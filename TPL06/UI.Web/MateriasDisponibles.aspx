﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MateriasDisponibles.aspx.cs" Inherits="Academia.UI.Web.Materias_disponibles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div>
     
              <div style="margin-bottom: 15px;">
<asp:LinkButton ID="LinkButton1" runat="server" OnClick="editarLinkButton_Click" ForeColor="Black" style="
    border-radius: 20px;
    font-size: 1.25rem !important;
    background: #36304a !important;
    color: white !important;
    margin: 5px  !important;
    padding: .3rem .5rem .3rem .5rem !important;">
            Incribirse
        </asp:LinkButton>
        </div>
            <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeyNames="Id">
                    <Columns>
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="HsSemanales" DataField="HsSemanales" />
                        <asp:BoundField HeaderText="HsTotales" DataField="HsTotales" />
                        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </div>
</asp:Content>
