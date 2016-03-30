using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cassandra;
using System.Text;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ISession session;
        simpleClient sc = new simpleClient();
        session = sc.Connect();
        RowSet rows = session.Execute("select * from users");
        session.Cluster.Shutdown();
        StringBuilder x = new StringBuilder();
        x.Append("<table class='table'><thead><tr><th>TPX ID</th><th>Email</th><th>First Name</th><th>Last Name</th><th>Email Address</th></tr></thead><tbody>");

        foreach (Row row in rows)
        {
            x.Append("<tr><td>" + row["tpxid"].ToString() + "</td><td>" + row["firstname"].ToString() + "</td><td>" + row["lastname"].ToString() + "</td><td>" + row["email"].ToString() + "</td><td><a class='btn btn-xs btn-info' href ='edit.aspx?id=" + row["tpxid"].ToString() + "'>EDIT </a></td><td><a class='btn btn-xs btn-danger' href ='delete.aspx?id=" + row["tpxid"].ToString() + "'>DELETE</a></td></tr>");
        }

        x.Append("</tbody></table>");
        ltr.Text = x.ToString();

    }
}
