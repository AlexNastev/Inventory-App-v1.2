using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App_v1._2.UserControls
{
    public partial class UC_Assembly : UserControl
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public UC_Assembly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Assy new_Assy = new New_Assy();
            new_Assy.Show();
        }

        private void UC_Assembly_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = button1.BackColor;

            MySqlConnection connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select * from assembly", connection1);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            connection1.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            if (guna2TextBox1.Text == string.Empty && guna2TextBox2.Text == string.Empty)
            {
                MySqlCommand cmd1 = new MySqlCommand("Select * from assembly", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else if (guna2TextBox1.Text != string.Empty && guna2TextBox2.Text == string.Empty)
            {
                MySqlCommand cmd = new MySqlCommand("Select * from assembly where Assembly_ID=@Assembly_ID", connection);
                cmd.Parameters.AddWithValue("Assembly_ID", guna2TextBox1.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (guna2TextBox1.Text == string.Empty && guna2TextBox2.Text != string.Empty)
            {
                MySqlCommand cmd = new MySqlCommand("Select * from assembly where Item=@Item", connection);
                cmd.Parameters.AddWithValue("Item", guna2TextBox2.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from projects where Assembly_ID=@Assembly_ID and Item=@Item", connection);
                cmd.Parameters.AddWithValue("Assembly_ID", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("Item", guna2TextBox2.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        private void SubategoryFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string SubategoryCategory = guna2ComboBox2.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(SubategoryCategory))
            {
                return;
            }
            if (guna2ComboBox2.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("Select * from assembly", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM assembly WHERE Subcategory = @Subcategory", connection);
                cmd.Parameters.AddWithValue("@Subcategory", SubategoryCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubategoryFilter();
        }
    }
}
