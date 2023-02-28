// See https://aka.ms/new-console-template for more information



using System;
using Asignacion_POO;

class PracticaPOO
{
    static void Main(string[] args)
    {
        Garaje garaje = new Garaje();
        Coche coche1 = new Coche("Honda", "Civic");
        Coche coche2 = new Coche("Ford", "Explorer");

        Random rand = new Random();

        for (int i = 0; i < 2; i++)
        {
            if (garaje.aceptcoche(coche1, "Frenos"))
            {
                double importe_averia = rand.NextDouble() * 100;
                coche1.precio_acumulado_en_averias(importe_averia);

                Console.WriteLine("El coche {0} {1} ha sido atendido. Importe de la avería: {2}.", coche1.marca, coche1.modelo, importe_averia);

                if (coche1.precio_acumulado_en_averias == "aceite")
                {
                    coche1.motor.litros_de_aceite += 10;
                    Console.WriteLine("Se han logrado añadidir 10 litros de aceite al coche {0} {1}.", coche1.marca, coche1.modelo);
                }

                garaje.devolvercoche();
            }

            if (garaje.aceptcoche(coche2, "Aceite"))
            {
                double importe_averia = rand.NextDouble() * 100;
                coche2.precio_acumulado_en_averias(importe_averia);

                Console.WriteLine("El coche {0} {1} ha sido atendido por el garaje. Importe de la avería: {2}.", coche2.marca, coche2.modelo, importe_averia);

                if (coche2.precio_acumulado_en_averias == "aceite")
                {
                    coche2.motor.litros_de_aceite += 10;
                    Console.WriteLine("Se han añadido 10 litros de aceite al coche {0} {1}.", coche2.marca, coche2.modelo);
                }

                garaje.devolvercoche();
            }
        }

        Console.WriteLine("Información de los coches:");
        Console.WriteLine("Coche 1: {0} {1}. Importe acumulado de averías: {2}. Litros de aceite en el motor: {3}.", coche1.marca, coche1.modelo, coche1.ImporteAverias, coche1.motor.litros_de_aceite);
        Console.WriteLine("Coche 2: {0} {1}. Importe acumulado de averías: {2}. Litros de aceite en el motor: {3}.", coche2.marca, coche2.modelo, coche2.ImporteAverias, coche2.motor.litros_de_aceite);
    }
}
