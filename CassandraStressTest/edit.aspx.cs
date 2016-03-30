using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cassandra;

public partial class edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String x = Request.QueryString["tpxid"];
        if(!Page.IsPostBack)
        {
            bindform(x);
        }
        
    }



    protected void btnsave_Click(object sender, EventArgs e)
    {
        Boolean res = updateUser(txtfirstname.Text, txtlastname.Text);
            if(res == true ){
                Response.Redirect("default.aspx");
            }
            else{
                Response.Write("oops,  error");
            }
    }

    public void bindform(string tpxid)
    {
        ISession session;
        simpleClient sc = new simpleClient();
        session = sc.Connect();
        Row rows = session.Execute("select * from users where tpxid='" + tpxid + "'").First();
        lbltpxid.Text = rows["tpxid"].ToString();
        txtfirstname.Text = rows["firstname"].ToString();
        txtlastname.Text = rows["lastname"].ToString();
        sc.Close();

    }

    public Boolean  updateUser(string lastname, string firstname)
    {
        ISession session;
        simpleClient sc = new simpleClient();            
        session = sc.Connect();
        try
        {
            session.Execute("update users set firstname ='" + txtfirstname + "', lastname ='" + txtlastname + "' where tpxid ='" + lbltpxid.Text + "'");
        }
        catch (Exception ex)
        {
            return false;
            throw ex;
           
        }
        return true;
    }
}