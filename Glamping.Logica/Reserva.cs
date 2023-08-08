using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    public class Reserva : Cliente
    {
        private const decimal PrecioPorNoche = 50.0m;

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"\t  Forma de Pago...........: {FormaPago,30}\n" +
                $"\t  Valor de la Reserva.....: {GetValueToPay(),30:C2}";
        }

        private void ValidateDias(int dias)
        {
            if (dias < 1 || dias > 4)
                throw new ArgumentException("Cantidad de días no válida.");
        }

        private void ValidateFormaPago(string? formaPago)
        {
            formaPago = formaPago?.ToUpper();
            if (formaPago != "EFECTIVO" && formaPago != "TRANSFERENCIA" && formaPago != "TARJETA DE CREDITO")
                throw new ArgumentException("Forma de pago no válida.");
        }

        public override decimal GetValueToPay()
        {
            ValidateDias(Dias);
            ValidateFormaPago(FormaPago);
            return PrecioPorNoche * Dias;
        }
    }
}



