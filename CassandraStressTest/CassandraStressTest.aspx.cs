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

    private int randomnumber(int min, int max)
    {
        Random rnum = new Random();
        return rnum.Next(min, max);
    }


    protected void btnStartTest_Click(object sender, EventArgs e)
    {
        ISession session;
        simpleClient sc = new simpleClient();
        session = sc.Connect();


        
            for (int i = 0; i < 10000; i++)
            {
            int newrandomnumber = randomnumber(0, 999999);
            session.Execute("INSERT INTO Users(tpxid,firstname,lastname,email) VALUES('xg47" + newrandomnumber + "','Karsan','Kerai','email@mail.com')");
            }

        Response.Redirect("default.aspx");
    }

}