<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="VisionGlobal.aspx.cs" Inherits="ProyectoPermanencia.Presentacion.VisionGlobal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderGlobal" runat="server">
    <div id="ScoreGlobal" class="ScoreGlobal">
        <h2> Visión Score global </h2>
        <asp:GridView ID="grvGlobal" runat="server" AllowPaging="true" AutoGenerateColumns="false" BorderStyle="Solid" GridLines="Both" ShowHeaderWhenEmpty="true" EmptyDataText="No se encontraron registros">
            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField HeaderText="ID Alumno" />
                <asp:BoundField HeaderText="Rut" />
                <asp:BoundField HeaderText="Nombre" />
                <asp:BoundField HeaderText="Carrera" />
                <asp:BoundField HeaderText="Escuela" />
                <asp:BoundField HeaderText="Sede" />
                <asp:BoundField HeaderText="Semestre" />
                <asp:BoundField HeaderText="Jornada" />
                <asp:BoundField HeaderText="SCORE" />
            </Columns>
        </asp:GridView>

    </div>
</asp:Content>
