using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_BIBLIOTECA.entidad
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;
        public Biblioteca()
        {
            this.Libros = new List<Libro>();
            this.Lectores = new List<Lector>();
        }

        internal List<Libro> Libros { get => libros; set => libros = value; }
        internal List<Lector> Lectores { get => lectores; set => lectores = value; }

        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;

            Libro libro;

            libro = BuscarLibro(titulo);

            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }

            return resultado;
        }

        private Libro BuscarLibro(string titulo)
        {
            Libro libroBuscado = null;

            int i = 0;

            while (i < Libros.Count && !Libros[i].Titulo.Equals(titulo))
                i++;
            if (i != Libros.Count) libroBuscado = Libros[i];
            return libroBuscado;
        }

        public void ListarLibros()
        {
            foreach (var libro in Libros)
                Console.WriteLine(libro);
        }

        public bool EliminarLibro(string titulo)
        {
            bool resultado = false;

            Libro libro;

            libro = BuscarLibro(titulo);

            if (libro != null)
            {
                Libros.Remove(libro);
                resultado = true;
            }

            return resultado;
        }
    }
}
