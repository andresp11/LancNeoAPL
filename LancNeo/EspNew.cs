using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

using System.Data.SqlClient;

namespace LancNeo
{
    public partial class EspNew : CatalogoGenerico
    {
        private int cambia = 0;
        private string IdUsuario;

        public EspNew()
        {
            InitializeComponent();
        }

        private void EspNew_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            dsResBajo1.ResBajo.AddResBajoRow(1, "Aceptable");
            dsResBajo1.ResBajo.AddResBajoRow(2, "No Aceptable");
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            this.buscaBtn1.Catalogo = this;
            sqlDATAgregado.Fill(dsAgregado1, "Agregado");
            sqlDATipo.Fill(dsTipo1, "Tipo");
            dsVapor1.Vapor.AddVaporRow(1, "Normal");
            dsVapor1.Vapor.AddVaporRow(2, "Vapor");
            sqlDAPrueba.Fill(dsTipoPrueba1, "Tipoprueba");
            sqlDADiametro.Fill(dsDiametro1, "Diametro");
            sqlDALaboratorio.Fill(dsLaboratorio1, "Laboratorio");
            sqlDALaboratorista.Fill(dsLaboratorista1, "Laboratorista");
            cambia = 1;
//            cmbIdObra.SelectedIndex = 0;
            cmbIdObra.SelectedIndex = 1;
            cmbIdObra.SelectedIndex = 0;
        }
        public override void LoadDataSet()
        {
            sqlDAMuestra.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            base.LoadDataSet();
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            dsMuEs1.Muestras.Rows.Clear();
            dsMuEs1.Especimen.Rows.Clear();
            this.LoadDataSet();
            DataSet objDataSetChanges = ((LancNeo.dsMuEs)(dsMuEs1.GetChanges()));
            this.BindingContext[dsMuEs1, "Muestras"].EndCurrentEdit();
            this.BindingContext[dsMuEs1, "Especimen"].EndCurrentEdit();
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
            dsMuEs1.Muestras.Rows.Clear();
            this.LoadDataSet();
            dsMuEs1.Especimen.Rows.Clear();
            try
            {
                sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
                sqlDAEspecimen.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
                sqlDAEspecimen.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
                sqlDAEspecimen.Fill(dsMuEs1, "Especimen");
            }
            catch (System.Exception eUpdate) { }

        }

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            txtUsrMov.Text = IdUsuario;
            try
            {
                // Intente actualizar el origen de datos.

                base.BindingContext[dsMuEs1, "Muestras"].Position = this.BindingContext[dsMuEs1, "Muestras"].Position;
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
            LancNeo.dsMuEs objDataSetChanges = new LancNeo.dsMuEs();
            // Detener las ediciones actuales.
            // original			this.BindingContext[dsgeneral].EndCurrentEdit();
            this.BindingContext[dsMuEs1, "Muestras"].EndCurrentEdit();
            this.BindingContext[dsMuEs1, "Especimen"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            // original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

            objDataSetChanges = ((LancNeo.dsMuEs)(dsMuEs1.GetChanges()));

            // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    dsMuEs1.Merge(objDataSetChanges);
                    dsMuEs1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsMuEs ChangedRows)
        {
            try
            {
                // Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
                if ((ChangedRows != null))
                {
                    // Abra la conexión.
                    this.sqlConn.Open();
                    // Intente actualizar el origen de datos.
                    sqlDAMuestra.Update(ChangedRows);
                    sqlDAEspecimen.Update(ChangedRows);
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
            dsMuEs1.Especimen.Clear();
            sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAEspecimen.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDAEspecimen.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDAEspecimen.Fill(dsMuEs1, "Especimen");
        }
        protected override void btnAnterior_Click(object sender, System.EventArgs e)
        {
            base.btnAnterior_Click(sender, e);
            dsMuEs1.Especimen.Clear();
            sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAEspecimen.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDAEspecimen.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDAEspecimen.Fill(dsMuEs1, "Especimen");
        }

        protected override void btnSiguiente_Click(object sender, System.EventArgs e)
        {
            base.btnSiguiente_Click(sender, e);
            dsMuEs1.Especimen.Clear();
            sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAEspecimen.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDAEspecimen.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDAEspecimen.Fill(dsMuEs1, "Especimen");
        }
        protected override void btnUltimo_Click(object sender, System.EventArgs e)
        {
            base.btnUltimo_Click(sender, e);
            dsMuEs1.Especimen.Clear();
            sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAEspecimen.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDAEspecimen.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDAEspecimen.Fill(dsMuEs1, "Especimen");
        }

        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            dsMuEs1.Especimen.Clear();
            sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAEspecimen.SelectCommand.Parameters["@Fecha"].Value = dtpFecha.Text;
            sqlDAEspecimen.SelectCommand.Parameters["@Consecutivo"].Value = txtConsecutivo.Text;
            sqlDAEspecimen.Fill(dsMuEs1, "Especimen");

        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Vapor"].Value = 1;
            e.Row.Cells["IdDiam"].Value = 1;
            e.Row.Cells["IdPrueba"].Value = 1;
            e.Row.Cells[24].Value = IdUsuario; //e.Row.Cells["IdUsuario"].Value = IdUsuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (((e.ColumnIndex == 3) || (e.ColumnIndex == 4) || (e.ColumnIndex == 5) || (e.ColumnIndex == 11) || (e.ColumnIndex == 13) || (e.ColumnIndex == 21) || (e.ColumnIndex == 23)) && (cambia == 1))
            {
                dataGridView1[24, e.RowIndex].Value = IdUsuario;
                return;
            }
            if ((e.ColumnIndex != 4) && (e.ColumnIndex != 24) || (cambia == 0)) return;

            if (dataGridView1[4, e.RowIndex].Value == null) return;

            DateTime fecha = dtpFecha.Value;
            double dia = double.Parse(dataGridView1[4, e.RowIndex].Value.ToString());
            fecha = fecha.AddDays(dia);
            dataGridView1[23, e.RowIndex].Value = fecha;

        }

        protected override void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
