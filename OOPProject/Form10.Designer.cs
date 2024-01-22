namespace OOPProject
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            txtID = new TextBox();
            SearchButton = new Button();
            label1 = new Label();
            EmployeesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)EmployeesGrid).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.BackColor = Color.PeachPuff;
            txtID.Location = new Point(429, 330);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(42, 28);
            txtID.TabIndex = 7;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightSalmon;
            SearchButton.Location = new Point(510, 321);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(87, 38);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(350, 335);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 5;
            label1.Text = "Enter ID";
            // 
            // EmployeesGrid
            // 
            EmployeesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmployeesGrid.BackgroundColor = Color.PeachPuff;
            EmployeesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesGrid.GridColor = Color.DarkSalmon;
            EmployeesGrid.Location = new Point(12, 413);
            EmployeesGrid.Margin = new Padding(3, 2, 3, 2);
            EmployeesGrid.Name = "EmployeesGrid";
            EmployeesGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            EmployeesGrid.Size = new Size(879, 217);
            EmployeesGrid.TabIndex = 4;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(910, 641);
            Controls.Add(txtID);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(EmployeesGrid);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form10";
            Text = "Employee Registry";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Button SearchButton;
        private Label label1;
        private DataGridView EmployeesGrid;
    }
}