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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAdd.Location = new Point(424, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkOrange;
            btnEdit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnEdit.Location = new Point(328, 302);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(424, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(13, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 23);
            txtName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(218, 29);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(198, 23);
            txtLastName.TabIndex = 4;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(14, 10);
            lbName.Name = "lbName";
            lbName.Size = new Size(46, 16);
            lbName.TabIndex = 5;
            lbName.Text = "NAME";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(219, 10);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(75, 16);
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
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            dgCustomer.DataSource = customerBindingSource;
            dgCustomer.EnableHeadersVisualStyles = false;
            dgCustomer.GridColor = Color.SteelBlue;
            dgCustomer.Location = new Point(13, 65);
            dgCustomer.MultiSelect = false;
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgCustomer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(501, 230);
            dgCustomer.TabIndex = 7;
            dgCustomer.CellContentClick += dgCustomer_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Entity.Customer);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 343);
            Controls.Add(dgCustomer);
            Controls.Add(lbLastName);
            Controls.Add(lbName);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CUSTOMER";
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}
