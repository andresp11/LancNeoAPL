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
    public partial class InfCliente : Form
    {
        public InfCliente()
        {
            InitializeComponent();
        }

        private void InfCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            dsBusObra1.Clear();
            dsBusObra1.Obra.AddObraRow("Todas", "Todas", " ", " ");
            sqlDABusObra.Fill(dsBusObra1, "Obra");

        }
        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            crvInfCompacta.Visible = true;
            dsInfCliente1.Clear();

            cryInfCliente1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryInfCliente1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            cryInfCliente1.SetDataSource(dsInfCliente1);
            sqlDACliente.SelectCommand.Parameters["@IdObra"].Value = (cmbIdObra.SelectedValue.ToString()  == "Todas" ? "Todas" : cmbIdObra.SelectedValue.ToString().Substring(0,3)+"%") ;
            sqlDACliente.Fill(dsInfCliente1, "Cliente");

            sqlDAPerCli.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAPerCli.Fill(dsInfCliente1, "PermisoEmpresa");

            crvInfCompacta.ReportSource = cryInfCliente1;
        }


    }
}
