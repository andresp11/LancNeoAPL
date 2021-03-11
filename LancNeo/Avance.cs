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
    public partial class Avance : Form
    {
        public Avance()
        {
            InitializeComponent();
        }

        private void Avance_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sqlDAObras.Fill(dsObra1, "Obra");
            sqlDAAvance.Fill(dsAvance1, "Avance");
        }

        private void dgvAvance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0)
            {
            string buscaID = dgvAvance[0, e.RowIndex].Value.ToString();
            DataRow filas = dsObra1.Obra.Rows.Find(buscaID);
            dgvAvance[2, e.RowIndex].Value = filas[4].ToString();
            }
        }

        private void dgvAvance_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dgvAvance_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvAvance_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void dgvAvance_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.Index == -1) return;
            
            string buscaID = e.Row.Cells[0].ToString();
            DataRow filas = dsObra1.Obra.Rows.Find(buscaID);
            e.Row.Cells[2].Value = filas[3].ToString();
        }

        private void dgvAvance_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.Index == -1) return;
//            e.Row.Cells[0].Value = dsObra1.Obra.Rows[0][2].ToString();
            string buscaID = e.Row.Cells[0].ToString();
            DataRow filas = dsObra1.Obra.Rows.Find(buscaID);
            e.Row.Cells[2].Value = filas[3].ToString();
        }

        private void dgvAvance_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (e.RowIndex == -1) return;
            //    string buscaID = dgvAvance[0, e.RowIndex].Value.ToString();
            //    DataRow filas = dsObra1.Obra.Rows.Find(buscaID);
            //    dgvAvance[2, e.RowIndex].Value = filas[4].ToString();
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            sqlComInserta.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;

            try
            {
                sqlConn.Open();
                sqlComInserta.ExecuteNonQuery();
                dsAvance1.Clear();
                sqlDAAvance.Fill(dsAvance1, "Avance");
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAvance.Rows)
            {
                //string buscaID = row.Cells[0].Value.ToString();
                //DataRow filas = dsObra1.Obra.Rows.Find(buscaID);
                //row.Cells[2].Value = filas[3].ToString();


                sqlComInserta.Parameters["@IdObra"].Value = row.Cells[0].Value.ToString().Trim();

                try
                {
                    sqlConn.Open();
                    sqlComInserta.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
                finally
                {
                    if (sqlConn.State == ConnectionState.Open)
                        sqlConn.Close();
                }
                try
                {
                    sqlConn.Open();
                    sqlComAgrega.Parameters["@IdObra"].Value = row.Cells[0].Value.ToString().Trim();
                    sqlComAgrega.Parameters["@Fini"].Value = "01/01/2001";
                    sqlComAgrega.Parameters["@Ffin"].Value = dtpFinal.Value;
                    sqlComAgrega.Parameters["@Mortero"].Value = 0;
                    sqlComAgrega.Parameters["@IdObraM"].Value = row.Cells[0].Value.ToString().Trim();
                    int error = sqlComAgrega.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConn.Close();
                if (!string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                {
                    try
                    {
                        sqlConn.Open();
                        sqlComAgrega.Parameters["@IdObra"].Value = row.Cells[1].Value.ToString().Trim();
                        sqlComAgrega.Parameters["@Fini"].Value = "01/01/2001";
                        sqlComAgrega.Parameters["@Ffin"].Value = dtpFinal.Value;
                        sqlComAgrega.Parameters["@Mortero"].Value = 1;
                        sqlComAgrega.Parameters["@IdObraM"].Value = row.Cells[0].Value.ToString().Trim();
                        int error = sqlComAgrega.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    sqlConn.Close();
                }
                try
                {
                    sqlConn.Open();
                    sqlComActualiza.Parameters["@IdObra"].Value = row.Cells[0].Value.ToString().Trim();
                    sqlComActualiza.Parameters["@IdObraN"].Value = (string.IsNullOrEmpty(row.Cells[1].Value.ToString()) ? row.Cells[0].Value.ToString().Trim() : row.Cells[1].Value.ToString().Trim());
                    int error = sqlComActualiza.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConn.Close();

            }
            MessageBox.Show("Proceso terminado");
            dsAvance1.Clear();
            sqlDAAvance.Fill(dsAvance1, "Avance");

        }

        private void tbBtn2_Click(object sender, EventArgs e)
        {
            try
                {
                    sqlConn.Open();
                    sqlDAAvance.Update(dsAvance1, "Avance");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConn.Close();
            MessageBox.Show("Proceso terminado");
            dsAvance1.Clear();
            sqlDAAvance.Fill(dsAvance1, "Avance");
        }

        private void tbBtn1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
