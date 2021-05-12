using Proyecto.DataModel;
using Proyecto.DataStatic;
using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CantidadProducto : Form
    {
        public ProductMenu Principal;
        public Product product;
        private int maxProduct;
        public CantidadProducto(Product product)
        {
            InitializeComponent();
            Consults consults = new Consults();
            maxProduct = consults.ObtenerStock(product.Cod_producto);
            if (maxProduct == 0)
            {
                MessageBox.Show("Disculpe, no hay stock de este producto.");
                this.Close();
            }
            this.product = product;
            lblTitulo.Text = product.Nombre;
            txtDetalleProd.Text = product.Descripcion;
            lblPrecio.Text = "$" + ((int)numericUpDown1.Value * product.Precio).ToString("0.00");
            image.Image = product.Imagen;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > maxProduct)
                numericUpDown1.Value--;
            else
                lblPrecio.Text = "$" + ((int)numericUpDown1.Value * product.Precio).ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(numericUpDown1.Value.ToString());
            Consults consults = new Consults();
            Orden orden = new Orden();
            orden.Id_orden = "O" + (consults.GetLastOrderID() + 1).ToString("D9");
            orden.Cod_producto = product.Cod_producto;
            orden.Cantidad = qty;
            orden.Panel = Methods.CrearPanel(Collections.pedidoActual.Count,
                product.Nombre, qty, product.Precio, product.Imagen);
            Collections.pedidoActual.Insertar(orden);
            Components.Producto += qty;
            Components.orderTotal += product.Precio * qty;
            Principal.Actualizar(orden.Panel);
            this.Close();
        }
        public void ModoVIP()
        {
            panel1.BackColor = Color.FromName("black");
            lblTitulo.ForeColor = Color.FromName("white");
            label2.ForeColor = Color.FromName("white");
            total.ForeColor = Color.FromName("white");
            numericUpDown1.BackColor = Color.FromName("black");
            numericUpDown1.ForeColor = Color.FromName("white");
            button2.BackColor = Color.FromArgb(184, 148, 25);
        }
        public void ModoNormal()
        {
            panel1.BackColor = Color.FromArgb(228, 211, 211);
            lblTitulo.ForeColor = Color.FromName("black");
            label2.ForeColor = Color.FromName("black");
            total.ForeColor = Color.FromName("black");
            numericUpDown1.BackColor = Color.FromName("white");
            numericUpDown1.ForeColor = Color.FromName("black");
            button2.BackColor = Color.FromArgb(10, 132, 255);
        }

        private void CantidadProducto_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.ControlForm(this);
        }
    }
}
