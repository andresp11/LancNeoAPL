using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LancNeo
{
    public partial class InfCompCon : Form
    {
        public InfCompCon()
        {
            InitializeComponent();
        }

        private void InfCompCon_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; 
            sqlDABusObra.Fill(dsBusObra1, "Obra");
        }
        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dsCompactaMdor1.Clear();
            LlenasSqlDA();
        }
        private void LlenasSqlDA()
        {
            sqlDACompactaMdor.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDACompactaMdor.Fill(dsCompactaMdor1, "CompactaMdor");
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            string renglon = "";
            char enter = '\n';
            crvInfCompacta.Visible = true;
            dsCompactaRep1.Clear();

            cryRepCompCon1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cryRepCompCon1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            cryRepCompCon1.SetDataSource(dsCompactaRep1);
                sqlDAcMdorH.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
//                sqlDAcMdorH.SelectCommand.Parameters["@Folio1"].Value = txtFolio.Text;
                sqlDAcMdorH.Fill(dsCompactaRep1, "CompactaRep");

            sqlDAFirmas.Fill(dsFirmas1, "Firmas");
            sqlDANorma.Fill(dsCompactaRep1, "Normas");

            cryRepCompCon1.SetParameterValue("@Renglon", 1);
            crvInfCompacta.ReportSource = cryRepCompCon1;
        }


    }
}
