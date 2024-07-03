<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Venta.aspx.cs" Inherits="U3DWI.Venta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <div class="card">
            <div class="card-header bg-primary text-white">
                Nueva Venta
            </div>
            <div class="card-body">
                <form>
                    <div class="form-group row">
                        <label for="DropDownList1" class="col-sm-2 col-form-label">Seleccionar Cliente:</label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <label for="TextBox1" class="col-sm-2 col-form-label">Fecha:</label>
                        <div class="col-sm-4">
                            <asp:TextBox ID="TextBox1" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <div class="col-sm-12 text-right">
                            <asp:Button ID="Button1" runat="server" Text="Nueva Venta" CssClass="btn btn-primary" OnClick="Button1_Click" />
                        </div>
                    </div>
                    <hr />
                    <div class="form-group row">
                        <label class="col-sm-2 col-form-label">Productos:</label>
                    </div>
                    <div class="form-group row">
                        <div class="col-sm-2">
                            <asp:ImageButton ID="ImageButton1"  runat="server" OnClick="ImageButton1_Click" CssClass="btn btn-outline-primary" style="width: 74px" />
                        </div>
                        <div class="col-sm-2">
                            <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click" CssClass="btn btn-outline-secondary" style="width: 74px" />
                        </div>
                        <div class="col-sm-2">
                            <asp:ImageButton ID="ImageButton3"  runat="server" OnClick="ImageButton3_Click" CssClass="btn btn-outline-success" style="width: 74px" />
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="Label1" class="col-sm-2 col-form-label">Nombre:</label>
                        <div class="col-sm-4">
                            <asp:Label ID="Label1" runat="server" Text="" CssClass="form-control-plaintext"></asp:Label>
                        </div>
                        <label for="Label2" class="col-sm-2 col-form-label">Precio:</label>
                        <div class="col-sm-4">
                            <asp:Label ID="Label2" runat="server" Text="Precio" CssClass="form-control-plaintext"></asp:Label>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="DropDownList2" class="col-sm-2 col-form-label">Cantidad:</label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2">
                            <asp:Button ID="Button6" runat="server" Text="Subtotal" CssClass="btn btn-info" OnClick="Button6_Click" />
                        </div>
                        <div class="col-sm-4">
                            <asp:Button ID="Button7" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="Button7_Click" />
                        </div>
                    </div>
                    <div class="form-group row">
                        <div class="col-sm-8 text-right">
                            <asp:Button ID="Button8" runat="server" Text="Ordenar y Pagar" CssClass="btn btn-warning" OnClick="Button8_Click" />
                        </div>
                        <label for="TextBox4" class="col-sm-1 col-form-label">Total:</label>
                        <div class="col-sm-3">
                            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>

