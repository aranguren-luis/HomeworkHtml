<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoClass.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />

</head>
<body>
   <div class="Container">
       <div class="row">
           <div class="col"></div>
           <div class="col-10">
               <h1>Proceso de Formulario</h1><hr />
               <h3><b>Resultado: <%=Mensaje%></b></h3>
               <br />
               <p><b>Nombre Completo:</b> <%=Nombre%> <%=Apellido1%></p>
           </div>

       </div>
   </div>
</body>
</html>
