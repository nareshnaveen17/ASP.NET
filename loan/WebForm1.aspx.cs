using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace loan
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("integrated Security=yes; database=amazon; data source=NARESH");
            con.Open();
            string q = "update loan set roi=('" + TextBox6.Text + "') where Loanid=('" + TextBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            int p = cmd.ExecuteNonQuery();
            Label3.Visible = true;
            if (p != 0)
            {
                Label3.Text = "Updated";
            }
            else
            {
                Label3.Text = "not Updated";
            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("integrated Security=yes; database=amazon; data source=NARESH");
            con.Open();

            string q = "insert into loan values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            int p = cmd.ExecuteNonQuery();
            Label1.Visible = true;

            if (p != 0)
            {
                Label1.Text = "Inserted";
            }
            else
            {
                Label1.Text = "Not Inserted";
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("integrated Security=yes; database=amazon; data source=NARESH");
            con.Open();
            string q = "delete from loan where Loanid=('" + TextBox4.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            int p = cmd.ExecuteNonQuery();
            Label2.Visible = true;
            if (p != 0)
            {
                Label2.Text = "Deleted";
            }
            else
            {
                Label2.Text = "Not deleted";
            }

            con.Close();
        }
    }
}