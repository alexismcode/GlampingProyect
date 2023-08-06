namespace Glamping.Logica
{
    // Clase abstracta que define la información básica de un cliente de reservas.
    public abstract class Clientes
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public string? Correo { get; set; }
        public int Celular { get; set; }
        public int Huespedes { get; set; }

        public string? _reservar { get; set; }

        // Propiedad que permite obtener y establecer el día de la reserva, validando que sea un día válido.
        public string? Reservar
        {
            get => _reservar;
            set => _reservar = ValidateReservar(value?.ToUpper());
        }



        public override string ToString()
        {
            return $"Nombre..................:{Nombre,20}\n" +
                   $"Apellido................:{Apellido,20}\n" +
                   $"Correo..................:{Correo,20}\n" +
                   $"Celular.................:{Celular,20}\n" +
                   $"Huespedes...............:{Huespedes,20}\n" +
                   $"Dia de reserva..........:{Reservar,20}\n";
        }

        // Método privado para validar si el día de reserva es válido.
        private string? ValidateReservar(string? value)
        {
            if (value == "JUEVES" || value == "VIERNES" || value == "SÁBADO" || value == "DOMINGO")

            {
                return value;

            }
            throw new ArgumentException("Día no inválido. Los días permitidos son jueves, viernes, sabado y domingo.");
        }
        // Método abstracto que debe ser implementado por las clases derivadas para calcular el valor a pagar.
        public abstract decimal GetValueToPay();
    }
}