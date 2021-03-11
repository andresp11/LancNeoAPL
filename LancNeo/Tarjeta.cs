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
    public partial class Tarjeta : Form
    {
        public Tarjeta()
        {
            InitializeComponent();
        }

        private void Tarjeta_Load(object sender, EventArgs e)
        {
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            cmbIdObra.SelectedIndex = 0;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    sqlConn.Open();
                    sqlComAgrega.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                    sqlComAgrega.Parameters["@Fini"].Value = "01/01/2001";
                    sqlComAgrega.Parameters["@Ffin"].Value = DateTime.Now.AddDays(30).ToShortDateString();
                    sqlComAgrega.Parameters["@Mortero"].Value = 0;
                    sqlComAgrega.Parameters["@IdObraM"].Value = cmbIdObra.SelectedValue;
                    int error = sqlComAgrega.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConn.Close();

                crvRepTarjeta.Visible = true;
                dsTarjeta1.Clear();
                dsServicios1.Clear();
                cryTarjeta1.SetDataSource(dsTarjeta1);
                sqlDAObra.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlDAObra.Fill(dsTarjeta1, "Obra");
                sqlDAEmpresa.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlDAEmpresa.Fill(dsTarjeta1, "Razonsocial");
                sqlDACliente.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlDACliente.Fill(dsTarjeta1, "Cliente");
                sqlDAServicios.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
                sqlDAServicios.Fill(dsServicios1, "Servicios");
                dsTarjeta1.SerFec.Rows.Add(DateTime.Now, DateTime.Now);
                if (dsServicios1.Servicios.Rows.Count > 0)
                {
                    dsTarjeta1.SerFec.Rows[0][0] = dsServicios1.Servicios.Rows[0][1].ToString();
                    dsTarjeta1.SerFec.Rows[0][1] = dsServicios1.Servicios.Rows[dsServicios1.Servicios.Rows.Count-1][1].ToString();
                }
                //                cryRepEnsayeProbeta1.SetParameterValue("Fecha", dtpFecha.Text);
                crvRepTarjeta.ReportSource = cryTarjeta1;
                //crvRepMuestreador.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
