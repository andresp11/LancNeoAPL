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
    public partial class InfPresup : Form
    {
        public InfPresup()
        {
            InitializeComponent();
        }
        private static string importeLet = "";

        private void buscaBtn1_Click(object sender, EventArgs e)
        {
            txtAño.Text = dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
            txtSolicitud.Text = dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
            txtUbicacion.Text = dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][4].ToString();
            txtPresupuesto.Text = dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][7].ToString();
            txtIdObra.Text = dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][5].ToString();
            cmbZona.SelectedItem = dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][2].ToString().Trim();
            dtpFecha.Value = DateTime.Parse(dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][3].ToString());
            if (dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][8].ToString() != "")
                dtpAprobado.Value = DateTime.Parse(dsBusSol1.Solicitud.Rows[buscaBtn1.RegistroSeleccionado][8].ToString());

            dsSolicitudVer1.Clear();
            sqlDAVersion.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDAVersion.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDAVersion.Fill(dsSolicitudVer1, "CatServicios");
            btnVistaPrevia.Visible = true;
        }

        private void InfPresupuesto_Load(object sender, EventArgs e)
        {
            sqlDABusSol.Fill(dsBusSol1, "Solicitud");
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    txtUsrMov.Text = MyControl.Text;
            }
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            cmbFormato.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            string renglon = "";
            for (int i = 1; i <= nudRenglon.Value; i++)
                renglon += "\r\n";
            bool uno, dos, tres, cuatro, cinco, seis, siete, ocho;
            switch (cmbFormato.SelectedItem.ToString())
            {
                case "A":
                    uno = false;
                    dos = false;
                    tres = false;
                    cuatro = false;
                    cinco = false;
                    seis = false;
                    siete = false;
                    ocho = false;
                    break;
                case "B":
                    uno = false;
                    dos = false;
                    tres = false;
                    cuatro = false;
                    cinco = false;
                    seis = false;
                    siete = false;
                    ocho = false;
                    break;
                case "C":
                    uno = false;
                    dos = true;
                    tres = true;
                    cuatro = false;
                    cinco = true;
                    seis = false;
                    siete = false;
                    ocho = true;
                    break;
                case "D":
                    uno = false;
                    dos = true;
                    tres = true;
                    cuatro = true;
                    cinco = true;
                    seis = true;
                    siete = false;
                    ocho = true;
                    break;
                default:
                    uno = false;
                    dos = false;
                    tres = false;
                    cuatro = false;
                    cinco = false;
                    seis = false;
                    siete = false;
                    ocho = false;
                    break;
            }

            crvPresupuesto.Visible = true;
            dsInfPresup1.Clear();

            cryInfPresup1.SetDataSource(dsInfPresup1);
            cryInfPresup1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;

            sqlDASolicitud.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitud.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitud.Fill(dsInfPresup1, "Solicitud");
            sqlDASolicitudSer.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitudSer.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitudSer.Fill(dsInfPresup1, "SolicitudSer");
            sqlDASolicitudCar.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitudCar.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitudCar.Fill(dsInfPresup1, "SolicitudCar");
            sqlDASolicitudPre.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitudPre.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitudPre.SelectCommand.Parameters["@Version"].Value = cmbVersion.SelectedValue.ToString();
            sqlDASolicitudPre.Fill(dsInfPresup1, "SolicitudPre");
            sqlDASolicitudPre1.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitudPre1.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitudPre1.SelectCommand.Parameters["@Version"].Value = cmbVersion.SelectedValue.ToString();
            sqlDASolicitudPre1.Fill(dsInfPresup1, "SolicitudPre1");
            sqlDASolicitudPre2.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitudPre2.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitudPre2.SelectCommand.Parameters["@Version"].Value = cmbVersion.SelectedValue.ToString();
            sqlDASolicitudPre2.Fill(dsInfPresup1, "SolicitudPre11");
            sqlDAIntensidad.SelectCommand.Parameters["@Intensidad"].Value = dsInfPresup1.Solicitud.Rows[0][22].ToString();
            sqlDAIntensidad.Fill(dsInfPresup1, "Intensidad");

            string servicios = "";
            for (int i = 0; i < dsInfPresup1.SolicitudSer.Rows.Count; i++)
            {
                if (i > 0)
                    if (i == dsInfPresup1.SolicitudSer.Rows.Count - 1)
                        servicios += " y ";
                    else
                        servicios += ", ";

                servicios += dsInfPresup1.SolicitudSer.Rows[i][4].ToString().Trim() ;
            }

            string generales = "";
            if (dsInfPresup1.Solicitud.Rows[0][11].ToString().Trim() != "")
                generales += "Tel: " + dsInfPresup1.Solicitud.Rows[0][11].ToString().Trim() + "\n";
            if (dsInfPresup1.Solicitud.Rows[0][9].ToString().Trim() != "")
                generales += dsInfPresup1.Solicitud.Rows[0][9].ToString().Trim() + "\n";
            if (dsInfPresup1.Solicitud.Rows[0][12].ToString().Trim() != "")
                generales += "Cel: " + dsInfPresup1.Solicitud.Rows[0][12].ToString().Trim();
            decimal importe = 0;
            if (chkLetras.Checked)
            {
                string formapago = dsInfPresup1.Solicitud.Rows[0]["FormaPago"].ToString();
                int inicio = formapago.IndexOf("$");
                if (inicio != -1)
                {
                    importe = armaimporte(formapago, inicio);
                    NumaLet let;
                    let = new NumaLet();
                    let.MascaraSalidaDecimal = "00/100 M.N.";
                    let.SeparadorDecimalSalida = "pesos";
                    //                let.ApocoparUnoParteEntera = true;
                    formapago = formapago.Replace(importeLet, importeLet + " (" + let.ToCustomCardinal(importe) + ")");
                    dsInfPresup1.Solicitud.Rows[0]["FormaPago"] = formapago;
                }
                inicio = formapago.IndexOf("$", inicio + 5);
                if (inicio != -1)
                {
                    if (importe != armaimporte(formapago, inicio))
                    {
                    importe = armaimporte(formapago, inicio);
                    NumaLet let;
                    let = new NumaLet();
                    let.MascaraSalidaDecimal = "00/100 M.N.";
                    let.SeparadorDecimalSalida = "pesos";
                    //                let.ApocoparUnoParteEntera = true;
                    formapago = formapago.Replace(importeLet, importeLet + " (" + let.ToCustomCardinal(importe) + ")");
                    dsInfPresup1.Solicitud.Rows[0]["FormaPago"] = formapago;
                    }
                }
            }
            //if (dsInfPresup1.Solicitud.Rows[0][13].ToString().Trim() != "")
            //    generales += "Obra: " + dsInfPresup1.Solicitud.Rows[0][13].ToString().Trim();
            bool InsInforme = (string.IsNullOrEmpty(dsInfPresup1.Solicitud.Rows[0]["Informes"].ToString()) ? false : true);
            if (InsInforme)
                chkInstalacion.Checked = chkInstalaCala.Checked = false;


            cryInfPresup1.SetParameterValue("Firma", chkFirma.Checked);
            cryInfPresup1.SetParameterValue("Quien", (radioButton1.Checked ? 1 : 2));
            cryInfPresup1.SetParameterValue("Adicional", dsInfPresup1.SolicitudPre1.Rows.Count);
            cryInfPresup1.SetParameterValue("servicios", servicios);
            cryInfPresup1.SetParameterValue("generales", generales);
            cryInfPresup1.SetParameterValue("Intensidad", chkIntensidas.Checked);
            cryInfPresup1.SetParameterValue("Notas", chkNotas.Checked);
            cryInfPresup1.SetParameterValue("Instala", chkInstalacion.Checked);
            cryInfPresup1.SetParameterValue("InstalaCala", chkInstalaCala.Checked);
            cryInfPresup1.SetParameterValue("Elaboración", true);
            cryInfPresup1.SetParameterValue("Afiliados", true);
            cryInfPresup1.SetParameterValue("Fortaleza", true);
            cryInfPresup1.SetParameterValue("Uno", uno);
            cryInfPresup1.SetParameterValue("dos", dos);
            cryInfPresup1.SetParameterValue("tres", tres);
            cryInfPresup1.SetParameterValue("cuatro", cuatro);
            cryInfPresup1.SetParameterValue("cinco", cinco);
            cryInfPresup1.SetParameterValue("seis", seis);
            cryInfPresup1.SetParameterValue("siete", siete);
            cryInfPresup1.SetParameterValue("ocho", ocho);
            cryInfPresup1.SetParameterValue("Salto", chkSalto.Checked);
            cryInfPresup1.SetParameterValue("Salto1", chkSaltoi.Checked);
            cryInfPresup1.SetParameterValue("Soldadura", chkSoldadura.Checked);
            cryInfPresup1.SetParameterValue("ImpGen", chkAtencion.Checked);
            cryInfPresup1.SetParameterValue("Totales", chkTotales.Checked, "Paquete");
            cryInfPresup1.SetParameterValue("NotasSalto", chkSaltoNota.Checked);
            cryInfPresup1.SetParameterValue("Caracteristicas", chkCarac.Checked);
            cryInfPresup1.SetParameterValue("SalAntIns", chkSalIns.Checked);
            cryInfPresup1.SetParameterValue("@Renglon", renglon);
            cryInfPresup1.SetParameterValue("FormaPago", chkFormaPago.Checked);
            cryInfPresup1.SetParameterValue("Totales", chkTotales.Checked, "preuni");
            cryInfPresup1.SetParameterValue("TotCierra", (dsInfPresup1.SolicitudPre11.Rows.Count == 0 ? false : true), "preuni");
            cryInfPresup1.SetParameterValue("generales", generales, "preuni");
            cryInfPresup1.SetParameterValue("TotalAdi", chkTotales.Checked, "PreuniAdicionales");
            cryInfPresup1.SetParameterValue("generales", generales, "ContactosPag2");
            cryInfPresup1.SetParameterValue("ImpGen", chkAtencion.Checked, "ContactosPag2");
            cryInfPresup1.SetParameterValue("InsInforme", InsInforme);
            crvPresupuesto.ReportSource = cryInfPresup1;
            if (chkInstalacion.Checked && chkInstalaCala.Checked)
                chkInstalaCala.Checked = false;

            if (chkFirma.Checked)
            {
                            try
            {
                sqlConn.Open();
            sqlComAgrega.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlComAgrega.Parameters["@IdUsuario"].Value = txtUsrMov.Text;
            sqlComAgrega.Parameters["@Año"].Value = txtAño.Text;
            sqlComAgrega.Parameters["@Version"].Value = cmbVersion.SelectedValue;
            int error = sqlComAgrega.ExecuteNonQuery();
            MessageBox.Show("Firma registrada");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
			sqlConn.Close();

            }
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {

        }

        private void chkFirma_CheckedChanged(object sender, EventArgs e)
        {
                grBFirmas.Visible = chkFirma.Checked;
        }

        private void chkInstalaCala_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstalaCala.Checked)
                chkInstalacion.Checked = false;
        }

        private void crvPresupuesto_Load(object sender, EventArgs e)
        {

        }

        private decimal armaimporte(string formpago, int inicio)
        {
            importeLet = "";
            bool punto = true;
            bool blanco = true;
            decimal importe = 0;
            string cantidad = "0";
            for (int i = inicio; i < (inicio + 15); i++)
            {
                if (formpago.Substring(i, 1) == "0" || formpago.Substring(i, 1) == "1" || formpago.Substring(i, 1) == "2" || formpago.Substring(i, 1) == "3" || formpago.Substring(i, 1) == "4" || formpago.Substring(i, 1) == "5" || formpago.Substring(i, 1) == "6" || formpago.Substring(i, 1) == "7" || formpago.Substring(i, 1) == "8" || formpago.Substring(i, 1) == "9")
                    cantidad += formpago.Substring(i, 1);
                else if (formpago.Substring(i, 1) == "." && punto)
                {
                    cantidad += formpago.Substring(i, 1);
                    punto = false;
                }
                if (formpago.Substring(i, 1) != " " && blanco)
                    importeLet += formpago.Substring(i, 1);
                else
                    blanco = false;

            }
            cantidad = (cantidad.StartsWith("0") && cantidad.Length > 2 ? cantidad.Substring(1) : cantidad);
            cantidad = (cantidad.EndsWith(".") && cantidad.Length > 2 ? cantidad.Substring(0,cantidad.Length-1) : cantidad);
            return importe = decimal.Parse(cantidad);
        }

    }
}
