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
    public partial class New_Quote : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public New_Quote()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO sales (Item, Assembly, Project_Number, Description, Quantity, Price, Customer, Status, Comments, Type) VALUES (@Item, @Assembly, @Project_Number, @Description, @Quantity, @Price, @Customer, @Status, @Comments, @Type)", connection);
            cmd.Parameters.AddWithValue("@Item", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@Assembly", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@Project_Number", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Description", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@Quantity", guna2TextBox5.Text);
            cmd.Parameters.AddWithValue("@Price", guna2TextBox6.Text);
            cmd.Parameters.AddWithValue("@Customer", guna2ComboBox4.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Status", guna2ComboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Comments", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@Type", guna2ComboBox2.SelectedItem.ToString());
           


            if (guna2TextBox1.Text != string.Empty && guna2TextBox2.Text != string.Empty && guna2TextBox3.Text != string.Empty && guna2TextBox4.Text != string.Empty && guna2TextBox5.Text != string.Empty && guna2TextBox6.Text != string.Empty && guna2TextBox9.Text != string.Empty &&  guna2ComboBox2.SelectedItem.ToString() != string.Empty && guna2ComboBox4.SelectedItem.ToString() != string.Empty && guna2ComboBox1.SelectedItem.ToString() != string.Empty)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Quote has been added successfully");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Quote Exists!");

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

        private void New_Quote_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Full_Name from customers", connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guna2ComboBox4.Items.Add(reader["Full_Name"].ToString());
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
