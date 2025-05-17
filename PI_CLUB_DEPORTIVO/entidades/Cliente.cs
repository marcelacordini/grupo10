using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
     
using PI_CLUB_DEPORTIVO.util;

namespace PI_CLUB_DEPORTIVO.entidades
{
    internal class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private string dni;
        private string correo;
        private string telefono;
        private string domicilio;
        private string fechaAlta;
        private bool aptoFisico;
        private string tipoCliente;

        public Cliente()
        {
        }

        public Cliente(string nombre, string apellido, string dni, string correo, string telefono, string domicilio, string fechaAlta, bool aptoFisico, string tipoCliente)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Correo = correo;
            Telefono = telefono;
            Domicilio = domicilio;
            FechaAlta = fechaAlta;
            AptoFisico = aptoFisico;
            TipoCliente = tipoCliente;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
        internal string TipoCliente { get => tipoCliente; set => tipoCliente = value; }

        public override string ToString()
        {
            return $"Cliente: {Nombre} {Apellido}\nDNI: {Dni} Tel.: {Telefono}\nDomicilio: {Domicilio}\nCorreo: {Correo}\nFecha alta: {FechaAlta}\nTipo: {TipoCliente}\nApto físico: {AptoFisico}";
        }
    }
}
