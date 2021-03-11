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
    public partial class TabMdor : CatalogoGenerico
    {
        private string IdUsuario;
                public TabMdor()
        {
            InitializeComponent();
        }

        private void TabMdor_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            this.WindowState = FormWindowState.Maximized;
            buscaBtn1.Catalogo = this;
			sqlDABusObra.Fill(dsBusObra1,"Obra");
			sqlDALaboratorista.Fill(dsLaboratorista1,"Laboratorista");
            sqlDAComo.Fill(dsComo1,"TabiqueMdor");
            sqlDATipo.Fill(dsTipoBlock1, "TabiqueMdor");
        }
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			dsTabMdor1.TabiqueMdor.MReducidaColumn.DefaultValue = 1;
			dsTabMdor1.TabiqueMdor.UnidadColumn.DefaultValue = 1;
			dsTabMdor1.TabiqueMdor.CumpleColumn.DefaultValue = 0;
			dsTabMdor1.TabiqueMdor.NormaColumn.DefaultValue = 1;
			dsTabMdor1.TabiqueMdor.EmpleadoColumn.DefaultValue = 0;
			base.btnNuevo_Click(sender, e);
			cmbIdObra.SelectedIndex = -1;
			cmbNoeco.SelectedIndex = -1;
			dtpFmuestreo.Value = DateTime.Now.AddDays(1);
			dtpFmuestreo.Value = DateTime.Today; 
//			dtpFensaye.Value = DateTime.Now.AddDays(1);
//			dtpFensaye.Value = DateTime.Today; 
//			dtpFFabrica.Value = DateTime.Now.AddDays(-7);
		}
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsTabMdor1,"TabiqueMdor"].Position = this.BindingContext[dsTabMdor1,"TabiqueMdor"].Position;
//				this.UpdateDataSet2();
                this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
//			dsTabMdor1.Tables["TabiqueRes"].Clear();
//			sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
//			sqlDATabiqueRes.Fill(dsTabMdor1,"TabiqueRes");
//            dsTabMdor1.Tables["TabiqueRes1"].Clear();
//            sqlDATabiqueRes1.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
//            sqlDATabiqueRes1.Fill(dsTabMdor1, "TabiqueRes");
            chbCompresion_CheckedChanged(null, null);
        }

		public override void LoadDataSet()
		{

//			sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			base.LoadDataSet();
//			dgTabique.SetDataBinding(dsTabMdor1, "TabiqueMdor.Tabique");
//			string apl = dgTabique.TableStyles.ToString();
            dsTabMdor1.Tables["TabiqueRes"].Clear();
            sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
            sqlDATabiqueRes.Fill(dsTabMdor1, "TabiqueRes");
//            dsTabMdor1.Tables["TabiqueRes1"].Clear();
//            sqlDATabiqueRes1.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
//            sqlDATabiqueRes1.Fill(dsTabMdor1, "TabiqueRes1");
        }

        private void UpdateDataSet1()
        {
            // Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            // original			DataSet objDataSetChanges = new DataSet();
            LancNeo.dsTabMdor objDataSetChanges = new LancNeo.dsTabMdor();
            // Detener las ediciones actuales.
            // original			this.BindingContext[dsgeneral].EndCurrentEdit();
            this.BindingContext[dsTabMdor1, "TabiqueMdor"].EndCurrentEdit();
            this.BindingContext[dsTabMdor1, "TabiqueRes"].EndCurrentEdit();
            //            this.BindingContext[dsTabMdor1, "TabiqueRes1"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            // original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

            objDataSetChanges = ((LancNeo.dsTabMdor)(dsTabMdor1.GetChanges()));

            // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método  de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    //                    this.UpdateDataSource1(dsTabMdor1.GetChanges());
                    dsTabMdor1.Merge(objDataSetChanges);
                    dsTabMdor1.AcceptChanges();
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
		private void UpdateDataSet2()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsTabMdor objDataSetChanges = new LancNeo.dsTabMdor();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsTabMdor1, "TabiqueMdor"].EndCurrentEdit();
//			this.BindingContext[dsTabMdor1, "TabiqueRes"].EndCurrentEdit();
            this.BindingContext[dsTabMdor1, "TabiqueRes1"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsTabMdor)(dsTabMdor1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método  de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource2(objDataSetChanges);
//                    this.UpdateDataSource1(dsTabMdor1.GetChanges());
                    dsTabMdor1.Merge(objDataSetChanges);
					dsTabMdor1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsTabMdor ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDATabiqueMdor.Update(ChangedRows);
					sqlDATabiqueRes.Update(ChangedRows);
//                    sqlDATabiqueRes1.Update(ChangedRows);
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
		private void UpdateDataSource2(LancNeo.dsTabMdor ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDATabiqueMdor.Update(ChangedRows);
//					sqlDATabiqueRes.Update(ChangedRows);
                    sqlDATabiqueRes1.Update(ChangedRows);
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

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label10_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txtObserva_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txtFolio_TextChanged(object sender, System.EventArgs e)
		{
            chbCompresion.Checked = true;
            dsTabMdor1.Tables["TabiqueRes"].Clear();
			sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDATabiqueRes.Fill(dsTabMdor1,"TabiqueRes");
//            dsTabMdor1.Tables["TabiqueRes1"].Clear();
//            sqlDATabiqueRes1.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
//            sqlDATabiqueRes1.Fill(dsTabMdor1, "TabiqueRes1");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                  MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  e.Handled = true;
                  return;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void cbEmpleado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void dgTabique_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["tMuestraDataGridViewCheckBoxColumn"].Value = 1;
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dataGridViewCheckBoxColumn1"].Value = 0;

        }

        private void chbCompresion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCompresion.Checked)
            {
                dsTabMdor1.Tables["TabiqueRes"].Clear();
                sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
                sqlDATabiqueRes.Fill(dsTabMdor1, "TabiqueRes");
                dgTabique.Visible = true;
                dataGridView1.Visible = false;
            }
            else
            {
                dsTabMdor1.Tables["TabiqueRes"].Clear();
                sqlDATabiqueRes1.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
                sqlDATabiqueRes1.Fill(dsTabMdor1, "TabiqueRes");
                dgTabique.Visible = false;
                dataGridView1.Visible = true;
            }

        }
    }
}
