using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SessionPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["session"] == "" || Session["session"] == null)
        {
            Response.Redirect("SingInUser.aspx");
          


        }
        else
        {
            userMsg_name.InnerHtml = Session["userName"].ToString();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Messager where sender='" + Session["userName"].ToString() + "' or Buyer='" + Session["userName"].ToString() + "'  ", WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
       DataTable dt = new DataTable();      
            da.Fill(dt);    
            if(dt.Rows.Count > 0 )
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    lblSelectedMessage.Text = dt.Rows[i]["Message"].ToString();
                    lblSelectedDate.Text= dt.Rows[i]["DateNow"].ToString();
                    lblSelectedName.Text = dt.Rows[i]["Sender"].ToString();





                }
            }
            else
            {
                lblSelectedMessage.Text = "Mesajınız Bulunmamaktadır!";
            }
        
        }
       
          


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbDataAdapter da = new OleDbDataAdapter("insert into Messager (Sender,Buyer,DateNow,Message) values('"+ Session["userName"].ToString() + "','"+txtUserName.Text+"','"+DateTime.Now.ToString()+"','"+txtMessageBox.Text+"') ", WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Response.Redirect("SessionPage.aspx");
    }

  
}