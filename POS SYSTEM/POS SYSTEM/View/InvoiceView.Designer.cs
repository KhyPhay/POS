namespace POS_SYSTEM.View
{
    partial class InvoiceView
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
            this.invoidView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dvgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgSeller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.viewPosBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoidView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoidView
            // 
            this.invoidView.AllowUserToAddRows = false;
            this.invoidView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.invoidView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.invoidView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dvgDate,
            this.dvgPrice,
            this.dvgQuality,
            this.dvgAmount,
            this.dvgSeller});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoidView.DefaultCellStyle = dataGridViewCellStyle3;
            this.invoidView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoidView.Location = new System.Drawing.Point(0, 92);
            this.invoidView.Name = "invoidView";
            this.invoidView.ReadOnly = true;
            this.invoidView.RowHeadersVisible = false;
            this.invoidView.RowHeadersWidth = 51;
            this.invoidView.RowTemplate.Height = 24;
            this.invoidView.Size = new System.Drawing.Size(1377, 492);
            this.invoidView.TabIndex = 9;
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
            this.invoidView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoidView_CellContentClick);
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
            // dvgDate
            // 
            this.dvgDate.HeaderText = "Date";
            this.dvgDate.MinimumWidth = 6;
            this.dvgDate.Name = "dvgDate";
            this.dvgDate.ReadOnly = true;
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
            // dvgSeller
            // 
            this.dvgSeller.HeaderText = "Seller";
            this.dvgSeller.MinimumWidth = 6;
            this.dvgSeller.Name = "dvgSeller";
            this.dvgSeller.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.viewPosBtn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1380, 88);
            this.guna2Panel1.TabIndex = 10;
            // 
            // viewPosBtn
            // 
            this.viewPosBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPosBtn.AutoRoundedCorners = true;
            this.viewPosBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewPosBtn.BorderRadius = 25;
            this.viewPosBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewPosBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewPosBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewPosBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewPosBtn.FillColor = System.Drawing.Color.Silver;
            this.viewPosBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewPosBtn.ForeColor = System.Drawing.Color.Black;
            this.viewPosBtn.Location = new System.Drawing.Point(1253, 17);
            this.viewPosBtn.Name = "viewPosBtn";
            this.viewPosBtn.Size = new System.Drawing.Size(115, 52);
            this.viewPosBtn.TabIndex = 1;
            this.viewPosBtn.Text = "View POS";
            this.viewPosBtn.Click += new System.EventHandler(this.viewPosBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice History";
            // 
            // InvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 584);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.invoidView);
            this.Name = "InvoiceView";
            this.Text = "InvoiceView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InvoiceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoidView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView invoidView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSeller;
        private Guna.UI2.WinForms.Guna2Button viewPosBtn;
    }
}