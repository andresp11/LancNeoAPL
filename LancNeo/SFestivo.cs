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
    public partial class SFestivo : CatalogoGenerico
    {
        public SFestivo()
        {
            InitializeComponent();
        }

        private void SFestivo_Load(object sender, EventArgs e)
        {
            buscaBtn1.Catalogo = this;
        }
    }
}
