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
    public partial class Mater : CatalogoGenerico
    {
        private string IdUsuario;
        public Mater()
        {
            InitializeComponent();
        }

        private void Mater_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
            sqlDABusMateriales.Fill(dsBusMateriales1, "Materiales");
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            sqlDALaboratorista.Fill(dsLaboratorista1, "Laboratorista");
            sqlDAMaterialesMal.Fill(dsMateriales1, "MaterialesMal");
            sqlDAMallasM.Fill(dsMallasM1, "MallasM");
        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {
            dsMateriales1.MaterialesMal.Clear();
            sqlDAMaterialesMal.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
            sqlDAMaterialesMal.Fill(dsMateriales1, "MaterialesMal");
       }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            int renglones = int.Parse(dgMateriales.RowCount.ToString());
            if (renglones <= 1)
            {
                DataColumn[] Llave = new DataColumn[2];

                try
                {
                    for (int i = 0; i < 13; i++)
                    {
                        Object[] Matriz = new Object[10];
                        Llave[0] = dsMateriales1.Tables["MaterialesMal"].Columns["Folio"];
                        Llave[1] = dsMateriales1.Tables["MaterialesMal"].Columns["Renglon"];
                        Matriz[0] = txtFolio.Text;
                        for (int j = 1; j < 8; j++)
                            if (dsMallasM1.Tables[0].Rows[i][j - 1].ToString() != "0.00")
                                Matriz[j] = dsMallasM1.Tables[0].Rows[i][j - 1].ToString();
                            else
                                Matriz[j] = null;
                        Matriz[6] = (i == 0 ? 0 : Matriz[6]);
                        dsMateriales1.Tables["MaterialesMal"].BeginLoadData();
                        dsMateriales1.Tables["MaterialesMal"].LoadDataRow(Matriz, false);
                        dsMateriales1.Tables["MaterialesMal"].EndLoadData();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
                finally
                {
                }
                dgMateriales.Show();
                dgMateriales.Refresh();
            }
        }
        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            cmbIdObra.SelectedIndex = -1;
            cmbNoeco.SelectedIndex = -1;
            dtpFmuestreo.Value = DateTime.Now.AddDays(1);
            dtpFmuestreo.Value = DateTime.Today;
            dtpFinforme.Value = DateTime.Now.AddDays(1);
            dtpFinforme.Value = DateTime.Today;
            dtpFensaye.Value = DateTime.Now.AddDays(1);
            dtpFensaye.Value = DateTime.Today;
            dgMateriales.Visible = false;
        }

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsMateriales1, "Materiales"].Position = this.BindingContext[dsMateriales1, "Materiales"].Position;
                this.UpdateDataSet1();
                base.dsGeneral_PositionChanged();
            }
            catch (System.Exception eUpdate)
            {
                statusBar1.Panels[2].Text = eUpdate.Message;
                statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
                statusBar1.Panels[2].ToolTipText = eUpdate.Message;
            }
            dsBusMateriales1.Clear();
            sqlDABusMateriales.Fill(dsBusMateriales1, "Materiales");
            dsMateriales1.MaterialesMal.Clear();
            sqlDAMaterialesMal.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
            sqlDAMaterialesMal.Fill(dsMateriales1, "MaterialesMal");
            dgMateriales.Visible = true;
        }
        public override void LoadDataSet()
        {
            base.LoadDataSet();
            sqlDAMaterialesMal.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
            sqlDAMaterialesMal.Fill(dsMateriales1, "MaterialesMal");
        }

        private void UpdateDataSet1()
        {
            // Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            LancNeo.dsMateriales objDataSetChanges = new LancNeo.dsMateriales();
            // Detener las ediciones actuales.
            this.BindingContext[dsMateriales1, "Materiales"].EndCurrentEdit();
            this.BindingContext[dsMateriales1, "MaterialesMal"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            objDataSetChanges = ((LancNeo.dsMateriales)(dsMateriales1.GetChanges()));

            // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    dsMateriales1.Merge(objDataSetChanges);
                    dsMateriales1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsMateriales ChangedRows)
        {
            try
            {
                // Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
                if ((ChangedRows != null))
                {
                    // Abra la conexión.
                    this.sqlConn.Open();
                    // Intente actualizar el origen de datos.
                    sqlDAMateriales.Update(ChangedRows);
                    sqlDAMaterialesMal.Update(ChangedRows);
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
        private void chbLimte_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbLimte.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg][18] = DBNull.Value;
                chbLimte.Checked = false;
            }

        }

        private void chbPlastico_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbPlastico.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg][19] = DBNull.Value;
                chbPlastico.Checked = false;
            }
        }

        private void chbIndice_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbIndice.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg][20] = DBNull.Value;
                chbIndice.Checked = false;
            }

        }

        private void chbLineal_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbLineal.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg][21] = DBNull.Value;
                chbLineal.Checked = false;
            }

        }
 
        private void chbXMasaSuelta_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXMasaSuelta.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XMasaSuelta"] = DBNull.Value;
                txtXMasaSuelta.Text = null;
                chbXMasaSuelta.Checked = false;
            }
        }

        private void chbXMasaMaxima_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXMasaMaxima.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XMasaMaxima"] = DBNull.Value;
                chbXMasaMaxima.Checked = false;
            }
        }

        private void chbXAgua_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXAgua.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XAgua"] = DBNull.Value;
                chbXAgua.Checked = false;
            }
        }

        private void chbXExpansion_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXExpansion.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XExpansion"] = DBNull.Value;
                chbXExpansion.Checked = false;
            }
        }

        private void chbXSoporte_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXSoporte.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XSoporte"] = DBNull.Value;
                chbXSoporte.Checked = false;
            }
        }

        private void chbXLiquido_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXLiquido.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XLiquido"] = DBNull.Value;
                chbXLiquido.Checked = false;
            }
        }

        private void chbXPlastico_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXPlastico.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XPlastico"] = DBNull.Value;
                chbXPlastico.Checked = false;
            }
        }

        private void chbXIndice_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXIndice.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XIndice"] = DBNull.Value;
                chbXIndice.Checked = false;
            }
        }

        private void chbXLineal_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXLineal.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XLineal"] = DBNull.Value;
                chbXLineal.Checked = false;
            }
        }

        private void chbXRocas_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXRocas.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XRocas"] = DBNull.Value;
                chbXRocas.Checked = false;
            }
        }

        private void chbXGruesa_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXGruesa.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XGruesas"] = DBNull.Value;
                chbXGruesa.Checked = false;
            }
        }

        private void chbXMediana_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXMediana.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XMediana"] = DBNull.Value;
                chbXMediana.Checked = false;
            }
        }

        private void chbXFina_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXFina.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XFina"] = DBNull.Value;
                chbXFina.Checked = false;
            }
        }

        private void chbXLimos_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXLimos.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XLimas"] = DBNull.Value;
                chbXLimos.Checked = false;
            }
        }

        private void chbXArcillas_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXArcillas.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XArcillas"] = DBNull.Value;
                chbXArcillas.Checked = false;
            }
        }

        private void chbXArena_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbXArena.Checked)
            {
                int reg = this.BindingContext[dsMateriales1, "Materiales"].Position;
                dsMateriales1.Tables["Materiales"].Rows[reg]["XArena"] = DBNull.Value;
                chbXArena.Checked = false;
            }
        }

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }

        protected override void btnDeshacer_Click(object sender, System.EventArgs e)
        {
            dgMateriales.Visible = true;
            base.btnDeshacer_Click(sender, e);

        }
        protected override void btnCancelar_Click(object sender, System.EventArgs e)
        {
            dgMateriales.Visible = true;
            base.btnCancelar_Click(sender, e);

        }
    }
}
