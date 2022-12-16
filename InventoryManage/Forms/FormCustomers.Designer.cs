namespace InventoryManage.Forms
{
    partial class FormCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.FbProfileTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomersNameTb = new System.Windows.Forms.TextBox();
            this.CustomersPhoneTb = new System.Windows.Forms.TextBox();
            this.CustomersAddressTb = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.dataCustomersGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers name";
            // 
            // FbProfileTb
            // 
            this.FbProfileTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FbProfileTb.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FbProfileTb.Location = new System.Drawing.Point(199, 5);
            this.FbProfileTb.Name = "FbProfileTb";
            this.FbProfileTb.Size = new System.Drawing.Size(271, 30);
            this.FbProfileTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "FB Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customers phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customers address";
            // 
            // CustomersNameTb
            // 
            this.CustomersNameTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomersNameTb.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomersNameTb.Location = new System.Drawing.Point(199, 54);
            this.CustomersNameTb.Name = "CustomersNameTb";
            this.CustomersNameTb.Size = new System.Drawing.Size(271, 30);
            this.CustomersNameTb.TabIndex = 5;
            // 
            // CustomersPhoneTb
            // 
            this.CustomersPhoneTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomersPhoneTb.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomersPhoneTb.Location = new System.Drawing.Point(199, 109);
            this.CustomersPhoneTb.Name = "CustomersPhoneTb";
            this.CustomersPhoneTb.Size = new System.Drawing.Size(271, 30);
            this.CustomersPhoneTb.TabIndex = 6;
            // 
            // CustomersAddressTb
            // 
            this.CustomersAddressTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomersAddressTb.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomersAddressTb.Location = new System.Drawing.Point(199, 161);
            this.CustomersAddressTb.Multiline = true;
            this.CustomersAddressTb.Name = "CustomersAddressTb";
            this.CustomersAddressTb.Size = new System.Drawing.Size(271, 202);
            this.CustomersAddressTb.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 210);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(172, 40);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(12, 267);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(172, 40);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(12, 326);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(172, 40);
            this.removeBtn.TabIndex = 11;
            this.removeBtn.Text = "DEL";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // dataCustomersGV
            // 
            this.dataCustomersGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCustomersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataCustomersGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCustomersGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataCustomersGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataCustomersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomersGV.Location = new System.Drawing.Point(476, 5);
            this.dataCustomersGV.Name = "dataCustomersGV";
            this.dataCustomersGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCustomersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCustomersGV.RowTemplate.ReadOnly = true;
            this.dataCustomersGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCustomersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCustomersGV.Size = new System.Drawing.Size(390, 361);
            this.dataCustomersGV.TabIndex = 12;
            this.dataCustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustomersGV_CellContentClick);
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataCustomersGV);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.CustomersAddressTb);
            this.Controls.Add(this.CustomersPhoneTb);
            this.Controls.Add(this.CustomersNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FbProfileTb);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FbProfileTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomersNameTb;
        private System.Windows.Forms.TextBox CustomersPhoneTb;
        private System.Windows.Forms.TextBox CustomersAddressTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.DataGridView dataCustomersGV;
    }
}