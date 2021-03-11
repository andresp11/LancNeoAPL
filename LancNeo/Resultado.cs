using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;


namespace LancNeo
{
    public partial class Resultado : Form
    {
        private String strRazonSocial;
		private String strObraUbicacion;
		private String strObraColonia;
        
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            dtpIni.Value = DateTime.Today.AddDays(-6);
            dtpFin.Value = DateTime.Today.AddDays(1);
            this.WindowState = FormWindowState.Maximized;
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultado.Visible = false;
                crvReporte.Visible = true;
                Pdf.Visible = false;
                resultadoCR1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                resultadoCR1.SetDataSource(dsBajosTemp1);
                dsBajosTemp1.Clear();
                sqlDABajosTemp.SelectCommand.Parameters["@Finicial"].Value = dtpIni.Value;
                sqlDABajosTemp.SelectCommand.Parameters["@Ffinal"].Value = dtpFin.Value;
                sqlDABajosTemp.SelectCommand.Parameters["@Dia"].Value = (rdbTres.Checked ? 3 : rdbUno.Checked ? 1 : 7);
                sqlDABajosTemp.SelectCommand.Parameters["@Tole"].Value = txtTolerancia.Text;
                sqlDABajosTemp.Fill(dsBajosTemp1, "Agregado");

                resultadoCR1.SetParameterValue("Finicial", dtpIni.Value);
                resultadoCR1.SetParameterValue("Ffinal", dtpFin.Value);
                resultadoCR1.SetParameterValue("Edad", (rdbTres.Checked ? 3 : rdbUno.Checked ? 1 : 7));
                resultadoCR1.SetParameterValue("Tolerancia", txtTolerancia.Text);


                crvReporte.ReportSource = resultadoCR1;
                //crvRepExperiencia.RefreshReport();
            }
            catch (Exception ex)
            {
                //                MessageBox.Show(ex.Message);
            }
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            dgvResultado.Visible = true;
            crvReporte.Visible = false;
            Pdf.Visible = true;
            tbBtn2.Visible = true;
            dsBajosTemp1.Clear();
            sqlDABajosTemp.SelectCommand.Parameters["@Finicial"].Value = dtpIni.Value;
            sqlDABajosTemp.SelectCommand.Parameters["@Ffinal"].Value = dtpFin.Value;
            sqlDABajosTemp.SelectCommand.Parameters["@Dia"].Value = (rdbTres.Checked ? 3 : rdbUno.Checked ? 1 : 7);
            sqlDABajosTemp.SelectCommand.Parameters["@Tole"].Value = txtTolerancia.Text;
            sqlDABajosTemp.Fill(dsBajosTemp1, "Agregado");
            decimal Res, incre;
            Res = incre = 0;
            foreach (DataGridViewRow row in dgvResultado.Rows)
            {
                row.Cells[0].Value = false;
                row.Cells[1].Value = false;
                row.Cells[2].Value = false;
                Res = decimal.Parse(row.Cells[18].Value.ToString());
                incre = decimal.Parse(row.Cells[19].Value.ToString());
                row.Cells[22].Value = Res + incre;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pdf_Click(object sender, EventArgs e)
        {
            int dia1 = 3;
            int dia2 = 7;
            int i = -1;
            foreach (DataGridViewRow row in dgvResultado.Rows)
            {

                i++;
                if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                {
                    try
                    {
                        DateTime Finicial = DateTime.Parse(dsBajosTemp1.Agregado.Rows[i][1].ToString());
                        DateTime Ffinal = DateTime.Parse(dsBajosTemp1.Agregado.Rows[i][1].ToString());
                        Finicial = Finicial.AddHours(-Finicial.Hour).AddMinutes(-Finicial.Minute).AddSeconds(-Finicial.Second);
                        Ffinal = Finicial.AddHours(23).AddMinutes(59).AddSeconds(59);
                        int Mpa = (bool.Parse(row.Cells[2].Value.ToString()) == true ? 1 : 0);
                        double factor = double.Parse(dsUnidad1.Unidad.Rows[Mpa][2].ToString());
                        double Res = double.Parse(dsBajosTemp1.Agregado.Rows[i][6].ToString()) * factor;
                        double incD3EE = (rdbTres.Checked ? double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString()) : double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString()));
                        double incD7EE = (rdbTres.Checked ? double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString()) : double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString()));
                        switch (int.Parse(dsBajosTemp1.Agregado.Rows[i][7].ToString()))
                        {
                            case 1:
                            case 2:
                                dia1 = 3;
                                dia2 = 7;
                                incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString());
                                incD7EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                                if (dsBajosTemp1.Agregado.Rows[i]["Dia"].ToString() == "7")
                                {
                                    incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                                    incD7EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString());
                                }
                                break;
                            case 6:
                            case 11:
                                dia1 = 1;
                                dia2 = 3;
                                incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                                incD7EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString());
                                break;
                            case 7:
                            case 12:
                                dia1 = 1;
                                dia2 = 0;
                                incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                                incD7EE = 0;
                                break;
                            case 8:
                            case 13:
                                dia1 = -1;
                                dia2 = 1;
                                incD3EE = 0;
                                incD7EE = 0;
                                break;
                            default:
                                dia1 = 3;
                                dia2 = 7;
                                incD3EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento"].ToString());
                                incD7EE = double.Parse(dsBajosTemp1.Agregado.Rows[i]["Incremento7"].ToString());
                                break;
                        }

                        incD3EE = incD3EE * factor;
                        incD7EE = incD7EE * factor;
                        string resis = (Mpa == 0 ? Res.ToString() : Res.ToString("###.00")) + " - " + dsBajosTemp1.Agregado.Rows[i][21].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][8].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][9].ToString();
                        GetDatosEmpresa(dsBajosTemp1.Agregado.Rows[i][0].ToString());
                        dsRepCartaEdadTemprana1.Clear();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@FechaIni"].Value = Finicial;
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@FechaFin"].Value = Ffinal;
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@IncD3EE"].Value = incD3EE;
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@IncD7EE"].Value = incD7EE;
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@ResistenciaKG"].Value = dsBajosTemp1.Agregado.Rows[i][6].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@IdObra"].Value = dsBajosTemp1.Agregado.Rows[i][0].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@IdConcretera"].Value = dsBajosTemp1.Agregado.Rows[i][5].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@Tipo"].Value = dsBajosTemp1.Agregado.Rows[i][7].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@Agregado"].Value = dsBajosTemp1.Agregado.Rows[i][8].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@Renvenimiento"].Value = dsBajosTemp1.Agregado.Rows[i][9].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@IdAgregado"].Value = dsBajosTemp1.Agregado.Rows[i][11].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@IdPrueba"].Value = dsBajosTemp1.Agregado.Rows[i][18].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@IdUnidad"].Value = dsUnidad1.Unidad.Rows[Mpa][0].ToString();
                        sqlDACartaEdadTemp.SelectCommand.Parameters["@IdDiam"].Value = dsBajosTemp1.Agregado.Rows[i][19].ToString();

                        dsCorreos1.Clear();
                        sqlDACorreos.SelectCommand.Parameters["@IdObra"].Value = dsBajosTemp1.Agregado.Rows[i][0].ToString(); 
                        sqlDACorreos.Fill(dsCorreos1, "Obra");


                        sqlDACartaEdadTemp.Fill(dsRepCartaEdadTemprana1, "RepCartaEdadTemprana");
                        //if (bool.Parse(row.Cells[2].Value.ToString()) != true)
                        //    cryRepCartaEdadTemprana = new CryRepCartaEdadTemprana();
                        //else
                        //    cryRepCartaEdadTemprana = new CryRepCartaEdadTempranM();
                        if (bool.Parse(row.Cells[1].Value.ToString()) != true)
                        {
                            resis = (Mpa == 0 ? Res.ToString() : Res.ToString("###.00")) + " - " + dsBajosTemp1.Agregado.Rows[i][21].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][8].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][9].ToString();
                            cryRepCartaEdadTemprana = new CryRepCartaEdadTemprana(); 
                            cryRepCartaEdadTemprana.SetDataSource(dsRepCartaEdadTemprana1);
                            cryRepCartaEdadTemprana.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                            cryRepCartaEdadTemprana.SetParameterValue("@Leyenda", true);
                            cryRepCartaEdadTemprana.SetParameterValue("@Lab", true);

                            cryRepCartaEdadTemprana.SetParameterValue("Razonsocial", strRazonSocial);
                            cryRepCartaEdadTemprana.SetParameterValue("ObraUbicacion", strObraUbicacion);
                            cryRepCartaEdadTemprana.SetParameterValue("ObraColonia", strObraColonia);
                            cryRepCartaEdadTemprana.SetParameterValue("TipoPrueba", "COMPRESIÓN");
                            cryRepCartaEdadTemprana.SetParameterValue("Exp3", incD3EE);
                            cryRepCartaEdadTemprana.SetParameterValue("Exp7", incD7EE);
                            cryRepCartaEdadTemprana.SetParameterValue("Unidad", dsUnidad1.Unidad.Rows[Mpa][1].ToString());
                            cryRepCartaEdadTemprana.SetParameterValue("Logotipo", " ");
                            cryRepCartaEdadTemprana.SetParameterValue("Consecutivo", "0");
                            cryRepCartaEdadTemprana.SetParameterValue("Res", resis);
                            cryRepCartaEdadTemprana.SetParameterValue("Concre", dsBajosTemp1.Agregado.Rows[i][5].ToString());
                            cryRepCartaEdadTemprana.SetParameterValue("Diam", dsBajosTemp1.Agregado.Rows[i][24].ToString());
                            cryRepCartaEdadTemprana.SetParameterValue("Res1", Res);
                            cryRepCartaEdadTemprana.SetParameterValue("Tipo", dsBajosTemp1.Agregado.Rows[i][7].ToString());
                            cryRepCartaEdadTemprana.SetParameterValue("Dia1", dia1);
                            cryRepCartaEdadTemprana.SetParameterValue("Dia2", dia2);
                        }
                        else
                        {
                            resis = (Mpa == 0 ? Res.ToString() : Res.ToString("###.00")) + " - " + dsBajosTemp1.Agregado.Rows[i][21].ToString() ;
                            cryRepCartaEdadTempranM1 = new CryRepCartaEdadTempranM();
                            cryRepCartaEdadTempranM1.SetDataSource(dsRepCartaEdadTemprana1);
                            cryRepCartaEdadTempranM1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                            cryRepCartaEdadTempranM1.SetParameterValue("@Leyenda", true);
                            cryRepCartaEdadTempranM1.SetParameterValue("@Lab", true);

                            cryRepCartaEdadTempranM1.SetParameterValue("Razonsocial", strRazonSocial);
                            cryRepCartaEdadTempranM1.SetParameterValue("ObraUbicacion", strObraUbicacion);
                            cryRepCartaEdadTempranM1.SetParameterValue("ObraColonia", strObraColonia);
                            cryRepCartaEdadTempranM1.SetParameterValue("TipoPrueba", "COMPRESIÓN");
                            cryRepCartaEdadTempranM1.SetParameterValue("Exp3", incD3EE);
                            cryRepCartaEdadTempranM1.SetParameterValue("Exp7", incD7EE);
                            cryRepCartaEdadTempranM1.SetParameterValue("Unidad", dsUnidad1.Unidad.Rows[Mpa][1].ToString());
                            cryRepCartaEdadTempranM1.SetParameterValue("Logotipo", " ");
                            cryRepCartaEdadTempranM1.SetParameterValue("Consecutivo", "0");
                            cryRepCartaEdadTempranM1.SetParameterValue("Res", resis);
                            cryRepCartaEdadTempranM1.SetParameterValue("Concre", dsBajosTemp1.Agregado.Rows[i][5].ToString());
                            cryRepCartaEdadTempranM1.SetParameterValue("Diam", dsBajosTemp1.Agregado.Rows[i][24].ToString());
                            cryRepCartaEdadTempranM1.SetParameterValue("Res1", Res);
                            cryRepCartaEdadTempranM1.SetParameterValue("Tipo", dsBajosTemp1.Agregado.Rows[i][7].ToString());
                            cryRepCartaEdadTempranM1.SetParameterValue("Dia1", dia1);
                            cryRepCartaEdadTempranM1.SetParameterValue("Dia2", dia2);
                        }
                        DateTime fechas = dtpFin.Value;
                        string nombre = "";
                        string obraC = dsBajosTemp1.Agregado.Rows[i][0].ToString();
                        obraC = obraC.Replace("/", "-");
                        obraC = obraC.Replace("\\", "-");
                        int lugar = obraC.IndexOf('\\');
                        if (lugar > 2)
                            obraC = obraC.Substring(0, lugar - 1) + "-" + obraC.Substring(lugar);
                        nombre = obraC + fechas.ToString("yyMMdd") + ".pdf";
                        ExportOptions CrExportOptions;
                        DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                        PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                        CrDiskFileDestinationOptions.DiskFileName = "c:\\correos\\" + obraC + fechas.ToString("yyMMdd") + dsBajosTemp1.Agregado.Rows[i][4].ToString().Trim() + ".pdf";
                        CrExportOptions = (bool.Parse(row.Cells[1].Value.ToString()) != true ? cryRepCartaEdadTemprana.ExportOptions : cryRepCartaEdadTempranM1.ExportOptions);
                        {
                            CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                            CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                            CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                            CrExportOptions.FormatOptions = CrFormatTypeOptions;
                        }
                        if (bool.Parse(row.Cells[1].Value.ToString()) != true )
                            cryRepCartaEdadTemprana.Export();
                        else
                            cryRepCartaEdadTempranM1.Export();
                        string direccion = ""; // "ariw@laboratorioslanc.mx; marcofar@laboratorioslanc.mx; apl_mx@hotmail.com";
                        bool sipaso = false;
                        obraC = CrDiskFileDestinationOptions.DiskFileName.ToString();
                        for (int j = 1; j < 6; j++)
                            direccion = direccion + (dsCorreos1.Obra.Rows[0][j].ToString() != "" ? dsCorreos1.Obra.Rows[0][j].ToString() + "; " : "");
                        if (string.IsNullOrEmpty(direccion) && chkObliga.Checked)
                            direccion = "ariw@laboratorioslanc.mx; marcofar@laboratorioslanc.mx; apl_mx@hotmail.com";
                        if (direccion.Length > 10)
                            sipaso = SendEmailWithOutlook(direccion, strObraUbicacion, "Enviamos preeliminares", obraC, nombre);
                    }
                    //                        crvReporte.ReportSource = cryRepCartaEdadTemprana;
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("Proceso terminado", "Vaya a outlook para verificar los correos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        
        private void GetDatosEmpresa(string IdObra)
		{
			String strSql = " Select O.informes as Facturar, O.Ubicacion, O.Colonia from Obra O ";
				strSql += " Where O.IdObra = '" + IdObra + "'";
			SqlCommand sqlCmd  = new SqlCommand(strSql, sqlConn);
			try
			{
				sqlConn.Open();
				SqlDataReader dr = sqlCmd.ExecuteReader();
				if(dr.Read())
				{	
					strRazonSocial = dr["Facturar"].ToString();
					strObraUbicacion = dr["Ubicacion"].ToString();
					strObraColonia = dr["Colonia"].ToString();
				}					                                                                                                                 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if(sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}
			}
		}

        public static Boolean SendEmailWithOutlook(string mailDirection, string mailSubject, string mailContent, string nombre, string filename)
        {
            //try
            //{
                Microsoft.Office.Interop.Outlook._Application oApp = new Microsoft.Office.Interop.Outlook.Application();

                Microsoft.Office.Interop.Outlook.NameSpace ns = oApp.GetNamespace("MAPI");
                //                var f = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

                System.Threading.Thread.Sleep(1000);

                var mailItem = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                mailItem.Subject = "Carta de baja resistencia a edad temprana de la obra: " + mailSubject;
                mailItem.HTMLBody = "Enviamos los resultados de las pruebas de compresión del mortero y concreto a edades tempranas de la obra " + mailSubject
                + "<br> en archivo adjunto. <br> <br> Estamos a sus ordenes para cualquier aclaración";
                mailItem.To = mailDirection;
                mailItem.Attachments.Add(nombre, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue,
                    1, filename);
                mailItem.Send();

            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
            //finally
            //{
            //}
            return true;
        }

        private void tbBtn2_Click(object sender, EventArgs e)
        {
            int i = -1;
            foreach (DataGridViewRow row in dgvResultado.Rows)
            {
                i++;
                if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                {
                    try
                    {
                            sqlConn.Open();
                            sqlComActualiza.Parameters["@Carta"].Value = 1;
                            sqlComActualiza.Parameters["@IdObra"].Value = dsBajosTemp1.Agregado.Rows[i][0].ToString();
                            sqlComActualiza.Parameters["@Fecha"].Value = dsBajosTemp1.Agregado.Rows[i][1].ToString();
                            sqlComActualiza.Parameters["@Consecutivo"].Value = dsBajosTemp1.Agregado.Rows[i][2].ToString();
                            sqlComActualiza.Parameters["@IdEspecimen"].Value = dsBajosTemp1.Agregado.Rows[i][3].ToString();
                            sqlComActualiza.Parameters["@FEnsaye"].Value = dsBajosTemp1.Agregado.Rows[i][20].ToString();
                            sqlComActualiza.ExecuteNonQuery();
                    }
                    //                        crvReporte.ReportSource = cryRepCartaEdadTemprana;
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (sqlConn.State == ConnectionState.Open)
                            sqlConn.Close();
                    }

                }
            }

        }

        private void tbBtn3_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultado.Visible = false;
                crvReporte.Visible = true;
                resultadoFCR1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                resultadoFCR1.SetDataSource(dsBajosTemp1);
                dsBajosTemp1.Clear();
                sqlDABajosRes.SelectCommand.Parameters["@Finicial"].Value = dtpIni.Value;
                sqlDABajosRes.SelectCommand.Parameters["@Ffinal"].Value = dtpFin.Value;
//                sqlDABajosTemp.SelectCommand.Parameters["@Dia"].Value = (rdbTres.Checked ? 3 : rdbUno.Checked ? 1 : 7);
//                sqlDABajosTemp.SelectCommand.Parameters["@Tole"].Value = txtTolerancia.Text;
                sqlDABajosRes.Fill(dsBajosTemp1, "Agregado");

                resultadoFCR1.SetParameterValue("Finicial", dtpIni.Value);
                resultadoFCR1.SetParameterValue("Ffinal", dtpFin.Value);
                resultadoFCR1.SetParameterValue("Edad", (rdbTres.Checked ? 3 : rdbUno.Checked ? 1 : 7));
                resultadoFCR1.SetParameterValue("Tolerancia", txtTolerancia.Text);


                crvReporte.ReportSource = resultadoFCR1;
                //crvRepExperiencia.RefreshReport();
            }
            catch (Exception ex)
            {
                //                MessageBox.Show(ex.Message);
            }

        }

    }
}
