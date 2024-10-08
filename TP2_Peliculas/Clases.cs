using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Peliculas
{
    internal class Clases
    {
        // comentario agregado paraver en git
    }

    public class Peliculas_cargadas
    {
        private string titulo { get; set; }
        private string director { get; set; }
        private string genero { get; set; }
        private string actores { get; set; }
        private int duracion {  get; set; }
        private int realizacion { get; set; }
        private DateOnly estreno {  get; set; }
        private string filmacion { get; set; }
        private string pais {  get; set; }

        public Peliculas_cargadas(string titulo, string director, string genero, string actores,
                                int duracion, int realizacion, DateOnly estreno, string filmacion, string pais)
        {
            this.titulo = titulo;
            this.director = director;
            this.genero = genero;
            this.actores = actores;
            this.duracion = duracion;
            this.realizacion = realizacion;
            this.estreno = estreno;
            this.filmacion = filmacion;
            this.pais = pais;
        }
    }
}
