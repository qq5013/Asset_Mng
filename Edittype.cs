using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asset_Mng
{
    public partial class Edittype : Form
    {
        public Edittype()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Type.nodname);
            SqlConnection connection = Main.connection;
            connection.Open();
            string update = "Update نوع set نام ='" + textBox1.Text + "' WHERE نام='"+Type.nodname+"';";
            //connection.Open();
            SqlCommand command = new SqlCommand(update,connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("با موفقیت انجام شد.","پیغام",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}