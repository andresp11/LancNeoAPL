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
    public partial class NucleoE : CatalogoGenerico
    {
        private int cambia = 0;
        private string IdUsuario;
        public NucleoE()
        {
            InitializeComponent();
        }

        private void NucleoE_Load(object sender, EventArgs e)
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
            sqlDATAgregado.Fill(dsAgregado1, "Agregado");
            sqlDATipo.Fill(dsTipo1, "Tipo");
            sqlDALaboratorio.Fill(dsLaboratorio1, "Laboratorio");
            sqlDALaboratorista.Fill(dsLaboratorista1, "Laboratorista");
            cambia = 1;
            cmbIdObra.SelectedIndex = 1;
            cmbIdObra.SelectedIndex = 0;
        }

        public override void LoadDataSet()
        {
            sqlDANucleoMue.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            base.LoadDataSet();
        }


        private void txtUsrMov_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAgregado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdConcretera_TextChanged(object sender, EventArgs e)
        {
                    }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtConsecutivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMuestra_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbIdObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            dsNuEs1.NucleoMue.Rows.Clear();
            dsNuEs1.NucleoEsp.Rows.Clear();
            this.LoadDataSet();
            DataSet objDataSetChanges = ((LancNeo.dsNuEs)(dsNuEs1.GetChanges()));
            this.BindingContext[dsNuEs1, "NucleoMue"].EndCurrentEdit();
            this.BindingContext[dsNuEs1, "NucleoEsp"].EndCurrentEdit();
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
            dsNuEs1.NucleoMue.Rows.Clear();
            this.LoadDataSet();
            dsNuEs1.NucleoEsp.Rows.Clear();
            try
            {
                sqlDANucleoEsp.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDANucleoEsp.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
                sqlDANucleoEsp.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
                sqlDANucleoEsp.Fill(dsNuEs1, "NucleoEsp");
            }
            catch (System.Exception eUpdate) { }
        }

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            txtUsrMov.Text = IdUsuario;
            try
            {
                // Intente actualizar el origen de datos.

                base.BindingContext[dsNuEs1, "NucleoMue"].Position = this.BindingContext[dsNuEs1, "NucleoMue"].Position;
                this.UpdateDataSet1();
                base.dsGeneral_PositionChanged();
            }
            catch (System.Exception eUpdate)
            {
                statusBar1.Panels[2].Text = eUpdate.Message;
                statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
                statusBar1.Panels[2].ToolTipText = eUpdate.Message;
            }
        }
        private void UpdateDataSet1()
        {
            // Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            // original			DataSet objDataSetChanges = new DataSet();
            LancNeo.dsNuEs objDataSetChanges = new LancNeo.dsNuEs();
            // Detener las ediciones actuales.
            // original			this.BindingContext[dsgeneral].EndCurrentEdit();
            this.BindingContext[dsNuEs1, "NucleoMue"].EndCurrentEdit();
            this.BindingContext[dsNuEs1, "NucleoEsp"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            // original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

            objDataSetChanges = ((LancNeo.dsNuEs)(dsNuEs1.GetChanges()));

            // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    dsNuEs1.Merge(objDataSetChanges);
                    dsNuEs1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsNuEs ChangedRows)
        {
            try
            {
                // Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
                if ((ChangedRows != null))
                {
                    // Abra la conexión.
                    this.sqlConn.Open();
                    // Intente actualizar el origen de datos.
                    sqlDANucleoMue.Update(ChangedRows);
                    sqlDANucleoEsp.Update(ChangedRows);
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

        protected override void btnPrimero_Click(object sender, System.EventArgs e)
        {
            base.btnPrimero_Click(sender, e);
            dsNuEs1.NucleoEsp.Clear();
            sqlDANucleoEsp.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDANucleoEsp.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDANucleoEsp.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDANucleoEsp.Fill(dsNuEs1, "NucleoEsp");
        }
        protected override void btnAnterior_Click(object sender, System.EventArgs e)
        {
            base.btnAnterior_Click(sender, e);
            dsNuEs1.NucleoEsp.Clear();
            sqlDANucleoEsp.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDANucleoEsp.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDANucleoEsp.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDANucleoEsp.Fill(dsNuEs1, "NucleoEsp");
        }

        protected override void btnSiguiente_Click(object sender, System.EventArgs e)
        {
            base.btnSiguiente_Click(sender, e);
            dsNuEs1.NucleoEsp.Clear();
            sqlDANucleoEsp.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDANucleoEsp.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDANucleoEsp.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDANucleoEsp.Fill(dsNuEs1, "NucleoEsp");
        }
        protected override void btnUltimo_Click(object sender, System.EventArgs e)
        {
            base.btnUltimo_Click(sender, e);
            dsNuEs1.NucleoEsp.Clear();
            sqlDANucleoEsp.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDANucleoEsp.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDANucleoEsp.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDANucleoEsp.Fill(dsNuEs1, "NucleoEsp");
        }

        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            dsNuEs1.NucleoEsp.Clear();
            sqlDANucleoEsp.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDANucleoEsp.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDANucleoEsp.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDANucleoEsp.Fill(dsNuEs1, "NucleoEsp");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1[24, e.RowIndex].Value = IdUsuario;

            //if ((e.ColumnIndex != 17) || (cambia == 0)) return;

            //if (dataGridView1[4, e.RowIndex].Value == null) return;

            //dataGridView1[17, e.RowIndex].Value = System.DateTime.Today.AddDays(-1);
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["IdLab"].Value = 61;
            e.Row.Cells["NoEco"].Value = 1;
            e.Row.Cells["Fensaye"].Value = System.DateTime.Today.AddDays(-1); ;
            e.Row.Cells["IdUsu"].Value = IdUsuario;

        }
    }
}
