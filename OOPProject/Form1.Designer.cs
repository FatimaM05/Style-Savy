namespace OOPProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            txtUpdate = new Button();
            txtdeletecustomer = new Button();
            txtAddCustomer = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Location = new Point(447, 326);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(202, 66);
            button1.TabIndex = 19;
            button1.Text = "View Customers";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtUpdate
            // 
            txtUpdate.BackColor = Color.DarkSalmon;
            txtUpdate.Location = new Point(447, 237);
            txtUpdate.Margin = new Padding(3, 2, 3, 2);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(202, 69);
            txtUpdate.TabIndex = 18;
            txtUpdate.Text = "Update Customer";
            txtUpdate.UseVisualStyleBackColor = false;
            txtUpdate.Click += txtUpdate_Click;
            // 
            // txtdeletecustomer
            // 
            txtdeletecustomer.BackColor = Color.DarkSalmon;
            txtdeletecustomer.Location = new Point(184, 326);
            txtdeletecustomer.Margin = new Padding(3, 2, 3, 2);
            txtdeletecustomer.Name = "txtdeletecustomer";
            txtdeletecustomer.Size = new Size(186, 66);
            txtdeletecustomer.TabIndex = 17;
            txtdeletecustomer.Text = "Delete Customer";
            txtdeletecustomer.UseVisualStyleBackColor = false;
            txtdeletecustomer.Click += txtdeletecustomer_Click;
            // 
            // txtAddCustomer
            // 
            txtAddCustomer.BackColor = Color.DarkSalmon;
            txtAddCustomer.Location = new Point(183, 237);
            txtAddCustomer.Margin = new Padding(3, 2, 3, 2);
            txtAddCustomer.Name = "txtAddCustomer";
            txtAddCustomer.Size = new Size(187, 69);
            txtAddCustomer.TabIndex = 16;
            txtAddCustomer.Text = "Add Customer";
            txtAddCustomer.UseVisualStyleBackColor = false;
            txtAddCustomer.Click += txtAddCustomer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(760, 580);
            Controls.Add(button1);
            Controls.Add(txtUpdate);
            Controls.Add(txtdeletecustomer);
            Controls.Add(txtAddCustomer);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Salon Customers";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button txtUpdate;
        private Button txtdeletecustomer;
        private Button txtAddCustomer;
    }
}