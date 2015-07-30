<%@ Page Title="" Language="C#"  EnableEventValidation="false" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <section id="form1">
        <!--form-->
        <div class="container">
            <div class="row">
                <h1>Category</h1>
                <div class="col-sm-12">
                    <div class="signup-form">
                        <!--sign up form-->
                        <h2>New Category</h2>

                        <asp:TextBox ID="tbCate" runat="server" placeholder="Category Name" />
                        <br/>
                            <br/>

                            <asp:Button Text="Add"  runat="server" ID="addCate" OnClick="addCate_Click" class="btn btn-warning"></asp:Button>
                        
                        <br/>
                            <br/>

                    </div>
                    <div class="signup-form">
                     
                    
                    <!--/sign up form-->
                     <div class="table-responsive cart_info">
                         <h2>Category List</h2>
                	<table class="table table-condensed">
					<thead>
						<tr class="cart_menu">
							<td class="image"><h4>ID</h4> </td>
							<td class="image"> <h4>Category</h4></td>
							<td class="image"><h4>Option</h4></td>
						</tr>
					</thead>
					<tbody>
                     <asp:Repeater ID="repCate" runat="server" >
                            <ItemTemplate>
						<tr>
							
							<td class="cart_description">
								<h4><asp:Label ID="lblidCat" Text=' <%#Eval("id_cat") %>' runat="server" /></h4>
									</td>
							
							<td class="cart_quantity" style="width:400px">
								<div class="cart_quantity_button">
                                    <div class="cart_quantity_input">
                                        <asp:TextBox ID="txtCateName" runat="server" Text='<%#Eval("cat_name")%>' required="true" />  

                                    </div>
                  
								</div>
							</td>
						
							<td class="cart_delete">
                                <div class="cart_quantity_delete" >
                                 <asp:LinkButton runat="server" CommandName="ghUpdate" CommandArgument='<%#Eval("id_cat")%>' OnCommand="Unnamed_Command" ToolTip="Update" ><i class="fa fa-refresh"></i></asp:LinkButton>
                                 <asp:LinkButton runat="server" CommandName="ghDel" CommandArgument='<%#Eval("id_cat")%>' OnCommand="del_Command" ToolTip="delete" ><i class="fa fa-times"></i></asp:LinkButton>
								</div>
							</td>
						</tr>
                         </ItemTemplate>
                </asp:Repeater>
					</tbody>
				</table>
            </div>

</div>

            </div>
        </div>
    </section>
  
    <!--/form-->
</asp:Content>

