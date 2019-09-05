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

            Playlist Año2018 = new Playlist("Peliculas del 2018", "Son algunas de la speliculas que salieron en el 2018 y en 2017");
            Playlist Año2019 = new Playlist("Peliculas del 2019", "Son algunas de la speliculas que salieron en el 2019");

            playlists.Add(Año2018);
            playlists.Add(Año2019);

            Año2018.Peliculas.Add(new Pelicula("120 pulsaciones por minuto", 2017, " Robin Campillo", "Drama", "Fracia", 140,8.1,
                "París, comienzos de la década de 1990. El grupo de jóvenes activistas Act Up lucha por conseguir una mayor " +
                "visibilidad e implicación del Gobierno y de las farmacéuticas en la lucha contra el sida."));
            Año2018.Peliculas.Add(new Pelicula("Caras y lugares", 2017, "Agnès Varda, JR", "Documental", "Francia", 129, 8.6,
                "Rostros y lugares es un documental dirigido por Agnès Varda y el fotógrafo conceptual y artista urbano, JR. "));
            Año2018.Peliculas.Add(new Pelicula("Vengadores: Infinity War", 2018, "Anthony Russo, Joe Russo", "Superheroes", 
                "Estados unidos", 150, 9.0, "Los superhéroes se alían para vencer al poderoso Thanos, el peor enemigo al que se " +
                "han enfrentado. Si Thanos logra reunir las seis gemas del infinito: poder, tiempo, alma, realidad, mente y espacio, nadie podrá detenerlo."));
            Año2018.Peliculas.Add(new Pelicula("Casi 40", 2018, "David Trueba", "comedia", "Espaqña", 87, 7.8, "Una modesta gira de conciertos vuelve " +
                "a reunir a dos amigos de juventud. Ella, cantante de éxito, está ya retirada de la escena. Él, que sobrevive como vendedor de productos " +
                "cosméticos, pretende relanzar la carrera musical de quien fue su amor de adolescencia."));
            Año2018.Peliculas.Add(new Pelicula("Con amor, Simon", 2018, "Greg Berlanti", "Romance", "Estados Unidos", 110, 8.2,
                "Un adolescente homosexual se enamora a través de Internet de un compañero de clase cuya identidad desconoce. Averiguar de quién se trata " +
                "resultará una experiencia divertida, ardua y trascendental."));
            Año2018.Peliculas.Add(new Pelicula("Amante por un día", 2017, "Philippe Garrel", "Drama", "Francia", 85, 7.9, 
                "Una joven regresa a casa después de terminar una relación y descubre que su padre está saliendo con una mujer de su edad."));
            Año2018.Peliculas.Add(new Pelicula("La cámara de Claire", 2018, "Hong Sang-soo", "Drama", "Francia", 99, 8.0, "Durante un viaje de negocios al " +
                "Festival de Cannes la joven Manhee (Kim Min-hee), asistente de ventas de una distribuidora, es despedida por su jefa acusada de ser deshonesta, " +
                "pero en el fondo por una cuestión de celos. Por suerte, conocerá allí a una profesora llamada Claire (Isabelle Huppert), que hace fotos con su " +
                "cámara Polaroid. Cada una de ellas tiene una peculiar visión de la vida, y juntas lograrán entender sus mundos. "));

            Año2019.Peliculas.Add(new Pelicula("Mirai, mi hermana pequeña", 2019, "Mamoru Hosoda", "historias de la vida",
                "Japon", 90, 8.1, "Con Mirai, se mete en la imaginación de un niño pequeño que está afrontando la llegada" +
                " de una nueva inquilina en casa. Una de esas películas para soltar la lagrimilla."));
            Año2019.Peliculas.Add(new Pelicula("Ruben Brandt, coleccionista", 2019, "Milorad Krstic", "thriller de acción ", 
                "Eslovenia", 102, 8.2, "La historia nos presenta a un psicoanalista que vive atormentado en sus pesadillas " +
                "por un buen puñado de pinturas famosas, y llega a la conclusión de que la única manera de superar ese miedo es poseyéndolo. "));
            Año2019.Peliculas.Add(new Pelicula("El blues de Beale Street", 2019, "Barry Jenkins", "romance", "Estados Unidos",
                143, 8.6, "En su historia, una mujer hará lo que sea para demostrar la inocencia de su marido, en unos años 70 " +
                "que aún desprendían un gran racismo institucional."));
            Año2019.Peliculas.Add(new Pelicula("Vengadores: Endgame", 2019, "Anthony Russo, Joe Russo", "superheroes",
                "Estados Unidos", 181, 8.7, "se cierra un fase mas en el universo cinematografico de marvel."));
            Año2019.Peliculas.Add(new Pelicula("Rocketman", 2019, " Dexter Fletcher", "comedia", "Reino Unido", 121, 8.3,
                "Rocketman cuenta la trayectoria del artista Elton John, desde sus años como niño prodigio del piano en la " +
                "Royal Academy of Music hasta llegar a ser una superestrella de fama mundial gracias a su talento y a la duradera asociación con su letrista Bernie Taupin."));
            Año2019.Peliculas.Add(new Pelicula("Dolor y gloria", 2019, "Pedro Almodóvar", "hitorias de la vida", "España",
                108, 8.6, "Salvador Mallo, un director de cine en su ocaso, recuerda su trayectoria vital y profesional desde " +
                "su infancia en el pueblo valenciano de Paterna en los años 60. "));
            Año2019.Peliculas.Add(new Pelicula("Érase una vez en Hollywood", 2019, "Quentin Tarantino", "comedia", "Estados Unidos",
                160, 8.5, "A finales de los 60, Hollywood empieza a cambiar y el actor Rick Dalton tratará seguir el cambio. " +
                "Junto a su doble, ambos verán como sus raíces les complican el cambio, y al mismo tiempo su relación con la " +
                "actriz Sharon Tate, que fue víctima de los Manson en la matanza de 1969."));






            foreach (Playlist playlist in playlists)
            {

                Console.WriteLine("\n\n ------------------------------------ \n\n");
                Console.WriteLine("\nNombre de la playlist: " + playlist.Titulo);
                Console.WriteLine("\nDescripcion: " + playlist.Descripcion);
                Console.WriteLine("\nLista de Peliculas:\n");
                foreach(Pelicula pelicula in playlist.Peliculas)
                {
                    Console.WriteLine("\nTitulo: " + pelicula.Titulo + "\nDrirector: " + pelicula.Director + " Año: " + pelicula.Año +
                        "\nGenero: " + pelicula.Genero + "\nPais de origen : " + pelicula.Pais + "\nDuracion: " + pelicula.Duracion +
                        "\nRating: " + pelicula.Rating + "\nSinopsis: " + pelicula.Sinopsis);
                }
            }

            Console.Read();
        }
    }
}
