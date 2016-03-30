using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cassandra;

public partial class delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String x = Request.QueryString["id"];
        if (!Page.IsPostBack)
        {
            bindform(x);
        }
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        Boolean res = deleteUser();
        if (res == true)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            Response.Write("an Error has occured");
        }
    }
    public void bindform(string id)
    {
        ISession session;
        simpleClient sc = new simpleClient();
        session = sc.Connect();
        Row rows = session.Execute("select * from users where tpxid='" + id + "'").First();
        lbltpxid.Text = rows["tpxid"].ToString();
        txtfirstname.Text = rows["firstname"].ToString();
        txtlastname.Text = rows["lastname"].ToString();
        sc.Close();

    }

    public Boolean deleteUser()
    {
        ISession session;
        simpleClient sc = new simpleClient();
        session = sc.Connect();
        try
        {
            session.Execute("delete from users where tpxid = '" + lbltpxid.Text + "'");
        }
        catch (Exception ex)
        {
            return false;
            throw ex;

        }
        return true;
    }
}