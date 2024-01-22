namespace OOPProject
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            Deletegrid = new DataGridView();
            txtUpdate = new Button();
            txtID = new TextBox();
            SearchButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Deletegrid).BeginInit();
            SuspendLayout();
            // 
            // Deletegrid
            // 
            Deletegrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Deletegrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Deletegrid.BackgroundColor = Color.PeachPuff;
            Deletegrid.BorderStyle = BorderStyle.Fixed3D;
            Deletegrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.SeaShell;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Deletegrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Deletegrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Deletegrid.GridColor = Color.DarkSalmon;
            Deletegrid.Location = new Point(12, 248);
            Deletegrid.Margin = new Padding(3, 2, 3, 2);
            Deletegrid.Name = "Deletegrid";
            Deletegrid.RowHeadersWidth = 62;
            Deletegrid.Size = new Size(964, 171);
            Deletegrid.TabIndex = 40;
            // 
            // txtUpdate
            // 
            txtUpdate.BackColor = Color.LightSalmon;
            txtUpdate.Location = new Point(422, 194);
            txtUpdate.Margin = new Padding(3, 2, 3, 2);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(181, 36);
            txtUpdate.TabIndex = 39;
            txtUpdate.Text = "Delete Customer";
            txtUpdate.UseVisualStyleBackColor = false;
            txtUpdate.Click += txtUpdate_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(471, 149);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(33, 28);
            txtID.TabIndex = 44;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(534, 145);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(84, 34);
            SearchButton.TabIndex = 43;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 152);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 42;
            label2.Text = "Enter ID";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(985, 430);
            Controls.Add(txtID);
            Controls.Add(SearchButton);
            Controls.Add(label2);
            Controls.Add(Deletegrid);
            Controls.Add(txtUpdate);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form5";
            Text = "Delete Customer";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)Deletegrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView Deletegrid;
        private Button txtUpdate;
        private TextBox txtID;
        private Button SearchButton;
        private Label label2;
    }
}