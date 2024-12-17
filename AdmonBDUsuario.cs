using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProyectoBase
{
    public class AdmonBDUsuario
    {
        private MySqlConnection connection;

        public AdmonBDUsuario()
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


        public List<Usuarios> consulta()
        {
            List<Usuarios> data = new List<Usuarios>();
            Usuarios item;
            int id;
            string nombreCompleto;
            int categoria;
            string cuenta;
            string contrasena;
            float monto;

            try
            {
                string query = "SELECT * FROM usuarios";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    nombreCompleto = Convert.ToString(reader["nombreCompleto"]) ?? "";
                    categoria = Convert.ToInt32(reader["categoria"]);
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    contrasena = Convert.ToString(reader["contrasena"]) ?? "";
                    monto = Convert.ToSingle(reader["monto"]);


                    item = new Usuarios(id, nombreCompleto, categoria, cuenta, contrasena, monto);
                    data.Add(item);

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

        public void insertar(int idp, string nom, int categ, string cuenta, string contrasena, float monto)
        {
            string query = "";
            try
            {

                /* Esta forma de insertar es la menos segura en cuanto ataques por mysql pero la mas sencilla por lo pronto*/
                query = "INSERT INTO usuarios (id,nombreCompleto,categoria,cuenta,contrasena,monto) VALUES ("
               + "'" + idp + "',"
               + "'" + nom + "',"
               + "'" + categ + "',"
               + "'" + cuenta + "',"
               + "'" + contrasena + "', "
               + "'" + monto + "')";

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

        public Usuarios consultaUnRegistro(string account)
        {

            Usuarios item = null;
            int id;
            string nombreCompleto;
            int categoria;
            string cuenta;
            string contrasena;
            float monto;
            try
            {
                string query = "SELECT * FROM usuarios WHERE cuenta = '" + account + "';";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  //solo encontrara un registro da una vuelta
                {

                    id = Convert.ToInt32(reader["id"]);
                    nombreCompleto = Convert.ToString(reader["nombreCompleto"]) ?? "";
                    categoria = Convert.ToInt32(reader["categoria"]);
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    contrasena = Convert.ToString(reader["contrasena"]) ?? "";
                    monto = Convert.ToSingle(reader["monto"]);

                    item = new Usuarios(id, nombreCompleto, categoria, cuenta, contrasena, monto);


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

                query = "DELETE FROM usuarios WHERE id=" + idp + ";";

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


        public void actualizar(int idp, string nom, int categ, string cuenta, string contrasena, float monto)
        {
            // UPDATE `usuarios` SET `id`= '[value-1]',`producto`= '[value-2]',`imagen`= '[value-3]',`precio`= '[value-4]' WHERE 1
            try
            {
                string query = "UPDATE usuarios SET id=" + "'" + idp + "'" + ",nombreCompleto=" + "'" + nom + "'" + ",categoria=" + "'" + categ + "'" + ",cuenta=" + "'" + cuenta + "'" + ",contrasena=" + "'" + contrasena + "'" + ",monto=" + "'" + monto + "'" + "where id=" + idp + ";";
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
            string cadena = "Server=localhost; Port=3306; Database=cafeplacita; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

