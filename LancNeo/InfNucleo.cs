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
    public partial class InfNucleo : Form
    {
        public InfNucleo()
        {
            InitializeComponent();
        }

        private void Fecha_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpIni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InfNucleo_Load(object sender, EventArgs e)
        {
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            sqlDAFirmas.Fill(dsFirmas1, "Firmas");
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dsBusEsp1.Clear();
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            buscaBtn1.Visible = true;
            sqlDABusNucleoEsp.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDABusNucleoEsp.Fill(dsBusEsp1, "NucleoEsp");
        }

        private void buscaBtn1_Click(object sender, EventArgs e)
        {
            txtFolio.Text = dsBusEsp1.Tables["NucleoEsp"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
            btnVistaPrevia.Visible = true;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                crvRepSemNormal.Visible = true;
                dsInfNucleos1.Clear();
                sqlDAObra.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDAObra.Fill(dsInfNucleos1, "Obra");
                DataSet ds = new DataSet();
                    sqlDAInfNucleos.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "%" : cmbIdObra.SelectedValue.ToString());
                    sqlDAInfNucleos.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
                    sqlDAInfNucleos.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                    sqlDAInfNucleos.Fill(dsInfNucleos1, "InfNucleos");
                    int cuantos = dsInfNucleos1.Tables["InfNucleos"].Rows.Count;
                    sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = 19;
                    sqlDANorma.Fill(dsInfNucleos1, "Normas");
                    cryInfNucleos1.SetDataSource(dsInfNucleos1);
                    cryInfNucleos1.SetParameterValue("@F1", dsFirmas1.Tables["Firmas"].Rows[0][1].ToString());
                    cryInfNucleos1.SetParameterValue("@C1", dsFirmas1.Tables["Firmas"].Rows[0][2].ToString());
                    cryInfNucleos1.SetParameterValue("@F2", dsFirmas1.Tables["Firmas"].Rows[1][1].ToString());
                    cryInfNucleos1.SetParameterValue("@C2", dsFirmas1.Tables["Firmas"].Rows[1][2].ToString());
                    cryInfNucleos1.SetParameterValue("@F3", dsFirmas1.Tables["Firmas"].Rows[2][1].ToString());
                    cryInfNucleos1.SetParameterValue("@C3", dsFirmas1.Tables["Firmas"].Rows[2][2].ToString());
                    cryInfNucleos1.SetParameterValue("@F4", dsFirmas1.Tables["Firmas"].Rows[3][1].ToString());
                    cryInfNucleos1.SetParameterValue("@C4", dsFirmas1.Tables["Firmas"].Rows[3][2].ToString());
                    cryInfNucleos1.SetParameterValue("@F5", dsFirmas1.Tables["Firmas"].Rows[4][1].ToString());
                    cryInfNucleos1.SetParameterValue("@C5", dsFirmas1.Tables["Firmas"].Rows[4][2].ToString());
                    cryInfNucleos1.SetParameterValue("@Ruta", chbLogo.Checked);
                cryInfNucleos1.SetParameterValue("@Lab", chbLab.Checked);
                //cryInfNucleos1.SetParameterValue("@Preliminar", false);
                crvRepSemNormal.ReportSource = cryInfNucleos1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbLogo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbLab_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
