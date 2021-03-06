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
    public partial class Loc : Form
    {
        public Loc()
        {
            InitializeComponent();
        }
        public static string node;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            node = treeView1.SelectedNode.Text;
            listBox1.Items.Clear();
            SqlConnection connection = Main.connection;
            //  string find1="select [شناسه]"

            string find = "SELECT [اتاق].[نام] from اتاق inner join واحد on [اتاق].[واحد]=[واحد].[نام] where [واحد].[نام]='" + treeView1.SelectedNode.Text + "';";
            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand(find, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["نام"].ToString());
            }
            connection.Close();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            SqlConnection connection = Main.connection;
            string find = "Select * from واحد";
            connection.Open();
            SqlCommand command = new SqlCommand(find, connection);
            SqlDataReader reader = command.ExecuteReader();
           
            while (reader.Read())
            {
                string temp = reader["نام"].ToString();
                treeView1.Nodes.Add(temp);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = Main.connection;
            connection.Open();
            string insert = "Insert into واحد ([نام]) values (@name)";
            SqlCommand command = new SqlCommand(insert, connection);
            command.Parameters.Add("@name", textBox1.Text);
            treeView1.Nodes.Add(textBox1.Text);
            textBox1.Clear();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static string list;//////
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list = listBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              SqlConnection connection = Main.connection;
            string insert = "Insert into اتاق ([واحد],[نام]) values (@unit,@name);";
            connection.Open();
            SqlCommand command = new SqlCommand(insert, connection);
            command.Parameters.Add("@unit", node);
            command.Parameters.Add("@name", textBox2.Text);
            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static string nodname;
        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);
                TreeNode node = treeView1.GetNodeAt(p);

                if (node != null)
                {
                    nodname = node.Text;
                    treeView1.SelectedNode = node;
                    contextMenuStrip1.Show(treeView1, p);
                }
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);
                listBox1.SelectedIndex = listBox1.IndexFromPoint(p);

                if (listBox1.SelectedIndex != -1)
                {
                  
                    contextMenuStrip2.Show(listBox1, p);
                }
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editunit frm = new Editunit();
            frm.ShowDialog();
        }

        private void حدفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("آیا میخواهید این نوع را حذف کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = Main.connection;
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
              
                string delete = "DELETE  from واحد where نام='" + Loc.node + "';";
               
                command.CommandText = delete;
                command.ExecuteNonQuery();

                treeView1.SelectedNode.Remove();
                MessageBox.Show("حذف شد");
                connection.Close();
            }
         
        }

        private void ویرایشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editroom frm = new Editroom();
            frm.ShowDialog();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("آیا میخواهید این نوع را حذف کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = Main.connection;
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
              
                string delete1 = "DELETE from اتاق where [نام]='" + Loc.list + "' and واحد='"+Loc.node+"';";
            
                command.CommandText = delete1;
                command.ExecuteNonQuery();
              
                MessageBox.Show("حذف شد");
                connection.Close();
            }
        }
    }
}