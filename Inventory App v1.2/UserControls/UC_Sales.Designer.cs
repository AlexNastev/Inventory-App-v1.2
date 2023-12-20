
namespace Inventory_App_v1._2.UserControls
{
    partial class UC_Sales
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2ComboBox4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.dataGridView1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox4);
            this.guna2CustomGradientPanel1.Controls.Add(this.checkedListBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ComboBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.button3);
            this.guna2CustomGradientPanel1.Controls.Add(this.button2);
            this.guna2CustomGradientPanel1.Controls.Add(this.button1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Tomato;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Salmon;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightSalmon;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LightSalmon;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1375, 575);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.Location = new System.Drawing.Point(3, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 377);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            "All"});
            this.guna2ComboBox4.Location = new System.Drawing.Point(496, 125);
            this.guna2ComboBox4.Name = "guna2ComboBox4";
            this.guna2ComboBox4.Size = new System.Drawing.Size(248, 36);
            this.guna2ComboBox4.StartIndex = 0;
            this.guna2ComboBox4.TabIndex = 26;
            this.guna2ComboBox4.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.checkedListBox1.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Customer Item NR",
            "Date Placed",
            "Payment Terms",
            "Delivery Terms",
            "Attachments"});
            this.checkedListBox1.Location = new System.Drawing.Point(1089, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(259, 99);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "By Customer:";
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
            this.guna2ComboBox1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "All",
            "Ordered",
            "Confirmed",
            "Arrived",
            "Completed"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(105, 125);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(222, 36);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 8;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSalmon;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 11.05F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(461, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Customers";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 11.05F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(220, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "New Customer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 11.05F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(16, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "New Quote";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UC_Sales";
            this.Size = new System.Drawing.Size(1367, 567);
            this.Load += new System.EventHandler(this.UC_Sales_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
