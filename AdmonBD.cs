using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProyectoBase;

namespace WinFormsProyectoBase
{
    public class AdmonBD
    {
        private MySqlConnection connection;

        public AdmonBD()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public List<Productos> consulta()
        {
            List<Productos> data = new List<Productos>();
            Productos item;
            int id;
            string nombre;
            int categoria;
            string descripcion;
            string imagen;
            float precio;
            int existencias;
            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    categoria = Convert.ToInt32(reader["categoria"]);
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    precio = Convert.ToSingle(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);

                    item = new Productos(id, nombre, categoria, descripcion, imagen, precio, existencias);
                    data.Add(item);

                    //Agregar a las listas static de panes y postres
                    if (item.Categoria == 1)
                    {
                        FormBaseUsuario.listaPanes.Add(item);
                    }
                    else if (item.Categoria == 2)
                    {
                        FormBaseUsuario.listaPostres.Add(item);
                    }

                }
                reader.Close();
                data.ForEach((p) =>
                {
                    //MessageBox.Show(p.Id + "," + p.Producto + "," + p.Imagen + "," + p.Precio);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
        }

        public void agregarListas()
        {
            Productos item;
            int id;
            string nombre;
            int categoria;
            string descripcion;
            string imagen;
            float precio;
            int existencias;
            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    categoria = Convert.ToInt32(reader["categoria"]);
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    precio = Convert.ToSingle(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);

                    item = new Productos(id, nombre, categoria, descripcion, imagen, precio, existencias);
                   
                    //Agregar a las listas static de panes y postres
                    if (item.Categoria == 1)
                    {
                        FormBaseUsuario.listaPanes.Add(item);
                    }
                    else if (item.Categoria == 2)
                    {
                        FormBaseUsuario.listaPostres.Add(item);
                    }

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
        }


        public void insertar(int idp, string nom, int categ, string descrip, string img, float prec, int exis)
        {
            string query = "";
            try
            {

                /* Esta forma de insertar es la menos segura en cuanto ataques por mysql pero la mas sencilla por lo pronto*/
                query = "INSERT INTO productos (id,nombre,categoria,descripcion,imagen,precio,existencias) VALUES ("
               + "'" + idp + "',"
               + "'" + nom + "',"
               + "'" + categ + "',"
               + "'" + descrip + "',"
               + "'" + img + "', "
               + "'" + prec + "',"
               + "'" + exis + "')";



                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nClave duplicada" + ex.Message);
                this.Disconnect();
            }


        }

        public Productos consultaUnRegistro(int idp)
        {

            Productos item = null;
            int id;
            string nombre;
            int categoria;
            string descripcion;
            string imagen;
            float precio;
            int existencias;
            try
            {
                string query = $"SELECT * FROM productos where id={idp};";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  //solo encontrara un registro da una vuelta
                {

                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    categoria = Convert.ToInt32(reader["categoria"]);
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    precio = Convert.ToSingle(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);

                    item = new Productos(id, nombre, categoria, descripcion, imagen, precio, existencias);


                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }


        public void eliminar(int idp)
        {
            string query = "";
            try
            {

                /* Esta forma de insertar es la menos segura en cuanto ataques por mysql pero la mas sencilla por lo pronto*/

                query = "DELETE FROM productos WHERE id=" + idp + ";";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }


        public void actualizar(int idp, string nom, int categ, string descrip, string img, float prec, int exis)
        {
            // UPDATE productos SET id= '[value-1]',producto= '[value-2]',imagen= '[value-3]',precio= '[value-4]' WHERE 1
            try
            {
                string query = "UPDATE productos SET id=" + "'" + idp + "'" + ",nombre=" + "'" + nom + "'" + ",categoria=" + "'" + categ + "'" + ",descripcion=" + "'" + descrip + "'" + ",imagen=" + "'" + img + "'" + ",precio=" + "'" + prec + "'" + ",existencias=" + "'" + exis + "'" + "where id=" + idp + ";";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Actualizado");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);
                this.Disconnect();
            }
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Port=33068; Database=cafeplacita; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                //MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}