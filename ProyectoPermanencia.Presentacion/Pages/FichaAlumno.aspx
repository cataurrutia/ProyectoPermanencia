<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FichaAlumno.aspx.cs" Inherits="ProyectoPermanencia.Presentacion.Pages.FichaAlumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--<link href="../css/FichaStyleSheet.css" rel="stylesheet" type="text/css" />-->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="ContentFicha" ContentPlaceHolderID="ContentPlaceHolderFicha" runat="server">
    <div class="container">
        <h3>Tabs</h3>
        <ul class="nav nav-tabs">
            <li class="active"><a href="#">Home</a></li>
            <li><a href="FichaAlumno.aspx">Ficha</a></li>
            <li><a href="Historico.aspx">Historico</a></li>
        </ul>
        <br>
    </div>

    <div id="InformacionAlumno" class="info">
        <h3>Información Personal</h3>
        <asp:Label runat="server">Rut:</asp:Label> 18462110-k
        <br />
        <asp:Label runat="server">Nombre:</asp:Label> Catalina
        <br />
        <asp:Label runat="server">Carrera:</asp:Label> Ing Informatica
        <br />
        <asp:Label runat="server">Escuela:</asp:Label> Inf.
        <h3>Contacto</h3>
        <br />
        <asp:Label runat="server">Teléfono:</asp:Label> 99999999
        <br />
        <asp:Label runat="server">Mail:</asp:Label> fdsgd@jhjg.com
    </div>

    <div id="ScoreNotas" class="ScoreNotas">
        <h2>Score notas por asignatura </h2>
        <asp:GridView ID="grvNotas" runat="server" CssClass="ScoreNotas" AllowPaging="true" AutoGenerateColumns="false" BorderStyle="Solid" GridLines="Both" ShowHeaderWhenEmpty="true" EmptyDataText="No se encontraron registros">
            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="" HeaderText="ID Asignatura" />
                <asp:BoundField DataField="" HeaderText="Nombre asignatura" />
                <asp:BoundField DataField="" HeaderText="Notas" />
                <asp:BoundField DataField="" HeaderText="Promedio" />
                <asp:BoundField DataField="" HeaderText="SCORE" />
            </Columns>
        </asp:GridView>

    </div>

    <div id="ScoreAsistencia" class="ScoreAsistencia">
        <h2>Score asistencia por asignatura </h2>
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

    <div id="ScoreFinanzas" class="ScoreFinanzas">
        <h2>Score situación financiera </h2>
        <asp:GridView ID="grvFinanzas" runat="server" AllowPaging="true" AutoGenerateColumns="false" BorderStyle="Solid" GridLines="Both" ShowHeaderWhenEmpty="true" EmptyDataText="No se encontraron registros">
            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField HeaderText="N° Cuota" />
                <asp:BoundField HeaderText="Fecha Vencimiento" />
                <asp:BoundField HeaderText="Tipo de beneficio" />
                <asp:BoundField HeaderText="% de cobertura" />
                <asp:BoundField HeaderText="Estado" />
                <asp:BoundField HeaderText="Saldo" />
                <asp:BoundField HeaderText="SCORE" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>

