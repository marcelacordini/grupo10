using System;
using TP1_BIBLIOTECA.entidad;

namespace TP1_BIBLIOTECA
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // ======================================================
            // 1. CARGA DE DATOS INICIALES
            // ======================================================
            Console.WriteLine("\n=== CARGA DE DATOS ===");
            CargarLibrosDeProgramacion();
            CargarLectores();

            // ======================================================
            // 2. PRUEBAS CON LECTORES
            // ======================================================
            Console.WriteLine("\n=== PRUEBAS CON LECTORES ===");
            ProbarBuscarLector();
            ProbarEliminarLector();

            // ======================================================
            // 3. PRUEBAS CON LIBROS
            // ======================================================
            Console.WriteLine("\n=== PRUEBAS CON LIBROS ===");
            ProbarPrestamos();

            // ======================================================
            // MÉTODOS LOCALES
            // ======================================================

            void CargarLibrosDeProgramacion()
            {
                biblioteca.AgregarLibro("Clean Code", "Robert Martin", "Editorial Técnica");
                biblioteca.AgregarLibro("Design Patterns", "Erich Gamma", "Editorial Técnica");
                biblioteca.AgregarLibro("The Pragmatic Programmer", "Andrew Hunt", "Editorial Técnica");
                biblioteca.AgregarLibro("Code Complete", "Steve McConnell", "Editorial Técnica");
                biblioteca.AgregarLibro("Refactoring", "Martin Fowler", "Editorial Técnica");
                biblioteca.AgregarLibro("Head First Design Patterns", "Eric Freeman", "Editorial Técnica");
                biblioteca.AgregarLibro("Domain-Driven Design", "Eric Evans", "Editorial Técnica");
                biblioteca.AgregarLibro("Introduction to Algorithms", "Thomas Cormen", "Editorial Técnica");
                biblioteca.AgregarLibro("Structure and Interpretation of Computer Programs", "Harold Abelson", "Editorial Técnica");
                biblioteca.AgregarLibro("The Art of Computer Programming", "Donald Knuth", "Editorial Técnica");
                Console.WriteLine("Libros cargados correctamente.\n");
            }

            void CargarLectores()
            {
                biblioteca.AltaLector("Adriana", 33456123);
                biblioteca.AltaLector("Lucas", 35678234);
                biblioteca.AltaLector("Marcela", 27345128);
                biblioteca.AltaLector("Verónica", 40123987);
                biblioteca.AltaLector("Enrique", 38456219);
                Console.WriteLine("Lectores cargados correctamente.\n");
            }

            void ProbarBuscarLector()
            {
                Console.WriteLine("\nBuscando lector con DNI 35678234:");
                var lector = biblioteca.BuscarLectorPorDni(35678234);
                if (lector != null)
                    Console.WriteLine($"Lector encontrado: {lector.Nombre} - DNI: {lector.Dni}");
                else
                    Console.WriteLine("Lector no encontrado.");

                Console.WriteLine("\nBuscando lector con DNI inexistente 99999999:");
                lector = biblioteca.BuscarLectorPorDni(99999999);
                Console.WriteLine(lector == null ? "Lector no encontrado." : "Error: lector debería no existir.");
            }

            void ProbarEliminarLector()
            {
                Console.WriteLine("\nEliminando lector con DNI 38456219:");
                bool eliminado = biblioteca.EliminarLector(38456219);
                Console.WriteLine(eliminado ? "Lector eliminado correctamente." : "No se pudo eliminar el lector.");

                Console.WriteLine("Intentando eliminar al mismo lector nuevamente:");
                eliminado = biblioteca.EliminarLector(38456219);
                Console.WriteLine(!eliminado ? "Lector ya no existe." : "Error: no debería poder eliminarse.");
            }

            void ProbarPrestamos()
            {
                // Mostrar estado inicial
                Console.WriteLine("\nEstado inicial de la biblioteca:");
                biblioteca.ListarLibros();
                biblioteca.ListarLectores();

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
                Console.WriteLine("\nEstado final de la biblioteca:");
                biblioteca.ListarLibros();
            }
        }
    }
}
