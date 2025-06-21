using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PI_CLUB_DEPORTIVO.util;

namespace PI_CLUB_DEPORTIVO.entidades
{
    internal class Socio : Cliente
    {
        private string fechaVencimiento;
        private string estado;
        public Socio(
            string nombre, string apellido, 
            string dni, string correo, 
            string telefono, string domicilio, 
            string fechaAlta, bool aptoFisico,
            string estado, string fechaVencimiento
            ) : base(nombre, apellido, dni, correo, telefono, domicilio, fechaAlta, aptoFisico, TipoClienteConst.SOCIO)
        {
            this.Estado = estado;
            this.FechaVencimiento = fechaVencimiento;
        }

        public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public string Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return String.Concat(base.ToString(), $"\nFecha vencimiento: {FechaVencimiento}\nEstado: {Estado}");
        }
    }
}
