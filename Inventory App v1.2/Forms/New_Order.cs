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

namespace Inventory_App_v1._2
{
    public partial class New_Order : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public New_Order()
        {
            InitializeComponent();
        }

        private void New_Order_Load(object sender, EventArgs e)
        {
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 1;
            button8.FlatAppearance.BorderColor = button8.BackColor;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Supplier from new_supplier", connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guna2ComboBox4.Items.Add(reader["Supplier"].ToString());
            }



        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO new_order (Item, Description, Vendor_NR, Quantity, Price, Delivery_Date, Payment, Delivery, Courier, Comments, Supplier) VALUES (@Item, @Description, @Vendor_NR, @Quantity, @Price, @Delivery_Date, @Payment, @Delivery, @Courier, @Comments, @Supplier)", connection);
            cmd.Parameters.AddWithValue("@Item", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@Description", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@Vendor_NR", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(guna2TextBox4.Text));
            cmd.Parameters.AddWithValue("@Price", int.Parse(guna2TextBox5.Text));
            cmd.Parameters.AddWithValue("@Delivery_Date", guna2TextBox6.Text);
            cmd.Parameters.AddWithValue("@Payment", guna2TextBox7.Text);
            cmd.Parameters.AddWithValue("@Delivery", guna2TextBox8.Text);
            cmd.Parameters.AddWithValue("@Courier", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@Comments", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@Supplier", guna2ComboBox4.SelectedItem.ToString());
            if (guna2TextBox1.Text != string.Empty && guna2TextBox2.Text != string.Empty && guna2TextBox3.Text != string.Empty && guna2TextBox4.Text != string.Empty && guna2TextBox5.Text != string.Empty && guna2TextBox6.Text != string.Empty && guna2TextBox7.Text != string.Empty && guna2TextBox8.Text != string.Empty && guna2TextBox9.Text != string.Empty && guna2TextBox10.Text != string.Empty && guna2ComboBox4.SelectedItem.ToString() != "Select Supplier") 
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Order has been added successfully");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Order Exists!");

                }

            }
            else
            {
                MessageBox.Show("You haven't filled all data!");
            }
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
