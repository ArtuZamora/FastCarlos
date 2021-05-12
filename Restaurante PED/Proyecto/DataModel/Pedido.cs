using Proyecto.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.DataModel
{
    public class Pedido
    {
        private FlowLayoutPanel orden;
        private ListaDoble productos;

        public FlowLayoutPanel Orden { get => orden; set => orden = value; }
        public ListaDoble Productos { get => productos; set => productos = value; }
    }
}
