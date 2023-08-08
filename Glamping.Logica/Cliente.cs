using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamping.Logica
{
    public abstract class Cliente
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Celular { get; set; }
        public int Dias { get; set; }

        private string? _correo;
        private int _huespedes;
        private string? _diaReserva;


        public string? Correo
        {
            get => _correo;
            set
            {
                ValidateCorreo(value);
                _correo = value;
            }
        }

        public int Huespedes
        {
            get => _huespedes;
            set
            {
                ValidateHuespedes(value);
                _huespedes = value;
            }
        }
        public string? DiaReserva
        {
            get => _diaReserva;
            set => _diaReserva = ValidateDiaReserva(value?.ToUpper());
        }
        public string? FormaPago { get; set; }

        public override string ToString()
        {
            return $"\t------------------------- INVOICE -------------------------\n\n" +
                   $"\t  Nombre..................: {Nombre} {Apellido}\n" +
                   $"\t  Correo..................: {Correo,30}\n" +
                   $"\t  Celular.................: {Celular,30}\n" +
                   $"\t  Huespedes...............: {Huespedes,30}\n" +
                   $"\t  Días....................: {Dias,30}\n" +
                   $"\t  Día de reserva..........: {DiaReserva,30}";
        }

        private void ValidateCorreo(string? correo)
        {
            if (correo == null || !correo.Contains("@"))
            {
                throw new ArgumentException("Correo inválido. Debe contener el símbolo '@'.");
            }
        }

        private void ValidateHuespedes(int huespedes)
        {
            if (huespedes < 2 || huespedes > 5)
            {
                throw new ArgumentException("Cantidad de huéspedes inválida. Debe estar entre 2 y 5.");
            }
        }
        private string ValidateDiaReserva(string? value)
        {
            if (value == "JUEVES" || value == "VIERNES" || value == "SABADO" || value == "DOMINGO")
                return value;
            throw new ArgumentException("Día de reserva inválido.");
        }

        public abstract decimal GetValueToPay();
    }
}