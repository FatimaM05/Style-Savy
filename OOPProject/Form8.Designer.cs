namespace OOPProject
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            addgrid = new DataGridView();
            txtAddEmployee = new Button();
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
            ((System.ComponentModel.ISupportInitialize)addgrid).BeginInit();
            SuspendLayout();
            // 
            // addgrid
            // 
            addgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addgrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            addgrid.BackgroundColor = Color.PeachPuff;
            addgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addgrid.Location = new Point(12, 279);
            addgrid.Margin = new Padding(3, 2, 3, 2);
            addgrid.Name = "addgrid";
            addgrid.RowHeadersWidth = 62;
            addgrid.Size = new Size(884, 168);
            addgrid.TabIndex = 1;
            // 
            // txtAddEmployee
            // 
            txtAddEmployee.BackColor = Color.LightSalmon;
            txtAddEmployee.Location = new Point(781, 174);
            txtAddEmployee.Margin = new Padding(3, 2, 3, 2);
            txtAddEmployee.Name = "txtAddEmployee";
            txtAddEmployee.Size = new Size(103, 61);
            txtAddEmployee.TabIndex = 44;
            txtAddEmployee.Text = "Add Employee";
            txtAddEmployee.UseVisualStyleBackColor = false;
            txtAddEmployee.Click += txtAddEmployee_Click;
            // 
            // txtsalarybox
            // 
            txtsalarybox.BackColor = Color.PeachPuff;
            txtsalarybox.Location = new Point(557, 226);
            txtsalarybox.Margin = new Padding(3, 2, 3, 2);
            txtsalarybox.Name = "txtsalarybox";
            txtsalarybox.Size = new Size(150, 28);
            txtsalarybox.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaShell;
            label6.Location = new Point(480, 234);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 42;
            label6.Text = "Salary";
            // 
            // txtEmailBox
            // 
            txtEmailBox.BackColor = Color.PeachPuff;
            txtEmailBox.Location = new Point(557, 166);
            txtEmailBox.Margin = new Padding(3, 2, 3, 2);
            txtEmailBox.Name = "txtEmailBox";
            txtEmailBox.Size = new Size(150, 28);
            txtEmailBox.TabIndex = 41;
            // 
            // txtCNICbox
            // 
            txtCNICbox.BackColor = Color.PeachPuff;
            txtCNICbox.Location = new Point(291, 197);
            txtCNICbox.Margin = new Padding(3, 2, 3, 2);
            txtCNICbox.Name = "txtCNICbox";
            txtCNICbox.Size = new Size(135, 28);
            txtCNICbox.TabIndex = 40;
            // 
            // txtPhoneNumberBox
            // 
            txtPhoneNumberBox.BackColor = Color.PeachPuff;
            txtPhoneNumberBox.Location = new Point(557, 197);
            txtPhoneNumberBox.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumberBox.Name = "txtPhoneNumberBox";
            txtPhoneNumberBox.Size = new Size(150, 28);
            txtPhoneNumberBox.TabIndex = 39;
            // 
            // txtNameBox
            // 
            txtNameBox.BackColor = Color.PeachPuff;
            txtNameBox.Location = new Point(291, 226);
            txtNameBox.Margin = new Padding(3, 2, 3, 2);
            txtNameBox.Name = "txtNameBox";
            txtNameBox.Size = new Size(135, 28);
            txtNameBox.TabIndex = 38;
            // 
            // txtIDbox
            // 
            txtIDbox.BackColor = Color.PeachPuff;
            txtIDbox.Location = new Point(291, 164);
            txtIDbox.Margin = new Padding(3, 2, 3, 2);
            txtIDbox.Name = "txtIDbox";
            txtIDbox.Size = new Size(43, 28);
            txtIDbox.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SeaShell;
            label5.Location = new Point(484, 174);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 36;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaShell;
            label4.Location = new Point(231, 200);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 35;
            label4.Text = "CNIC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Location = new Point(469, 201);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 34;
            label3.Text = "Contact";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Location = new Point(231, 230);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 33;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Location = new Point(255, 166);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 32;
            label1.Text = "ID";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(909, 458);
            Controls.Add(txtAddEmployee);
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
            Controls.Add(addgrid);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form8";
            Text = "Add Employees";
            ((System.ComponentModel.ISupportInitialize)addgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView addgrid;
        private Button txtAddEmployee;
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