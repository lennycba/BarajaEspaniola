using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaEspaniola.baraja
{
    public class Carta
    {
        public int numero;
        public string palo;
    }
    
    public class Baraja
    {
        public List<Carta> cartas;
        public List<Carta> cartasDescartadas = new List<Carta>();

        public Baraja()
        {
            cartas = new List<Carta>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    if (j == 8 || j== 9)
                    {
                        continue;
                    }
                    else
                    {
                        var carta = new Carta();
                        carta.numero = j;
                        switch (i)
                        {
                            case 1:
                                carta.palo = "Espadas";
                                break;
                            case 2:
                                carta.palo = "Copa";
                                break;
                            case 3:
                                carta.palo = "Oro";
                                break;
                            case 4:
                                carta.palo = "Basto";
                                break;
                        }

                        cartas.Add(carta);
                    }
                    
                }
            }
        }

        public void Barajar()
        {
            Random randomizador = new Random();
            cartas = cartas.OrderBy(x => randomizador.Next()).ToList();
        }

        
        public void SiguienteCarta()
        {
            
            cartasDescartadas.Add(cartas[0]);
            
            Console.WriteLine(cartas[0].numero + " de " + cartas[0].palo);
            cartas.RemoveAt(0);

            if (cartas.Count == 0)
            {
                Console.WriteLine("No quedan cartas en la baraja");
            }
        }
        
        public void CartasDisponibles()
        {
            Console.WriteLine("Aún quedan " + cartas.Count + " cartas en el mazo");
            Console.WriteLine();

        }

        public void DarCartas(int numero)
        {
            if (cartas.Count == 0 || cartas.Count < numero)
            {
                Console.WriteLine("No quedan cartas en la baraja");
            }
            else
            {
                for (int i = 0; i < numero; i++)
                {
                    SiguienteCarta();
                }
            }


        }

        public void CartasMonton() 
        {
            
            if (cartasDescartadas.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Aún no se han descartado cartas");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Hata ahora se han descartado las siguientes "+ cartasDescartadas.Count + " cartas");
                foreach (var carta in cartasDescartadas)
                {
                    Console.WriteLine(carta.numero + " de " + carta.palo);
                }
            }
        }

        public void MostrarBaraja()
        {

            foreach (var carta in cartas)
            {
                Console.WriteLine(carta.numero + " de " + carta.palo);
            }
        }
    }

}
