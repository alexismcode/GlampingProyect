using Glamping.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    public class Precios : Clientes
    {
        public decimal _precio;
        public int _dias;

        // Constructor predeterminado que inicializa el precio base de la reserva en $50.
        public Precios()
        {
            _precio = 50;
        }

        // Propiedad para acceder y establecer el precio base de la reserva.
        public decimal Precio
        {
            get => _precio;
            set => _precio = (value);
        }

        // Propiedad para acceder y establecer la cantidad de días de la reserva.
        public int Dias
        {
            get => _dias;
            set => _dias = ValidateDias(value);
        }


        // Calcula el valor total a pagar por la reserva multiplicando el precio por la cantidad de días.
        public override decimal GetValueToPay()
        {
            return Precio * Dias;
        }

        // Convierte la información de la reserva en una cadena de formato especial.
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Precio por habitación...:{Precio,20:C2}\n" +
                   $"Total a pagar...........:{GetValueToPay(),20:C2}\n";
        }

        // Valida y normaliza la cantidad de días de la reserva.
        private int ValidateDias(int value)
        {
            if (value < 2)
            {
                throw new ArgumentException("Lo sentimos, minimo son 2 personas");
            }
            else if (value > 5)
            {
                throw new ArgumentException("Lo sentimos, solo un máximo de 5 personas");
            }
            return value;
        }
    }
}
