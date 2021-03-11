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
    public partial class LiquidoMdor : CatalogoGenerico
    {
        public LiquidoMdor()
        {
            InitializeComponent();
        }

        private void liquidoMdor_Load(object sender, EventArgs e)
        {
            buscaBtn1.Catalogo = this;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
        }
        
        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            cmbIdObra.SelectedIndex = -1;
            dtpFmuestreo.Value = DateTime.Now.AddDays(1);
            dtpFmuestreo.Value = DateTime.Today;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
