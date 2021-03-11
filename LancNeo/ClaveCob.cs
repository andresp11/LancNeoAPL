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
    public partial class ClaveCob : CatalogoGenerico
    {
        public ClaveCob()
        {
            InitializeComponent();
        }

        private void ClaveCob_Load(object sender, EventArgs e)
        {
            sqlDABusObra.Fill(dsBusObra1, "Obra");
//            this.buscaBtn1.Catalogo = this;
        }
    }
}
