using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace WebformApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //string cs = ConfigurationManager.ConnectionStrings["mycon"].ToString();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetUserDetails();
            }
        }

        

        protected void AddMyData(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(cs);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M1VJECI\\SQLEXPRESS01;Initial Catalog=mydata1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("InsertUserDt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Gender", rblGender.SelectedValue);
            cmd.Parameters.AddWithValue("@CountryName", ddlCountryName.SelectedValue);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            GetUserDetails();
            Response.Write("<script>alert('Insert Data successfullyInsert Data successfully') </script>");
            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data inserted successfully!');", true);

            
             txtName.Text = "";
           txtAddress.Text = "";
             txtEmail.Text = "";
             ddlCountryName.SelectedIndex = 0;
             rblGender.SelectedIndex = -1; // radio button clear fild data after insert






        }

        void GetUserDetails()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M1VJECI\\SQLEXPRESS01;Initial Catalog=mydata1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("GetUserDt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(cs);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M1VJECI\\SQLEXPRESS01;Initial Catalog=mydata1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UpdateUserDt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",Convert.ToInt32(TextEnterID.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Gender", rblGender.SelectedValue);
            cmd.Parameters.AddWithValue("@CountryName", ddlCountryName.SelectedValue);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            GetUserDetails();
            Response.Write("<script>alert('Insert Data successfullyInsert Data successfully') </script>");
            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data inserted successfully!');", true);

            TextEnterID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            ddlCountryName.SelectedIndex = 0;
            rblGender.SelectedIndex = -1; // radio button clear fild data after insert
            GetUserDetails();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M1VJECI\\SQLEXPRESS01;Initial Catalog=mydata1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DeleteUserDt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(TextEnterID.Text));
            
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            GetUserDetails();
            Response.Write("<script>alert('Insert Data successfullyInsert Data successfully') </script>");
            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data inserted successfully!');", true);

            TextEnterID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            ddlCountryName.SelectedIndex = 0;
            rblGender.SelectedIndex = -1; // radio button clear fild data after insert
          


        }
    }
}
