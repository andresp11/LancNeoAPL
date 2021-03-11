using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
    public partial class Intensidad : CatalogoGenerico
    {
        public Intensidad()
        {
            InitializeComponent();
        }

        private void Intensidad_Load(object sender, EventArgs e)
        {
            buscaBtn1.Catalogo = this;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }
    }
}
