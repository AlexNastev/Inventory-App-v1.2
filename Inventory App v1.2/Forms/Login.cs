using Inventory_App_v1._2.UserControls;
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

    public partial class Login : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";

        public Login()
        {
            InitializeComponent();
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 1;
            button8.FlatAppearance.BorderColor = button8.BackColor;
        }
        public string publicString;
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            publicString = guna2TextBox1.Text;
            String username, password;
            username = guna2TextBox1.Text;
            password = guna2TextBox2.Text;
            


            try
            {
                String query = "Select * from users where username = '"+ guna2TextBox1.Text+"' and password = '"+ guna2TextBox2.Text+"'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = guna2TextBox1.Text;
                    password = guna2TextBox2.Text;
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User does not exist!");
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                    guna2TextBox3.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error!");

            }
            finally
            {
                connection.Close();
            }

        }

        private void guna2Button3_MouseDown(object sender, MouseEventArgs e)
        {
            guna2TextBox3.Hide();
        }

        private void guna2Button3_MouseUp(object sender, MouseEventArgs e)
        {
            guna2TextBox3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2TextBox2.Text = guna2TextBox3.Text;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
