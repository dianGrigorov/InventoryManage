namespace InventoryManage.Forms
{
    partial class FormProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataProductGV = new System.Windows.Forms.DataGridView();
            this.clearBtn = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.Label();
            this.productColor = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.productColorTb = new System.Windows.Forms.TextBox();
            this.productPriceTb = new System.Windows.Forms.TextBox();
            this.productDescriptionTb = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.productIdTb = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProductGV
            // 
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            this.dataProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProductGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProductGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataProductGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataProductGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProductGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataProductGV.Location = new System.Drawing.Point(472, 9);
            this.dataProductGV.Name = "dataProductGV";
            this.dataProductGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataProductGV.RowHeadersVisible = false;
            this.dataProductGV.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataProductGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataProductGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataProductGV.RowTemplate.ReadOnly = true;
            this.dataProductGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProductGV.Size = new System.Drawing.Size(320, 374);
            this.dataProductGV.TabIndex = 16;
            this.dataProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustomersGV_CellContentClick);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(7, 343);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(172, 40);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productName.Location = new System.Drawing.Point(22, 54);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(61, 21);
            this.productName.TabIndex = 17;
            this.productName.Text = "Name";
            // 
            // productColor
            // 
            this.productColor.AutoSize = true;
            this.productColor.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productColor.Location = new System.Drawing.Point(23, 93);
            this.productColor.Name = "productColor";
            this.productColor.Size = new System.Drawing.Size(60, 21);
            this.productColor.TabIndex = 18;
            this.productColor.Text = "Color";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPrice.Location = new System.Drawing.Point(27, 132);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(56, 21);
            this.productPrice.TabIndex = 19;
            this.productPrice.Text = "Price";
            // 
            // productNameTb
            // 
            this.productNameTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productNameTb.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameTb.Location = new System.Drawing.Point(195, 48);
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(271, 33);
            this.productNameTb.TabIndex = 20;
            // 
            // productColorTb
            // 
            this.productColorTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productColorTb.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productColorTb.Location = new System.Drawing.Point(195, 87);
            this.productColorTb.Name = "productColorTb";
            this.productColorTb.Size = new System.Drawing.Size(271, 33);
            this.productColorTb.TabIndex = 21;
            // 
            // productPriceTb
            // 
            this.productPriceTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productPriceTb.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceTb.Location = new System.Drawing.Point(195, 126);
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.Size = new System.Drawing.Size(271, 33);
            this.productPriceTb.TabIndex = 22;
            // 
            // productDescriptionTb
            // 
            this.productDescriptionTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productDescriptionTb.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productDescriptionTb.Location = new System.Drawing.Point(195, 165);
            this.productDescriptionTb.Multiline = true;
            this.productDescriptionTb.Name = "productDescriptionTb";
            this.productDescriptionTb.Size = new System.Drawing.Size(271, 218);
            this.productDescriptionTb.TabIndex = 23;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(22, 171);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(114, 21);
            this.description.TabIndex = 24;
            this.description.Text = "Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(7, 251);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(172, 40);
            this.editBtn.TabIndex = 26;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(7, 297);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(172, 40);
            this.delBtn.TabIndex = 27;
            this.delBtn.Text = "DEL";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // productIdTb
            // 
            this.productIdTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productIdTb.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdTb.Location = new System.Drawing.Point(195, 9);
            this.productIdTb.Name = "productIdTb";
            this.productIdTb.Size = new System.Drawing.Size(271, 33);
            this.productIdTb.TabIndex = 28;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(22, 15);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(104, 21);
            this.ID.TabIndex = 29;
            this.ID.Text = "Product ID";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.productIdTb);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.productDescriptionTb);
            this.Controls.Add(this.productPriceTb);
            this.Controls.Add(this.productColorTb);
            this.Controls.Add(this.productNameTb);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productColor);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.dataProductGV);
            this.Controls.Add(this.clearBtn);
            this.Name = "FormProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataProductGV;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productColor;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.TextBox productNameTb;
        private System.Windows.Forms.TextBox productColorTb;
        private System.Windows.Forms.TextBox productPriceTb;
        private System.Windows.Forms.TextBox productDescriptionTb;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox productIdTb;
        private System.Windows.Forms.Label ID;
    }
}