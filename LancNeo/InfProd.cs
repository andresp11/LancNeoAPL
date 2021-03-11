using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Drawing2D;
using ZedGraph;
using System.IO;
using System.Text.RegularExpressions;
using CrystalDecisions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.Threading;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace LancNeo
{
    public partial class InfProd : Form
    {
        private DBGraphics memGraphics;
        public InfProd()
        {
            InitializeComponent();
            memGraphics = new DBGraphics();

        }
        protected GraphPane myPane;
        private void InfProd_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sqlDAGrupos.Fill(dsGrupos1, "Grupo");
            dtpIni.Value = DateTime.Now.AddDays(-7);
        }
        private void SetSize()
        {
            Rectangle paneRect = this.ClientRectangle;
            paneRect.Inflate(-2, -1);
            this.myPane.PaneRect = paneRect;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            crvInfProd.Visible = true;
            dsGrupos1.GraGrupos.Clear();
            dsGrupos1.GraPersonal.Clear();
            dsGrupos1.Vivienda.Clear();
            dsGrupos1.Grupos.Clear();
            dsGrupos1.Grafica.Clear();
            dsGrupos1.GraDuracionI.Clear();
            dsGrupos1.GraDuracionF.Clear();
            dsGrupos1.GraPromedio.Clear();
            dsGrupos1.GraDias.Clear();
            dsGraduracion1.Clear();


            int s = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(dtpIni.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            int a = dtpIni.Value.Year;
            s = (a == 2019 ? s + 1 : s);
            if (s == 53 && a != 2020)
            {
                s = 1;
                a = a + 1;
            }
            if (s > 53)
            {
                s = 1;
                a = a + 1;
            }
            

            sqlDASFestivo.SelectCommand.Parameters["@Año"].Value = a;
            sqlDASFestivo.SelectCommand.Parameters["@Si"].Value = s;
            sqlDASFestivo.SelectCommand.Parameters["@Sf"].Value = s + 25;
            sqlDASFestivo.Fill(dsSFestivo1, "SFestivo");


            cryGraGrupos1.SetDataSource(dsGrupos1);
            cryGraGrupos1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            sqlDAGrupo.SelectCommand.Parameters["@IdGrupo"].Value = cmbIdGrupo.SelectedValue;
            sqlDAGrupo.Fill(dsGrupos1, "Grupos");

            sqlDAGraGrupos.SelectCommand.Parameters["@IdGrupo"].Value = cmbIdGrupo.SelectedValue;
            sqlDAGraGrupos.SelectCommand.Parameters["@Mes"].Value = s;
            sqlDAGraGrupos.SelectCommand.Parameters["@Año"].Value = a;
            sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 1;
            sqlDAGraGrupos.Fill(dsGrupos1, "GraGrupos");
            sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 0;
            sqlDAGraGrupos.Fill(dsGrupos1, "GraPersonal");
            sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 2;
            sqlDAGraGrupos.Fill(dsGrupos1, "GraPromedio");
            sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 3;
            sqlDAGraGrupos.Fill(dsGrupos1, "GraDias");
            sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 4;
            sqlDAGraGrupos.Fill(dsGrupos1, "GraDias");
            sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 5;
            sqlDAGraGrupos.Fill(dsGrupos1, "GraDias");
            sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 6;
            sqlDAGraGrupos.Fill(dsGrupos1, "GraDias");
            sqlDAVivienda.SelectCommand.Parameters["@IdGrupo"].Value = cmbIdGrupo.SelectedValue;
            sqlDAVivienda.SelectCommand.Parameters["@Mes"].Value = s;
            sqlDAVivienda.SelectCommand.Parameters["@Año"].Value = a;
            sqlDAVivienda.Fill(dsGrupos1, "Vivienda");
            sqlDAVivIni.SelectCommand.Parameters["@IdGrupo"].Value = cmbIdGrupo.SelectedValue;
            sqlDAVivIni.SelectCommand.Parameters["@Mes"].Value = s;
            sqlDAVivIni.SelectCommand.Parameters["@Año"].Value = a;
            sqlDAVivIni.Fill(dsGrupos1, "Vivienda");
            sqlDADuracion.SelectCommand.Parameters["@IdGrupo"].Value = cmbIdGrupo.SelectedValue;
            sqlDADuracion.SelectCommand.Parameters["@Primero"].Value = 0;
            sqlDADuracion.Fill(dsGrupos1, "GraduracionI");
            sqlDADuracion.SelectCommand.Parameters["@IdGrupo"].Value = cmbIdGrupo.SelectedValue;
            sqlDADuracion.SelectCommand.Parameters["@Primero"].Value = 1;
            sqlDADuracion.Fill(dsGrupos1, "GraduracionF");
            sqlDADuracion.SelectCommand.Parameters["@IdGrupo"].Value = cmbIdGrupo.SelectedValue;
            sqlDADuracion.SelectCommand.Parameters["@Primero"].Value = 2;
            sqlDADuracion.Fill(dsGraduracion1, "GraduracionF");

            myPane = new GraphPane(new Rectangle(10, 10, 10, 10), " ", "", "");
            SetSize();
            CurveItem curve;
            double[] eex;
            eex = new double[26];
            double[] neey;
            neey = new double[26];

            for (int m = 0; m < dsGrupos1.GraGrupos.Rows.Count; m++)
            {
                for (int i = 0; i <= 25; i++)
                {
                    neey[i] = double.Parse(dsGrupos1.Tables["GraGrupos"].Rows[m][i + 1].ToString());
                    eex[i] = double.Parse((s + i).ToString());
                }
                if (m == 0)
                {
                    curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Maroon, SymbolType.Square);
                    curve.Symbol.Fill = new Fill(Color.Maroon);
                    curve.Line.Width = 2.5F;
                    for (int jj = 25; jj >= 0; jj--)
                        if (neey[jj] <= 0.01)
                            curve.Points.Remove(jj);
                        else
                            jj = -1;
                }
                if (m == 1)
                {
                    curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Green, SymbolType.Diamond);
                    curve.Symbol.Fill = new Fill(Color.Green);
                    curve.Line.Width = 2.5F;
                    //for (int jj = 25; jj >= 0; jj--)
                    //    if (neey[jj] <= 0.01)
                    //        curve.Points.Remove(jj);
                }
                if (m == 2)
                {
                    curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Olive, SymbolType.Circle);
                    curve.Line.Width = 3.5F;
                    curve.Symbol.Fill = new Fill(Color.Olive);
                    //for (int jj = 25; jj >= 0; jj--)
                    //    if (neey[jj] <= 0.01)
                    //        curve.Points.Remove(jj);
                }
                if (m == 3)
                {
                    curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Navy, SymbolType.TriangleDown);
                    curve.Symbol.Fill = new Fill(Color.Navy);
                    curve.Line.Width = 2.5F;
                    //for (int jj = 25; jj >= 0; jj--)
                    //    if (neey[jj] <= 0.01)
                    //        curve.Points.Remove(jj);
                }
                if (m == 4)
                {
                    curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Purple, SymbolType.TriangleDown);
                    curve.Symbol.Fill = new Fill(Color.Purple);
                    curve.Line.Width = 2.5F;
                    //for (int jj = 25; jj >= 0; jj--)
                    //    if (neey[jj] <= 0.01)
                    //        curve.Points.Remove(jj);
                }
            }

            float x1 = float.Parse(s.ToString());
            float y1 = 10;
            float size = 5;
            TextItem texe = new TextItem();
            ArrowItem arrow = new ArrowItem(Color.Red, size, x1, y1, x1 + 25, y1);
            arrow.CoordinateFrame = CoordType.AxisXYScale;
            arrow.PenWidth = 0F;
            myPane.ArrowList.Add(arrow);
            y1 = 10;
            arrow = new ArrowItem(Color.Red, size, x1, y1, x1 + 25, y1);
            arrow.CoordinateFrame = CoordType.AxisXYScale;
            arrow.PenWidth = 0F;
            myPane.ArrowList.Add(arrow);
            y1 = 15;
            arrow = new ArrowItem(Color.Red, size, x1, y1, x1 + 25, y1);
            arrow.CoordinateFrame = CoordType.AxisXYScale;
            arrow.PenWidth = 0F;
            myPane.ArrowList.Add(arrow);
            y1 = 20;
            arrow = new ArrowItem(Color.Red, size, x1, y1, x1 + 25, y1);
            arrow.CoordinateFrame = CoordType.AxisXYScale;
            arrow.PenWidth = 0F;
            myPane.ArrowList.Add(arrow);

            double año = a;
            int semIni = (a * 52) + s - 104936;
            int semFin = semIni + 25;
            for (int m = 0; m < dsGraduracion1.GraDuracionF.Rows.Count; m++)
            {
                int semana = int.Parse(dsGraduracion1.GraDuracionF.Rows[m][4].ToString());
                int años = int.Parse(dsGraduracion1.GraDuracionF.Rows[m][3].ToString());
                int vigencia = (años * 52) + semana - 104936;
                if (semIni <= vigencia && vigencia <= semFin)
                {
                    size = 3;
                    x1 = float.Parse((vigencia - semIni + 1).ToString());
                    y1 = 0;
                    arrow = new ArrowItem(Color.Violet, size, x1, y1, x1, y1 + 35);
                    arrow.CoordinateFrame = CoordType.AxisXYScale;
                    arrow.PenWidth = 5F;
                    myPane.ArrowList.Add(arrow);
                    texe = new TextItem(dsGraduracion1.GraDuracionF.Rows[m][1].ToString(), x1, 2);
                    texe.FontSpec.IsBold = false;
                    texe.FontSpec.Size = 8;
                    texe.FontSpec.Family = "Times New Roman";
                    myPane.TextList.Add(texe);
                }
            }


            guardagrafica(s);
            cryGraGrupos1.SetParameterValue("Grupo", "Laboratorio " + string.Format("{0:0.#}", dsGrupos1.Grupo.Rows[cmbIdGrupo.SelectedIndex][0]));
            cryGraGrupos1.SetParameterValue("Año", a);
            cryGraGrupos1.SetParameterValue("Semana", s);
            for (int i = 0; i < 26; i++)
            {
                if (s == 53 && a != 2020)
                {
                    s = 1;
                    a = a + 1;
                }
                if (s > 53)
                {
                    s = 1;
                    a = a + 1;
                }
                string param = "SFes" + i.ToString().Trim();
                int Sfes = 0;
                for (int j = 0; j < dsSFestivo1.SFestivo.Rows.Count; j++)
                    if (dsSFestivo1.SFestivo.Rows[j][0].ToString() == a.ToString() && dsSFestivo1.SFestivo.Rows[j][1].ToString() == s.ToString())
                        Sfes = 1;
                cryGraGrupos1.SetParameterValue(param, Sfes);
                s = s + 1;
            }
            crvInfProd.ReportSource = cryGraGrupos1;

        }
        private void guardagrafica(double S)
        {

            myPane.XAxis.IsMinorInsideTic = false;
            //myPane.XAxis.TicSize = 0;
            myPane.XAxis.IsShowGrid = true;
            myPane.XAxis.IsInsideTic = false;
            myPane.XAxis.IsOppositeTic = false;
            myPane.XAxis.IsMinorOppositeTic = false;
            myPane.XAxis.ScaleFontSpec.Angle = 0;
            myPane.XAxis.NumDec = 0;
            myPane.XAxis.IsTicsBetweenLabels = false;
            //            myPane.XAxis.Step = float.Parse((res * 0.1).ToString());
            myPane.XAxis.Min = S; //cambiar
            myPane.XAxis.Max = S + 25;
            myPane.XAxis.Type = AxisType.Linear;
            //            myPane.XAxis.StepAuto = true;
            myPane.XAxis.MinorStepAuto = false;
            myPane.XAxis.TitleFontSpec.Family = "Times New Roman";
            myPane.XAxis.TitleFontSpec.Size = 8;
            myPane.XAxis.ScaleFontSpec.Size = 8;
            myPane.XAxis.IsShowTitle = true;
            myPane.XAxis.ScaleFontSpec.FontColor = Color.Black;
            myPane.XAxis.IsMinorTic = false;
            myPane.XAxis.Title = "Semanas";
            myPane.XAxis.Step = 1;
            myPane.XAxis.IsVisible = false;
            //            myPane.YAxis.IsMinorInsideTic = true;
            //            myPane.XAxis.IsInsideTic = true;
            myPane.YAxis.IsShowGrid = false;
            myPane.YAxis.ScaleFontSpec.Angle = 90;
            myPane.YAxis.ScaleFontSpec.Size = 8;
            myPane.YAxis.Min = 0;
            myPane.YAxis.Max = 35;
            //myPane.YAxis.TicSize = 10;
            myPane.YAxis.TitleFontSpec.Family = "Times New Roman";
            myPane.YAxis.ScaleFontSpec.Family = "Times New Roman";
            myPane.YAxis.Title = "Servicios";
            myPane.Legend.IsVisible = true;
            myPane.Legend.Location = LegendLoc.InsideTopLeft;
            myPane.Legend.FontSpec.Size = 8;
            myPane.PaneFill = new Fill(Color.White, Color.White, 2F);
            myPane.AxisChange(this.CreateGraphics());
            myPane.IsShowTitle = false;

            pictureBox2.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            pictureBox2.BorderStyle = BorderStyle.None;
            MemoryStream ms1 = new MemoryStream();
            pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] arrImage1 = ms1.GetBuffer();
            ms1.Close();

            myPane.Image.Dispose();
            pictureBox2.Image.Dispose();
            dsGrupos1.Grafica.AddGraficaRow(1, arrImage1);

        }


        private void cmbIdGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();
                sqlComEficiencia.Parameters["@IdObra"].Value = "%";
                sqlComEficiencia.Parameters["@FecIni"].Value = "01/01/2018";
                sqlComEficiencia.Parameters["@FecFin"].Value = dtpFin.Value.ToShortDateString();
                sqlComEficiencia.Parameters["@EliFut"].Value = (ckbEliFut.Checked ? 1 : 0);
                int error = sqlComEficiencia.ExecuteNonQuery();
                MessageBox.Show("Proceso terminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UnirPdf_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string[] Docs = new string[dsGrupos1.Grupo.Rows.Count];
            folderBrowserDialog1.SelectedPath = @"Bibliotecas\Documentos";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int kk = 0; kk < dsGrupos1.Grupo.Rows.Count; kk++)
                {
                    dsGrupos1.GraGrupos.Clear();
                    dsGrupos1.GraPersonal.Clear();
                    dsGrupos1.Vivienda.Clear();
                    dsGrupos1.Grupos.Clear();
                    dsGrupos1.Grafica.Clear();
                    dsGrupos1.GraDuracionI.Clear();
                    dsGrupos1.GraDuracionF.Clear();
                    dsGrupos1.GraPromedio.Clear();
                    dsGrupos1.GraDias.Clear();
                    dsGraduracion1.Clear();

                    string grupo = dsGrupos1.Grupo.Rows[kk][0].ToString();

                    int s = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(dtpIni.Value, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
                    int a = dtpIni.Value.Year;
                    s = (a == 2019 ? s + 1 : s);
                    if (s == 53 && a == 2018)
                    {
                        s = 1;
                        a = a + 1;
                    }

                    sqlDASFestivo.SelectCommand.Parameters["@Año"].Value = a;
                    sqlDASFestivo.SelectCommand.Parameters["@Si"].Value = s;
                    sqlDASFestivo.SelectCommand.Parameters["@Sf"].Value = s + 25;
                    sqlDASFestivo.Fill(dsSFestivo1, "SFestivo");


                    cryGraGrupos1.SetDataSource(dsGrupos1);
                    cryGraGrupos1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    sqlDAGrupo.SelectCommand.Parameters["@IdGrupo"].Value = grupo;
                    sqlDAGrupo.Fill(dsGrupos1, "Grupos");

                    sqlDAGraGrupos.SelectCommand.Parameters["@IdGrupo"].Value = grupo;
                    sqlDAGraGrupos.SelectCommand.Parameters["@Mes"].Value = s;
                    sqlDAGraGrupos.SelectCommand.Parameters["@Año"].Value = a;
                    sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 1;
                    sqlDAGraGrupos.Fill(dsGrupos1, "GraGrupos");
                    sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 0;
                    sqlDAGraGrupos.Fill(dsGrupos1, "GraPersonal");
                    sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 2;
                    sqlDAGraGrupos.Fill(dsGrupos1, "GraPromedio");
                    sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 3;
                    sqlDAGraGrupos.Fill(dsGrupos1, "GraDias");
                    sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 4;
                    sqlDAGraGrupos.Fill(dsGrupos1, "GraDias");
                    sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 5;
                    sqlDAGraGrupos.Fill(dsGrupos1, "GraDias");
                    sqlDAGraGrupos.SelectCommand.Parameters["@Cual"].Value = 6;
                    sqlDAGraGrupos.Fill(dsGrupos1, "GraDias");
                    sqlDAVivienda.SelectCommand.Parameters["@IdGrupo"].Value = grupo;
                    sqlDAVivienda.SelectCommand.Parameters["@Mes"].Value = s;
                    sqlDAVivienda.SelectCommand.Parameters["@Año"].Value = a;
                    sqlDAVivienda.Fill(dsGrupos1, "Vivienda");
                    sqlDAVivIni.SelectCommand.Parameters["@IdGrupo"].Value = grupo;
                    sqlDAVivIni.SelectCommand.Parameters["@Mes"].Value = s;
                    sqlDAVivIni.SelectCommand.Parameters["@Año"].Value = a;
                    sqlDAVivIni.Fill(dsGrupos1, "Vivienda");
                    sqlDADuracion.SelectCommand.Parameters["@IdGrupo"].Value = grupo;
                    sqlDADuracion.SelectCommand.Parameters["@Primero"].Value = 0;
                    sqlDADuracion.Fill(dsGrupos1, "GraduracionI");
                    sqlDADuracion.SelectCommand.Parameters["@IdGrupo"].Value = grupo;
                    sqlDADuracion.SelectCommand.Parameters["@Primero"].Value = 1;
                    sqlDADuracion.Fill(dsGrupos1, "GraduracionF");
                    sqlDADuracion.SelectCommand.Parameters["@IdGrupo"].Value = grupo;
                    sqlDADuracion.SelectCommand.Parameters["@Primero"].Value = 2;
                    sqlDADuracion.Fill(dsGraduracion1, "GraduracionF");

                    myPane = new GraphPane(new Rectangle(10, 10, 10, 10), " ", "", "");
                    SetSize();
                    CurveItem curve;
                    double[] eex;
                    eex = new double[26];
                    double[] neey;
                    neey = new double[26];

                    for (int m = 0; m < dsGrupos1.GraGrupos.Rows.Count; m++)
                    {
                        for (int i = 0; i <= 25; i++)
                        {
                            neey[i] = double.Parse(dsGrupos1.Tables["GraGrupos"].Rows[m][i + 1].ToString());
                            eex[i] = double.Parse((s + i).ToString());
                        }
                        if (m == 0)
                        {
                            curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Maroon, SymbolType.Square);
                            curve.Symbol.Fill = new Fill(Color.Maroon);
                            curve.Line.Width = 2.5F;
                            for (int jj = 25; jj >= 0; jj--)
                                if (neey[jj] <= 0.01)
                                    curve.Points.Remove(jj);
                                else
                                    jj = -1;
                        }
                        if (m == 1)
                        {
                            curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Green, SymbolType.Diamond);
                            curve.Symbol.Fill = new Fill(Color.Green);
                            curve.Line.Width = 2.5F;
                            //for (int jj = 25; jj >= 0; jj--)
                            //    if (neey[jj] <= 0.01)
                            //        curve.Points.Remove(jj);
                        }
                        if (m == 2)
                        {
                            curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Olive, SymbolType.Circle);
                            curve.Line.Width = 3.5F;
                            curve.Symbol.Fill = new Fill(Color.Olive);
                            //for (int jj = 25; jj >= 0; jj--)
                            //    if (neey[jj] <= 0.01)
                            //        curve.Points.Remove(jj);
                        }
                        if (m == 3)
                        {
                            curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Navy, SymbolType.TriangleDown);
                            curve.Symbol.Fill = new Fill(Color.Navy);
                            curve.Line.Width = 2.5F;
                            //for (int jj = 25; jj >= 0; jj--)
                            //    if (neey[jj] <= 0.01)
                            //        curve.Points.Remove(jj);
                        }
                        if (m == 4)
                        {
                            curve = myPane.AddCurve(dsGrupos1.Tables["GraGrupos"].Rows[m][28].ToString() + " " + dsGrupos1.Tables["GraDuracionF"].Rows[m]["Ubicacion"].ToString(), eex, neey, Color.Purple, SymbolType.TriangleDown);
                            curve.Symbol.Fill = new Fill(Color.Purple);
                            curve.Line.Width = 2.5F;
                            //for (int jj = 25; jj >= 0; jj--)
                            //    if (neey[jj] <= 0.01)
                            //        curve.Points.Remove(jj);
                        }
                    }

                    float x1 = float.Parse(s.ToString());
                    float y1 = 10;
                    float size = 3;

                    TextItem texe = new TextItem();
                    ArrowItem arrow = new ArrowItem(Color.Red, size, x1, y1, x1 + 25, y1);
                    arrow.CoordinateFrame = CoordType.AxisXYScale;
                    arrow.PenWidth = 0F;
                    myPane.ArrowList.Add(arrow);
                    y1 = 15;
                    arrow = new ArrowItem(Color.Red, size, x1, y1, x1 + 25, y1);
                    arrow.CoordinateFrame = CoordType.AxisXYScale;
                    arrow.PenWidth = 0F;
                    myPane.ArrowList.Add(arrow);
                    y1 = 20;
                    arrow = new ArrowItem(Color.Red, size, x1, y1, x1 + 25, y1);
                    arrow.CoordinateFrame = CoordType.AxisXYScale;
                    arrow.PenWidth = 0F;
                    myPane.ArrowList.Add(arrow);

                    double año = a;
                    int semIni = (a * 52) + s - 104936;
                    int semFin = semIni + 25;
                    for (int m = 0; m < dsGraduracion1.GraDuracionF.Rows.Count; m++)
                    {
                        int semana = int.Parse(dsGraduracion1.GraDuracionF.Rows[m][4].ToString());
                        int años = int.Parse(dsGraduracion1.GraDuracionF.Rows[m][3].ToString());
                        int vigencia = (años * 52) + semana - 104936;
                        if (semIni <= vigencia && vigencia <= semFin)
                        {
                            size = 3;
                            x1 = float.Parse((vigencia - semIni + 1).ToString());
                            y1 = 0;
                            arrow = new ArrowItem(Color.Violet, size, x1, y1, x1, y1 + 35);
                            arrow.CoordinateFrame = CoordType.AxisXYScale;
                            arrow.PenWidth = 5F;
                            myPane.ArrowList.Add(arrow);
                            texe = new TextItem(dsGraduracion1.GraDuracionF.Rows[m][1].ToString(), x1, 2);
                            texe.FontSpec.IsBold = false;
                            texe.FontSpec.Size = 8;
                            texe.FontSpec.Family = "Times New Roman";
                            myPane.TextList.Add(texe);
                        }
                    }

                    guardagrafica(s);
                    cryGraGrupos1.SetParameterValue("Grupo", "Laboratorio " + string.Format("{0:0.#}", dsGrupos1.Grupo.Rows[kk][0]));
                    cryGraGrupos1.SetParameterValue("Año", a);
                    cryGraGrupos1.SetParameterValue("Semana", s);

                    for (int i = 0; i < 26; i++)
                    {
                        if (s == 53 && a!= 2020)
                        {
                            s = 1;
                            a = a + 1;
                        }
                        if (s > 53)
                        {
                            s = 1;
                            a = a + 1;
                        }
                        string param = "SFes" + i.ToString().Trim();
                        int Sfes = 0;
                        for (int j = 0; j < dsSFestivo1.SFestivo.Rows.Count; j++)
                            if (dsSFestivo1.SFestivo.Rows[j][0].ToString() == a.ToString() && dsSFestivo1.SFestivo.Rows[j][1].ToString() == s.ToString())
                                Sfes = 1;
                        cryGraGrupos1.SetParameterValue(param, Sfes);
                        s = s + 1;
                    }


                    string obraC = dsGrupos1.Grupo.Rows[kk][0].ToString();
                    string Documento = folderBrowserDialog1.SelectedPath.ToString() + "\\" + obraC + ".pdf";
                    Docs[kk] = Documento;
                    ruta = folderBrowserDialog1.SelectedPath.ToString();
                    try
                    {
                        ExportOptions CrExportOptions;
                        DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                        PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                        CrDiskFileDestinationOptions.DiskFileName = Documento;
                        CrExportOptions = cryGraGrupos1.ExportOptions;
                        {
                            CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                            CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                            CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                            CrExportOptions.FormatOptions = CrFormatTypeOptions;
                        }
                        cryGraGrupos1.Export();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    //crvInfProd.ReportSource = cryGraGrupos1;
                }
                Variant1(Docs, ruta);
            }
        }
        static void Variant1(string[] documentos, string ruta)
        {
            // Get some file names
            string[] files = documentos;

            // Open the output document
            PdfDocument outputDocument = new PdfDocument();

            // Iterate files
            foreach (string file in files)
            {
                // Open the document to import pages from it.
                PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import);

                // Iterate pages
                int count = inputDocument.PageCount;
                for (int idx = 0; idx < count; idx++)
                {
                    // Get the page from the external document...
                    PdfPage page = inputDocument.Pages[idx];
                    // ...and add it to the output document.
                    outputDocument.AddPage(page);
                }
            }

            // Save the document...
            string filename = ruta + "\\Eficiencia.pdf";
            outputDocument.Save(filename);
            // ...and start a viewer.
//            Process.Start(filename);
            Process P = new Process();
            try
            {
                P.StartInfo.FileName = filename;
                P.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                P.Start();
                //Espera el proceso para que lo termine y continuar 
                P.WaitForExit();
                //Liberar 
                P.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " No se puede abrir el documento " + ruta, "Error");
            }

        }
    }
}
