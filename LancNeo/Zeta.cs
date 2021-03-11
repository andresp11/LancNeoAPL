using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
namespace LancNeo
{
    public partial class Zeta : Form
    {
        private string IdUsuario;
        static DateTime fini;
        static DateTime ffin;
        static int ai = 0;
        static int si = 0;
        static int af = 0;
        static int sf = 0;

        public Zeta()
        {
            InitializeComponent();
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            btnVistaPrevia.Visible = true;
            try
            {
                DataSet ds = new DataSet();
                sqlDADuracion.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString().Trim();
                sqlDADuracion.Fill(ds);
                if (ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    fini = DateTime.Parse(ds.Tables[0].Rows[0][0].ToString());
                    ffin = DateTime.Parse(ds.Tables[0].Rows[0][1].ToString());
                }
                else
                {
                    fini = DateTime.Today.AddDays(-30);
                    ffin = DateTime.Today;
                }
                lblDuracion.Text = Math.Floor(Math.Abs((fini - ffin).TotalDays / 7) + 1).ToString();
                dsZetaObras1.Clear();
                sqlDAObras.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString().Trim().Substring(0, 3);
                sqlDAObras.Fill(dsZetaObras1, "Obra");
                dsZetaSolicitud1.Clear();
                sqlDASolicitud.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString().Trim();
                sqlDASolicitud.Fill(dsZetaSolicitud1, "Solicitud");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for (int i = 0; i < dGVPresupuesto.RowCount; i++)
                dGVPresupuesto.Rows[i].Cells[7].Value = 0;
        }

        private void Zeta_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            this.WindowState = FormWindowState.Maximized;
            sqlDABusObra.Fill(dsDGObra1, "Obra");

        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            string IdObraM = "zzzzzz";
            for (int i = 0; i < dGVObras.RowCount; i++)
                if (dGVObras.Rows[i].Cells[1].Value.ToString() != "0" && dGVObras.Rows[i].Cells[2].Value.ToString() != "0")
                    IdObraM = dGVObras.Rows[i].Cells[0].Value.ToString().Trim();
            decimal D14 = 0, D16 = 0, D17 = 0;
            int SemCol = 0;
            int[] SSCol = new int[13];
            int SemCIni = 0;
            int SemCFin = 0;
            int añoCIni = 0;
            int añoCFin = 0;
            int residuo = 0;
            string años = "      ";
            crvResumen.Visible = true;
            cryZeta1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryZeta1.SetDataSource(dsZeta1);
            decimal[,,] tot = new decimal[50, 19, 3];
            decimal[] tot1 = new decimal[19];
            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 19; j++)
                    for (int k = 0; k < 3; k++)
                        tot[i, j, k] = 0;
            decimal[,] totd = new decimal[19, 3];
            for (int i = 0; i < 19; i++)
            {
                tot1[i] = 0;
                for (int j = 0; j < 3; j++)
                    totd[i, j] = 0;
            }
            int[] tdias = new int[13];
            for (int i = 0; i < 13; i++)
                tdias[i] = 0;
            int[] diaSem = new int[14];
            for (int i = 0; i < 14; i++)
                diaSem[i] = 0;
            string[,] semana = new string[13, 2];
            dsZeta1.Clear();
            dsPrevioZ1.Clear();
            int Sn = si;
            int An = ai;
            int Desfase = 0;
            for (int jjj = 0; jjj < 500; jjj++)
            {
                if (Sn == int.Parse(nUDSi.Value.ToString()) && An == int.Parse(txtAi.Text))
                {
                    Desfase = jjj;
                    break;
                }
                Sn++;
                if (Sn > 52)
                {
                    Sn = 1;
                    An = An + 1;
                }
            }

            try
            {
                sqlDAZeta.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim();
                sqlDAZeta.Fill(dsPrevioZ1, "Obra");
                sqlDAConcepto.Fill(dsZeta1, "Concepto");
                //sqlDASECIERRA.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim();
                //sqlDASECIERRA.Fill(dsZeta1, "Obra");
                sqlDAVivienda.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim();
                sqlDAVivienda.Fill(dsZeta1, "Vivienda");
                sqlDAPresupuestoz.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim();
                sqlDAPresupuestoz.Fill(dsZeta1, "Obra");
                if (dsZeta1.Obra.Rows.Count > 1)
                {
                    for (int i = 1; i < dsZeta1.Obra.Rows.Count; i++)
                    {
                        dsZeta1.Obra.Rows[0][5] = double.Parse(dsZeta1.Obra.Rows[0][5].ToString()) + double.Parse(dsZeta1.Obra.Rows[i][5].ToString());
                        dsZeta1.Obra.Rows[0][6] = double.Parse(dsZeta1.Obra.Rows[0][6].ToString()) + double.Parse(dsZeta1.Obra.Rows[i][6].ToString());
                        dsZeta1.Obra.Rows[0][7] = double.Parse(dsZeta1.Obra.Rows[0][7].ToString()) + double.Parse(dsZeta1.Obra.Rows[i][7].ToString());
                    }
                    int ICuantos = dsZeta1.Obra.Rows.Count - 1;
                    for (int i = ICuantos; i > 0; i--)
                        dsZeta1.Obra.Rows.RemoveAt(i);
                    if (!chkPU.Checked)
                    {
                        dsZeta1.Obra.Rows[0][5] = 0;
                        dsZeta1.Obra.Rows[0][6] = 0;
                        //dsZeta1.Obra.Rows[0][7] = 0;
                    }
                }
                if (dsZeta1.Obra.Rows.Count == 0)
                    dsZeta1.Obra.AddObraRow(txtIdobra.Text.Trim(), "01/01", 0, " ", 10, 0, 0, 0, 0, 0, 0, "");

                SemCol = int.Parse(cmbDurSem.Text);
                for (int i = 0; i < 13; i++)
                    SSCol[i] = SemCol;
                if (SemCol == 5)
                {
                    SSCol[2] = SSCol[5] = SSCol[8] = SSCol[11] = 4;
                    SSCol[3] = SSCol[6] = SSCol[9] = SSCol[12] = 5;
                    SSCol[4] = SSCol[7] = SSCol[10] = 4;

                }
                if (SemCol == 8)
                {
                    SSCol[2] = SSCol[5] = SSCol[8] = SSCol[11] = 9;
                    SSCol[3] = SSCol[6] = SSCol[9] = SSCol[12] = 9;
                    SSCol[4] = SSCol[7] = SSCol[10] = 8;

                }
                int Reng = -1;
                int IdConcepto = -1;
                double Colu = 0;
                double Colo = 0;
                double SeIn = Double.Parse(txtBimIni.Text);
                double SeSe = Double.Parse(txtBimSeg.Text);
                int Colum = 0;
                double Colf = 0;
                decimal Cantidad;
                decimal PreUni;
                int soldadura = 0;
                int RengSol = 0;
                DateTime SemIni = DateTime.Now;
                DateTime SemFin = DateTime.Now;
                DateTime Finicial;
                DateTime Ffinal;
                TimeSpan dias;
                double x = 0;
                try
                {
                    // 15 = IdConcepto; 14 = Total 12/12/2018 //14 = IdConcepto; 13 = Total
                    foreach (DataRow dr in dsPrevioZ1.Tables["Obra"].Rows)
                    {
                        if (dr["SemCons"].ToString().Trim() == "1")
                            SemIni = DateTime.Parse(dr["Fecha"].ToString());
                        if (IdConcepto != int.Parse(dr["IdConcepto"].ToString()))
                        {
                            Reng++;
                            IdConcepto = int.Parse(dr["IdConcepto"].ToString());
                            if (910 <= IdConcepto && IdConcepto <= 990 && soldadura == 0)
                            {
                                tot[Reng, 15, 0] = 900;
                                tot[Reng, 15, 1] = 900;
                                tot[Reng, 15, 2] = 900;
                                RengSol = Reng;
                                Reng++;
                                soldadura = 1;
                            }
                            tot[Reng, 15, 0] = IdConcepto;
                            tot[Reng, 15, 1] = IdConcepto;
                            tot[Reng, 15, 2] = IdConcepto;
                        }
                        Colu = double.Parse(dr["SemCons"].ToString()) - Desfase;
                        Colo = double.Parse(dr["SemCons"].ToString());
                        if (Colu <= SeIn)
                        {
                            Colum = (Colo == 0 ? 0 : (Colu >= 1 ? 1 : 18));
                        }
                        else if (SeIn < Colu && Colu <= (SeIn + SeSe))
                        {
                            Colum = 2;
                        }
                        else
                        {
                            Colum = -1;
                            int SeIni = int.Parse(SeIn.ToString());
                            int SeSei = int.Parse(SeSe.ToString());
                            int Dividendo = int.Parse(Colu.ToString()) - (SeIni + SeSei);
                            int Zi = 1;
                            int Zf = 0;
                            for (int z = 2; z < 13; z++)
                            {
                                Zf = Zi + SSCol[z] - 1;
                                if (Zi <= Dividendo && Dividendo <= Zf)
                                {
                                    Colum = z + 1;
                                    break;

                                }
                                Zi += SSCol[z];
                            }

                            //int Dividendo = int.Parse(Colu.ToString()) - (SeIni + SeSei);
                            //Colf = Math.DivRem(Dividendo, SemCol, out residuo);
                            //Colf = Colf + (residuo > 0 ? 1 : 0) + 2;
                            //Colum = System.Convert.ToInt32(Colf);
                        }
                        if (Colum < 14 && Colum != -1)
                        {
                            tot[Reng, Colum, 0] += decimal.Parse(dr["Cantidad"].ToString());
                            if (chkPU.Checked)
                            {
                                tot[Reng, Colum, 1] = decimal.Parse(dr["PreUni"].ToString());
                                tot[Reng, Colum, 2] += (decimal.Parse(dr["Cantidad"].ToString()) * decimal.Parse(dr["PreUni"].ToString()));
                            }
                            else
                            {
                                tot[Reng, Colum, 1] = 0;
                                tot[Reng, Colum, 2] += 0;
                            }
                            if (IdConcepto == 14)
                                residuo = 0;
                        }
                        else
                        {
                            //Cantidad = decimal.Parse(dr["Cantidad"].ToString());
                            //PreUni = decimal.Parse(dr["PreUni"].ToString());
                            //tot[Reng, 13, 0] += Cantidad;
                            //tot[Reng, 13, 1] = PreUni;
                            //tot[Reng, 13, 2] += (Cantidad * PreUni);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




                for (int i = 0; i < 13; i++)
                {
                    int ii = (i - int.Parse(SeIn.ToString()) + 1);
                    if (i == 0)
                    {
                        Finicial = SemIni.AddDays(+7);
                        Ffinal = Finicial.AddDays(((SeIn) * 7) - 3);
                        SemCIni = int.Parse(nUDSi.Value.ToString());
                        añoCIni = int.Parse(txtAi.Text) - 2000;
                        añoCFin = añoCIni;
                        SemCFin = (SemCIni + int.Parse(SeIn.ToString()) - 1);
                        if (SemCFin > 52)
                        {
                            añoCFin++;
                            SemCFin = SemCFin - 52;
                        }
                        semana[i, 0] = añoCIni.ToString() + " - " + SemCIni.ToString();
                        semana[i, 1] = (añoCIni == añoCFin ? "      " : añoCFin.ToString() + " - ") + SemCFin.ToString();
                    }
                    else if (i == 1)
                    {
                        SemCIni += int.Parse(SeIn.ToString());
                        if (SemCIni > 52)
                        {
                            añoCIni++;
                            SemCIni = SemCIni - 52;
                        }
                        añoCFin = añoCIni;
                        SemCFin = (SemCIni + int.Parse(SeSe.ToString()) - 1);
                        if (SemCFin > 52)
                        {
                            añoCFin++;
                            SemCFin = SemCFin - 52;
                            //                            añoCFin = añoCIni;
                        }
                        if (añoCIni != añoCFin)
                            años = añoCIni.ToString() + " - ";
                        else
                            años = "     ";
                        if (añoCIni != int.Parse(semana[i - 1, 0].Substring(0, 2)))
                            años = añoCIni.ToString() + " - ";
                        else
                            años = "     ";
                        Finicial = SemIni.AddDays((i * SemCol * 7) - 6);
                        Ffinal = Finicial.AddDays(((SeSe) * 7) - 3);
                        semana[i, 0] = años + SemCIni;
                        semana[i, 1] = (añoCIni == añoCFin ? "      " : añoCFin.ToString() + " - ") + SemCFin.ToString();
                        añoCFin = añoCIni;
                        SemCIni += int.Parse(SeSe.ToString());
                    }
                    else
                    {
                        if (SemCIni > 52)
                        {
                            añoCIni++;
                            SemCIni = SemCIni - 52;
                        }
                        añoCFin = añoCIni;
                        //                        SemCFin = (SemCIni + int.Parse(SemCol.ToString()) - 1);
                        SemCFin = (SemCIni + SSCol[i] - 1);
                        if (SemCFin > 52)
                        {
                            añoCFin++;
                            SemCFin = SemCFin - 52;
                        }
                        if (añoCIni != añoCFin || SemCIni == 1)
                            años = añoCIni.ToString() + " - ";
                        else
                            años = "     ";
                        //                        Finicial = SemIni.AddDays(((i * SemCol + (SeIn - SemCol)) * 7) - 6);
                        //                        Ffinal = Finicial.AddDays((SemCol * 7) - 3);
                        Finicial = SemIni.AddDays(((i * SSCol[i] + (SeIn - SemCol)) * 7) - 6);
                        Ffinal = Finicial.AddDays((SSCol[i] * 7) - 3);
                        semana[i, 0] = años + SemCIni;
                        semana[i, 1] = (añoCIni == añoCFin ? "      " : añoCFin.ToString() + " - ") + SemCFin.ToString();
                        añoCFin = añoCIni;
                        //                        SemCIni += int.Parse(SemCol.ToString());
                        SemCIni += SSCol[i];
                    }
                    if (Ffinal > SemFin)
                        Ffinal = SemFin;
                    dias = Ffinal.Subtract(Finicial);
                    x = dias.Days;
                    ii = (i < int.Parse(SeIn.ToString()) ? 0 : ii);
                    tdias[i] = int.Parse(Math.Round((x > 0 ? x / 7 : 0), 0).ToString());
                    if (Ffinal == SemFin)
                        i = 14;
                }
                //decimal promedio = 0;
                //for (int i = 0; i < 50; i++)
                //    if (tot[i, 15, 0] >= 2 && tot[i, 15, 0] <= 6)
                //    {
                //        promedio = 0;
                //        for (int j = 1; j < 13; j++)
                //            if (tot[i, j, 0] != 0)
                //            {
                //                if (j == 1) promedio += tot[i, j, 0] / int.Parse(txtBimIni.Text);
                //                if (j == 2) promedio += tot[i, j, 0] / int.Parse(txtBimSeg.Text);
                //                if (j > 2) promedio += tot[i, j, 0] / int.Parse(cmbDurSem.Text);
                //            }
                //        tot[i, 14, 0] = promedio;
                //    }
                int i28 = 0;
                int i29 = 0;
                int i140 = 0;
                int i640 = 0;
                int i110 = 0;
                //Sumar adicionales
                for (int i = 0; i < 50; i++)
                {
                    if (tot[i, 15, 0] == 14) i28 = i;
                    if (tot[i, 15, 0] == 16) i29 = i;
                    if (tot[i, 15, 0] == 140) i140 = i;
                    if (tot[i, 15, 0] == 110) i110 = i;
                    if (tot[i, 15, 0] == 640)
                    {
                        i640 = i;
                        tot[i, 1, 0] = 1;
                        tot[i, 14, 0] = 0;
                        tot[i, 1, 1] = tot[i, 0, 1];
                        tot[i, 14, 1] = 0;
                        tot[i, 1, 2] = tot[i, 0, 2];
                        tot[i, 14, 2] = 0;
                    }
                    if (tot[i, 15, 0] == 28)
                        for (int j = 1; j < 14; j++)
                            tot[i28, j, 0] += tot[i, j, 0];
                    if (tot[i, 15, 0] == 29)
                        for (int j = 1; j < 14; j++)
                            tot[i29, j, 0] += tot[i, j, 0];
                }
                //Aqui elimina calas de semanas trabajadas
                if (i29 != 0 && i140 != 0)
                    for (int j = 1; j < 14; j++)
                        for (int k = 0; k < 3; k++)
                            if (tot[i29, j, k] != 0)
                                tot[i140, j, k] = 0;

                if (soldadura == 1)
                    for (int i = RengSol + 1; i < 50; i++)
                        for (int j = 0; j < 14; j++)
                            for (int k = 2; k < 3; k++)
                                if (900 < tot[Reng, 15, k] && tot[Reng, 15, k] <= 990)
                                    tot[RengSol, j, k] += tot[i, j, k];

                for (int i = 0; i < 50; i++)
                {
                    for (int j = 1; j < 14; j++)
                        for (int k = 0; k < 3; k++)
                        {
                            if (tot[i, 15, 0] == 25 && tot[i, j, 0] > 13 && k == 0) //que pasa aqui
                                tot[i, j, 0] = 13;
                            tot[i, 14, k] += tot[i, j, k];
                            if (tot[i, 15, k] != 28 && tot[i, 15, k] != 29 && tot[i, 15, k] != 26 && tot[i, 15, k] != 27 && tot[i, 15, k] != 20 && tot[i, 15, k] != 110 && tot[i, 15, k] != 140) // && tot[i, 15, k] != 110
                                tot[i, 16, k] += tot[i, j, k];
                            //if (tot[i, 1, k] != 10 && tot[i, 14, k] != 26 && tot[i, 14, k] != 27 && tot[i, 14, k] != 20 && tot[i, 14, k] != 141 && tot[i, 14, k] != 145)
                            //    tot[i, 16, k] += tot[i, j, k];
                            if (tot[i, 15, k] != 10 && tot[i, 15, k] != 14 && tot[i, 15, k] != 16 && tot[i, 15, k] != 17 && tot[i, 15, k] != 18 && tot[i, 15, k] != 144 && tot[i, 15, k] != 145)  //Aqui no
                                tot[i, 17, k] += tot[i, j, k];
                            if (tot[i, 15, 1] == 900)
                                tot[i, 14, 1] = 0;
                        }
                    tot[i, 14, 1] = (tot[i, 14, 0] == 0 || tot[i, 15, 0] < 10 ? 0 : tot[i, 14, 2] / tot[i, 14, 0]);
                }
                soldadura = (soldadura == 1 && tot[RengSol, 0, 0] > 0 ? 1 : 0);   //cambio de valor de soldadura
                for (int i = 0; i < 50; i++)
                    for (int j = 0; j < 16; j++)
                    {
                        tot1[j] += tot[i, j, 2];
                        if (tot[i, 15, 2] != 28 && tot[i, 15, 2] != 29 && tot[i, 15, 2] != 26 && tot[i, 15, 2] != 27 && tot[i, 15, 2] != 20 && tot[i, 15, 2] != 110 && tot[i, 15, 2] != 140 && tot[i, 15, 2] != 900 && (tot[i, 15, 2] > 900 && soldadura == 1)) //&& tot[i, 15, 2] != 110
                            totd[j, 0] += tot[i, j, 2];
                        //if (tot[i, 14, 2] != 10 && tot[i, 14, 2] != 26 && tot[i, 14, 2] != 27 && tot[i, 14, 2] != 20 && tot[i, 14, 2] != 141 && tot[i, 14, 2] != 145 && tot[i, 14, 2] != 900 && (tot[i, 14, 2] > 900 && soldadura == 1))
                        //    totd[j, 1] += tot[i, j, 2];
                        if (tot[i, 15, 2] != 10 && tot[i, 15, 2] != 14 && tot[i, 15, 2] != 16 && tot[i, 15, 2] != 17 && tot[i, 15, 2] != 30 && tot[i, 15, 2] != 144 && tot[i, 15, 2] != 145 && tot[i, 15, 2] != 900 && (tot[i, 15, 2] > 900 && soldadura == 1))
                            totd[j, 2] += tot[i, j, 2];
                    }

                int muestra = -1;
                int cubicos = -1;
                int diarios = -1;
                int semanas = -1;
                int cubmues = -1;
                int diacubi = -1;
                int semcubi = -1;
                int muedias = -1;
                int muesema = -1;
                int DIASTRAB = -1;
                int i18 = -1;
                int i19 = -1;
                for (int i = 0; i < 50; i++)
                {
                    if (tot[i, 15, 0] == 1) cubicos = i;
                    if (tot[i, 15, 0] == 2) cubmues = i;
                    if (tot[i, 15, 0] == 3) diacubi = i;
                    if (tot[i, 15, 0] == 4) semcubi = i;
                    if (tot[i, 15, 0] == 5) muedias = i;
                    if (tot[i, 15, 0] == 6) muesema = i;
                    if (tot[i, 15, 0] == 10) diarios = i;
                    if (tot[i, 15, 0] == 18) muestra = i;
                    if (tot[i, 15, 0] == 26) i18 = i;     //antes 18
                    if (tot[i, 15, 0] == 27) i19 = i;     //antes 19
                    if (tot[i, 15, 0] == 11) semanas = i; //Antes 25
                    if (tot[i, 15, 0] == 14) DIASTRAB = i;
                }

                int paso = 1;
                for (int i = 0; i < 50; i++)
                    for (int j = 1; j < 15; j++)
                    {
                        if (muestra != -1 && cubicos != -1 && cubmues == i && tot[muestra, j, 0] > 0)
                            tot[cubmues, j, 0] = tot[cubicos, j, 0] / tot[muestra, j, 0];
                        if (cubicos != -1 && diarios != -1 && diacubi == i && tot[diarios, j, 0] > 0)
                            tot[diacubi, j, 0] = tot[cubicos, j, 0] / tot[diarios, j, 0];
                        if (cubicos != -1 && semanas != -1 && semcubi == i && tot[semanas, j, 0] > 0)
                            tot[semcubi, j, 0] = tot[cubicos, j, 0] / tot[semanas, j, 0];
                        if (muestra != -1 && diarios != -1 && muedias == i && tot[diarios, j, 0] > 0)
                            tot[muedias, j, 0] = tot[muestra, j, 0] / tot[diarios, j, 0];
                        if (muestra != -1 && semanas != -1 && muesema == i && tot[semanas, j, 0] > 0)
                            tot[muesema, j, 0] = tot[muestra, j, 0] / tot[semanas, j, 0];
                        if (i19 == i && (tot[diarios, j, 0] > 3 || paso == 0))
                        {
                            if (j < 14)
                            {
                                if (tot[diarios, j, 0] > 0 || tot[semanas, j, 0] > 0)
                                    if (tot[DIASTRAB, j, 0] / tot[semanas, j, 0] > 3)
                                    {
                                        tot[i19, j, 0] = tdias[j - 1];
                                        tot[i19, j, 1] = (tot[i19, j, 1] == 0 ? tot[i19, 0, 1] : tot[i19, j, 1]);
                                        tot[i19, j, 1] = (tdias[j - 1] == 0 ? 0 : tot[i19, j, 1]);
                                        tot[i19, j, 2] = tdias[j - 1] * tot[i19, j, 1];
                                        paso = 0;
                                    }
                            }
                        }
                    }
                if (i19 > 0)
                {
                    tot[i19, 14, 0] = 0;
                    tot[i19, 14, 2] = 0;
                    for (int j = 1; j < 15; j++)
                    {
                        if (j != 14)
                        {
                            tot[i19, j, 2] = tot[i19, j, 0] * tot[i19, j, 1];
                            tot[i19, 14, 0] += tot[i19, j, 0];
                            tot[i19, 14, 2] += tot[i19, j, 2];
                        }
                    }
                    tot[i19, 17, 2] = tot[i19, 14, 2];
                }
                if (i18 > 0 && i19 > 0)
                {
                    if (tot[i18, 0, 0] > 0)
                    {
                        decimal diasP = tot[i18, 14, 0] - tot[i18, 0, 0];
                        if (diasP > 0)
                        {
                            for (int j = 13; 0 < j; j--)
                            {
                                decimal diasR = diasP - tot[i18, j, 0];
                                if (diasR > 0)
                                {
                                    tot[i18, j, 0] = 0;
                                    tot[i18, j, 1] = 0;
                                    tot[i18, j, 2] = 0;
                                    diasR = diasR - tot[i18, j, 0];
                                    diasP = diasR;
                                }
                                else
                                {
                                    if (diasR < 0)
                                    {
                                        tot[i18, j, 0] = tot[i18, j, 0] - diasP;
                                        tot[i18, j, 2] = tot[i18, j, 0] * tot[i18, j, 1];
                                        diasR = 0;
                                        j = 0;
                                    }
                                }
                            }
                            tot[i18, 14, 0] = tot[i18, 0, 0];
                            tot[i18, 14, 2] = tot[i18, 0, 0] * tot[i18, 0, 1];
                        }
                    }
                    tot[i18, 17, 2] = tot[i18, 14, 2];
                }
                tot[0, 0, 0] = decimal.Parse((dsZeta1.Obra.Rows.Count > 0 && dsZeta1.Obra.Rows[0][7].ToString() != "" ? dsZeta1.Obra.Rows[0][7].ToString() : "0"));


                for (int i = 0; i < 50; i++)
                    for (int k = 0; k < 3; k++)
                        if (tot[i, 14, k] > 0 || tot[i, 0, k] > 0)
                            dsZeta1.Zeta.Rows.Add(txtIdobra.Text.Trim(), tot[i, 15, k], tot[i, 0, k], tot[i, 1, k],
                            tot[i, 2, k], tot[i, 3, k], tot[i, 4, k], tot[i, 5, k], tot[i, 6, k], tot[i, 7, k],
                            tot[i, 8, k], tot[i, 9, k], tot[i, 10, k], tot[i, 11, k], tot[i, 12, k], tot[i, 13, k], tot[i, 14, k], tot[i, 16, k], tot[i, 17, k], k);

                for (int i = 0; i < 19; i++)
                {
                    tot1[i] = 0;
                    for (int j = 0; j < 3; j++)
                        totd[i, j] = 0;
                }
                for (int i = 0; i < 50; i++)
                    for (int j = 0; j < 18; j++)
                    {
                        if (tot[i, 15, 2] < 900)
                        {
                            tot1[j] += tot[i, j, 2];
                            if (0 < j && j < 14)
                            {
                                if (tot[i, 15, 2] != 28 && tot[i, 15, 2] != 29 && tot[i, 15, 2] != 26 && tot[i, 15, 2] != 27 && tot[i, 15, 2] != 20 && tot[i, 15, 2] != 110 && tot[i, 15, 2] != 140) //&& tot[i, 15, 2] != 110
                                    totd[j, 0] += tot[i, j, 2];
                                //if (tot[i, 14, 2] != 10 && tot[i, 14, 2] != 18 && tot[i, 14, 2] != 19 && tot[i, 14, 2] != 20 && tot[i, 14, 2] != 141 && tot[i, 14, 2] != 145 && tot[i, 14, 2] != 900 && tot[i, 14, 2] < 900)
                                //    totd[j, 1] += tot[i, j, 2];
                                if (tot[i, 15, 2] != 10 && tot[i, 15, 2] != 14 && tot[i, 15, 2] != 16 && tot[i, 15, 2] != 17 && tot[i, 15, 2] != 18 && tot[i, 15, 2] != 144 && tot[i, 15, 2] != 145) //
                                    totd[j, 2] += tot[i, j, 2];
                            }
                        }
                    }

                dsZeta1.Zeta1.Rows.Add(txtIdobra.Text.Trim(), "Total", tot1[0], 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, tot1[16], tot1[17]);
                for (int k = 0; k < 3; k++)
                    if (k != 1)
                        dsZeta1.Zeta1.Rows.Add(txtIdobra.Text.Trim(), "Caso " + (k + 1).ToString().Trim() + ":", totd[0, k], totd[1, k], totd[2, k], totd[3, k],
                        totd[4, k], totd[5, k], totd[6, k], totd[7, k], totd[8, k], totd[9, k], totd[10, k], totd[11, k], totd[12, k], totd[13, k], totd[15, k], totd[16, k], totd[17, k]);

                //for (int i = 1; i < 13; i++)
                //    diaSem[i] = (((SemCol * i) - 1) * 7);
                dsZeta1.Fechas.Rows.Add(semana[0, 0], semana[0, 1], semana[1, 0], semana[1, 1], semana[2, 0], semana[2, 1],
                                        semana[3, 0], semana[3, 1], semana[4, 0], semana[4, 1], semana[5, 0], semana[5, 1],
                                        semana[6, 0], semana[6, 1], semana[7, 0], semana[7, 1], semana[8, 0], semana[8, 1],
                                        semana[9, 0], semana[9, 1], semana[10, 0], semana[10, 1], semana[11, 0], semana[11, 1], semana[12, 0], semana[12, 1]);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            DataSet dsDGO1 = new DataSet();
            sqlDABusObra.Fill(dsDGO1);

            cryZeta1.SetParameterValue("@Cons", dsDGO1.Tables[0].Rows[cmbIdObra.SelectedIndex][3].ToString());
            cryZeta1.SetParameterValue("@Ubica", dsDGO1.Tables[0].Rows[cmbIdObra.SelectedIndex][1].ToString());
            cryZeta1.SetParameterValue("@Col", dsDGO1.Tables[0].Rows[cmbIdObra.SelectedIndex][4].ToString());
            cryZeta1.SetParameterValue("@Zona", dsDGO1.Tables[0].Rows[cmbIdObra.SelectedIndex][5].ToString());
            cryZeta1.SetParameterValue("@Total", cbkTotal.Checked);
            cryZeta1.SetParameterValue("Obras", txtIdobra.Text.Trim() + " " + (IdObraM == "zzzzzz" ? "" : IdObraM));
            cryZeta1.SetParameterValue("@Cliente", (string.IsNullOrEmpty(dsDGO1.Tables[0].Rows[cmbIdObra.SelectedIndex][6].ToString()) ? "" : dsDGO1.Tables[0].Rows[cmbIdObra.SelectedIndex][6].ToString()));
            cryZeta1.SetParameterValue("SemCol", SemCol);
            cryZeta1.SetParameterValue("Semana", int.Parse(txtBimIni.Text) + int.Parse(txtBimSeg.Text));
            cryZeta1.SetParameterValue("SReal", int.Parse(lblDuracion.Text));
            cryZeta1.SetParameterValue("Pser", fini);
            cryZeta1.SetParameterValue("User", ffin);
            cryZeta1.SetParameterValue("Ai", txtAi.Text);
            cryZeta1.SetParameterValue("Si", nUDSi.Value);
            cryZeta1.SetParameterValue("Af", txtAf.Text);
            cryZeta1.SetParameterValue("Sf", nUDSf.Value);
            cryZeta1.SetParameterValue("Cli", (string.IsNullOrEmpty(dsDGO1.Tables[0].Rows[cmbIdObra.SelectedIndex][7].ToString()) ? "" : dsDGO1.Tables[0].Rows[cmbIdObra.SelectedIndex][7].ToString()));


            crvResumen.ReportSource = cryZeta1;
            //crvResumen.RefreshReport();

        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            lblProceso.Text = "Proceso:";
            try
            {
                sqlConn.Open();
                sqlCDelTemp1.Parameters["@IdUser"].Value = IdUsuario;
                int error = sqlCDelTemp1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            try
            {
                sqlConn.Open();
                sqlCDelTemp2.Parameters["@IdUser"].Value = IdUsuario;
                int error = sqlCDelTemp2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();

            string IdObraM = "zzzzzz";

            for (int i = 0; i < dGVObras.RowCount; i++)
            {
                if (dGVObras.Rows[i].Cells[1].Value.ToString() != "0" && dGVObras.Rows[i].Cells[2].Value.ToString() != "0")
                    IdObraM = dGVObras.Rows[i].Cells[0].Value.ToString().Trim();
                if (dGVObras.Rows[i].Cells[2].Value.ToString() != "0")
                {
                    try
                    {
                        sqlConn.Open();
                        sqlCInsZetaTemp.Parameters["@IdObra"].Value = dGVObras.Rows[i].Cells[0].Value.ToString().Trim();
                        sqlCInsZetaTemp.Parameters["@IdUser"].Value = IdUsuario;
                        sqlCInsZetaTemp.Parameters["@Pri"].Value = 0;
                        int error = sqlCInsZetaTemp.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    sqlConn.Close();
                }
            }
            for (int i = 0; i < dGVPresupuesto.RowCount; i++)
            {
                if (dGVPresupuesto.Rows[i].Cells[7].Value.ToString() != "0")
                {
                    try
                    {
                        sqlConn.Open();
                        sqlCInsZetaSolicitud.Parameters["@IdSolicitud"].Value = dGVPresupuesto.Rows[i].Cells[0].Value.ToString().Trim();
                        sqlCInsZetaSolicitud.Parameters["@Año"].Value = dGVPresupuesto.Rows[i].Cells[1].Value.ToString().Trim();
                        sqlCInsZetaSolicitud.Parameters["@IdUser"].Value = IdUsuario;
                        int error = sqlCInsZetaSolicitud.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    sqlConn.Close();
                }
            }
            lblProceso.Text = "Inicio obra principal";
            try
            {
                sqlConn.Open();
                sqlComAgrega.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlComAgrega.Parameters["@Fini"].Value = "01/01/2001";
                sqlComAgrega.Parameters["@Ffin"].Value = DateTime.Now.AddDays(30).ToShortDateString();
                sqlComAgrega.Parameters["@Mortero"].Value = 0;
                sqlComAgrega.Parameters["@IdObraM"].Value = cmbIdObra.SelectedValue;
                int error = sqlComAgrega.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            if (IdObraM != "zzzzzz")
            {
                lblProceso.Text = "Obra mortero";
                try
                {
                    sqlConn.Open();
                    sqlComAgrega.Parameters["@IdObra"].Value = IdObraM;
                    sqlComAgrega.Parameters["@Fini"].Value = "01/01/2001";
                    sqlComAgrega.Parameters["@Ffin"].Value = DateTime.Now.AddDays(30).ToShortDateString();
                    sqlComAgrega.Parameters["@Mortero"].Value = 1;
                    sqlComAgrega.Parameters["@IdObraM"].Value = cmbIdObra.SelectedValue;
                    int error = sqlComAgrega.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConn.Close();
            }
            lblProceso.Text = "Inserta zeta";
            for (int i = 0; i < dGVObras.RowCount; i++)
            {
                int mortero = int.Parse(dGVObras.Rows[i].Cells[1].Value.ToString());
                if (dGVObras.Rows[i].Cells[2].Value.ToString() != "0")
                {
                    try
                    {
                        sqlConn.Open();
                        sqlComPrevioZ.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                        sqlComPrevioZ.Parameters["@Mortero"].Value = mortero;
                        sqlComPrevioZ.Parameters["@IdUser"].Value = IdUsuario;
                        sqlComPrevioZ.Parameters["@IdObraM"].Value = IdObraM;
                        int error = sqlComPrevioZ.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    sqlConn.Close();
                }
            }
            lblProceso.Text = "Calculo semanas";
            chkSemanas_CheckedChanged(sender, null);
            MessageBox.Show("Proceso terminado");

        }

        private void txtBimIni_Validating(object sender, CancelEventArgs e)
        {
            //int duracion = int.Parse(lblDuracion.Text);
            //int semini = int.Parse(txtBimIni.Text);
            //int semseg = int.Parse(txtBimSeg.Text);
            //int semana = int.Parse(cmbDurSem.Text) * 12;
            //if (semini + semseg > duracion)
            //{
            //    MessageBox.Show("La semana inicial mas la segunda,  no deben ser mayor al número de semanas");
            //    e.Cancel = true;
            //}

        }

        private void nUpDoSem_ValueChanged(object sender, EventArgs e)
        {
            txtBimIni.Text = (int.Parse(cmbDurSem.Text) > int.Parse(txtBimIni.Text) ? txtBimIni.Text = cmbDurSem.Text : txtBimIni.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtBimSeg_Validating(object sender, CancelEventArgs e)
        {
            int duracion = int.Parse(lblDuracion.Text);
            int semini = int.Parse(txtBimIni.Text);
            int semseg = int.Parse(txtBimSeg.Text);
            int semana = int.Parse(cmbDurSem.Text) * 12;
            if (semini + semseg > duracion)
            {
                MessageBox.Show("La semana inicial mas la segunda,  no deben ser mayor al número de semanas");
                e.Cancel = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void chkSemanas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dsZetaSemanas1.Clear();
                sqlDAZetaSi.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString().Trim();
                sqlDAZetaSi.Fill(dsZetaSemanas1, "PrevioZ");
                sqlDAZetaSf.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString().Trim();
                sqlDAZetaSf.Fill(dsZetaSemanas1, "PrevioZ");
                nUDSi.Value = int.Parse(dsZetaSemanas1.PrevioZ.Rows[0]["Semana"].ToString());
                txtAi.Text = dsZetaSemanas1.PrevioZ.Rows[0]["Ano"].ToString();
                nUDSf.Value = int.Parse(dsZetaSemanas1.PrevioZ.Rows[1]["Semana"].ToString());
                txtAf.Text = dsZetaSemanas1.PrevioZ.Rows[1]["Ano"].ToString();
                ai = int.Parse(txtAi.Text);
                si = int.Parse(nUDSi.Value.ToString());
                af = int.Parse(txtAf.Text);
                sf = int.Parse(nUDSf.Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbDurSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBimIni.Text = cmbDurSem.SelectedItem.ToString();
            txtBimSeg.Text = cmbDurSem.SelectedItem.ToString();
            if (cmbDurSem.SelectedItem.ToString() == "5") txtBimIni.Text = "4";
            if (cmbDurSem.SelectedItem.ToString() == "9") txtBimSeg.Text = "8";
        }
    }
}
