using System;
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
        }
    }
}
