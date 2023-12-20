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
    public partial class Register : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public Register()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO users (first_name, last_name, username, password, Email) VALUES (@first_name, @last_name, @username, @password, @Email)", connection);
            cmd.Parameters.AddWithValue("@first_name", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@last_name", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@username", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@password", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Email", guna2TextBox5.Text);
            if (guna2TextBox1.Text != string.Empty && guna2TextBox2.Text != string.Empty && guna2TextBox3.Text != string.Empty && guna2TextBox4.Text != string.Empty)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User has been added successfully");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                catch 
                {
                    MessageBox.Show("User Exists!");
                    
                }
                
            }
            else
            {
                MessageBox.Show("You haven't filled all data!");
            }
            
        }

        

        private void Register_Load(object sender, EventArgs e)
        {
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 1;
            button8.FlatAppearance.BorderColor = button8.BackColor;
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
