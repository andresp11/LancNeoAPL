using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Cabeceador.
	/// </summary>
	public class Cabeceador : CatalogoGenerico 
	{
		private System.Windows.Forms.Label lblIdCabeceador;
		private System.Windows.Forms.Label lblCabeceador;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Data.SqlClient.SqlDataAdapter sqlDACabeceador;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsCabeceador dsCabeceador1;
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Cabeceador()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cabeceador));
            this.lblIdCabeceador = new System.Windows.Forms.Label();
            this.lblCabeceador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dsCabeceador1 = new LancNeo.dsCabeceador();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sqlDACabeceador = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabeceador1)).BeginInit();
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
            // lblIdCabeceador
            // 
            this.lblIdCabeceador.Location = new System.Drawing.Point(40, 48);
            this.lblIdCabeceador.Name = "lblIdCabeceador";
            this.lblIdCabeceador.Size = new System.Drawing.Size(100, 23);
            this.lblIdCabeceador.TabIndex = 0;
            this.lblIdCabeceador.Text = "Id Cabeceador:";
            this.lblIdCabeceador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCabeceador
            // 
            this.lblCabeceador.Location = new System.Drawing.Point(40, 88);
            this.lblCabeceador.Name = "lblCabeceador";
            this.lblCabeceador.Size = new System.Drawing.Size(100, 23);
            this.lblCabeceador.TabIndex = 0;
            this.lblCabeceador.Text = "Cabeceador:";
            this.lblCabeceador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCabeceador1, "Cabeceador.IdCabaceador", true));
            this.textBox1.Location = new System.Drawing.Point(160, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "textBox1";
            // 
            // dsCabeceador1
            // 
            this.dsCabeceador1.DataSetName = "dsCabeceador";
            this.dsCabeceador1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsCabeceador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCabeceador1, "Cabeceador.Cabeceador", true));
            this.textBox2.Location = new System.Drawing.Point(160, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "textBox1";
            // 
            // sqlDACabeceador
            // 
            this.sqlDACabeceador.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDACabeceador.InsertCommand = this.sqlInsertCommand1;
            this.sqlDACabeceador.SelectCommand = this.sqlSelectCommand1;
            this.sqlDACabeceador.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Cabeceador", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCabaceador", "IdCabaceador"),
                        new System.Data.Common.DataColumnMapping("Cabeceador", "Cabeceador")})});
            this.sqlDACabeceador.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Cabeceador WHERE (IdCabaceador = @Original_IdCabaceador) AND (Cabecea" +
                "dor = @Original_Cabeceador OR @Original_Cabeceador IS NULL AND Cabeceador IS NUL" +
                "L)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdCabaceador", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCabaceador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cabeceador", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cabeceador", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Cabeceador(IdCabaceador, Cabeceador) VALUES (@IdCabaceador, @Cabecead" +
                "or); SELECT IdCabaceador, Cabeceador FROM Cabeceador WHERE (IdCabaceador = @IdCa" +
                "baceador)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdCabaceador", System.Data.SqlDbType.NVarChar, 2, "IdCabaceador"),
            new System.Data.SqlClient.SqlParameter("@Cabeceador", System.Data.SqlDbType.NVarChar, 50, "Cabeceador")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdCabaceador, Cabeceador FROM Cabeceador";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdCabaceador", System.Data.SqlDbType.NVarChar, 2, "IdCabaceador"),
            new System.Data.SqlClient.SqlParameter("@Cabeceador", System.Data.SqlDbType.NVarChar, 50, "Cabeceador"),
            new System.Data.SqlClient.SqlParameter("@Original_IdCabaceador", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCabaceador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cabeceador", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cabeceador", System.Data.DataRowVersion.Original, null)});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.lblCabeceador);
            this.panel1.Controls.Add(this.lblIdCabeceador);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(96, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 176);
            this.panel1.TabIndex = 9;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsCabeceador1.Cabeceador;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(264, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // Cabeceador
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDACabeceador;
            this.dsGeneral = this.dsCabeceador1;
            this.Name = "Cabeceador";
            this.NombreTabla = "Cabeceador";
            this.Text = "Catálogo de Cabeceadores";
            this.Load += new System.EventHandler(this.Cabeceador_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCabeceador1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Cabeceador_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}
	}
}
