// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralTelefónica
{
    public class Llamada
    {
        public string numOrigen;
        public string numDestino;
        public double duracion;

        public Llamada()
        {
        }

        public Llamada(string numOrigen, string numDestino, double duracion)
        {
            this.numOrigen = numOrigen;
            this.numDestino = numDestino;
            this.duracion = duracion;
        }

        public string GetNumOrigen()
        {
            return numOrigen;
        }

        public string GetNumDestino()
        {
            return numDestino;
        }

        public double GetDuracion()
        {
            return duracion;
        }

        public virtual double calcularPrecio()
        {
            return 0;
        }
    }

    public class LlamadaProvincial : Llamada
    {
        private const double precio1 = 0.20;
        private const double precio2 = 0.25;
        private const double precio3 = 0.30;
        public int franja;

        public LlamadaProvincial(string numOrigen, string numDestino, double duracion, int franja) : base(numOrigen, numDestino, duracion)
        {
            this.franja = franja;
        }

        public override double calcularPrecio()
        {
            switch (franja)
            {
                case 1:
                    return duracion * precio1;

                case 2:
                    return duracion * precio2;

                case 3:
                    return duracion * precio3;

                default:
                    return 0;
            }
        }
    }

    public class LlamadaLocal : Llamada
    {
        public double precio;

        public LlamadaLocal(string numOrigen, string numDestino, double duracion, double precio) : base(numOrigen, numDestino, duracion)
        {
            this.precio = precio;
        }

        public override double calcularPrecio()
        {
            return duracion * precio;
        }
    }

    public class CentralitaTelefonica
    {
        private List<Llamada> llamadas = new List<Llamada>();

        public void registrarLlamada(Llamada llamada)
        {
            llamadas.Add(llamada);
            Console.WriteLine("Llamada registrada: {0}", llamada.numDestino);
        }

        public int contarLlamadas()
        {
            return llamadas.Count;
        }

        public double calculoCostoTotal()
        {
            double costoTotal = 0;
            foreach (Llamada llamada in llamadas)
            {
                costoTotal += llamada.calcularPrecio();
            }
            return costoTotal;
        }
    }
    internal class Program_CentralTelefonica
            {
                static void Main(string[] args)
                {
                    CentralitaTelefonica centralita = new CentralitaTelefonica();

                    
                    LlamadaLocal llamadaLocal_1 = new LlamadaLocal("809-535-1834", "849-565-5668", 120, 1);
                    LlamadaProvincial llamadaProv_1 = new LlamadaProvincial("809-535-1834", "849-565-5668", 180, 2);
                    LlamadaLocal llamadaLocal_2 = new LlamadaLocal("809-535-1834", "849-565-5668", 90, 3);
                    LlamadaProvincial llamadaProv_2 = new LlamadaProvincial("809-535-1834", "849-565-5668", 240, 3);

                    centralita.registrarLlamada(llamadaLocal_1);
                    centralita.registrarLlamada(llamadaProv_1);
                    centralita.registrarLlamada(llamadaLocal_2);
                    centralita.registrarLlamada(llamadaProv_2);

                    Console.WriteLine("Número de llamadas: {0}", centralita.contarLlamadas());
                    Console.WriteLine("Costo total: {0:C}", centralita.calculoCostoTotal());

                }
            }
        }
