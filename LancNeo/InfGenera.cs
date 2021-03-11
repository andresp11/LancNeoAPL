using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Configuration;
using System.Globalization;

namespace LancNeo
{
    public partial class InfGenera : Form
    {
        public InfGenera()
        {
            InitializeComponent();
        }

        private void InfGenera_Load(object sender, EventArgs e)
        {
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            cmbIdObra.SelectedIndex = 0;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            string obra = cmbIdObra.SelectedValue.ToString().Trim();
            obra = (obra.IndexOf("-", 0) > 0 ? obra.Substring(1, 1) + obra.Substring(2, 1) + obra.Substring(4, 1) : obra);
            crvRepTarjeta.Visible = true;
            dsInfGenera1.Clear();
            dsInfGenera2.Clear();
            dsAgenteC1.Clear();
            //string clv = empresa();
            try
            {
                DateTime fecha = DateTime.Now;
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;
                object[] findTheseVals = new object[3];

                sqlDAFacCob.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlDAFacCob.Fill(dsInfGenera1, "FacCob");
                sqlDAFactura.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlDAFactura.Fill(dsInfGenera1, "Factura");
                sqlDAAgente.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlDAAgente.Fill(dsAgenteC1, "Agente");
                for (int i = 0; i < dsInfGenera1.Tables["Factura"].Rows.Count; i++)
                {
                    // Set the values of the keys to find.
                    findTheseVals[0] = cmbIdObra.SelectedValue;
                    findTheseVals[1] = dsInfGenera1.Tables["Factura"].Rows[i][10].ToString();
                    findTheseVals[2] = dsInfGenera1.Tables["Factura"].Rows[i][11].ToString();
                    DataRow filas = dsInfGenera1.Tables["Periodos"].Rows.Find(findTheseVals);
                    if (filas == null)
                        dsInfGenera1.Tables["Periodos"].Rows.Add(cmbIdObra.SelectedValue, dsInfGenera1.Tables["Factura"].Rows[i][10].ToString(), dsInfGenera1.Tables["Factura"].Rows[i][11].ToString());
                    if (dsAgenteC1.Agente.Rows.Count == 1)
                    {
                        string observa = dsInfGenera1.Tables["Factura"].Rows[i]["Obs"].ToString().Trim();
                        observa = observa.Replace(dsAgenteC1.Agente.Rows[0][2].ToString().Trim(), "");
                        observa = observa.Replace("  ", " "); //_x000D_
                        observa = observa.Replace("_x000D__x000D_", "_x000D_");
                        observa = observa.Replace("_x000D_", System.Environment.NewLine);
                        observa = observa.Replace("\r\n\n\r\n\n", System.Environment.NewLine);
                        observa = observa.Replace("Iguala Semanal por Trabajos de Laboratorio", "");
                        observa = observa.Replace("Iguala Catorcenal por Trabajos de Laboratorio", "");
                        int ultimo = observa.LastIndexOf("\r\n\n");
                        int longit = observa.Length;
                        if (longit == ultimo + 4)
                            observa = observa.Substring(0, ultimo);
                        ultimo = observa.IndexOf("\r\n\n");
                        if (ultimo == 0)
                            observa = observa.Substring(4);
                        observa = observa.Replace("\r\n\n", "\r\n");
                        dsInfGenera1.Tables["Factura"].Rows[i]["Obs"] = observa.Trim();

                    }
                    dsInfGenera1.Tables["Factura"].Rows[i]["Numdoc"] = dsInfGenera1.Tables["Factura"].Rows[i]["Numdoc"].ToString().Substring(3);
                }
                for (int i = 0; i < dsInfGenera1.Tables["FacCob"].Rows.Count; i++)
                    dsInfGenera1.Tables["FacCob"].Rows[i]["Numdoc"] = dsInfGenera1.Tables["FacCob"].Rows[i]["Numdoc"].ToString().Substring(3);

                sqlDAInfGenera.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDAInfGenera.Fill(dsInfGenera1, "Obras");
            for (int i = 0; i < dsInfGenera1.Tables["Obras"].Rows.Count; i++)
            {
                // Set the values of the keys to find.
                findTheseVals[0] = cmbIdObra.SelectedValue;
                findTheseVals[1] = dsInfGenera1.Tables["Obras"].Rows[i][1].ToString();
                findTheseVals[2] = dsInfGenera1.Tables["Obras"].Rows[i][2].ToString();
                DataRow filas = dsInfGenera1.Tables["Periodos"].Rows.Find(findTheseVals);
                if (filas == null)
                    dsInfGenera1.Tables["Periodos"].Rows.Add(cmbIdObra.SelectedValue, dsInfGenera1.Tables["Obras"].Rows[i][1].ToString(), dsInfGenera1.Tables["Obras"].Rows[i][2].ToString());
            }
            dsInfGenera1.Tables["Periodos"].DefaultView.Sort = "IdObra ASC, Anos ASC, Semana ASC";
            DataTable dt = dsInfGenera1.Tables["Periodos"];
            dt.DefaultView.Sort = "IdObra ASC, Anos ASC, Semana ASC";
            DataView dv = dt.DefaultView;
            dv.Sort = "IdObra ASC, Anos ASC, Semana ASC";
            DataTable dt1 = dv.ToTable();
            dsInfGenera1.Tables["Periodos"].Clear();
            for (int i = 0; i < dt1.Rows.Count; i++)
                dsInfGenera1.Tables["Periodos"].Rows.Add(dt1.Rows[i][0].ToString(), dt1.Rows[i][1], dt1.Rows[i][2]);
            if (dt1.Rows.Count == 0)
            {
                Int16 semana = Int16.Parse(cal.GetWeekOfYear(fecha, dfi.CalendarWeekRule, DayOfWeek.Monday).ToString());
                dt1.Rows.Add(cmbIdObra.SelectedValue.ToString(), fecha.Year, semana);
            }
                //if (dt1.Rows.Count < 26)
            {
                Int16 año = Int16.Parse(dt1.Rows[dt1.Rows.Count - 1][1].ToString());
                Int16 semana = Int16.Parse(dt1.Rows[dt1.Rows.Count - 1][2].ToString());
                for (int i = dt1.Rows.Count; i < nUDRenglon.Value + dt1.Rows.Count; i++)
                {
                    try
                    {
                        dsInfGenera1.Tables["Periodos"].Rows.Add(dt1.Rows[dt1.Rows.Count - 1][0].ToString(), año, semana);
                    }
                    catch { }
                    semana++;
                    if (semana > 52)
                    {
                        año++;
                        semana = 1;
                    }
                }
            }

                double Presupuesto = 0;
                double Soldadura = 0;

                dsInfGenera1.Obras1.Clear();

                SqlDaInfGenPresC.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            SqlDaInfGenPresC.Fill(dsInfGenera1, "Obras1");
            sqlDAObra.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDAObra.Fill(dsInfGenera1, "Obra");
            sqlDAPresupuesto.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDAPresupuesto.Fill(dsInfGenera1, "ObraP");
            sqlDASolicitudCar.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDASolicitudCar.Fill(dsInfGenera1, "SolicitudCar");
                string años = "";
                string añoa = "";
                string Solicitud = "";
                string Solicituda = "";
                if (dsInfGenera1.SolicitudCar.Rows.Count > 0)
                {
                    for (int j = 0; j < dsInfGenera1.SolicitudCar.Rows.Count; j++)
                    {
                        años = dsInfGenera1.SolicitudCar.Rows[j][1].ToString();
                        Solicitud = dsInfGenera1.SolicitudCar.Rows[j][0].ToString();
                        if (añoa != años || Solicitud != Solicituda)
                        {
                            dsInfGenera1.SolicitudPre.Clear();
                            dsInfGenera1.SolicitudPre1.Clear();
                            añoa = años;
                            Solicituda = Solicitud;
                            sqlDASolicitudPre.SelectCommand.Parameters["@IdSolicitud"].Value = Solicitud;
                            sqlDASolicitudPre.SelectCommand.Parameters["@Año"].Value = años;
                            sqlDASolicitudPre.SelectCommand.Parameters["@Version"].Value = 1;
                            sqlDASolicitudPre.Fill(dsInfGenera1, "SolicitudPre");
                            for (int i = 0; i < dsInfGenera1.SolicitudPre.Rows.Count; i++)
                                Presupuesto += (double.Parse(dsInfGenera1.SolicitudPre.Rows[i][5].ToString()) * double.Parse(dsInfGenera1.SolicitudPre.Rows[i][6].ToString()));
                            sqlDASolicitudPre1.SelectCommand.Parameters["@IdSolicitud"].Value = Solicitud;
                            sqlDASolicitudPre1.SelectCommand.Parameters["@Año"].Value = años;
                            sqlDASolicitudPre1.SelectCommand.Parameters["@Version"].Value = 1;
                            sqlDASolicitudPre1.Fill(dsInfGenera1, "SolicitudPre1");
                            for (int i = 0; i < dsInfGenera1.SolicitudPre1.Rows.Count; i++)
                                Presupuesto += (double.Parse(dsInfGenera1.SolicitudPre1.Rows[i][5].ToString()) * double.Parse(dsInfGenera1.SolicitudPre1.Rows[i][6].ToString()));
                        }
                    }
                }
                int asf = 0;
            int sol = 0;
            int formato = 0;
            if (rdBPre.Checked == true  )
            {
                asf = int.Parse(dsInfGenera1.Obras1.Rows[0]["Asf"].ToString()) + int.Parse(dsInfGenera1.Obras1.Rows[0]["Ase"].ToString())
                    + int.Parse(dsInfGenera1.Obras1.Rows[0]["Ass"].ToString()) + int.Parse(dsInfGenera1.Obras1.Rows[0]["Asp"].ToString())
                    + int.Parse(dsInfGenera1.Obras1.Rows[0]["Asg"].ToString()) + int.Parse(dsInfGenera1.Obras1.Rows[0]["Asl"].ToString())
                    + int.Parse(dsInfGenera1.Obras1.Rows[0]["Asd"].ToString()) + int.Parse(dsInfGenera1.Obras1.Rows[0]["Asv"].ToString())
                    ;
                sol = int.Parse(dsInfGenera1.Obras1.Rows[0]["Sol"].ToString()) + int.Parse(dsInfGenera1.Obras1.Rows[0]["rad"].ToString())
                    + int.Parse(dsInfGenera1.Obras1.Rows[0]["ult"].ToString()) + int.Parse(dsInfGenera1.Obras1.Rows[0]["liq"].ToString())
                    + int.Parse(dsInfGenera1.Obras1.Rows[0]["Vis"].ToString()) 
                    ;
                formato = (asf > sol ? 0 : 1); 
           }
            if (rdBAsf.Checked) 
                formato = 0 ;
            if (rdBSol.Checked) 
                formato = 1;

                int copiar = 0;
                if (nUDSemana.Value != 0 || nUDAño.Value != 2000)
                {
                    DataSet _tmp = new DataSet();
                    DataTable _dt = dsInfGenera1.Tables["Periodos"].Clone();
                    _tmp.Tables.Add(_dt);
                    for (int i = 0; i < dsInfGenera1.Tables["Periodos"].Rows.Count; i++)
                    {
                        if (nUDSemana.Value == int.Parse(dsInfGenera1.Tables["Periodos"].Rows[i][2].ToString()) && nUDAño.Value == int.Parse(dsInfGenera1.Tables["Periodos"].Rows[i][1].ToString())) copiar = 1;
                        if (copiar == 1) _tmp.Tables[0].ImportRow(dsInfGenera1.Tables["Periodos"].Rows[i]);
                    }
                    if (copiar == 1)
                    {
                        dsInfGenera1.Tables["Periodos"].Clear();
                        for (int i = 0; i < _tmp.Tables[0].Rows.Count; i++)
                           dsInfGenera1.Tables["Periodos"].ImportRow(_tmp.Tables[0].Rows[i]);
                    }
                }
                cryInfGenera1.SetDataSource(dsInfGenera1);
            cryInfGenera1.SetParameterValue("@Formato", formato.ToString());
                cryInfGenera1.SetParameterValue("Presupuesto", Presupuesto);
                cryInfGenera1.SetParameterValue("Soldadura", Soldadura);
                crvRepTarjeta.ReportSource = cryInfGenera1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cmbIdObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            nUDAño.Value = 2000;
            nUDSemana.Value = 0;
        }
        //private string empresa()
        //{

        //    string strIdEmpresa = "";
        //        String strSql = " SELECT paradox FROM Obra where idobra = '" + cmbIdObra.SelectedValue.ToString() + "'";
        //        SqlCommand sqlCmd = new SqlCommand(strSql, sqlConn);
        //        try
        //        {
        //            sqlConn.Open();
        //            SqlDataReader dr = sqlCmd.ExecuteReader();
        //            if (dr.Read())
        //            {
        //                strIdEmpresa = dr["Paradox"].ToString();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            ex.ToString();
        //        }
        //        finally
        //        {
        //            if (sqlConn.State == ConnectionState.Open)
        //            {
        //                sqlConn.Close();
        //            }
        //        }
        //    return strIdEmpresa;
        //}

    }
}
