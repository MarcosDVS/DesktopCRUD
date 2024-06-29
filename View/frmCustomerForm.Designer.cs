namespace TEST.View
{
    partial class frmCustomerForm
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
            btnSave = new Button();
            txtName = new TextBox();
            txtLastName = new TextBox();
            lbName = new Label();
            lbLastName = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(73, 156);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 23);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(232, 23);
            txtLastName.TabIndex = 2;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(12, 28);
            lbName.Name = "lbName";
            lbName.Size = new Size(55, 19);
            lbName.TabIndex = 3;
            lbName.Text = "Name";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLastName.Location = new Point(12, 87);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(90, 19);
            lbLastName.TabIndex = 4;
            lbLastName.Text = "LastName";
            // 
            // frmCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 202);
            Controls.Add(lbLastName);
            Controls.Add(lbName);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtName;
        private TextBox txtLastName;
        private Label lbName;
        private Label lbLastName;
    }
}