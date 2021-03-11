using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using ZedGraph;
using System.IO;

namespace LancNeo
{
    public partial class RepAnaBloN : Form
    {
        private DBGraphics memGraphics;
        public RepAnaBloN()
        {
            InitializeComponent();
            memGraphics = new DBGraphics();
        }
        protected GraphPane myPane;
        private void RepAnaBloN_Load(object sender, EventArgs e)
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
			dsBuscaObra1.Tables["Obra"].LoadDataRow(Matriz,true);
			dsBuscaObra1.Tables["Obra"].EndLoadData();
			sqlDABusObra.Fill(dsBuscaObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			sqlDAGrado.Fill(dsGradoBlock1, "TabiqueMdor");
			sqlDATipo.Fill(dsTipoBlock1, "TabiqueMdor");
			sqlDAComo.Fill(dsComo1, "TabiqueMdor");
			dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1,"Todos");
			sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
			cmbNoEco.SelectedIndex = 0;
			cmbIdObra.SelectedIndex = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsConcreto1.Clear();
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
            dsGruTab1.Clear();
            sqlDAGruTab.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "%" : txtIdobra.Text);
            sqlDAGruTab.Fill(dsGruTab1, "TabiqueMdor");
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			btnVistaPrevia.Visible = true;
            cmbComo.SelectedValue = dsGruTab1.TabiqueMdor.Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
            cmbTipo.SelectedValue = dsGruTab1.TabiqueMdor.Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
            cmbGrado.SelectedValue = dsGruTab1.TabiqueMdor.Rows[buscaBtn1.RegistroSeleccionado][2].ToString();
            txtLargo.Text = dsGruTab1.TabiqueMdor.Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
            txtAncho.Text = dsGruTab1.TabiqueMdor.Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
            txtPeralte.Text = dsGruTab1.TabiqueMdor.Rows[buscaBtn1.RegistroSeleccionado][5].ToString();
            dsProveedor1.Clear();
            dsProveedor1.TabiqueMdor.Rows.Add("Todos", "Todos");
            sqlDAProveedor.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
            sqlDAProveedor.SelectCommand.Parameters["@Como"].Value = cmbComo.SelectedValue;
            sqlDAProveedor.SelectCommand.Parameters["@Tipo"].Value = cmbTipo.SelectedValue;
            sqlDAProveedor.SelectCommand.Parameters["@largo"].Value = txtLargo.Text;
            sqlDAProveedor.SelectCommand.Parameters["@ancho"].Value = txtAncho.Text;
            sqlDAProveedor.SelectCommand.Parameters["@peralte"].Value = txtPeralte.Text;
            sqlDAProveedor.Fill(dsProveedor1, "TabiqueMdor");
            cmbProve.SelectedIndex = 0;

		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{

            int resi = 0;
            string grado = "   ";
            string gradot = "   ";
            char cGrado;
            gradot = cmbGrado.SelectedValue.ToString().Trim();
            int Longitud = gradot.Length;
            grado = "";
            for (int i = 0; i < Longitud; i++)
            {
                cGrado = System.Convert.ToChar(gradot.Substring(i, 1));
                if (char.IsNumber(cGrado))
                    grado = grado + System.Convert.ToString(cGrado);
            }
            grado = grado + " f*p  ";
            crvRepAnalisis.Visible = true;
            cryRepAnalBlockC1.SetDataSource(dsAnalBlock1);				
                        
            try
			{
				CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
				
				CrystalDecisions.Shared.ParameterDiscreteValue pdvRes = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvRes.Value = float.Parse(grado.Substring(0,3)) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				CrystalDecisions.Shared.ParameterDiscreteValue pdvTip = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvTip.Value = cmbTipo.SelectedValue.ToString();
				
				CrystalDecisions.Shared.ParameterDiscreteValue pdvLab = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvLab.Value = cmbNoEco.Text;

				CrystalDecisions.Shared.ParameterDiscreteValue pdvCra = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvCra.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvDir = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvDir.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvObr = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvObr.Value = txtIdobra.Text;
				CrystalDecisions.Shared.ParameterDiscreteValue pdvZon = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvZon.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString();
				CrystalDecisions.Shared.ParameterDiscreteValue pdvLoc = new CrystalDecisions.Shared.ParameterDiscreteValue();
				pdvLoc.Value = dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString();

				pvCollection.Clear();
				pvCollection.Add(pdvRes);
				cryRepAnalBlockC1.DataDefinition.ParameterFields["@Res"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvTip);
				cryRepAnalBlockC1.DataDefinition.ParameterFields["@Tip"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvLab);
				cryRepAnalBlockC1.DataDefinition.ParameterFields["@Lab"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvCra);
				cryRepAnalBlockC1.DataDefinition.ParameterFields["@Cra"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvDir);
				cryRepAnalBlockC1.DataDefinition.ParameterFields["@Dir"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvObr);
				cryRepAnalBlockC1.DataDefinition.ParameterFields["@Obr"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvZon);
				cryRepAnalBlockC1.DataDefinition.ParameterFields["@Zon"].ApplyCurrentValues(pvCollection);
				pvCollection.Clear();
				pvCollection.Add(pdvLoc);
				cryRepAnalBlockC1.DataDefinition.ParameterFields["@Loc"].ApplyCurrentValues(pvCollection);	
			}
			catch(Exception ex1)
			{
				MessageBox.Show("parametro" + ex1.Message );
			}
			dsAnalBlock1.Clear();
			sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "%" : txtIdobra.Text);
			sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@Tipo"].Value = cmbTipo.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@Largo"].Value = txtLargo.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@Ancho"].Value = txtAncho.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@Peralte"].Value = txtPeralte.Text;
			sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = 1;
			sqlDAAnalisis.SelectCommand.Parameters["@NoEco"].Value = cmbNoEco.SelectedValue.ToString();
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 3;
            sqlDAAnalisis.SelectCommand.Parameters["@Grado"].Value = cmbGrado.SelectedValue.ToString(); //grado;
			sqlDAAnalisis.SelectCommand.Parameters["@Como"].Value = cmbComo.SelectedValue.ToString();
            sqlDAAnalisis.SelectCommand.Parameters["@TMuestra"].Value = true;
            sqlDAAnalisis.SelectCommand.Parameters["@Prove"].Value = (cmbProve.SelectedValue.ToString() == "Todos" ? "%" : cmbProve.SelectedValue);
            sqlDAAnalisis.Fill(dsAnalBlock1, "GraficaFinal");
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 1;
			sqlDAAnalisis.Fill(dsAnalBlock1, "Analisis");
			sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 2;
			sqlDAAnalisis.Fill(dsAnalBlock1, "Grafica1");
            sqlDAAnalisis.SelectCommand.Parameters["@TMuestra"].Value = false;
            sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
            sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 1;
            sqlDAAnalisis.Fill(dsAnalBlock1, "Analisis1");
            sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 2;
            sqlDAAnalisis.Fill(dsAnalBlock1, "Grafica11");
            sqlDAAnalisis.SelectCommand.Parameters["@Datos"].Value = 3;
            sqlDAAnalisis.Fill(dsAnalBlock1, "GraficaFinal1");

            int cuantos = dsAnalBlock1.GraficaFinal.Rows.Count;
            cuantos = dsAnalBlock1.Grafica1.Rows.Count;
            cuantos = dsAnalBlock1.Analisis.Rows.Count;

			double[] gaus;
			gaus= new double[24];
			double[] ee;
			ee= new double[24];
			double[] nuevoee;
			nuevoee = new double[24];
			double moda = 0;
			int indice = 1;
			for(int i= 1; i <= 23; i++)
			{
				nuevoee[i] = 0;
				ee[i] = double.Parse(dsAnalBlock1.Tables["GraficaFinal"].Rows[0][i].ToString());
				if (moda < ee[i])
				{
					indice = i;
					moda = ee[i];
				}
			}
				indice = 12;
				for(int i= 1; i <= 23; i++)
					if(1 <= (i - (12 - indice)) && (i - (12 - indice)) <= 23)
						nuevoee[(i - (12 - indice))] = gaus[i] * (moda + 2);
				float res = float.Parse(grado.ToString().Substring(0,3).Trim()) * float.Parse(dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());

				sqlDATitulo.SelectCommand.Parameters["@ResistenciaKg"].Value = res.ToString();
				sqlDATitulo.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
				sqlDATitulo.SelectCommand.Parameters["@Hoja"].Value = int.Parse(dsAnalBlock1.Tables["GraficaFinal"].Rows[0][24].ToString());
                sqlDATitulo.SelectCommand.Parameters["@Incre"].Value = 0.15;
                sqlDATitulo.Fill(dsAnalBlock1, "titulo");

                cuantos = dsAnalBlock1.Analisis1.Rows.Count;
                int Lineas = dsAnalBlock1.GraficaFinal.Rows.Count;

                double res1 = 0;
                double res2 = 0;

                for (int i = 0; i < cuantos; i++)
                {
                    if (!string.IsNullOrEmpty(dsAnalBlock1.Tables["Analisis1"].Rows[i]["ee1"].ToString()))
                    {
                        res2 = float.Parse(dsAnalBlock1.Tables["Analisis1"].Rows[i]["ee1"].ToString());
                        res1 = (res2 > res1 ? res2 : res1);
                    }
                }
                    //res1 = Math.Truncate((res1 / cuantos) * 10) / 10;
                sqlDATitulo.SelectCommand.Parameters["@ResistenciaKg"].Value = res1.ToString();
                sqlDATitulo.SelectCommand.Parameters["@IdUnidad"].Value = 1;
                sqlDATitulo.SelectCommand.Parameters["@Hoja"].Value = int.Parse(dsAnalBlock1.Tables["GraficaFinal"].Rows[0][24].ToString());
                sqlDATitulo.SelectCommand.Parameters["@Incre"].Value = 0.1;
                sqlDATitulo.Fill(dsAnalBlock1, "titulo1");

                memGraphics.CreateDoubleBuffer(this.CreateGraphics(), this.ClientRectangle.Width, this.ClientRectangle.Height);

                myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "Edad en días", "Frecuencia");
                SetSize();
                CurveItem curve;
 
                double incdec = 0.1;
                for (int j = 0; j < Lineas; j++)
                {
                    for (int i = 0; i <= 21; i++)
                    {
                        nuevoee[i] = double.Parse(dsAnalBlock1.Tables["GraficaFinal"].Rows[j][i + 1].ToString());
                        ee[i] = res * (incdec * i);
                    }
                    if (j == 0)
                    {
                        curve = myPane.AddCurve("Reducida", ee, nuevoee, Color.DarkSeaGreen, SymbolType.Square);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                    }
                    if (j == 1)
                    {
                        curve = myPane.AddCurve("Completa", ee, nuevoee, Color.Cyan, SymbolType.Circle);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.Cyan);
                    }
                    if (j == 2)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkSlateBlue, SymbolType.Diamond);
                        curve.Line.Width = 3.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkSlateBlue);
                    }
                    if (j == 3)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.Brown, SymbolType.TriangleDown);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.Brown);
                    }
                    if (j == 4)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["GraficaFinal"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkMagenta, SymbolType.Triangle);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkMagenta);
                    }
                }

                myPane.XAxis.IsMinorInsideTic = true;
                myPane.XAxis.TicSize = float.Parse((res * 0.05).ToString());
                myPane.XAxis.IsShowGrid = true;
                myPane.XAxis.IsInsideTic = true;
                myPane.XAxis.ScaleFontSpec.Angle = 0;
                myPane.XAxis.NumDec = 0;
                myPane.XAxis.Step = float.Parse((res * 0.05).ToString());
                myPane.XAxis.ScaleFontSpec.Size = 10;
                myPane.XAxis.Min = res * 0.1; //cambiar
                myPane.XAxis.Max = res * 22 * 0.1;
                myPane.XAxis.Type = AxisType.Linear;
                myPane.XAxis.StepAuto = true;
                //                myPane1.XAxis.MinorStepAuto = true;
                myPane.XAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.XAxis.TitleFontSpec.Size = 12;
                myPane.XAxis.IsShowTitle = false;
                myPane.XAxis.ScaleFontSpec.FontColor = Color.Black;
                myPane.XAxis.IsMinorTic = true;

                myPane.YAxis.IsMinorInsideTic = true;
                myPane.XAxis.IsInsideTic = true;
                myPane.YAxis.IsShowGrid = true;
                myPane.YAxis.ScaleFontSpec.Angle = 90;
                myPane.YAxis.ScaleFontSpec.Size = 10;
                myPane.YAxis.Min = 0;
                myPane.YAxis.Max = Math.Round((moda/10))*10;
                myPane.YAxis.TicSize = 10;
                myPane.YAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.YAxis.ScaleFontSpec.Family = "Times New Roman";
                myPane.Legend.IsVisible = true;
                myPane.Legend.Location = LegendLoc.InsideTopRight;
                myPane.Legend.FontSpec.Size = 10;
                myPane.PaneFill = new Fill(Color.White, Color.White, 2F);
                myPane.AxisChange(this.CreateGraphics());

                pictureBox2.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
                pictureBox2.BorderStyle = BorderStyle.None;
                MemoryStream ms1 = new MemoryStream();
                pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] arrImage1 = ms1.GetBuffer();
                ms1.Close();
                dsAnalBlock1.GraficaFinal.Rows[0]["Imagen1"] = arrImage1;

                Lineas = dsAnalBlock1.GraficaFinal1.Rows.Count;
                myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "Edad en días", "Frecuencia");
                SetSize();
                incdec = 0.1;
                for (int j = 0; j < Lineas; j++)
                {
                    for (int i = 0; i <= 21; i++)
                    {
                        nuevoee[i] = double.Parse(dsAnalBlock1.Tables["GraficaFinal1"].Rows[j][i + 1].ToString());
                        ee[i] = res * (incdec * i);
                    }
                    //if (j == 0)
                    //{
                    //    curve = myPane.AddCurve(dsAnalBlock1.Tables["GraficaFinal1"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkSeaGreen, SymbolType.Square);
                    //    curve.Line.Width = 2.5F;
                    //    curve.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                    //}
                    if (j == 1)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["GraficaFinal1"].Rows[j][0].ToString(), ee, nuevoee, Color.Cyan, SymbolType.Circle);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.Cyan);
                    }
                    if (j == 2)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["GraficaFinal1"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkSlateBlue, SymbolType.Diamond);
                        curve.Line.Width = 3.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkSlateBlue);
                    }
                    if (j == 3)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["GraficaFinal1"].Rows[j][0].ToString(), ee, nuevoee, Color.Brown, SymbolType.TriangleDown);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.Brown);
                    }
                    if (j == 4)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["GraficaFinal1"].Rows[j][0].ToString(), ee, nuevoee, Color.DarkMagenta, SymbolType.Triangle);
                        curve.Line.Width = 2.5F;
                        curve.Symbol.Fill = new Fill(Color.DarkMagenta);
                    }
                }

                myPane.XAxis.IsMinorInsideTic = true;
                myPane.XAxis.TicSize = float.Parse((res * 0.05).ToString());
                myPane.XAxis.IsShowGrid = true;
                myPane.XAxis.IsInsideTic = true;
                myPane.XAxis.ScaleFontSpec.Angle = 0;
                myPane.XAxis.NumDec = 0;
                myPane.XAxis.Step = float.Parse((res * 0.05).ToString());
                myPane.XAxis.ScaleFontSpec.Size = 10;
                myPane.XAxis.Min = res * 0.1; //cambiar
                myPane.XAxis.Max = res * 22 * 0.1;
                myPane.XAxis.Type = AxisType.Linear;
                myPane.XAxis.StepAuto = true;
                //                myPane1.XAxis.MinorStepAuto = true;
                myPane.XAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.XAxis.TitleFontSpec.Size = 12;
                myPane.XAxis.IsShowTitle = false;
                myPane.XAxis.ScaleFontSpec.FontColor = Color.Black;
                myPane.XAxis.IsMinorTic = true;

                myPane.YAxis.IsMinorInsideTic = true;
                myPane.XAxis.IsInsideTic = true;
                myPane.YAxis.IsShowGrid = true;
                myPane.YAxis.ScaleFontSpec.Angle = 90;
                myPane.YAxis.ScaleFontSpec.Size = 10;
                myPane.YAxis.Min = 0;
                myPane.YAxis.Max = Math.Round((moda/10))*10;;
                myPane.YAxis.TicSize = 10;
                myPane.YAxis.TitleFontSpec.Family = "Times New Roman";
                myPane.YAxis.ScaleFontSpec.Family = "Times New Roman";
                myPane.Legend.IsVisible = false;
//                myPane.Legend.Location = LegendLoc.InsideTopRight;
                myPane.Legend.FontSpec.Size = 10;
                myPane.PaneFill = new Fill(Color.White, Color.White, 2F);
                myPane.AxisChange(this.CreateGraphics());

                pictureBox4.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
                pictureBox4.BorderStyle = BorderStyle.None;
                MemoryStream ms2 = new MemoryStream();
                pictureBox4.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] arrImage2 = ms2.GetBuffer();
                arrImage2 = ms2.GetBuffer();
                ms2.Close();
                myPane.Image.Dispose();
                pictureBox4.Image.Dispose();
                dsAnalBlock1.GraficaFinal1.Rows[0]["Imagen2"] =  arrImage2;

                Lineas = dsAnalBlock1.Grafica1.Rows.Count;
                incdec = 0.1;
                double[] eex;
                eex = new double[12];
                double[] neey;
                neey = new double[12];
                int hoja = int.Parse(dsAnalBlock1.Grafica1.Rows[0][0].ToString());
                int hoaa = hoja;
                int ij = 0;
                double mayor = 0;
                myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "", "Frecuencias");
                SetSize();
                for (int m = 0; m < dsAnalBlock1.Grafica1.Rows.Count; m++)
                {
                    if (hoaa != int.Parse(dsAnalBlock1.Grafica1.Rows[m][0].ToString())) // && ij >= Lineas)
                    {
                        guardagrafica(res, hoaa, 1, mayor);
                        myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "", "Frecuencias");
                        SetSize();
                        ij = 0;
                        hoaa = int.Parse(dsAnalBlock1.Grafica1.Rows[m][0].ToString());
                        mayor = 0;
                    }
                    for (int i = 0; i <= 11; i++)
                    {
                        neey[i] = double.Parse(dsAnalBlock1.Tables["Grafica1"].Rows[m][i + 2].ToString());
                        eex[i] = double.Parse(dsAnalBlock1.titulo.Rows[0][i + 2].ToString());
                        mayor = (neey[i] > mayor ? neey[i] : mayor);
                    }
                    if (ij == 0)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkSeaGreen, SymbolType.Square);
                        curve.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                        curve.Line.Width = 2.5F;
                    }
                    if (ij == 1)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.Cyan, SymbolType.Circle);
                        curve.Symbol.Fill = new Fill(Color.Cyan);
                        curve.Line.Width = 2.5F;
                    }
                    //if (ij == 2)
                    //{
                    //    curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkSlateBlue, SymbolType.Diamond);
                    //    curve.Line.Width = 3.5F;
                    //    curve.Symbol.Fill = new Fill(Color.DarkSlateBlue);
                    //}
                    //if (ij == 3)
                    //{
                    //    curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.Brown, SymbolType.TriangleDown);
                    //    curve.Symbol.Fill = new Fill(Color.Brown);
                    //    curve.Line.Width = 2.5F;
                    //}
                    //if (ij == 4)
                    //{
                    //    curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkMagenta, SymbolType.TriangleDown);
                    //    curve.Symbol.Fill = new Fill(Color.DarkMagenta);
                    //    curve.Line.Width = 2.5F;
                    //}
                    ij++;
                }
                guardagrafica(res, hoaa, 1, mayor);

                Lineas = dsAnalBlock1.Grafica11.Rows.Count;
                hoja = int.Parse(dsAnalBlock1.Grafica11.Rows[0][0].ToString());
                hoaa = hoja;
                ij = 0;
                myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "", "Frecuencias");
                SetSize();
                for (int m = 0; m < dsAnalBlock1.Grafica11.Rows.Count; m++)
                {
                    if (hoaa != int.Parse(dsAnalBlock1.Grafica11.Rows[m][0].ToString()) ) //&& ij >= Lineas)
                    {
                        guardagrafica(res, hoaa, 2, mayor);
                        myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "", "Frecuencias");
                        SetSize();
                        ij = 0;
                        hoaa = int.Parse(dsAnalBlock1.Grafica11.Rows[m][0].ToString());
                        mayor = 0;
                    }
                    for (int i = 0; i <= 11; i++)
                    {
                        neey[i] = double.Parse(dsAnalBlock1.Tables["Grafica11"].Rows[m][i + 2].ToString());
                        eex[i] = double.Parse(dsAnalBlock1.titulo.Rows[0][i + 2].ToString());
                        mayor = (neey[i] > mayor ? neey[i] : mayor);
                    }
                    if (ij == 0)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica11"].Rows[m][1].ToString(), eex, neey, Color.DarkSeaGreen, SymbolType.Square);
                        curve.Symbol.Fill = new Fill(Color.DarkSeaGreen);
                        curve.Line.Width = 2.5F;
                    }
                    if (ij == 1)
                    {
                        curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica11"].Rows[m][1].ToString(), eex, neey, Color.Cyan, SymbolType.Circle);
                        curve.Symbol.Fill = new Fill(Color.Cyan);
                        curve.Line.Width = 2.5F;
                    }
                    //if (ij == 2)
                    //{
                    //    curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica11"].Rows[m][1].ToString(), eex, neey, Color.DarkSlateBlue, SymbolType.Diamond);
                    //    curve.Line.Width = 3.5F;
                    //    curve.Symbol.Fill = new Fill(Color.DarkSlateBlue);
                    //}
                    //if (ij == 3)
                    //{
                    //    curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.Brown, SymbolType.TriangleDown);
                    //    curve.Symbol.Fill = new Fill(Color.Brown);
                    //    curve.Line.Width = 2.5F;
                    //}
                    //if (ij == 4)
                    //{
                    //    curve = myPane.AddCurve(dsAnalBlock1.Tables["Grafica1"].Rows[m][1].ToString(), eex, neey, Color.DarkMagenta, SymbolType.TriangleDown);
                    //    curve.Symbol.Fill = new Fill(Color.DarkMagenta);
                    //    curve.Line.Width = 2.5F;
                    //}
                    ij++;
                }
                guardagrafica(res, hoaa, 2, mayor);

                resi = System.Convert.ToInt32(Math.Floor(res));
				// Establece el valor actual de parameter1 en el subinforme en 10 
				cryRepAnalBlockC1.SetParameterValue("@reskg", res.ToString(), "Gauss");
                cryRepAnalBlockC1.SetParameterValue("@Unidad", cmbUnidad.Text);
                cryRepAnalBlockC1.SetParameterValue("@Unidad", cmbUnidad.Text, "Gauss");
				cryRepAnalBlockC1.SetParameterValue("@Equi", dsUnidad1.Tables["unidad"].Rows[cmbUnidad.SelectedIndex][2].ToString());
				cryRepAnalBlockC1.SetParameterValue("@Prueba", cmbPrueba.Text);
				cryRepAnalBlockC1.SetParameterValue("@Grado", cmbGrado.SelectedValue.ToString());
				cryRepAnalBlockC1.SetParameterValue("@Indice", resi);
			cryRepAnalBlockC1.SetParameterValue("@Como", cmbComo.SelectedValue);
			cryRepAnalBlockC1.SetParameterValue("@Largo", txtLargo.Text);
			cryRepAnalBlockC1.SetParameterValue("@Ancho", txtAncho.Text);
			cryRepAnalBlockC1.SetParameterValue("@Peralte", txtPeralte.Text);
			cryRepAnalBlockC1.SetParameterValue("@Lab1", chbLab.Checked);
            cryRepAnalBlockC1.SetParameterValue("@Prove", cmbProve.SelectedValue.ToString());

				
				crvRepAnalisis.ReportSource = cryRepAnalBlockC1;

		}

		private void cbkPrefijo_CheckedChanged(object sender, System.EventArgs e)
		{
		if (cbkPrefijo.Checked == false)
			txtIdobra.Text = txtIdobra.Text.Substring(0,3)+"%";
		else
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
		}

        private void SetSize()
        {
            Rectangle paneRect = this.ClientRectangle;
            paneRect.Inflate(-2, -1);
            this.myPane.PaneRect = paneRect;
        }

        private void guardagrafica(double res, int hoja, int cual, double mayor)
        {

            float resus = float.Parse(res.ToString());
            double super = Math.Truncate(((mayor / 10) + 1) * 10);
            super = (super < 15 ? 15 : super);
            float superior = float.Parse(super.ToString());
            if (cual == 1)
            {
                ArrowItem arrow = new ArrowItem(Color.Gray, 0, resus, 0, resus, superior);
                //            ArrowItem arrow = new ArrowItem(Color.Red, superior, resus, 0, resus, superior);
                arrow.CoordinateFrame = CoordType.AxisXYScale;
                arrow.PenWidth = 3F;
                myPane.ArrowList.Add(arrow);
            }
            myPane.XAxis.IsMinorInsideTic = true;
            myPane.XAxis.TicSize = float.Parse((res * 0.1).ToString());
            myPane.XAxis.IsShowGrid = true;
            myPane.XAxis.IsInsideTic = true;
            myPane.XAxis.ScaleFontSpec.Angle = 0;
            myPane.XAxis.NumDec = 0;
            myPane.XAxis.Step = float.Parse((res * 0.1).ToString());
            myPane.XAxis.ScaleFontSpec.Size = 10;
            myPane.XAxis.Min = res * 0.15; //cambiar
            myPane.XAxis.Max = res * 12 * 0.15;
            myPane.XAxis.Type = AxisType.Linear;
            myPane.XAxis.StepAuto = true;
            //                myPane1.XAxis.MinorStepAuto = true;
            myPane.XAxis.TitleFontSpec.Family = "Times New Roman";
            myPane.XAxis.TitleFontSpec.Size = 8;
            myPane.XAxis.IsShowTitle = false;
            myPane.XAxis.ScaleFontSpec.FontColor = Color.Black;
            myPane.XAxis.IsMinorTic = true;

            myPane.YAxis.IsMinorInsideTic = true; 
            myPane.XAxis.IsInsideTic = true;
            myPane.YAxis.IsShowGrid = true;
            myPane.YAxis.ScaleFontSpec.Angle = 90;
            myPane.YAxis.ScaleFontSpec.Size = 8;
            myPane.YAxis.Min = 0;
            myPane.YAxis.Max = super;
            myPane.YAxis.TicSize = 10;
            myPane.YAxis.TitleFontSpec.Family = "Times New Roman";
            myPane.YAxis.ScaleFontSpec.Family = "Times New Roman";
            myPane.Legend.IsVisible = true;
            myPane.Legend.Location = LegendLoc.InsideTopRight;
            myPane.Legend.FontSpec.Size = 8;
            myPane.PaneFill = new Fill(Color.White, Color.White, 2F);
            myPane.AxisChange(this.CreateGraphics());

            pictureBox3.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            pictureBox3.BorderStyle = BorderStyle.None;
            MemoryStream ms1 = new MemoryStream();
            pictureBox3.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] arrImage1 = ms1.GetBuffer();
            ms1.Close();

            myPane.Image.Dispose();
            pictureBox3.Image.Dispose();
            if (cual == 1)
                   dsAnalBlock1.Gra1.AddGra1Row(hoja, arrImage1);
            else
                dsAnalBlock1.Gra2.AddGra2Row(hoja, arrImage1);
        } 
    }
}
