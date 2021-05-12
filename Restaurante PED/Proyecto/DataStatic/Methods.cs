using Proyecto.DataModel;
using Proyecto.DataStructures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.DataStatic
{
    public static class Methods
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public static void ControlForm(Form form)
        {
            ReleaseCapture();
            SendMessage(form.Handle, 0x112, 0xf012, 0);
        }
        private static void DeleteOrder_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("¿Está seguro de eliminar esta orden de tu carrito de compras?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Panel SCart = (Panel)Components.SCPanel.Controls.Find("SCart", true).FirstOrDefault();
                Label orderTotalLbl = (Label)SCart.Controls.Find("orderTotalLbl", true).FirstOrDefault();
                Control c = ((Control)sender).Parent;
                int index = SCart.Controls.IndexOf(c);
                double price = 0;
                Orden o = (Orden)Collections.pedidoActual.BuscarNodo(index).Dato;
                NodoLista nodo = Collections.productos.inicio;
                while (nodo != null)
                {
                    Product prd = (Product)nodo.Dato;
                    if (prd.Cod_producto == o.Cod_producto)
                    {
                        price = prd.Precio * o.Cantidad;
                        break;
                    }
                    nodo = nodo.Siguiente;
                }
                Components.Producto -= o.Cantidad;
                Components.orderTotal -= price;
                orderTotalLbl.Text = "$" + Components.orderTotal.ToString("0.00");
                Collections.pedidoActual.EliminarNodo(index);
                Components.principal.lblCantidad.Text = 
                Components.secundario.lblCantidad.Text = Components.Producto.ToString();
                c.Dispose();
            }
        }
        public static FlowLayoutPanel CrearPedidoPanel(string pedID, string ETA, bool VIP)
        {
            FlowLayoutPanel FLProducts = new FlowLayoutPanel();
            Panel panelItem = new Panel();
            Label generic1 = new Label();
            Label generic2 = new Label();
            Label generic3 = new Label();
            Label pedidoID = new Label();
            Label eta = new Label();
            generic1.AutoSize = generic2.AutoSize = 
                generic3.AutoSize = pedidoID.AutoSize = eta.AutoSize = true;
            panelItem.Size = new Size(375, 338);
            panelItem.BackColor = VIP ? Color.FromArgb(48, 45, 45) : Color.White;
            FLProducts.Size = new Size(370, 283);
            FLProducts.BackColor = Color.Transparent;
            FLProducts.AutoScroll = true;
            generic1.Text = "Pedido #";
            generic2.Text = "ETA:";
            generic3.Text = "----------------------------------------------------------------------";
            pedidoID.Text = pedID;
            if (VIP)
                generic1.ForeColor = generic2.ForeColor =
                    generic3.ForeColor = eta.ForeColor = pedidoID.ForeColor = Color.FromArgb(248, 200, 34);
            else
                generic1.ForeColor = generic2.ForeColor =
                    generic3.ForeColor = eta.ForeColor = pedidoID.ForeColor = Color.Black;
            generic1.Font = generic2.Font = generic3.Font = new Font("Microsoft Sans Serif", (float)12.00);
            pedidoID.Font = eta.Font = new Font("Microsoft Sans Serif", (float)12.00, FontStyle.Bold);
            eta.Text = ETA;

            panelItem.Controls.Add(FLProducts);
            panelItem.Controls.Add(generic1);
            panelItem.Controls.Add(generic2);
            panelItem.Controls.Add(generic3);
            panelItem.Controls.Add(pedidoID);
            panelItem.Controls.Add(eta);

            FLProducts.Location = new Point(16, 45);
            generic1.Location = new Point(12, 11);
            generic2.Location = new Point(227, 11);
            generic3.Location = new Point(-3, 31);
            pedidoID.Location = new Point(86, 11);
            eta.Location = new Point(270, 11);
            return FLProducts;
        }
        public static Panel CrearPanel(int itemNum, string prodName, int prodQty, 
            double prodPrice, Image image)
        {
            Panel panelItem = new Panel();
            TextBox Productlbl = new TextBox();
            Label QtyLbl = new Label();
            Label QtyLbl2 = new Label();
            Label PriceLbl = new Label();
            PictureBox ProductImage = new PictureBox();
            Button deleteBtn = new Button();

            panelItem.Name = "itemPnl" + itemNum;
            panelItem.BackColor = Color.White;
            panelItem.Size = new Size(311, 114);

            Productlbl.Name = "itemName" + itemNum;
            Productlbl.Text = prodName;
            Productlbl.ReadOnly = true;
            Productlbl.Size = new Size(160, 10);
            Productlbl.Font = new Font("Microsoft Sans Serif", (float)12.00);

            QtyLbl.Name = "itemQtyLbl" + itemNum;
            QtyLbl.Text = "Cantidad:"; ;
            QtyLbl.Font = new Font("Microsoft Sans Serif", (float)9.75);

            QtyLbl2.Name = "itemQtyS" + itemNum;
            QtyLbl2.Text = prodQty.ToString();
            QtyLbl2.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Bold);

            PriceLbl.Name = "itemPrice" + itemNum;
            PriceLbl.Text = "$" + (prodQty * prodPrice).ToString("0.00");
            PriceLbl.ForeColor = Color.Green;
            PriceLbl.Font = new Font("Microsoft Sans Serif", (float)12.00, FontStyle.Bold);

            ProductImage.Name = "itemImage" + itemNum;
            ProductImage.Image = image;
            ProductImage.Size = new Size(127, 108);
            ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;

            deleteBtn.Name = "itemDel" + itemNum;
            deleteBtn.BackgroundImage = Properties.Resources.close;
            deleteBtn.BackColor = Color.Transparent;
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            deleteBtn.Size = new Size(29, 26);
            deleteBtn.Click += DeleteOrder_Click;

            panelItem.Controls.Add(Productlbl);
            panelItem.Controls.Add(QtyLbl);
            panelItem.Controls.Add(QtyLbl2);
            panelItem.Controls.Add(PriceLbl);
            panelItem.Controls.Add(ProductImage);
            panelItem.Controls.Add(deleteBtn);

            ProductImage.Location = new Point(3, 3);
            Productlbl.Location = new Point(136, 38);
            Productlbl.BringToFront();
            QtyLbl.Location = new Point(134, 67);
            QtyLbl2.Location = new Point(196, 67);
            QtyLbl2.BringToFront();
            PriceLbl.Location = new Point(247, 91);
            deleteBtn.Location = new Point(276, 3);

            return panelItem;
        }
    }
}
