using System;
namespace Asignacion_POO
{
	public class Garaje
	{
		private Coche coche;
		private string nombre_averia_asociada;
		private int coches_atendidos { get; set;}

		public Garaje()
		{
			coche = null;
			nombre_averia_asociada = "";
			coches_atendidos = 0;

		}
		public bool aceptcoche(Coche coche,string nombre_averia_asociada)
        {
            if (this.coche != null)
            {
                return false;
            }

            this.coche = coche;
            this.nombre_averia_asociada = nombre_averia_asociada;
			coches_atendidos++;

            return true;
        }

		public Coche devolvercoche()
		{
            Coche coche_dev = coche;
            coche = null;
            nombre_averia_asociada = "";

            return coche_dev;
        }

	}
}

