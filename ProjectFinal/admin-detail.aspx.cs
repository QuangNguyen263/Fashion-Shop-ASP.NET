using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_detail : System.Web.UI.Page
{
    Responsitory rp = new Responsitory();
    List<cat> cate_list;
    cat ca;
    img_prod ip1;      
    CheckE ck = new CheckE();
    static prod p;
    int idCate;
    int id;
    int tam = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("404.html");
            }
            else
            {
                ViewState["bf"] = 0;
                load_pro();
                loadCate();
            }
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
        p = rp.getProduct(id);
        lblID.Text = p.id_pro + "";
        txtName.Text = p.pro_name;
        txtPrice.Text = p.pro_price + "";
        idCate = p.id_cat;
        Repeater3.DataSource = p.img_prods;
        Repeater3.DataBind();
    }
    public void loadCate()
    {
        cate_list = rp.getAllCate();
        drCate.DataSource = cate_list;
        drCate.DataTextField = "cat_name";
        drCate.DataValueField = "id_cat";
        drCate.DataBind();
        drCate.SelectedValue = p.id_cat.ToString();
    }
    public void ud()
    {
        foreach (RepeaterItem i in Repeater3.Items)
        {
            FileUpload fu = (FileUpload)i.FindControl("FileUpload1");
            Label lbl = (Label)i.FindControl("lblIDIMG");
            if (fu.HasFile)
            {
                if (!ck.CheckFileType(fu.FileName))
                {
                    tam = 1;
                    break;
                }
            }
        }
        if (FileUploadMore.HasFile)
        {
            foreach (var file1 in FileUploadMore.PostedFiles)
            {
                if (!ck.CheckFileType(file1.FileName))
                {
                    tam = 1;
                    break;
                }
            }
         
        }
        if (tam == 0)
        {
            foreach (RepeaterItem i in Repeater3.Items)
            {
                FileUpload fu = (FileUpload)i.FindControl("FileUpload1");
                Label lbl = (Label)i.FindControl("lblIDIMG");
                if (fu.HasFile)
                {
                    
                        int n111 = Convert.ToInt32(lbl.Text);
                        string fileName = "images/home/" + fu.FileName;
                        string filePath = MapPath(fileName);
                        fu.SaveAs(filePath);
                        img_prod ima = rp.getImage(n111);
                        ima.img_url = fu.FileName;
                        rp.UpdateimgProd(ima);
                  
                }
            }
            if (FileUploadMore.HasFile)
            {
                foreach (var file1 in FileUploadMore.PostedFiles)
                {
                    string fileName = "images/home/" + file1.FileName;
                    string filePath = MapPath(fileName);
                    file1.SaveAs(filePath);
                    ip1 = new img_prod();
                    ip1.id_prod = p.id_pro;
                    ip1.img_url = file1.FileName;
                    rp.AddimgProd(ip1);
                }

            }

            if ((int)ViewState["bf"] == 1)
            {
                p.id_cat = idCate;
                ViewState["bf"] = 0;
            }
            if (ck.checkstringnull(txtName.Text.Trim()))
            {
                if (ck.checkstringnull(txtPrice.Text.Trim()))
                {
                    if (ck.checknumber(txtPrice.Text.Trim()))
                    {
                        if (ck.checkstring(txtName.Text.Trim(), 50))
                        {
                            if (p.pro_name == txtName.Text.Trim())
                            {
                                p.pro_name = txtName.Text.Trim();
                                p.pro_price = float.Parse(txtPrice.Text.Trim());
                                rp.UpdateProduct(p);
                                load_pro();
                            }
                            else
                            {
                                if (rp.checkalprod(txtName.Text.Trim()))
                                {
                                    p.pro_name = txtName.Text.Trim();
                                    p.pro_price = float.Parse(txtPrice.Text.Trim());
                                    rp.UpdateProduct(p);
                                    load_pro();
                                }
                                else
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Product Name Already Exist')", true);

                                }
                            }
                            
                           
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Product Name Too Long')", true);

                        }

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Product Price Is Incorrect')", true);

                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Type Product Price')", true);

                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Type Product Name')", true);

            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Many Images Too Large Or Not Format(.jpg|.png|.gif)')", true);
            load_pro();
            loadCate();
        }
       
      
    }
    protected void drCate_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["bf"] = 1;
        idCate = Convert.ToInt32(drCate.SelectedItem.Value);
    }
    protected void Unnamed_Command(object sender, CommandEventArgs e)
    {
        ud();
    }
}