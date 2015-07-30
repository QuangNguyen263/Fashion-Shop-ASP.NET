using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_cart : System.Web.UI.Page
{
    Responsitory rp = new Responsitory();
    List<cust> lc;
    cust ctm;
    cart ca;
    detail_cart dtca;
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
                load_cus();
            }
        }
       
        
    }
    public void load_cus(){
        lc = rp.getAllCustomer();
        rpCustomer.DataSource = lc;
        rpCustomer.DataBind();
    }
    public void del_cus()
    {

    }
    protected void Unnamed_Command(object sender, CommandEventArgs e)
    {
      
    }
    protected void rpCustomer_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "ghDel")
        {
            foreach (RepeaterItem it in rpCustomer.Items)
            {
                Label n1 = (Label)it.FindControl("lblidcus");
                if (n1.Text == e.CommandArgument.ToString())
                {
                    int n = Convert.ToInt32(n1.Text);
                    List<cart> lca = rp.getCustomerCart(n);
                    foreach (cart cartzz in lca)
                    {
                        List<detail_cart> ldtca = rp.getDetailCartID(cartzz.id_cart);
                        foreach (detail_cart dtca in ldtca)
                        {
                            rp.DeletedtCart(dtca.id_dtcart);
                           
                        }
                        rp.DeleteCart(cartzz.id_cart);
                       
                    }
                    if (rp.DeleteCustomer(n))
                    {
                        load_cus();
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Delete Complete')", true);
           
                        break;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Delete Fail')", true);
           
                    }

                }

            }
        }
    }
}