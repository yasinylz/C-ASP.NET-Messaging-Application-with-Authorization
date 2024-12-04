using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Web.Configuration;

public partial class SingInUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbDataAdapter da = new OleDbDataAdapter("select * from Users   where  UserName='" + txtUserName.Text + "'  and  Pasword='" + txtPwd.Text + "'", WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count>0)
        {
            Session["session"] = "open";
            Session["userName"] = txtUserName.Text;
            Response.Redirect("SessionPage.aspx");

        }
        else
        {
            lblErr.Text = "Kullanıcı adı ya da şifre hatalı ! ! !";

        }
    }
}