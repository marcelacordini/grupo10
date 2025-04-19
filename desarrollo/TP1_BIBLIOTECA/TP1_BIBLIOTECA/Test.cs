using System;
using System.Collections.Generic;
using TP1_BIBLIOTECA.entidad;

namespace TP1_BIBLIOTECA
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            cargarLibros(10);
            cargarLibros(5);

            biblioteca.ListarLibros();
            biblioteca.EliminarLibro("Libro5");
            biblioteca.ListarLibros();

            cargarLectores(3); 


            void cargarLibros(int cantidad)
            {
                bool pude;

                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.AgregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (pude) Console.WriteLine("Libro" + i + " agregado correctamente.");
                    else Console.WriteLine("Libro" + i + " ya existe en la biblioteca.");
                }
            }

            void cargarLectores(int cantidad)
            {
                bool pude;

                for (int i = 1; i <= cantidad; i++)
                {
                    int dni = 10000000 + i;
                    pude = biblioteca.AltaLector("Lector" + i, dni);
                    if (pude) Console.WriteLine("Lector" + i + " agregado correctamente.");
                    else Console.WriteLine("Lector" + i + " ya existe en la biblioteca.");
                }
            }       //

            biblioteca.ListarLectores();        //listar

            // Buscar lector por DNI
            Lector lectorEncontrado = biblioteca.BuscarLectorPorDni(10000001);   //
            if (lectorEncontrado != null)
                Console.WriteLine("Lector encontrado: " + lectorEncontrado.Nombre + " - DNI: " + lectorEncontrado.Dni);
            else
                Console.WriteLine("LECTOR INEXISTENTE");

            // Buscar lector por nombre
            List<Lector> lectoresConNombre = biblioteca.BuscarLectoresPorNombre("Lector2");
            foreach (var lector in lectoresConNombre)
            {
                Console.WriteLine("Busqueda lector por nombre: " + lector.Nombre + " - DNI: " + lector.Dni);
            }

            
            // Eliminar lector
            bool eliminado = biblioteca.EliminarLector(10000002);
            Console.WriteLine(eliminado ? "Lector eliminado correctamente." : "No se encontró el lector para eliminar.");
            
        }

    }
}

