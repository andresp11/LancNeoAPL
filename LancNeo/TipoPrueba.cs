using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de TipoPrueba.
	/// </summary>
	public class TipoPrueba : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblIdPrueba;
		private System.Windows.Forms.Label lblPrueba;
		private System.Windows.Forms.TextBox txtIdPrueba;
		private System.Windows.Forms.TextBox txtPrueba;
		private System.Data.SqlClient.SqlDataAdapter sqlDATipoPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TipoPrueba()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoPrueba));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.txtIdPrueba = new System.Windows.Forms.TextBox();
            this.lblIdPrueba = new System.Windows.Forms.Label();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            this.sqlDATipoPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
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
            this.panel1.Controls.Add(this.txtIdPrueba);
            this.panel1.Controls.Add(this.lblIdPrueba);
            this.panel1.Controls.Add(this.lblPrueba);
            this.panel1.Controls.Add(this.txtPrueba);
            this.panel1.Location = new System.Drawing.Point(102, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 192);
            this.panel1.TabIndex = 0;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsTipoPrueba1.Tipoprueba;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(264, 32);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            this.buscaBtn1.Load += new System.EventHandler(this.buscaBtn1_Load);
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdPrueba
            // 
            this.txtIdPrueba.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTipoPrueba1, "Tipoprueba.IdPrueba", true));
            this.txtIdPrueba.Location = new System.Drawing.Point(160, 63);
            this.txtIdPrueba.Name = "txtIdPrueba";
            this.txtIdPrueba.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrueba.TabIndex = 1;
            this.txtIdPrueba.Text = "textBox1";
            // 
            // lblIdPrueba
            // 
            this.lblIdPrueba.Location = new System.Drawing.Point(48, 63);
            this.lblIdPrueba.Name = "lblIdPrueba";
            this.lblIdPrueba.Size = new System.Drawing.Size(100, 23);
            this.lblIdPrueba.TabIndex = 0;
            this.lblIdPrueba.Text = "Id Prueba:";
            this.lblIdPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrueba
            // 
            this.lblPrueba.Location = new System.Drawing.Point(48, 103);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(100, 23);
            this.lblPrueba.TabIndex = 0;
            this.lblPrueba.Text = "Prueba:";
            this.lblPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrueba
            // 
            this.txtPrueba.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTipoPrueba1, "Tipoprueba.Prueba", true));
            this.txtPrueba.Location = new System.Drawing.Point(160, 103);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(100, 20);
            this.txtPrueba.TabIndex = 1;
            this.txtPrueba.Text = "textBox1";
            // 
            // sqlDATipoPrueba
            // 
            this.sqlDATipoPrueba.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDATipoPrueba.InsertCommand = this.sqlInsertCommand1;
            this.sqlDATipoPrueba.SelectCommand = this.sqlSelectCommand1;
            this.sqlDATipoPrueba.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipoprueba", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba")})});
            this.sqlDATipoPrueba.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Tipoprueba WHERE (IdPrueba = @Original_IdPrueba) AND (Prueba = @Origi" +
                "nal_Prueba)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdPrueba", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Prueba", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prueba", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Tipoprueba(IdPrueba, Prueba) VALUES (@IdPrueba, @Prueba); SELECT IdPr" +
                "ueba, Prueba FROM Tipoprueba WHERE (IdPrueba = @IdPrueba) ORDER BY IdPrueba";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@Prueba", System.Data.SqlDbType.NVarChar, 10, "Prueba")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdPrueba, Prueba FROM Tipoprueba ORDER BY IdPrueba";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 2, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@Prueba", System.Data.SqlDbType.NVarChar, 10, "Prueba"),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrueba", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Prueba", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prueba", System.Data.DataRowVersion.Original, null)});
            // 
            // TipoPrueba
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDATipoPrueba;
            this.dsGeneral = this.dsTipoPrueba1;
            this.Name = "TipoPrueba";
            this.NombreTabla = "TipoPrueba";
            this.Text = "Catálogo de Tipos de Prueba";
            this.Load += new System.EventHandler(this.TipoPrueba_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void TipoPrueba_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }


	}
}
