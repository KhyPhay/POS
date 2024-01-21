namespace POS_SYSTEM.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.product = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.productName = new System.Windows.Forms.Label();
            this.txImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txImage)).BeginInit();
            this.SuspendLayout();
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.Transparent;
            this.product.Controls.Add(this.guna2Separator1);
            this.product.Controls.Add(this.productName);
            this.product.Controls.Add(this.txImage);
            this.product.FillColor = System.Drawing.Color.White;
            this.product.Location = new System.Drawing.Point(3, 3);
            this.product.Name = "product";
            this.product.ShadowColor = System.Drawing.Color.Black;
            this.product.Size = new System.Drawing.Size(182, 181);
            this.product.TabIndex = 0;
            this.product.Paint += new System.Windows.Forms.PaintEventHandler(this.product_Paint);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 120);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(158, 11);
            this.guna2Separator1.TabIndex = 2;
            // 
            // productName
            // 
            this.productName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(3, 119);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(179, 48);
            this.productName.TabIndex = 1;
            this.productName.Text = "Product Name";
            this.productName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productName.Click += new System.EventHandler(this.productName_Click);
            // 
            // txImage
            // 
            this.txImage.Image = global::POS_SYSTEM.Properties.Resources.logo_system;
            this.txImage.ImageRotate = 0F;
            this.txImage.Location = new System.Drawing.Point(12, 15);
            this.txImage.Name = "txImage";
            this.txImage.Size = new System.Drawing.Size(170, 87);
            this.txImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txImage.TabIndex = 0;
            this.txImage.TabStop = false;
            this.txImage.UseTransparentBackground = true;
            this.txImage.Click += new System.EventHandler(this.txImage_Click_1);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.product);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(185, 184);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            this.product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel product;
        private Guna.UI2.WinForms.Guna2PictureBox txImage;
        private System.Windows.Forms.Label productName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
