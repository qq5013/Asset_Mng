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
    public partial class subsearch : Form
    {
        public subsearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.searchid = textBox1.Text;
            SqlConnection con = Main.connection;
            con.Open();
            string find = "SELECT شناسه from کالا where شناسه='" + textBox1.Text+ "'";
            SqlCommand command = new SqlCommand(find, con);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            string check = "0";
            if (dr.HasRows)
            {

                check = "1";
                con.Close();
               Info frm = new Info();

                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("یافت نشد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}