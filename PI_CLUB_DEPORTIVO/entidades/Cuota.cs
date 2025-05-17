using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_CLUB_DEPORTIVO.entidades
{
    public class Cuota
    {
        // Atributos privados
        private int idCuota;
        private DateTime fechaVencimiento;
        private DateTime fechaPago;
        private float monto;
        private string formaPago;
        private int promocion;
        private string estado;

        // Constructor
        public Cuota(int idCuota, DateTime fechaVencimiento, float monto, string formaPago, int promocion)
        {
            this.idCuota = idCuota;
            this.fechaVencimiento = fechaVencimiento;
            this.monto = monto;
            this.formaPago = formaPago;
            this.promocion = promocion;
            this.estado = "Pendiente";
        }

        // Propiedades para poder acceder a las variables privadas
        public DateTime FechaPago { get { return fechaPago; } set { fechaPago = value; } }
        public string Estado { get { return estado; } set { estado = value; } }

        // Método público para notificar vencimientos
        public void NotificarVencimientos()
        {
            if (DateTime.Now > fechaVencimiento && estado == "Pendiente")
            {
                Console.WriteLine("Notificación: La cuota está vencida.");
            }
            else
            {
                Console.WriteLine("La cuota está al día.");
            }
        }
    }
}
