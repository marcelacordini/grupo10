using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_BIBLIOTECA.entidad
{
    internal class Lector
    {
        private string nombre;
        private int dni;
        private List<Libro> librosPrestados;

        public Lector(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.LibrosPrestados = new List<Libro>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public List<Libro> LibrosPrestados { get; set; }
    }
}
