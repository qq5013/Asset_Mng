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
    public partial class Editroom : Form
    {
        public Editroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Main.connection;
            connection.Open();
            string update = "Update اتاق set نام ='" + textBox1.Text + "' WHERE نام='" +Loc.list + "' and واحد='"+Loc.node+"';";
            //connection.Open();
            SqlCommand command = new SqlCommand(update, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("با موفقیت انجام شد.", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}