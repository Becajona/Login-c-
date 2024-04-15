<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccesoCorrecto.aspx.cs" Inherits="Login.AccesoCorrecto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Acceso Correcto</title>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="jumbotron">
            <h1 class="display-4">¡Bienvenido!</h1>
            <p class="lead">Acceso Correcto</p>
            <hr class="my-4">
            <a class="btn btn-primary btn-lg" href="Login.aspx" role="button">Ir a la Página Principal</a>
        </div>
        <br />
        <br />
        <div class="mt-5">
            <asp:GridView ID="GridViewUsuarios" runat="server" CssClass="table table-striped" AutoGenerateColumns="true" />
        </div>
    </form>

</body>
</html>
