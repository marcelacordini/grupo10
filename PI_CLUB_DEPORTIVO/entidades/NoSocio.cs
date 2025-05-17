using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PI_CLUB_DEPORTIVO.util;

namespace PI_CLUB_DEPORTIVO.entidades
{
    internal class NoSocio : Cliente
    {
        public NoSocio(string nombre, string apellido, 
            string dni, string correo, string telefono, 
            string domicilio, string fechaAlta, 
            bool aptoFisico) : base(nombre, apellido, dni, correo, telefono, domicilio, fechaAlta, aptoFisico, TipoClienteConst.NO_SOCIO)
        {
        }
    }
}
