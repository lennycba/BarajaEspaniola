using BarajaEspaniola.baraja;


////creamos una nueva baraja

//var baraja = new Baraja();

////mostramos la baraja ordenada

//foreach (var carta in baraja.cartas)
//{
//    Console.WriteLine(carta.numero + " de " + carta.palo);
//}

////barajamos y mostramos la baraja mezclada

//baraja.Barajar();
//Console.WriteLine("La baraja se ha barajado");

//foreach (var carta in baraja.cartas)
//{
//    Console.WriteLine(carta.numero + " de " + carta.palo);
//}


////probamos a sacar dos cartas

//Console.WriteLine();
//Console.WriteLine("--------------------------------------------------");
//baraja.SiguienteCarta();

//Console.WriteLine();
//Console.WriteLine("--------------------------------------------------");
//baraja.SiguienteCarta();

//Console.WriteLine();
//Console.WriteLine("--------------------------------------------------");


////mostramos la baraja despues de sacar dos cartas

//foreach (var carta in baraja.cartas)
//{
//    Console.WriteLine(carta.numero + " de " + carta.palo);
//}



//Console.WriteLine();
//Console.WriteLine("-----------------repartir--------------------");

////probamos a repartir 5 cartas

//Console.WriteLine();
//Console.WriteLine("----------------se repartieron---------------------");

//baraja.DarCartas(5);

//Console.WriteLine();
//Console.WriteLine("-------------------------------------");

//foreach (var carta in baraja.cartas)
//{
//    Console.WriteLine(carta.numero + " de " + carta.palo);
//}

////mostramos las cartas que ya fueron repartidas


//Console.WriteLine();
//Console.WriteLine("----------------se descartaron---------------------");

//baraja.CartasMonton();
//foreach (var carta in baraja.cartasDescartadas)
//{
//    Console.WriteLine(carta.numero + " de " + carta.palo);
//}

var baraja = new Baraja();
int opcion = 0;

Console.WriteLine("bienvenido al programa Baraja Virtual");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Hemos creado una nueva baraja");
Console.WriteLine("--------------------------------------------------");

while (opcion != 7)
{
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Seleccione una de las sigientes opciones para continuar: ");

    Console.WriteLine("1. Mostrar la baraja");
    Console.WriteLine("2. Barajar");
    Console.WriteLine("3. mostrar la carta en el tope de la baraja");
    Console.WriteLine("4. Mostrar cuantas cartas quedan disponibles");
    Console.WriteLine("5. Repartir cartas");
    Console.WriteLine("6. Mostrar las cartas que ya han salido");
    Console.WriteLine("7. Salir");
    Console.WriteLine("--------------------------------------------------");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:

            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("A continuación se muestra la baraja");
            Console.WriteLine("--------------------------------------------------");

            baraja.MostrarBaraja();
            break;

        case 2:

            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Se ha barajado el mazo");
            Console.WriteLine("--------------------------------------------------");

            baraja.Barajar();
            break;

        case 3:

            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Se reparte la siguiente carta");
            Console.WriteLine("--------------------------------------------------");

            baraja.SiguienteCarta();
            break;

        case 4:

            Console.Clear();
            baraja.CartasDisponibles();
            break;

        case 5:

            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("¿cuantas cartas desea repartir?");
            Console.WriteLine("--------------------------------------------------");

            int cantCartas = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Se reparten las siguientes " + cantCartas + " cartas");
            Console.WriteLine("--------------------------------------------------");

            baraja.DarCartas(cantCartas);
            break;

        case 6:

            Console.Clear();
            baraja.CartasMonton();
            break;

        case 7:

            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Muchas gracias por utilizar Baraja Virtual");
            Console.WriteLine("--------------------------------------------------");
            break;
    }
}



