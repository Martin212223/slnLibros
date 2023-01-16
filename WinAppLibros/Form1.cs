using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            Titulo libro1 = new Titulo("The Maze Runner", "James Dashner", "Fantasía", 6000.50, "Primero de una trilogía.");

            MessageBox.Show("Nombre: " + libro1.Nombre + "\nAutor: " + libro1.Autor + "\nCategoría: " + libro1.Categoria + "\nPrecio: $" + libro1.Precio + "\nNotas: " + libro1.Notas);
        }
    }
}
