
namespace Inventory_App_v1._2.UserControls
{
    partial class UC_Inventory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ComboBox5 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.Location = new System.Drawing.Point(9, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1352, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Part Number:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(335, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 11.05F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(724, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by Description:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(335, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(369, 32);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.checkedListBox1.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Additional Note",
            "Category",
            "Subcategory",
            "Order Date",
            "Order Status"});
            this.checkedListBox1.Location = new System.Drawing.Point(1102, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(259, 99);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Subcategory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(708, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alternative Parts";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox5);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox4);
            this.guna2CustomGradientPanel1.Controls.Add(this.textBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label7);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.dataGridView1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.button1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Tomato;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Salmon;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightSalmon;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LightSalmon;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1370, 570);
            this.guna2CustomGradientPanel1.TabIndex = 17;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // guna2ComboBox5
            // 
            this.guna2ComboBox5.AutoRoundedCorners = true;
            this.guna2ComboBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox5.BorderRadius = 17;
            this.guna2ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox5.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox5.ItemHeight = 30;
            this.guna2ComboBox5.Items.AddRange(new object[] {
            "All"});
            this.guna2ComboBox5.Location = new System.Drawing.Point(724, 128);
            this.guna2ComboBox5.Name = "guna2ComboBox5";
            this.guna2ComboBox5.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox5.StartIndex = 0;
            this.guna2ComboBox5.TabIndex = 21;
            this.guna2ComboBox5.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox5_SelectedIndexChanged);
            // 
            // guna2ComboBox4
            // 
            this.guna2ComboBox4.AutoRoundedCorners = true;
            this.guna2ComboBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox4.BorderRadius = 17;
            this.guna2ComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox4.ItemHeight = 30;
            this.guna2ComboBox4.Items.AddRange(new object[] {
            "All",
            "Pending",
            "In Progress",
            "Completed"});
            this.guna2ComboBox4.Location = new System.Drawing.Point(545, 128);
            this.guna2ComboBox4.Name = "guna2ComboBox4";
            this.guna2ComboBox4.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox4.StartIndex = 0;
            this.guna2ComboBox4.TabIndex = 20;
            this.guna2ComboBox4.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            // 
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.AutoRoundedCorners = true;
            this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox3.BorderRadius = 17;
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox3.ItemHeight = 30;
            this.guna2ComboBox3.Items.AddRange(new object[] {
            "All"});
            this.guna2ComboBox3.Location = new System.Drawing.Point(369, 128);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox3.StartIndex = 0;
            this.guna2ComboBox3.TabIndex = 19;
            this.guna2ComboBox3.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox3_SelectedIndexChanged);
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.AutoRoundedCorners = true;
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 17;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "All",
            "AVR",
            "Carousel",
            "Controller large",
            "Controller small",
            "EGPA",
            "End Effector",
            "GB1E",
            "GB1EB",
            "GB3",
            "GB4",
            "GB4P",
            "GB4PS",
            "GB4S",
            "GB4SB",
            "GB7",
            "GB7S",
            "GB8",
            "GB8SM",
            "GB9",
            "GREX3",
            "GREX4",
            "OCA",
            "Porta 300",
            "Porta 300P",
            "Porta R6",
            "Ripa",
            "RTA",
            "SAPA"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(200, 128);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.TabIndex = 18;
            this.guna2ComboBox2.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "All",
            "Assembly",
            "Bearing",
            "Belt",
            "Board",
            "Box",
            "Bracket",
            "Cable",
            "Chuck",
            "Electrical subs",
            "End Effector",
            "Floor Stock",
            "Light house",
            "Motor",
            "Other",
            "Power Supply",
            "Pulley",
            "Scanning",
            "Shaft",
            "Vacuum subs"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(20, 128);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(155, 36);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 17;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(1367, 567);
            this.Load += new System.EventHandler(this.UC_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox5;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
    }
}
