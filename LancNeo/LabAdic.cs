using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data.SqlClient;

namespace LancNeo
{
    public partial class LabAdic : CatalogoGenerico
    {
        public LabAdic()
        {
            InitializeComponent();
        }

        private void LabAdic_Load(object sender, EventArgs e)
        {
            buscaBtn1.Catalogo = this;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            sqlDALaboratorista.Fill(dsLaboratorista1, "Laboratorista");
        }
        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            cmbIdObra.SelectedIndex = -1;
            cmbNoeco.SelectedIndex = -1;
            dtpFmuestreo.Value = DateTime.Now.AddDays(1);
            dtpFmuestreo.Value = DateTime.Today;
            dtpFensaye.Value = DateTime.Now.AddDays(1);
            dtpFensaye.Value = DateTime.Today;
        }


    }
}
