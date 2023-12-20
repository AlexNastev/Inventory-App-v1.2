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
    public partial class UC_Inventory : UserControl
    {

        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public UC_Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MySqlCommand cmd1 = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts from inventory", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else if (textBox1.Text != string.Empty && textBox2.Text == string.Empty)
            {
                MySqlCommand cmd = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts from inventory where part_Number=@Part_Number", connection);
                cmd.Parameters.AddWithValue("part_Number", textBox1.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (textBox1.Text == string.Empty && textBox2.Text != string.Empty)
            {
                MySqlCommand cmd = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts from inventory where description=@Description", connection);
                cmd.Parameters.AddWithValue("description", textBox2.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts from inventory where part_Number=@Part_Number and description=@Description", connection);
                cmd.Parameters.AddWithValue("part_Number", textBox1.Text);
                cmd.Parameters.AddWithValue("description", textBox2.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = button1.BackColor;

            MySqlConnection connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts from inventory", connection1);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            connection1.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CategoryFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectedCategory = guna2ComboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCategory))
            {
                return;
            }
            if (guna2ComboBox1.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts, Category from inventory", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Part_Number, Description, Category, Location, Quantity, Lead_Time, Alternative_Parts FROM inventory WHERE Category = @Category", connection);
                cmd.Parameters.AddWithValue("@Category", selectedCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }



        }
        private void SubcategoryFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectedCategory = guna2ComboBox2.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCategory))
            {
                return;
            }
            if (guna2ComboBox2.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts, Subcategory from inventory", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Part_Number, Description, Subcategory, Location, Quantity, Lead_Time, Alternative_Parts FROM inventory WHERE Subcategory = @Subcategory", connection);
                cmd.Parameters.AddWithValue("@Subcategory", selectedCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }



        }
        private void LocationFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectedCategory = guna2ComboBox3.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCategory))
            {
                return;
            }
            if (guna2ComboBox3.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts from inventory", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Part_Number, Description, Location, Quantity, Lead_Time, Alternative_Parts FROM inventory WHERE Location = @Location", connection);
                cmd.Parameters.AddWithValue("@Location", selectedCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }



        }
        private void OrderStatusFilter()
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
                MySqlCommand cmd1 = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts, `Order Status` from inventory", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Part_Number, Description, `Order Status`, Location, Quantity, Lead_Time, Alternative_Parts FROM inventory WHERE `Order Status` = @Order_Status", connection);
                cmd.Parameters.AddWithValue("@Order_Status", selectedCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }



        }
        private void AltPartsFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectedCategory = guna2ComboBox5.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCategory))
            {
                return;
            }
            if (guna2ComboBox5.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("Select Part_Number,Description,Location,Quantity,Lead_Time,Alternative_Parts from inventory", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Part_Number, Description,Location, Quantity, Lead_Time, Alternative_Parts FROM inventory WHERE Alternative_Parts = @Alternative_Parts", connection);
                cmd.Parameters.AddWithValue("@Alternative_Parts", selectedCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }



        }




        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            guna2CustomGradientPanel1.SendToBack();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryFilter();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubcategoryFilter();
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationFilter();
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderStatusFilter();
        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltPartsFilter();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<string> selectedItems = new List<string>();

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedItem = checkedListBox1.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                // Add the selected item to the list
                selectedItems.Add(selectedItem);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // Remove the selected item from the list
                selectedItems.Remove(selectedItem);
            }

            // Update the DataGridView based on the selected items
            UpdateDataGridViewBasedOnCheckedItems();
        }

        private void UpdateDataGridViewBasedOnCheckedItems()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create the base SQL query
            string query = "SELECT Part_Number, Description, Location, Quantity, Lead_Time, Alternative_Parts";

            // Append additional columns to the query
            if (selectedItems.Count > 0)
            {
                string additionalColumns = string.Join(", ", selectedItems.Select(item => $"`{item}`"));
                query += ", " + additionalColumns;
            }

            query += " FROM inventory";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();
        }


    }
}
