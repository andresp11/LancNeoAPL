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
    public partial class InfTabN : Form
    {
        public InfTabN()
        {
            InitializeComponent();
        }

        private void InfTabN_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dsTabMdor1.Clear();
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            buscaBtn1.Visible = true;
            LlenasSqlDA();
        }
        private void LlenasSqlDA()
        {
            sqlDATabiqueMdor.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDATabiqueMdor.Fill(dsTabMdor1, "TabiqueMdor");
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            crvInfTabique.Visible = true;
            dsInfTabN1.Clear();
            sqlDAInfTabiqueMdor.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAInfTabiqueMdor.SelectCommand.Parameters["@FolioIni"].Value = (chbTodos.Checked ? " " : txtFolio.Text);
            sqlDAInfTabiqueMdor.SelectCommand.Parameters["@FolioFin"].Value = (chbTodos.Checked ? "zzzzz" : txtFolio.Text);
            sqlDAInfTabiqueMdor.Fill(dsInfTabN1, "TabRepN");
            for (int m = 0; m < dsInfTabN1.Tables["TabRepN"].Rows.Count; m++)
            {
                sqlDAInfTabiqueResC.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDAInfTabiqueResC.SelectCommand.Parameters["@Folio1"].Value = dsInfTabN1.Tables["TabRepN"].Rows[m][0].ToString();
                sqlDAInfTabiqueResC.SelectCommand.Parameters["@Prueba"].Value = true;
                sqlDAInfTabiqueResC.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
                sqlDAInfTabiqueResC.Fill(dsInfTabN1, "TabRepN1");
                sqlDAInfTabiqueResC.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDAInfTabiqueResC.SelectCommand.Parameters["@Folio1"].Value = dsInfTabN1.Tables["TabRepN"].Rows[m][0].ToString();
                sqlDAInfTabiqueResC.SelectCommand.Parameters["@Prueba"].Value = false;
                sqlDAInfTabiqueResC.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
                sqlDAInfTabiqueResC.Fill(dsInfTabN1, "TabRepN11");
            }
            dsFirmas1.Clear();
            sqlDAFirmas.Fill(dsFirmas1, "Firmas");
            sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = 4;
            sqlDANorma.Fill(dsInfTabN1, "Normas");
            cryRepTabN1.SetDataSource(dsInfTabN1);
            cryRepTabN1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
            cryRepTabN1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
            cryRepTabN1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
            cryRepTabN1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
            cryRepTabN1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
            cryRepTabN1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
            cryRepTabN1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
            cryRepTabN1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
            cryRepTabN1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
            cryRepTabN1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
            cryRepTabN1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
            cryRepTabN1.SetParameterValue("@Lab", chbLab.Checked);
            cryRepTabN1.SetParameterValue("@Ineco", chbLab1.Checked);
            cryRepTabN1.SetParameterValue("@Unidad", dsUnidad1.Tables[0].Rows[cmbUnidad.SelectedIndex][1].ToString(), "Compresion");
            string conversion = (cmbUnidad.SelectedValue.ToString() == "2" ? "* Para convertir a kg/cm² multiplique por 10,19716" : "* Para convertir en Mpa multiplique por 0,0980665");
            cryRepTabN1.SetParameterValue("@Conversion", conversion);
            cryRepTabN1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
            decimal convertir = decimal.Parse(dsUnidad1.Unidad.Rows[cmbUnidad.SelectedIndex][2].ToString());
            cryRepTabN1.SetParameterValue("@Convertir", convertir);
            cryRepTabN1.SetParameterValue("@Convertir", convertir, "Compresion");
            cryRepTabN1.SetParameterValue("@Respaldo", chbRespaldo.Checked);

            crvInfTabique.ReportSource = cryRepTabN1;
        }

        private void btnVistaPrevia_Load(object sender, EventArgs e)
        {

        }
        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            if (dsTabMdor1.Tables["TabiqueMdor"].Rows.Count > 0)
            {
                txtFolio.Text = dsTabMdor1.Tables["TabiqueMdor"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
                btnVistaPrevia.Visible = true;
            }
            else
            {
                btnVistaPrevia.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
