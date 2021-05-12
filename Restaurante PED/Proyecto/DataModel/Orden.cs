using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.DataModel
{
    public class Orden
    {
        private int cod_orden;
        private string id_orden;
        private int cod_producto;
        private int cantidad;
        private Panel panel;

        public int Cod_orden { get => cod_orden; set => cod_orden = value; }
        public string Id_orden { get => id_orden; set => id_orden = value; }
        public int Cod_producto { get => cod_producto; set => cod_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Panel Panel { get => panel; set => panel = value; }
    }
}
