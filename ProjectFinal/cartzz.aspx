<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cartzz.aspx.cs" Inherits="cartzz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section id="cart_items">
        <div class="container">
            <div class="breadcrumbs">
                <ol class="breadcrumb">
                    <li><a href="#">Home</a></li>
                    <li class="active">Shopping Cart</li>
                </ol>
            </div>
            <div class="table-responsive cart_info">
                	<table class="table table-condensed">
					<thead>
						<tr class="cart_menu">
							<td class="image">Item</td>
							<td class="description"></td>
							<td class="price">Price</td>
							<td class="quantity">Quantity</td>
							<td class="total">Total</td>
							<td></td>
						</tr>
					</thead>
					<tbody>
                     <asp:Repeater ID="rpGioHang" runat="server" >
                
                            <ItemTemplate>
						<tr>
							<td class="cart_product">
								<img src="<%#Eval("imgSP") %>" alt="" style="height:150px;width:80px"/>
							</td>
							<td class="cart_description">
								<h4><p><%#Eval("TenSP")%></h4>
								<p>Product ID:<asp:Label ID="lblID" Text='<%#Eval("idSP")%>' runat="server" /> </p>
							</td>
							<td class="cart_price">
								<p><%#Eval("Gia") %></p>
							</td>
							<td class="cart_quantity">
								<div class="cart_quantity_button">
									<%--<a class="cart_quantity_up" href=""> + </a>--%>
                                    <div class="cart_quantity_input"><asp:TextBox ID="tbSL" runat="server" Text='<%#Eval("soluong")%>' />  </div>
                     <%--<input class="cart_quantity_input" type="text" name="quantity" value='<%#Eval("soluong") %>' autocomplete="off" size="2">         
									<a class="cart_quantity_down" href=""> - </a>--%>
								</div>
							</td>
							<td class="cart_total">
								<p class="cart_total_price">$<asp:Label ID="lblTT" Text='<%#Eval("TongTien") %>' runat="server" /></p>
							</td>
							<td class="cart_delete">
                                <div class="cart_quantity_delete" >
                                    <asp:LinkButton runat="server" CommandName="ghUpdate" CommandArgument='<%#Eval("idSP")%>' OnCommand="Unnamed_Command1" ToolTip="Update" ><i class="fa fa-refresh"></i></asp:LinkButton>
                                <asp:LinkButton runat="server" CommandName="ghDel" CommandArgument='<%#Eval("idSP")%>' OnCommand="Unnamed_Command" ToolTip="delete" ><i class="fa fa-times"></i></asp:LinkButton>
								</div>
							</td>
						</tr>
                         </ItemTemplate>
                </asp:Repeater>
					</tbody>
				</table>
            </div>
        </div>
    </section>
    <!--/#cart_items-->
    <section id="do_action">
        <div class="container">
            <div class="heading">
                <h3>Check Out You Choise!</h3>
                <p>Choose if you have a discount code or reward points you want to use or would like to estimate your delivery cost.</p>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    <div class="total_area">
                        <asp:TextBox ID="txtCusName" runat="server" placeholder="Type Your Name" required="true" />
                        <br />
                        <br />
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Type Your Email" required="true" />
                        <br />
                        <div class="btn btn-default check_out">
                            <asp:LinkButton CommandName="co" OnCommand="Unnamed_Command2" runat="server">Checkout</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>

