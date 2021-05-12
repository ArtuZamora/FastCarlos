using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DataModel
{
    public class Categoria
    {
        private int cod_categoria;
        private string nombre;
        private Image imagen;

        public int Cod_categoria { get => cod_categoria; set => cod_categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Image Imagen { get => imagen; set => imagen = value; }
    }
}