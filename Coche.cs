using System;
namespace Asignacion_POO
{
	public class Coche
	{
		private Motor motor { get; }
		private string marca { get; }
        private string modelo { get; }
        private double precio_acumulado_en_averias;

        public Coche(string marca, string modelo)
		{
            this.motor = new Motor(0);
            this.marca = marca;
            this.modelo = modelo;
            this.precio_acumulado_en_averias = 0;


        }
        public double Getprecio_acumulado_en_averias()

            {

            return precio_acumulado_en_averias;

            }


        public void acumularAvería(double precio)
        {
            this.precio_acumulado_en_averias += precio;
        }

        internal void precio_acumulado_en_averias(double importe_averia)
        {
            throw new NotImplementedException();
        }
    }
}

