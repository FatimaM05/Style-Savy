namespace OOPProject
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            txtEmailBox = new TextBox();
            txtCNICbox = new TextBox();
            txtPhoneNumberBox = new TextBox();
            txtNameBox = new TextBox();
            txtIDbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUpdate = new Button();
            updategrid = new DataGridView();
            label6 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)updategrid).BeginInit();
            SuspendLayout();
            // 
            // txtEmailBox
            // 
            txtEmailBox.BackColor = Color.PeachPuff;
            txtEmailBox.Location = new Point(586, 213);
            txtEmailBox.Margin = new Padding(3, 2, 3, 2);
            txtEmailBox.Name = "txtEmailBox";
            txtEmailBox.Size = new Size(165, 30);
            txtEmailBox.TabIndex = 24;
            // 
            // txtCNICbox
            // 
            txtCNICbox.BackColor = Color.PeachPuff;
            txtCNICbox.Location = new Point(207, 255);
            txtCNICbox.Margin = new Padding(3, 2, 3, 2);
            txtCNICbox.Name = "txtCNICbox";
            txtCNICbox.Size = new Size(148, 30);
            txtCNICbox.TabIndex = 23;
            // 
            // txtPhoneNumberBox
            // 
            txtPhoneNumberBox.BackColor = Color.PeachPuff;
            txtPhoneNumberBox.Location = new Point(586, 249);
            txtPhoneNumberBox.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumberBox.Name = "txtPhoneNumberBox";
            txtPhoneNumberBox.Size = new Size(165, 30);
            txtPhoneNumberBox.TabIndex = 22;
            // 
            // txtNameBox
            // 
            txtNameBox.BackColor = Color.PeachPuff;
            txtNameBox.Location = new Point(207, 291);
            txtNameBox.Margin = new Padding(3, 2, 3, 2);
            txtNameBox.Name = "txtNameBox";
            txtNameBox.Size = new Size(148, 30);
            txtNameBox.TabIndex = 21;
            // 
            // txtIDbox
            // 
            txtIDbox.BackColor = Color.PeachPuff;
            txtIDbox.Location = new Point(207, 213);
            txtIDbox.Margin = new Padding(3, 2, 3, 2);
            txtIDbox.Name = "txtIDbox";
            txtIDbox.Size = new Size(148, 30);
            txtIDbox.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SeaShell;
            label5.Location = new Point(506, 217);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaShell;
            label4.Location = new Point(125, 257);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 18;
            label4.Text = "CNIC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Location = new Point(493, 255);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 17;
            label3.Text = "Contact";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Location = new Point(125, 293);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Location = new Point(149, 217);
            label1.Name = "label1";
            label1.Size = new Size(30, 22);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // txtUpdate
            // 
            txtUpdate.BackColor = Color.MistyRose;
            txtUpdate.Location = new Point(312, 347);
            txtUpdate.Margin = new Padding(3, 2, 3, 2);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(251, 53);
            txtUpdate.TabIndex = 25;
            txtUpdate.Text = "Update Customer";
            txtUpdate.UseVisualStyleBackColor = false;
            txtUpdate.Click += txtUpdate_Click;
            // 
            // updategrid
            // 
            updategrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            updategrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            updategrid.BackgroundColor = Color.PeachPuff;
            updategrid.BorderStyle = BorderStyle.Fixed3D;
            updategrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.SeaShell;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            updategrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            updategrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            updategrid.GridColor = Color.DarkSalmon;
            updategrid.Location = new Point(3, 404);
            updategrid.Margin = new Padding(3, 2, 3, 2);
            updategrid.Name = "updategrid";
            updategrid.RowHeadersWidth = 62;
            updategrid.Size = new Size(945, 203);
            updategrid.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaShell;
            label6.Location = new Point(454, 294);
            label6.Name = "label6";
            label6.Size = new Size(109, 22);
            label6.TabIndex = 27;
            label6.Text = "Membership";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.PeachPuff;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Platinum", "Silver", "Gold" });
            comboBox1.Location = new Point(586, 288);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 30);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 618);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(updategrid);
            Controls.Add(txtUpdate);
            Controls.Add(txtEmailBox);
            Controls.Add(txtCNICbox);
            Controls.Add(txtPhoneNumberBox);
            Controls.Add(txtNameBox);
            Controls.Add(txtIDbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "Update Customer";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)updategrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmailBox;
        private TextBox txtCNICbox;
        private TextBox txtPhoneNumberBox;
        private TextBox txtNameBox;
        private TextBox txtIDbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button txtUpdate;
        private DataGridView updategrid;
        private Label label6;
        private ComboBox comboBox1;
    }
}