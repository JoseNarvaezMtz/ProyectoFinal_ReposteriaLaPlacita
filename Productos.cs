using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProyectoBase
{
    public class Productos
    {
        int id;
        string nombre;
        int categoria;
        string descripcion;
        byte[] imagen;
        float precio;
        int existencias;

        public Productos() { }
        public Productos(int id, string nombre, int categoria, string descripcion, byte[] imagen, float precio, int existencias)
        {
            this.id = id;
            this.nombre = nombre;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.precio = precio;
            this.existencias = existencias;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
    }
}