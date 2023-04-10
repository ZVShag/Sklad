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
            SqlCommand cmd = new SqlCommand($"INSERT INTO [Sklad](Name,Type,Seller,Count,Price,Data) VALUES(@Name,@Typee,@Seller,@Count,@Price,@Data)", sqlConnection);
            cmd.Parameters.AddWithValue("Name", textBox1.Text);
            cmd.Parameters.AddWithValue("Type", textBox2.Text);
            cmd.Parameters.AddWithValue("Seller", textBox3.Text);
            cmd.Parameters.AddWithValue("Count", textBox4.Text);
            cmd.Parameters.AddWithValue("Price", textBox5.Text);
            cmd.Parameters.AddWithValue("Data", textBox6.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
