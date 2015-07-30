<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="admin-cart.aspx.cs" Inherits="admin_cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section id="cart_items">
        <div class="container">

            <div class="table-responsive cart_info">
                <table class="table table-condensed">
                    <thead>
                        <tr class="cart_menu">
                            <td class="image" style="width: 295px">Customer</td>
                            <td class="description" style="width: 712px">Cart</td>
                            <td></td>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rpCustomer" runat="server" OnItemCommand="rpCustomer_ItemCommand">

                            <ItemTemplate>
                                <tr>
                                    <td class="cart_product">
                                        <h4>Name: <%#Eval("cus_name")%></h4>
                                        <p>
                                            Customer ID:<asp:Label ID="lblidcus" Text='<%#Eval("id_cus")%>' runat="server" />
                                        </p>
                                        <p>
                                            Email:
                                        <asp:Label ID="lblemail" Text='<%#Eval("email")%>' runat="server" />
                                        </p>
                                    </td>
                                    <td class="cart_description">
                                        <asp:Repeater ID="rpCart" runat="server" DataSource='<%#Eval("carts") %>'>
                                            <ItemTemplate>
                                                <h4>ID Cart: <%#Eval("id_cart")%> | Time: <%#Eval("time_cart")%> </h4>
                                                <br />
                                                <table class="table table-condensed">
                                                    <thead>
                                                        <tr class="cart_menu">
                                                            <td class="image">Detail ID</td>
                                                            <td class="description">Product ID</td>
                                                            <td class="description">Quanlity</td>
                                                            <td class="description">Total Price</td>
                                                        </tr>
                                                    </thead>
                                                    <tbody>

                                                        <asp:Repeater ID="rpDetail" runat="server" DataSource='<%#Eval("detail_carts") %>'>
                                                            <ItemTemplate>
                                                                <tr>
                                                                    <td class="cart_product">
                                                                        <%#Eval("id_dtcart")%>
                                                                    </td>
                                                                    <td class="description">
                                                                        <%#Eval("id_pro")%>
                                                                    </td>
                                                                    <td class="cart_product">
                                                                        <%#Eval("quanlity")%>
                                                                    </td>
                                                                    <td class="description">
                                                                        <%#Eval("TTprice")%>
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                        </asp:Repeater>
                                                    </tbody>
                                                </table>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </td>
                                    <td class="cart_delete">
                                        <div class="cart_quantity_delete">
                                            <asp:LinkButton runat="server" CommandArgument='<%#Eval("id_cus") %>' CommandName="ghDel" OnCommand="Unnamed_Command"><i class="fa fa-times"></i></asp:LinkButton>
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

</asp:Content>

