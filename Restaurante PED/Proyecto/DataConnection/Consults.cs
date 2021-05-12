using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.DataModel;
using Proyecto.DataStatic;
using Proyecto.DataStructures;

namespace Proyecto.Datos
{
    public class Consults
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public Consults()
        {
            try
            {
                Connection connection = new Connection();
                connection.connect();
                conn = new SqlConnection(connection.chain);
            }
            catch (Exception)
            {
            }
        }
        public void GetProductos()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Productos", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product producto = new Product();
                producto.Cod_producto = Convert.ToInt32(reader["Cod_producto"]);
                producto.Nombre = reader["Nombre"].ToString();
                producto.Cod_categoria = Convert.ToInt32(reader["Cod_categoria"]);
                producto.Precio = Convert.ToDouble(reader["Precio"]);
                producto.Descripcion = reader["Descripcion"].ToString();
                producto.Stock = Convert.ToInt32(reader["Stock"]);
                producto.MinutosPreparacion = Convert.ToDouble(reader["MinutosPreparacion"]);
                byte[] img = (byte[])reader["Imagen"];
                if (img == null) producto.Imagen = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    producto.Imagen = Image.FromStream(ms);
                }
                Collections.productos.Insertar(producto);
            }
            reader.Close();
            conn.Close();
        }
        public void GetCategorias()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Categorias", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Cod_categoria = Convert.ToInt32(reader["Cod_categoria"]);
                categoria.Nombre = reader["Categoria"].ToString();
                byte[] img = (byte[])reader["Imagen"];
                if (img == null) categoria.Imagen = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    categoria.Imagen = Image.FromStream(ms);
                }
                Collections.categorias.Insertar(categoria);
            }
            reader.Close();
            conn.Close();
        }
        public bool ExistVIP(string dui)
        {
            bool exists;
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Usuarios WHERE DUI = '" + dui + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) exists = true;
            else exists = false;
            reader.Close();
            conn.Close();
            return exists;
        }
        public int GetLastOrderID()
        {
            int orderID = 0, nID = 0;
            string oID = "";
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Ordenes", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                cmd = new SqlCommand("SELECT IDENT_CURRENT('Ordenes')", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nID = Convert.ToInt32(reader[0]);
                }
                reader.Close();
                cmd = new SqlCommand("SELECT TOP 1 Id_orden FROM Ordenes WHERE Cod_orden = " + nID, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    oID = reader[0].ToString();
                }
                orderID = Convert.ToInt32(oID.Substring(1));
            }
            reader.Close();
            conn.Close();
            return orderID;
        }
        public void InsertarPedido()
        {
            NodoLista actual = Collections.pedidoActual.inicio;
            conn.Open();
            string sql = "INSERT INTO Ordenes (Id_orden, Cod_producto, Cantidad) VALUES (@IdOrden, @CodProd, @Cant)";
            while (actual != null)
            {
                cmd = new SqlCommand(sql, conn);
                Orden orden = (Orden)actual.Dato;
                cmd.Parameters.AddWithValue("@IdOrden", orden.Id_orden);
                cmd.Parameters.AddWithValue("@CodProd", orden.Cod_producto);
                cmd.Parameters.AddWithValue("@Cant", orden.Cantidad);
                cmd.ExecuteNonQuery();
                actual = actual.Siguiente;
            }
            Collections.pedidoActual = new ListaDoble();
            conn.Close();
        }
        public string ObtenerETA(string orderID)
        {
            conn.Open();
            string eta = "";
            string sql = "EXEC sp_ETA_order @IdOrden";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IdOrden", orderID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    eta = Convert.ToDouble(reader[0]).ToString() + " min";
                }
            }
            reader.Close();
            conn.Close();
            return eta;
        }
        public int ObtenerStock(int productID)
        {
            conn.Open();
            int stock = 0;
            string sql = "SELECT Stock FROM Productos WHERE Cod_producto = @CodProducto";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CodProducto", productID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    stock = Convert.ToInt32(reader[0]);
                }
            }
            reader.Close();
            conn.Close();
            return stock;
        }
        public void CambiarEstatus(string orderID, string estatus)
        {
            conn.Open();
            string sql = "EXEC sp_update_status @idOrden, @estatus";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idOrden", orderID);
            cmd.Parameters.AddWithValue("@estatus", estatus);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
