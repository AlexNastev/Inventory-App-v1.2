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
    public partial class New_Supplier : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public New_Supplier()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void New_Supplier_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = button1.BackColor;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = button2.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO new_supplier (Supplier, Contact, Our_ID, Phone, Fax, Email, Website, Street, City, State, Country, Postal_Code, Comment) VALUES (@Supplier, @Contact, @Our_ID, @Phone, @Fax, @Email, @Website, @Street, @City, @State, @Country, @Postal_Code, @Comment)", connection);
            cmd.Parameters.AddWithValue("@Supplier", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@Contact", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@Our_ID", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Phone", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@Fax", guna2TextBox5.Text);
            cmd.Parameters.AddWithValue("@Email", guna2TextBox6.Text);
            cmd.Parameters.AddWithValue("@Website", guna2TextBox7.Text);
            cmd.Parameters.AddWithValue("@Street", guna2TextBox8.Text);
            cmd.Parameters.AddWithValue("@City", guna2TextBox9.Text);
            cmd.Parameters.AddWithValue("@State", guna2TextBox10.Text);
            cmd.Parameters.AddWithValue("@Country", guna2TextBox11.Text);
            cmd.Parameters.AddWithValue("@Postal_Code", guna2TextBox12.Text);
            cmd.Parameters.AddWithValue("@Comment", guna2TextBox13.Text);

            
            if (guna2TextBox1.Text != string.Empty && guna2TextBox2.Text != string.Empty && guna2TextBox3.Text != string.Empty && guna2TextBox4.Text != string.Empty && guna2TextBox5.Text != string.Empty && guna2TextBox6.Text != string.Empty && guna2TextBox7.Text != string.Empty && guna2TextBox8.Text != string.Empty && guna2TextBox9.Text != string.Empty && guna2TextBox10.Text != string.Empty && guna2TextBox11.Text != string.Empty && guna2TextBox12.Text != string.Empty && guna2TextBox13.Text != string.Empty)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Supplier has been added successfully");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Supplier Exists!");

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
