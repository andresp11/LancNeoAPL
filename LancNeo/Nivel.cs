using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Nivel.
	/// </summary>
	public class Nivel : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtIdNivel;
		private System.Windows.Forms.Label lblIdNivel;
		private System.Windows.Forms.Label lblNivel;
		private System.Windows.Forms.TextBox txtNivel;
		private System.Data.SqlClient.SqlDataAdapter sqlDANivel;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsNivel dsNivel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Nivel()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsNivel1 = new LancNeo.dsNivel();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.lblIdNivel = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.sqlDANivel = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNivel1)).BeginInit();
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
            this.panel2.Controls.Add(this.txtIdNivel);
            this.panel2.Controls.Add(this.lblIdNivel);
            this.panel2.Controls.Add(this.lblNivel);
            this.panel2.Controls.Add(this.txtNivel);
            this.panel2.Location = new System.Drawing.Point(136, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 192);
            this.panel2.TabIndex = 5;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsNivel1.Nivel;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(208, 32);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsNivel1
            // 
            this.dsNivel1.DataSetName = "dsNivel";
            this.dsNivel1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsNivel1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNivel1, "Nivel.IdNivel", true));
            this.txtIdNivel.Location = new System.Drawing.Point(104, 64);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(100, 20);
            this.txtIdNivel.TabIndex = 1;
            this.txtIdNivel.Text = "textBox1";
            // 
            // lblIdNivel
            // 
            this.lblIdNivel.Location = new System.Drawing.Point(40, 60);
            this.lblIdNivel.Name = "lblIdNivel";
            this.lblIdNivel.Size = new System.Drawing.Size(56, 23);
            this.lblIdNivel.TabIndex = 0;
            this.lblIdNivel.Text = "Id Nivel:";
            this.lblIdNivel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblNivel
            // 
            this.lblNivel.Location = new System.Drawing.Point(40, 100);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(56, 23);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel:";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtNivel
            // 
            this.txtNivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsNivel1, "Nivel.Nivel", true));
            this.txtNivel.Location = new System.Drawing.Point(104, 104);
            this.txtNivel.MaxLength = 50;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(150, 20);
            this.txtNivel.TabIndex = 1;
            this.txtNivel.Text = "textBox1";
            // 
            // sqlDANivel
            // 
            this.sqlDANivel.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDANivel.InsertCommand = this.sqlInsertCommand1;
            this.sqlDANivel.SelectCommand = this.sqlSelectCommand1;
            this.sqlDANivel.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Nivel", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdNivel", "IdNivel"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel")})});
            this.sqlDANivel.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Nivel WHERE (IdNivel = @Original_IdNivel) AND (Nivel = @Original_Nive" +
                "l OR @Original_Nivel IS NULL AND Nivel IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdNivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdNivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Nivel(IdNivel, Nivel) VALUES (@IdNivel, @Nivel); SELECT IdNivel, Nive" +
                "l FROM Nivel WHERE (IdNivel = @IdNivel) ORDER BY IdNivel";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNivel", System.Data.SqlDbType.SmallInt, 2, "IdNivel"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 50, "Nivel")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdNivel, Nivel FROM Nivel ORDER BY IdNivel";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNivel", System.Data.SqlDbType.SmallInt, 2, "IdNivel"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 50, "Nivel"),
            new System.Data.SqlClient.SqlParameter("@Original_IdNivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdNivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null)});
            // 
            // Nivel
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDANivel;
            this.dsGeneral = this.dsNivel1;
            this.Name = "Nivel";
            this.NombreTabla = "Nivel";
            this.Text = "Nivel";
            this.Load += new System.EventHandler(this.Nivel_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNivel1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Nivel_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}


	}
}
