using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
    public partial class RadioMdor : CatalogoGenerico
    {
        public RadioMdor()
        {
            InitializeComponent();
        }

        private void RadioMdor_Load(object sender, EventArgs e)
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
    }
}
