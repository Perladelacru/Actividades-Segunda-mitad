// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace puesto_de_chimi_asignacion
{
    // Hamburguesa clasica
    public class Hamburguesa
    {
        string tipo_pan;
        string carne;
        int precio_original = 130;
        string ingrediente;
        int cargo_adicional { get; set; }
        int sum = 0;

        List<string> ingredientes_adicionales = new List<string>();
        List<int> cargos_adicionales = new List<int>();

        public Hamburguesa(string tipo_pan, string carne, int precio_original)
        {
            this.tipo_pan = tipo_pan;
            this.carne = carne;
            this.precio_original = precio_original;
        }

        public virtual void Agreg_Ing_Adicional(string ingrediente, int cargo_adicional)
        {
            if (ingredientes_adicionales.Count < 4)
            {
                ingredientes_adicionales.Add(ingrediente);
                cargos_adicionales.Add(cargo_adicional);
                sum = cargos_adicionales.Sum();
            }
            else
            {
                Console.WriteLine("No es posible agregar mas ingredientes");
            }
        }

        public virtual void MostrarPrecio()
        {
            Console.WriteLine("Hamburguesa " + this.GetType().Name + ":");
            Console.WriteLine("Carne: " + carne);
            Console.WriteLine("Tipo de pan: " + tipo_pan);
            Console.WriteLine("Ingredientes adicionales seleccionados:");
            foreach (string ingrediente in ingredientes_adicionales)
            {
                Console.WriteLine("    " + ingrediente);
            }
            Console.WriteLine("Precio: $" + sum);
            Console.WriteLine("");
        }

        // Hamburguesa saludable(tipo de pan integral + dos ingredientes)
        public class Hamburguesa_Saludable : Hamburguesa
        {
            public Hamburguesa_Saludable(string tipo_Pan, string carne, int precio_original) : base(tipo_Pan, carne, precio_original)
            {
                this.ingredientes_adicionales = new List<string>();
            }

            public override void Agreg_Ing_Adicional(string ingrediente, int cargo_adicional)
            {
                if (ingredientes_adicionales.Count >= 2)
                {
                    Console.WriteLine("No es posible agregar más ingredientes.");
                    return;
                }

                ingredientes_adicionales.Add(ingrediente);
                this.precio_original += cargo_adicional;
                sum = precio_original + cargos_adicionales.Sum();
            }
        }
    }
        public class Hamburguesa_Premium : Hamburguesa
        {
            Dictionary<string, int> adicionales_premium = new Dictionary<string, int>();
            int precioPremium;

            public Hamburguesa_Premium(string tipo_pan, string carne, int precio_original) : base(tipo_pan, carne, precio_original)
            {
                adicionales_premium.Add("Papas fritas", 140);
                adicionales_premium.Add("Refresco", 80);
                int precio_papas = adicionales_premium["Papas fritas"];
                int precio_refresco = adicionales_premium["Refresco"];
                precioPremium = precio_papas + precio_refresco;
            }
        }





    //Hamburguesa Saludable (en tipo de pan integral, más dos ingredientes adicionales que se puedan agregar.

    //La hamburguesa saludable puede tener un total de 6 ingredientes adicionales en total.

    //Consejo: probablemente usted quiere procesar los dos ingredientes adicionales en esta nueva clase, no en la clase base, ya que los dos ingredientes adicionales son únicamente propios para esta nueva clase.


    internal class puesto_de_chimi_asignacion
    {

        static void Main(string[] args)
        {
            Hamburguesa hamburguesa1 = new Hamburguesa("blanco", "res", 130);
            hamburguesa1.Agreg_Ing_Adicional("lechuga", 10);
            hamburguesa1.Agreg_Ing_Adicional("tomate", 10);
            hamburguesa1.MostrarPrecio();

            Hamburguesa hamburguesa2 = new Hamburguesa.Hamburguesa_Saludable("integral", "pollo", 150);
            hamburguesa2.Agreg_Ing_Adicional("cebolla", 5);
            hamburguesa2.Agreg_Ing_Adicional("pepinillos", 5);
            hamburguesa2.MostrarPrecio();

            Hamburguesa hamburguesa3 = new Hamburguesa_Premium("blanco", "cerdo", 180);
            hamburguesa3.Agreg_Ing_Adicional("queso cheddar", 20);
            hamburguesa3.Agreg_Ing_Adicional("tocino", 30);
            hamburguesa3.MostrarPrecio();
         

        }
    }
    }












