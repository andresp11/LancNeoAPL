using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using ZedGraph;
using System.IO;

namespace LancNeo
{
    public partial class InfDisTot : Form
    {
        private int filaCon = 0;
        private int filaExp = 0;
        public InfDisTot()
        {
            InitializeComponent();
            memGraphics = new DBGraphics();
            memGraphics1 = new DBGraphics();
        }
        protected GraphPane myPane;
        protected GraphPane myPane1;

        private void cmbIdObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsConCarta1.Clear();
            sqlDAConcretos.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
            sqlDAConcretos.SelectCommand.Parameters["@Cuantas"].Value = txtMinimo.Text.Trim();
            sqlDAConcretos.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Value.ToShortDateString();
            sqlDAConcretos.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Value.ToShortDateString(); ;
            sqlDAConcretos.Fill(dsConCarta1, "Obra");
            dgConcreto.Visible = true;
            dgExperiencia.Visible = true;
            crvGraDis.Visible = false;
            experiencia();
        }

        private void InfDisTot_Load(object sender, EventArgs e)
        {
           //
            sqlDABusObra.Fill(dsBuscaObra1, "Obra");
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");
            cmbUnidad.SelectedIndex = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            dtpIni.Value = DateTime.Now.AddDays(-33);
//            dtpFin.Value = dtpIni.Value.AddDays(33);
        }

        private void rBPre1_CheckedChanged(object sender, EventArgs e)
        {
            dsConCarta1.Clear();
            sqlDAConcretos.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
            sqlDAConcretos.SelectCommand.Parameters["@Cuantas"].Value = txtMinimo.Text.Trim();
            sqlDAConcretos.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Value.ToShortDateString();
            sqlDAConcretos.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Value.ToShortDateString();
            sqlDAConcretos.Fill(dsConCarta1, "Obra");
            dgConcreto.Visible = true;
            dgExperiencia.Visible = true;
            crvGraDis.Visible = false;
            experiencia();
        }

        private void experiencia()
        {
            dsBusExpCar1.Clear();
            //for (int i = 0; i < dsConCarta1.Obra.Rows.Count; i++)
            //{
            //}
            if (dsConCarta1.Obra.Rows.Count > 0)
            {
                sqlDABusExpCar.SelectCommand.Parameters["@ResKG"].Value = dsConCarta1.Obra.Rows[filaCon][0].ToString().Trim();
                sqlDABusExpCar.SelectCommand.Parameters["@Tipo"].Value = dsConCarta1.Obra.Rows[filaCon][7].ToString().Trim();
                sqlDABusExpCar.SelectCommand.Parameters["@Agr"].Value = dsConCarta1.Obra.Rows[filaCon][2].ToString().Trim();
                sqlDABusExpCar.SelectCommand.Parameters["@Rev"].Value = dsConCarta1.Obra.Rows[filaCon][3].ToString().Trim();
                sqlDABusExpCar.SelectCommand.Parameters["@IdAgr"].Value = dsConCarta1.Obra.Rows[filaCon][8].ToString().Trim();
                sqlDABusExpCar.Fill(dsBusExpCar1, "Agregado");
                dgExperiencia.Visible = true;
            }
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

        private void dgExperiencia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filaExp = e.RowIndex;
            try
            {
                if (!string.IsNullOrEmpty(dgExperiencia[0, filaExp].Value.ToString()))
                dgConcreto[6, filaCon].Value = dgExperiencia[0, filaExp].Value;
            }
            catch (Exception ex)
            {
            }
        }

        private void dgConcreto_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (filaCon != e.RowIndex)
            {
                filaCon = e.RowIndex;
                experiencia();
            }
            txtTipo.Text = dsConCarta1.Obra.Rows[filaCon][1].ToString().Trim();
            switch (int.Parse(dsConCarta1.Obra.Rows[filaCon][7].ToString().Trim()))
            {
                case 1:
                    txtInc1.Text = "3 a 7";
                    txtInc2.Text = "3 a 28";
                    txtInc3.Text = "7 a 28";
                    txtInc4.Text = "28 a 63";
                    break;
                case 2:
                    txtInc1.Text = "3 a 7";
                    txtInc2.Text = "3 a 14";
                    txtInc3.Text = "7 a 14";
                    txtInc4.Text = "14 a 28";
                    break;
                case 6:
                case 11:
                    txtInc1.Text = "1 a 3";
                    txtInc2.Text = "1 a 7";
                    txtInc3.Text = "3 a 7";
                    txtInc4.Text = "7 a 14";
                    break;
                case 7:
                case 12:
                    txtInc1.Text = "1 a 3";
                    txtInc2.Text = "1 a 7";
                    txtInc3.Text = "3 a 7";
                    txtInc4.Text = "7 a 14";
                    break;
                case 8:
                case 13:
                    txtInc1.Text = "16a20h";
                    txtInc2.Text = "16a24h";
                    txtInc3.Text = "20a24h";
                    txtInc4.Text = "1 a 3";
                    break;
                default:
                    txtInc1.Text = " ";
                    txtInc2.Text = " ";
                    txtInc3.Text = " ";
                    txtInc4.Text = " ";
                    break;
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            dgConcreto.Visible = false;
            dgExperiencia.Visible = false;
            double[, ,] datos = new double[8, 150, 36];
            double[,] media = new double[8, 35];
            double[,] enes  = new double[8, 35];
            double[,] seman = new double[8, 35];
            double[,] erres = new double[8, 35];
            double[,] erreM = new double[8, 35];
            double[,] estad = new double[8, 4];
            double[] sa = new double[30]; //63
            double[] ta = new double[30]; //28
            double[] ua = new double[30]; //14
            double[] va = new double[30]; //7
            double[] wa = new double[30]; //3
            double[] xa = new double[30]; //1
            double[] ya = new double[30]; //20 horas
            double[] za = new double[30]; //16 horas
            double[] xx = new double[30]; //eje x
            double[] sb = new double[30]; //63
            double[] tb = new double[30]; //28
            double[] ub = new double[30]; //14
            double[] vb = new double[30]; //7
            double[] wb = new double[30]; //3
            double[] xb = new double[30]; //1
            double[] yb = new double[30]; //20 horas
            double[] zb = new double[30]; //16 horas
            double[] xaa = new double[2];
            double[] C200 = new double[2];
            double xxx = 0, menor = 0, mayor = 0, mediat = 0, xxxM = 0;
            int min = int.Parse(txtMin.Text);
            int max = int.Parse(txtMax.Text);
            int[,] ren = new int[8, 150];
            int[] dic = new int[30];
            int renDatos, d1ant, reemm = 0;
            decimal[] Cemento = new decimal[30];
            int col, d1, d2, renm, dia, ren63, ren28, ren14, ren07, ren03, ren01, renx1, renx2, renr, edad, n, nt, nM;
            col = renm = ren63 = ren28 = ren14 = ren07 = ren03 = ren01 = renx1 = renx2 = renr = 0;
            string Etiqueta = " Edad", Titulo;
            double suma = 0;
            dsGraDis1.Clear();
            int erre = 0;
            for (int i = 0; i < 150; i++)
                for (int j = 0; j < 8; j++)
                {
                    ren[j, i] = 0;
                    for (int k = 0; k < 35; k++)
                    {
                        media[j, k] = 0;
                        erres[j, k] = 0;
                        enes[j, k] = 0;
                    }
                }
            sqlDACemento.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
            sqlDACemento.SelectCommand.Parameters["@FechaI"].Value = dtpIni.Text;
            sqlDACemento.SelectCommand.Parameters["@FechaF"].Value = dtpFin.Text;
            sqlDACemento.Fill(dsCementoC1, "Muestreador");

            cryInfDisTot1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cryInfDisTot1.SetDataSource(dsGraDis1);
            for (int Muest = 0; Muest < dsConCarta1.Obra.Rows.Count ; Muest++)
            {
                try
                {
                dsDatos1.Clear();
                if (int.Parse(dgConcreto[6, Muest].Value.ToString()) > 0)
                {
                    sqlDADatosT.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
                    sqlDADatosT.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                    sqlDADatosT.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                    sqlDADatosT.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
                    sqlDADatosT.SelectCommand.Parameters["@Prefijo"].Value = (rBPre3.Checked == true ? 3 : 1);
                    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 0;
                    sqlDADatosT.SelectCommand.Parameters["@ResKg"].Value = dgConcreto[0, Muest].Value;
                    sqlDADatosT.SelectCommand.Parameters["@Tipo"].Value = dsConCarta1.Obra.Rows[Muest][7].ToString();
                    sqlDADatosT.SelectCommand.Parameters["@Agr"].Value = dgConcreto[2, Muest].Value;
                    sqlDADatosT.SelectCommand.Parameters["@Rev"].Value = dgConcreto[3, Muest].Value;
                    sqlDADatosT.SelectCommand.Parameters["@IdAgr"].Value = dsConCarta1.Obra.Rows[Muest][8].ToString(); //REVISAR Y BORRAR
                    sqlDADatosT.SelectCommand.Parameters["@EE"].Value = (cbkEE.Checked ? 1 : 0);
                    sqlDADatosT.SelectCommand.Parameters["@IdDiam"].Value = dsConCarta1.Obra.Rows[Muest][9].ToString();
                    sqlDADatosT.SelectCommand.Parameters["@Id"].Value = dgConcreto[6, Muest].Value;

                    sqlDADatosT.Fill(dsDatos1, "InfDistribucion");
                    sqlDABusExpRep.SelectCommand.Parameters["@Id"].Value = dgConcreto[6, Muest].Value;
                    sqlDABusExpRep.Fill(dsGraDis1, "Agregado");
                    sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 1;
                    sqlDADatosT.Fill(dsGraDis1, "Muestras");
                    //sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 6;
                    //sqlDADatosT.Fill(dsDatos1, "Barra");
                    //sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 7;
                    //sqlDADatosT.Fill(dsGraDis1, "Estadisticos1");
                    renDatos = dsDatos1.InfDistribucion.Rows.Count;
                    if (renDatos > 0)
                    {
                        d1ant = int.Parse(dsDatos1.InfDistribucion.Rows[0]["d1"].ToString());
                        for (int i = 0; i < renDatos; i++)
                        {
                            d1 = int.Parse(dsDatos1.InfDistribucion.Rows[i]["d1"].ToString());
                            if (d1 == d1ant)
                            {
                                if (d1 == 63) reemm = 0;
                                if (d1 == 28) reemm = 1;
                                if (d1 == 14) reemm = 2;
                                if (d1 == 07) reemm = 3;
                                if (d1 == 03) reemm = 4;
                                if (d1 == 01) reemm = 5;
                                if (d1 == -1) reemm = 6;
                                if (d1 == -2) reemm = 7;

                                dia = int.Parse(dsDatos1.InfDistribucion.Rows[i]["Dia"].ToString());
                                if (dia > 6 && dia < 14)
                                    dia = dia - 1;
                                else if (dia > 13 && dia < 21)
                                    dia = dia - 2;
                                else if (dia > 20 && dia < 28)
                                    dia = dia - 3;
                                else if (dia > 27 && dia < 35)
                                    dia = dia - 4;
                                datos[reemm, ren[reemm, dia], 35] = d1;
                                datos[reemm, ren[reemm, dia]++, dia] = double.Parse(dsDatos1.InfDistribucion.Rows[i]["Resul"].ToString());
                            }
                            else
                            {
                                d1ant = d1;
                                if (d1 == 63) reemm = 0;
                                if (d1 == 28) reemm = 1;
                                if (d1 == 14) reemm = 2;
                                if (d1 == 07) reemm = 3;
                                if (d1 == 03) reemm = 4;
                                if (d1 == 01) reemm = 5;
                                if (d1 == -1) reemm = 6;
                                if (d1 == -2) reemm = 7;
                                dia = int.Parse(dsDatos1.InfDistribucion.Rows[i]["Dia"].ToString());
                                if (dia > 6 && dia < 14)
                                    dia = dia - 1;
                                else if (dia > 13 && dia < 21)
                                    dia = dia - 2;
                                else if (dia > 20 && dia < 28)
                                    dia = dia - 3;
                                else if (dia > 27 && dia < 35)
                                    dia = dia - 4;
                                datos[reemm, ren[reemm, dia], 35] = d1;
                                datos[reemm, ren[reemm, dia]++, dia] = double.Parse(dsDatos1.InfDistribucion.Rows[i]["Resul"].ToString());
                            }
                        }
                    }
                }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message );
                }
            }
            for (int j = 0; j < 8; j++)
            {
                nt = 0;
                mediat = 0;
                for (int k = 0; k < 35; k++)
                {
                    menor = 10000;
                    mayor = xxx = 0;
                    n = 0;
                    for (int i = 0; i < 150; i++)
                        if (datos[j, i, k] > 0)
                        {
                            xxx += datos[j, i, k];
                            n++;
                            nt++;
                            mediat += datos[j, i, k];
                            if (datos[j, i, k] > mayor) mayor = datos[j, i, k];
                            if (menor > datos[j, i, k]) menor = datos[j, i, k];
                        }
                    if (n > 0)
                    {
                        media[j, k] = xxx / n;
                        if (menor != 0 && mayor != 0 && mayor != menor && mayor != 10000)
                            erres[j, k] = mayor - menor;
                        enes[j, k] = n;
                    }
                }
                if (nt > 1)
                {
                    estad[j, 0] = mediat / nt;
                    estad[j, 3] = nt;
                    mediat = 0;
                    for (int k = 0; k < 35; k++)
                        for (int i = 0; i < 150; i++)
                            if (datos[j, i, k] > 0)
                                mediat += Math.Pow((datos[j, i, k] - estad[j, 0]), 2);
                    estad[j, 1] = Math.Sqrt((mediat / (nt - 1)));
                    estad[j, 2] = estad[j, 1] / estad[j, 0] * 100;
                }
            }

            //Aqui debo de borrar los menores de 15
            //for (int j = 0; j < 8; j++)
            //    if (estad[j, 3] < 15)
            //    {
            //        estad[j, 0] = estad[j, 1] = estad[j, 2] = estad[j, 3] = 0;
            //        for (int k = 0; k < 31; k++)
            //        {
            //            media[j, k] = 0;
            //            erres[j, k] = 0;
            //            erreM[j, k] = 0;
            //            for (int i = 0; i < 150; i++)
            //                datos[j, i, k] = 0;
            //        }
            //    }
            for (int j = 0; j < 8; j++)
            {
                xxx = xxxM = 0;
                n = nM = 0;
                for (int k = 0; k < 35; k++)
                {
                    if (media[j, k] > 0)
                    {
                        xxx += media[j, k];
                        n++;
                    }
                    if (k == 5 && n > 0)
                    {
                        seman[j, 5] = xxx / n;
                        xxx = 0;
                        n = 0;
                    }
                    else if (k == 11 && n > 0)
                    {
                        seman[j, 11] = xxx / n;
                        xxx = 0;
                        n = 0;
                    }
                    else if (k == 17 && n > 0)
                    {
                        seman[j, 17] = xxx / n;
                        xxx = 0;
                        n = 0;
                    }
                    else if (k == 23 && n > 0)
                    {
                        seman[j, 23] = xxx / n;
                        xxx = 0;
                        n = 0;
                    }
                    else if (k == 29 && n > 0)
                    {
                        seman[j, 29] = xxx / n;
                        xxx = 0;
                        n = 0;
                    }

                    if (erres[j, k] > 0)
                    {
                        xxxM += erres[j, k];
                        nM++;
                    }
                    if (k == 5 && nM > 0)
                    {
                        erreM[j, 5] = xxxM / nM;
                        xxxM = 0;
                        nM = 0;
                    }
                    else if (k == 11 && nM > 0)
                    {
                        erreM[j, 11] = xxxM / nM;
                        xxxM = 0;
                        nM = 0;
                    }
                    else if (k == 17 && nM > 0)
                    {
                        erreM[j, 17] = xxxM / nM;
                        xxxM = 0;
                        nM = 0;
                    }
                    else if (k == 23 && nM > 0)
                    {
                        erreM[j, 23] = xxxM / nM;
                        xxxM = 0;
                        nM = 0;
                    }
                    else if (k == 29 && nM > 0)
                    {
                        erreM[j, 29] = xxxM / nM;
                        xxxM = 0;
                        nM = 0;
                    }


                }
            }
            for (int k = 0; k < 8; k++)
            {
                Etiqueta = k.ToString();
                if (k == 0)
                    Etiqueta = "63 días";
                else if (k == 1)
                    Etiqueta = "● 28 días";
                else if (k == 2)
                    Etiqueta = "* 14 días";
                else if (k == 3)
                    Etiqueta = "▼ 7 días";
                else if (k == 4)
                    Etiqueta = "▲ 3 días";
                else if (k == 5)
                    Etiqueta = "■ 1 día";
                else if (k == 6)
                    Etiqueta = "20 horas";
                else if (k == 7)
                    Etiqueta = "16 horas";
                for (int i = 0; i < 145; i++)
                {
                    suma = 0;
                    for (int j = 0; j < 31; j++)
                        suma = suma + datos[k, i, j];
                    Titulo = System.Convert.ToString(i + 1);
                    if (suma > 0)
                        dsGraDis1.Gradis.AddGradisRow(i.ToString(), datos[k, i, 0], datos[k, i, 1], datos[k, i, 2], datos[k, i, 3], datos[k, i, 4], datos[k, i, 5], datos[k, i, 6], datos[k, i, 7], datos[k, i, 8], datos[k, i, 9], datos[k, i, 10], datos[k, i, 11],
                        datos[k, i, 12], datos[k, i, 13], datos[k, i, 14], datos[k, i, 15], datos[k, i, 16], datos[k, i, 17], datos[k, i, 18], datos[k, i, 19], datos[k, i, 20], datos[k, i, 21], datos[k, i, 22], datos[k, i, 23], datos[k, i, 24], datos[k, i, 25], datos[k, i, 26], datos[k, i, 27],
                        datos[k, i, 28], datos[k, i, 29], datos[k, i, 28], Etiqueta.Trim(), Titulo);
                }
                suma = 0;
                for (int j = 0; j < 31; j++)
                    suma = suma + media[k, j];
                if (suma > 0)
                {
                    dsGraDis1.Gradis.AddGradisRow("n", enes[k, 0], enes[k, 1], enes[k, 2], enes[k, 3], enes[k, 4], enes[k, 5], enes[k, 6], enes[k, 7], enes[k, 8], enes[k, 9], enes[k, 10], enes[k, 11],
                    enes[k, 12], enes[k, 13], enes[k, 14], enes[k, 15], enes[k, 16], enes[k, 17], enes[k, 18], enes[k, 19], enes[k, 20], enes[k, 21], enes[k, 22], enes[k, 23], enes[k, 24], enes[k, 25], enes[k, 26], enes[k, 27],
                    enes[k, 28], enes[k, 29], enes[k, 30], Etiqueta.Trim(), "n por día");
                    dsGraDis1.Gradis.AddGradisRow("M", media[k, 0], media[k, 1], media[k, 2], media[k, 3], media[k, 4], media[k, 5], media[k, 6], media[k, 7], media[k, 8], media[k, 9], media[k, 10], media[k, 11],
                    media[k, 12], media[k, 13], media[k, 14], media[k, 15], media[k, 16], media[k, 17], media[k, 18], media[k, 19], media[k, 20], media[k, 21], media[k, 22], media[k, 23], media[k, 24], media[k, 25], media[k, 26], media[k, 27],
                    media[k, 28], media[k, 29], media[k, 30], Etiqueta.Trim(), "Media");
                    dsGraDis1.Gradis.AddGradisRow("MS", seman[k, 0], seman[k, 1], seman[k, 2], seman[k, 3], seman[k, 4], seman[k, 5], seman[k, 6], seman[k, 7], seman[k, 8], seman[k, 9], seman[k, 10], seman[k, 11],
                    seman[k, 12], seman[k, 13], seman[k, 14], seman[k, 15], seman[k, 16], seman[k, 17], seman[k, 18], seman[k, 19], seman[k, 20], seman[k, 21], seman[k, 22], seman[k, 23], seman[k, 24], seman[k, 25], seman[k, 26], seman[k, 27],
                    seman[k, 28], seman[k, 29], seman[k, 30], Etiqueta.Trim(), "Media semanal");
                    dsGraDis1.Gradis.AddGradisRow("rR", erres[k, 0], erres[k, 1], erres[k, 2], erres[k, 3], erres[k, 4], erres[k, 5], erres[k, 6], erres[k, 7], erres[k, 8], erres[k, 9], erres[k, 10], erres[k, 11],
                    erres[k, 12], erres[k, 13], erres[k, 14], erres[k, 15], erres[k, 16], erres[k, 17], erres[k, 18], erres[k, 19], erres[k, 20], erres[k, 21], erres[k, 22], erres[k, 23], erres[k, 24], erres[k, 25], erres[k, 26], erres[k, 27],
                    erres[k, 28], erres[k, 29], erres[k, 30], Etiqueta.Trim(), "R");
                    dsGraDis1.Gradis.AddGradisRow("rM", erreM[k, 0], erreM[k, 1], erreM[k, 2], erreM[k, 3], erreM[k, 4], erreM[k, 5], erreM[k, 6], erreM[k, 7], erreM[k, 8], erreM[k, 9], erreM[k, 10], erreM[k, 11],
                    erreM[k, 12], erreM[k, 13], erreM[k, 14], erreM[k, 15], erreM[k, 16], erreM[k, 17], erreM[k, 18], erreM[k, 19], erreM[k, 20], erreM[k, 21], erreM[k, 22], erreM[k, 23], erreM[k, 24], erreM[k, 25], erreM[k, 26], erreM[k, 27],
                    erreM[k, 28], erreM[k, 29], erreM[k, 30], Etiqueta.Trim(), "R Semanal");
                    dsGraDis1.Estadisticos1.AddEstadisticos1Row(estad[k, 0], estad[k, 1], estad[k, 2], estad[k, 3], Etiqueta.Trim(), "Est");
                    for (int j = 0; j < 30; j++)
                        if (k == 0)
                        {
                            sa[j] = media[k, j];
                            sb[j] = erres[k, j];
                        }
                        else if (k == 1)
                        {
                            ta[j] = media[k, j];
                            tb[j] = erres[k, j];
                        }
                        else if (k == 2)
                        {
                            ua[j] = media[k, j];
                            ub[j] = erres[k, j];
                        }
                        else if (k == 3)
                        {
                            va[j] = media[k, j];
                            vb[j] = erres[k, j];
                        }
                        else if (k == 4)
                        {
                            wa[j] = media[k, j];
                            wb[j] = erres[k, j];
                        }
                        else if (k == 5)
                        {
                            xa[j] = media[k, j];
                            xb[j] = erres[k, j];
                        }
                        else if (k == 6)
                        {
                            ya[j] = media[k, j];
                            yb[j] = erres[k, j];
                        }
                        else if (k == 7)
                        {
                            za[j] = media[k, j];
                            zb[j] = erres[k, j];
                        }
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

            dias = dtpIni.Value;
            dmes = 0;
            for (int i = 0; i < 35; i++)
                if (dias.AddDays(i).DayOfWeek.ToString() != DayOfWeek.Sunday.ToString())
                {
                    DataRow foundRow = dsCementoC1.Tables["Muestreador"].Rows.Find(dias.AddDays(i).ToString().Substring(0, 10));
                    if (foundRow != null)
                    {
                        Cemento[dmes] = Decimal.Parse(foundRow["Cemento"].ToString());
                    }
                    else
                    {
                        //                MessageBox.Show(foundRow[0].ToString());
                    }
                    dmes++;
                }
            dsGraDis1.Cemento.AddCementoRow(Cemento[0], Cemento[1], Cemento[2], Cemento[3],
                Cemento[4], Cemento[5], Cemento[6], Cemento[7], Cemento[8], Cemento[9], Cemento[10], Cemento[11],
                Cemento[12], Cemento[13], Cemento[14], Cemento[15], Cemento[16], Cemento[17], Cemento[18], Cemento[19],
                Cemento[20], Cemento[21], Cemento[22], Cemento[23], Cemento[24], Cemento[25], Cemento[26], Cemento[27],
                Cemento[28], Cemento[29]);

            memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
                this.ClientRectangle.Width, this.ClientRectangle.Height);

            myPane = new GraphPane(new Rectangle(10, 10, 10, 10),
                "", "", "");
            SetSize();

            for (int j = 0; j < 30; j++)
                xx[j] = j + 1;

            CurveItem curve;
            curve = myPane.AddCurve("63 días", xx, sa, Color.DarkCyan, SymbolType.Diamond);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.DarkCyan);
            for (int j = 29; j >= 0; j--)
                if (sa[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("28 días", xx, ta, Color.Black, SymbolType.Circle);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.Black);
            for (int j = 29; j >= 0; j--)
                if (ta[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("14 días", xx, ua, Color.DarkOliveGreen, SymbolType.Star);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.DarkOliveGreen);
            for (int j = 29; j >= 0; j--)
                if (ua[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("7 días", xx, va, Color.Blue, SymbolType.TriangleDown);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.Empty);
            for (int j = 29; j >= 0; j--)
                if (va[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("3 días", xx, wa, Color.Brown, SymbolType.Triangle);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.Empty);
            for (int j = 29; j >= 0; j--)
                if (wa[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("1 día", xx, xa, Color.Red, SymbolType.Square);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.Red);
            curve.Symbol.Size = 8;
            for (int j = 29; j >= 0; j--)
                if (xa[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("20 horas", xx, ya, Color.DarkGreen, SymbolType.Diamond);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.DarkGreen);
            curve.Symbol.Size = 8;
            for (int j = 29; j >= 0; j--)
                if (ya[j] == 0)
                    curve.Points.Remove(j);
            curve = myPane.AddCurve("16 horas", xx, za, Color.DarkOrange, SymbolType.Circle);
            curve.Line.Width = 2.5F;
            curve.Symbol.Fill = new Fill(Color.DarkOrange);
            curve.Symbol.Size = 8;
            for (int j = 29; j >= 0; j--)
                if (za[j] == 0)
                    curve.Points.Remove(j);

            //			curve.IsY2Axis = true;
            //			curve.Line.IsSmooth = true;
            if (cbkR3.Checked == false)
            {
                curve = myPane.AddCurve("R 63", xx, sb, Color.DarkCyan, SymbolType.Diamond);
                curve.Line.Width = 1.0F;
                curve.Symbol.Fill = new Fill(Color.DarkCyan);
                curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
                for (int j = 29; j >= 0; j--)
                    if (sb[j] == 0)
                        curve.Points.Remove(j);
                curve = myPane.AddCurve("R 28", xx, tb, Color.Black, SymbolType.Circle);
                curve.Line.Width = 1.0F;
                curve.Symbol.Fill = new Fill(Color.Black);
                curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
                for (int j = 29; j >= 0; j--)
                    if (tb[j] == 0)
                        curve.Points.Remove(j);
                curve = myPane.AddCurve("R 14", xx, ub, Color.DarkOliveGreen, SymbolType.Star);
                curve.Line.Width = 1.0F;
                curve.Symbol.Fill = new Fill(Color.DarkOliveGreen);
                curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
                for (int j = 29; j >= 0; j--)
                    if (ub[j] == 0)
                        curve.Points.Remove(j);
            }
            curve = myPane.AddCurve("R 7", xx, vb, Color.Blue, SymbolType.TriangleDown);
            curve.Line.Width = 1.0F;
            curve.Symbol.Fill = new Fill(Color.Blue);
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
            for (int j = 29; j >= 0; j--)
                if (vb[j] == 0)
                    curve.Points.Remove(j);
            Double MereEE = 0;
            Double DEreEE = 0;
            Double NEreEE = 0;

            for (int j = 29; j >= 0; j--)
                if (vb[j] != 0)
                {
                    MereEE += vb[j];
                    NEreEE++;
                }
            if (NEreEE > 0)
                MereEE = MereEE / NEreEE;

            mediat = 0;
            for (int j = 29; j >= 0; j--)
                if (vb[j] != 0)
                    mediat += Math.Pow((vb[j] - MereEE), 2);

            if (NEreEE > 0)
                DEreEE = Math.Sqrt((mediat / (NEreEE - 1)));

            if (cbkR3.Checked == false)
            {
                curve = myPane.AddCurve("R 3", xx, wb, Color.Brown, SymbolType.Triangle);
                curve.Line.Width = 1.0F;
                curve.Symbol.Fill = new Fill(Color.Brown);
                curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
                for (int j = 29; j >= 0; j--)
                    if (wb[j] == 0)
                        curve.Points.Remove(j);
                curve = myPane.AddCurve("R 1", xx, xb, Color.Red, SymbolType.Square);
                curve.Line.Width = 1.0F;
                curve.Symbol.Fill = new Fill(Color.Red);
                curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
                for (int j = 29; j >= 0; j--)
                    if (xb[j] == 0)
                        curve.Points.Remove(j);
                curve = myPane.AddCurve("R 20h", xx, yb, Color.DarkGreen, SymbolType.Diamond);
                curve.Line.Width = 1.0F;
                curve.Symbol.Fill = new Fill(Color.DarkGreen);
                curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
                for (int j = 29; j >= 0; j--)
                    if (yb[j] == 0)
                        curve.Points.Remove(j);
                curve = myPane.AddCurve("R 16h", xx, zb, Color.DarkOrange, SymbolType.Circle);
                curve.Line.Width = 1.0F;
                curve.Symbol.Fill = new Fill(Color.DarkOrange);
                curve.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
                for (int j = 29; j >= 0; j--)
                    if (zb[j] == 0)
                        curve.Points.Remove(j);
            }
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
            C200[0] = 120;
            C200[1] = 120;
            curve = myPane.AddCurve("C120", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 1.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            //			curve.IsY2Axis = true;
            xaa[0] = 6.5;
            xaa[1] = 6.5;
            C200[0] = min;
            C200[1] = max;
            curve = myPane.AddCurve("C6.5", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 4.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            xaa[0] = 12.5;
            xaa[1] = 12.5;
            C200[0] = min;
            C200[1] = max;
            curve = myPane.AddCurve("C13.5", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 4.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            xaa[0] = 18.5;
            xaa[1] = 18.5;
            C200[0] = min;
            C200[1] = max;
            curve = myPane.AddCurve("C20.5", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 4.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;
            xaa[0] = 24.5;
            xaa[1] = 24.5;
            C200[0] = min;
            C200[1] = max;
            curve = myPane.AddCurve("C13.5", xaa, C200, Color.Black, SymbolType.Empty);
            curve.Line.Width = 4.0F;
            curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.FrameColor = Color.White;


            /*			myPane.Y2Axis.IsShowGrid = true;
                        myPane.Y2Axis.Step = 10;
                        myPane.Y2Axis.Min = 0;
                        myPane.Y2Axis.Max = (max - min);
                        myPane.Y2Axis.IsVisible = true;
                        myPane.Y2Axis.ScaleFontSpec.Size = 6;
            */
            myPane.XAxis.IsShowGrid = true;
            myPane.XAxis.IsTic = true;
            myPane.XAxis.ScaleFontSpec.Angle = 0;
            myPane.XAxis.Min = 0;
            myPane.XAxis.Max = 30;
            myPane.XAxis.IsVisible = false;
            myPane.YAxis.IsShowGrid = true;
            myPane.YAxis.ScaleFontSpec.Angle = 90;
            myPane.YAxis.Min = min;
            myPane.YAxis.Max = max;
            myPane.FontSpec.Size = 12;

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
                "", "", "");
            SetSize1();

//            renDatos = dsDatos1.Barra.Rows.Count;
//            int renmc = (renDatos > 31 ? renDatos : 31);
            for (int j = 0; j < 8; j++)
                for (int k = 0; k < 31; k++)
                    for (int i = 0; i < 150; i++)
                        datos[j, i, k] = 0;

            for (int Muest = 0; Muest < dsConCarta1.Obra.Rows.Count; Muest++)
            {
                try
                {
                    dsDatos1.Clear();
                    if (int.Parse(dgConcreto[6, Muest].Value.ToString()) > 0)
                    {
                        sqlDADatosT.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
                        sqlDADatosT.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                        sqlDADatosT.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                        sqlDADatosT.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
                        sqlDADatosT.SelectCommand.Parameters["@Prefijo"].Value = (rBPre3.Checked == true ? 3 : 1);
                        sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 8;
                        sqlDADatosT.SelectCommand.Parameters["@ResKg"].Value = dgConcreto[0, Muest].Value;
                        sqlDADatosT.SelectCommand.Parameters["@Tipo"].Value = dsConCarta1.Obra.Rows[Muest][7].ToString();
                        sqlDADatosT.SelectCommand.Parameters["@Agr"].Value = dgConcreto[2, Muest].Value;
                        sqlDADatosT.SelectCommand.Parameters["@Rev"].Value = dgConcreto[3, Muest].Value;
                        sqlDADatosT.SelectCommand.Parameters["@EE"].Value = 1; // (cbkEE.Checked ? 1 : 0);
                        sqlDADatosT.SelectCommand.Parameters["@IdAgr"].Value = dsConCarta1.Obra.Rows[Muest][8].ToString(); //REVISAR Y BORRAR
                        sqlDADatosT.SelectCommand.Parameters["@Id"].Value = dgConcreto[6, Muest].Value;
                        sqlDADatosT.SelectCommand.Parameters["@IdDiam"].Value = dsConCarta1.Obra.Rows[Muest][9].ToString();
                        sqlDADatosT.Fill(dsDatos1, "InfDistribucion");

                        renDatos = dsDatos1.InfDistribucion.Rows.Count;
                        if (renDatos > 0)
                        {
                            d1ant = int.Parse(dsDatos1.InfDistribucion.Rows[0]["d1"].ToString());
                            for (int i = 0; i < renDatos; i++)
                            {
                                d1 = int.Parse(dsDatos1.InfDistribucion.Rows[i]["d1"].ToString());
                                if (d1 == d1ant)
                                {
                                    if (d1 == 63) reemm = 0;
                                    if (d1 == 28) reemm = 1;
                                    if (d1 == 14) reemm = 2;
                                    if (d1 == 07) reemm = 3;
                                    if (d1 == 03) reemm = 4;
                                    if (d1 == 01) reemm = 5;
                                    if (d1 == -1) reemm = 6;
                                    if (d1 == -2) reemm = 7;

                                    dia = int.Parse(dsDatos1.InfDistribucion.Rows[i]["Dia"].ToString());
                                    if (dia > 6 && dia < 14)
                                        dia = dia - 1;
                                    else if (dia > 13 && dia < 21)
                                        dia = dia - 2;
                                    else if (dia > 20 && dia < 28)
                                        dia = dia - 3;
                                    else if (dia > 27 && dia < 35)
                                        dia = dia - 4;
                                    datos[reemm, ren[reemm, dia], 35] = d1;
                                    datos[reemm, ren[reemm, dia]++, dia] = double.Parse(dsDatos1.InfDistribucion.Rows[i]["Resul"].ToString());
                                }
                                else
                                {
                                    d1ant = d1;
                                    if (d1 == 63) reemm = 0;
                                    if (d1 == 28) reemm = 1;
                                    if (d1 == 14) reemm = 2;
                                    if (d1 == 07) reemm = 3;
                                    if (d1 == 03) reemm = 4;
                                    if (d1 == 01) reemm = 5;
                                    if (d1 == -1) reemm = 6;
                                    if (d1 == -2) reemm = 7;
                                    dia = int.Parse(dsDatos1.InfDistribucion.Rows[i]["Dia"].ToString());
                                    if (dia > 6 && dia < 14)
                                        dia = dia - 1;
                                    else if (dia > 13 && dia < 21)
                                        dia = dia - 2;
                                    else if (dia > 20 && dia < 28)
                                        dia = dia - 3;
                                    else if (dia > 27 && dia < 35)
                                        dia = dia - 4;
                                    datos[reemm, ren[reemm, dia], 35] = d1;
                                    datos[reemm, ren[reemm, dia]++, dia] = double.Parse(dsDatos1.InfDistribucion.Rows[i]["Resul"].ToString());
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message );
                }
            }

            Double MedEE = 0;
            Double DesRE = 0;
            Double EneEE = 0;
            int renmc = 35;
            double[] xxa = new double[renmc];
            double[] yya = new double[renmc];
            for (int i = 0; i < renmc; i++)
            {
                xxa[i] = i * 10;
                yya[i] = 0;
            }
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 31; k++)
                {
                    for (int i = 0; i < 150; i++)
                        if (datos[j, i, k] > 0)
                        {
                            n = System.Convert.ToInt32(Math.Round(datos[j, i, k] / 10, 1));
                            if (0 < n && n < 35)
                            {
                                yya[n] = yya[n] + 1;
                                MedEE += datos[j, i, k];
                                EneEE++;
                            }
                        }
                }
            }
            if (EneEE > 0)
                MedEE = MedEE / EneEE;
            mediat = 0;
            for (int j = 0; j < 8; j++)
                for (int k = 0; k < 31; k++)
                    for (int i = 0; i < 150; i++)
                        if (datos[j, i, k] > 0)
                        {
                            n = System.Convert.ToInt32(Math.Round(datos[j, i, k] / 10, 1));
                            if (0 < n && n < 35)
                                mediat += Math.Pow((datos[j, i, k] - MedEE), 2);
                        }

            if (EneEE > 0)
                DesRE = Math.Sqrt((mediat / (EneEE - 1)));

            CurveItem curve1;
            curve1 = myPane1.AddBar("Cantidad", yya, xxa, Color.Black);
            for (int j = 31; j >= 0; j--)
                if (xxa[j] == 0)
                    curve1.Points.Remove(j);

            curve1.Bar.FrameWidth = 10.0F;
            curve1.Symbol.Fill = new Fill(Color.Blue);
            myPane1.BarBase = BarBase.Y;
//            myPane1.XAxis.ScaleFontSpec.Angle = 90;
            myPane1.YAxis.Min = 0;
            myPane1.YAxis.Max = 350;
//            myPane1.XAxis.MaxAuto = true;
//            myPane1.XAxis.ScaleFontSpec.Size = 10;
            myPane1.XAxis.IsVisible = false;
            myPane1.XAxis.IsShowGrid = false;
            myPane1.YAxis.IsShowGrid = false;
//            myPane1.YAxis.ScaleFontSpec.Angle = 90;
            myPane1.XAxis.Min = 0;
            myPane1.XAxis.Max = System.Convert.ToInt32(yya.Max()*10 + 50)/10;
            //            myPane1.YAxis.v
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

            sqlDADatosT.SelectCommand.Parameters["@IdReporte"].Value = 5;
            sqlDADatosT.Fill(dsGraDis1, "Estadisticos");

            crvGraDis.Visible = true;
            cryInfDisTot1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLegal;
            cryInfDisTot1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
            cryInfDisTot1.SetParameterValue("@Obr", (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%"));
            cryInfDisTot1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
            cryInfDisTot1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
            cryInfDisTot1.SetParameterValue("@Fecha", dtpIni.Value.AddDays(20));
            cryInfDisTot1.SetParameterValue("ObrOCon", false);
            cryInfDisTot1.SetParameterValue("Resumen", cbkResumen.Checked);
            cryInfDisTot1.SetParameterValue("Detalle", cbkDetalle.Checked);
            cryInfDisTot1.SetParameterValue("MedEE", MedEE);
            cryInfDisTot1.SetParameterValue("DevEE", DesRE);
            cryInfDisTot1.SetParameterValue("MereEE", MereEE);
            cryInfDisTot1.SetParameterValue("DEreEE", DEreEE);

            crvGraDis.ReportSource = cryInfDisTot1;

        }

        private void dtpIni_ValueChanged(object sender, EventArgs e)
        {
            dtpFin.Value = dtpIni.Value.AddDays(33);
            dsConCarta1.Clear();
            sqlDAConcretos.SelectCommand.Parameters["@IdObra"].Value = (rBPre1.Checked == true ? cmbIdObra.SelectedValue.ToString() : cmbIdObra.SelectedValue.ToString() + "%");
            sqlDAConcretos.SelectCommand.Parameters["@Cuantas"].Value = txtMinimo.Text.Trim();
            sqlDAConcretos.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Value.ToShortDateString();
            sqlDAConcretos.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Value.ToShortDateString(); ;
            sqlDAConcretos.Fill(dsConCarta1, "Obra");
            dgConcreto.Visible = true;
            dgExperiencia.Visible = true;
            crvGraDis.Visible = false;
        }

        private void crvGraDis_Leave(object sender, EventArgs e)
        {
            crvGraDis.Visible = false;
            dgConcreto.Visible = true;
            dgExperiencia.Visible = true;
        }

        private void tbBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();
                sqlComInsertaExp.Parameters["@ResistenciaKG"].Value = dsConCarta1.Obra.Rows[filaCon][0].ToString().Trim();
                sqlComInsertaExp.Parameters["@Tipo"].Value = dsConCarta1.Obra.Rows[filaCon][7].ToString().Trim();
                sqlComInsertaExp.Parameters["@Agregado"].Value = dsConCarta1.Obra.Rows[filaCon][2].ToString().Trim();
                sqlComInsertaExp.Parameters["@Renvenimiento"].Value = dsConCarta1.Obra.Rows[filaCon][3].ToString().Trim();
                sqlComInsertaExp.Parameters["@IdAgregado"].Value = dsConCarta1.Obra.Rows[filaCon][8].ToString().Trim();
                sqlComInsertaExp.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
                sqlComInsertaExp.Parameters["@d3a7"].Value = dgExperiencia[10, filaExp].Value;
                sqlComInsertaExp.Parameters["@d3aEE"].Value = dgExperiencia[11, filaExp].Value;
                sqlComInsertaExp.Parameters["@d7aEE"].Value = dgExperiencia[12, filaExp].Value;
                sqlComInsertaExp.Parameters["@Diametro"].Value = dsConCarta1.Obra.Rows[filaCon][10].ToString().Trim() + dsConCarta1.Obra.Rows[filaCon][11].ToString().Trim();
                sqlComInsertaExp.Parameters["@dAr1"].Value = dgExperiencia[13, filaExp].Value;
                sqlComInsertaExp.Parameters["@dAr2"].Value = dgExperiencia[14, filaExp].Value;
                sqlComInsertaExp.Parameters["@dAr3"].Value = dgExperiencia[15, filaExp].Value;

                int error = sqlComInsertaExp.ExecuteNonQuery();
//                MessageBox.Show("Proceso terminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            experiencia();
        }

        private void dgExperiencia_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
//                               dsBusExpCar1.Tables[0].Rows[filaCon][0] = 0;
            try
            {
                e.Row.Cells[0].Value = 0;
            }
            catch (Exception ex)
            {
            }
            e.Row.Cells[1].Value = dsConCarta1.Obra.Rows[filaCon][0].ToString().Trim();
            e.Row.Cells[2].Value = "LANC";
            e.Row.Cells[6].Value = dsConCarta1.Obra.Rows[filaCon][1].ToString().Trim();
            e.Row.Cells[7].Value = dsConCarta1.Obra.Rows[filaCon][2].ToString().Trim();
            e.Row.Cells[8].Value = dsConCarta1.Obra.Rows[filaCon][3].ToString().Trim();
            e.Row.Cells[9].Value = dsConCarta1.Obra.Rows[filaCon][4].ToString().Trim();
        }

        private void dgExperiencia_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }


    }
}
