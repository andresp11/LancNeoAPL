using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LancNeo
{
    public partial class AnaXS : Form
    {
        public AnaXS()
        {
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


        private void AnaXS_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            dsBuscaObra1.Clear();
            dsBuscaObra1.Obra.AddObraRow("%", "Todas", " ", " ", " ", " ");
            cmbIdObra.SelectedIndex = 0;
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            sqlDABusObra.Fill(dsBuscaObra1, "Obra");
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");
            sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
            dsConcretera1.Concretera.AddConcreteraRow("%", "Todas", "%");
            sqlDAConcretera.Fill(dsConcretera1, "Concretera");
            cmbConcretera.SelectedIndex = 0;
            dsPlanta1.Planta.AddPlantaRow(-1, "Todas", cmbConcretera.SelectedValue.ToString());
            sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
            sqlDAPLanta.Fill(dsPlanta1, "Planta");
            dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1, "Todos");
            sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
            cmbNoEco.SelectedIndex = 0;
            dsBusLab1.Laboratorio.AddLaboratorioRow("%", "Todos", " ");
            sqlDALaboratorio.Fill(dsBusLab1, "Laboratorio");
            cmbIdLaboratorio.SelectedIndex = 0;
//            dsBusResistencia1.Resistencia.AddResistenciaRow(-1, "Todas");
//            sqlDARes.Fill(dsBusResistencia1, "Resistencia");
//            cmbRes.SelectedIndex = 0;
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
        }

        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            btnVistaPrevia.Visible = true;
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            try
            {
                dsAnalisisXS1.Clear();
                dsAnalisisXS1.Tables["Analisis"].Rows.Clear();
                dsAnalisisXS1.Tables["AnalisisMay"].Rows.Clear();
                sqlDAAnalisis.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
                sqlDAAnalisis.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
                sqlDAAnalisis.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
                sqlDAAnalisis.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                sqlDAAnalisis.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                sqlDAAnalisis.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
                sqlDAAnalisis.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                sqlDAAnalisis.SelectCommand.Parameters["@NoEco"].Value = cmbNoEco.SelectedValue.ToString();
                sqlDAAnalisis.SelectCommand.Parameters["@IdLaboratorio"].Value = cmbIdLaboratorio.SelectedValue.ToString();
                sqlDAAnalisis.SelectCommand.Parameters["@Nivel"].Value = (rdbMuestreador.Checked == true ? 1 : 2);
                sqlDAAnalisis.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue;
                sqlDAAnalisis.SelectCommand.Parameters["@Resistencia"].Value = txtRes.Text;
                sqlDAAnalisis.Fill(dsAnalisisXS1, "Analisis");

                sqlDAMay.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
                sqlDAMay.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
                sqlDAMay.SelectCommand.Parameters["@IdPlanta"].Value = cmbPlanta.SelectedValue.ToString();
                sqlDAMay.SelectCommand.Parameters["@FechaIni"].Value = dtpIni.Text;
                sqlDAMay.SelectCommand.Parameters["@FechaFin"].Value = dtpFin.Text;
                sqlDAMay.SelectCommand.Parameters["@IdPrueba"].Value = cmbPrueba.SelectedValue.ToString();
                sqlDAMay.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue.ToString();
                sqlDAMay.SelectCommand.Parameters["@NoEco"].Value = cmbNoEco.SelectedValue.ToString();
                sqlDAMay.SelectCommand.Parameters["@IdLaboratorio"].Value = cmbIdLaboratorio.SelectedValue.ToString();
                sqlDAMay.SelectCommand.Parameters["@Nivel"].Value = (rdbMuestreador.Checked == true ? 1 : 2);
                sqlDAMay.SelectCommand.Parameters["@Mezcla"].Value = cmbMezcla.SelectedValue;
                sqlDAMay.SelectCommand.Parameters["@Resistencia"].Value = txtRes.Text;
                sqlDAMay.Fill(dsAnalisisXS1, "AnalisisMay");


                crvRepAnalisis.Visible = true;
                cryRepAnalisiXS1.SetDataSource(dsAnalisisXS1);
                cryRepAnalisiXS1.SetParameterValue("@Con", cmbConcretera.Text);
                cryRepAnalisiXS1.SetParameterValue("@Pla", cmbPlanta.Text);
                cryRepAnalisiXS1.SetParameterValue("@Lab", cmbNoEco.Text);
                cryRepAnalisiXS1.SetParameterValue("@Cra", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][3].ToString());
                cryRepAnalisiXS1.SetParameterValue("@Dir", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][1].ToString());
                cryRepAnalisiXS1.SetParameterValue("@Obr", txtIdobra.Text);
                cryRepAnalisiXS1.SetParameterValue("@Zon", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][4].ToString());
                cryRepAnalisiXS1.SetParameterValue("@Loc", dsBuscaObra1.Tables["Obra"].Rows[cmbIdObra.SelectedIndex][5].ToString());
                cryRepAnalisiXS1.SetParameterValue("@Unidad", cmbUnidad.Text);
                cryRepAnalisiXS1.SetParameterValue("@Laboratorio", cmbIdLaboratorio.SelectedValue.ToString());
                cryRepAnalisiXS1.SetParameterValue("@Fini", dtpIni.Text);
                cryRepAnalisiXS1.SetParameterValue("@Ffin", dtpFin.Text);
                cryRepAnalisiXS1.SetParameterValue("@Resistencia", txtRes.Text);
                cryRepAnalisiXS1.SetParameterValue("@Nivel", rdbMuestreador.Checked ? "Muestreador" : "Ensayista");

                crvRepAnalisis.ReportSource = cryRepAnalisiXS1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void RepAnalisisLab_Load_1(object sender, System.EventArgs e)
        {
            dsBuscaObra1.Clear();
            dsBuscaObra1.Obra.AddObraRow("%", "Todas", " ", " ", " ", " ");
            cmbIdObra.SelectedIndex = 0;
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            sqlDABusObra.Fill(dsBuscaObra1, "Obra");
            sqlDAUnidad.Fill(dsUnidad1, "Unidad");
            sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
            dsConcretera1.Concretera.AddConcreteraRow("%", "Todas", "%");
            sqlDAConcretera.Fill(dsConcretera1, "Concretera");
            cmbConcretera.SelectedIndex = 0;
            dsPlanta1.Planta.AddPlantaRow(-1, "Todas", cmbConcretera.SelectedValue.ToString());
            sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
            sqlDAPLanta.Fill(dsPlanta1, "Planta");
            dsBusNoEco1.Laboratorista.AddLaboratoristaRow(-1, "Todos");
            sqlDANoEco.Fill(dsBusNoEco1, "Laboratorista");
            cmbNoEco.SelectedIndex = 0;
            dsBusLab1.Laboratorio.AddLaboratorioRow("%", "Todos", " ");
            sqlDALaboratorio.Fill(dsBusLab1, "Laboratorio");
            cmbIdLaboratorio.SelectedIndex = 0;
//            dsBusResistencia1.Resistencia.AddResistenciaRow(-1, "Todas");
//            sqlDARes.Fill(dsBusResistencia1, "Resistencia");
//            cmbRes.SelectedIndex = 0;
        }

        private void cmbConcretera_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cmbPlanta.Visible = true;
            dsPlanta1.Clear();
            dsPlanta1.Planta.AddPlantaRow(-1, "Todas", cmbConcretera.SelectedValue.ToString());
            sqlDAPLanta.SelectCommand.Parameters["@IdConcretera"].Value = cmbConcretera.SelectedValue.ToString();
            sqlDAPLanta.Fill(dsPlanta1, "Planta");
            cmbPlanta.SelectedIndex = 0;
        }
    }
}
