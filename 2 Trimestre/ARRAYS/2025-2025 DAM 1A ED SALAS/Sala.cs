using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_2025_DAM_1A_ED_SALAS
{
    public class Sala
    { 
        // ATRIBUTOS

        private String pelicula;
        private int aforo;
        private int ocupadas;
        private float entrada;


        // CONSTRUCTORES

        public Sala(string pelicula, int aforo)
        {
            this.pelicula = pelicula;
            this.aforo = aforo;
        }
        public Sala(string pelicula, int aforo, int ocupadas, float entrada)
        {
            this.pelicula = pelicula;
            this.aforo = aforo;
            this.ocupadas = ocupadas;
            this.entrada = entrada;
        }

        // GETTERS Y SETTERS

        public string Pelicula { get => pelicula; set => pelicula = value; }
        public int Aforo { get => aforo; set => aforo = value; }
        public int Ocupadas { get => ocupadas; set => ocupadas = value; }
        public float Entrada { get => entrada; set => entrada = value; }

        // METODOS PROPIOS

        public int ButacasLibres()
        {
            return aforo - ocupadas;
        }
        public float PorcentajeOcupacion()
        {
            return ocupadas * 100 / aforo;
        }
        public float Ingresos()
        {
            return ocupadas * entrada;
        }
        public void Vaciar()
        {
            ocupadas = 0;
        }
        public bool EntraUno()
        {
            if (ocupadas < aforo)
            {
                ocupadas++;
                return true;
            }
            return false;
        }
    }
}
