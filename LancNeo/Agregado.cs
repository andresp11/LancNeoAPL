using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Agregado.
	/// </summary>
	public class Agregado : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAAgregado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private LancNeo.dsAgregado dsAgregado1;
		private System.Windows.Forms.TextBox txtIdAgregado;
		private System.Windows.Forms.TextBox txtAgregado;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.Label lblIdAgregado;
		private System.Windows.Forms.Label lblAgregado;
		private System.Windows.Forms.Label lblTipo;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Agregado()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregado));
            this.sqlDAAgregado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsAgregado1 = new LancNeo.dsAgregado();
            this.txtIdAgregado = new System.Windows.Forms.TextBox();
            this.txtAgregado = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblIdAgregado = new System.Windows.Forms.Label();
            this.lblAgregado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).BeginInit();
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
            // sqlDAAgregado
            // 
            this.sqlDAAgregado.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAAgregado.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAAgregado.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAAgregado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Agregado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo")})});
            this.sqlDAAgregado.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Agregado WHERE (IdAgregado = @Original_IdAgregado) AND (Agregado = @O" +
                "riginal_Agregado OR @Original_Agregado IS NULL AND Agregado IS NULL) AND (Tipo =" +
                " @Original_Tipo)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdAgregado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.NVarChar, 11, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Agregado(IdAgregado, Agregado, Tipo) VALUES (@IdAgregado, @Agregado, " +
                "@Tipo); SELECT IdAgregado, Agregado, Tipo FROM Agregado WHERE (IdAgregado = @IdA" +
                "gregado)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.NVarChar, 15, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.NVarChar, 11, "Tipo")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdAgregado, Agregado, Tipo FROM Agregado";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.NVarChar, 15, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.NVarChar, 11, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Original_IdAgregado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.NVarChar, 11, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null)});
            // 
            // dsAgregado1
            // 
            this.dsAgregado1.DataSetName = "dsAgregado";
            this.dsAgregado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAgregado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdAgregado
            // 
            this.txtIdAgregado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAgregado1, "Agregado.IdAgregado", true));
            this.txtIdAgregado.Location = new System.Drawing.Point(160, 40);
            this.txtIdAgregado.Name = "txtIdAgregado";
            this.txtIdAgregado.Size = new System.Drawing.Size(64, 20);
            this.txtIdAgregado.TabIndex = 3;
            // 
            // txtAgregado
            // 
            this.txtAgregado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAgregado1, "Agregado.Agregado", true));
            this.txtAgregado.Location = new System.Drawing.Point(160, 72);
            this.txtAgregado.Name = "txtAgregado";
            this.txtAgregado.Size = new System.Drawing.Size(160, 20);
            this.txtAgregado.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAgregado1, "Agregado.Tipo", true));
            this.txtTipo.Location = new System.Drawing.Point(160, 104);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(160, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // lblIdAgregado
            // 
            this.lblIdAgregado.Location = new System.Drawing.Point(48, 40);
            this.lblIdAgregado.Name = "lblIdAgregado";
            this.lblIdAgregado.Size = new System.Drawing.Size(100, 23);
            this.lblIdAgregado.TabIndex = 6;
            this.lblIdAgregado.Text = "IdAgregado:";
            this.lblIdAgregado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAgregado
            // 
            this.lblAgregado.Location = new System.Drawing.Point(48, 72);
            this.lblAgregado.Name = "lblAgregado";
            this.lblAgregado.Size = new System.Drawing.Size(100, 23);
            this.lblAgregado.TabIndex = 6;
            this.lblAgregado.Text = "Agregado:";
            this.lblAgregado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(48, 104);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 23);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.txtAgregado);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.lblAgregado);
            this.panel1.Controls.Add(this.txtIdAgregado);
            this.panel1.Controls.Add(this.lblIdAgregado);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(80, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 176);
            this.panel1.TabIndex = 7;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsAgregado1.Agregado;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(232, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            this.buscaBtn1.Load += new System.EventHandler(this.buscaBtn1_Load);
            // 
            // Agregado
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDAAgregado;
            this.dsGeneral = this.dsAgregado1;
            this.Name = "Agregado";
            this.NombreTabla = "agregado";
            this.Text = "Catálogo de Agregados";
            this.Load += new System.EventHandler(this.Agregado_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Agregado_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }
	}
}
