<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="U3DWI.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
    .button1 {
background-color: #28D1D8; /* Green */
border: 1px solid green;
padding: 12px 26px;
text-align: center;
text-decoration: none;
display: inline-block;
font-size: 18px;
cursor: pointer;
float: left;
border-style:hidden;
    color: black;
    font-weight: 700;
    width: 100%;
}
.button1:hover {
background-color: #008b8b;
color: white;
}
.button2 {
background-color: #28D1D8; 
border: 1px solid green;
color: black;
padding: 10px 20px;
text-align: center;
text-decoration: none;
display: inline-block;
font-size: 14px;
cursor: pointer;
float: left;
border-style:hidden;
min-width: 100px;
}
.button2:hover {
background-color: #28D1D8;
color: black;
}

.navboton{
    background-color: #008b8b; 
    color: white;
}
.borde1{
        border-left: 1px solid black;
    border-right: 1px solid black;
}
</style>
<html>
<head">
    <meta charset="utf-8" />
    <title>Productos</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
    <body>
        
            <div class="container">
                <div class="row">
                     <div class="col-4">
                         <asp:Button ID="Button1" runat="server" Text="Alta" CssClass="button1" OnClick="Button1_Click" />
                     </div>
                     <div class="col-4">
                         <asp:Button ID="Button2" runat="server" Text="Edicion" CssClass="button1" OnClick="Button2_Click" />
                     </div>
                     <div class="col-4">
                         <asp:Button ID="Button3" runat="server" Text="Consultas" CssClass="button1" OnClick="Button3_Click" />
                     </div>
                </div>
            </div>
            <div class="container mt-5">
    
                <table class="table table-striped " runat="server" id="altas">
                    <thead>
                        <tr style="border-top: 1px solid; border-left: 1px solid black;border-right: 1px solid black;">
                            <th>Registro de nuevo producto</th>
                            <th></th>

                        </tr>
                    </thead>
                    <tbody class="borde1">
                        <tr style="border-left: 1px solid black;border-right: 1px solid black; border-right: 1px solid black">
                            <td>Nombre</td>
                            <td><asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox>
                            </td>
                        </tr>
                        <tr style="border-left: 1px solid black;border-right: 1px solid black;">
                            <td>Precio</td>
                            <td> <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox>  </td>
                        </tr>
                        <tr style="border-left: 1px solid black;border-right: 1px solid black;">
                            <td>Cantidad de stock</td>
                            <td> <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox></td>
                        </tr>
                        <tr style=" border-bottom: 1px solid black; border-left: 1px solid black;border-right: 1px solid black;">
                            <td></td>
                            <td><asp:Button ID="Button4" runat="server" Text="Guardar" CssClass="button2" OnClick="Button4_Click" /></td>
                        </tr>

                    </tbody>
                    </table>
            </div>
       
        <div class="container mt-5">
            <table class="table table-striped " runat="server" id="edicion">
                <thead>
                    <tr style="border-left: 1px solid black;border-right: 1px solid black; border-top: 1px solid black">
                        <th>Edicion</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody class="borde1">
                    <tr style="border-left: 1px solid black;border-right: 1px solid black; border-top: 1px solid black">
                        <td>id</td>
                        <td><asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox></td>
                            <td><asp:Button ID="Button5" runat="server" Text="Consultar" CssClass="button2" OnClick="Button5_Click" /></td>
                    </tr>
                    <tr style="border-left: 1px solid black;border-right: 1px solid black;">
                        <td>Nombre</td>
                        <td><asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr style="border-left: 1px solid black;border-right: 1px solid black;">
                        <td>Precio</td>
                        <td><asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox></td>
                        
                        <td></td>
                    </tr>
                    <tr style="border-left: 1px solid black;border-right: 1px solid black; border-top: 1px solid black">
                        <td>Cantidad</td>
                        <td><asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox></td>
                        <td></td>
                        
                    </tr>
                    <tr style=" border-bottom: 1px solid black; border-left: 1px solid black;border-right: 1px solid black;">
                        <td></td>
                            <td><asp:Button ID="Button6" runat="server" Text="Modificar" CssClass="button2" OnClick="Button6_Click" /></td>
                            <td><asp:Button ID="Button7" runat="server" Text="Eliminar" CssClass="button2" OnClick="Button7_Click" /></td>
                    </tr>
                </tbody>
            </table>
         </div>
                <div class="container mt-5">

            <table class="table table-striped " runat="server" id="consultar">

                <tbody >
                    <tr style="border-left: 1px solid black;border-right: 1px solid black; border-top: 1px solid black">
                        <td>Por id</td>
                        <td><asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox></td>
                        <td><asp:Button ID="Button9" runat="server" Text="Consultar" CssClass="button2" OnClick="Button9_Click" /></td>
                    </tr>
                    <tr style="border-left: 1px solid black;border-right: 1px solid black;">
                        <td></td>
                        <td></td>
                        <td></td>

                    </tr>
                    <tr style=" border-bottom: 1px solid black; border-left: 1px solid black;border-right: 1px solid black;">
                        <td>Reporte General</td>
                        <td> <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control" Width="60%"  ></asp:TextBox></td>
                        <td><asp:Button ID="Button10" runat="server" Text="Generar" CssClass="button2" OnClick="Button10_Click" /></td>

                    </tr>
                </tbody>
                </table>
        </div>

      </body>
</html>


    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>


</asp:Content>
