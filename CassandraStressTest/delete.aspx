<%@ Page Language="C#" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Delete User</title>   
     <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link rel="stylesheet" href="css/styles.css"/>
    <link rel="stylesheet" href="css/queries.css"/>
    <link href="http://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet"/>
	  <!-- Fonts -->
    
</head>
<body>
    <form id="form1" runat="server">
<header class="clearfix">
		    		    <div class="active"><h2 class="logo col-md-3">Database Stress Test</h2></div>
		    <nav class="clearfix">
            <ul class="clearfix">
                <li><a href="Default.aspx" >Users</a></li>
                <li><a href="CassandraStressTest.aspx"  class="last">Cassandra Stress Test</a></li>           
                <li><a href="CouchTest.aspx"  class="last">Couch Test</a></li>  
            </ul>
        </nav>
        <div class="pullcontainer">
        <a href="#" id="pull"><i class="fa fa-bars fa-2x"></i></a>
        </div>     
		</header>
  <div class="container">
     <h3>Delete User:</h3>  
    <hr />
    <table class ="table">
        <tr>
            <td>TPX ID</td>
            <td><asp:Label ID="lbltpxid" runat ="server" ></asp:Label></td>
        </tr>
        <tr>
            <td>FirstName:</td>
            <td><asp:Label ID ="txtfirstname" runat ="server" ></asp:Label></td>

        </tr>
          <tr>
            <td>LastName:</td>
            <td><asp:Label ID ="txtlastname" runat ="server" ></asp:Label></td>

        </tr>
        <tr>
            <td>Email Address:</td>
            <td><asp:Label ID ="txtemail" runat ="server" ></asp:Label></td>

        </tr>
        <tr>
         
            <td>
                <asp:Button ID ="btndelete" runat ="server" Text ="Delete" CssClass ="btn btn-danger btn-group-sm " OnClick="btndelete_Click"  />

            </td>
            
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
