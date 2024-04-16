using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication35
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
        protected void Button1_Click(object sender, EventArgs e)
        {



            }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\srcadmin\Documents\Visual Studio 2012\Projects\WebApplication35\WebApplication35\App_Data\Database1.mdf;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Select * FROM Register WHERE Email = @Email and Password = @Password", con);
            cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Webform4.aspx");
            }
            else
            {
                Label1.Text = "Invalid Credentials";
        }


            }
        }
    }
