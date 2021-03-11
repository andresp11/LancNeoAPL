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
    public partial class InfRadio : Form
    {
        public InfRadio()
        {
            InitializeComponent();
        }

        private void InfRadio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
        }
        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dsRadio1.Clear();
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            buscaBtn1.Visible = true;
            sqlDARadio.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDARadio.Fill(dsRadio1, "RadioMdor");
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            crvInfAcero.Visible = true;
            dsInfRadio1.Clear();

            cryRepRadio1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryRepRadio1.SetDataSource(dsInfRadio1);

            sqlDARadioMdor.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDARadioMdor.SelectCommand.Parameters["@IdFolio"].Value = txtFolio.Text;
            sqlDARadioMdor.Fill(dsInfRadio1, "RadioMdor");
            sqlDARadioRes.SelectCommand.Parameters["@IdFolio"].Value = txtFolio.Text;
            sqlDARadioRes.Fill(dsInfRadio1, "RadioRes");
            sqlDAObra.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAObra.Fill(dsInfRadio1, "Obra");
            sqlDARazon.SelectCommand.Parameters["@RFC"].Value = dsInfRadio1.Tables["Obra"].Rows[0][1].ToString();
            sqlDARazon.Fill(dsInfRadio1, "Razonsocial");
            sqlDAFirmas.Fill(dsInfRadio1, "Firmas");
//            cryRepPlaAce1.SetParameterValue("@Duplicado", chbDuplicado.Checked);


            crvInfAcero.ReportSource = cryRepRadio1;
            //			crvInfAcero.RefreshReport();
        }

        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            if (dsRadio1.Tables["RadioMdor"].Rows.Count > 0)
            {
                txtFolio.Text = dsRadio1.Tables["RadioMdor"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
                btnVistaPrevia.Visible = true;
            }
            else
            {
                btnVistaPrevia.Visible = false;
            }
        }


    }
}
