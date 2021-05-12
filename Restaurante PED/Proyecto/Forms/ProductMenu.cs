using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.DataModel;
using Proyecto.DataStatic;
using Proyecto.DataStructures;
using Proyecto.Datos;

namespace Proyecto
{
    public partial class ProductMenu : Form
    {
        private int categoryID;
        private ListaDoble prodTypeList;
        private NodoLista product1, product2, product3;
        public ProductMenu(string category)
        {
            InitializeComponent();
            Components.secundario = this;
            Components.SCPanel.Visible = false;
            this.Controls.Add(Components.SCPanel);
            Components.SCPanel.BringToFront();
            lblCategory.Text = category;
            categoryID = Collections.SearchCategoryID(category);
            lblCantidad.Text = Components.Producto.ToString();
            prodTypeList = Collections.FilterProdByCat(categoryID);
            product1 = prodTypeList.BuscarNodo(0);
            product2 = prodTypeList.BuscarNodo(1);
            product3 = prodTypeList.BuscarNodo(2);
            LlenadoProducto(product1, lblNameProd1, lblPriceProd1, pictProd1);
            LlenadoProducto(product2, lblNameProd2, lblPriceProd2, pictProd2);
            LlenadoProducto(product3, lblNameProd3, lblPriceProd3, pictProd3);
        }
        private void LlenadoProducto(NodoLista prod, Label prodLbl, Label proceLbl, PictureBox image)
        {
            if (prod != null)
            {
                Product prodObj = (Product)prod.Dato;
                prodLbl.Text = prodObj.Nombre;
                proceLbl.Text = "$" + prodObj.Precio.ToString("F2");
                image.Image = prodObj.Imagen;
            }
            else
            {
                prodLbl.Text = "Proximamente";
                proceLbl.Text = "$0.00";
                image.Image = Properties.Resources.notimage;
            }
        }
        public void Actualizar(Panel panel)
        {
            Panel SCart = (Panel)Components.SCPanel.Controls.Find("SCart", true).FirstOrDefault();
            Panel BuyPanel = (Panel)Components.SCPanel.Controls.Find("BuyPanel", true).FirstOrDefault();
            Label orderTotalLbl = (Label)SCart.Controls.Find("orderTotalLbl", true).FirstOrDefault();
            orderTotalLbl.Text = "$" + Components.orderTotal.ToString("0.00");
            SCart.Controls.Add(panel);
            SCart.Controls.Add(BuyPanel);
            Components.principal.lblCantidad.Text =
            lblCantidad.Text = Components.Producto.ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictProd1_Click(object sender, EventArgs e)
        {
            if (product1 != null)
            {
                CantidadProducto cantProdForm = new CantidadProducto((Product)product1.Dato);
                cantProdForm.Principal = this;
                if (BackColor == Color.FromName("black")) cantProdForm.ModoVIP();
                else cantProdForm.ModoNormal();
                cantProdForm.ShowDialog();
            }
        }

        private void pictProd2_Click(object sender, EventArgs e)
        {
            if (product2 != null)
            {
                CantidadProducto cantProdForm = new CantidadProducto((Product)product2.Dato);
                cantProdForm.Principal = this;
                if (BackColor == Color.FromName("black")) cantProdForm.ModoVIP();
                else cantProdForm.ModoNormal();
                cantProdForm.ShowDialog();
            }
        }

        private void pictProd3_Click(object sender, EventArgs e)
        {
            if (product3 != null)
            {
                CantidadProducto cantProdForm = new CantidadProducto((Product)product3.Dato);
                cantProdForm.Principal = this;
                if (BackColor == Color.FromName("black")) cantProdForm.ModoVIP();
                else cantProdForm.ModoNormal();
                cantProdForm.ShowDialog();
            }
        }
        private void nextSet_Click(object sender, EventArgs e)
        {
            if (product3 != null)
            {
                if (product3.Siguiente != null)
                {
                    product1 = product3.Siguiente;
                    product2 = null;
                    product3 = null;
                    if (product1.Siguiente != null)
                    {
                        product2 = product1.Siguiente;
                        product3 = null;
                        if (product2.Siguiente != null) product3 = product2.Siguiente;
                    }
                }
                LlenadoProducto(product1, lblNameProd1, lblPriceProd1, pictProd1);
                LlenadoProducto(product2, lblNameProd2, lblPriceProd2, pictProd2);
                LlenadoProducto(product3, lblNameProd3, lblPriceProd3, pictProd3);
            }
        }
        private void lastSet_Click(object sender, EventArgs e)
        {
            if (product1 != null)
            {
                if (product1.Anterior != null)
                {
                    product1 = product1.Anterior.Anterior.Anterior;
                    product2 = product1.Siguiente;
                    product3 = product2.Siguiente;
                }
                LlenadoProducto(product1, lblNameProd1, lblPriceProd1, pictProd1);
                LlenadoProducto(product2, lblNameProd2, lblPriceProd2, pictProd2);
                LlenadoProducto(product3, lblNameProd3, lblPriceProd3, pictProd3);
            }
        }

        private void shoppingCartBtn_Click(object sender, EventArgs e)
        {
            Components.SCPanel.Visible = true;
        }

        private void ProductMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Components.SCPanel.Visible = false;
            Components.principal.Controls.Add(Components.SCPanel);
            Components.SCPanel.BringToFront();
        }

        private void ProductMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.ControlForm(this);
        }

        public void ModoVIP()//cambia la apariencia del form a modo vip
        {
            pictureBox1.Image = Properties.Resources.flechaVIP;
            shoppingCartBtn.Image = Properties.Resources.carroVIP;
            lblCategory.ForeColor = Color.FromArgb(248, 200, 34);
            panel1.BackColor = Color.FromArgb(99, 99, 99);
            panel2.BackColor = Color.FromArgb(99, 99, 99);
            panel3.BackColor = Color.FromArgb(99, 99, 99);
            lblPriceProd1.BackColor = Color.FromArgb(184, 148, 25);
            lblPriceProd2.BackColor = Color.FromArgb(184, 148, 25);
            lblPriceProd3.BackColor = Color.FromArgb(184, 148, 25);
            BackColor = Color.FromName("black");
        }
        public void ModoNormal()//cambia la apariencia del form a modo normal
        {
            pictureBox1.Image = Properties.Resources.flecha;
            shoppingCartBtn.Image = Properties.Resources.carro;
            lblCategory.ForeColor = Color.FromArgb(0, 0, 0);
            panel1.BackColor = Color.FromArgb(228, 211, 211);
            panel2.BackColor = Color.FromArgb(228, 211, 211);
            panel3.BackColor = Color.FromArgb(228, 211, 211);
            lblPriceProd1.BackColor = Color.FromArgb(10, 132, 255);
            lblPriceProd2.BackColor = Color.FromArgb(10, 132, 255);
            lblPriceProd3.BackColor = Color.FromArgb(10, 132, 255);
            BackColor = Color.FromName("Gainsboro");
        }

    }
}
