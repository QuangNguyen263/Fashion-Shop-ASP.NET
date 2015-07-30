using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    Responsitory rp = new Responsitory();
    CheckE ck = new CheckE();
    static user_name un;
    int idus;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["login"] == null)
            {
                lbtnUser.Visible = false;
                lbtncart.Visible = true;
                lbtnlogin.Visible = true;
                lblAdmin.Visible = false;
                lbtnlog.Visible = false;
                lbtnCate.Visible = false;
                lbtnProd.Visible = false;
                lbtnCartzz.Visible = false;
            }
            else
            {
                idus = Convert.ToInt32(Session["Login"]);
                un = rp.getUserbyID(idus);
                lblUser.Text = un.usFulname;
                imgav.ImageUrl = "images/Userimg/" + un.usImg;
                lbtnUser.Visible = true;
                lbtncart.Visible = false;
                lbtnlogin.Visible = false;
                lblAdmin.Visible = true;
                lbtnlog.Visible = true;
                lbtnCate.Visible = true;
                lbtnProd.Visible = true;
                lbtnCartzz.Visible = true;
            }
        }
        
    }

    protected void Unnamed_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("cartzz.aspx");
    }
    protected void Unnamed_Command1(object sender, CommandEventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void Unnamed_Command2(object sender, CommandEventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
    protected void Unnamed_Command3(object sender, CommandEventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Unnamed_Command4(object sender, CommandEventArgs e)
    {
        Session["login"] = null;
        Response.Redirect("Default.aspx");
    }
    protected void lbtnCate_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
    protected void lbtnProd_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("admin-product.aspx");
    }
    protected void lbtnCartzz_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("admin-cart.aspx");
    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string res = txtSearch.Text.Trim();
        if (ck.checkstringnull(res))
        {
            Response.Redirect("search.aspx?result=" + res);
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
        
    }
    protected void lbtnUser_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("admin-person.aspx?id=" + un.id_user);
    }
}
