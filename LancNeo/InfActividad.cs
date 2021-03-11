using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LancNeo
{
    public partial class InfActividad : Form
    {
        public InfActividad()
        {
            InitializeComponent();
        }

        private void InfActividad_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            sqlDABusObra.Fill(dsBusObra1, "Obra");

        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            sqlDADuracion.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString().Trim();
            sqlDADuracion.Fill(ds);
            DateTime fini = DateTime.Today;
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString().Length > 0) fini = DateTime.Parse(ds.Tables[0].Rows[0][0].ToString());
            DataSet ds1 = new DataSet();
            sqlDADuraPres.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString().Trim();
            sqlDADuraPres.Fill(ds1);
            int Semanas = 0;
            if (ds1.Tables[0].Rows.Count > 0 && ds1.Tables[0].Rows[0][0].ToString().Length > 0) Semanas = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
            crvInfPrecios.Visible = true;
            dsInfActividad1.Clear();

            cryInfActividad1.SetDataSource(dsInfActividad1);
            cryInfActividad1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            sqlDAActividad.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDAActividad.Fill(dsInfActividad1, "Actividad");
            sqlDAIntensidad.SelectCommand.Parameters["@IdIntensidad"].Value = dsInfActividad1.Actividad.Rows[0][2].ToString();
            sqlDAIntensidad.Fill(dsInfActividad1, "Intensidad");
            sqlDAObra.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDAObra.Fill(dsInfActividad1, "Obra");

            if (dsInfActividad1.Obra.Rows.Count > 0)
            {
                string carac = dsInfActividad1.Obra.Rows[0]["Caracteristica"].ToString();
                for (int i = 0; i < 10; i++)
                    carac = carac.Replace("  ", " ");
            }
            cryInfActividad1.SetParameterValue("FecIni", fini);
            cryInfActividad1.SetParameterValue("Semanas", Semanas);

            crvInfPrecios.ReportSource = cryInfActividad1;

        }
    }
}
