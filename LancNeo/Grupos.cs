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
    public partial class Grupos : CatalogoGenerico
    {
        private int nuevo = 0;
        public Grupos()
        {
            InitializeComponent();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            this.buscaBtn1.Catalogo = this;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
        }
        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            nuevo = 1;
            dGVObras.Visible = false;
            dGVObras.Enabled = false;
        }
        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Intente actualizar el origen de datos.
                base.BindingContext[dsGruposR1, "Grupo"].Position = this.BindingContext[dsGruposR1, "Grupo"].Position;
                this.UpdateDataSet1();
                base.dsGeneral_PositionChanged();
            }
            catch (System.Exception eUpdate)
            {
                statusBar1.Panels[2].Text = eUpdate.Message;
                statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
                statusBar1.Panels[2].ToolTipText = eUpdate.Message;
            }

            if (nuevo == 1)
            {
                dGVObras.Visible = true;
                dGVObras.Enabled = true;
            }
        }

        public override void LoadDataSet()
        {

            base.LoadDataSet();

            dsGruposR1.GrupoObra.Clear();
            sqlDAGrObra.SelectCommand.Parameters["@IdGrupo"].Value = txtGrupo.Text;
            sqlDAGrObra.Fill(dsGruposR1, "GrupoObra");
        }

        private void UpdateDataSet1()
        {
            // Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            // original			DataSet objDataSetChanges = new DataSet();
            LancNeo.dsGruposR objDataSetChanges = new LancNeo.dsGruposR();
            // Detener las ediciones actuales.
            // original			this.BindingContext[dsgeneral].EndCurrentEdit();
            this.BindingContext[dsGruposR1, "Grupo"].EndCurrentEdit();
            //            this.BindingContext[dsCatServicios1, "CatServicios"].EndCurrentEdit();
            //            this.BindingContext[dsCatServicios1, "CatServicios"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            // original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

            objDataSetChanges = ((LancNeo.dsGruposR)(dsGruposR1.GetChanges()));

            // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    dsGruposR1.Merge(objDataSetChanges);
                    dsGruposR1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsGruposR ChangedRows)
        {
            try
            {
                // Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
                if ((ChangedRows != null))
                {
                    // Abra la conexión.
                    this.sqlConn.Open();
                    // Intente actualizar el origen de datos.
                    sqlDAGrupo.Update(ChangedRows);
                    sqlDAGrObra.Update(ChangedRows);
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

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {
            dsGruposR1.GrupoObra.Clear();
            sqlDAGrObra.SelectCommand.Parameters["@IdGrupo"].Value = txtGrupo.Text;
            sqlDAGrObra.Fill(dsGruposR1, "GrupoObra");
        }

    }
}
