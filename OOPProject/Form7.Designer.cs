namespace OOPProject
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            DeleteGrid = new DataGridView();
            DeleteEmployee = new Button();
            txtID = new TextBox();
            SearchButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DeleteGrid).BeginInit();
            SuspendLayout();
            // 
            // DeleteGrid
            // 
            DeleteGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DeleteGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DeleteGrid.BackgroundColor = Color.PeachPuff;
            DeleteGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeleteGrid.Location = new Point(12, 262);
            DeleteGrid.Margin = new Padding(3, 2, 3, 2);
            DeleteGrid.Name = "DeleteGrid";
            DeleteGrid.RowHeadersWidth = 62;
            DeleteGrid.Size = new Size(884, 180);
            DeleteGrid.TabIndex = 0;
            // 
            // DeleteEmployee
            // 
            DeleteEmployee.BackColor = Color.LightSalmon;
            DeleteEmployee.Location = new Point(393, 218);
            DeleteEmployee.Margin = new Padding(3, 2, 3, 2);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Size = new Size(162, 40);
            DeleteEmployee.TabIndex = 1;
            DeleteEmployee.Text = "Delete Employee";
            DeleteEmployee.UseVisualStyleBackColor = false;
            DeleteEmployee.Click += DeleteEmployee_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(422, 175);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(33, 28);
            txtID.TabIndex = 47;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(485, 171);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(84, 34);
            SearchButton.TabIndex = 46;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(341, 178);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 45;
            label2.Text = "Enter ID";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(904, 453);
            Controls.Add(txtID);
            Controls.Add(SearchButton);
            Controls.Add(label2);
            Controls.Add(DeleteEmployee);
            Controls.Add(DeleteGrid);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form7";
            Text = "Delete Employees";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)DeleteGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DeleteGrid;
        private Button DeleteEmployee;
        private TextBox txtID;
        private Button SearchButton;
        private Label label2;
    }
}