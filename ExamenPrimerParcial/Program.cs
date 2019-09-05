using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            Playlist Año2018 = new Playlist("Peliculas del 2018", "Que mas descripcion quiere");
            Playlist Año2019 = new Playlist("Peliculas del 2019", "");

            playlists.Add(Año2018);
            playlists.Add(Año2019);

            foreach(Playlist playlist in playlists)
            {
                Console.WriteLine("\nNombre de la playlist: " + playlist.Titulo);
                Console.WriteLine("\nDescripcion: " + playlist.Descripcion);
                //Console.WriteLine("");
            }

            Console.Read();
        }
    }
}
