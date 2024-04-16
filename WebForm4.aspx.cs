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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        void LoadRecord()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\srcadmin\Documents\Visual Studio 2012\Projects\WebApplication35\WebApplication35\App_Data\Database1.mdf;Integrated Security=true"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ORDERS", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or display error message
                Label1.Text = "Error: " + ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\srcadmin\Documents\Visual Studio 2012\Projects\WebApplication35\WebApplication35\App_Data\Database1.mdf;Integrated Security=true"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO ORDERS (MyOrder, Amount) VALUES (@MyOrder, @Amount)", con);
                    cmd.Parameters.AddWithValue("@MyOrder", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Amount", TextBox2.Text);

                    cmd.ExecuteNonQuery();
                    Label1.Text = "Saved Successfully!";
                    LoadRecord();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or display error message
                Label1.Text = "Error: " + ex.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\srcadmin\Documents\Visual Studio 2012\Projects\WebApplication35\WebApplication35\App_Data\Database1.mdf;Integrated Security=true"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM ORDERS WHERE ID = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", TextBox8.Text);
                    cmd.ExecuteNonQuery();

                    Label1.Text = "Deleted successfully!";
                    LoadRecord();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or display error message
                Label1.Text = "Error: " + ex.Message;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\srcadmin\Documents\Visual Studio 2012\Projects\WebApplication35\WebApplication35\App_Data\Database1.mdf;Integrated Security=true"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE ORDERS SET MyOrder = @MyOrder, Amount = @Amount WHERE ID = @ID", con);
                    cmd.Parameters.AddWithValue("@MyOrder", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Amount", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@ID", TextBox8.Text);
                    cmd.ExecuteNonQuery();

                    Label1.Text = "Updated successfully!";
                    LoadRecord();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or display error message
                Label1.Text = "Error: " + ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\srcadmin\Documents\Visual Studio 2012\Projects\WebApplication35\WebApplication35\App_Data\Database1.mdf;Integrated Security=true"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Orders = (MyOrder, Amount) VALUES (@MyOrder, @Amount)", con);
                    cmd.Parameters.AddWithValue("@MyOrder", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Amount", TextBox2.Text);
                    cmd.ExecuteNonQuery();
                    LoadRecord();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }
    }
}
