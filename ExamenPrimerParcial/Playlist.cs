using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> Peliculas { get; set; }

        public Playlist()
        {
            Titulo = "No se inserto el titulo de la playlist";
            Descripcion = "No se inserto una descripcion para la playlist";
            Peliculas = new List<Pelicula>();
        }
        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Peliculas = new List<Pelicula>();
        }
    }
}
