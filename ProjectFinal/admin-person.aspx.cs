using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_person : System.Web.UI.Page
{
    CheckE ck = new CheckE();
    Responsitory rp = new Responsitory();
    static user_name un;
    int idus;
    protected void Page_Load(object sender, EventArgs e)
    {
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
        {
            Path = "~/scripts/jquery-1.4.1.min.js",
            DebugPath = "~/scripts/jquery-1.4.1.js",
            CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.min.js",
            CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.js"
        });
       
            if (!IsPostBack)
            {
                if (Session["login"] == null)
                {
                    Response.Redirect("404.html");
                }
                else
                {
                    load_us();
                }
            
            }
    }
    public void load_us()
    {
        if (ck.checkQuanlity(Request.QueryString["id"]))
        {
            idus = Convert.ToInt32(Request.QueryString["id"]);
            un = rp.getUserbyID(idus);
            txtName.Text = un.usFulname;
            txtAge.Text = un.usAge + "";
            txtEmail.Text = un.email;
            lblUsname.Text = un.user_name1;
            imgava.ImageUrl = "images/Userimg/" + un.usImg;
        }
        else
        {
            Response.Redirect("404.html");
        }
    }
    protected void Unnamed_Command(object sender, CommandEventArgs e)
    {
        if (ck.checkstringnull(txtName.Text) && ck.checkstringnull(txtAge.Text) && ck.checkstringnull(txtEmail.Text))
        {
            if (ck.checkQuanlity(txtAge.Text.Trim()))
            {
                if (ck.checkEmail(txtEmail.Text))
                {
                   
                        if (FileUpload1.HasFile)
                        {
                            if (ck.CheckFileType(FileUpload1.FileName))
                            {
                                string fileName = "images/Userimg/" + FileUpload1.FileName;
                                string filePath = MapPath(fileName);
                                FileUpload1.SaveAs(filePath);
                                un.usImg = FileUpload1.FileName;
                            }
                            else
                            {
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Your Image Is Too Large Or Not Format(.jpg|.png|.gif)')", true);
                                load_us();
           
                            }
                           
                        }
                            un.usFulname = txtName.Text.Trim();
                            un.usAge = Convert.ToInt32(txtAge.Text.Trim());
                            un.email = txtEmail.Text.Trim();
                        rp.UpdateUser(un);
                        load_us();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email Is Incorrect')", true);
           
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Age Is Incorrect')", true);
           
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Type Full Information ')", true);
           
        }
    }
    protected void Unnamed_Command1(object sender, CommandEventArgs e)
    {
        if (ck.checkstringnull(txtPassword.Text.Trim()) && ck.checkstringnull(txtrepass.Text.Trim()))
        {
            if (txtPassword.Text.Trim() == txtrepass.Text.Trim())
            {
                un.password = txtPassword.Text.Trim();
                rp.UpdateUserPass(un);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Change Password Complete! ')", true);
                load_us();
                lbtnshpa.Visible = true;
                txtPassword.Visible = false;
                txtrepass.Visible = false;
                lbtnCpa.Visible = false;

           
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Passwords Do Not Match ')", true);
           
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Type Password And Confirm Password ')", true);
           
        }
    }
    protected void Unnamed_Command2(object sender, CommandEventArgs e)
    {
        txtPassword.Visible = true;
        txtrepass.Visible = true;
        lbtnCpa.Visible = true;
        lbtnshpa.Visible = false;
    }
}