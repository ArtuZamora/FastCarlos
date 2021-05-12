using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.DataStructures
{
    public class NodoCola
    {
        private object dato;
        private NodoCola siguiente;
        public object Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoCola Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
    public class Cola
    {
        private int count = 0;
        public NodoCola primero = new NodoCola();
        public NodoCola ultimo = new NodoCola();

        public int Count { get => count; set => count = value; }

        public Cola()
        {
            primero = null;
            ultimo = null;
        }
        public void Enqueue(object dato)
        {
            NodoCola nuevo = new NodoCola();
            nuevo.Siguiente = null;
            nuevo.Dato = dato;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            count++;
        }
        public void BuscarNodoCola(object NodoColabuscado)
        {
            NodoCola actual = new NodoCola();
            actual = primero;
            bool seencontro = false;
            if (primero != null)
            {
                while (actual != null && seencontro != true)
                {
                    if (actual.Dato == NodoColabuscado)
                    {
                        seencontro = true;
                    }
                    actual = actual.Siguiente;
                }
                if (seencontro == true)
                {
                    string x = Convert.ToString(NodoColabuscado);
                    MessageBox.Show("El elemento es:" + x, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public object ActualizarNodoCola(object NodoColabuscado, object NodoColacambiar)
        {
            NodoCola actual = new NodoCola();
            actual = primero;
            bool seencontro = false;
            if (primero != null)
            {
                while (actual != null && seencontro != true)
                {
                    if (actual.Dato == NodoColabuscado)
                    {
                        actual.Dato = NodoColacambiar;
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
                MessageBox.Show("Cola vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return 0;
        }

        public NodoCola Dequeue()
        {
            NodoCola actual = primero;
            NodoCola aux = actual;
            if (primero == ultimo)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                primero = primero.Siguiente;
            }
            actual = null;
            count--;
            return aux;
        }
        public void Clear()
        {
            while (primero != null)
            {
                this.Dequeue();
            }
            count = 0;
        }
    }
}
