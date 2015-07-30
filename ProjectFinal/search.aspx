<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="advertisement">
        <div class="container">
            <img src="images/shop/advertisement.jpg" alt="" />
        </div>
    </section>

    <section>

        <div class="container">
            <div class="row">
                <div class="col-sm-3">
                    <div class="left-sidebar">
                        <h2>Category</h2>
                        <div class="panel-group category-products" id="accordian">
                            <!--category-productsr-->
                            <asp:Repeater runat="server" ID="repCate">
                                <ItemTemplate>
                                    <div class="panel panel-default">
                                        <div class="panel-heading">
                                            <h4 class="panel-title">
                                                <asp:LinkButton ID="linkc" Text='<%#Eval("cat_name") %>' CommandArgument='<%#Eval("id_cat") %>' CommandName="linkCate" runat="server" OnCommand="linkc_Command" /></h4>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <!--/category-products-->

                        <div class="shipping text-center">
                            <!--shipping-->
                            <img src="images/home/shipping.jpg" alt="" />
                        </div>
                        <!--/shipping-->

                    </div>
                </div>

                <div class="col-sm-9 padding-right">
                    <div class="features_items">
                        <!--features_items-->
                        <h2 class="title text-center">Features Items</h2>
                        <asp:Repeater ID="rep" runat="server">
                            <ItemTemplate>
                                <div class="col-sm-4">

                                    <div class="product-image-wrapper">
                                        <div class="single-products">

                                            <div class="productinfo text-center">

                                                <asp:Image ID="imghang" ImageUrl='<%#Eval("imgMPro", "images/home/{0}") %>' runat="server" Style="height: 250px" />
                                                <h2>$<asp:Label ID="lblPrice" Text='<%#Eval("priceMPro")%>' runat="server" /></h2>
                                                <asp:Label ID="lblid" Text='<%#Eval("idMPro")%>' runat="server" Visible="false" />
                                                <p>
                                                    <asp:Label ID="lblName" Text='<%#Eval("nameMPro")%>' runat="server" />
                                                </p>

                                            </div>
                                            <div class="product-overlay">
                                                <div class="overlay-content">
                                                    <h2>$<%#Eval("priceMPro") %></h2>
                                                    <p><%#Eval("nameMPro") %></p>

                                                    <asp:LinkButton CommandArgument='<%#Eval("idMPro")%>' class="btn btn-default add-to-cart" ID="LinkButton2" runat="server" OnCommand="LinkButton2_Command1"><i class="fa fa-shopping-cart"></i>Detail</asp:LinkButton>
                                                    <asp:LinkButton CommandArgument='<%#Eval("idMPro")%>' class="btn btn-default add-to-cart" ID="LinkButton3" runat="server" OnCommand="LinkButton3_Command"><i class="fa fa-shopping-cart"></i>Add To Cart</asp:LinkButton>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                        </div>
                    </div>
                    <div style="text-align: center; margin-bottom: 5%">
                        <cc1:CollectionPager ID="CollectionPager1" runat="server" ShowPageNumbers="True" PageNumbersDisplay="Numbers" BackNextDisplay="Buttons" ResultsLocation="Bottom" ResultsStyle="display:none" LabelText="Trang" ShowLabel="False" NextText="Next" BackText="Back" ShowFirstLast="False" BackNextLocation="Split" PageNumbersStyle="margin:2%;"></cc1:CollectionPager>
                    </div>
    </section>
</asp:Content>

