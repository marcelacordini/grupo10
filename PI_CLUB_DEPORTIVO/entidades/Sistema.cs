using PI_CLUB_DEPORTIVO.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_CLUB_DEPORTIVO.entidades
{
    public class Sistema
    {
        //TO-DO: DESCOMENTAR TODO CUANDO SEA NECESARIO!!


        //// Atributo privado para almacenar socios inactivos
        //private List<Socio> sociosInactivos;

        //// Constructor
        //public Sistema()
        //{
        //    sociosInactivos = new List<Socio>();
        //}

        //// Método público para controlar vencimientos
        //public void ControlarVencimientos(List<Socio> socios)
        //{
        //    foreach (var socio in socios)
        //    {
        //        socio.VerificarVencimiento();
        //        if (socio.GetType() == typeof(Socio) && socio.GetType().GetProperty("estado").GetValue(socio, null).ToString() == "Inactivo")
        //        {
        //            sociosInactivos.Add(socio);
        //        }

        //    }
        //}
        //// Método público para mostrar socios inactivos 
        //public void MostrarSociosInactivos()
        //{
        //    Console.WriteLine("Socios inactivos:");
        //    foreach (var socio in sociosInactivos)
        //    {
        //        Console.WriteLine($"ID: {socio.GetType().GetProperty("idCliente").GetValue(socio, null)}, Nombre: {socio.GetType().GetProperty("nombre").GetValue(socio, null)}");
        //    }
        //}

        //// Método público para desbloquear acceso
        //public void DesbloquearAcceso(Socio socio)
        //{
        //    if (sociosInactivos.Contains(socio))
        //    {
        //        sociosInactivos.Remove(socio);
        //        socio.GetType().GetProperty("estado").SetValue(socio, "Activo", null);
        //        Console.WriteLine("Acceso desbloqueado para el socio.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El socio no está bloqueado.");
        //    }
        //}
        //// Método público para mostrar todos los socios
        //public void MostrarTodosLosSocios(List<Socio> socios)
        //{
        //    Console.WriteLine("Lista de todos los socios:");
        //    foreach (var socio in socios)
        //    {
        //        Console.WriteLine($"ID: {socio.GetType().GetProperty("idCliente").GetValue(socio, null)}, Nombre: {socio.GetType().GetProperty("nombre").GetValue(socio, null)}");
        //    }
        //}
        //// Método público para mostrar todos los socios inactivos

        //public void MostrarTodosLosSociosInactivos()
        //{
        //    Console.WriteLine("Lista de todos los socios inactivos:");
        //    foreach (var socio in sociosInactivos)
        //    {
        //        Console.WriteLine($"ID: {socio.GetType().GetProperty("idCliente").GetValue(socio, null)}, Nombre: {socio.GetType().GetProperty("nombre").GetValue(socio, null)}");
        //    }
        //}
        //// Método público para mostrar todos los socios activos
        //public void MostrarTodosLosSociosActivos(List<Socio> socios)
        //{
        //    Console.WriteLine("Lista de todos los socios activos:");
        //    foreach (var socio in socios)
        //    {
        //        if (socio.GetType().GetProperty("estado").GetValue(socio, null).ToString() == "Activo")
        //        {
        //            Console.WriteLine($"ID: {socio.GetType().GetProperty("idCliente").GetValue(socio, null)}, Nombre: {socio.GetType().GetProperty("nombre").GetValue(socio, null)}");
        //        }
        //    }
        //}
        //// Método público para mostrar todos los socios bloqueados
        //public void MostrarTodosLosSociosBloqueados(List<Socio> socios)
        //{
        //    Console.WriteLine("Lista de todos los socios bloqueados:");
        //    foreach (var socio in socios)
        //    {
        //        if (socio.GetType().GetProperty("estado").GetValue(socio, null).ToString() == "Bloqueado")
        //        {
        //            Console.WriteLine($"ID: {socio.GetType().GetProperty("idCliente").GetValue(socio, null)}, Nombre: {socio.GetType().GetProperty("nombre").GetValue(socio, null)}");
        //        }
        //    }
        //}
        //// Método público para mostrar todos los socios con cuotas pendientes
        //public void MostrarTodosLosSociosConCuotasPendientes(List<Socio> socios)
        //{
        //    Console.WriteLine("Lista de todos los socios con cuotas pendientes:");
        //    foreach (var socio in socios)
        //    {
        //        if (socio.GetType().GetProperty("cuotas").GetValue(socio, null) is List<Cuota> cuotas)
        //        {
        //            foreach (var cuota in cuotas)
        //            {
        //                if (cuota.GetType().GetProperty("estado").GetValue(cuota, null).ToString() == "Pendiente")
        //                {
        //                    Console.WriteLine($"ID: {socio.GetType().GetProperty("idCliente").GetValue(socio, null)}, Nombre: {socio.GetType().GetProperty("nombre").GetValue(socio, null)}");
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}
        //// Método público para mostrar todos los socios con cuotas pagadas
        //public void MostrarTodosLosSociosConCuotasPagadas(List<Socio> socios)
        //{
        //    Console.WriteLine("Lista de todos los socios con cuotas pagadas:");
        //    foreach (var socio in socios)
        //    {
        //        if (socio.GetType().GetProperty("cuotas").GetValue(socio, null) is List<Cuota> cuotas)
        //        {
        //            foreach (var cuota in cuotas)
        //            {
        //                if (cuota.GetType().GetProperty("estado").GetValue(cuota, null).ToString() == "Pagada")
        //                {
        //                    Console.WriteLine($"ID: {socio.GetType().GetProperty("idCliente").GetValue(socio, null)}, Nombre: {socio.GetType().GetProperty("nombre").GetValue(socio, null)}");
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}
        // Método público para mostrar todos los socios con cuotas vencidas
    }
}



