using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data;
using System.Data.SqlClient;

namespace LancNeo
{
    public partial class Nucleo : CatalogoGenerico
    {
        private string IdUsuario;
        private int regist = 2;
        private int cambia = 0;

        public Nucleo()
        {
            InitializeComponent();
        }

        private void Nucleo_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            sqlDABusObra.Fill(dsBusObra1, "Obra");

            this.buscaBtn1.Catalogo = this;
            cmbIdObra.SelectedIndex = 0;
            cmbIdObra.SelectedIndex = 1;
            cmbIdObra.SelectedIndex = 0;
            EstableceVistaPrevia();
            LlenaLaboratorista();
        }

        private void LlenaLaboratorista()
        {
            sqlDANoEco.Fill(dsLaboratorista1, "Laboratorista");
            sqlDALaboratorio.Fill(dsLaboratorio1, "Laboratorio");
            sqlDARes.Fill(dsResistencia1, "Resistencia");
            sqlDATAgregado.Fill(dsAgregado1, "Agregado");
            sqlDATipo.Fill(dsTipo1, "Tipo");
            if (cmbIdObra.SelectedValue == null)
                sqlDANucleoMue.SelectCommand.Parameters["@IdObra"].Value = "AC";
            else
                sqlDANucleoMue.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
//            sqlDANucleoMue.SelectCommand.Parameters["@Folio"].Value = " ";
            dsNucleo1.NucleoMue.Clear();
            sqlDANucleoMue.Fill(dsNucleo1, "NucleoMue");
        }

        private void EstableceVistaPrevia()
        {
            DataSet dsVP = new DataSet();
            dsBusNucleo1.Clear();
            sqlDABusq.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDABusq.Fill(dsBusNucleo1, "NucleoMdor");
            dsVistaPrevia = dsBusNucleo1;//dsVP;
        }

        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            txtIdObra.Text = cmbIdObra.SelectedValue.ToString();
            dtpFecha.Value = DateTime.Now.AddDays(1);
            dtpFecha.Value = DateTime.Today; // .Now. .AddMilliseconds(1);
        }

        //protected override void btnGuardar_Click(object sender, System.EventArgs e)
        //{
        //    txtUser.Text = IdUsuario;
        //    base.btnGuardar_Click(sender, e);
        //}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtObserva_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbIdObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsBusNucleo1.Clear();
            sqlDABusq.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            sqlDABusq.Fill(dsBusNucleo1, "NucleoMdor");

            DataSet objDataSetChanges = ((LancNeo.dsNucleo)(dsNucleo1.GetChanges()));
            this.BindingContext[dsNucleo1, "NucleoMdor"].EndCurrentEdit();
            if ((objDataSetChanges != null))
            {
                switch (MessageBox.Show("Desea Guardar los cambios ", "Existen cambios", System.Windows.Forms.MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        btnGuardar_Click(sender, null);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            this.LoadDataSet();

        }
        public override void LoadDataSet()
        {
            string IdObra = "AC";
            if (cmbIdObra.SelectedValue == null)
                sqlDANucleoMdor.SelectCommand.Parameters["@IdObra"].Value = "AC";
            else
                sqlDANucleoMdor.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;

            base.LoadDataSet();
            if (dsBusNucleo1.NucleoMdor.Rows.Count == 0)
                IdObra = "AC";
            else
                IdObra = dsNucleo1.NucleoMdor.Rows[0][0].ToString();
            dsNucleo1.NucleoMue.Clear();
            dsNucleo1.Tables["NucleoMue"].Clear();
            sqlDANucleoMue.SelectCommand.Parameters["@IdObra"].Value = IdObra;
//            sqlDANucleoMue.SelectCommand.Parameters["@Folio"].Value = F;
            sqlDANucleoMue.Fill(dsNucleo1, "NucleoMue");
            regist = 0;

        }

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            txtUser.Text = IdUsuario;
            try
            {
                // Intente actualizar el origen de datos.
                base.BindingContext[dsNucleo1, "NucleoMdor"].Position = this.BindingContext[dsNucleo1, "NucleoMdor"].Position;
                this.UpdateDataSet1();
                base.dsGeneral_PositionChanged();
            }
            catch (System.Exception eUpdate)
            {
                statusBar1.Panels[2].Text = eUpdate.Message;
                statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
                statusBar1.Panels[2].ToolTipText = eUpdate.Message;
            }

            EstableceVistaPrevia();
        }

        private void UpdateDataSet1()
        {
            LancNeo.dsNucleo objDataSetChanges = new LancNeo.dsNucleo();
            // Detener las ediciones actuales.
            // original			this.BindingContext[dsgeneral].EndCurrentEdit();
            this.BindingContext[dsNucleo1, "NucleoMdor"].EndCurrentEdit();
            //			this.BindingContext[dsNucleo1,"Muestras"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            // original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));
            //Anterior            objDataSetChanges = ((LancNeo.dsMuestra)(dsNucleo1.GetChanges()));

            objDataSetChanges = ((LancNeo.dsNucleo)(dsNucleo1.GetChanges()));

            // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    dsNucleo1.Merge(objDataSetChanges);
                    dsNucleo1.AcceptChanges();
                }
                catch (System.Exception eUpdate)
                {
                    // Agregar aquí el código de control de errores.
                    throw eUpdate;
                }
                // Agregar código para comprobar en el conjunto de datos devuelto los errores que se puedan haber
                // introducido en el error del objeto de fila.
            }

        }
        private void UpdateDataSource1(LancNeo.dsNucleo ChangedRows)
        {
            try
            {
                // Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
                if ((ChangedRows != null))
                {
                    // Abra la conexión.
                    this.sqlConn.Open();
                    // Intente actualizar el origen de datos.
                    sqlDANucleoMdor.Update(ChangedRows);
                    sqlDANucleoMue.Update(ChangedRows);
                }
            }
            catch (System.Exception updateException)
            {
                // Agregar aquí el código de control de errores.
                throw updateException;
            }
            finally
            {
                // Cerrar la conexión independientemente de si se inició una excepción o no.
                this.sqlConn.Close();
            }
        }

        private void dgMuestras_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cambia = 0;
        }

        private void dgMuestras_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //e.Row.Cells["Tipo"].Value = 1;
            //e.Row.Cells["TA"].Value = 1;
            e.Row.Cells[25].Value = IdUsuario;
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            //if (dsNucleo1.NucleoMue.Count > 1)
            //{
            //    dsFechaM1.Clear();
            //    sqlDAFecha.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            //    sqlDAFecha.SelectCommand.Parameters["@Muestra"].Value = txtMuestra.Text.Trim();
            //    sqlDAFecha.Fill(dsFechaM1, "Muestras");

            //    int curr = 0;
            //    foreach (DataRow dr in dsNucleo1.NucleoMdor.Rows)
            //    {
            //        try
            //        {
            //            if (dr["Fecha"].ToString() == dsFechaM1.Muestras.Rows[0][0].ToString())
            //                break;
            //            else
            //                curr++;
            //        }
            //        catch (Exception)
            //        {
            //            //MessageBox.Show(ex.Message);
            //        }
            //        finally
            //        {
            //            //curr++;
            //        }
            //    }
            //    try
            //    {
            //        this.BindingContext[dsNucleo1, "NucleoMdor"].Position = curr;
            //        this.dsGeneral_PositionChanged();
            //    }
            //    catch (Exception ex)
            //    {
            //        statusBar1.Panels[2].Text = ex.Message;
            //        statusBar1.Panels[2].ToolTipText = ex.Message;
            //    }
            //}
        }

        private void dgMuestras_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int registros = dgMuestras.Rows.Count;
            regist = (e == null ? 0 : e.RowIndex);
            dgMuestras.Rows[regist].Cells[26].Value = IdUsuario;
            //if (dgMuestras.Rows[regist].Cells[11].Value != null && dgMuestras.Rows[regist].Cells[12].Value != null && dgMuestras.Rows[regist].Cells[13].Value != null && dgMuestras.Rows[regist].Cells[14].Value != null)
            //{
            //    txtEle.Text = dgMuestras.Rows[e.RowIndex].Cells[11].Value.ToString();
            //    txtEje.Text = dgMuestras.Rows[e.RowIndex].Cells[12].Value.ToString();
            //    txtNiv.Text = dgMuestras.Rows[e.RowIndex].Cells[13].Value.ToString();
            //    txtEdi.Text = dgMuestras.Rows[e.RowIndex].Cells[14].Value.ToString();
            //}

        }

        private void txtEle_Leave(object sender, EventArgs e)
        {
            
            dgMuestras.Rows[regist].Cells[26].Value = IdUsuario;
        }

        private void txtEje_Leave(object sender, EventArgs e)
        {
            //dgMuestras.Rows[regist].Cells[12].Value = txtEje.Text;
        }

        private void txtNiv_Leave(object sender, EventArgs e)
        {
            //dgMuestras.Rows[regist].Cells[13].Value = txtNiv.Text;
        }

        private void txtEdi_Leave(object sender, EventArgs e)
        {
            //dgMuestras.Rows[regist].Cells[14].Value = txtEdi.Text;
        }

        private void dgMuestras_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            cambia = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgMuestras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
