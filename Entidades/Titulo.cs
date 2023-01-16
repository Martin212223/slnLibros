using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Titulo
    {

        public Titulo(string nombre, string autor, string categoria, double precio, string notas)
        {
            Nombre = nombre;

            Autor = autor;

            Categoria = categoria;

            Precio = precio;

            Notas = notas;
        }

        public string Nombre { get; set; }

        public string Autor { get; set; }

        public string Categoria { get; set; }

        public double Precio { get; set; }

        public string Notas { get; set; }
    }
}
