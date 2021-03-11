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
    public partial class InfAvance : Form
    {
        public InfAvance()
        {
            InitializeComponent();
        }

        private void InfAvance_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            crvInfAvance.Visible = true;
            dsAvance1.Clear();
            sqlDAObras.Fill(dsAvance1, "Obra");
            cryInfAvance1.SetDataSource(dsAvance1);
            cryInfAvance1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            sqlDAAvance.Fill(dsAvance1, "Avance");
            cryInfAvance1.SetParameterValue("Fecha", dtpFecha.Value.Date);

            crvInfAvance.ReportSource = cryInfAvance1;
        }
    }
}
