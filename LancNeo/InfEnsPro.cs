using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data;
using System.Data.SqlClient;

namespace LancNeo
{
    public partial class InfEnsPro : Form
    {
        public InfEnsPro()
        {
            InitializeComponent();
        }

        private void InfEnsPro_Load(object sender, EventArgs e)
        {
            sqlDALaboratorio.Fill(dsLaboratorio1, "Laboratorio");
            cmbLaboratorio.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            try
            {
                crvRepMuestreador.Visible = true;
                dsEspProInf1.Clear();

                cryRepEnsayeProbeta1.SetDataSource(dsEspProInf1);
                sqlDAMuestra.SelectCommand.Parameters["@IdLaboratorio"].Value = cmbLaboratorio.SelectedValue;
                sqlDAMuestra.SelectCommand.Parameters["@Fensaye"].Value = dtpFecha.Text;
                sqlDAMuestra.SelectCommand.Parameters["@Dia"].Value = txtDia.Text;
                sqlDAMuestra.SelectCommand.Parameters["@TR"].Value = (rBAmbos.Checked == true ? 1 : (rBConcreto.Checked == true ? 2 : 3)); 
                sqlDAMuestra.Fill(dsEspProInf1, "Muestras");
                DataSet _tmp = new DataSet();
                DataTable _dt = dsEspProInf1.Tables["Muestras"].Clone();
                _tmp.Tables.Add(_dt);
                int cuantos = dsEspProInf1.Muestras.Rows.Count;
                int c = cuantos -1 ;
                _tmp.Tables[0].ImportRow(dsEspProInf1.Tables["Muestras"].Rows[c]);
                _tmp.Tables[0].Rows[0]["Unico"] = -1;
                _tmp.Tables[0].Rows[0]["IdEnsaye"] = 0; 
                cuantos = ((cuantos / 42 + 1) * 42) - (c + 1);
                int hojas = 1;
                double residuo, cociente;
                for (int i = 0; i < cuantos; i++)
                {
                    cociente = i;
                    residuo = (cociente + 1) / 42;
                    if (residuo == 0)
                        hojas = hojas + 1;
                    dsEspProInf1.Hojas.AddHojasRow(hojas, i + 1);
                    dsEspProInf1.Muestras.ImportRow(_tmp.Tables[0].Rows[0]);

                }



                cryRepEnsayeProbeta1.SetParameterValue("Fecha", dtpFecha.Text);
                cryRepEnsayeProbeta1.SetParameterValue("Laboratorio", cmbLaboratorio.SelectedValue.ToString());

                crvRepMuestreador.ReportSource = cryRepEnsayeProbeta1;
                //crvRepMuestreador.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVistaPrevia_Load(object sender, EventArgs e)
        {

        }

    }
}
