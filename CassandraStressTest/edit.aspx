<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Home Page</title>   
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
     <h3>Edit User:</h3>  
    <hr />
       <div class="form-group">
    <label for="txttpxid">TPX ID</label>
              <asp:Label  ID ="lbltpxid" runat ="server" CssClass="form-control"></asp:Label>
  </div>
      <div class="form-group">
    <label for="txtfirstname">First Name</label>
              <asp:TextBox ID ="txtfirstname" runat ="server" CssClass="form-control"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="txtlastname">Last Name</label>
    <asp:TextBox ID ="txtlastname" runat ="server" CssClass="form-control"></asp:TextBox>
  </div>
        <div class="form-group">
    <label for="txtemail">Email Address</label>
    <asp:TextBox ID ="txtemail" runat ="server" CssClass="form-control"></asp:TextBox>
  </div>
                <asp:Button ID ="btnsave" runat ="server" CssClass ="btn btn-primary" Text ="Update" OnClick="btnsave_Click" />
    </div>
    </form>
</body>
</html>
