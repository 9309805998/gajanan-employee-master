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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Data Source=DESKTOP-RB1MO78\\SQLEXPRESS03;Initial Catalog=master;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
           

       }

        private void btn01_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("insert into employee_detail values(" + txt01.Text + ",'" + txt02.Text + "'," + listBox1.Text + ",'" + txt04.Text + "')", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Saved...");
            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("Delete from Employee_detail where Employee ID = " + txt01.Text + " ", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                txt01.Clear();
                txt02.Clear();
             
                txt04.Clear();
                txt01.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(" Not Deleted" + x.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    }
}
