namespace TEST
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            txtLastName = new TextBox();
            lbName = new Label();
            lbLastName = new Label();
            dgCustomer = new DataGridView();
            customerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(96, 207);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 27);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(180, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 27);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(235, 23);
            txtName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(11, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(235, 23);
            txtLastName.TabIndex = 4;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(12, 9);
            lbName.Name = "lbName";
            lbName.Size = new Size(41, 15);
            lbName.TabIndex = 5;
            lbName.Text = "NAME";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(12, 67);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(63, 15);
            lbLastName.TabIndex = 6;
            lbLastName.Text = "Last Name";
            // 
            // dgCustomer
            // 
            dgCustomer.AutoGenerateColumns = false;
            dgCustomer.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgCustomer.BorderStyle = BorderStyle.None;
            dgCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.DataSource = customerBindingSource;
            dgCustomer.EnableHeadersVisualStyles = false;
            dgCustomer.GridColor = Color.SteelBlue;
            dgCustomer.Location = new Point(264, 27);
            dgCustomer.Name = "dgCustomer";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgCustomer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgCustomer.Size = new Size(346, 207);
            dgCustomer.TabIndex = 7;
            dgCustomer.CellContentClick += dgCustomer_CellContentClick;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Entity.Customer);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 254);
            Controls.Add(dgCustomer);
            Controls.Add(lbLastName);
            Controls.Add(lbName);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtName;
        private TextBox txtLastName;
        private Label lbName;
        private Label lbLastName;
        private DataGridView dgCustomer;
        private BindingSource customerBindingSource;
        private DataGridViewTextBoxColumn namneDataGridViewTextBoxColumn;
    }
}
