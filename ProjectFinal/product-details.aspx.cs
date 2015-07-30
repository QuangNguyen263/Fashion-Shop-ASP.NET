using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product_detail : System.Web.UI.Page
{
    Responsitory rp = new Responsitory();
    List<prod> product_list, product_list2;
    List<cat> cate_list;
    CheckE ck = new CheckE();
    int id = 0;
    static DataTable tbGioHang = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            if (Session["GioHang"] != null)
            {
                tbGioHang = Session["GioHang"] as DataTable;
            }
            else
            {
                tbGioHang.Rows.Clear();
                tbGioHang.Columns.Clear();
                tbGioHang.Columns.Add("idSP", typeof(int));
                tbGioHang.Columns.Add("imgSP", typeof(string));
                tbGioHang.Columns.Add("TenSP", typeof(string));
                tbGioHang.Columns.Add("Gia", typeof(float));
                tbGioHang.Columns.Add("SoLuong", typeof(int));
                tbGioHang.Columns.Add("TongTien", typeof(double), "SoLuong * Gia");
            }
            load_pro();
            loadCate();
        }
    }
    public void load_pro()
    {
        if (ck.checkQuanlity(Request.QueryString["id"]))
        {

            id = Convert.ToInt32(Request.QueryString["id"]);
        }
        else
        {
            Response.Redirect("404.html");
        }
        prod p = rp.getProduct(id);
        lblID.Text = p.id_pro + "";
        lblName.Text = p.pro_name;
        lblPrice.Text = p.pro_price + "";
        Repeater3.DataSource = p.img_prods;
        Repeater3.DataBind();
        //imgav.ImageUrl = "images/home/" + p.pro_img;
        product_list = rp.getTopProduct(4);
        Repeater1.DataSource = product_list;
        Repeater1.DataBind();
    }
    public void loadCate()
    {
        cate_list = rp.getAllCate();
        repCate.DataSource = cate_list;
        repCate.DataBind();
    }
    protected void linkc_Command(object sender, CommandEventArgs e)
    {
        int n = Convert.ToInt32(e.CommandArgument);
        Response.Redirect("shop.aspx?id=" + n);
    }
    protected void Unnamed_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "atc")
        {
            int idSP = int.Parse(lblID.Text);
            string strTenSP = (lblName.Text);
            float flGia = float.Parse(lblPrice.Text);
            int intSoLuong = 1;
            //string imgh = imgav.ImageUrl.ToString();
            //Add vao gio hang
            addtoGIOHANG(idSP, null, strTenSP, flGia, intSoLuong);

        }

    }

    protected void Unnamed_Command1(object sender, CommandEventArgs e)
    {
        foreach (RepeaterItem it in Repeater1.Items)
        {
            Label n1 = (Label)it.FindControl("idSP");
            Label n2 = (Label)it.FindControl("nameSP");
            Label n3 = (Label)it.FindControl("giaSP");
            if (n1.Text == e.CommandArgument.ToString())
            {
                int idSP = Convert.ToInt32(n1.Text);
                string strTenSP = n2.Text;
                float giaSP = float.Parse(n3.Text);
                int intSoLuong = 1;
                addtoGIOHANG(idSP, null, strTenSP, giaSP, intSoLuong);
            }

        }

    }
    public void addtoGIOHANG(int idSP, string imgh, string strTenSP, float flGia, int intSoLuong)
    {
        foreach (DataRow row in tbGioHang.Rows)
        {//Kiem tr neu mat hang da co roi thi tang so luong len 1
            if ((int)row["idSP"] == idSP)
            {
                row["SoLuong"] = (int)row["SoLuong"] + 1;
                goto GioHang;
            }
        }
        tbGioHang.Rows.Add(idSP, imgh, strTenSP, flGia, intSoLuong);
    GioHang:
        Session["GioHang"] = tbGioHang;

        Response.Write("<script>alert('Add Complete')</script>");
    }
}