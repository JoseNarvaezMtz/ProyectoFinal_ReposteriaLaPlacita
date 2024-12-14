using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProyectoBase
{
    public class ClassCompras
    {
        public int cantidad;
        public Productos producto;
        public int indice;
        public ClassCompras(int cantidad, Productos producto, int indice) 
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.indice = indice;
        }
        public float costo()
        {
            return this.cantidad * this.producto.Precio;
        }

    }
}
