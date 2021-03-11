using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Descarga.
	/// </summary>
	public class Descarga : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblDescarga;
		private System.Windows.Forms.Label lblIdDescarga;
		private System.Windows.Forms.TextBox txtIdDescarga;
		private System.Windows.Forms.TextBox txtDescarga;
		private System.Data.SqlClient.SqlDataAdapter sqlDADescarga;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsDescarga dsDescarga1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Descarga()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Descarga));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsDescarga1 = new LancNeo.dsDescarga();
            this.txtIdDescarga = new System.Windows.Forms.TextBox();
            this.lblDescarga = new System.Windows.Forms.Label();
            this.lblIdDescarga = new System.Windows.Forms.Label();
            this.txtDescarga = new System.Windows.Forms.TextBox();
            this.sqlDADescarga = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescarga1)).BeginInit();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.txtIdDescarga);
            this.panel1.Controls.Add(this.lblDescarga);
            this.panel1.Controls.Add(this.lblIdDescarga);
            this.panel1.Controls.Add(this.txtDescarga);
            this.panel1.Location = new System.Drawing.Point(96, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 176);
            this.panel1.TabIndex = 10;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsDescarga1.Descarga;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(256, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsDescarga1
            // 
            this.dsDescarga1.DataSetName = "dsDescarga";
            this.dsDescarga1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDescarga1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdDescarga
            // 
            this.txtIdDescarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDescarga1, "Descarga.IdDescarga", true));
            this.txtIdDescarga.Location = new System.Drawing.Point(152, 48);
            this.txtIdDescarga.Name = "txtIdDescarga";
            this.txtIdDescarga.Size = new System.Drawing.Size(100, 20);
            this.txtIdDescarga.TabIndex = 1;
            this.txtIdDescarga.Text = "textBox1";
            // 
            // lblDescarga
            // 
            this.lblDescarga.Location = new System.Drawing.Point(40, 88);
            this.lblDescarga.Name = "lblDescarga";
            this.lblDescarga.Size = new System.Drawing.Size(100, 23);
            this.lblDescarga.TabIndex = 0;
            this.lblDescarga.Text = "Descarga:";
            this.lblDescarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIdDescarga
            // 
            this.lblIdDescarga.Location = new System.Drawing.Point(40, 48);
            this.lblIdDescarga.Name = "lblIdDescarga";
            this.lblIdDescarga.Size = new System.Drawing.Size(100, 23);
            this.lblIdDescarga.TabIndex = 0;
            this.lblIdDescarga.Text = "Id Descarga:";
            this.lblIdDescarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescarga
            // 
            this.txtDescarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDescarga1, "Descarga.Descarga", true));
            this.txtDescarga.Location = new System.Drawing.Point(152, 88);
            this.txtDescarga.Name = "txtDescarga";
            this.txtDescarga.Size = new System.Drawing.Size(216, 20);
            this.txtDescarga.TabIndex = 1;
            this.txtDescarga.Text = "textBox1";
            // 
            // sqlDADescarga
            // 
            this.sqlDADescarga.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDADescarga.InsertCommand = this.sqlInsertCommand1;
            this.sqlDADescarga.SelectCommand = this.sqlSelectCommand1;
            this.sqlDADescarga.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Descarga", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdDescarga", "IdDescarga"),
                        new System.Data.Common.DataColumnMapping("Descarga", "Descarga")})});
            this.sqlDADescarga.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Descarga WHERE (IdDescarga = @Original_IdDescarga) AND (Descarga = @O" +
                "riginal_Descarga)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdDescarga", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDescarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Descarga", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descarga", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Descarga(IdDescarga, Descarga) VALUES (@IdDescarga, @Descarga); SELEC" +
                "T IdDescarga, Descarga FROM Descarga WHERE (IdDescarga = @IdDescarga)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdDescarga", System.Data.SqlDbType.SmallInt, 2, "IdDescarga"),
            new System.Data.SqlClient.SqlParameter("@Descarga", System.Data.SqlDbType.NVarChar, 20, "Descarga")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdDescarga, Descarga FROM Descarga";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdDescarga", System.Data.SqlDbType.SmallInt, 2, "IdDescarga"),
            new System.Data.SqlClient.SqlParameter("@Descarga", System.Data.SqlDbType.NVarChar, 20, "Descarga"),
            new System.Data.SqlClient.SqlParameter("@Original_IdDescarga", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDescarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Descarga", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descarga", System.Data.DataRowVersion.Original, null)});
            // 
            // Descarga
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDADescarga;
            this.dsGeneral = this.dsDescarga1;
            this.Name = "Descarga";
            this.NombreTabla = "Descarga";
            this.Text = "Descarga";
            this.Load += new System.EventHandler(this.Descarga_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescarga1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Descarga_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}
	}
}
