using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace my_first_virtual_window_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connectObj = new SqlConnection();
                connectObj.ConnectionString = "Data Source=LAPTOP-IGCVHMJQ\\SQLEXPRESS;Initial Catalog=Virtusa;Integrated Security=true";
            SqlCommand commandObj = new SqlCommand();
            commandObj.CommandText = "insert into Students values ('" + textBox1.Text + "','" + textBox2.Text + "' ,'" + textBox3.Text + "','" + textBox4.Text + "')";
            commandObj.Connection = connectObj;
            connectObj.Open();
            int rowaffect = commandObj.ExecuteNonQuery();
            connectObj.Close();
            if (rowaffect > 0)
            {
                MessageBox.Show("Record Added Successfully...");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Insertion failied...");
            }
        }
catch(Exception ee)
{
MessageBox.Show(ee.Message);
}
}
    }
}
