using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProyectoBase
{
    public class Usuarios
    {
        int id;
        string nombreCompleto;
        int categoria;
        string cuenta;
        string contrasena;
        float monto;

        public Usuarios(int id, string nombreCompleto, int categoria, string cuenta, string contrasena, float monto)
        {
            this.id = id;
            this.nombreCompleto = nombreCompleto;
            this.categoria = categoria;
            this.cuenta = cuenta;
            this.contrasena = contrasena;
            this.monto = monto;
        }

        public Usuarios() { }

        public int Id { get => id; set => id = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public float Monto { get => monto; set => monto = value; }
    }
}

