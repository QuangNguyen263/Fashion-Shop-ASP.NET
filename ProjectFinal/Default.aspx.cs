using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    Responsitory rp = new Responsitory();
    List<mainIMGPro> prim;
    List<prod> list_product;
    List<cat> cate_list;
    static DataTable tbGioHang = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
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
            load_Prod();
            loadCate();

        }
       

    }
    public void loadCate()
    {
        cate_list = rp.getAllCate();

        repCate.DataSource = cate_list;
        repCate.DataBind();
    }
    public void load_Prod()
    {

        prim = rp.getMainProduct();
        //rep.DataSource = prim;
        //rep.DataBind();
        list_product = rp.getTopProduct(4);
        Repeater1.DataSource = list_product;
        Repeater1.DataBind();
        CollectionPager1.PageSize = 12;
        CollectionPager1.DataSource = prim;
        CollectionPager1.BindToControl = rep;
        rep.DataSource = CollectionPager1.DataSourcePaged;
        rep.DataBind();
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
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        int n = Convert.ToInt32(e.CommandArgument);
        Response.Redirect("product-details.aspx?id=" + n);
    }
    protected void LinkButton3_Command(object sender, CommandEventArgs e)
    {
        foreach (RepeaterItem it in rep.Items)
        {
            Label n1 = (Label)it.FindControl("lblid");
            Label n2 = (Label)it.FindControl("lblName");
            Label n3 = (Label)it.FindControl("lblPrice");
            Image n4 = (Image)it.FindControl("imghang");
            if (n1.Text == e.CommandArgument.ToString())
            {
                int idSP = Convert.ToInt32(n1.Text);
                string strTenSP = n2.Text;
                float giaSP = float.Parse(n3.Text);
                int intSoLuong = 1;
                string imghangzz = n4.ImageUrl;
                addtoGIOHANG(idSP, imghangzz, strTenSP, giaSP, intSoLuong);
                
            }

        }
        load_Prod();
       
    }
    protected void Unnamed_Command(object sender, CommandEventArgs e)
    {
        int n = Convert.ToInt32(e.CommandArgument);
        Response.Redirect("shop.aspx?id=" + n);
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
        load_Prod();
    }
}