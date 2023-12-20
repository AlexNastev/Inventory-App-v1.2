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
    public partial class New_Assy : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public New_Assy()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO assembly (Items, Description, Subcategory, Required_Quantity, Available_Quantity, Comments) VALUES (@Items, @Description, @Subcategory, @Required_Quantity, @Available_Quantity, @Comments)", connection);
            cmd.Parameters.AddWithValue("@Items", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@Description", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Subcategory", guna2ComboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Required_Quantity", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@Available_Quantity", guna2TextBox5.Text);
            cmd.Parameters.AddWithValue("@Comments", guna2TextBox6.Text);
            if (guna2TextBox1.Text != string.Empty && guna2ComboBox2.Text != string.Empty && guna2TextBox3.Text != string.Empty && guna2TextBox4.Text != string.Empty && guna2TextBox5.Text != string.Empty && guna2TextBox6.Text != string.Empty)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Assembly has been added successfully");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Assembly Exists!");

                }

            }
            else
            {
                MessageBox.Show("You haven't filled all data!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
