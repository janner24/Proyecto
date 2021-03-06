﻿
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Proyecto.Web.vistas.Registrar.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
  <meta name="description" content=""/>
  <meta name="author" content=""/>
  <title>Registrar</title>
  <!-- Bootstrap core CSS-->
  <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
  <!-- Custom fonts for this template-->
  <link href="../../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css"/>
  <!-- Custom styles for this template-->
  <link href="../../css/sb-admin.css" rel="stylesheet"/>

    
  <!-- Bootstrap core JavaScript-->
  <script src="../../vendor/jquery/jquery.min.js"></script>
  <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
  <!-- Core plugin JavaScript-->
  <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>

    
    <link href="../../css/sweetalert.css" rel="stylesheet"/>
    <script  src="../../js/sweetalert.min.js" type="text/javascript"> </script>
</head>

<body class="bg-dark">
    <div class="container">
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">Registrar cuenta</div>
            <div class="card-body">
                <form id="form1" runat="server">
                    <div class="form-group">

                        <asp:Label ID="Lblnombre" runat="server" Text="Ingrese Nombre"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    
                    
                       <asp:Label ID="LblApellido" runat="server" Text="Ingrese Apellido"></asp:Label>
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                     <div class="form-group">

                        <asp:Label ID="Lblemail" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="Txteamil" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
                        
                         <div class="form-group">
                       <asp:Label ID="Lblpassword" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" TextMode="Password" ></asp:TextBox>

                              <asp:Label ID="Lblconpasswor" runat="server" Text="Confirmar Password"></asp:Label>
                        <asp:TextBox ID="Txtconpassword" runat="server" CssClass="form-control" TextMode="Password" ></asp:TextBox>
                    </div>
                        <asp:Button ID="btnRegistrar" runat="server" CssClass="btn-primary btn-block" Text="Registrar" OnClick="btnRegistrar_Click" ></asp:Button>
                   
                                   
                </form>
                <div class="text-center">
                    <a class="d-block small" href="../Login/Login.aspx">Pagina de inicio</a>
                    <a class="d-block small" href="#">Olvido password</a>
                </div>
            </div>
        </div>
    </div>
   </body>



</html>


