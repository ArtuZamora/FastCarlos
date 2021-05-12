namespace Proyecto
{
    partial class ProductMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.shoppingCartBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictProd1 = new System.Windows.Forms.PictureBox();
            this.lblPriceProd1 = new System.Windows.Forms.Label();
            this.lblNameProd1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNameProd2 = new System.Windows.Forms.Label();
            this.pictProd2 = new System.Windows.Forms.PictureBox();
            this.lblPriceProd2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNameProd3 = new System.Windows.Forms.Label();
            this.pictProd3 = new System.Windows.Forms.PictureBox();
            this.lblPriceProd3 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lastSet = new System.Windows.Forms.PictureBox();
            this.nextSet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProd1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProd2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.flecha;
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(343, 38);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(122, 33);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Product";
            // 
            // shoppingCartBtn
            // 
            this.shoppingCartBtn.BackColor = System.Drawing.Color.Transparent;
            this.shoppingCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shoppingCartBtn.Image = global::Proyecto.Properties.Resources.carro;
            this.shoppingCartBtn.Location = new System.Drawing.Point(678, 30);
            this.shoppingCartBtn.Name = "shoppingCartBtn";
            this.shoppingCartBtn.Size = new System.Drawing.Size(54, 52);
            this.shoppingCartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shoppingCartBtn.TabIndex = 2;
            this.shoppingCartBtn.TabStop = false;
            this.shoppingCartBtn.Click += new System.EventHandler(this.shoppingCartBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictProd1);
            this.panel1.Controls.Add(this.lblPriceProd1);
            this.panel1.Controls.Add(this.lblNameProd1);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 212);
            this.panel1.TabIndex = 3;
            // 
            // pictProd1
            // 
            this.pictProd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictProd1.Image = global::Proyecto.Properties.Resources.notimage;
            this.pictProd1.Location = new System.Drawing.Point(-1, -1);
            this.pictProd1.Name = "pictProd1";
            this.pictProd1.Size = new System.Drawing.Size(250, 166);
            this.pictProd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictProd1.TabIndex = 0;
            this.pictProd1.TabStop = false;
            this.pictProd1.Click += new System.EventHandler(this.pictProd1_Click);
            // 
            // lblPriceProd1
            // 
            this.lblPriceProd1.AutoEllipsis = true;
            this.lblPriceProd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lblPriceProd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPriceProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProd1.ForeColor = System.Drawing.Color.White;
            this.lblPriceProd1.Location = new System.Drawing.Point(173, 160);
            this.lblPriceProd1.Name = "lblPriceProd1";
            this.lblPriceProd1.Size = new System.Drawing.Size(76, 52);
            this.lblPriceProd1.TabIndex = 4;
            this.lblPriceProd1.Text = "$0.00";
            this.lblPriceProd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameProd1
            // 
            this.lblNameProd1.AutoSize = true;
            this.lblNameProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProd1.Location = new System.Drawing.Point(3, 179);
            this.lblNameProd1.Name = "lblNameProd1";
            this.lblNameProd1.Size = new System.Drawing.Size(89, 16);
            this.lblNameProd1.TabIndex = 5;
            this.lblNameProd1.Text = "Nombre Prod";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNameProd2);
            this.panel2.Controls.Add(this.pictProd2);
            this.panel2.Controls.Add(this.lblPriceProd2);
            this.panel2.Location = new System.Drawing.Point(275, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 212);
            this.panel2.TabIndex = 4;
            // 
            // lblNameProd2
            // 
            this.lblNameProd2.AutoSize = true;
            this.lblNameProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProd2.Location = new System.Drawing.Point(3, 178);
            this.lblNameProd2.Name = "lblNameProd2";
            this.lblNameProd2.Size = new System.Drawing.Size(89, 16);
            this.lblNameProd2.TabIndex = 6;
            this.lblNameProd2.Text = "Nombre Prod";
            // 
            // pictProd2
            // 
            this.pictProd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictProd2.Image = ((System.Drawing.Image)(resources.GetObject("pictProd2.Image")));
            this.pictProd2.Location = new System.Drawing.Point(-1, -1);
            this.pictProd2.Name = "pictProd2";
            this.pictProd2.Size = new System.Drawing.Size(250, 165);
            this.pictProd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictProd2.TabIndex = 0;
            this.pictProd2.TabStop = false;
            this.pictProd2.Click += new System.EventHandler(this.pictProd2_Click);
            // 
            // lblPriceProd2
            // 
            this.lblPriceProd2.AutoEllipsis = true;
            this.lblPriceProd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lblPriceProd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPriceProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProd2.ForeColor = System.Drawing.Color.White;
            this.lblPriceProd2.Location = new System.Drawing.Point(170, 158);
            this.lblPriceProd2.Name = "lblPriceProd2";
            this.lblPriceProd2.Size = new System.Drawing.Size(79, 52);
            this.lblPriceProd2.TabIndex = 7;
            this.lblPriceProd2.Text = "$0.00";
            this.lblPriceProd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblNameProd3);
            this.panel3.Controls.Add(this.pictProd3);
            this.panel3.Controls.Add(this.lblPriceProd3);
            this.panel3.Location = new System.Drawing.Point(538, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 212);
            this.panel3.TabIndex = 5;
            // 
            // lblNameProd3
            // 
            this.lblNameProd3.AutoSize = true;
            this.lblNameProd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProd3.Location = new System.Drawing.Point(3, 178);
            this.lblNameProd3.Name = "lblNameProd3";
            this.lblNameProd3.Size = new System.Drawing.Size(89, 16);
            this.lblNameProd3.TabIndex = 7;
            this.lblNameProd3.Text = "Nombre Prod";
            // 
            // pictProd3
            // 
            this.pictProd3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictProd3.Image = ((System.Drawing.Image)(resources.GetObject("pictProd3.Image")));
            this.pictProd3.Location = new System.Drawing.Point(-1, -1);
            this.pictProd3.Name = "pictProd3";
            this.pictProd3.Size = new System.Drawing.Size(250, 165);
            this.pictProd3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictProd3.TabIndex = 0;
            this.pictProd3.TabStop = false;
            this.pictProd3.Click += new System.EventHandler(this.pictProd3_Click);
            // 
            // lblPriceProd3
            // 
            this.lblPriceProd3.AutoEllipsis = true;
            this.lblPriceProd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.lblPriceProd3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPriceProd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProd3.ForeColor = System.Drawing.Color.White;
            this.lblPriceProd3.Location = new System.Drawing.Point(185, 161);
            this.lblPriceProd3.Name = "lblPriceProd3";
            this.lblPriceProd3.Size = new System.Drawing.Size(64, 50);
            this.lblPriceProd3.TabIndex = 8;
            this.lblPriceProd3.Text = "$0.00";
            this.lblPriceProd3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.Red;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(704, 27);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(28, 23);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "0";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(764, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastSet
            // 
            this.lastSet.BackColor = System.Drawing.Color.Transparent;
            this.lastSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastSet.Image = global::Proyecto.Properties.Resources.fIzquierda;
            this.lastSet.Location = new System.Drawing.Point(29, 353);
            this.lastSet.Name = "lastSet";
            this.lastSet.Size = new System.Drawing.Size(89, 74);
            this.lastSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastSet.TabIndex = 8;
            this.lastSet.TabStop = false;
            this.lastSet.Click += new System.EventHandler(this.lastSet_Click);
            // 
            // nextSet
            // 
            this.nextSet.BackColor = System.Drawing.Color.Transparent;
            this.nextSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextSet.Image = global::Proyecto.Properties.Resources.fDerecha;
            this.nextSet.Location = new System.Drawing.Point(690, 353);
            this.nextSet.Name = "nextSet";
            this.nextSet.Size = new System.Drawing.Size(89, 74);
            this.nextSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nextSet.TabIndex = 9;
            this.nextSet.TabStop = false;
            this.nextSet.Click += new System.EventHandler(this.nextSet_Click);
            // 
            // ProductMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextSet);
            this.Controls.Add(this.lastSet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shoppingCartBtn);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PizzaMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductMenu_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductMenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProd1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProd2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox shoppingCartBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPriceProd1;
        private System.Windows.Forms.Label lblNameProd1;
        private System.Windows.Forms.PictureBox pictProd1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictProd2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictProd3;
        public System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNameProd2;
        private System.Windows.Forms.Label lblNameProd3;
        private System.Windows.Forms.Label lblPriceProd2;
        private System.Windows.Forms.Label lblPriceProd3;
        private System.Windows.Forms.PictureBox lastSet;
        private System.Windows.Forms.PictureBox nextSet;
    }
}