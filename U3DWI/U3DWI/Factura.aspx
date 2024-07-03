<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="U3DWI.Factura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-3">
        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="Label2" runat="server" Text="Selecciona Nombre" CssClass="form-label"></asp:Label>
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-md-4">
                <asp:Button ID="Button6" runat="server" Text="Consultar" OnClick="Button6_Click" CssClass="btn btn-primary" />
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-4">
                <asp:Label ID="Label3" runat="server" Text="Selecciona Fecha de Venta:" CssClass="form-label"></asp:Label>
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-md-4">
                <asp:Button ID="Button7" runat="server" Text="Generar" OnClick="Button7_Click" CssClass="btn btn-primary" />
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-12">
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
