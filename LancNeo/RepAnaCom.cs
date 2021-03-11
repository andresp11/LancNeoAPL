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
    public partial class RepAnaCom : Form
    {
        public RepAnaCom()
        {
            InitializeComponent();
        }

        private void RepAnaCom_Load(object sender, EventArgs e)
        {
            DataColumn[] Llave = new DataColumn[1];
            Object[] Matriz = new Object[6];
            Llave[0] = dsBuscaObra1.Tables["Obra"].Columns["IdObra"];
            Matriz[0] = "Todas";
            Matriz[1] = "Todas";
            Matriz[2] = "Todas";
            Matriz[3] = "Todas";
            Matriz[4] = "Todas";
            Matriz[5] = "Todas";
            dsBuscaObra1.Tables["Obra"].BeginLoadData();
            dsBuscaObra1.Tables["Obra"].LoadDataRow(Matriz, true);
            dsBuscaObra1.Tables["Obra"].EndLoadData();
            sqlDABusObra.Fill(dsBuscaObra1, "Obra");
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dsAnaCompac1.Clear();
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            buscaBtn1.Visible = true;
            dsAnaCompac1.CompactaMdor.AddCompactaMdorRow("Todas","Todas");
            sqlDACompac.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text); ;
            sqlDACompac.Fill(dsAnaCompac1, "CompactaMdor");
            cbkPrefijo.Checked = true;
            dsAnaCapa1.Clear();
            dsAnaCapa1.CompactaMdor.AddCompactaMdorRow("Todas");
            sqlDACapa.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text); ;
            sqlDACapa.Fill(dsAnaCapa1, "CompactaMdor");
            dsAnaReque1.Clear();
//            dsAnaReque1.CompactaMdor.AddCompactaMdorRow(-1);
            sqlDARequer.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text); ;
            sqlDARequer.Fill(dsAnaReque1, "CompactaMdor");
            buscaBtn1.Visible = true;
        }

        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            btnVistaPrevia.Visible = true;
            cmbCapa.SelectedIndex = buscaBtn1.RegistroSeleccionado;
            double increm = double.Parse(cmbRequerido.SelectedValue.ToString());
            increm = (increm > 0 ? (200 / increm) : 200 / 90);
            txtIncrem.Text = increm.ToString();
        }
        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            crvRepAnalisis.Visible = true;
            cryRepAnaCompacta1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cryRepAnaCompacta1.SetDataSource(dsAnaCompacta1);

            double incremento = float.Parse(txtIncrem.Text);
            int dias;
            incremento = (incremento > 19 || incremento < 0 ? 0.1 : incremento / 100);

            try
            {
                dsAnaCompacta1.Clear();
                sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value = (txtIdobra.Text == "Todas" ? "%" : txtIdobra.Text);
                sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                sqlDAAnalisis.SelectCommand.Parameters["@Capa"].Value = (cmbCapa.SelectedValue.ToString() == "Todas" ? "%" : cmbCapa.SelectedValue.ToString());
                sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 1;
                sqlDAAnalisis.SelectCommand.Parameters["@Increm"].Value = incremento; 
                sqlDAAnalisis.SelectCommand.Parameters["@Requerido"].Value = cmbRequerido.SelectedValue;
                sqlDAAnalisis.Fill(dsAnaCompacta1, "Analisis");
                sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 2;
                sqlDAAnalisis.Fill(dsAnaCompacta1, "Grafica1");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "Grafica1");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "Grafica1");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "Grafica1");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "Grafica1");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "Grafica1");
                sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 3;
                sqlDAAnalisis.Fill(dsAnaCompacta1, "GraficaFinal");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "GraficaFinal");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "GraficaFinal");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "GraficaFinal");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "GraficaFinal");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "GraficaFinal");
                sqlDAAnalisis.Fill(dsAnaCompacta1, "GraficaFinal");

                dias = dsAnaCompacta1.Analisis.Rows.Count;
                dias = dsAnaCompacta1.Grafica1.Rows.Count;
                dias = dsAnaCompacta1.GraficaFinal.Rows.Count;
                float[] gaus;
                gaus = new float[24];
                float[] ee;
                ee = new float[24];
                float[] nuevoee;
                nuevoee = new float[24];
                float moda = 0;
                int indice = 1;
                for (int i = 1; i <= 12; i++)
                {
                    nuevoee[i] = 0;
                    ee[i] = float.Parse(dsAnaCompacta1.Tables["GraficaFinal"].Rows[0][i].ToString());
                    if (moda < ee[i])
                    {
                        indice = i;
                        moda = ee[i];
                    }
                }
                indice = 6;
                for (int i = 1; i <= 6; i++)
                    if (1 <= (i - (6 - indice)) && (i - (6 - indice)) <= 13)
                        nuevoee[(i - (6 - indice))] = gaus[i] * (moda + 2);

                sqlDATitulo.SelectCommand.Parameters["@ResistenciaKg"].Value = (float.Parse(cmbRequerido.SelectedValue.ToString()) == -1 ? 95 : cmbRequerido.SelectedValue);
                sqlDATitulo.SelectCommand.Parameters["@IdUnidad"].Value = 1;
                sqlDATitulo.SelectCommand.Parameters["@Hoja"].Value = int.Parse(dsAnaCompacta1.Tables["GraficaFinal"].Rows[0][13].ToString());
                sqlDATitulo.SelectCommand.Parameters["@Incre"].Value = incremento;
                sqlDATitulo.Fill(dsAnaCompacta1, "Titulo");

                // Establece el valor actual de parameter1 en el subinforme en 10 
                    cryRepAnaCompacta1.SetParameterValue("@Unidad", "%");
                    cryRepAnaCompacta1.SetParameterValue("@Res", (cmbRequerido.SelectedValue.ToString()) == "-1" ? 100 : cmbRequerido.SelectedValue);
                    cryRepAnaCompacta1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                    cryRepAnaCompacta1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                    cryRepAnaCompacta1.SetParameterValue("@Obr", txtIdobra.Text);
                    cryRepAnaCompacta1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                    cryRepAnaCompacta1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                    cryRepAnaCompacta1.SetParameterValue("@reskg", (cmbRequerido.SelectedValue.ToString() == "-1" ? 100 : cmbRequerido.SelectedValue), "Gauss");
                    cryRepAnaCompacta1.SetParameterValue("@Unidad", "%", "Gauss");
                    cryRepAnaCompacta1.SetParameterValue("@Equi", 1);
                    cryRepAnaCompacta1.SetParameterValue("@Prueba", "Compactación");
                    cryRepAnaCompacta1.SetParameterValue("@Indice", txtResIndice.Text);
                    cryRepAnaCompacta1.SetParameterValue("@Como", "Compactación");
                    crvRepAnalisis.ReportSource = cryRepAnaCompacta1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRequerido_SelectedIndexChanged(object sender, EventArgs e)
        {
            double increm = double.Parse(cmbRequerido.SelectedValue.ToString());
            increm = (increm > 0 ? (200 / increm) : 200 / 90);
            txtIncrem.Text = increm.ToString();

        }


    }
}
