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
    public partial class InfLiquid : Form
    {
        public InfLiquid()
        {
            InitializeComponent();
        }

        
        private void buscaBtn1_Click(object sender, EventArgs e)
        {
            {
                if (dsLiquid1.Tables["LiquidoMdor"].Rows.Count > 0)
                {
                    txtFolio.Text = dsLiquid1.Tables["LiquidoMdor"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
                    btnVistaPrevia.Visible = true;
                }
                else
                {
                    btnVistaPrevia.Visible = false;
                }
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            {
                crvInfAcero.Visible = true;
                dsInfLiquid1.Clear();

                cryRepLiquido1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                cryRepLiquido1.SetDataSource(dsInfLiquid1);

                sqlDALiquidMdor.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDALiquidMdor.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
                sqlDALiquidMdor.Fill(dsInfLiquid1, "LiquidoMdor");
                sqlDALiquidEsp.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
                sqlDALiquidEsp.Fill(dsInfLiquid1, "LiquidoRes");
                sqlDAObra.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDAObra.Fill(dsInfLiquid1, "Obra");
                sqlDARazon.SelectCommand.Parameters["@RFC"].Value = dsInfLiquid1.Tables["Obra"].Rows[0][1].ToString();
                sqlDARazon.Fill(dsInfLiquid1, "Razonsocial");
                sqlDAFirmas.Fill(dsInfLiquid1, "Firmas");
                //            cryRepPlaAce1.SetParameterValue("@Duplicado", chbDuplicado.Checked);


                crvInfAcero.ReportSource = cryRepLiquido1;
                //			crvInfAcero.RefreshReport();
            }
        }

        private void InfLiquid_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsLiquid1.Clear();
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            buscaBtn1.Visible = true;
            sqlDALiquid.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDALiquid.Fill(dsLiquid1, "LiquidoMdor");
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }
    }
}
