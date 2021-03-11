using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ZedGraph;
using System.IO;

namespace LancNeo
{
    public partial class InfMexDis : Form
    {
        private DBGraphics memGraphics;
        private DBGraphics memGraphics1;
        protected GraphPane myPane;
        protected GraphPane myPane1;
        
        public InfMexDis()
        {
            InitializeComponent();
            memGraphics = new DBGraphics();
            memGraphics1 = new DBGraphics();
        }

        private void InfMexDis_Load(object sender, EventArgs e)
        {
            // sqlDABusObra.Fill(dsBuscaObra1, "Obra");
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");
            cmbUnidad.SelectedIndex = 0;
            sqlDATipo.Fill(dsTipo1, "Tipo");
            cmbTipo.SelectedIndex = 0;
            dsConcretera1.Concretera.AddConcreteraRow("Todas", "Todas", "%");
            sqlDAConcretera.Fill(dsConcretera1, "Concretera");
            cmbConcretera.SelectedIndex = 0;
            dsPlanta1.Planta.AddPlantaRow(-1, "Todas", (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString()));
            sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue);
            sqlDAPLanta.Fill(dsPlanta1, "Planta");
        }

        private void dtpIni_ValueChanged(object sender, EventArgs e)
        {
            dtpFin.Value = dtpIni.Value.AddDays(33);
        }

        private void textBox4_TextChanged(object sender, System.EventArgs e)
        {
            txtLan1507.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox4.Text));
            txtLan2007.Text = textBox4.Text;
            txtLan2507.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox4.Text));
            txtLan3007.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox4.Text));
        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {
            txtLan1503.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox3.Text));
            txtLan2003.Text = textBox3.Text;
            txtLan2503.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox3.Text));
            txtLan3003.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox3.Text));
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {
            txtLan1501.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox2.Text));
            txtLan2001.Text = textBox2.Text;
            txtLan2501.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox2.Text));
            txtLan3001.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox2.Text));
        }

        private void txtResis1_TextChanged(object sender, System.EventArgs e)
        {
            txtLan15EE.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text));
            txtLan1507.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox4.Text));
            txtLan1503.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox3.Text));
            txtLan1501.Text = System.Convert.ToString(200 - int.Parse(txtResis1.Text) + int.Parse(textBox2.Text));
        }

        private void txtResis3_TextChanged(object sender, System.EventArgs e)
        {
            txtLan25EE.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text));
            txtLan2507.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox4.Text));
            txtLan2503.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox3.Text));
            txtLan2501.Text = System.Convert.ToString(200 - int.Parse(txtResis3.Text) + int.Parse(textBox2.Text));
        }

        private void txtResis4_TextChanged(object sender, System.EventArgs e)
        {
            txtLan30EE.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text));
            txtLan3007.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox4.Text));
            txtLan3003.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox3.Text));
            txtLan3001.Text = System.Convert.ToString(200 - int.Parse(txtResis4.Text) + int.Parse(textBox2.Text));
        }

        private void cmbConcretera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlanta.Enabled = true;
            dsPlanta1.Clear();
            dsPlanta1.Planta.AddPlantaRow(-1, "Todas", (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString()));
            sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue);
            sqlDAPLanta.Fill(dsPlanta1, "Planta");
        }
        private void SetSize()
        {
            Rectangle paneRect = this.ClientRectangle;
            paneRect.Inflate(-2, -1);
            this.myPane.PaneRect = paneRect;
        }
        private void SetSize1()
        {
            Rectangle paneRect = this.ClientRectangle;
            paneRect.Inflate(-2, -1);
            this.myPane1.PaneRect = paneRect;
        }
        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            double[,] datos = new double[45, 36];
            double[,] media = new double[5, 35];
            double[] ua = new double[30];
            double[] va = new double[30];
            double[] xa = new double[30];
            double[] ya = new double[30];
            double[] wa = new double[30];
            double[] za = new double[30];
            double[] xaa = new double[2];
            double[] C200 = new double[2];
            double min = 0;
            double max = 330;
            int[] ren = new int[45];
            int[] dic = new int[30];
            int col, d1, d2, renm, dia, ren28, ren07, ren03, ren01;
            string Etiqueta = " Edad", Titulo;
            double suma;
            dsDatos1.Clear();
            dsGraDis1.Clear();


 /*           if (chbTodas.Checked == false)
            {

                cryInfGrDiCo1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryInfGrDiCo1.SetDataSource(dsGraDis1);

                sqlDADatos.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
                sqlDADatos.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                sqlDADatos.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                sqlDADatos.SelectCommand.Parameters["@TipoCon"].Value = cmbTipo.SelectedValue;
                sqlDADatos.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
                sqlDADatos.SelectCommand.Parameters["@Resis1"].Value = txtResis1.Text;
                sqlDADatos.SelectCommand.Parameters["@Resis2"].Value = txtResis2.Text;
                sqlDADatos.SelectCommand.Parameters["@Resis3"].Value = txtResis3.Text;
                sqlDADatos.SelectCommand.Parameters["@Resis4"].Value = txtResis4.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan15EE"].Value = txtLan15EE.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan20EE"].Value = txtLan20EE.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan25EE"].Value = txtLan25EE.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan30EE"].Value = txtLan30EE.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan1507"].Value = txtLan1507.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan2007"].Value = txtLan2007.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan2507"].Value = txtLan2507.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan3007"].Value = txtLan3007.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan1503"].Value = txtLan1503.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan2003"].Value = txtLan2003.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan2503"].Value = txtLan2503.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan3003"].Value = txtLan3003.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan1501"].Value = txtLan1501.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan2001"].Value = txtLan2001.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan2501"].Value = txtLan2501.Text;
                sqlDADatos.SelectCommand.Parameters["@Lan3001"].Value = txtLan3001.Text;
                sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 0;
                sqlDADatos.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue);
                sqlDADatos.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
                sqlDADatos.Fill(dsDatos1, "InfDistribucion");
                sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 1;
                sqlDADatos.Fill(dsDatos1, "Total");
                sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 2;
                sqlDADatos.Fill(dsDatos1, "Media");
                sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 3;
                sqlDADatos.Fill(dsDatos1, "Erre");
                sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 4;
                sqlDADatos.Fill(dsDatos1, "Semanal");
                sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 5;
                sqlDADatos.Fill(dsGraDis1, "Estadisticos");
                sqlDADatos.SelectCommand.Parameters["@IdReporte"].Value = 6;
                sqlDADatos.Fill(dsDatos1, "Barra");
            }
            else
            {*/

                cryInfGrDiCo1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                cryInfGrDiCo1.SetDataSource(dsGraDis1);

                sqlDADatosT.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
                sqlDADatosT.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                sqlDADatosT.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                sqlDADatosT.SelectCommand.Parameters["@TipoCon"].Value = cmbTipo.SelectedValue;
                sqlDADatosT.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
                sqlDADatosT.SelectCommand.Parameters["@Inc7aEE"].Value = textBox4.Text;
                sqlDADatosT.SelectCommand.Parameters["@Inc3aEE"].Value = textBox3.Text;
                sqlDADatosT.SelectCommand.Parameters["@Inc1aEE"].Value = textBox2.Text;
                sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 0;
                sqlDADatosT.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue);
                sqlDADatosT.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
                sqlDADatosT.Fill(dsDatos1, "InfDistribucion");
                sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 1;
                sqlDADatosT.Fill(dsDatos1, "Total");
                sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 2;
                sqlDADatosT.Fill(dsDatos1, "Media");
                sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 3;
                sqlDADatosT.Fill(dsDatos1, "Erre");
                sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 4;
                sqlDADatosT.Fill(dsDatos1, "Semanal");
                sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 5;
                sqlDADatosT.Fill(dsGraDis1, "Estadisticos");
                sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 6;
                sqlDADatosT.Fill(dsDatos1, "Barra");
            //}
            int renDatos = dsDatos1.InfDistribucion.Rows.Count;
            col = renm = ren28 = ren07 = ren03 = ren01 = 0;
            int d1ant = int.Parse(dsDatos1.InfDistribucion.Rows[0]["d1"].ToString());
            for (int i = 0; i < 45; i++)
                ren[i] = 0;
            for (int i = 0; i < renDatos; i++)
            {
                d1 = int.Parse(dsDatos1.InfDistribucion.Rows[i]["d1"].ToString());
                if (d1 == d1ant)
                {
                    dia = int.Parse(dsDatos1.InfDistribucion.Rows[i]["Dia"].ToString());
                    if (dia > 6 && dia < 14)
                        dia = dia - 1;
                    else if (dia > 13 && dia < 21)
                        dia = dia - 2;
                    else if (dia > 20 && dia < 28)
                        dia = dia - 3;
                    else if (dia > 27 && dia < 35)
                        dia = dia - 4;
                    datos[ren[dia], 35] = d1;
                    datos[ren[dia]++, dia] = double.Parse(dsDatos1.InfDistribucion.Rows[i]["Resul"].ToString());
                }
                else
                {
                    renm = ren[0];
                    for (int j = 0; j < 35; j++)
                        if (renm < ren[j])
                            renm = ren[j];
                    datos[renm, 35] = d1ant;
                    ren28 = (d1ant >= 14 ? renm : ren28);
                    ren07 = (d1ant == 07 ? renm : ren07);
                    ren03 = (d1ant == 03 ? renm : ren03);
                    ren01 = (d1ant == 01 ? renm : ren01);
                    renm = renm + 4;
                    for (int j = 0; j < 35; j++)
                        ren[j] = renm;
                    d1ant = d1;
                    dia = int.Parse(dsDatos1.InfDistribucion.Rows[i]["Dia"].ToString());
                    if (dia > 6 && dia < 14)
                        dia = dia - 1;
                    else if (dia > 13 && dia < 21)
                        dia = dia - 2;
                    else if (dia > 20 && dia < 28)
                        dia = dia - 3;
                    else if (dia > 27 && dia < 35)
                        dia = dia - 4;
                    datos[ren[dia], 35] = d1;
                    datos[ren[dia]++, dia] = double.Parse(dsDatos1.InfDistribucion.Rows[i]["Resul"].ToString());
                }
                renm = ren[0];
                for (int j = 0; j < 35; j++)
                    if (renm < ren[j])
                        renm = ren[j];
                datos[renm, 35] = d1ant;
                ren28 = (d1ant >= 14 ? renm : ren28);
                ren07 = (d1ant == 07 ? renm : ren07);
                ren03 = (d1ant == 03 ? renm : ren03);
                ren01 = (d1ant == 01 ? renm : ren01);
            }
            
            renDatos = dsDatos1.Media.Rows.Count;
            for (int i = 0; i < renDatos; i++)
            {
                d2 = d1 = int.Parse(dsDatos1.Media.Rows[i]["d1"].ToString());
                if (d1 >= 14)
                    d1 = ren28;
                else if (d1 == 07)
                    d1 = ren07;
                else if (d1 == 03)
                    d1 = ren03;
                else if (d1 == 01)
                    d1 = ren01;
                dia = int.Parse(dsDatos1.Media.Rows[i]["Dia"].ToString());
                if (dia > 6 && dia < 14)
                    dia = dia - 1;
                else if (dia > 13 && dia < 21)
                    dia = dia - 2;
                else if (dia > 20 && dia < 28)
                    dia = dia - 3;
                else if (dia > 27 && dia < 35)
                    dia = dia - 4;
                datos[d1 + 1, 35] = d2;
                datos[d1 + 1, dia] = double.Parse(dsDatos1.Media.Rows[i]["Resul"].ToString());
            }
            ren01 = (ren01 == 0 ? 40 : ren01);
            renDatos = dsDatos1.Semanal.Rows.Count;
            for (int i = 0; i < renDatos; i++)
            {
                d2 = d1 = int.Parse(dsDatos1.Semanal.Rows[i]["d1"].ToString());
                if (d1 >= 14)
                    d1 = ren28;
                else if (d1 == 07)
                    d1 = ren07;
                else if (d1 == 03)
                    d1 = ren03;
                else if (d1 == 01)
                    d1 = ren01;
                dia = int.Parse(dsDatos1.Semanal.Rows[i]["Dia"].ToString());
                if (dia <= 6)
                    dia = 5;
                else if (dia > 6 && dia < 14)
                    dia = 11;
                else if (dia > 13 && dia < 21)
                    dia = 17;
                else if (dia > 20 && dia < 28)
                    dia = 23;
                else if (dia > 27 && dia < 35)
                    dia = 29;
                datos[d1 + 2, 35] = d2;
                datos[d1 + 2, dia] = double.Parse(dsDatos1.Semanal.Rows[i]["Resul"].ToString());
            }
            renDatos = dsDatos1.Erre.Rows.Count;
            for (int i = 0; i < renDatos; i++)
            {
                d2 = d1 = int.Parse(dsDatos1.Erre.Rows[i]["d1"].ToString());
                if (d1 >= 14)
                    d1 = ren28;
                else if (d1 == 07)
                    d1 = ren07;
                else if (d1 == 03)
                    d1 = ren03;
                else if (d1 == 01)
                    d1 = ren01;
                dia = int.Parse(dsDatos1.Erre.Rows[i]["Dia"].ToString());
                if (dia > 6 && dia < 14)
                    dia = dia - 1;
                else if (dia > 13 && dia < 21)
                    dia = dia - 2;
                else if (dia > 20 && dia < 28)
                    dia = dia - 3;
                else if (dia > 27 && dia < 35)
                    dia = dia - 4;
                datos[d1 + 3, 35] = d2;
                datos[d1 + 3, dia] = double.Parse(dsDatos1.Erre.Rows[i]["Resul"].ToString());
            }
            for (int i = 0; i < 34; i++)
            {
                suma = 0;
                for (int j = 0; j < 34; j++)
                    suma = suma + datos[i, j];
                if (datos[i, 35] >= 14)
                    Etiqueta = "Edad especificada";
                else if (datos[i, 35] == 7)
                    Etiqueta = "7 días";
                else if (datos[i, 35] == 3)
                    Etiqueta = "3 días";
                else if (datos[i, 35] == 1)
                    Etiqueta = "1 día";
                Titulo = "n"; // System.Convert.ToString(i + 1);
                if (suma > 0)
                {
                    //					if (i == (ren28 == 0 ? 90 : ren28) + 1 || i == ren07 + 1 || i == ren03 + 1 || i == ren01 + 1)
                    //						Titulo = "TOTAL";
                    if (i == (ren28 == 0 ? 90 : ren28) + 1 || i == ren07 + 1 || i == ren03 + 1 || i == ren01 + 1)
                        Titulo = "Media";
                    if (i == (ren28 == 0 ? 90 : ren28) + 2 || i == ren07 + 2 || i == ren03 + 2 || i == ren01 + 2)
                        Titulo = "Media Semanal";
                    if (i == (ren28 == 0 ? 90 : ren28) + 3 || i == ren07 + 3 || i == ren03 + 3 || i == ren01 + 3)
                        Titulo = "R";
                    dsGraDis1.Gradis.AddGradisRow(i.ToString(), datos[i, 0], datos[i, 1], datos[i, 2], datos[i, 3],
                    datos[i, 4], datos[i, 5], datos[i, 6], datos[i, 7], datos[i, 8], datos[i, 9], datos[i, 10], datos[i, 11],
                    datos[i, 12], datos[i, 13], datos[i, 14], datos[i, 15], datos[i, 16], datos[i, 17], datos[i, 18], datos[i, 19],
                    datos[i, 20], datos[i, 21], datos[i, 22], datos[i, 23], datos[i, 24], datos[i, 25], datos[i, 26], datos[i, 27],
                    datos[i, 28], datos[i, 29], datos[i, 30], Etiqueta.Trim(), Titulo);
                    if (i == ren28 + 1 && ren28 != 0)
                        for (int j = 0; j < 30; j++)
                            ua[j] = datos[i, j];
                    if (i == ren07 + 1 && ren07 != 0)
                        for (int j = 0; j < 30; j++)
                            va[j] = datos[i, j];
                    if (i == ren07 + 3 && ren07 != 0)
                        for (int j = 0; j < 30; j++)
                            za[j] = datos[i, j];
                    if (i == ren03 + 1 && ren03 != 0)
                        for (int j = 0; j < 30; j++)
                            wa[j] = datos[i, j];
                    if (i == ren01 + 1 && ren01 != 0)
                        for (int j = 0; j < 30; j++)
                            ya[j] = datos[i, j];
                }

            }
            DateTime dias = dtpIni.Value;
            int dmes = 0;
            for (int i = 0; i < 35; i++)
                if (dias.AddDays(i).DayOfWeek.ToString() != DayOfWeek.Sunday.ToString())
                    dic[dmes++] = dias.AddDays(i).Day;
            dsGraDis1.Dias.AddDiasRow(dic[0], dic[1], dic[2], dic[3],
                dic[4], dic[5], dic[6], dic[7], dic[8], dic[9], dic[10], dic[11],
                dic[12], dic[13], dic[14], dic[15], dic[16], dic[17], dic[18], dic[19],
                dic[20], dic[21], dic[22], dic[23], dic[24], dic[25], dic[26], dic[27],
                dic[28], dic[29]);

            memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
                this.ClientRectangle.Width, this.ClientRectangle.Height);

            myPane = new GraphPane(new Rectangle(10, 10, 10, 10),
                "CARTA DE CONTROL Y DISTRIBUCIÓN DE FRECUENCIAS", "", "");
            SetSize();

            for (int j = 0; j < 30; j++)
                xa[j] = j + 1;

            CurveItem curve;
            curve = myPane.AddCurve("E. E:", xa, ua, Color.Black, SymbolType.Circle);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.Black);
            for (int j = 29; j >= 0; j--)
                if (ua[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("7 días", xa, va, Color.Blue, SymbolType.Circle);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.White);
            for (int j = 29; j >= 0; j--)
                if (va[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("3 días", xa, wa, Color.Brown, SymbolType.Square);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.Red);
            for (int j = 29; j >= 0; j--)
                if (wa[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("1 día", xa, ya, Color.DarkRed, SymbolType.Square);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.Size = 8;
            for (int j = 29; j >= 0; j--)
                if (ya[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("R", xa, za, Color.DarkMagenta, SymbolType.Star);
            curve.Line.Width = 1.0F;
            curve.Symbol.Fill = new Fill(Color.DarkMagenta);
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
            curve.IsY2Axis = true;
            for (int j = 29; j >= 0; j--)
                if (za[j] == 0)
                    curve.Points.Remove(j);
            //			curve.Line.IsSmooth = true;
            xaa[0] = 0;
            xaa[1] = 30;
            C200[0] = 200;
            C200[1] = 200;
            curve = myPane.AddCurve("C200", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 2.5F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            C200[0] = 230;
            C200[1] = 230;
            curve = myPane.AddCurve("C230", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            C200[0] = 260;
            C200[1] = 260;
            curve = myPane.AddCurve("C260", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            C200[0] = 40;
            C200[1] = 40;
            curve = myPane.AddCurve("C040", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 1.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            curve.IsY2Axis = true;
            xaa[0] = 6.5;
            xaa[1] = 6.5;
            C200[0] = 100;
            C200[1] = 300;
            curve = myPane.AddCurve("C6.5", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 4.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            xaa[0] = 12.5;
            xaa[1] = 12.5;
            C200[0] = 100;
            C200[1] = 300;
            curve = myPane.AddCurve("C13.5", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 4.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            xaa[0] = 18.5;
            xaa[1] = 18.5;
            C200[0] = 100;
            C200[1] = 300;
            curve = myPane.AddCurve("C20.5", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 4.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            xaa[0] = 24.5;
            xaa[1] = 24.5;
            C200[0] = 100;
            C200[1] = 300;
            curve = myPane.AddCurve("C13.5", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 4.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;


            myPane.Y2Axis.IsShowGrid = true;
            myPane.Y2Axis.Step = 10;
            myPane.Y2Axis.Min = min;
            myPane.Y2Axis.Max = 200;
            myPane.Y2Axis.IsVisible = true;
            myPane.Y2Axis.ScaleFontSpec.Size = 6;
            myPane.XAxis.IsShowGrid = true;
            myPane.XAxis.IsTic = true;
            myPane.XAxis.ScaleFontSpec.Angle = 0;
            myPane.XAxis.Min = 0;
            myPane.XAxis.Max = 30;
            myPane.XAxis.IsVisible = false;
            myPane.YAxis.IsShowGrid = true;
            myPane.YAxis.ScaleFontSpec.Angle = 90;
            myPane.YAxis.Min = 100;
            myPane.YAxis.Max = 300;

            //			myPane.YAxis.MaxAuto = true;
            myPane.Legend.IsVisible = false;
            myPane.PaneFill = new Fill(Color.White, Color.White, 0F);

            myPane.AxisChange(this.CreateGraphics());
            pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] arrImage = ms.GetBuffer();
            ms.Close();

            myPane.Image.Dispose();
            pictureBox1.Image.Dispose();
            dsGraDis1.Grafica.AddGraficaRow(arrImage);

            memGraphics1.CreateDoubleBuffer(this.CreateGraphics(),
                this.ClientRectangle.Width, this.ClientRectangle.Height);

            myPane1 = new GraphPane(new Rectangle(10, 10, 10, 10),
                " ", "", "");
            SetSize1();

            renDatos = dsDatos1.Barra.Rows.Count;
            double[] xxa = new double[renDatos];
            double[] yya = new double[renDatos];
            for (int i = 0; i < renDatos; i++)
            {
                xxa[i] = double.Parse(dsDatos1.Barra.Rows[i][0].ToString());
                yya[i] = double.Parse(dsDatos1.Barra.Rows[i][1].ToString());
            }

            CurveItem curve1;
            curve1 = myPane1.AddBar("Cantidad", yya, xxa, Color.Black);
            curve1.Bar.FrameWidth = 12.0F;
            curve1.Symbol.Fill = new Fill(Color.Black);

            myPane1.BarBase = BarBase.Y;
            myPane1.XAxis.IsShowGrid = true;
            myPane1.XAxis.ScaleFontSpec.Angle = 0;
            myPane1.XAxis.Min = 0;
            myPane1.XAxis.Max = 30;
            myPane1.XAxis.MaxAuto = true;
            myPane1.XAxis.ScaleFontSpec.Size = 30;
            myPane1.XAxis.IsVisible = false;
            myPane1.XAxis.IsShowGrid = true;
            myPane1.YAxis.IsShowGrid = true;
            myPane1.YAxis.ScaleFontSpec.Angle = 90;
            myPane1.YAxis.Min = 100;
            myPane1.YAxis.Max = 300;
            //			myPane1.YAxis.MaxAuto = true;
            myPane1.YAxis.IsVisible = false;
            myPane1.Legend.IsVisible = false;
            //			myPane.YAxis.ScaleFontSpec.Size = 10;
            myPane1.PaneFill = new Fill(Color.White, Color.White, 0F);

            myPane1.AxisChange(this.CreateGraphics());
            pictureBox2.Image = Image.FromHbitmap(myPane1.Image.GetHbitmap());
            pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            MemoryStream ms1 = new MemoryStream();
            pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] arrImage1 = ms1.GetBuffer();
            ms1.Close();

            myPane1.Image.Dispose();
            pictureBox2.Image.Dispose();
            dsGraDis1.Barras.AddBarrasRow(arrImage1);


            crvGraDis.Visible = true;
            cryInfGrDiCo1.SetParameterValue("@Tip", dsTipo1.Tables[0].Rows[cmbTipo.SelectedIndex][1].ToString());
            cryInfGrDiCo1.SetParameterValue("@Rev", 0);
            cryInfGrDiCo1.SetParameterValue("@Fecha", dtpIni.Value.AddDays(20));
            cryInfGrDiCo1.SetParameterValue("@Resistencias", txtResis1.Text.Trim() + " " + txtResis2.Text.Trim() + " " + txtResis3.Text.Trim() + " " + txtResis4.Text.Trim());
            cryInfGrDiCo1.SetParameterValue("@Resis1", txtResis1.Text.Trim());
            cryInfGrDiCo1.SetParameterValue("@Resis2", txtResis2.Text.Trim());
            cryInfGrDiCo1.SetParameterValue("@Resis3", txtResis3.Text.Trim());
            cryInfGrDiCo1.SetParameterValue("@Resis4", txtResis4.Text.Trim());
            cryInfGrDiCo1.SetParameterValue("Inc15EE", txtLan15EE.Text);
            cryInfGrDiCo1.SetParameterValue("Inc1507", txtLan1507.Text);
            cryInfGrDiCo1.SetParameterValue("Inc1503", txtLan1503.Text);
            cryInfGrDiCo1.SetParameterValue("Inc1501", txtLan1501.Text);
            cryInfGrDiCo1.SetParameterValue("Inc20EE", txtLan20EE.Text);
            cryInfGrDiCo1.SetParameterValue("Inc2007", txtLan2007.Text);
            cryInfGrDiCo1.SetParameterValue("Inc2003", txtLan2003.Text);
            cryInfGrDiCo1.SetParameterValue("Inc2001", txtLan2001.Text);
            cryInfGrDiCo1.SetParameterValue("Inc25EE", txtLan25EE.Text);
            cryInfGrDiCo1.SetParameterValue("Inc2507", txtLan2507.Text);
            cryInfGrDiCo1.SetParameterValue("Inc2503", txtLan2503.Text);
            cryInfGrDiCo1.SetParameterValue("Inc2501", txtLan2501.Text);
            cryInfGrDiCo1.SetParameterValue("Inc30EE", txtLan30EE.Text);
            cryInfGrDiCo1.SetParameterValue("Inc3007", txtLan3007.Text);
            cryInfGrDiCo1.SetParameterValue("Inc3003", txtLan3003.Text);
            cryInfGrDiCo1.SetParameterValue("Inc3001", txtLan3001.Text);
            cryInfGrDiCo1.SetParameterValue("@Lab", chbLab.Checked);
            cryInfGrDiCo1.SetParameterValue("@Con", cmbConcretera.Text);
            cryInfGrDiCo1.SetParameterValue("@Pla", cmbPlanta.Text);
            cryInfGrDiCo1.SetParameterValue("@IdObra", txtIdobra.Text);



            crvGraDis.ReportSource = cryInfGrDiCo1;
            // crvGraDis.RefreshReport();
        }
    }
}
