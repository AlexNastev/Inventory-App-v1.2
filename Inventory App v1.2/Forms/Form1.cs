using Inventory_App_v1._2.UserControls;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = button1.BackColor;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderColor = button2.BackColor;

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 1;
            button3.FlatAppearance.BorderColor = button3.BackColor;

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 1;
            button4.FlatAppearance.BorderColor = button4.BackColor;

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 1;
            button5.FlatAppearance.BorderColor = button5.BackColor;

            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 1;
            button6.FlatAppearance.BorderColor = button6.BackColor;

            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 1;
            button7.FlatAppearance.BorderColor = button7.BackColor;

            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 1;
            button8.FlatAppearance.BorderColor = button7.BackColor;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Inventory uc = new UC_Inventory();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Orders uc = new UC_Orders();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_Sales uc = new UC_Sales();
            addUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UC_Projects uc = new UC_Projects();
            addUserControl(uc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UC_Assembly uc = new UC_Assembly();
            addUserControl(uc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UC_AccountSettings uc = new UC_AccountSettings();
            addUserControl(uc);
        }
    }
}
