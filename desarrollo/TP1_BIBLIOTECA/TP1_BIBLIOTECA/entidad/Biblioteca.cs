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
        
        public bool AltaLector(string nombre, int dni)  // cambio de nombre el PDF pide AltaLector
        {
            bool resultado = false;

            Lector lector = BuscarLector(dni);

            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                Lectores.Add(lector);
                resultado = true;
            }

            return resultado;
        }
        
        private Lector BuscarLector(int dni)            //auxiliar
        {
            Lector lectorBuscado = null;

            int i = 0;
            while (i < Lectores.Count && Lectores[i].Dni != dni)
                i++;

            if (i != Lectores.Count)
                lectorBuscado = Lectores[i];

            return lectorBuscado;
        }
        
        public void ListarLectores()                //
        {
            foreach (var lector in Lectores)
                Console.WriteLine("Nombre: " + lector.Nombre + " - DNI: " + lector.Dni);
        }
        
        public Lector BuscarLectorPorDni(int dni)   //
        {
            return Lectores.Find(l => l.Dni == dni);
        }
        
        public List<Lector> BuscarLectoresPorNombre(string nombre)
        {
            return Lectores.FindAll(l => l.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
        
        public bool EliminarLector(int dni)
        {
            Lector lector = BuscarLector(dni);
            if (lector != null)
            {
                Lectores.Remove(lector);
                return true;
            }
            return false;
        }
        
        
        
        public string PrestarLibro(string titulo, int dni)
        {
            
            Libro libro = BuscarLibro(titulo);
            if (libro == null)
            {
                return "LIBRO INEXISTENTE";
            }

            
            Lector lector = BuscarLector(dni);
            if (lector == null)
            {
                return "LECTOR INEXISTENTE";
            }

            
            if (lector.LibrosPrestados.Count >= 3)
            {
                return "TOPE DE PRESTAMO ALCANZADO";
            }

            
            Libros.Remove(libro);
            
            lector.LibrosPrestados.Add(libro);

            return "PRESTAMO EXITOSO";
        }
        
        public string devolverLibro(string titulo, int dni)
        {
            Lector lector = BuscarLector(dni);
            if (lector == null) return "LECTOR INEXISTENTE";

            Libro libro = lector.LibrosPrestados.Find(l => l.Titulo.Equals(titulo));
            if (libro == null) return "LIBRO NO PRESTADO A ESTE LECTOR";

            lector.LibrosPrestados.Remove(libro);
            Libros.Add(libro);
            return "DEVOLUCION EXITOSA";
        }
        
        
    }
}
