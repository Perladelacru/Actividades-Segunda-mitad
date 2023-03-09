// See https://aka.ms/new-console-template for more information
using System;



namespace Act.Polimorfismo1
{
    public abstract class Perro
    {
        public virtual string ladrar()
        {
            return "Perro ladrando";
        }
        public abstract string Dormir();

        public abstract string Comer();

        public abstract string Saltar();

        public abstract string Jugar();

        public abstract string Rodar();


    }


    public class Bulldog : Perro
    {
        public override string ladrar()
        {
            return "Bulldog Ladrando";
        }

        public override string Dormir()
        {
            return "Bulldog Durmiendo";
        }

        public override string Comer()
        {
            return "Bulldog Comiendo";
        }

        public override string Saltar()
        {
            return "Bulldog Saltando";
        }

        public override string Jugar()
        {
            return "Bulldog Jugando";
        }

        public override string Rodar()
        {
            return "Bulldog Rodando";
        }


    }

    public class Chihuahua : Perro
    {
        public override string ladrar()
        {
            return "Chihuahua ladrando";
        }

        public override string Dormir()
        {
            return "Chihuahua Durmiendo";
        }

        public override string Comer()
        {
            return "Chihuahua Comiendo";
        }

        public override string Saltar()
        {
            return "Chihuahua Saltando";
        }

        public override string Jugar()
        {
            return "Chihuahua Jugando";

        }

        public override string Rodar()
        {
            return "Chihuahua Rodando";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Chihuahua Chihuahua1 = new Chihuahua();
            Chihuahua Chihuahua2 = new Chihuahua();
            Bulldog Bulldog1 = new Bulldog();
            Bulldog Bulldog2 = new Bulldog();

            Perro[] Perrera = { Chihuahua1, Bulldog1 };
            

            Console.WriteLine("Elija que tipo de perro que desea analizar:");
            Console.WriteLine("A. Chihuahua");
            Console.WriteLine("B. Bulldog");
            Console.WriteLine("C. Analizar Perrera:");

            string opcion = Console.ReadLine();

            Console.Clear();
            if (opcion == "A" || opcion == "a")
            {

                    Console.WriteLine("En esta categoria puede encontrar a un:");
                    Console.WriteLine(Chihuahua1.ladrar());
                    Console.WriteLine(Chihuahua1.Dormir());
                    Console.WriteLine(Chihuahua1.Comer());
                    Console.WriteLine(Chihuahua1.Saltar());
                    Console.WriteLine(Chihuahua1.Jugar());
                    Console.WriteLine(Chihuahua1.Rodar());
                

            }


            if (opcion == "B" || opcion == "b")
            {
                    Console.WriteLine("En esta categoria puede encontrar a un:");
                    Console.WriteLine(Bulldog1.ladrar());
                    Console.WriteLine(Bulldog1.Dormir());
                    Console.WriteLine(Bulldog1.Comer());
                    Console.WriteLine(Bulldog1.Saltar());
                    Console.WriteLine(Bulldog1.Jugar());
                    Console.WriteLine(Bulldog1.Rodar());
               
            }

            if (opcion == "C" || opcion == "c")
            {
                Console.WriteLine("En esta categoria puede encontrar a un:");
                foreach (Perro item in Perrera)
                {
                  
                    Console.WriteLine(item.ladrar());
                    Console.WriteLine(item.Dormir());
                    Console.WriteLine(item.Comer());
                    Console.WriteLine(item.Saltar());
                    Console.WriteLine(item.Jugar());
                    Console.WriteLine(item.Rodar());
                }

            }

        }



    }

}






