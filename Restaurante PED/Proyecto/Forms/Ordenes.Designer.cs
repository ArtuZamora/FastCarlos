namespace Proyecto
{
    partial class Ordenes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordenes));
            this.lblNormales = new System.Windows.Forms.Label();
            this.lblVIP = new System.Windows.Forms.Label();
            this.FlwVIP = new System.Windows.Forms.FlowLayoutPanel();
            this.FlwNormal = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.entregarVIPbtn = new System.Windows.Forms.Button();
            this.changeToMenu = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.entregarNRMbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeToMenu)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNormales
            // 
            this.lblNormales.AutoSize = true;
            this.lblNormales.BackColor = System.Drawing.Color.Transparent;
            this.lblNormales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormales.Location = new System.Drawing.Point(549, 9);
            this.lblNormales.Name = "lblNormales";
            this.lblNormales.Size = new System.Drawing.Size(138, 31);
            this.lblNormales.TabIndex = 0;
            this.lblNormales.Text = "Normales";
            // 
            // lblVIP
            // 
            this.lblVIP.AutoSize = true;
            this.lblVIP.BackColor = System.Drawing.Color.Transparent;
            this.lblVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(200)))), ((int)(((byte)(34)))));
            this.lblVIP.Location = new System.Drawing.Point(175, 6);
            this.lblVIP.Name = "lblVIP";
            this.lblVIP.Size = new System.Drawing.Size(61, 31);
            this.lblVIP.TabIndex = 1;
            this.lblVIP.Text = "VIP";
            // 
            // FlwVIP
            // 
            this.FlwVIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlwVIP.AutoScroll = true;
            this.FlwVIP.BackColor = System.Drawing.Color.Transparent;
            this.FlwVIP.Location = new System.Drawing.Point(12, 40);
            this.FlwVIP.Name = "FlwVIP";
            this.FlwVIP.Size = new System.Drawing.Size(369, 398);
            this.FlwVIP.TabIndex = 2;
            // 
            // FlwNormal
            // 
            this.FlwNormal.AutoScroll = true;
            this.FlwNormal.BackColor = System.Drawing.Color.Transparent;
            this.FlwNormal.Location = new System.Drawing.Point(419, 40);
            this.FlwNormal.Name = "FlwNormal";
            this.FlwNormal.Size = new System.Drawing.Size(369, 398);
            this.FlwNormal.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Controls.Add(this.entregarVIPbtn);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(401, 450);
            this.panel9.TabIndex = 4;
            // 
            // entregarVIPbtn
            // 
            this.entregarVIPbtn.Location = new System.Drawing.Point(12, 11);
            this.entregarVIPbtn.Name = "entregarVIPbtn";
            this.entregarVIPbtn.Size = new System.Drawing.Size(113, 23);
            this.entregarVIPbtn.TabIndex = 0;
            this.entregarVIPbtn.Text = "Entregar Orden";
            this.entregarVIPbtn.UseVisualStyleBackColor = true;
            this.entregarVIPbtn.Click += new System.EventHandler(this.entregarVIPbtn_Click);
            // 
            // changeToMenu
            // 
            this.changeToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeToMenu.Image = global::Proyecto.Properties.Resources.change;
            this.changeToMenu.Location = new System.Drawing.Point(757, 0);
            this.changeToMenu.Name = "changeToMenu";
            this.changeToMenu.Size = new System.Drawing.Size(43, 40);
            this.changeToMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changeToMenu.TabIndex = 0;
            this.changeToMenu.TabStop = false;
            this.changeToMenu.Click += new System.EventHandler(this.changeToMenu_Click);
            this.changeToMenu.MouseLeave += new System.EventHandler(this.changeToMenu_MouseLeave);
            this.changeToMenu.MouseHover += new System.EventHandler(this.changeToMenu_MouseHover);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.entregarNRMbtn);
            this.panel10.Controls.Add(this.changeToMenu);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(800, 450);
            this.panel10.TabIndex = 5;
            // 
            // entregarNRMbtn
            // 
            this.entregarNRMbtn.Location = new System.Drawing.Point(419, 13);
            this.entregarNRMbtn.Name = "entregarNRMbtn";
            this.entregarNRMbtn.Size = new System.Drawing.Size(99, 23);
            this.entregarNRMbtn.TabIndex = 1;
            this.entregarNRMbtn.Text = "Entregar Orden";
            this.entregarNRMbtn.UseVisualStyleBackColor = true;
            this.entregarNRMbtn.Click += new System.EventHandler(this.entregarNRMbtn_Click);
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlwVIP);
            this.Controls.Add(this.FlwNormal);
            this.Controls.Add(this.lblVIP);
            this.Controls.Add(this.lblNormales);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Ordenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes";
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeToMenu)).EndInit();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNormales;
        private System.Windows.Forms.Label lblVIP;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox changeToMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.FlowLayoutPanel FlwVIP;
        public System.Windows.Forms.FlowLayoutPanel FlwNormal;
        private System.Windows.Forms.Button entregarVIPbtn;
        private System.Windows.Forms.Button entregarNRMbtn;
    }
}