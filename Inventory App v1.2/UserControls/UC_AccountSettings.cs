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
using Newtonsoft.Json;
using System.IO;

namespace Inventory_App_v1._2.UserControls
{
    public partial class UC_AccountSettings : UserControl
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=crud;Uid=root;Pwd=Alexnastev12;";

        public UC_AccountSettings()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void guna2CustomGradientPanel1_Enter(object sender, EventArgs e)
        {
            
        }

        private void UC_AccountSettings_Load(object sender, EventArgs e)
        {
            Login loginForm = Application.OpenForms.OfType<Login>().FirstOrDefault();

            if (loginForm != null)
            {
                string username = loginForm.publicString;

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT Full_Name FROM users WHERE username = @username", connection);
                cmd.Parameters.AddWithValue("@username", username);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string fullName = reader.GetString(0); // Assuming Full_Name is stored as a string in the database
                    label4.Text = fullName;
                }
                else
                {
                    label4.Text = "Username not found";
                }

                reader.Close(); // Close the data reader

                MySqlCommand passwordCmd = new MySqlCommand("SELECT password FROM users WHERE username = @username", connection);
                passwordCmd.Parameters.AddWithValue("@username", username);
                string password = passwordCmd.ExecuteScalar().ToString();
                string passwordAsterisks = new string('*', password.Length);
                label5.Text = passwordAsterisks;

                // Retrieve user's email
                MySqlCommand emailCmd = new MySqlCommand("SELECT email FROM users WHERE username = @username", connection);
                emailCmd.Parameters.AddWithValue("@username", username);
                string email = emailCmd.ExecuteScalar().ToString();
                label6.Text = email;

                // Load user image
                if (userImages.ContainsKey(username))
        {
            string imagePath = userImages[username];
            if (File.Exists(imagePath))
            {
                guna2PictureBox1.Image = Image.FromFile(imagePath);
                guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                // Handle case when the image file no longer exists
                guna2PictureBox1.Image = null;
                guna2PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
        else
        {
            // Handle case when no image is available for the user
            guna2PictureBox1.Image = null;
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        connection.Close();
            }
        }



        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private Dictionary<string, string> userImages = new Dictionary<string, string>();
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Get the logged-in username
                Login loginForm = Application.OpenForms.OfType<Login>().FirstOrDefault();
                if (loginForm != null)
                {
                    string username = loginForm.publicString;

                    // Store the selected image path for the logged-in username
                    userImages[username] = imagePath;

                    // Load the selected image into the PictureBox
                    guna2PictureBox1.Image = Image.FromFile(imagePath);
                    guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    // Save the image path to the database
                    try
                    {
                        MySqlConnection connection = new MySqlConnection(connectionString);
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand("UPDATE user_images SET image_path = @imagePath WHERE username = @username", connection);
                        cmd.Parameters.AddWithValue("@imagePath", imagePath);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image path: " + ex.Message);
                    }
                }
            }
        }

    }
}
