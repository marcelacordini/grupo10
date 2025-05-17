using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_CLUB_DEPORTIVO.entidades
{
    public class Cliente
    {
        // Atributos privados
        private int idCliente;
        private string nombre;
        private string apellido;
        private string dni;
        private string correo;
        private string telefono;
        private string domicilio;
        private DateTime fechaAlta;
        private bool aptoFisico;
        private string tipoCliente;

        // Constructor
        public Cliente(int idCliente, string nombre, string apellido, string dni, string correo, string telefono, string domicilio, DateTime fechaAlta, bool aptoFisico, string tipoCliente)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.correo = correo;
            this.telefono = telefono;
            this.domicilio = domicilio;
            this.fechaAlta = fechaAlta;
            this.aptoFisico = aptoFisico;
            this.tipoCliente = tipoCliente;
        }

        // Método público para registrar cliente
        public void RegistrarCliente()
        {
            // Aquí podrías agregar la lógica para registrar al cliente en una base de datos o en un sistema
            Console.WriteLine("Cliente registrado correctamente.");
        }
    }
}
