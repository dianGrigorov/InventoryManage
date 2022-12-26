namespace InventoryManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.stockBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.reportingBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.stockBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.ordersBtn);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.reportingBtn);
            this.panelMenu.Controls.Add(this.customersBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(171, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // stockBtn
            // 
            this.stockBtn.FlatAppearance.BorderSize = 0;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.stockBtn.Image = ((System.Drawing.Image)(resources.GetObject("stockBtn.Image")));
            this.stockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn.Location = new System.Drawing.Point(2, 280);
            this.stockBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.stockBtn.Size = new System.Drawing.Size(171, 49);
            this.stockBtn.TabIndex = 5;
            this.stockBtn.Text = "  Stock";
            this.stockBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(171, 65);
            this.panelLogo.TabIndex = 1;
            // 
            // lbLogo
            // 
            this.lbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbLogo.Location = new System.Drawing.Point(58, 19);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(61, 27);
            this.lbLogo.TabIndex = 1;
            this.lbLogo.Text = "BoM";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordersBtn
            // 
            this.ordersBtn.FlatAppearance.BorderSize = 0;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ordersBtn.Image = ((System.Drawing.Image)(resources.GetObject("ordersBtn.Image")));
            this.ordersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersBtn.Location = new System.Drawing.Point(2, 68);
            this.ordersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ordersBtn.Size = new System.Drawing.Size(171, 49);
            this.ordersBtn.TabIndex = 3;
            this.ordersBtn.Text = "  Orders";
            this.ordersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ordersBtn.UseVisualStyleBackColor = true;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(2, 174);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(171, 49);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "  Products";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // reportingBtn
            // 
            this.reportingBtn.FlatAppearance.BorderSize = 0;
            this.reportingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportingBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportingBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportingBtn.Image")));
            this.reportingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportingBtn.Location = new System.Drawing.Point(2, 227);
            this.reportingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reportingBtn.Name = "reportingBtn";
            this.reportingBtn.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.reportingBtn.Size = new System.Drawing.Size(171, 49);
            this.reportingBtn.TabIndex = 4;
            this.reportingBtn.Text = "  Reporting";
            this.reportingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportingBtn.UseVisualStyleBackColor = true;
            this.reportingBtn.Click += new System.EventHandler(this.reportingBtn_Click);
            // 
            // customersBtn
            // 
            this.customersBtn.FlatAppearance.BorderSize = 0;
            this.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.customersBtn.Image = ((System.Drawing.Image)(resources.GetObject("customersBtn.Image")));
            this.customersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersBtn.Location = new System.Drawing.Point(2, 121);
            this.customersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.customersBtn.Size = new System.Drawing.Size(171, 49);
            this.customersBtn.TabIndex = 2;
            this.customersBtn.Text = "  Customers";
            this.customersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customersBtn.UseVisualStyleBackColor = true;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(139)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(171, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(933, 65);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMinimize.Location = new System.Drawing.Point(843, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "o";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMaximize.Location = new System.Drawing.Point(873, 3);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "o";
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.Location = new System.Drawing.Point(903, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "o";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(5, 3);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(53, 56);
            this.btnCloseChildForm.TabIndex = 0;
            this.btnCloseChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(399, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(171, 65);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(933, 546);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 611);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button reportingBtn;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnExit;
    }
}
