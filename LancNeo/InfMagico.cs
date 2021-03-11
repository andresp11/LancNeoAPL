using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Configuration;
using System.Globalization;

namespace LancNeo
{
    public partial class InfMagico : Form
    {
        public InfMagico()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            crvRepTarjeta.Visible = true;
            dsInfMagico1.Clear();
            string clv = "";
            try
            {
                DateTime fecha = dTPHoy.Value.Date;
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;
                //object[] findTheseVals = new object[3];
                //string connOle = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\ServidorN\\Empresas\\Apl\\dcmcxc_db.mdb;";
                ////                string connOle = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Compartido\\Delfino\\CAPL\\Empresas\\Apl\\dcmcxc_db.mdb;";
                //System.Data.OleDb.OleDbConnection conOle = new OleDbConnection(connOle);
                //System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand();
                //System.Data.OleDb.OleDbDataAdapter adpter = new System.Data.OleDb.OleDbDataAdapter(command);
                //command.CommandText = "SELECT * FROM dcmcxc_db where clnclv = '" + clv + "' and AgnVntClv='" + "' and stt <> ('X') and ntr = 1;";
                //command.Connection = conOle;
                //conOle.Open();
                //adpter.Fill(dsInfMagico1, "dcmcxc_db");
                //conOle.Close();
                //for (int i = 0; i < dsInfMagico1.dcmcxc_db.Rows.Count; i++)
                //{
                //    fecha = DateTime.Parse(dsInfMagico1.dcmcxc_db.Rows[i]["fch"].ToString());
                int semana = cal.GetWeekOfYear(fecha, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                int año = int.Parse(fecha.Year.ToString());
                //    dsInfMagico1.dcmcxc_db.Rows[i]["Anos"] = año;
                //    dsInfMagico1.dcmcxc_db.Rows[i]["Semana"] = semana;
                //    fecha = DateTime.Parse(dsInfMagico1.dcmcxc_db.Rows[i]["FchEms"].ToString());
                //    int semenv = cal.GetWeekOfYear(fecha, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                //    dsInfMagico1.dcmcxc_db.Rows[i]["Cnc"] = semenv.ToString() + "/" + fecha.Year.ToString().Substring(2);
                //    fecha = DateTime.Parse(dsInfMagico1.dcmcxc_db.Rows[i]["FchUltMvm"].ToString());
                //    int sempag = cal.GetWeekOfYear(fecha, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                //    dsInfMagico1.dcmcxc_db.Rows[i]["SubCnc"] = sempag.ToString() + "/" + fecha.Year.ToString().Substring(2);

                //    // Set the values of the keys to find.
                //    //findTheseVals[0] = cmbIdObra.SelectedValue;
                //    //findTheseVals[1] = año;
                //    //findTheseVals[2] = semana;
                //    //DataRow filas = dsInfMagico1.Tables["Periodos"].Rows.Find(findTheseVals);
                //    //if (filas == null)
                //    //    dsInfMagico1.Tables["Periodos"].Rows.Add(cmbIdObra.SelectedValue, año, semana);
                //}
                //string connOle1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\ServidorN\\Empresas\\Apl\\dcmfct_db.mdb;";
                ////                string connOle1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Compartido\\Delfino\\CAPL\\Empresas\\Apl\\dcmfct_db.mdb;";
                //System.Data.OleDb.OleDbConnection conOle1 = new OleDbConnection(connOle1);
                //System.Data.OleDb.OleDbCommand command1 = new System.Data.OleDb.OleDbCommand();
                //System.Data.OleDb.OleDbDataAdapter adpter1 = new System.Data.OleDb.OleDbDataAdapter(command1);
                //command1.CommandText = "SELECT * FROM dcmfct_db where clnclv = '" + clv + "' and AgnVntClv='"  + "' and stt <> ('X') and ntr = 1;";
                //command1.Connection = conOle1;
                //conOle1.Open();
                //adpter1.Fill(dsInfMagico1, "dcmfct_db");
                //conOle1.Close();

                sqlDAInfMagico.SelectCommand.Parameters["@TipoObra"].Value = (rdbContrato.Checked ? 0 : 1);
                sqlDAInfMagico.SelectCommand.Parameters["@Dias"].Value = txtDias.Text;
                sqlDAInfMagico.SelectCommand.Parameters["@Abreviado"].Value = chkAbreviado.Checked;
                sqlDAInfMagico.Fill(dsInfMagico1, "InfMagico");
                //for (int i = 0; i < dsInfMagico1.Tables["InfMagico"].Rows.Count; i++)
                //{
                    // Set the values of the keys to find.
                    //findTheseVals[0] = cmbIdObra.SelectedValue;
                    //findTheseVals[1] = dsInfMagico1.Tables["Obras"].Rows[i][1].ToString();
                    //findTheseVals[2] = dsInfMagico1.Tables["Obras"].Rows[i][2].ToString();
                    //DataRow filas = dsInfMagico1.Tables["Periodos"].Rows.Find(findTheseVals);
                //    if (filas == null)
                //        dsInfMagico1.Tables["Periodos"].Rows.Add(cmbIdObra.SelectedValue, dsInfMagico1.Tables["Obras"].Rows[i][1].ToString(), dsInfMagico1.Tables["Obras"].Rows[i][2].ToString());
                //}
                //dsInfMagico1.Tables["Periodos"].DefaultView.Sort = "IdObra ASC, Anos ASC, Semana ASC";
                //DataTable dt = dsInfMagico1.Tables["Periodos"];
                //dt.DefaultView.Sort = "IdObra ASC, Anos ASC, Semana ASC";
                //DataView dv = dt.DefaultView;
                //dv.Sort = "IdObra ASC, Anos ASC, Semana ASC";
                //DataTable dt1 = dv.ToTable();
                //dsInfMagico1.Tables["Periodos"].Clear();
                //for (int i = 0; i < dt1.Rows.Count; i++)
                //    dsInfMagico1.Tables["Periodos"].Rows.Add(dt1.Rows[i][0].ToString(), dt1.Rows[i][1], dt1.Rows[i][2]);

                
                cryInfMagico1.SetDataSource(dsInfMagico1);
                cryInfMagico1.SetParameterValue("FecIni", fecha.AddDays(-7));
                cryInfMagico1.SetParameterValue("FecFin", fecha);
                cryInfMagico1.SetParameterValue("Semana", semana);
                cryInfMagico1.SetParameterValue("Año", año);
                cryInfMagico1.SetParameterValue("Abreviado", chkAbreviado.Checked);
                crvRepTarjeta.ReportSource = cryInfMagico1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void dTPHoy_ValueChanged(object sender, EventArgs e)
        {
            if (dTPHoy.Value.DayOfWeek.ToString() == "Saturday")
            {
                crvRepTarjeta.Visible = true;
                btnVistaPrevia.Visible = true;
            }
            else
            {
                crvRepTarjeta.Visible = false;
                btnVistaPrevia.Visible = false;
                MessageBox.Show("Elección incorrecta del día de la semana." +
                                    System.Environment.NewLine + System.Environment.NewLine, "Elija un sabado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
