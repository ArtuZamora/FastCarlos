using Proyecto.DataModel;
using Proyecto.DataStatic;
using Proyecto.DataStructures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Forms
{
    public partial class TipoPago : Form
    {
        public TipoPago(bool VIP)
        {
            InitializeComponent();
            if (VIP == true)
            {
                BackgroundImage = Properties.Resources.FondoVIP;
                this.BackColor = Color.FromArgb(3, 3, 3);
                lblTitulo.ForeColor = Color.FromArgb(248, 200, 34);
                lblEfectivo.ForeColor = Color.FromArgb(133, 54, 0);
                lblTarjeta.ForeColor = Color.FromArgb(133, 54, 0);
                Return.Image = Properties.Resources.flechaVIP;
            }
            else
            {
                BackgroundImage = Properties.Resources.Fondo;
                this.BackColor = Color.FromArgb(31, 170, 216);
                lblTitulo.ForeColor = Color.FromName("Black");
                lblEfectivo.ForeColor = Color.FromName("Black");
                lblTarjeta.ForeColor = Color.FromName("Black");
                Return.Image = Properties.Resources.flecha;
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Efectivo_Click(object sender, EventArgs e)
        {
            if (!(Factura.Visible || FacturaTarjeta.Visible))
            {
                Components.principal.payed = true;
                Factura.Visible = true;
                lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            }
        }

        private void Tarjeta_Click(object sender, EventArgs e)
        {
            if (!(Factura.Visible || FacturaTarjeta.Visible))
            {
                Components.principal.payed = true;
                FacturaTarjeta.Visible = true;
                label16.Text = "Emisión: " + DateTime.Now;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacturaTarjeta.Hide();
            mensajeLblTicket.Hide();
            Factura.Show();
        }

        private void Factura_VisibleChanged(object sender, EventArgs e)
        {
            if (Factura.Visible == true)
            {
                orderNumLbl.Text = ((Orden)Collections.pedidoActual.inicio.Dato).Id_orden;
                ordTotLbl.Text = "$" + Components.orderTotal.ToString("0.00");
                NodoLista nodoPedido = Collections.pedidoActual.inicio;
                while (nodoPedido != null)
                {
                    Orden orden = (Orden)nodoPedido.Dato;
                    NodoLista nodoProducto = Collections.productos.inicio;
                    while (((Product)nodoProducto.Dato).Cod_producto != orden.Cod_producto)
                        nodoProducto = nodoProducto.Siguiente;
                    Product product = (Product)nodoProducto.Dato;
                    Label lblProducto = new Label();
                    lblProducto.AutoSize = true;
                    lblProducto.Text = product.Nombre;
                    Label lblPrecio = new Label();
                    lblPrecio.AutoSize = true;
                    lblPrecio.Text = "$" + (product.Precio * orden.Cantidad).ToString("0.00");
                    FlowPanelProductos.Controls.Add(lblProducto);
                    FlowPanelPrecio.Controls.Add(lblPrecio);
                    nodoPedido = nodoPedido.Siguiente;
                }
            }
        }
    }
}
