using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DataStructures;
using Proyecto.DataModel;

namespace Proyecto.DataStatic
{
    public static class Collections
    {
        public static ListaDoble productos = new ListaDoble();
        public static ListaDoble categorias = new ListaDoble();
        public static ListaDoble pedidoActual = new ListaDoble();
        public static Cola pedidosVIP = new Cola();
        public static Cola pedidosNormal = new Cola();
        public static int SearchCategoryID(string category)
        {
            NodoLista actual = categorias.inicio;
            int id = -1;
            while (actual != null)
            {
                if (((Categoria)actual.Dato).Nombre == category)
                {
                    id = ((Categoria)actual.Dato).Cod_categoria;
                    break;
                }
                actual = actual.Siguiente;
            }

            return id;
        }
        public static ListaDoble FilterProdByCat(int idCat)
        {
            ListaDoble list = new ListaDoble();
            NodoLista actual = productos.inicio;
            while (actual != null)
            {
                if(((Product)actual.Dato).Cod_categoria == idCat)
                {
                    list.Insertar(actual.Dato);
                }
                actual = actual.Siguiente;
            }
            return list;
        }
    }
}
