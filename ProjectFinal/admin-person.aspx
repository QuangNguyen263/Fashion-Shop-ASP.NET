<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="~/admin-person.aspx.cs" Inherits="admin_person" %>

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
                                <div>
                                    <asp:Image runat="server" id="imgava"  style="height: 300px; margin: 0px !important;" />
                                    
                                    <div style="margin-left: 15%">
                                        <asp:FileUpload ID="FileUpload1" runat="server" Width="360px" Height="27px" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUpload1" Display="None" ErrorMessage="Bạn cần chọn một tệp ảnh trước khi ấn nút &quot;Upload&quot;"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                            </div>


                        </div>
                        <div class="col-sm-7">
                            <div class="product-information">
                                <h2>
                                    <asp:TextBox runat="server" ID="txtName" Width="280px" ToolTip="Full Name" placeholder="Full Name"/></h2>
                                <p>
                                    Age:
                                    <asp:TextBox runat="server" ID="txtAge" Width="248px" ToolTip="Age" placeholder="Age"/>
                                </p><h2>    Username:
                                <asp:Label runat="server" ID="lblUsname" Width="232px"></asp:Label></h2>
                                
                                    <asp:TextBox runat="server" ID="txtEmail" Width="280px" ToolTip="Email" placeholder="Email" />
                                <br />
                                <br />
                                 
                                    <asp:LinkButton CommandName="shpa" ID="lbtnshpa" runat="server" OnCommand="Unnamed_Command2"  OnClientClick="javascript:document.forms[0].encoding = 'multipart/form-data';"><div class="btn btn-fefault cart"><i class="fa fa-edit"></i>
                                        Update Password </div></asp:LinkButton>
                               
                                 <asp:TextBox runat="server" ID="txtPassword" Width="280px" ToolTip="Password" placeholder="Password" Visible="False" TextMode="Password" />
                                <br />
                                <br />
                                <asp:TextBox runat="server" ID="txtrepass" Width="280px" ToolTip="Confirm Password" placeholder="Confirm Password" Wrap="False" Visible="False" TextMode="Password" />
                                <br />
                                <br />  
                                    <asp:LinkButton CommandName="cpa" ID="lbtnCpa" style="margin-left:0px !important"  runat="server" OnCommand="Unnamed_Command1"  OnClientClick="javascript:document.forms[0].encoding = 'multipart/form-data';" Visible="False"><div class="btn btn-fefault cart"><i class="fa fa-edit"></i>
                                        Change Password  </div></asp:LinkButton>
                                <br />
                                    <asp:LinkButton CommandName="atc" runat="server" OnCommand="Unnamed_Command"  OnClientClick="javascript:document.forms[0].encoding = 'multipart/form-data';"> <div class="btn btn-fefault cart"><i class="fa fa-edit"></i>
                                        Update </div></asp:LinkButton>
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

