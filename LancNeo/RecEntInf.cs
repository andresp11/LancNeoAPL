using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data.SqlClient;
using System.Globalization;
namespace LancNeo
{
    public partial class RecEntInf : Form
    {
        public RecEntInf()
        {
            InitializeComponent();
        }

        private void RecEntInf_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lancDataSet.Zona' Puede moverla o quitarla según sea necesario.
            this.zonaTableAdapter1.Fill(this.lancDataSet.Zona);
            // TODO: esta línea de código carga datos en la tabla 'dsUbicacion.Zona' Puede moverla o quitarla según sea necesario.
            this.zonaTableAdapter.Fill(this.dsUbicacion.Zona);
            dtpFecha.Value = DateTime.Now;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cmbUbicacion.SelectedIndex = 0;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                crvRepMuestreador.Visible = true;
                dsRecEntInf1.Clear();

                cryRecEntInf1.SetDataSource(dsRecEntInf1);
                sqlDAMuestra.SelectCommand.Parameters["@Fensaye"].Value = dtpFecha.Text;
                sqlDAMuestra.SelectCommand.Parameters["@Ubicacion"].Value = cmbUbicacion.SelectedIndex;
                sqlDAMuestra.Fill(dsRecEntInf1, "Especimen");

                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo; 
                Calendar cal = dfi.Calendar;
                DateTime Fechas = dtpFecha.Value;
                int semana = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(Fechas, CalendarWeekRule.FirstFourDayWeek, dfi.FirstDayOfWeek);

                semana = (Fechas.Year == 2016 ? semana - 1 : semana);
                Fechas = Fechas.AddDays(1);

                cryRecEntInf1.SetParameterValue("Fec1", dtpFecha.Text);
                cryRecEntInf1.SetParameterValue("Fec2", Fechas);
                cryRecEntInf1.SetParameterValue("Fec3", Fechas.AddDays(1));
                cryRecEntInf1.SetParameterValue("Fec4", Fechas.AddDays(2));
                cryRecEntInf1.SetParameterValue("Fec5", Fechas.AddDays(3));
                cryRecEntInf1.SetParameterValue("Fec6", Fechas.AddDays(4));
                cryRecEntInf1.SetParameterValue("Semana", semana);

                crvRepMuestreador.ReportSource = cryRecEntInf1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVistaPrevia_Load(object sender, EventArgs e)
        {

        }
    }
}
