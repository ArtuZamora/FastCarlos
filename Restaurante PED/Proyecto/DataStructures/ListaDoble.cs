using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.DataStructures
{
    public class NodoLista
    {
        private object dato;
        private NodoLista siguiente;
        private NodoLista anterior;
        public object Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoLista Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoLista Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
    public class ListaDoble
    {
        private int count;
        public NodoLista inicio = new NodoLista();
        public NodoLista final = new NodoLista();

        public int Count { get => count; set => count = value; }

        public ListaDoble()
        {
            count = 0;
            inicio = final = null;
        }

        public void Insertar(object dato)
        {
            try
            {
                NodoLista nuevoinicio = new NodoLista();
                nuevoinicio.Dato = dato;
                if (inicio == null)
                {
                    inicio = nuevoinicio;
                    inicio.Siguiente = null;
                    inicio.Anterior = null;
                    final = inicio;
                }
                else
                {
                    final.Siguiente = nuevoinicio;
                    nuevoinicio.Siguiente = null;
                    nuevoinicio.Anterior = final;
                    final = nuevoinicio;
                }
                count++;
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void BuscarNodo(object NodoListabuscado)
        {
            NodoLista actual = new NodoLista();
            actual = inicio;
            bool seencontro = false;
            if (inicio != null)
            {
                while (actual != null && seencontro != true)
                {
                    if (actual.Dato == NodoListabuscado)
                    {
                        seencontro = true;
                    }
                    actual = actual.Siguiente;
                }
                if (seencontro == true)
                {
                    string x = Convert.ToString(NodoListabuscado);
                    MessageBox.Show("El elemento es:" + x, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public NodoLista BuscarNodo(int index)
        {
            if (count >= index)
            {
                int idxCount = 0;
                NodoLista actual = inicio;
                while (actual != null)
                {
                    if (idxCount == index) return actual;
                    actual = actual.Siguiente;
                    idxCount++;
                }
            }
            return null;
        }
        public object ActualizarNodo(object NodoListabuscado, object NodoListacambiar)
        {
            NodoLista actual = new NodoLista();
            actual = inicio;
            bool seencontro = false;
            if (inicio != null)
            {
                while (actual != null && seencontro != true)
                {
                    if (actual.Dato == NodoListabuscado)
                    {
                        actual.Dato = NodoListacambiar;
                        seencontro = true;
                    }
                    actual = actual.Siguiente;
                }
                if (!seencontro)
                {
                    MessageBox.Show("El elemento es:" + actual.Dato, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return actual.Dato;
                }
            }
            else
            {
                MessageBox.Show("Lista doble vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return 0;
        }
        public void EliminarNodo(int posicion)
        {
            try
            {
                NodoLista actual = new NodoLista();
                NodoLista secundario = new NodoLista();
                actual = inicio;

                if (count == 0)
                {
                    MessageBox.Show("Lista Doble vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (count == 1)
                {
                    inicio = final = null;
                    count--;
                }
                else if (posicion >= count)
                {
                    MessageBox.Show("Posición del elemento no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (posicion < count && posicion >= 0)
                {
                    if (posicion == 0)
                    {
                        inicio = inicio.Siguiente;
                        inicio.Anterior = null;
                        count--;
                    }
                    else if (posicion == count - 1)
                    {
                        secundario = final;
                        final = secundario.Anterior;
                        final.Siguiente = null;
                        count--;
                    }
                    else
                    {
                        for (int i = 0; i < posicion; i++)
                        {
                            secundario = actual;
                            actual = actual.Siguiente;
                        }
                        secundario.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior = secundario;
                        count--;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Clear()
        {
            try
            {
                inicio = final = null;
            }
            catch
            {
                throw new Exception("Error borrando la lista");
            }
        }
    }
}
