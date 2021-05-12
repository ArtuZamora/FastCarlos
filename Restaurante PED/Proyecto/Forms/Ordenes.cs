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
    public partial class Ordenes : Form
    {
        public Ordenes()
        {
            InitializeComponent();
        }

        private void changeToMenu_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cambiar a modo menú", this, MousePosition.X - 275, MousePosition.Y - 160);
        }

        private void changeToMenu_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(this);
        }

        private void changeToMenu_Click(object sender, EventArgs e)
        {
            Components.principal.Show();
            this.Hide();
        }

        private void entregarVIPbtn_Click(object sender, EventArgs e)
        {
            if(Collections.pedidosVIP.Count != 0)
            {
                Consults consults = new Consults();
                Pedido pedido = (Pedido)Collections.pedidosVIP.Dequeue().Dato;
                consults.CambiarEstatus(((Orden)pedido.Productos.inicio.Dato).Id_orden, "Finalizado");
                FlwVIP.Controls[0].Dispose();
            }
        }

        private void entregarNRMbtn_Click(object sender, EventArgs e)
        {
            if(Collections.pedidosNormal.Count != 0)
            {
                Consults consults = new Consults();
                Pedido pedido = (Pedido)Collections.pedidosNormal.Dequeue().Dato;
                consults.CambiarEstatus(((Orden)pedido.Productos.inicio.Dato).Id_orden, "Finalizado");
                FlwNormal.Controls[0].Dispose();
            }
        }
    }
}
