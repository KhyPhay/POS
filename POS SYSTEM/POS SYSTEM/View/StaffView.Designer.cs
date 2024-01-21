namespace POS_SYSTEM.View
{
    partial class StaffView
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
            this.categoryDataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dvgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.addCategory = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dvgGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryDataTable
            // 
            this.categoryDataTable.AllowUserToAddRows = false;
            this.categoryDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.categoryDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryDataTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categoryDataTable.ColumnHeadersHeight = 40;
            this.categoryDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categoryDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgID,
            this.dvgName,
            this.dvgTel,
            this.dvgrole,
            this.dvgGender});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.categoryDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoryDataTable.Location = new System.Drawing.Point(26, 153);
            this.categoryDataTable.Name = "categoryDataTable";
            this.categoryDataTable.ReadOnly = true;
            this.categoryDataTable.RowHeadersVisible = false;
            this.categoryDataTable.RowHeadersWidth = 51;
            this.categoryDataTable.RowTemplate.Height = 24;
            this.categoryDataTable.Size = new System.Drawing.Size(746, 285);
            this.categoryDataTable.TabIndex = 5;
            this.categoryDataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.categoryDataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.categoryDataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.categoryDataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.categoryDataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.categoryDataTable.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryDataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoryDataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGray;
            this.categoryDataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categoryDataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.categoryDataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categoryDataTable.ThemeStyle.HeaderStyle.Height = 40;
            this.categoryDataTable.ThemeStyle.ReadOnly = true;
            this.categoryDataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.categoryDataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categoryDataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categoryDataTable.ThemeStyle.RowsStyle.Height = 24;
            this.categoryDataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.categoryDataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categoryDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataTable_CellContentClick);
            // 
            // dvgID
            // 
            this.dvgID.FillWeight = 82.85175F;
            this.dvgID.HeaderText = "ID";
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
            // dvgTel
            // 
            this.dvgTel.HeaderText = "Phone Number";
            this.dvgTel.MinimumWidth = 6;
            this.dvgTel.Name = "dvgTel";
            this.dvgTel.ReadOnly = true;
            // 
            // dvgrole
            // 
            this.dvgrole.HeaderText = "Role";
            this.dvgrole.MinimumWidth = 6;
            this.dvgrole.Name = "dvgrole";
            this.dvgrole.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 90.71359F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::POS_SYSTEM.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 194;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 93.58289F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::POS_SYSTEM.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 199;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(26, 105);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(751, 8);
            this.guna2Separator1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "List Emplyee";
            // 
            // addCategory
            // 
            this.addCategory.FillColor = System.Drawing.Color.Transparent;
            this.addCategory.Image = global::POS_SYSTEM.Properties.Resources.plus1;
            this.addCategory.ImageRotate = 0F;
            this.addCategory.Location = new System.Drawing.Point(26, 62);
            this.addCategory.Name = "addCategory";
            this.addCategory.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addCategory.Size = new System.Drawing.Size(53, 46);
            this.addCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addCategory.TabIndex = 6;
            this.addCategory.TabStop = false;
            // 
            // dvgGender
            // 
            this.dvgGender.HeaderText = "Gender";
            this.dvgGender.MinimumWidth = 6;
            this.dvgGender.Name = "dvgGender";
            this.dvgGender.ReadOnly = true;
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.categoryDataTable);
            this.Name = "StaffView";
            this.Text = "StaffView";
            this.Load += new System.EventHandler(this.StaffView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView categoryDataTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox addCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgGender;
    }
}