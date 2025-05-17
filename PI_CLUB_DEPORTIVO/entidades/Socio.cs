using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_CLUB_DEPORTIVO.entidades
{
    public class Socio : Cliente
    {
        // Atributos privados adicionales
        private List<Cuota> cuotas;
        private DateTime fechaVencimiento;
        private string estado;

        // Constructor
        public Socio(int idCliente, string nombre, string apellido, string dni, string correo, string telefono, string domicilio, DateTime fechaAlta, bool aptoFisico, string tipoCliente, DateTime fechaVencimiento, string estado)
            : base(idCliente, nombre, apellido, dni, correo, telefono, domicilio, fechaAlta, aptoFisico, tipoCliente)
        {
            this.cuotas = new List<Cuota>();
            this.fechaVencimiento = fechaVencimiento;
            this.estado = estado;
        }

        // Método público para pagar una cuota
        public void PagarCuota(Cuota cuota)
        {
            cuota.FechaPago = DateTime.Now;
            cuota.Estado = "Pagada";
            Console.WriteLine("Cuota pagada correctamente.");
        }

        // Método público para verificar vencimiento
        public void VerificarVencimiento()
        {
            if (DateTime.Now > this.fechaVencimiento)
            {
                this.estado = "Inactivo";
                Console.WriteLine("El socio ha vencido, estado cambiado a Inactivo.");
            }
            else
            {
                Console.WriteLine("El socio está activo.");
            }
        }

        // Método público para bloquear acceso
        public void BloquearAcceso()
        {
            this.estado = "Bloqueado";
            Console.WriteLine("Acceso bloqueado para el socio.");
        }

        // Método para añadir cuotas al socio
        public void AgregarCuota(Cuota cuota)
        {
            this.cuotas.Add(cuota);
        }
    }
}
