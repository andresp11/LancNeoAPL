using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Tempranos.
	/// </summary>
	public class Tempranos : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDATempranos;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		public System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsTempranos dsTempranos1;
		private System.Windows.Forms.TextBox txtIdTempranos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox txtTempranos;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Tempranos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tempranos));
            this.sqlDATempranos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsTempranos1 = new LancNeo.dsTempranos();
            this.txtIdTempranos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTempranos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempranos1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 279);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(576, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(576, 64);
            // 
            // sqlDATempranos
            // 
            this.sqlDATempranos.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDATempranos.InsertCommand = this.sqlInsertCommand1;
            this.sqlDATempranos.SelectCommand = this.sqlSelectCommand1;
            this.sqlDATempranos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tempranos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdTempranos", "IdTempranos"),
                        new System.Data.Common.DataColumnMapping("Tempranos", "Tempranos")})});
            this.sqlDATempranos.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Tempranos WHERE (IdTempranos = @Original_IdTempranos) AND (Tempranos " +
                "= @Original_Tempranos OR @Original_Tempranos IS NULL AND Tempranos IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdTempranos", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdTempranos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tempranos", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tempranos", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Tempranos(IdTempranos, Tempranos) VALUES (@IdTempranos, @Tempranos); " +
                "SELECT IdTempranos, Tempranos FROM Tempranos WHERE (IdTempranos = @IdTempranos)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdTempranos", System.Data.SqlDbType.SmallInt, 2, "IdTempranos"),
            new System.Data.SqlClient.SqlParameter("@Tempranos", System.Data.SqlDbType.VarChar, 10, "Tempranos")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdTempranos, Tempranos FROM Tempranos";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdTempranos", System.Data.SqlDbType.SmallInt, 2, "IdTempranos"),
            new System.Data.SqlClient.SqlParameter("@Tempranos", System.Data.SqlDbType.VarChar, 10, "Tempranos"),
            new System.Data.SqlClient.SqlParameter("@Original_IdTempranos", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdTempranos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tempranos", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tempranos", System.Data.DataRowVersion.Original, null)});
            // 
            // dsTempranos1
            // 
            this.dsTempranos1.DataSetName = "dsTempranos";
            this.dsTempranos1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTempranos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdTempranos
            // 
            this.txtIdTempranos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTempranos1, "Tempranos.IdTempranos", true));
            this.txtIdTempranos.Location = new System.Drawing.Point(160, 95);
            this.txtIdTempranos.Name = "txtIdTempranos";
            this.txtIdTempranos.Size = new System.Drawing.Size(46, 20);
            this.txtIdTempranos.TabIndex = 4;
            this.txtIdTempranos.Text = "0";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(74, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "IdTempranos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTempranos
            // 
            this.txtTempranos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTempranos1, "Tempranos.Tempranos", true));
            this.txtTempranos.Location = new System.Drawing.Point(160, 126);
            this.txtTempranos.Name = "txtTempranos";
            this.txtTempranos.Size = new System.Drawing.Size(100, 20);
            this.txtTempranos.TabIndex = 6;
            this.txtTempranos.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(74, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tempranos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 400;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsTempranos1.Tempranos;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(276, 90);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 8;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // Tempranos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 301);
            this.Controls.Add(this.buscaBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTempranos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdTempranos);
            this.DAGeneral = this.sqlDATempranos;
            this.dsGeneral = this.dsTempranos1;
            this.Name = "Tempranos";
            this.NombreTabla = "Tempranos";
            this.Text = "Tempranos";
            this.Load += new System.EventHandler(this.Tempranos_Load);
            this.Controls.SetChildIndex(this.txtIdTempranos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTempranos, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.buscaBtn1, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTempranos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Tempranos_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (dsTempranos1.Tables.Count >= 0)
				{
					txtIdTempranos.Text = dsTempranos1.Tables["Tempranos"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
					txtTempranos.Text = dsTempranos1.Tables["Tempranos"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
				}
			}
			catch(Exception ex)
			{
				//MessageBox.Show(ex.Message );
			}
		}
	}
}
