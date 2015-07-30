<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="product-details.aspx.cs" Inherits="product_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                    <div class="product-details">
                        <!--product-details-->
                        <div class="col-sm-5">
                            <div class="view-product">
                                <div id="carousel-example-generic1" class="carousel slide" data-ride="carousel">
                                    <!-- Indicators -->
                                    <!-- Wrapper for slides -->
                                    <div class="carousel-inner ">
                                        <asp:Repeater ID="Repeater3" runat="server">
                                            <ItemTemplate>
                                                <div class='item <%# Container.ItemIndex == 0 ? "active" : "" %>'>
                                                    <img id="imgsold" src="images/home/<%#Eval("img_url") %>" alt="" style="height:300px;margin: 0px !important;" />
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                    <!-- Controls -->
                                    <a class="left carousel-control" href="#carousel-example-generic1" role="button" data-slide="prev">
                                        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                                        <span class="sr-only">Previous</span>
                                    </a>
                                    <a class="right carousel-control" href="#carousel-example-generic1" role="button" data-slide="next">
                                        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                                        <span class="sr-only">Next</span>
                                    </a>

                                </div>
                            </div>


                        </div>
                        <div class="col-sm-7">
                            <div class="product-information">
                                <!--/product-information-->
                                <img src="images/product-details/new.jpg" class="newarrival" alt="" />
                                <h2>
                                    <asp:Label runat="server" ID="lblName" /></h2>
                                <p>
                                    Product ID in Shop:
                                    <asp:Label runat="server" ID="lblID" />
                                </p>
                                <img src="images/product-details/rating.png" alt="" /><br />
                                <span>
                                    <span>$</span>
                                    <asp:Label runat="server" ID="lblPrice"></asp:Label>

                                    <div class="btn btn-fefault cart">
                                        <asp:LinkButton CommandName="atc" OnCommand="Unnamed_Command" runat="server"><i class="fa fa-shopping-cart"></i>
                                        Add to cart</asp:LinkButton>
                                    </div>

                                </span>
                                <p><b>Availability:</b> In Stock</p>
                                <p><b>Condition:</b> New</p>
                               
                                    <img src="images/product-details/share.png" class="share img-responsive" alt="" />
                            </div>
                            <!--/product-information-->
                        </div>
                    </div>
                    <!--/product-details-->
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
                                                                        <img id="imgsold" src="images/home/<%#Eval("img_url") %>" alt="" style="height: 150px; margin: 0px !important;" />
                                                                    </div>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </div>

                                                        <!-- Controls -->

                                                    </div>
                                                    <%--<asp:Image ID="imgSP" ImageUrl='getImage( images/home/<%#Eval("pro_img"))%>' runat="server" />--%>
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

