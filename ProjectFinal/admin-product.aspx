<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admin-product.aspx.cs" Inherits="admin_product" %>

<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!--form-->

    <section id="form" style="margin-top: 0">
        <!--form-->
        <div class="container">
            <div class="row">
                <h1>Product</h1>
                <div class="col-sm-12">
                    <div class="signup-form">
                        <!--sign up form-->
                        <h2>New Product!</h2>
                        <asp:DropDownList ID="drCate" runat="server" Width="348px" OnSelectedIndexChanged="drCate_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:TextBox ID="tbName1" runat="server" placeholder="Name" />
                        <br />
                        <br />
                        <asp:TextBox ID="tbPrice1" runat="server" placeholder="Price" />
                        <br />
                        <br />
                        <asp:FileUpload runat="server"  id="FileU" AllowMultiple="true" onchange="ShowpImage(this);" />
                        <asp:RequiredFieldValidator ErrorMessage="Bạn cần chọn một tệp ảnh trước khi ấn nút &quot;Upload&quot;" ControlToValidate="FileU" runat="server" />
                        <asp:Image ID="imgS" runat="server" style="width:100px;height:100px"/>
                         <br />
          
                        <asp:Button Text="Add" runat="server" ID="btnAddPro" class="btn btn-warning" OnClick="btnAddPro_Click"></asp:Button>
                        <br />
                        <br />
                    </div>
                    <!--/sign up form-->
                </div>
                <asp:Repeater ID="grid_product" runat="server">
                    <ItemTemplate>
                        <div class="col-sm-3">
                            <div class="product-image-wrapper">
                                <div class="single-products">
                                    <div class="productinfo text-center">
                                        <img src="images/home/<%#Eval("imgMPro") %>" alt="" style="height: 250px" />
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
                                            <div class="btn btn-default add-to-cart">
                                                <asp:LinkButton ID="LinkButton2" CommandArgument='<%#Eval("idMPro")%>' CommandName="upcm" runat="server" OnCommand="udate_Command"><i class="fa fa-edit"></i>Update</asp:LinkButton>
                                            </div>
                                            <div class="btn btn-default add-to-cart">
                                                <asp:LinkButton ID="LinkButton3" CommandArgument='<%#Eval("idMPro")%>' CommandName="delcm" runat="server" OnCommand="del_Command"><i class="fa fa-times"></i>Delete</asp:LinkButton>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
             <div style="text-align: center; margin-bottom: 5%">
                    <cc1:collectionpager id="CollectionPager2" runat="server" showpagenumbers="True" pagenumbersdisplay="Numbers" backnextdisplay="Buttons" resultslocation="Bottom" resultsstyle="display:none" labeltext="Trang" showlabel="False" nexttext="Next" backtext="Back" showfirstlast="False" backnextlocation="Split" pagenumbersstyle="margin:2%;"></cc1:collectionpager>
                </div>
        </div>
    </section>
    <!--/form-->
</asp:Content>

