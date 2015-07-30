<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<%@ MasterType VirtualPath="~/MasterPage.master" %>
<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section id="slider">
        <!--slider-->
        <div class="container">
            <div class="row">

                <div class="col-sm-12">
                    <div id="slider-carousel" class="carousel slide" data-ride="carousel">
                        <ol class="carousel-indicators">
                            <li data-target="#slider-carousel" data-slide-to="0" class="active"></li>
                            <li data-target="#slider-carousel" data-slide-to="1"></li>
                            <li data-target="#slider-carousel" data-slide-to="2"></li>
                        </ol>
                        <div class="carousel-inner">
                            <div class="item active">
                                <div class="col-sm-6">
                                    <h1><span>E</span>-SHOPPER</h1>
                                    <h2>Bring You To Best Choise</h2>
                                    <p>High Quality - Low Price</p>
                                    <button type="button" class="btn btn-default get"><a href="index.aspx" >Get it now</a></button>
                                </div>
                                <div class="col-sm-6">
                                    <img src="images/home/girl1.jpg" class="girl img-responsive" alt="" />
                                    <img src="images/home/pricing.png" class="pricing" alt="" />
                                </div>
                            </div>
                            <div class="item">
                                <div class="col-sm-6">
                                    <h1><span>E</span>-SHOPPER</h1>
                                    <h2>Perfect Week</h2>
                                    <p>Super Sold All Product! Come And Get It! </p>
                                    <button type="button" class="btn btn-default get"><a href="index.aspx" >Get it now</a></button>
                                </div>
                                <div class="col-sm-6">
                                    <img src="images/home/girl2.jpg" class="girl img-responsive" alt="" />
                                    <img src="images/home/pricing.png" class="pricing" alt="" />
                                </div>
                            </div>
                            <div class="item">
                                <div class="col-sm-6">
                                    <h1><span>E</span>-SHOPPER</h1>
                                    <h2>Smart Choise</h2>
                                    <p>Easy Buy, Easy Pay ... Easy Choise </p>
                                    <button type="button" class="btn btn-default get"><a href="index.aspx" >Get it now</a></button>
                                </div>
                                <div class="col-sm-6">
                                    <img src="images/home/girl3.jpg" class="girl img-responsive" alt="" />
                                    <img src="images/home/pricing.png" class="pricing" alt="" />
                                </div>
                            </div>
                        </div>
                        <a href="#slider-carousel" class="left control-carousel hidden-xs" data-slide="prev">
                            <i class="fa fa-angle-left"></i>
                        </a>
                        <a href="#slider-carousel" class="right control-carousel hidden-xs" data-slide="next">
                            <i class="fa fa-angle-right"></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--/slider-->
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
                                                <asp:LinkButton ID="linkc" Text='<%#Eval("cat_name") %>' CommandArgument='<%#Eval("id_cat") %>' CommandName="linkCate" runat="server" OnCommand="Unnamed_Command" /></h4>
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
                                                        <%--<img src="images/home/<%#Eval("imgMPro") %>" alt="" style="height: 250px" />--%>
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

                                                    <asp:LinkButton CommandArgument='<%#Eval("idMPro")%>' class="btn btn-default add-to-cart" ID="LinkButton2" runat="server" OnCommand="LinkButton2_Command"><i class="fa fa-shopping-cart"></i>Detail</asp:LinkButton>

                                                    <asp:LinkButton CommandArgument='<%#Eval("idMPro")%>' class="btn btn-default add-to-cart" ID="LinkButton3" runat="server" OnCommand="LinkButton3_Command"><i class="fa fa-shopping-cart"></i>Add To Cart</asp:LinkButton>


                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>


                    </div>
                    <div style="text-align: center; margin-bottom: 5%">
                        <cc1:CollectionPager ID="CollectionPager1" runat="server" ShowPageNumbers="True" PageNumbersDisplay="Numbers" BackNextDisplay="Buttons" ResultsLocation="Bottom" ResultsStyle="display:none" LabelText="Trang" ShowLabel="False" NextText="Next" BackText="Back" ShowFirstLast="False" BackNextLocation="Split" PageNumbersStyle="margin:2%;"></cc1:CollectionPager>
                    </div>
                    <div class="category-tab">
                        <h2 class="title text-center">Super Sold</h2>
                        <!--category-tab-->
                        <div class="col-sm-12">
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <div class="col-sm-3">
                                        <div class="product-image-wrapper">
                                            <div class="single-products">
                                                <div class="productinfo text-center">
                                                    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                                                        <!-- Indicators -->
                                                        <!-- Wrapper for slides -->
                                                        <div class="carousel-inner ">
                                                            <asp:Repeater ID="Repeater2" runat="server" DataSource='<%#Eval("img_prods") %>'>
                                                                <ItemTemplate>
                                                                    <div class='item <%# Container.ItemIndex == 0 ? "active" : "" %>'>
                                                                        <%--<img id="imgsold" src="images/home/<%#Eval("img_url") %>" alt="" style="height: 150px; margin: 0px !important; " />--%>
                                                                        <asp:Image ID="imghang2" ImageUrl='<%#Eval("img_url", "images/home/{0}") %>' runat="server" Style="height: 150px; margin: 0px !important;" />
                                                                    </div>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </div>
                                                        <!-- Controls -->
                                                    </div>
                                                    <h2>$
                                                        <asp:Label ID="giaSP" runat="server" Text='<%#Eval("pro_price")%>' /></h2>
                                                    <p>
                                                        ID in Shop: 
                                                        <asp:Label ID="idSP" runat="server" Text='<%#Eval("id_pro")%>' />
                                                    </p>
                                                    <p>
                                                        <asp:Label ID="nameSP" runat="server" Text='<%#Eval("pro_name")%>'></asp:Label>
                                                    </p>
                                                    <div class="btn btn-default add-to-cart">
                                                        <asp:LinkButton CommandName="atc1" CommandArgument='<%#Eval("id_pro")%>' OnCommand="Unnamed_Command1" runat="server"><i class="fa fa-shopping-cart"></i>
                                                     Add to cart</asp:LinkButton>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <!--/category-tab-->
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>