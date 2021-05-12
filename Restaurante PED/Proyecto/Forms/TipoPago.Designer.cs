namespace Proyecto.Forms
{
    partial class TipoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoPago));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Efectivo = new System.Windows.Forms.PictureBox();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.Tarjeta = new System.Windows.Forms.PictureBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.PictureBox();
            this.Factura = new System.Windows.Forms.Panel();
            this.ordTotLbl = new System.Windows.Forms.Label();
            this.mensajeLblTicket = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FlowPanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FlowPanelPrecio = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FacturaTarjeta = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.orderNumLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Efectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).BeginInit();
            this.Factura.SuspendLayout();
            this.FlowPanelProductos.SuspendLayout();
            this.FlowPanelPrecio.SuspendLayout();
            this.FacturaTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(167, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formas de Pago";
            // 
            // Efectivo
            // 
            this.Efectivo.BackColor = System.Drawing.Color.Transparent;
            this.Efectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Efectivo.Image = ((System.Drawing.Image)(resources.GetObject("Efectivo.Image")));
            this.Efectivo.Location = new System.Drawing.Point(74, 114);
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.Size = new System.Drawing.Size(125, 125);
            this.Efectivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Efectivo.TabIndex = 1;
            this.Efectivo.TabStop = false;
            this.Efectivo.Click += new System.EventHandler(this.Efectivo_Click);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(100, 254);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(76, 24);
            this.lblEfectivo.TabIndex = 2;
            this.lblEfectivo.Text = "Efectivo";
            // 
            // Tarjeta
            // 
            this.Tarjeta.BackColor = System.Drawing.Color.Transparent;
            this.Tarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tarjeta.Image = ((System.Drawing.Image)(resources.GetObject("Tarjeta.Image")));
            this.Tarjeta.Location = new System.Drawing.Point(411, 114);
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.Size = new System.Drawing.Size(125, 125);
            this.Tarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tarjeta.TabIndex = 3;
            this.Tarjeta.TabStop = false;
            this.Tarjeta.Click += new System.EventHandler(this.Tarjeta_Click);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(438, 254);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(67, 24);
            this.lblTarjeta.TabIndex = 4;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return.Image = global::Proyecto.Properties.Resources.flecha;
            this.Return.Location = new System.Drawing.Point(12, 9);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(53, 38);
            this.Return.TabIndex = 5;
            this.Return.TabStop = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Factura
            // 
            this.Factura.BackColor = System.Drawing.Color.White;
            this.Factura.Controls.Add(this.label5);
            this.Factura.Controls.Add(this.orderNumLbl);
            this.Factura.Controls.Add(this.ordTotLbl);
            this.Factura.Controls.Add(this.mensajeLblTicket);
            this.Factura.Controls.Add(this.label12);
            this.Factura.Controls.Add(this.label11);
            this.Factura.Controls.Add(this.label10);
            this.Factura.Controls.Add(this.FlowPanelProductos);
            this.Factura.Controls.Add(this.lblFecha);
            this.Factura.Controls.Add(this.label3);
            this.Factura.Controls.Add(this.label2);
            this.Factura.Controls.Add(this.FlowPanelPrecio);
            this.Factura.Controls.Add(this.label1);
            this.Factura.Location = new System.Drawing.Point(205, 12);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(200, 404);
            this.Factura.TabIndex = 6;
            this.Factura.Visible = false;
            this.Factura.VisibleChanged += new System.EventHandler(this.Factura_VisibleChanged);
            // 
            // ordTotLbl
            // 
            this.ordTotLbl.AutoSize = true;
            this.ordTotLbl.Location = new System.Drawing.Point(147, 182);
            this.ordTotLbl.Name = "ordTotLbl";
            this.ordTotLbl.Size = new System.Drawing.Size(34, 13);
            this.ordTotLbl.TabIndex = 10;
            this.ordTotLbl.Text = "$0.00";
            // 
            // mensajeLblTicket
            // 
            this.mensajeLblTicket.AutoSize = true;
            this.mensajeLblTicket.Location = new System.Drawing.Point(9, 220);
            this.mensajeLblTicket.Name = "mensajeLblTicket";
            this.mensajeLblTicket.Size = new System.Drawing.Size(179, 13);
            this.mensajeLblTicket.TabIndex = 9;
            this.mensajeLblTicket.Text = "MUESTRE ESTE TICKET EN CAJA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-3, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "*********************************";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "*********************************";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Total: ";
            // 
            // FlowPanelProductos
            // 
            this.FlowPanelProductos.AutoSize = true;
            this.FlowPanelProductos.Controls.Add(this.label4);
            this.FlowPanelProductos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPanelProductos.Location = new System.Drawing.Point(6, 64);
            this.FlowPanelProductos.Name = "FlowPanelProductos";
            this.FlowPanelProductos.Size = new System.Drawing.Size(126, 104);
            this.FlowPanelProductos.TabIndex = 4;
            this.FlowPanelProductos.WrapContents = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Productos";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(3, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*********************************";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FastCarlos ®";
            // 
            // FlowPanelPrecio
            // 
            this.FlowPanelPrecio.Controls.Add(this.label8);
            this.FlowPanelPrecio.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPanelPrecio.Location = new System.Drawing.Point(138, 64);
            this.FlowPanelPrecio.Name = "FlowPanelPrecio";
            this.FlowPanelPrecio.Size = new System.Drawing.Size(59, 104);
            this.FlowPanelPrecio.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*********************************";
            // 
            // FacturaTarjeta
            // 
            this.FacturaTarjeta.BackColor = System.Drawing.Color.White;
            this.FacturaTarjeta.Controls.Add(this.button1);
            this.FacturaTarjeta.Controls.Add(this.label17);
            this.FacturaTarjeta.Controls.Add(this.label16);
            this.FacturaTarjeta.Controls.Add(this.label15);
            this.FacturaTarjeta.Controls.Add(this.label14);
            this.FacturaTarjeta.Location = new System.Drawing.Point(149, 59);
            this.FacturaTarjeta.Name = "FacturaTarjeta";
            this.FacturaTarjeta.Size = new System.Drawing.Size(319, 240);
            this.FacturaTarjeta.TabIndex = 7;
            this.FacturaTarjeta.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Tarjeta: xxx-xxx-xxx-1234";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Emisión: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Banco X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Transacción Exitosa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar Ticket";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderNumLbl
            // 
            this.orderNumLbl.AutoSize = true;
            this.orderNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumLbl.Location = new System.Drawing.Point(3, 274);
            this.orderNumLbl.Name = "orderNumLbl";
            this.orderNumLbl.Size = new System.Drawing.Size(130, 16);
            this.orderNumLbl.TabIndex = 11;
            this.orderNumLbl.Text = "Numero de Orden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo de Orden";
            // 
            // TipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(170)))), ((int)(((byte)(216)))));
            this.BackgroundImage = global::Proyecto.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 361);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.FacturaTarjeta);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.Tarjeta);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.Efectivo);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoPago";
            ((System.ComponentModel.ISupportInitialize)(this.Efectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Return)).EndInit();
            this.Factura.ResumeLayout(false);
            this.Factura.PerformLayout();
            this.FlowPanelProductos.ResumeLayout(false);
            this.FlowPanelProductos.PerformLayout();
            this.FlowPanelPrecio.ResumeLayout(false);
            this.FlowPanelPrecio.PerformLayout();
            this.FacturaTarjeta.ResumeLayout(false);
            this.FacturaTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox Efectivo;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.PictureBox Tarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.PictureBox Return;
        private System.Windows.Forms.Panel Factura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label mensajeLblTicket;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel FacturaTarjeta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label ordTotLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label orderNumLbl;
    }
}