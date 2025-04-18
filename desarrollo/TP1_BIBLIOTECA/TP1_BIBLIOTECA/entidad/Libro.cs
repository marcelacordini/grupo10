using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_BIBLIOTECA.entidad
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;

        public Libro(string titulo, string autor, string editorial)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editorial = editorial;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        private string Autor { get => autor; set => autor = value; }
        private string Editorial { get => editorial; set => editorial = value; }

        public override string ToString()
        {
            return "Titulo: " + Titulo + " Autor: " + Autor + " Editorial: " + Editorial;
        }
    }
}
