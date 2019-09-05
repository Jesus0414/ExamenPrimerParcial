using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Pelicula
    {
        public string Titulo { get; set; }
        private int _año;
        public int Año
        {
            get { return _año; }
            set
            {
                if (_año > 1800 || _año < 2019)
                {
                    _año = value;
                }
                else
                {
                    throw new Exception("Tiene que ser entre el año de 1800 a 2019");
                }
            }
        }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string Pais { get; set; }
        private int _duracion;
        public int Duracion
        {
            get { return _duracion; }
            set
            {
                if (_duracion > 0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("La pelicula debe de tener una duracion de al menos 1 minuto");
                }
            }
        }
        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set
            {
                if(_rating<=10 || _rating >= 0)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("El rating tiene que ir del 0 al 10");
                }
            }
        }
        public string Sinopsis { get; set; }

        public Pelicula()
        {
            Titulo = "No se inserto el titulo de la pelicula";
            Año = 0000;
            Director = "No se inserto el nombre del director de la pelicula";
            Genero = "No se inserto el género de la pelicula";
            Pais = "No se inserto el país de origen de la pelicula";
            Duracion = 0000;
            Rating = 0;
            Sinopsis = "No se inserto una sinopsis para la pelicula";
        }
        public Pelicula(string titulo, int año, string director, string genero, string pais, int duracion, 
            double rating, string sinopsis)
        {
            Titulo = titulo;
            Año = año;
            Director = director;
            Genero = genero;
            Pais = pais;
            Duracion = duracion;
            Rating = rating;
            Sinopsis = sinopsis;
        }

    }
}
