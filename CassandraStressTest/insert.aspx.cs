using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cassandra;

public partial class insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnsave_Click(object sender, EventArgs e)
    {
        ISession session;
        simpleClient sc = new simpleClient();
        session = sc.Connect();
        try
        {
            session.Execute("INSERT INTO Users(tpxid,firstname,lastname,email) VALUES('" + txttpxid.Text + "','" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtemail.Text + "')");

        }
        catch (Exception ex)
        {

            throw ex;

        }
        Response.Redirect("default.aspx");
    }

}