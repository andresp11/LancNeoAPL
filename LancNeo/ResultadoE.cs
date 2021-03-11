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
    public partial class ResultadoE : Form
    {
        private String strRazonSocial;
        private String strObraUbicacion;
        private String strObraColonia;
        private int Mpa;
        public ResultadoE()
        {
            InitializeComponent();
        }

        private void ResultadoE_Load(object sender, EventArgs e)
        {
            dtpIni.Value = DateTime.Today.AddDays(-6);
            dtpFin.Value = DateTime.Today.AddDays(1);
            this.WindowState = FormWindowState.Maximized;
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");

            dsResBajo1.ResBajo.AddResBajoRow(0, "Epecificada");
            dsResBajo1.ResBajo.AddResBajoRow(1, "Madura");

        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tbBtn1_Click(object sender, EventArgs e)
        {
            dgvResultado.Visible = true;
            crvReporte.Visible = false;
            Pdf.Visible = true;
            dsBajosTemp1.Clear();
            sqlDABajosTemp.SelectCommand.Parameters["@Finicial"].Value = dtpIni.Value;
            sqlDABajosTemp.SelectCommand.Parameters["@Ffinal"].Value = dtpFin.Value;
            sqlDABajosTemp.Fill(dsBajosTemp1, "Agregado");
            decimal Res, incre;
            Res = incre = 0;
            foreach (DataGridViewRow row in dgvResultado.Rows)
            {
                row.Cells[0].Value = false;
                row.Cells[1].Value = false;
                row.Cells[2].Value = false;
                //Res = decimal.Parse(row.Cells[18].Value.ToString());
                //incre = decimal.Parse(row.Cells[19].Value.ToString());
                //row.Cells[20].Value = Res + incre;
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultado.Visible = false;
                crvReporte.Visible = true;
                Pdf.Visible = false;
                resultadoECR1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                resultadoECR1.SetDataSource(dsBajosTemp1);
                dsBajosTemp1.Clear();
                sqlDABajosTemp.SelectCommand.Parameters["@Finicial"].Value = dtpIni.Value;
                sqlDABajosTemp.SelectCommand.Parameters["@Ffinal"].Value = dtpFin.Value;
                //sqlDABajosTemp.SelectCommand.Parameters["@Dia"].Value = (rdbTres.Checked ? 3 : rdbUno.Checked ? 1 : 7);
                //sqlDABajosTemp.SelectCommand.Parameters["@Tole"].Value = txtTolerancia.Text;
                sqlDABajosTemp.Fill(dsBajosTemp1, "Agregado");

                resultadoECR1.SetParameterValue("Finicial", dtpIni.Value);
                resultadoECR1.SetParameterValue("Ffinal", dtpFin.Value);
                crvReporte.ReportSource = resultadoECR1;
                //crvRepExperiencia.RefreshReport();
            }
            catch (Exception ex)
            {
                //                MessageBox.Show(ex.Message);
            }
        }

        private void Pdf_Click(object sender, EventArgs e)
        {
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
                        Mpa = (bool.Parse(row.Cells[2].Value.ToString()) == true ? 1 : 0);
                        double factor = double.Parse(dsUnidad1.Unidad.Rows[Mpa][2].ToString());
                        double Res = double.Parse(dsBajosTemp1.Agregado.Rows[i][6].ToString()) * factor;
                        string resis = (Mpa == 0 ? Res.ToString() : Res.ToString("###.00")) + " - " + dsBajosTemp1.Agregado.Rows[i][21].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][8].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][9].ToString();
                        GetDatosEmpresa(dsBajosTemp1.Agregado.Rows[i][0].ToString());
                        dsCorreos1.Clear();
                        sqlDACorreos.SelectCommand.Parameters["@IdObra"].Value = dsBajosTemp1.Agregado.Rows[i][0].ToString();
                        sqlDACorreos.Fill(dsCorreos1, "Obra");


                            dsExpMuesEE1.Clear();
                            sqlDAMuestras.SelectCommand.Parameters["@IdObra"].Value = dsBajosTemp1.Agregado.Rows[i][0].ToString();;
                            sqlDAMuestras.SelectCommand.Parameters["@IdConcretera"].Value = dsBajosTemp1.Agregado.Rows[i][5].ToString();
                            //				sqlDAMuestras.SelectCommand.Parameters["@IdPlanta"].Value = -1;
                            sqlDAMuestras.SelectCommand.Parameters["@FechaIni"].Value = Finicial;
                            sqlDAMuestras.SelectCommand.Parameters["@FechaFin"].Value = Ffinal;
                            sqlDAMuestras.SelectCommand.Parameters["@ResistenciaKg"].Value = dsBajosTemp1.Agregado.Rows[i][6].ToString();
                            sqlDAMuestras.SelectCommand.Parameters["@Tipo"].Value = dsBajosTemp1.Agregado.Rows[i][7].ToString();
                            sqlDAMuestras.SelectCommand.Parameters["@Agregado"].Value = dsBajosTemp1.Agregado.Rows[i][8].ToString();
                            sqlDAMuestras.SelectCommand.Parameters["@Revenimiento"].Value = dsBajosTemp1.Agregado.Rows[i][9].ToString();
                            sqlDAMuestras.SelectCommand.Parameters["@IdAgregado"].Value = dsBajosTemp1.Agregado.Rows[i][11].ToString();
                            sqlDAMuestras.Fill(dsExpMuesEE1, "Muestras");
                            sqlDAPromedios.SelectCommand.Parameters["@IdObra"].Value = dsBajosTemp1.Agregado.Rows[i][0].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@IdConcretera"].Value = dsBajosTemp1.Agregado.Rows[i][5].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@IdPlanta"].Value = -1;
                            sqlDAPromedios.SelectCommand.Parameters["@FechaIni"].Value = Finicial;
                            sqlDAPromedios.SelectCommand.Parameters["@FechaFin"].Value = Ffinal;
                            sqlDAPromedios.SelectCommand.Parameters["@ResistenciaKg"].Value = dsBajosTemp1.Agregado.Rows[i][6].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@Tipo"].Value = dsBajosTemp1.Agregado.Rows[i][7].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@Agregado"].Value = dsBajosTemp1.Agregado.Rows[i][8].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@Renvenimiento"].Value = dsBajosTemp1.Agregado.Rows[i][9].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@IdAgregado"].Value = dsBajosTemp1.Agregado.Rows[i][11].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@IdPrueba"].Value = dsBajosTemp1.Agregado.Rows[i][18].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@IdUnidad"].Value = dsUnidad1.Unidad.Rows[Mpa][0].ToString();
                            sqlDAPromedios.SelectCommand.Parameters["@Todos"].Value = true;
                            sqlDAPromedios.SelectCommand.Parameters["@IdDiam"].Value = dsBajosTemp1.Agregado.Rows[i][19].ToString();
                            sqlDAPromedios.Fill(dsExpMuesEE1, "Promedios");

                            string resiss;
                            double resis1;
                            resis1 = double.Parse(dsBajosTemp1.Agregado.Rows[i][6].ToString()) * double.Parse(dsUnidad1.Tables[0].Rows[Mpa][2].ToString());
                            if (double.Parse(dsUnidad1.Tables[0].Rows[Mpa][2].ToString()) == 1)
                                resiss = dsBajosTemp1.Agregado.Rows[i][6].ToString();
                            else
                                resiss = resis1.ToString("###.00");
                            string respar = resiss + " - " + dsBajosTemp1.Agregado.Rows[i][21].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][8].ToString() + " - " + dsBajosTemp1.Agregado.Rows[i][9].ToString();


                            if (bool.Parse(row.Cells[1].Value.ToString()) != true)
                            {
                                cryRepCartaEdadEspecificada = new CryRepCartaEdadEspecificada();
                                cryRepCartaEdadEspecificada.SetDataSource(dsExpMuesEE1);
                                SetCrysParams(respar, dsBajosTemp1.Agregado.Rows[i][5].ToString(), dsBajosTemp1.Agregado.Rows[i][19].ToString(), dsBajosTemp1.Agregado.Rows[i][23].ToString());
                                cryRepCartaEdadEspecificada.SetParameterValue("@Leyenda", false);
                                cryRepCartaEdadEspecificada.SetParameterValue("@Lab", true);
                                cryRepCartaEdadEspecificada.SetParameterValue("Unidades", double.Parse(dsUnidad1.Tables[0].Rows[Mpa][2].ToString()));
                            }
                            else
                            {
                                cryRepCartaEdadEspecificada = new CryRepCartaEdadEspecificadM();
                                cryRepCartaEdadEspecificada.SetDataSource(dsExpMuesEE1);
                                SetCrysParams(respar, dsBajosTemp1.Agregado.Rows[i][5].ToString(), dsBajosTemp1.Agregado.Rows[i][19].ToString(), dsBajosTemp1.Agregado.Rows[i][23].ToString());
                                cryRepCartaEdadEspecificada.SetParameterValue("@Leyenda", false);
                                cryRepCartaEdadEspecificada.SetParameterValue("@Lab", true);
                                cryRepCartaEdadEspecificada.SetParameterValue("Unidades", double.Parse(dsUnidad1.Tables[0].Rows[Mpa][2].ToString()));
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
                            CrExportOptions = cryRepCartaEdadEspecificada.ExportOptions ;
                            {
                                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                                CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                                CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                                CrExportOptions.FormatOptions = CrFormatTypeOptions;
                            }
                                cryRepCartaEdadEspecificada.Export();
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
            SqlCommand sqlCmd = new SqlCommand(strSql, sqlConn);
            try
            {
                sqlConn.Open();
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                {
                    strRazonSocial = dr["Facturar"].ToString();
                    strObraUbicacion = dr["Ubicacion"].ToString();
                    strObraColonia = dr["Colonia"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
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
            mailItem.Subject = "Carta de baja resistencia a edad especificada de la obra: " + mailSubject;
            mailItem.HTMLBody = "Enviamos los resultados de las pruebas de compresión del mortero y concreto a edades especificadas de la obra " + mailSubject
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



		private void SetCrysParams(string respar, string IdConcretera, string IdDiam, string Prueba)
		{
			ParameterValues pvs = new CrystalDecisions.Shared.ParameterValues();
				
			ParameterDiscreteValue pdvRazonsocial = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvObraUbicacion = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvObraColonia = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvTipoPrueba = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvExp3 = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvExp7 = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvUnidad = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvSINO = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvConsecutivo = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvRes = new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvConcre= new CrystalDecisions.Shared.ParameterDiscreteValue();
			ParameterDiscreteValue pdvDiam= new CrystalDecisions.Shared.ParameterDiscreteValue();

			pdvRazonsocial.Value = strRazonSocial;
			pvs.Add(pdvRazonsocial);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Razonsocial"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvObraUbicacion.Value = strObraUbicacion;
			pvs.Add(pdvObraUbicacion);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["ObraUbicacion"].ApplyCurrentValues(pvs);
			pvs.Clear();

			pdvObraColonia.Value = strObraColonia;
			pvs.Add(pdvObraColonia);
			cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["ObraColonia"].ApplyCurrentValues(pvs);
			pvs.Clear();

            pdvTipoPrueba.Value = Prueba;
            pvs.Add(pdvTipoPrueba);
            cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["TipoPrueba"].ApplyCurrentValues(pvs);
            pvs.Clear();

            pdvUnidad.Value = dsUnidad1.Unidad.Rows[Mpa][0].ToString();
            pvs.Add(pdvUnidad);
            cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Unidad"].ApplyCurrentValues(pvs);
            pvs.Clear();

            pdvSINO.Value = 0;
            pvs.Add(pdvSINO);
            cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Logotipo"].ApplyCurrentValues(pvs);
            pvs.Clear();

            pdvConsecutivo.Value =  "0";
            pvs.Add(pdvConsecutivo);
            cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Consecutivo"].ApplyCurrentValues(pvs);
            pvs.Clear();

            pdvRes.Value = respar;
            pvs.Add(pdvRes);
            cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Res"].ApplyCurrentValues(pvs);
            pvs.Clear();

            pdvConcre.Value = IdConcretera;
            pvs.Add(pdvConcre);
            cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Concre"].ApplyCurrentValues(pvs);
            pvs.Clear();

            pdvDiam.Value = IdDiam;
            pvs.Add(pdvDiam);
            cryRepCartaEdadEspecificada.DataDefinition.ParameterFields["Diam"].ApplyCurrentValues(pvs);
            pvs.Clear();

//			pdvRes1.Value = double.Parse(resis) ;
//			pvs.Add(pdvRes1);
//			cryRepCartaEdadTemprana.DataDefinition.ParameterFields["Res1"].ApplyCurrentValues(pvs);
//			pvs.Clear();
		}


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
