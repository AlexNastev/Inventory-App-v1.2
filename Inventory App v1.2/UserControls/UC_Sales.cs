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
    public partial class UC_Sales : UserControl
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";

        private List<string> selectedItems = new List<string>();

        public UC_Sales()
        {
            InitializeComponent();

            // Subscribe to the ItemCheck event
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }

        private void UC_Sales_Load(object sender, EventArgs e)
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

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Full_Name from customers", connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guna2ComboBox4.Items.Add(reader["Full_Name"].ToString());
            }
            connection.Close();

            MySqlConnection connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT Item, Assembly, Project_Number, Description, Quantity, Price, Customer, Status, Comments from sales", connection);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_Customer new_Customer = new New_Customer();
            new_Customer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Customers view_Customers = new View_Customers();
            view_Customers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Quote new_Quote = new New_Quote();
            new_Quote.Show();
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerFilter();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusFilter();
        }
        private void StatusFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectedStatus = guna2ComboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedStatus))
            {
                return;
            }
            if (guna2ComboBox1.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT Item, Assembly, Project_Number, Description, Quantity, Price, Customer, Status, Comments from sales", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                connection.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Item, Assembly, Project_Number, Description, Quantity, Price, Customer, Status, Comments FROM sales WHERE Status = @Status", connection);
                cmd.Parameters.AddWithValue("@Status", selectedStatus);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
        }
        private void CustomerFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectedCustomer = guna2ComboBox4.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCustomer))
            {
                return;
            }
            if (guna2ComboBox4.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT Item, Assembly, Project_Number, Description, Quantity, Price, Customer, Status, Comments FROM sales", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                connection.Close();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Item, Assembly, Project_Number, Description, Quantity, Price, Customer, Status, Comments FROM sales WHERE Customer = @Customer", connection);
                cmd.Parameters.AddWithValue("@Customer", selectedCustomer);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

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
            string query = "SELECT Item, Assembly, Project_Number, Description, Quantity, Price, Customer, Status, Comments";

            // Append additional columns to the query
            if (selectedItems.Count > 0)
            {
                string additionalColumns = string.Join(", ", selectedItems.Select(item => $"`{item}`"));
                query += ", " + additionalColumns;
            }

            query += " FROM sales";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();
        }
    }
}
