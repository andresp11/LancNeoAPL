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

namespace LancNeo
{
    public partial class RepSemNorAr : Form
    {
        public RepSemNorAr()
        {
            InitializeComponent();
            ArrayList Mezcla = new ArrayList();
            Mezcla.Add(new matCombo("Concreto", 1));
            Mezcla.Add(new matCombo("Mortero", 2));
            cmbMezcla.DataSource = Mezcla; //DataSource for lookup table 
            cmbMezcla.DisplayMember = "getName"; //Display value in lookup table
            cmbMezcla.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows

            //
            // TODO: agregar código de constructor después de llamar a InitializeComponent
            //
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


        private void RepSemNorAr_Load(object sender, EventArgs e)
        {
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
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            buscaBtn1.Visible = false;
            dsBusEspMues1.Clear();
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            LlenasSqlDA(); 
            buscaBtn1.Visible = true;
            
        }
        private void LlenasSqlDA()
        {
            sqlDABusEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
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
            cryRepSemNormalAR1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryRepSemNormalAR1.SetDataSource(dsRepSemNormal1);
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvMezcla = new CrystalDecisions.Shared.ParameterDiscreteValue();
                pdvMezcla.Value = cmbMezcla.Text;
                CrystalDecisions.Shared.ParameterDiscreteValue pdvFirma1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCargo1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
                pdvFirma1.Value = dsFirmas1.Tables["Firmas"].Rows[0][1].ToString();
                pdvCargo1.Value = dsFirmas1.Tables["Firmas"].Rows[0][2].ToString();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvFirma2 = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCargo2 = new CrystalDecisions.Shared.ParameterDiscreteValue();
                pdvFirma2.Value = dsFirmas1.Tables["Firmas"].Rows[1][1].ToString();
                pdvCargo2.Value = dsFirmas1.Tables["Firmas"].Rows[1][2].ToString();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvFirma3 = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCargo3 = new CrystalDecisions.Shared.ParameterDiscreteValue();
                pdvFirma3.Value = dsFirmas1.Tables["Firmas"].Rows[2][1].ToString();
                pdvCargo3.Value = dsFirmas1.Tables["Firmas"].Rows[2][2].ToString();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvFirma4 = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCargo4 = new CrystalDecisions.Shared.ParameterDiscreteValue();
                pdvFirma4.Value = dsFirmas1.Tables["Firmas"].Rows[3][1].ToString();
                pdvCargo4.Value = dsFirmas1.Tables["Firmas"].Rows[3][2].ToString();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvLogo = new CrystalDecisions.Shared.ParameterDiscreteValue();
                pdvLogo.Value = chbLogo.Checked;
                pvCollection.Clear();
                pvCollection.Add(pdvMezcla);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@Mezcla"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvFirma1);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@F1"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvCargo1);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@C1"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvFirma2);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@F2"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvCargo2);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@C2"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvFirma3);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@F3"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvCargo3);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@C3"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvFirma4);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@F4"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvCargo4);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@C4"].ApplyCurrentValues(pvCollection);
                pvCollection.Clear();
                pvCollection.Add(pdvLogo);
                cryRepSemNormalAR1.DataDefinition.ParameterFields["@Ruta"].ApplyCurrentValues(pvCollection);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("parametro" + ex1.Message);
            }
            try
            {
                crvRepSemNormal.Visible = true;
                dsRepSemNormal1.Clear();
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdConcretera"].Value = (cmbConcretera.SelectedValue.ToString() == "Todas" ? "%" : cmbConcretera.SelectedValue.ToString());
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdPlanta"].Value = (cmbPlanta.SelectedIndex == 0 ? "%" : cmbPlanta.SelectedValue.ToString());
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdReporte"].Value = 4;
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue.ToString();
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@Nulos"].Value = chbImprime.Checked;
                    sqlDARepSemNormalLogo.SelectCommand.Parameters["@Secuencia"].Value = chbRevisa.Checked;
                    sqlDARepSemNormalLogo.Fill(dsRepSemNormal1, "RepSemNormal");
                int cuantos = dsRepSemNormal1.Tables["RepSemNormal"].Rows.Count;

                sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = cmbMezcla.SelectedValue;
                sqlDANorma.Fill(dsRepSemNormal1, "Normas");
                cryRepSemNormalAR1.SetParameterValue("@F5", dsFirmas1.Tables["Firmas"].Rows[4][1].ToString());
                cryRepSemNormalAR1.SetParameterValue("@C5", dsFirmas1.Tables["Firmas"].Rows[4][2].ToString());
                cryRepSemNormalAR1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
                cryRepSemNormalAR1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
                cryRepSemNormalAR1.SetParameterValue("@Lab", chbLab.Checked);

                crvRepSemNormal.ReportSource = cryRepSemNormalAR1;
                    //crvRepSemNormal.RefreshReport();
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

        private void cmbIdObra_Enter(object sender, EventArgs e)
        {
            buscaBtn1.Visible = false;
        }

    }
}
