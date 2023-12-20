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
    public partial class UC_Orders : UserControl
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public UC_Orders()
        {
            InitializeComponent();
        }

        private void CategoryFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectedCategory = guna2ComboBox4.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCategory))
            {
                return;
            }
            if (guna2ComboBox4.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("Select * from new_order", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from new_order WHERE Status = @Status", connection);
                cmd.Parameters.AddWithValue("@Status", selectedCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = button1.BackColor;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = button2.BackColor;

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 1;
            button3.FlatAppearance.BorderColor = button3.BackColor;

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 1;
            button4.FlatAppearance.BorderColor = button4.BackColor;

            MySqlConnection connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select * from new_order", connection1);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            connection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_Supplier supplier = new New_Supplier();
            supplier.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Supplier view_Supplier = new View_Supplier();
            view_Supplier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Order new_Order = new New_Order();
            new_Order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(string.Empty))
            {
                MySqlConnection connection1 = new MySqlConnection(connectionString);
                connection1.Open();
                MySqlCommand cmd1 = new MySqlCommand("Select * from new_order", connection1);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from new_order where Order_Number=@Order_Number", connection);
                cmd.Parameters.AddWithValue("Order_Number", textBox2.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryFilter();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
