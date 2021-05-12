using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DataModel
{
    public class Product
    {
        private int cod_producto;
        private string nombre;
        private int cod_categoria;
        private double precio;
        private string descripcion;
        private int stock;
        private double minutosPreparacion;
        private Image imagen;

        public int Cod_producto { get => cod_producto; set => cod_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cod_categoria { get => cod_categoria; set => cod_categoria = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Stock { get => stock; set => stock = value; }
        public double MinutosPreparacion { get => minutosPreparacion; set => minutosPreparacion = value; }
        public Image Imagen { get => imagen; set => imagen = value; }
    }
}
