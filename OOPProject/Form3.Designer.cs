namespace OOPProject
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            CustomersGrid = new DataGridView();
            label1 = new Label();
            SearchButton = new Button();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CustomersGrid).BeginInit();
            SuspendLayout();
            // 
            // CustomersGrid
            // 
            CustomersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersGrid.BackgroundColor = Color.PeachPuff;
            CustomersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGrid.GridColor = Color.DarkSalmon;
            CustomersGrid.Location = new Point(5, 251);
            CustomersGrid.Margin = new Padding(3, 2, 3, 2);
            CustomersGrid.Name = "CustomersGrid";
            CustomersGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CustomersGrid.Size = new Size(791, 312);
            CustomersGrid.TabIndex = 0;
            CustomersGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(265, 201);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter ID";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightSalmon;
            SearchButton.Location = new Point(425, 187);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(87, 38);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.PeachPuff;
            txtID.Location = new Point(344, 196);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(42, 28);
            txtID.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(806, 574);
            Controls.Add(txtID);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(CustomersGrid);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Customer Data";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)CustomersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CustomersGrid;
        private Label label1;
        private Button SearchButton;
        private TextBox txtID;
    }
}