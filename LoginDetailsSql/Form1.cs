using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginDetailsSql
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=logs;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into userlogs values('" + txtusrnme.Text + "','" + txtpasswrd.Text + "')", con);
            cmd.ExecuteNonQuery();
            lblmsg1.Text = "Record inserted Sucessfully";
            lblmsg1.ForeColor = System.Drawing.Color.Green;
            txtusrnme.Text = "";
            txtpasswrd.Text = "";
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd=new SqlCommand("Delete from userlogs where username='" +txtusrnme.Text + "'and upassword='" + txtpasswrd.Text + "'", con);
            cmd.ExecuteNonQuery();
            lblmsg1.Text = "Record deleted Sucessfully";
            lblmsg1.ForeColor = System.Drawing.Color.Red;
            txtusrnme.Text = "";
            txtpasswrd.Text = "";
            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update userlogs set username='" + txtusrnme.Text + "'Where upassword='" + txtpasswrd.Text + "'", con);
            cmd.ExecuteNonQuery();
            lblmsg1.Text = "Record Update Sucessfully";
            lblmsg1.ForeColor = System.Drawing.Color.Green;
            txtusrnme.Text = "";
            txtpasswrd.Text = "";
            con.Close() ;
        }
    }
}
