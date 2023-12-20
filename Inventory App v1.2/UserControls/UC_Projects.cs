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
    public partial class UC_Projects : UserControl
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";
        public UC_Projects()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Project new_Project = new New_Project();
            new_Project.Show();
        }

        private void UC_Projects_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = button1.BackColor;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = button2.BackColor;


            MySqlConnection connection1 = new MySqlConnection(connectionString);
            connection1.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select * from projects", connection1);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            connection1.Close();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MySqlCommand cmd1 = new MySqlCommand("Select * from projects", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else if (textBox2.Text != string.Empty && textBox1.Text == string.Empty)
            {
                MySqlCommand cmd = new MySqlCommand("Select * from projects where Project_Name=@Project_Name", connection);
                cmd.Parameters.AddWithValue("Project_Name", textBox2.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (textBox2.Text == string.Empty && textBox1.Text != string.Empty)
            {
                MySqlCommand cmd = new MySqlCommand("Select * from projects where Parts=@Parts", connection);
                cmd.Parameters.AddWithValue("Parts", textBox1.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("Select * from projects where Parts=@Parts and Project_Name=@Project_Name", connection);
                cmd.Parameters.AddWithValue("Parts", textBox1.Text);
                cmd.Parameters.AddWithValue("Project_Name", textBox2.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        private void CategoryFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string ProjectTypeCategory = guna2ComboBox2.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(ProjectTypeCategory))
            {
                return;
            }
            if (guna2ComboBox2.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("Select * from projects", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM projects WHERE Project_Type = @Project_Type", connection);
                cmd.Parameters.AddWithValue("@Project_Type", ProjectTypeCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void StatusFilter()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string StatusCategory = guna2ComboBox4.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(StatusCategory))
            {
                return;
            }
            if (guna2ComboBox4.SelectedItem.Equals("All"))
            {
                MySqlCommand cmd1 = new MySqlCommand("Select * from projects", connection);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM projects WHERE Status = @Status", connection);
                cmd.Parameters.AddWithValue("@Status", StatusCategory);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryFilter();
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusFilter();
        }
    }
}
