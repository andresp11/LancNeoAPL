using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using CrystalDecisions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace LancNeo
{
    public partial class RepNorLo10 : Form
    {
        public RepNorLo10()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-MX");
            InitializeComponent();
            ArrayList Mezcla = new ArrayList();
            Mezcla.Add(new matCombo("Concreto", 1));
            Mezcla.Add(new matCombo("Mortero", 2));
            cmbMezcla.DataSource = Mezcla; //DataSource for lookup table 
            cmbMezcla.DisplayMember = "getName"; //Display value in lookup table
            cmbMezcla.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
        }
        protected struct matCombo
        {
            private string Descripcion;
            private int Identificador;
            public matCombo(string Nombre, int id)
            {
                Descripcion = Nombre;
                Identificador = id;
            }
            public string getName
            {
                get
                {
                    return Descripcion;
                }
            }
            public int getId
            {
                get
                {
                    return Identificador;
                }
            }
        }
        protected struct matCombo1
        {
            private string Descripcion;
            private short Identificador;
            public matCombo1(string Nombre, short id)
            {
                Descripcion = Nombre;
                Identificador = id;
            }
            public string getName
            {
                get
                {
                    return Descripcion;
                }
            }
            public short getId
            {
                get
                {
                    return Identificador;
                }
            }
        }
        protected struct matComboS
        {
            private string Descripcion;
            private string Identificador;
            public matComboS(string Nombre, string id)
            {
                Descripcion = Nombre;
                Identificador = id;
            }
            public string getName
            {
                get
                {
                    return Descripcion;
                }
            }
            public string getId
            {
                get
                {
                    return Identificador;
                }
            }
        }

        private void RepNorLo10_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    txtUsrMov.Text = MyControl.Text;
            }
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //if (txtUsrMov.Text.Trim().ToUpper() == "DELFINO" || txtUsrMov.Text.Trim().ToUpper() == "JULIO" || txtUsrMov.Text.Trim().ToUpper() == "ADMIN")
            //    dsBusObra1.Obra.AddObraRow("Todas", " ", "RFCAAMMDD123", " ");
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            sqlDAFirmas.Fill(dsFirmas1, "Firmas");
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");
            sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
            dsConcretera1.Concretera.AddConcreteraRow("Todas", "%", "%");
            sqlDAConcretera.Fill(dsConcretera1, "Concretera");
            cmbConcretera.SelectedIndex = 0;
            dsPlanta1.Planta.AddPlantaRow(-1, "Todas", cmbConcretera.SelectedValue.ToString());
            sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
            sqlDAPLanta.Fill(dsPlanta1, "Planta");
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dsBusEspMues1.Clear();
            //			crvRepMuestreador.Visible = false;
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            buscaBtn1.Visible = true;
            if (txtUsrMov.Text.Trim().ToUpper() == "DELFINO" || txtUsrMov.Text.Trim().ToUpper() == "JULIO" || txtUsrMov.Text.Trim().ToUpper() == "ADMIN")
                Pdf.Visible = true;
            btnVistaPrevia.Visible = true;
            LlenasSqlDA();
        }
        private void LlenasSqlDA()
        {
            sqlDABusEspecimen.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "AC " : cmbIdObra.SelectedValue.ToString());
            sqlDABusEspecimen.Fill(dsBusEspMues1, "Especimen");
        }

        private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbConcretera.SelectedIndex == 0)
                cmbPlanta.Enabled = false;
            else
                cmbPlanta.Enabled = true;
            dsPlanta1.Clear();
            dsPlanta1.Planta.AddPlantaRow(-1, "Todas", cmbConcretera.SelectedValue.ToString());
            sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
            sqlDAPLanta.Fill(dsPlanta1, "Planta");
            cmbPlanta.SelectedIndex = 0;
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {

            try
            {
                crvRepSemNormal.Visible = true;
                dsRepNo10Neo1.Clear();
                DataSet ds = new DataSet();
//                if (cmbIdObra.SelectedValue.ToString().Substring(0, 3) != "EBY")
                if(chbLogo.Checked)
                {
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "%" : cmbIdObra.SelectedValue.ToString());
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdPlanta"].Value = (cmbPlanta.SelectedIndex == 0 ? "%" : cmbPlanta.SelectedValue.ToString());
                    sqlDARepSemNormal.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                    sqlDARepSemNormal.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdReporte"].Value = 5;
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                    sqlDARepSemNormal.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue.ToString();
                    sqlDARepSemNormal.SelectCommand.Parameters["@Nulos"].Value = chbImprime.Checked;
                    sqlDARepSemNormal.SelectCommand.Parameters["@Secuencia"].Value = chbRevisa.Checked;
//                    sqlDARepSemNormal.Fill(ds);
                    sqlDARepSemNormal.Fill(dsRepNo10Neo1, "RepSemLo10");
                    int cuantos = dsRepNo10Neo1.Tables["RepSemLo10"].Rows.Count;
                    sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = cmbMezcla.SelectedValue;
                    sqlDANorma.Fill(dsRepNo10Neo1, "Normas");
                    sqlDADiametro.Fill(dsRepNo10Neo1, "Diametro");
                    cryRepNo10Neo1.SetDataSource(dsRepNo10Neo1);
                    cryRepNo10Neo1.SetParameterValue("@F1", dsFirmas1.Tables["Firmas"].Rows[0][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C1", dsFirmas1.Tables["Firmas"].Rows[0][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@F2", dsFirmas1.Tables["Firmas"].Rows[1][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C2", dsFirmas1.Tables["Firmas"].Rows[1][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@F3", dsFirmas1.Tables["Firmas"].Rows[2][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C3", dsFirmas1.Tables["Firmas"].Rows[2][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@F4", dsFirmas1.Tables["Firmas"].Rows[3][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C4", dsFirmas1.Tables["Firmas"].Rows[3][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@F5", dsFirmas1.Tables["Firmas"].Rows[4][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C5", dsFirmas1.Tables["Firmas"].Rows[4][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@Mezcla", (cmbMezcla.SelectedValue.ToString() == "1" ? "Concreto" : "Mortero"));
                    cryRepNo10Neo1.SetParameterValue("@Ruta", chbLogo.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Lab", chbLab.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                    cryRepNo10Neo1.SetParameterValue("@mucf", chkMUCF.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Preliminar", false);
                    cryRepNo10Neo1.SetParameterValue("@Respaldo", chbRespaldo.Checked);

                    crvRepSemNormal.ReportSource = cryRepNo10Neo1;
                }
                else
                {
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "%" : cmbIdObra.SelectedValue.ToString());
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdPlanta"].Value = (cmbPlanta.SelectedIndex == 0 ? "%" : cmbPlanta.SelectedValue.ToString());
                    sqlDARepSemNormal.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                    sqlDARepSemNormal.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdReporte"].Value = 5;
                    sqlDARepSemNormal.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                    sqlDARepSemNormal.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue.ToString();
                    sqlDARepSemNormal.SelectCommand.Parameters["@Nulos"].Value = chbImprime.Checked;
                    sqlDARepSemNormal.SelectCommand.Parameters["@Secuencia"].Value = chbRevisa.Checked;
                    //                    sqlDARepSemNormal.Fill(ds);
                    sqlDARepSemNormal.Fill(dsRepNo10Neo1, "RepSemLo10");
                    int cuantos = dsRepNo10Neo1.Tables["RepSemLo10"].Rows.Count;
                    sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = cmbMezcla.SelectedValue;
                    sqlDANorma.Fill(dsRepNo10Neo1, "Normas");
                    sqlDADiametro.Fill(dsRepNo10Neo1, "Diametro");
                    cryRepNo10Neo1.SetDataSource(dsRepNo10Neo1);
                    cryRepNo10Neo1.SetParameterValue("@F1", dsFirmas1.Tables["Firmas"].Rows[0][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C1", dsFirmas1.Tables["Firmas"].Rows[0][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@F2", dsFirmas1.Tables["Firmas"].Rows[1][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C2", dsFirmas1.Tables["Firmas"].Rows[1][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@F3", dsFirmas1.Tables["Firmas"].Rows[2][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C3", dsFirmas1.Tables["Firmas"].Rows[2][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@F4", dsFirmas1.Tables["Firmas"].Rows[3][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C4", dsFirmas1.Tables["Firmas"].Rows[3][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@F5", dsFirmas1.Tables["Firmas"].Rows[4][1].ToString());
                    cryRepNo10Neo1.SetParameterValue("@C5", dsFirmas1.Tables["Firmas"].Rows[4][2].ToString());
                    cryRepNo10Neo1.SetParameterValue("@Mezcla", (cmbMezcla.SelectedValue.ToString() == "1" ? "Concreto" : "Mortero"));
                    cryRepNo10Neo1.SetParameterValue("@Ruta", chbLogo.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Lab", chbLab.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                    cryRepNo10Neo1.SetParameterValue("@mucf", chkMUCF.Checked);
                    cryRepNo10Neo1.SetParameterValue("@Preliminar", false);
                    cryRepNo10Neo1.SetParameterValue("@Respaldo", chbRespaldo.Checked);

                    crvRepSemNormal.ReportSource = cryRepNo10Neo1;
                    //    sqlDASemNormalE.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "%" : cmbIdObra.SelectedValue.ToString());
                    //    sqlDASemNormalE.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
                    //    sqlDASemNormalE.SelectCommand.Parameters["@IdPlanta"].Value = (cmbPlanta.SelectedIndex == 0 ? "%" : cmbPlanta.SelectedValue.ToString());
                    //    sqlDASemNormalE.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                    //    sqlDASemNormalE.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                    //    sqlDASemNormalE.SelectCommand.Parameters["@IdReporte"].Value = 5;
                    //    sqlDASemNormalE.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                    //    sqlDASemNormalE.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue.ToString();
                    //    sqlDASemNormalE.SelectCommand.Parameters["@Nulos"].Value = chbImprime.Checked;
                    //    sqlDASemNormalE.SelectCommand.Parameters["@Secuencia"].Value = chbRevisa.Checked;
                    //    sqlDASemNormalE.Fill(dsRepNo10Neo1, "RepSemLo10");
                    //int cuantos = dsRepNo10Neo1.Tables["RepSemLo10"].Rows.Count;
                    //sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = cmbMezcla.SelectedValue;
                    //sqlDANorma.Fill(dsRepNo10Neo1, "Normas");
                    //cryRepNo10NeoE1.SetDataSource(dsRepNo10Neo1);
                    //cryRepNo10NeoE1.SetParameterValue("@F1", dsFirmas1.Tables["Firmas"].Rows[0][1].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@C1", dsFirmas1.Tables["Firmas"].Rows[0][2].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@F2", dsFirmas1.Tables["Firmas"].Rows[1][1].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@C2", dsFirmas1.Tables["Firmas"].Rows[1][2].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@F3", dsFirmas1.Tables["Firmas"].Rows[2][1].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@C3", dsFirmas1.Tables["Firmas"].Rows[2][2].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@F4", dsFirmas1.Tables["Firmas"].Rows[3][1].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@C4", dsFirmas1.Tables["Firmas"].Rows[3][2].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@F5", dsFirmas1.Tables["Firmas"].Rows[4][1].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@C5", dsFirmas1.Tables["Firmas"].Rows[4][2].ToString());
                    //cryRepNo10NeoE1.SetParameterValue("@Mezcla", (cmbMezcla.SelectedValue.ToString() == "1" ? "Concreto" : "Mortero"));
                    //cryRepNo10NeoE1.SetParameterValue("@Ruta", chbLogo.Checked);
                    //cryRepNo10NeoE1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                    //cryRepNo10NeoE1.SetParameterValue("@Lab", chbLab.Checked);
                    //cryRepNo10NeoE1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
                    //cryRepNo10NeoE1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                    //cryRepNo10NeoE1.SetParameterValue("@mucf", chkMUCF.Checked);
                    //cryRepNo10NeoE1.SetParameterValue("@Respaldo", chbRespaldo.Checked);

                    //crvRepSemNormal.ReportSource = cryRepNo10NeoE1;
                    //    //crvRepSemNormal.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            dtpIni.Text = dsBusEspMues1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
            btnVistaPrevia.Visible = true;
        }

        private void cryRepNo10NeoE1_InitReport(object sender, EventArgs e)
        {

        }

        private void Pdf_Click(object sender, EventArgs e)
        {
            try
            {
                crvRepSemNormal.Visible = true;
                dsRepNo10Neo2.Clear();
                sqlDARepSemNormal.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString() == "Todas" ? "%" : cmbIdObra.SelectedValue.ToString());
                sqlDARepSemNormal.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
                sqlDARepSemNormal.SelectCommand.Parameters["@IdPlanta"].Value = (cmbPlanta.SelectedIndex == 0 ? "%" : cmbPlanta.SelectedValue.ToString());
                sqlDARepSemNormal.SelectCommand.Parameters["@FechaIni"].Value = dtpFin.Text;
                sqlDARepSemNormal.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                sqlDARepSemNormal.SelectCommand.Parameters["@IdReporte"].Value = 5;
                sqlDARepSemNormal.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                sqlDARepSemNormal.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue.ToString();
                sqlDARepSemNormal.SelectCommand.Parameters["@Nulos"].Value = chbImprime.Checked;
                sqlDARepSemNormal.SelectCommand.Parameters["@Secuencia"].Value = chbRevisa.Checked;
                sqlDARepSemNormal.Fill(dsRepNo10Neo2, "RepSemLo10");
                int cuantos = dsRepNo10Neo2.Tables["RepSemLo10"].Rows.Count;
                string obra = "    ";
                for (int i = 0; i < cuantos; i++)
                {
                    if (obra != dsRepNo10Neo2.Tables["RepSemLo10"].Rows[i][0].ToString())
                    {
                        dsRepNo10Neo1.Clear();
                        dsCorreos1.Clear();
                        sqlDARepSemNormal.SelectCommand.Parameters["@IdObra"].Value = dsRepNo10Neo2.Tables["RepSemLo10"].Rows[i][0].ToString();
                        sqlDARepSemNormal.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
                        sqlDARepSemNormal.SelectCommand.Parameters["@IdPlanta"].Value = (cmbPlanta.SelectedIndex == 0 ? "%" : cmbPlanta.SelectedValue.ToString());
                        sqlDARepSemNormal.SelectCommand.Parameters["@FechaIni"].Value = dtpFin.Text;
                        sqlDARepSemNormal.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                        sqlDARepSemNormal.SelectCommand.Parameters["@IdReporte"].Value = 5;
                        sqlDARepSemNormal.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                        sqlDARepSemNormal.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue.ToString();
                        sqlDARepSemNormal.SelectCommand.Parameters["@Nulos"].Value = chbImprime.Checked;
                        sqlDARepSemNormal.SelectCommand.Parameters["@Secuencia"].Value = chbRevisa.Checked;
                        sqlDARepSemNormal.Fill(dsRepNo10Neo1, "RepSemLo10");
                        sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = cmbMezcla.SelectedValue;
                        sqlDANorma.Fill(dsRepNo10Neo1, "Normas");
                        sqlDACorreos.SelectCommand.Parameters["@IdObra"].Value = dsRepNo10Neo2.Tables["RepSemLo10"].Rows[i][0].ToString();
                        sqlDACorreos.Fill(dsCorreos1, "Obra");
                        cryRepNo10Neo1.SetDataSource(dsRepNo10Neo1);
                        cryRepNo10Neo1.SetParameterValue("@F1", dsFirmas1.Tables["Firmas"].Rows[0][1].ToString());
                        cryRepNo10Neo1.SetParameterValue("@C1", dsFirmas1.Tables["Firmas"].Rows[0][2].ToString());
                        cryRepNo10Neo1.SetParameterValue("@F2", dsFirmas1.Tables["Firmas"].Rows[1][1].ToString());
                        cryRepNo10Neo1.SetParameterValue("@C2", dsFirmas1.Tables["Firmas"].Rows[1][2].ToString());
                        cryRepNo10Neo1.SetParameterValue("@F3", dsFirmas1.Tables["Firmas"].Rows[2][1].ToString());
                        cryRepNo10Neo1.SetParameterValue("@C3", dsFirmas1.Tables["Firmas"].Rows[2][2].ToString());
                        cryRepNo10Neo1.SetParameterValue("@F4", dsFirmas1.Tables["Firmas"].Rows[3][1].ToString());
                        cryRepNo10Neo1.SetParameterValue("@C4", dsFirmas1.Tables["Firmas"].Rows[3][2].ToString());
                        cryRepNo10Neo1.SetParameterValue("@F5", dsFirmas1.Tables["Firmas"].Rows[4][1].ToString());
                        cryRepNo10Neo1.SetParameterValue("@C5", dsFirmas1.Tables["Firmas"].Rows[4][2].ToString());
                        cryRepNo10Neo1.SetParameterValue("@Mezcla", (cmbMezcla.SelectedValue.ToString() == "1" ? "Concreto" : "Mortero"));
                        cryRepNo10Neo1.SetParameterValue("@Ruta", chbLogo.Checked);
                        cryRepNo10Neo1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                        cryRepNo10Neo1.SetParameterValue("@Lab", chbLab.Checked);
                        cryRepNo10Neo1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
                        cryRepNo10Neo1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                        cryRepNo10Neo1.SetParameterValue("@mucf", chkMUCF.Checked);
                        cryRepNo10Neo1.SetParameterValue("@Preliminar", true);

                        DateTime fechas = dtpFin.Value;
                        string nombre = "";
                        string obraC = dsRepNo10Neo2.Tables["RepSemLo10"].Rows[i][0].ToString();
                        obraC = obraC.Replace("/","-");
                        obraC = obraC.Replace("\\", "-");
                        //                        obraC = Regex.Replace("\\", obraC,"-"); //obraC.Replace('\\', '-');
                        int lugar = obraC.IndexOf('\\');
                        if(lugar > 2)
                            obraC = obraC.Substring(0,lugar-1) + "-" + obraC.Substring(lugar);
                        nombre = obraC + fechas.ToString("yyMMdd") + ".pdf";
                        try
                        {
                            ExportOptions CrExportOptions;
                            DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                            PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                            CrDiskFileDestinationOptions.DiskFileName = "c:\\correos\\" + obraC  + fechas.ToString("yyMMdd")+ ".pdf";
                            CrExportOptions = cryRepNo10Neo1.ExportOptions;
                            {
                                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                                CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                                CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                                CrExportOptions.FormatOptions = CrFormatTypeOptions;
                            }
                            cryRepNo10Neo1.Export();
                            string direccion = "";
                            bool sipaso = false;
                            for (int j = 1; j < 6; j++)
                                direccion = direccion + (dsCorreos1.Obra.Rows[0][j].ToString() != "" ? dsCorreos1.Obra.Rows[0][j].ToString() + "; " : "");
                            obraC = CrDiskFileDestinationOptions.DiskFileName.ToString();
                            if(direccion.Length > 10)
                                sipaso = SendEmailWithOutlook(direccion, dsRepNo10Neo2.Tables["RepSemLo10"].Rows[i][0].ToString(), "Enviamos preeliminares", obraC, nombre);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

//                        
                        crvRepSemNormal.ReportSource = cryRepNo10Neo1;
                        obra = dsRepNo10Neo2.Tables["RepSemLo10"].Rows[i][0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static Boolean SendEmailWithOutlook(string mailDirection, string mailSubject, string mailContent, string nombre, string filename)
        {
            try
            {
                Microsoft.Office.Interop.Outlook._Application oApp = new Microsoft.Office.Interop.Outlook.Application();

                Microsoft.Office.Interop.Outlook.NameSpace ns = oApp.GetNamespace("MAPI");
//                var f = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

                System.Threading.Thread.Sleep(1000);

                var mailItem = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                mailItem.Subject = "Informe preliminar de la obra: " + mailSubject;
                mailItem.HTMLBody = "Enviamos los resultados preliminares de las pruebas de compresión del mortero y concreto a edades tempranas de la obra " + mailSubject 
                + "<br> en archivo adjunto. <br> <br> Estamos a sus ordenes para cualquier aclaración";
                mailItem.To = mailDirection;
                mailItem.Attachments.Add(nombre, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue,
                    1, filename);
                mailItem.Send();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
            }
            return true;
        }

    }
}
