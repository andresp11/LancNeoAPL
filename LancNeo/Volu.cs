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
    public partial class Volu : CatalogoGenerico
    {
        private string IdUsuario;

        public Volu()
        {
            InitializeComponent();
        }

        private void Volu_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            sqlDALaboratorista.Fill(dsLaboratorista1, "Laboratorista");
            sqlDALaboratorio.Fill(dsLaboratorio1, "Laboratorio");
            dsTiPr1.Tables[0].Rows.Add("Proctor", "Proctor");
            dsTiPr1.Tables[0].Rows.Add("Porter", "Porter");
            DataGridTableStyle miest = new DataGridTableStyle();
            miest.AlternatingBackColor = System.Drawing.Color.MidnightBlue;
            miest.BackColor = System.Drawing.Color.SteelBlue;
            miest.ForeColor = System.Drawing.Color.White;
            miest.GridLineColor = System.Drawing.Color.LightGray;
            miest.HeaderBackColor = System.Drawing.Color.CornflowerBlue;
            miest.HeaderFont = new System.Drawing.Font("Tahoma", 7.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            miest.HeaderForeColor = System.Drawing.Color.White;
            miest.LinkColor = System.Drawing.Color.MidnightBlue;
            miest.ReadOnly = true;
            miest.RowHeaderWidth = 45;
            miest.SelectionBackColor = System.Drawing.Color.White;
            miest.SelectionForeColor = System.Drawing.Color.Black;

//            dgVolum.TableStyles.Add(miest);
        }
        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            cmbIdObra.SelectedIndex = -1;
            cmbNoeco.SelectedIndex = -1;
            dtpFinforme.Value = DateTime.Now.AddDays(1);
            dtpFinforme.Value = DateTime.Today;
            dtpFEnsaye.Value = DateTime.Now.AddDays(1);
            dtpFEnsaye.Value = DateTime.Today;
        }

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsVolumetrico1, "Volumetrico"].Position = this.BindingContext[dsVolumetrico1, "Volumetrico"].Position;
                this.UpdateDataSet1();
                base.dsGeneral_PositionChanged();
            }
            catch (System.Exception eUpdate)
            {
                statusBar1.Panels[2].Text = eUpdate.Message;
                statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
                statusBar1.Panels[2].ToolTipText = eUpdate.Message;
            }
            dsVolumetrico1.Tables["VolumetricoRes"].Clear();
            sqlDAVolRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
            sqlDAVolRes.Fill(dsVolumetrico1, "VolumetricoRes");
        }
        public override void LoadDataSet()
        {
            base.LoadDataSet();
            //			dgVolum.SetDataBinding(dsVolumetrico1, "Volumetrico.VolumetricoVolumetricoRes");
            dsVolumetrico1.Tables["VolumetricoRes"].Clear();
            sqlDAVolRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
            sqlDAVolRes.Fill(dsVolumetrico1, "VolumetricoRes");
        }

        private void UpdateDataSet1()
        {
            // Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            LancNeo.dsVolumetrico objDataSetChanges = new LancNeo.dsVolumetrico();
            // Detener las ediciones actuales.
            this.BindingContext[dsVolumetrico1, "Volumetrico"].EndCurrentEdit();
            this.BindingContext[dsVolumetrico1, "VolumetricoRes"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            objDataSetChanges = ((LancNeo.dsVolumetrico)(dsVolumetrico1.GetChanges()));

            // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    dsVolumetrico1.Merge(objDataSetChanges);
                    dsVolumetrico1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsVolumetrico ChangedRows)
        {
            try
            {
                // Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
                if ((ChangedRows != null))
                {
                    // Abra la conexión.
                    this.sqlConn.Open();
                    // Intente actualizar el origen de datos.
                    sqlDAVolumetrico.Update(ChangedRows);
                    sqlDAVolRes.Update(ChangedRows);
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

        private void txtFolio_TextChanged(object sender, System.EventArgs e)
        {
            dsVolumetrico1.Tables["VolumetricoRes"].Clear();
            sqlDAVolRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
            sqlDAVolRes.Fill(dsVolumetrico1, "VolumetricoRes");
        }

    }
}
