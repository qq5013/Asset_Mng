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
    public partial class Editunit : Form
    {
        public Editunit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Loc.node);
            SqlConnection connection = Main.connection;
            connection.Open();
          //  string update = "Update اتاق set [شناسه واحد] ='" + textBox1.Text + "' where [شناسه واحد]='" + Loc.node + "';";
            string update2 = "Update واحد set نام ='" + textBox1.Text + "' Where نام='"+Loc.node+"';";
            //connection.Open();
            SqlCommand command = new SqlCommand(update2, connection);
            command.ExecuteNonQuery();


            connection.Close();
            MessageBox.Show("با موفقیت انجام شد.", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}