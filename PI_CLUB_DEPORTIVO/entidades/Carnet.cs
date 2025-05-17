using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_CLUB_DEPORTIVO.entidades
{
    public class Carnet
    {
        // Atributos privados
        private int idCarnet;
        private int idSocio;
        private DateTime fechaEmision;
        private DateTime fechaVencimiento;

        // Constructor
        public Carnet(int idCarnet, int idSocio, DateTime fechaEmision, DateTime fechaVencimiento)
        {
            this.idCarnet = idCarnet;
            this.idSocio = idSocio;
            this.fechaEmision = fechaEmision;
            this.fechaVencimiento = fechaVencimiento;
        }

        // Método público para emitir el carnet
        public void EmitirCarnet()
        {
            Console.WriteLine($"Carnet emitido para el socio con ID {idSocio}. Fecha de vencimiento: {fechaVencimiento.ToShortDateString()}");
        }
    }
}
