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
    public partial class New_Customer : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public New_Customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO customers (First_Name, Last_Name, Email, Phone, Street, City, State, Country, Postal_Code) VALUES (@First_Name, @Last_Name, @Email, @Phone, @Street, @City, @State, @Country, @Postal_Code)", connection);
            cmd.Parameters.AddWithValue("@First_Name", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@Last_Name", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@Email", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Phone", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@Street", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@City", guna2TextBox10.Text);
            cmd.Parameters.AddWithValue("@State", guna2TextBox11.Text);
            cmd.Parameters.AddWithValue("@Country", guna2TextBox12.Text);
            cmd.Parameters.AddWithValue("@Postal_Code", guna2TextBox13.Text);

            if (guna2TextBox1.Text != string.Empty && guna2TextBox2.Text != string.Empty && guna2TextBox3.Text != string.Empty && guna2TextBox4.Text != string.Empty && guna2TextBox9.Text != string.Empty && guna2TextBox10.Text != string.Empty && guna2TextBox11.Text != string.Empty && guna2TextBox12.Text != string.Empty && guna2TextBox13.Text != string.Empty)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Customer has been added successfully");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Customer Exists!");

                }

            }
            else
            {
                MessageBox.Show("You haven't filled all data!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
