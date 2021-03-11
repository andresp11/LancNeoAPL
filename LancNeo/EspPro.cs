using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
    public partial class EspPro : CatalogoGenerico
    {
        private string IdObra;
        private string Fecha;
        private int cambia = 0;
        public EspPro()
        {
            InitializeComponent();
        }

        private void EspPro_Load(object sender, EventArgs e)
        {
//			this.buscaBtn1.Catalogo = this;
            int pos = Text.IndexOf("|");
            IdObra = this.Text.Substring(0,pos);
            Fecha = this.Text.Substring(pos+1,8);
            sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = IdObra;
            sqlDAEspecimen.SelectCommand.Parameters["@Fecha"].Value = Fecha;
            sqlDAEspecimen.Fill(dsEspPro1, "Especimen");
            cambia = 1;
        }

        private void dgEspPro_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = IdObra;
            e.Row.Cells[1].Value = Fecha;
            e.Row.Cells[7].Value = 1;
            e.Row.Cells[10].Value = 1;
            e.Row.Cells[11].Value = 1;
            e.Row.Cells[8].Value = 61;
            e.Row.Cells[9].Value = 1;
            
        }

        private void dgEspPro_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != 4) || (cambia == 0)) return;
            
                DateTime fecha = System.Convert.ToDateTime(dgEspPro[1,e.RowIndex].Value.ToString());
                double dia = double.Parse(dgEspPro[4, e.RowIndex].Value.ToString());
                    fecha = fecha.AddDays(dia);
            dgEspPro[6, e.RowIndex].Value = fecha;
        }
/*protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
                int renglones = int.Parse(dgEspPro.RowCount.ToString());
                DataColumn[] Llave = new DataColumn[4];

                try
                {
                    for (int i = 0; i < renglones -  1; i++)

                    {
                        Object[] Matriz = new Object[7];
//                        Llave[0] = dsEspPro1.Tables[0].Columns[0];
//                        Llave[1] = dsEspPro1.Tables[0].Columns[1];
//                        Llave[2] = dsEspPro1.Tables[0].Columns[2];
//                        Llave[3] = dsEspPro1.Tables[0].Columns[3];
                        Matriz[0] = dsEspPro1.Tables[0].Rows[i][0].ToString();
                        Matriz[1] = dsEspPro1.Tables[0].Rows[i][1].ToString();
                        Matriz[2] = dsEspPro1.Tables[0].Rows[i][2].ToString();
                        Matriz[3] = dsEspPro1.Tables[0].Rows[i][3].ToString();
                        Matriz[4] = dsEspPro1.Tables[0].Rows[i][4].ToString();
                        Matriz[5] = dsEspPro1.Tables[0].Rows[i][5].ToString();
                        Matriz[6] = dsEspPro1.Tables[0].Rows[i][6].ToString();

                        dsEspPro1.Tables["Especimen"].BeginLoadData();
                        dsEspPro1.Tables["Especimen"].LoadDataRow(Matriz, false);
                        dsEspPro1.Tables["Especimen"].EndLoadData();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
                finally
                {
                }
                sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = IdObra;
                sqlDAEspecimen.SelectCommand.Parameters["@Fecha"].Value = Fecha;
                sqlDAEspecimen.Fill(dsEspPro1, "Especimen");
                dgEspPro.Show();
                dgEspPro.Refresh();
        }
        */
    }
}
