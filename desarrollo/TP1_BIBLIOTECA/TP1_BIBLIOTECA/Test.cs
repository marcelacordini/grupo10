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

            // 1. Cargar datos iniciales
            CargarLibrosDeProgramacion();
            CargarLectores();

            // 2. Mostrar estado inicial
            Console.WriteLine("=== ESTADO INICIAL ===");
            biblioteca.ListarLibros();
            biblioteca.ListarLectores();
            Console.WriteLine();

            // 3. Pruebas del método prestarLibro()
            ProbarPrestamos();

            // --- Métodos locales ---
            void CargarLibrosDeProgramacion()
            {
                string[] librosProgramacion = {
                    "Clean Code", "Design Patterns", "The Pragmatic Programmer",
                    "Code Complete", "Refactoring", "Head First Design Patterns",
                    "Domain-Driven Design", "Introduction to Algorithms",
                    "Structure and Interpretation of Computer Programs",
                    "The Art of Computer Programming"
                };

                string[] autores = {
                    "Robert Martin", "Erich Gamma", "Andrew Hunt",
                    "Steve McConnell", "Martin Fowler", "Eric Freeman",
                    "Eric Evans", "Thomas Cormen", "Harold Abelson",
                    "Donald Knuth"
                };

                for (int i = 0; i < librosProgramacion.Length; i++)
                {
                    bool pude = biblioteca.AgregarLibro(librosProgramacion[i], autores[i], "Editorial Técnica");
                    if (pude) Console.WriteLine($"Libro '{librosProgramacion[i]}' agregado.");
                }
                Console.WriteLine();
            }

            void CargarLectores()
            {
                var lectores = new Dictionary<string, int> {
                    {"Adriana", 33456123},
                    {"Lucas", 35678234},
                    {"Marcela", 27345128},
                    {"Verónica", 40123987},
                    {"Enrique", 38456219}
                };

                foreach (var lector in lectores)
                {
                    bool pude = biblioteca.AltaLector(lector.Key, lector.Value);
                    Console.WriteLine(pude ? $"{lector.Key} agregado correctamente." : $"{lector.Key} ya existe.");
                }
                Console.WriteLine();
            }

            void ProbarPrestamos()
            {
                Console.WriteLine("=== PRUEBAS DE PRESTARLIBRO() ===");

                // Caso 1: Préstamo exitoso
                Console.WriteLine("\nCaso 1: Adriana pide 'Clean Code'");
                string resultado = biblioteca.PrestarLibro("Clean Code", 33456123);
                Console.WriteLine($"Resultado: {resultado}");

                // Caso 2: Libro inexistente
                Console.WriteLine("\nCaso 2: Lucas pide 'Libro Inexistente'");
                resultado = biblioteca.PrestarLibro("Libro Inexistente", 35678234);
                Console.WriteLine($"Resultado: {resultado}");

                // Caso 3: Lector inexistente
                Console.WriteLine("\nCaso 3: DNI 99999999 pide 'Clean Code'");
                resultado = biblioteca.PrestarLibro("Clean Code", 99999999);
                Console.WriteLine($"Resultado: {resultado}");

                // Caso 4: Tope de préstamos
                Console.WriteLine("\nCaso 4: Marcela pide 4 libros (solo puede 3)");
                biblioteca.PrestarLibro("Design Patterns", 27345128);
                biblioteca.PrestarLibro("The Pragmatic Programmer", 27345128);
                biblioteca.PrestarLibro("Code Complete", 27345128);
                resultado = biblioteca.PrestarLibro("Refactoring", 27345128);
                Console.WriteLine($"Resultado al pedir el 4to libro: {resultado}");

                // Caso 5: Libro ya prestado
                Console.WriteLine("\nCaso 5: Verónica pide 'Clean Code' (ya lo tiene Adriana)");
                resultado = biblioteca.PrestarLibro("Clean Code", 40123987);
                Console.WriteLine($"Resultado: {resultado}");

                // Mostrar estado final
                Console.WriteLine("\n=== ESTADO FINAL ===");
                Console.WriteLine("Libros restantes en biblioteca:");
                biblioteca.ListarLibros();
                
                
                
                
            }
        }
    }
}
