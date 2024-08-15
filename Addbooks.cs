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

namespace LibrarySystem
{
    public partial class Addbooks : Form
    {
        public Addbooks()
        {
            InitializeComponent();
        }
        private string connection = "Data Source=duyank\\SQLEXPRESS04;Initial Catalog=asm2;Integrated Security=True;";
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_add_books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName",SqlDbType.NVarChar).Value =textBox1.Text;
            cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@publication", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@purchaseDate", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
            cmd.Parameters.Add("@BookPrice", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Added");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbooks_Load(object sender, EventArgs e)
        {

        }
    }
}
