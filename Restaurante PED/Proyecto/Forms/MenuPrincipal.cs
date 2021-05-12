using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Proyecto.DataStatic;
using Proyecto.DataModel;
using Proyecto.Datos;
using Proyecto.Forms;
using Proyecto.DataStructures;

namespace Proyecto
{
    public partial class MenuPrincipal : Form
    {
        public bool payed = false;
        public MenuPrincipal()
        {
            InitializeComponent();
            Components.ordenes = new Ordenes();
            Components.principal = this;
            Components.SCPanel = shoppingCarPanel;
            Pizza.Image = ((Categoria)Collections.categorias.BuscarNodo(0).Dato).Imagen;
            Hamburguesa.Image = ((Categoria)Collections.categorias.BuscarNodo(1).Dato).Imagen;
            Pasta.Image = ((Categoria)Collections.categorias.BuscarNodo(2).Dato).Imagen;
            Bebida.Image = ((Categoria)Collections.categorias.BuscarNodo(3).Dato).Imagen;
            Postre.Image = ((Categoria)Collections.categorias.BuscarNodo(4).Dato).Imagen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void slideButton1_Click(object sender, EventArgs e)
        {
            shoppingCarPanel.Hide();
            if (vipButton.IsOn)
            {
                carrito.Hide();
                lblCantidad.Hide();
                vipButton.BackColor = Color.FromArgb(137, 113, 30);
                BackgroundImage = Properties.Resources.FondoVIP;
                BackColor = Color.FromArgb(3, 3, 3);
                panelMenu.Hide();
                panelLogin.Show();
                shoppingCarPanel.BackColor = Color.FromArgb(3, 3, 3);
                label8.ForeColor = Color.FromArgb(248, 200, 34);
                label9.ForeColor = Color.FromArgb(248, 200, 34);

            }
            else
            {
                carrito.Show();
                lblCantidad.Show();
                panelLogin.Hide();
                panelMenu.Location = new Point(12, 50);
                ModoNormal();
                panelMenu.Show();
                BackgroundImage = Properties.Resources.Fondo;
                BackColor = Color.FromArgb(31, 170, 216);
                vipButton.BackColor = Color.FromArgb(31, 170, 216);
                shoppingCarPanel.BackColor = Color.FromName("gainsboro");
                label8.ForeColor = Color.FromArgb(0, 0, 0);
                label9.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            ;
            panelLogin.Hide();
            panelMenu.Location = new Point(12, 50);
            panelMenu.Show();
            BackgroundImage = Properties.Resources.Fondo;
            BackColor = Color.FromArgb(31, 170, 216);
            vipButton.BackColor = Color.FromArgb(31, 170, 216);
        }

        private void Pizza_Click_1(object sender, EventArgs e)
        {
            ProductMenu pizza = new ProductMenu("Pizza");
            if (vipButton.IsOn)
            {
                pizza.ModoVIP();
                pizza.BackgroundImage = Properties.Resources.fondo_pizza_VIP;

            }
            else
            {
                pizza.ModoNormal();
                pizza.BackgroundImage = Properties.Resources.fondo_pizza;

            }
            pizza.Show();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Datos.Consults cons = new Datos.Consults();
            if (cons.ExistVIP(txtDUI.Text))
            {
                panelLogin.Hide();
                ModoVIP();
                panelMenu.Show();
                lblCantidad.Show();
            }
            else
                MessageBox.Show("Cliente no encontrado en la base de datos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            carrito.Show();
        }
        private void ModoVIP()
        {
            //cambiando color a los labels
            pictureBox2.Image = Properties.Resources.flechaVIP;
            lblPizzas.ForeColor = Color.FromArgb(133, 54, 0);
            lblHamburguesa.ForeColor = Color.FromArgb(133, 54, 0);
            lblPastas.ForeColor = Color.FromArgb(133, 54, 0);
            lblBebidas.ForeColor = Color.FromArgb(133, 54, 0);
            lblPostres.ForeColor = Color.FromArgb(133, 54, 0);
            lblMenu.ForeColor = Color.FromArgb(248, 200, 34);
            //cambiando color a los borde de las imagenes
            BordePizza.BackColor = Color.FromArgb(248, 200, 34);
            BordeHamburguesa.BackColor = Color.FromArgb(248, 200, 34);
            BordePasta.BackColor = Color.FromArgb(248, 200, 34);
            BordeBebida.BackColor = Color.FromArgb(248, 200, 34);
            BordePastel.BackColor = Color.FromArgb(248, 200, 34);
            //cambiando el fondo
            BackgroundImage = Properties.Resources.FondoVIPMenu;
            BackColor = Color.FromName("black");
            //cambiando el carrito
            carrito.Image = Properties.Resources.carroVIP;
        }
        private void ModoNormal()
        {
            //cambiando color a los labels
            pictureBox2.Image = Properties.Resources.flecha;
            lblPizzas.ForeColor = Color.FromName("black");
            lblHamburguesa.ForeColor = Color.FromName("black");
            lblPastas.ForeColor = Color.FromName("black");
            lblBebidas.ForeColor = Color.FromName("black");
            lblPostres.ForeColor = Color.FromName("black");
            lblMenu.ForeColor = Color.FromName("black");
            //cambiando color a los borde de las imagenes
            BordePizza.BackColor = Color.FromName("black");
            BordeHamburguesa.BackColor = Color.FromName("black");
            BordePasta.BackColor = Color.FromName("black");
            BordeBebida.BackColor = Color.FromName("black");
            BordePastel.BackColor = Color.FromName("black");
            //cambiando el carrito
            carrito.Image = Properties.Resources.carro;

        }
        private void Hamburguesa_Click_1(object sender, EventArgs e)
        {
            ProductMenu hambur = new ProductMenu("Hamburguesa");
            if (vipButton.IsOn)
            {
                hambur.ModoVIP();
                hambur.BackgroundImage = Properties.Resources.fondo_hamburguesa_vip;
            }
            else
            {
                hambur.ModoNormal();
                hambur.BackgroundImage = Properties.Resources.fondo_hamburguesa;
            }
            hambur.Show();
        }

        private void Pasta_Click(object sender, EventArgs e)
        {
            ProductMenu pasta = new ProductMenu("Pasta");
            if (vipButton.IsOn)
            {
                pasta.ModoVIP();
                pasta.BackgroundImage = Properties.Resources.fondo_pasta_VIP;
            }
            else
            {
                pasta.ModoNormal();
                pasta.BackgroundImage = Properties.Resources.fondo_pasta;
            }
            pasta.Show();
        }

        private void Bebida_Click(object sender, EventArgs e)
        {
            ProductMenu bebida = new ProductMenu("Bebida");
            if (vipButton.IsOn)
            {
                bebida.ModoVIP();
                bebida.BackgroundImage = Properties.Resources.fondo_bebida_VIP;
            }
            else
            {
                bebida.ModoNormal();
                bebida.BackgroundImage = Properties.Resources.fondo_bebida;
            }
            bebida.Show();
        }

        private void Postre_Click(object sender, EventArgs e)
        {
            ProductMenu postres = new ProductMenu("Postre");
            if (vipButton.IsOn)
            {
                postres.ModoVIP();
                postres.BackgroundImage = Properties.Resources.fondo_postres_VIP;
            }
            else
            {
                postres.ModoNormal();
                postres.BackgroundImage = Properties.Resources.fondo_postres;
            }
            postres.Show();
        }

        private void carrito_Click(object sender, EventArgs e)
        {
            shoppingCarPanel.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            shoppingCarPanel.Visible = false;
        }

        private void buyOrderBtn_Click(object sender, EventArgs e)
        {
            if (Collections.pedidoActual.inicio != null)
            {
                TipoPago VentanaTipoPago = new TipoPago(vipButton.IsOn);
                VentanaTipoPago.ShowDialog();
                if(payed)
                {
                    Consults consults = new Consults();
                    Components.Producto = 0;
                    Components.orderTotal = 0;
                    Pedido pedido = new Pedido();
                    pedido.Productos = Collections.pedidoActual;
                    Orden orden = (Orden)Collections.pedidoActual.inicio.Dato;
                    consults.InsertarPedido();
                    pedido.Orden = Methods.CrearPedidoPanel(orden.Id_orden,
                        consults.ObtenerETA(orden.Id_orden),
                        Components.principal.vipButton.IsOn);
                    if (vipButton.IsOn)
                        Collections.pedidosVIP.Enqueue(pedido);
                    else
                    {
                        if (Collections.pedidosVIP.Count == 0 && Collections.pedidosNormal.Count == 5)
                            Collections.pedidosVIP.Enqueue(pedido);
                        else
                            Collections.pedidosNormal.Enqueue(pedido);
                    }
                    Actualizar(pedido.Orden);
                    shoppingCarPanel.Visible = false;
                    if (vipButton.IsOn)
                        Components.ordenes.FlwVIP.Controls.Add(pedido.Orden.Parent);
                    else
                        Components.ordenes.FlwNormal.Controls.Add(pedido.Orden.Parent);
                    payed = false;
                }
            }
        }
        private void Actualizar(FlowLayoutPanel panel)
        {
            int length = SCart.Controls.Count;
            for (int i = 0; i < length - 1; i++)
            {
                foreach (Control control in SCart.Controls[0].Controls)
                {
                    if (control.Name.Contains("itemDel") ||
                        control.Name.Contains("itemPrice"))
                        control.Hide();
                    if (vipButton.IsOn)
                        if (control.Name.Contains("itemName") ||
                            control.Name.Contains("itemQtyLbl") ||
                            control.Name.Contains("itemQtyS"))
                            control.ForeColor = Color.FromArgb(248, 200, 34);
                }
                if (SCart.Controls[0] != SCart)
                {
                    Panel p = (Panel)SCart.Controls[0];
                    p.BorderStyle = BorderStyle.FixedSingle;
                    p.BackColor = vipButton.IsOn ? Color.FromArgb(34, 42, 42) : Color.FromArgb(149, 152, 152);
                    panel.Controls.Add(SCart.Controls[0]);
                }
            }
            orderTotalLbl.Text = "$0.00";
            lblCantidad.Text = "0";
            Components.secundario.lblCantidad.Text = "0";
        }

        private void MenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.ControlForm(this);
        }

        private void changeToOrder_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cambiar a modo ordenes", this, MousePosition.X - 275, MousePosition.Y - 160);
        }

        private void changeToOrder_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(this);
        }

        private void changeToOrder_Click(object sender, EventArgs e)
        {
            Components.ordenes.Show();
            this.Hide();
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
                btnVerificar_Click(null, null);
        }
    }
}
