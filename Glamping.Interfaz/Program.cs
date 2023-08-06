using Glamping.Logica;  // Importa el espacio de nombres Glamping.Logica

Console.WriteLine("============= GLAMPING BOOKING SYSTEM =============\n");  // Imprime un encabezado

try
{
    Console.WriteLine("> Ingrese el nombre del reservante:");
    string? Nombre1 = Console.ReadLine();  // Lee el nombre del reservante desde la consola

    Console.WriteLine("> Ingrese su apellido:");
    string? Apellido1 = Console.ReadLine();  // Lee el apellido del reservante desde la consola

    Console.WriteLine("> Ingrese su correo:");
    string? Correo1 = Console.ReadLine();  // Lee el correo del reservante desde la consola

    Console.WriteLine("> Ingrese su número celular: ");
    int Celular1 = int.Parse(s: Console.ReadLine());  // Lee el número de celular del reservante desde la consola

    Console.WriteLine("> Ingrese la cantidad de huespedes \n[MINIMO 2 - MAXIMO 5 PERSONAS]: ");
    int Huespedes1 = int.Parse(s: Console.ReadLine());  // Lee la cantidad de huéspedes desde la consola

    Console.WriteLine("> Ingrese cuantos días va a reservar \n[MINIMO 1 - MAXIMO 4 DÍAS]: ");
    int Dias1 = int.Parse(s: Console.ReadLine());  // Lee la cantidad de días de reserva desde la consola

    Console.WriteLine("> Ingrese el día que se realizará la reserva \n[JUEVES, VIERNES, SABADO O DOMINGO]:");
    string? Reserva1 = Console.ReadLine();  // Lee el día de la reserva desde la consola
    Console.WriteLine("\n");

    Console.WriteLine("===================================================\n");

    // Crea una nueva instancia de la clase "Precios" del espacio de nombres Glamping.Logica
    var Cliente1 = new Precios()
    {
        Nombre = Nombre1,
        Apellido = Apellido1,
        Correo = Correo1,
        Celular = Celular1,
        Huespedes = Huespedes1,
        Dias = Dias1,
        Reservar = Reserva1,
    };

    Console.WriteLine(Cliente1);  // Imprime la información del cliente y la reserva
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");  // En caso de error, imprime un mensaje de error con el detalle
}
