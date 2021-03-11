using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Prensa.
	/// </summary>
	public class Prensa : CatalogoGenerico 
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblIdPrensa;
		private System.Windows.Forms.Label lblPrensa;
		private System.Windows.Forms.TextBox txtIdPrensa;
		private System.Windows.Forms.TextBox txtPrensa;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrensa;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsPrensa dsPrensa1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Prensa()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prensa));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsPrensa1 = new LancNeo.dsPrensa();
            this.txtIdPrensa = new System.Windows.Forms.TextBox();
            this.lblIdPrensa = new System.Windows.Forms.Label();
            this.lblPrensa = new System.Windows.Forms.Label();
            this.txtPrensa = new System.Windows.Forms.TextBox();
            this.sqlDAPrensa = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrensa1)).BeginInit();
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtIdPrensa);
            this.panel2.Controls.Add(this.lblIdPrensa);
            this.panel2.Controls.Add(this.lblPrensa);
            this.panel2.Controls.Add(this.txtPrensa);
            this.panel2.Location = new System.Drawing.Point(112, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 176);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsPrensa1.Prensa;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(232, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsPrensa1
            // 
            this.dsPrensa1.DataSetName = "dsPrensa";
            this.dsPrensa1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPrensa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdPrensa
            // 
            this.txtIdPrensa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPrensa1, "Prensa.IdPrensa", true));
            this.txtIdPrensa.Location = new System.Drawing.Point(130, 51);
            this.txtIdPrensa.MaxLength = 2;
            this.txtIdPrensa.Name = "txtIdPrensa";
            this.txtIdPrensa.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrensa.TabIndex = 1;
            this.txtIdPrensa.Text = "textBox1";
            // 
            // lblIdPrensa
            // 
            this.lblIdPrensa.Location = new System.Drawing.Point(66, 51);
            this.lblIdPrensa.Name = "lblIdPrensa";
            this.lblIdPrensa.Size = new System.Drawing.Size(56, 23);
            this.lblIdPrensa.TabIndex = 0;
            this.lblIdPrensa.Text = "Id Prensa:";
            this.lblIdPrensa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrensa
            // 
            this.lblPrensa.Location = new System.Drawing.Point(66, 99);
            this.lblPrensa.Name = "lblPrensa";
            this.lblPrensa.Size = new System.Drawing.Size(56, 23);
            this.lblPrensa.TabIndex = 0;
            this.lblPrensa.Text = "Prensa:";
            this.lblPrensa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrensa
            // 
            this.txtPrensa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPrensa1, "Prensa.Prensa", true));
            this.txtPrensa.Location = new System.Drawing.Point(130, 99);
            this.txtPrensa.MaxLength = 50;
            this.txtPrensa.Name = "txtPrensa";
            this.txtPrensa.Size = new System.Drawing.Size(198, 20);
            this.txtPrensa.TabIndex = 1;
            this.txtPrensa.Text = "textBox1";
            // 
            // sqlDAPrensa
            // 
            this.sqlDAPrensa.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAPrensa.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAPrensa.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAPrensa.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Prensa", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrensa", "IdPrensa"),
                        new System.Data.Common.DataColumnMapping("Prensa", "Prensa")})});
            this.sqlDAPrensa.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Prensa WHERE (IdPrensa = @Original_IdPrensa) AND (Prensa = @Original_" +
                "Prensa OR @Original_Prensa IS NULL AND Prensa IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdPrensa", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrensa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Prensa", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prensa", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Prensa(IdPrensa, Prensa) VALUES (@IdPrensa, @Prensa); SELECT IdPrensa" +
                ", Prensa FROM Prensa WHERE (IdPrensa = @IdPrensa) ORDER BY IdPrensa";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdPrensa", System.Data.SqlDbType.NVarChar, 2, "IdPrensa"),
            new System.Data.SqlClient.SqlParameter("@Prensa", System.Data.SqlDbType.NVarChar, 50, "Prensa")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdPrensa, Prensa FROM Prensa ORDER BY IdPrensa";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdPrensa", System.Data.SqlDbType.NVarChar, 2, "IdPrensa"),
            new System.Data.SqlClient.SqlParameter("@Prensa", System.Data.SqlDbType.NVarChar, 50, "Prensa"),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrensa", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrensa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Prensa", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prensa", System.Data.DataRowVersion.Original, null)});
            // 
            // Prensa
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAPrensa;
            this.dsGeneral = this.dsPrensa1;
            this.Name = "Prensa";
            this.NombreTabla = "Prensa";
            this.Text = "Prensa";
            this.Load += new System.EventHandler(this.Prensa_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrensa1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Prensa_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}
	}
}
