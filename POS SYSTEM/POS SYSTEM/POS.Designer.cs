namespace POS_SYSTEM
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProduct1 = new POS_SYSTEM.Model.ucProduct();
            this.ucProduct2 = new POS_SYSTEM.Model.ucProduct();
            this.ucProduct3 = new POS_SYSTEM.Model.ucProduct();
            this.ucProduct4 = new POS_SYSTEM.Model.ucProduct();
            this.ucProduct5 = new POS_SYSTEM.Model.ucProduct();
            this.ucProduct6 = new POS_SYSTEM.Model.ucProduct();
            this.invoidView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dvgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.viewHisBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoidView)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.Controls.Add(this.ucProduct1);
            this.ProductPanel.Controls.Add(this.ucProduct2);
            this.ProductPanel.Controls.Add(this.ucProduct3);
            this.ProductPanel.Controls.Add(this.ucProduct4);
            this.ProductPanel.Controls.Add(this.ucProduct5);
            this.ProductPanel.Controls.Add(this.ucProduct6);
            this.ProductPanel.Location = new System.Drawing.Point(0, 170);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(419, 494);
            this.ProductPanel.TabIndex = 0;
            // 
            // ucProduct1
            // 
            this.ucProduct1.id = 0;
            this.ucProduct1.Location = new System.Drawing.Point(3, 3);
            this.ucProduct1.Name = "ucProduct1";
            this.ucProduct1.PCategory = null;
            this.ucProduct1.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct1.PImage")));
            this.ucProduct1.PName = "Product Name";
            this.ucProduct1.PPrice = null;
            this.ucProduct1.PQuality = null;
            this.ucProduct1.Size = new System.Drawing.Size(193, 185);
            this.ucProduct1.TabIndex = 0;
            // 
            // ucProduct2
            // 
            this.ucProduct2.id = 0;
            this.ucProduct2.Location = new System.Drawing.Point(202, 3);
            this.ucProduct2.Name = "ucProduct2";
            this.ucProduct2.PCategory = null;
            this.ucProduct2.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct2.PImage")));
            this.ucProduct2.PName = "Product Name";
            this.ucProduct2.PPrice = null;
            this.ucProduct2.PQuality = null;
            this.ucProduct2.Size = new System.Drawing.Size(193, 185);
            this.ucProduct2.TabIndex = 1;
            // 
            // ucProduct3
            // 
            this.ucProduct3.id = 0;
            this.ucProduct3.Location = new System.Drawing.Point(3, 194);
            this.ucProduct3.Name = "ucProduct3";
            this.ucProduct3.PCategory = null;
            this.ucProduct3.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct3.PImage")));
            this.ucProduct3.PName = "Product Name";
            this.ucProduct3.PPrice = null;
            this.ucProduct3.PQuality = null;
            this.ucProduct3.Size = new System.Drawing.Size(193, 185);
            this.ucProduct3.TabIndex = 2;
            // 
            // ucProduct4
            // 
            this.ucProduct4.id = 0;
            this.ucProduct4.Location = new System.Drawing.Point(202, 194);
            this.ucProduct4.Name = "ucProduct4";
            this.ucProduct4.PCategory = null;
            this.ucProduct4.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct4.PImage")));
            this.ucProduct4.PName = "Product Name";
            this.ucProduct4.PPrice = null;
            this.ucProduct4.PQuality = null;
            this.ucProduct4.Size = new System.Drawing.Size(193, 185);
            this.ucProduct4.TabIndex = 3;
            // 
            // ucProduct5
            // 
            this.ucProduct5.id = 0;
            this.ucProduct5.Location = new System.Drawing.Point(3, 385);
            this.ucProduct5.Name = "ucProduct5";
            this.ucProduct5.PCategory = null;
            this.ucProduct5.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct5.PImage")));
            this.ucProduct5.PName = "Product Name";
            this.ucProduct5.PPrice = null;
            this.ucProduct5.PQuality = null;
            this.ucProduct5.Size = new System.Drawing.Size(193, 185);
            this.ucProduct5.TabIndex = 4;
            // 
            // ucProduct6
            // 
            this.ucProduct6.id = 0;
            this.ucProduct6.Location = new System.Drawing.Point(202, 385);
            this.ucProduct6.Name = "ucProduct6";
            this.ucProduct6.PCategory = null;
            this.ucProduct6.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct6.PImage")));
            this.ucProduct6.PName = "Product Name";
            this.ucProduct6.PPrice = null;
            this.ucProduct6.PQuality = null;
            this.ucProduct6.Size = new System.Drawing.Size(193, 185);
            this.ucProduct6.TabIndex = 5;
            // 
            // invoidView
            // 
            this.invoidView.AllowUserToAddRows = false;
            this.invoidView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.invoidView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.invoidView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoidView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.invoidView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invoidView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoidView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.invoidView.ColumnHeadersHeight = 40;
            this.invoidView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.invoidView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgID,
            this.dvgName,
            this.dvgPrice,
            this.dvgQuality,
            this.dvgAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoidView.DefaultCellStyle = dataGridViewCellStyle3;
            this.invoidView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoidView.Location = new System.Drawing.Point(425, 160);
            this.invoidView.Name = "invoidView";
            this.invoidView.ReadOnly = true;
            this.invoidView.RowHeadersVisible = false;
            this.invoidView.RowHeadersWidth = 51;
            this.invoidView.RowTemplate.Height = 24;
            this.invoidView.Size = new System.Drawing.Size(748, 401);
            this.invoidView.TabIndex = 8;
            this.invoidView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.invoidView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.invoidView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.invoidView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.invoidView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.invoidView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invoidView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoidView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.invoidView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.invoidView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.invoidView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.invoidView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.invoidView.ThemeStyle.HeaderStyle.Height = 40;
            this.invoidView.ThemeStyle.ReadOnly = true;
            this.invoidView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.invoidView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.invoidView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoidView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.invoidView.ThemeStyle.RowsStyle.Height = 24;
            this.invoidView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoidView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dvgID
            // 
            this.dvgID.FillWeight = 82.85175F;
            this.dvgID.HeaderText = "#NO";
            this.dvgID.MinimumWidth = 6;
            this.dvgID.Name = "dvgID";
            this.dvgID.ReadOnly = true;
            // 
            // dvgName
            // 
            this.dvgName.FillWeight = 82.85175F;
            this.dvgName.HeaderText = "Name";
            this.dvgName.MinimumWidth = 6;
            this.dvgName.Name = "dvgName";
            this.dvgName.ReadOnly = true;
            // 
            // dvgPrice
            // 
            this.dvgPrice.HeaderText = "Price";
            this.dvgPrice.MinimumWidth = 6;
            this.dvgPrice.Name = "dvgPrice";
            this.dvgPrice.ReadOnly = true;
            // 
            // dvgQuality
            // 
            this.dvgQuality.HeaderText = "Quantity";
            this.dvgQuality.MinimumWidth = 6;
            this.dvgQuality.Name = "dvgQuality";
            this.dvgQuality.ReadOnly = true;
            // 
            // dvgAmount
            // 
            this.dvgAmount.HeaderText = "Amount";
            this.dvgAmount.MinimumWidth = 6;
            this.dvgAmount.Name = "dvgAmount";
            this.dvgAmount.ReadOnly = true;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.cancelBtn);
            this.footerPanel.Controls.Add(this.saveBtn);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.FillColor = System.Drawing.Color.Silver;
            this.footerPanel.Location = new System.Drawing.Point(0, 659);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1173, 94);
            this.footerPanel.TabIndex = 9;
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoRoundedCorners = true;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BorderRadius = 23;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Gray;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(1007, 33);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(129, 48);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "CANCEL";
            // 
            // saveBtn
            // 
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderRadius = 23;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(831, 34);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 48);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(1038, 564);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(67, 31);
            this.Total.TabIndex = 1;
            this.Total.Text = "00,00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(947, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.viewHisBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1173, 113);
            this.guna2Panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "POS";
            // 
            // viewHisBtn
            // 
            this.viewHisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewHisBtn.AutoRoundedCorners = true;
            this.viewHisBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewHisBtn.BorderRadius = 25;
            this.viewHisBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewHisBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewHisBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewHisBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewHisBtn.FillColor = System.Drawing.Color.Silver;
            this.viewHisBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewHisBtn.ForeColor = System.Drawing.Color.Black;
            this.viewHisBtn.Location = new System.Drawing.Point(1010, 37);
            this.viewHisBtn.Name = "viewHisBtn";
            this.viewHisBtn.Size = new System.Drawing.Size(151, 52);
            this.viewHisBtn.TabIndex = 0;
            this.viewHisBtn.Text = "View History";
            this.viewHisBtn.Click += new System.EventHandler(this.viewHisBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.DefaultText = "";
            this.searchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.Location = new System.Drawing.Point(121, 123);
            this.searchTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTB.Name = "searchTB";
            this.searchTB.PasswordChar = '\0';
            this.searchTB.PlaceholderText = "";
            this.searchTB.SelectedText = "";
            this.searchTB.Size = new System.Drawing.Size(298, 43);
            this.searchTB.TabIndex = 0;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 753);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.invoidView);
            this.Controls.Add(this.ProductPanel);
            this.Name = "POS";
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POS_Load);
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoidView)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2DataGridView invoidView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgAmount;
        private Model.ucProduct ucProduct1;
        private Model.ucProduct ucProduct2;
        private Model.ucProduct ucProduct3;
        private Model.ucProduct ucProduct4;
        private Model.ucProduct ucProduct5;
        private Model.ucProduct ucProduct6;
        private Guna.UI2.WinForms.Guna2Panel footerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button viewHisBtn;
    }
}