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
    public partial class InfPrecios : Form
    {
        private int regist = 1;
        public InfPrecios()
        {
            InitializeComponent();
        }

        private void InfPrecios_Load(object sender, EventArgs e)
        {
            sqlDABusPrecio.Fill(dsInfPrecios1, "Precio");
            sqlDAPreDet.Fill(dsInfPrecios1, "PrecioDet");
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            DateTime hoy = DateTime.Now.AddDays(DateTime.Now.Day - 1).AddMonths(DateTime.Now.Month - 1);
            if(DateTime.Now.Month > 6)  
                hoy = hoy.AddMonths(11 - DateTime.Now.Month);
            else
                hoy = hoy.AddMonths(5 - DateTime.Now.Month );
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            string nombreMes = formatoFecha.GetMonthName(int.Parse(hoy.Month.ToString()));
            TxtVigenccia.Text = "VIGENCIA HASTA " + nombreMes.ToUpper() + " " + DateTime.Now.Year.ToString();
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            string renglon = "";
            for (int i = 1; i <= 2; i++)
                renglon += "\r\n";
            crvInfPrecios.Visible = true;
            dsInfPrecios1.Precio1.Rows.Clear();
//            dsInfPrecios1.PrecioDet.Rows.Clear();

            cryInfPrecios1.SetDataSource(dsInfPrecios1);
            cryInfPrecios1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cryInfPreciosR1.SetDataSource(dsInfPrecios1);
            cryInfPreciosR1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;

            if (!chkRecortado.Checked)
            {
                sqlDAInfPrecios.SelectCommand.CommandText = "InfPrecios";
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True")
                    {
                        sqlDAInfPrecios.SelectCommand.Parameters["@Grupo"].Value = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
                        sqlDAInfPrecios.SelectCommand.Parameters["@Descr"].Value = regist;
                        sqlDAInfPrecios.SelectCommand.Parameters["@Imprime"].Value = chechkTodos.Checked;
                        sqlDAInfPrecios.Fill(dsInfPrecios1, "Precio1");
                        cryInfPrecios1.SetParameterValue("Vigencia", TxtVigenccia.Text);
                        cryInfPrecios1.SetParameterValue("Caratula", chkCaratula.Checked);
                        crvInfPrecios.ReportSource = cryInfPrecios1;
                    }
                }
            }
            else
            {
                sqlDAInfPrecios.SelectCommand.CommandText = "InfPreciosR";
                sqlDAInfPrecios.SelectCommand.Parameters["@Grupo"].Value = "";
                sqlDAInfPrecios.SelectCommand.Parameters["@Descr"].Value = regist;
                sqlDAInfPrecios.SelectCommand.Parameters["@Imprime"].Value = chechkTodos.Checked;
                sqlDAInfPrecios.Fill(dsInfPrecios1, "Precio1");
                cryInfPreciosR1.SetParameterValue("Vigencia", TxtVigenccia.Text);
                cryInfPreciosR1.SetParameterValue("Caratula", chkCaratula.Checked);
                cryInfPreciosR1.SetParameterValue("Activo", chkActivo.Checked);

                crvInfPrecios.ReportSource = cryInfPreciosR1;
            }
            chkOpciones.Checked = false;
        }

        private void crvInfPrecios_Load(object sender, EventArgs e)
        {

        }

        private void chechkTodos_CheckedChanged(object sender, EventArgs e)
        {
            chkCaratula.Checked = (chechkTodos.Checked ? false : true);
        }
        private void rbtSe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtLp.Checked) regist = 1;
            if (rbtSe.Checked) regist = 2;
            if (rbtRz.Checked) regist = 3;
        }

        private void chkOpciones_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOpciones.Checked)
                crvInfPrecios.Visible = false;
        }

    }
}
