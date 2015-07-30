using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cartzz : System.Web.UI.Page
{
    Responsitory rp = new Responsitory();
    cust c;
    cart cartss;
    detail_cart dc;
    CheckE ck = new CheckE();
    static DataTable tbGioHang = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            load_data();
        }
      
    }
    private void load_data()
    {
      
        if (Session["GioHang"] == null || (Session["GioHang"] as DataTable).Rows.Count==0)
        {
            Response.Redirect("GioHangRong.aspx");
        }
        tbGioHang = (DataTable)Session["GioHang"];
        string strnumber = tbGioHang.Compute("Sum(TongTien)", "").ToString();
        rpGioHang.DataSource = tbGioHang;
        rpGioHang.DataBind();
    }
    private void del_data(string ms)
    {
        string n = ms;
        DataTable ca = Session["GioHang"] as DataTable;
        foreach (RepeaterItem it in rpGioHang.Items)
        {
           
            Label n1 = (Label)it.FindControl("lblID");
            if (n1.Text == ms)
            {
                foreach (DataRow dr in ca.Rows)
                {
                    if (dr["idsp"].ToString() == ms)
                    {
                        dr.Delete();
                        break;
                    }
                }
            }
        }
        Session["GioHang"] = ca;
        load_data();
    }
    private void ud_data(string ms){
        DataTable ca = Session["GioHang"] as DataTable;
        foreach (RepeaterItem it in rpGioHang.Items)
        {
            Label n1 = (Label)it.FindControl("lblID");
           
            if (n1.Text == ms)
            {
                foreach (DataRow dr in ca.Rows)
                {
                    TextBox n2 = (TextBox)it.FindControl("tbSL");
                    if (dr["idsp"].ToString() == ms)
                    {
                        if (ck.checkstringnull(n2.Text))
                        {
                            if (ck.checkQuanlity(n2.Text))
                            {
                                dr["SoLuong"] = int.Parse(n2.Text);
                                break;
                            }
                            else
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Quanlity Is Incorrect')", true);
                            }
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Type Quanlity')", true);
                    
                        }
                    }
                }
            }
        }
        Session["GioHang"] = ca;
        load_data();
    }
    protected void Unnamed_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "ghDel")
        {
            del_data(e.CommandArgument.ToString());
        }
        
    }
    protected void Unnamed_Command1(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "ghUpdate")
        {
            ud_data(e.CommandArgument.ToString());
        }
    }
    public bool add_cus()
    {
        string cname = txtCusName.Text;
        string cemail = txtEmail.Text;
        if (ck.checkstringnull(cname))
        {
            if (ck.checkstringnull(cemail))
            {
                if (ck.checkEmail(cemail))
                {
                    if (ck.checkstring(cemail, 100))
                    {
                        if (ck.checkstring(cname, 50))
                        {
                            int n = rp.checkCus(cname, cemail);
                            if (n==-1)
                            {
                                c = new cust();
                                c.cus_name = cname;
                                c.email = cemail;
                                rp.AddCustomer(c);
                            }
                            else
                            {
                                c = rp.getCusbyID(n);
                            }
                            return true;
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Your Name Too Long')", true);
                   
                            return false;
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Your Email Too Long')", true);
                   
                        return false;
                    }
                 
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Your Email Is Incorrect')", true);
                    return false;
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Type Your Email')", true);
                return false;
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Type Your Name')", true);
            return false;    
        }
       
        
    }
    public void add_cart()
    {
        if (c != null)
        {
            cartss = new cart();
            cartss.id_cus = c.id_cus;
            cartss.time_cart = DateTime.Now;
            rp.AddCart(cartss);
        }
    }
    public void add_dtCart()
    {
        if (cartss != null)
        {
            DataTable ca = Session["GioHang"] as DataTable;

            foreach (RepeaterItem it in rpGioHang.Items)
            {
                Label n1 = (Label)it.FindControl("lblID");
                TextBox n2 = (TextBox)it.FindControl("tbSL");
                Label n3 = (Label)it.FindControl("lblTT");
                dc = new detail_cart();
                dc.id_cart = cartss.id_cart;
                dc.id_pro = Convert.ToInt32(n1.Text);
                dc.quanlity = Convert.ToInt32(n2.Text);
                dc.TTprice = float.Parse(n3.Text);
                rp.AdddtCart(dc);
                }
            }
        }
    protected void Unnamed_Command2(object sender, CommandEventArgs e)
    {
        if (add_cus())
        {
            add_cart();
            add_dtCart();
            Response.Redirect("checkout.aspx");
           
        }
      
    }
}