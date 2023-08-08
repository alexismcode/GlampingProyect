using Glamping.Logica;

Console.WriteLine("========================== GLAMPING BOOKING SYSTEM ==========================\n");

try
{

    Console.Write(" > Ingrese el nombre del reservante: ");
    string nombre = Console.ReadLine();

    Console.Write(" > Ingrese el apellido del reservante: ");
    string apellido = Console.ReadLine();

    Console.Write(" > Ingrese su correo: ");
    string correo = Console.ReadLine();

    Console.Write(" > Ingrese un número celular de contacto: ");
    int celular = int.Parse(Console.ReadLine());

    Console.Write(" > Ingrese la cantidad de huéspedes [MINIMO 2 - MÁXIMO 5 PERSONAS]: ");
    int huespedes = int.Parse(Console.ReadLine());

    Console.Write(" > Ingrese cuantos días va a reservar [MINIMO 1 - MAXIMO 4 DÍAS]: ");
    int dias = int.Parse(Console.ReadLine());

    Console.Write(" > Ingrese el número de habitaciones que desea: ");
    int numeroHabitaciones = int.Parse(Console.ReadLine());

    Console.Write(" > Ingrese el día que se realizará la reserva \n  [JUEVES, VIERNES, SABADO O DOMINGO]: ");
    string diaReserva = Console.ReadLine();

    Console.Write(" > Ingrese la forma en que realizara el pago \n  [EFECTIVO, TRANSFERENCIA, TARJETA DE CREDITO]: ");
    string formaPago = Console.ReadLine();
    Console.WriteLine("\n=============================================================================\n\n\n");

    var factura = new Factura()
    {
        Nombre = nombre,
        Apellido = apellido,
        Correo = correo,
        Celular = celular,
        Huespedes = huespedes,
        Dias = dias,
        Habitaciones = numeroHabitaciones,
        DiaReserva = diaReserva,
        FormaPago = formaPago
    };

    Console.WriteLine(factura);
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: [{ex.Message}]");
}
