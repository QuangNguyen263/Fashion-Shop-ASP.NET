<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="form"><!--form-->
		<div class="container">
			<div class="row">
				<div class="col-sm-12 col-sm-offset-1">
					<div class="login-form"><!--login form-->
						<h2>Login to your account</h2>
						<form action="#">
							<asp:TextBox  runat="server"  placeholder="Name" ID="tbName"/>  
                            </br>
                            </br>
							<asp:TextBox  runat="server"  TextMode="Password" placeholder="Password" ID="tbPass"/>  
                           </br>
                            </br>
                            <asp:Button ID="btnLogin" Text="Login" runat="server"  class="btn btn-default" OnClick="Unnamed_Click" />
						</form>
					</div><!--/login form-->
				</div>
				
			
			</div>
		</div>
	</section><!--/form-->
</asp:Content>

