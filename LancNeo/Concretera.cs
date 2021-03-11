using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Concretera.
	/// </summary>
	public class Concretera : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private LancNeo.dsConcretera dsConcretera1;
		private System.Windows.Forms.Label lblIdConcretera;
		private System.Windows.Forms.Label lblConcretera;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.TextBox txtIdConcretera;
		private System.Windows.Forms.TextBox txtConcretera;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Concretera()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concretera));
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.lblIdConcretera = new System.Windows.Forms.Label();
            this.lblConcretera = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtIdConcretera = new System.Windows.Forms.TextBox();
            this.txtConcretera = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(576, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(576, 64);
            // 
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAConcretera.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAConcretera.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            this.sqlDAConcretera.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Concretera WHERE (IdConcretera = @Original_IdConcretera) AND (Concret" +
                "era = @Original_Concretera) AND (Direccion = @Original_Direccion OR @Original_Di" +
                "reccion IS NULL AND Direccion IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdConcretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Concretera", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@Concretera", System.Data.SqlDbType.NVarChar, 50, "Concretera"),
            new System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.NVarChar, 50, "Direccion")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@Concretera", System.Data.SqlDbType.NVarChar, 50, "Concretera"),
            new System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.NVarChar, 50, "Direccion"),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Concretera", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null)});
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIdConcretera
            // 
            this.lblIdConcretera.Location = new System.Drawing.Point(16, 48);
            this.lblIdConcretera.Name = "lblIdConcretera";
            this.lblIdConcretera.Size = new System.Drawing.Size(80, 23);
            this.lblIdConcretera.TabIndex = 3;
            this.lblIdConcretera.Text = "Id Concretera:";
            this.lblIdConcretera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConcretera
            // 
            this.lblConcretera.Location = new System.Drawing.Point(16, 88);
            this.lblConcretera.Name = "lblConcretera";
            this.lblConcretera.Size = new System.Drawing.Size(80, 23);
            this.lblConcretera.TabIndex = 3;
            this.lblConcretera.Text = "Concretera:";
            this.lblConcretera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(16, 128);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 23);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdConcretera
            // 
            this.txtIdConcretera.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConcretera1, "Concretera.IdConcretera", true));
            this.txtIdConcretera.Location = new System.Drawing.Point(112, 48);
            this.txtIdConcretera.Name = "txtIdConcretera";
            this.txtIdConcretera.Size = new System.Drawing.Size(128, 20);
            this.txtIdConcretera.TabIndex = 4;
            this.txtIdConcretera.Text = "textBox1";
            // 
            // txtConcretera
            // 
            this.txtConcretera.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConcretera1, "Concretera.Concretera", true));
            this.txtConcretera.Location = new System.Drawing.Point(112, 88);
            this.txtConcretera.Name = "txtConcretera";
            this.txtConcretera.Size = new System.Drawing.Size(256, 20);
            this.txtConcretera.TabIndex = 4;
            this.txtConcretera.Text = "textBox1";
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConcretera1, "Concretera.Direccion", true));
            this.txtDireccion.Location = new System.Drawing.Point(112, 128);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(256, 20);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Text = "textBox1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.lblIdConcretera);
            this.panel1.Controls.Add(this.lblConcretera);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtIdConcretera);
            this.panel1.Controls.Add(this.txtConcretera);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Location = new System.Drawing.Point(96, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 192);
            this.panel1.TabIndex = 9;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcretera1.Concretera;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(240, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // Concretera
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDAConcretera;
            this.dsGeneral = this.dsConcretera1;
            this.Name = "Concretera";
            this.NombreTabla = "Concretera";
            this.Text = "Catálogo de Concreteras y Premezcladoras";
            this.Load += new System.EventHandler(this.Concretera_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Concretera_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}
	}
}
