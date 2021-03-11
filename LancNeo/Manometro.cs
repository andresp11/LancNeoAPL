using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Manometro.
	/// </summary>
	public class Manometro : CatalogoGenerico 
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblIdManometro;
		private System.Windows.Forms.Label lblManometro;
		private System.Windows.Forms.TextBox txtIdManometro;
		private System.Windows.Forms.TextBox txtManometro;
		private System.Data.SqlClient.SqlDataAdapter sqlDAManometro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsManometro dsManometro1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Manometro()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manometro));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsManometro1 = new LancNeo.dsManometro();
            this.txtIdManometro = new System.Windows.Forms.TextBox();
            this.lblIdManometro = new System.Windows.Forms.Label();
            this.lblManometro = new System.Windows.Forms.Label();
            this.txtManometro = new System.Windows.Forms.TextBox();
            this.sqlDAManometro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsManometro1)).BeginInit();
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
            this.panel2.Controls.Add(this.txtIdManometro);
            this.panel2.Controls.Add(this.lblIdManometro);
            this.panel2.Controls.Add(this.lblManometro);
            this.panel2.Controls.Add(this.txtManometro);
            this.panel2.Location = new System.Drawing.Point(116, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 192);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsManometro1.Manometro;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(232, 32);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsManometro1
            // 
            this.dsManometro1.DataSetName = "dsManometro";
            this.dsManometro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsManometro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdManometro
            // 
            this.txtIdManometro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsManometro1, "Manometro.IdManometro", true));
            this.txtIdManometro.Location = new System.Drawing.Point(130, 64);
            this.txtIdManometro.Name = "txtIdManometro";
            this.txtIdManometro.Size = new System.Drawing.Size(100, 20);
            this.txtIdManometro.TabIndex = 1;
            this.txtIdManometro.Text = "textBox1";
            // 
            // lblIdManometro
            // 
            this.lblIdManometro.Location = new System.Drawing.Point(26, 60);
            this.lblIdManometro.Name = "lblIdManometro";
            this.lblIdManometro.Size = new System.Drawing.Size(100, 23);
            this.lblIdManometro.TabIndex = 0;
            this.lblIdManometro.Text = "Id Manómetro:";
            this.lblIdManometro.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblManometro
            // 
            this.lblManometro.Location = new System.Drawing.Point(26, 100);
            this.lblManometro.Name = "lblManometro";
            this.lblManometro.Size = new System.Drawing.Size(100, 23);
            this.lblManometro.TabIndex = 0;
            this.lblManometro.Text = "Manómetro:";
            this.lblManometro.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtManometro
            // 
            this.txtManometro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsManometro1, "Manometro.Manometro", true));
            this.txtManometro.Location = new System.Drawing.Point(130, 104);
            this.txtManometro.MaxLength = 50;
            this.txtManometro.Name = "txtManometro";
            this.txtManometro.Size = new System.Drawing.Size(150, 20);
            this.txtManometro.TabIndex = 1;
            this.txtManometro.Text = "textBox1";
            // 
            // sqlDAManometro
            // 
            this.sqlDAManometro.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAManometro.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAManometro.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAManometro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Manometro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdManometro", "IdManometro"),
                        new System.Data.Common.DataColumnMapping("Manometro", "Manometro")})});
            this.sqlDAManometro.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Manometro WHERE (IdManometro = @Original_IdManometro) AND (Manometro " +
                "= @Original_Manometro OR @Original_Manometro IS NULL AND Manometro IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdManometro", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdManometro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Manometro", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Manometro", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Manometro(IdManometro, Manometro) VALUES (@IdManometro, @Manometro); " +
                "SELECT IdManometro, Manometro FROM Manometro WHERE (IdManometro = @IdManometro) " +
                "ORDER BY IdManometro";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdManometro", System.Data.SqlDbType.SmallInt, 2, "IdManometro"),
            new System.Data.SqlClient.SqlParameter("@Manometro", System.Data.SqlDbType.NVarChar, 50, "Manometro")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdManometro, Manometro FROM Manometro ORDER BY IdManometro";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdManometro", System.Data.SqlDbType.SmallInt, 2, "IdManometro"),
            new System.Data.SqlClient.SqlParameter("@Manometro", System.Data.SqlDbType.NVarChar, 50, "Manometro"),
            new System.Data.SqlClient.SqlParameter("@Original_IdManometro", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdManometro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Manometro", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Manometro", System.Data.DataRowVersion.Original, null)});
            // 
            // Manometro
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAManometro;
            this.dsGeneral = this.dsManometro1;
            this.Name = "Manometro";
            this.NombreTabla = "Manometro";
            this.Text = "Manometro";
            this.Load += new System.EventHandler(this.Manometro_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsManometro1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Manometro_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}
	}
}
