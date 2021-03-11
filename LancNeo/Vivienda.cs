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
    public partial class Vivienda : CatalogoGenerico
    {
        public Vivienda()
        {
            InitializeComponent();
        }

        private void Vivienda_Load(object sender, EventArgs e)
        {
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            cmbIdObra.SelectedIndex = 0;
        }
        public override void LoadDataSet()
        {

            base.LoadDataSet();
            if (string.IsNullOrEmpty(cmbIdObra.SelectedValue.ToString()) == false)
            {
                dsVivienda1.Clear();
                sqlDAVivienda.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlDAVivienda.Fill(dsVivienda1, "Vivienda");
            }
        }

        private void dGVVivienda_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = cmbIdObra.SelectedValue;
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsVivienda1.Clear();
            sqlDAVivienda.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDAVivienda.Fill(dsVivienda1, "Vivienda");
        }
    }
}
