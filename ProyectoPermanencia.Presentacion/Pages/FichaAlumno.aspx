<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FichaAlumno.aspx.cs" Inherits="ProyectoPermanencia.Presentacion.Pages.FichaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="ContentFicha" ContentPlaceHolderID="ContentPlaceHolderFicha" runat="server">
    <div id="InformacionAlumno">


    </div>

    <div id="ScoreNotas" class="ScoreNotas">
        <h2> Score notas por asignatura </h2>
        <asp:GridView ID="grvNotas" runat="server" AllowPaging="true" AutoGenerateColumns="false" BorderStyle="Solid" GridLines="Both" ShowHeaderWhenEmpty="true" EmptyDataText="No se encontraron registros">
            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
           <Columns>
               <asp:BoundField HeaderText="ID Asignatura" />
               <asp:BoundField HeaderText="Nombre asignatura" />
               <asp:BoundField HeaderText="Notas" />
               <asp:BoundField HeaderText="Promedio" />
               <asp:BoundField HeaderText="SCORE" />
           </Columns>
        </asp:GridView>

    </div>

    <div id="ScoreAsistencia" class="ScoreAsistencia">
        <h2> Score asistencia por asignatura </h2>
        <asp:GridView ID="grvAsistencia" runat="server" AllowPaging="true" AutoGenerateColumns="false" BorderStyle="Solid" GridLines="Both" ShowHeaderWhenEmpty="true" EmptyDataText="No se encontraron registros">
            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
            <Columns>
               <asp:BoundField HeaderText="ID Asignatura" />
               <asp:BoundField HeaderText="Nombre asignatura" />
               <asp:BoundField HeaderText="N° de clases registradas" />
               <asp:BoundField HeaderText="N° de clases asitidas" />
               <asp:BoundField HeaderText="% actual de asistencia" />
               <asp:BoundField HeaderText="SCORE" />
           </Columns>
        </asp:GridView>
    </div>

    <div id="ScoreFinanzas">
        <h2> Score situación financiera </h2>
        <asp:GridView ID="grvFinanzas" runat="server" AllowPaging="true" AutoGenerateColumns="false" BorderStyle="Solid" GridLines="Both" ShowHeaderWhenEmpty="true" EmptyDataText="No se encontraron registros">
            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </div>

</asp:Content>

