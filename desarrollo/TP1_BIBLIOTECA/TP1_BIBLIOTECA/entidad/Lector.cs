using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_BIBLIOTECA.entidad
{
    internal class Lector
    {
        private string nombre;
        private int dni;

        public Lector(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
    }
}
