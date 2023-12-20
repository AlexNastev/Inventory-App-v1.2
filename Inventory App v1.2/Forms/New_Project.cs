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
    public partial class New_Project : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public New_Project()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_Project_Load(object sender, EventArgs e)
        {
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 1;
            button8.FlatAppearance.BorderColor = button8.BackColor;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = button1.BackColor;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Full_Name from customers", connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guna2ComboBox1.Items.Add(reader["Full_Name"].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO projects (Project_Name, Project_Type, Parts, Quantity, SN, Start_Date, Completed_Date, Status, Customer, Technician) VALUES (@Project_Name, @Project_Type, @Parts, @Quantity, @SN, @Start_Date, @Completed_Date, @Status, @Customer, @Technician)", connection);
            cmd.Parameters.AddWithValue("@Project_Name", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@Project_Type", guna2ComboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Parts", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Quantity", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@SN", guna2TextBox5.Text);
            cmd.Parameters.AddWithValue("@Start_Date", guna2TextBox6.Text);
            cmd.Parameters.AddWithValue("@Completed_Date", guna2TextBox7.Text);
            cmd.Parameters.AddWithValue("@Status", guna2ComboBox4.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Customer", guna2ComboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Technician", guna2TextBox10.Text);
            if (guna2TextBox1.Text != string.Empty && guna2ComboBox2.Text != string.Empty && guna2TextBox3.Text != string.Empty && guna2TextBox4.Text != string.Empty && guna2TextBox5.Text != string.Empty && guna2TextBox6.Text != string.Empty && guna2TextBox7.Text != string.Empty && guna2ComboBox4.SelectedItem.ToString() != string.Empty && guna2ComboBox1.SelectedItem.ToString() != string.Empty && guna2TextBox10.Text != string.Empty && guna2ComboBox4.SelectedItem.ToString() != string.Empty)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Project has been added successfully");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Project Exists!");

                }

            }
            else
            {
                MessageBox.Show("You haven't filled all data!");
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
