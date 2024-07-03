<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="U3DWI.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-left:400px; margin-top:100px">
        <asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="White" BorderColor="#336666"
            BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal"
            AutoGenerateColumns="False" ShowFooter="True">

            <Columns>
                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("idc") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtid" Text='<%#Eval("idc") %>'
                            runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox runat="server" ID="txtidf" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("nombre") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtnombre" Text='<%#Eval("nombre") %>'
                            runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>

                        <asp:TextBox ID="txtfn" runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Correo">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("correo") %>' runat="server"></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtel" Text='<%#Eval("correo") %>'
                            runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtftel" runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ImageUrl="~/images/lapiz.png" runat="server"
                            CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:ImageButton ImageUrl="~/images/eliminar.png" CommandName="Delete"
                            ToolTip="Delete" Width="20px" Height="20px" runat="server" />
                        <asp:ImageButton ImageUrl="~/images/lapiz.png" runat="server"
                            CommandName="Update" ToolTip="Update" Width="20px" Height="20px" />
                        <asp:ImageButton ImageUrl="~/images/cerrar.png" runat="server"
                            CommandName="cancel" ToolTip="Save" Width="20px" Height="20px" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:ImageButton ImageUrl="~/images/boton-agregar.png" runat="server"
                            CommandName="Save" ToolTip="Save" Width="20px" Height="20px" />
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#2DA496" />
            <HeaderStyle BackColor="#2DA496" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" BorderColor="White" BorderStyle="None"
                BorderWidth="0px" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />

        </asp:GridView>
    </div>
    <asp:Label ID="MensajeS" Text="" runat="server" ForeColor="Green" />
    <br />
    <asp:Label ID="MensajeM" Text="" runat="server"
        ForeColor="Red" />


</asp:Content>
