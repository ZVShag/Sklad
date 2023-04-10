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
using System.Configuration;

namespace Sklad
{
    public partial class Form1 : Form
    {
        public static string connect= @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Studen 2\source\repos\Network\Sklad\Sklad\Sklad.mdf; Integrated Security = True";

        SqlConnection sqlConnection = new SqlConnection(connect);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO [Sklad](Id,Name,Type,Seller,Count,Price,Data) VALUES(1,@Name,@Type,@Seller,@Count,@Price,@Data)", sqlConnection);
            cmd.Parameters.AddWithValue("Name", textBox1.Text);
            cmd.Parameters.AddWithValue("Type", textBox2.Text);
            cmd.Parameters.AddWithValue("Seller", textBox4.Text);
            cmd.Parameters.AddWithValue("Count",int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("Price", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("Data", DateTime.Parse(textBox5.Text));
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
