using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace LancNeo
{
    public partial class InfSegui : Form
    {
        public InfSegui()
        {
            InitializeComponent();
        }

        private void InfSegui_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            crvInfPrecios.Visible = true;
            dsInfSegui1.Clear();

            bool lapla = false;
            cryInfSegui1.SetDataSource(dsInfSegui1);
            cryInfSegui1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            sqlDASolicitud.SelectCommand.Parameters["@Fechai"].Value = dateTimePicker1.Value.ToShortDateString();
            sqlDASolicitud.SelectCommand.Parameters["@Fechaf"].Value = dateTimePicker2.Value.ToShortDateString();
            sqlDASolicitud.Fill(dsInfSegui1, "Solicitud");
            sqlDASolicitudCar.SelectCommand.Parameters["@Fechai"].Value = dateTimePicker1.Value.ToShortDateString();
            sqlDASolicitudCar.SelectCommand.Parameters["@Fechaf"].Value = dateTimePicker2.Value.ToShortDateString();
            sqlDASolicitudCar.Fill(dsInfSegui1, "SolicitudCar");
            sqlDASolicitudPre.SelectCommand.Parameters["@Fechai"].Value = dateTimePicker1.Value.ToShortDateString();
            sqlDASolicitudPre.SelectCommand.Parameters["@Fechaf"].Value = dateTimePicker2.Value.ToShortDateString();
            sqlDASolicitudPre.Fill(dsInfSegui1, "SolicitudPre");
            sqlDASolicitudPre1.SelectCommand.Parameters["@Fechai"].Value = dateTimePicker1.Value.ToShortDateString();
            sqlDASolicitudPre1.SelectCommand.Parameters["@Fechaf"].Value = dateTimePicker2.Value.ToShortDateString();
            sqlDASolicitudPre1.Fill(dsInfSegui1, "SolicitudPre1");
            sqlDASolicitudPre2.SelectCommand.Parameters["@Fechai"].Value = dateTimePicker1.Value.ToShortDateString();
            sqlDASolicitudPre2.SelectCommand.Parameters["@Fechaf"].Value = dateTimePicker2.Value.ToShortDateString();
            sqlDASolicitudPre2.Fill(dsInfSegui1, "SolicitudPre11");

            for (int i = 0; i < dsInfSegui1.Solicitud.Count; i++)
            {
                lapla = false;
                double visitas, semanas;
                visitas = semanas = 0;
                dsInfSegui1.SolPre.Clear();
                sqlDASolPre.SelectCommand.Parameters["@IdSolicitud"].Value = dsInfSegui1.Solicitud.Rows[i]["IdSolicitud"].ToString();
                sqlDASolPre.SelectCommand.Parameters["@Año"].Value = dsInfSegui1.Solicitud.Rows[i]["Año"].ToString();
                sqlDASolPre.Fill(dsInfSegui1, "SolPre");
                if (dsInfSegui1.SolPre.Count > 0)
                {
                    if (string.IsNullOrEmpty(dsInfSegui1.Solicitud.Rows[i]["TipoObra"].ToString()))
                        if (!string.IsNullOrEmpty(dsInfSegui1.SolPre.Rows[0]["Concepto"].ToString()))
                            if (dsInfSegui1.SolPre.Rows[0]["Concepto"].ToString().Length > 30)
                                dsInfSegui1.Solicitud.Rows[i]["TipoObra"] = dsInfSegui1.SolPre.Rows[0]["Concepto"].ToString().Substring(0, 30);
                            else
                                dsInfSegui1.Solicitud.Rows[i]["TipoObra"] = dsInfSegui1.SolPre.Rows[0]["Concepto"].ToString();
                    lapla = (dsInfSegui1.Solicitud.Rows[i]["LocFor"].ToString().Trim() == "Foranea" || dsInfSegui1.Solicitud.Rows[i]["Presupuesto"].ToString().Contains("F") ? true : false);
                    if (lapla == false)
                    {
                        for (int k = 0; k < dsInfSegui1.SolPre.Count; k++)
                        {
                            if (dsInfSegui1.SolPre.Rows[k]["IdPrecio"].ToString().Trim() == "1.02.02.")
                                semanas += double.Parse(dsInfSegui1.SolPre.Rows[k]["Cantidad"].ToString());
                            if (dsInfSegui1.SolPre.Rows[k]["IdPrecio"].ToString().Trim() == "1.02.01.")
                                visitas += double.Parse(dsInfSegui1.SolPre.Rows[k]["Cantidad"].ToString());
                        }
                        lapla = (semanas > 0 && visitas > 0 && (semanas * 6 > visitas) ? true : false);
                    }
                }
                dsInfSegui1.Solicitud.Rows[i]["IvaPrecios"] = lapla;
            }

            cryInfSegui1.SetParameterValue("Fechai", dateTimePicker1.Value.ToShortDateString());
            cryInfSegui1.SetParameterValue("Fechaf", dateTimePicker2.Value.ToShortDateString());
            crvInfPrecios.ReportSource = cryInfSegui1;
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            while (dateTimePicker1.Value.DayOfWeek != DayOfWeek.Monday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
            }
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(5);
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            while (dateTimePicker1.Value.DayOfWeek != DayOfWeek.Monday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
            }
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(5);
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            while (dateTimePicker1.Value.DayOfWeek != DayOfWeek.Monday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
            }
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(5);
        }
    }
}
