<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="U3DWI.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Login</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"
</head>

<body>
    <form id="form2" runat="server">
        <div class="container mt-5" style="margin-top:100px;">
            <div class="row justify-content-center"style="margin-top:180px;" >
                <div class="col-md-4">
                    <div class="card">
                        <div class="card-header text-center">
                            <h3>Login</h3>
                        </div>
                        <div class="card-body">
                            <div class="form-group" style="margin-left:100px">
                                <label for="username">Username</label>
                                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" Width="60%"  placeholder="Enter username"></asp:TextBox>
                            </div>
                            <div class="form-group" style="margin-left:100px">
                                <label for="password">Password</label>
                                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" Width="60%" TextMode="Password" placeholder="Enter password"></asp:TextBox>
                            </div>
                            <div class="form-group text-center mt-3">
                                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>