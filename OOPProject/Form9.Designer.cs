namespace OOPProject
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            updategrid = new DataGridView();
            txtupdateEmployee = new Button();
            txtsalarybox = new TextBox();
            label6 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)updategrid).BeginInit();
            SuspendLayout();
            // 
            // updategrid
            // 
            updategrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            updategrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            updategrid.BackgroundColor = Color.PeachPuff;
            updategrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            updategrid.Location = new Point(12, 364);
            updategrid.Margin = new Padding(3, 2, 3, 2);
            updategrid.Name = "updategrid";
            updategrid.RowHeadersWidth = 62;
            updategrid.Size = new Size(928, 239);
            updategrid.TabIndex = 2;
            // 
            // txtupdateEmployee
            // 
            txtupdateEmployee.BackColor = Color.LightSalmon;
            txtupdateEmployee.Location = new Point(747, 259);
            txtupdateEmployee.Margin = new Padding(3, 2, 3, 2);
            txtupdateEmployee.Name = "txtupdateEmployee";
            txtupdateEmployee.Size = new Size(115, 59);
            txtupdateEmployee.TabIndex = 57;
            txtupdateEmployee.Text = "Update Employee";
            txtupdateEmployee.UseVisualStyleBackColor = false;
            txtupdateEmployee.Click += txtupdateEmployee_Click;
            // 
            // txtsalarybox
            // 
            txtsalarybox.BackColor = Color.PeachPuff;
            txtsalarybox.Location = new Point(531, 313);
            txtsalarybox.Margin = new Padding(3, 2, 3, 2);
            txtsalarybox.Name = "txtsalarybox";
            txtsalarybox.Size = new Size(150, 28);
            txtsalarybox.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaShell;
            label6.Location = new Point(454, 320);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 55;
            label6.Text = "Salary";
            // 
            // txtEmailBox
            // 
            txtEmailBox.BackColor = Color.PeachPuff;
            txtEmailBox.Location = new Point(531, 239);
            txtEmailBox.Margin = new Padding(3, 2, 3, 2);
            txtEmailBox.Name = "txtEmailBox";
            txtEmailBox.Size = new Size(150, 28);
            txtEmailBox.TabIndex = 54;
            // 
            // txtCNICbox
            // 
            txtCNICbox.BackColor = Color.PeachPuff;
            txtCNICbox.Location = new Point(265, 275);
            txtCNICbox.Margin = new Padding(3, 2, 3, 2);
            txtCNICbox.Name = "txtCNICbox";
            txtCNICbox.Size = new Size(135, 28);
            txtCNICbox.TabIndex = 53;
            // 
            // txtPhoneNumberBox
            // 
            txtPhoneNumberBox.BackColor = Color.PeachPuff;
            txtPhoneNumberBox.Location = new Point(531, 275);
            txtPhoneNumberBox.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumberBox.Name = "txtPhoneNumberBox";
            txtPhoneNumberBox.Size = new Size(150, 28);
            txtPhoneNumberBox.TabIndex = 52;
            // 
            // txtNameBox
            // 
            txtNameBox.BackColor = Color.PeachPuff;
            txtNameBox.Location = new Point(265, 313);
            txtNameBox.Margin = new Padding(3, 2, 3, 2);
            txtNameBox.Name = "txtNameBox";
            txtNameBox.Size = new Size(135, 28);
            txtNameBox.TabIndex = 51;
            // 
            // txtIDbox
            // 
            txtIDbox.BackColor = Color.PeachPuff;
            txtIDbox.Location = new Point(265, 238);
            txtIDbox.Margin = new Padding(3, 2, 3, 2);
            txtIDbox.Name = "txtIDbox";
            txtIDbox.Size = new Size(43, 28);
            txtIDbox.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SeaShell;
            label5.Location = new Point(458, 246);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 49;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaShell;
            label4.Location = new Point(205, 285);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 48;
            label4.Text = "CNIC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Location = new Point(443, 278);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 47;
            label3.Text = "Contact";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Location = new Point(205, 316);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 46;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Location = new Point(229, 247);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 45;
            label1.Text = "ID";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(952, 639);
            Controls.Add(txtupdateEmployee);
            Controls.Add(txtsalarybox);
            Controls.Add(label6);
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
            Controls.Add(updategrid);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form9";
            Text = "Update Employees";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)updategrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView updategrid;
        private Button txtupdateEmployee;
        private TextBox txtsalarybox;
        private Label label6;
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
    }
}