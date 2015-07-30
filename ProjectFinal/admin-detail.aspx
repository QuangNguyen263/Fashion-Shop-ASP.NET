<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="admin-detail.aspx.cs" Inherits="admin_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section>
        <div class="container">
            <div class="row">
                <div class="col-sm-3">
               
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
                                                    <asp:Label ID="lblIDIMG" Text='<%#Eval("id_img") %>' runat="server" Visible="False" />
                                                    <div style="margin-left:15%">
                                                       <asp:FileUpload ID="FileUpload1"  runat="server" Width="360px" Height="27px" AllowMultiple="true"   />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUpload1" Display="None" ErrorMessage="Bạn cần chọn một tệp ảnh trước khi ấn nút &quot;Upload&quot;"></asp:RequiredFieldValidator>  
                                                    </div>
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
                                <br/>
                               <span><b>Add More Images: </b></span> <asp:FileUpload  ID="FileUploadMore" runat="server" Width="348px" Height="27px" AllowMultiple="true" />

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FileUploadMore" Display="None" ErrorMessage="Bạn cần chọn một tệp ảnh trước khi ấn nút &quot;Upload&quot;"></asp:RequiredFieldValidator>
                            </div>
                        

                        </div>
                        <div class="col-sm-7">
                            <div class="product-information">
                                <!--/product-information-->
                                <img src="images/product-details/new.jpg" class="newarrival" alt="" />
                                <h2>
                                    <asp:Textbox runat="server" ID="txtName" Width="244px" /></h2>
                                <p>Product ID in Shop:
                                    <asp:Label runat="server" ID="lblID" Width="121px" /></p>
                              
                                 <asp:DropDownList ID="drCate" runat="server" Width="244px" OnSelectedIndexChanged="drCate_SelectedIndexChanged" > 
                           
                        </asp:DropDownList>
                                <br />
                                <br />
                                <img src="images/product-details/rating.png" alt="" /><br/>
								
                                 <span> $</span> <asp:Textbox runat="server" ID="txtPrice" Width="232px" ></asp:Textbox>
                                <br />
                                <br />
                                    
                                    <div  class="btn btn-fefault cart" >
                                    <asp:LinkButton CommandName="atc" runat="server" OnCommand="Unnamed_Command" OnClientClick="javascript:document.forms[0].encoding = 'multipart/form-data';"><i class="fa fa-edit"></i>
                                        Update</asp:LinkButton></div>
                                   
                            </div>
                            <!--/product-information-->
                        </div>
                    </div>
                    <!--/product-details-->
                </div>
        </div>
        </div>
    </section>
</asp:Content>

