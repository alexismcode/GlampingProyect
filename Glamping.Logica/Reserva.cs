using Glamping.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    // Clase que define la información de reserva
    public class Reserva
    {
        public string? _dia;

        public Reserva()
        {
            _dia = "Sabado";
        }

        public Reserva(string? dia)
        {
            _dia = ValidateDia(dia);
        }

        // Propiedad que permite obtener y establecer el día de la reserva.
        public string? Dia
        {
            get => _dia;
            set => _dia = ValidateDia(value);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Dia....................:{Dia,20:C2}\n\t";
        }

        // Método privado para validar si el día de reserva es válido.
        private string? ValidateDia(string? value)
        {
            if (value == "jueves" || value == "viernes" || value == "sabado" || value == "domingo")

            {
                return value;

            }
            throw new ArgumentException("Día no inválido. Los días permitidos son Jueves, viernes, sabado y domingo.");
        }
    }
}



