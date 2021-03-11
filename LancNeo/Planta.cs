using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data;
using System.Data.SqlClient;
namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Planta.
	/// </summary>
	public class Planta : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtIdNivel;
		private System.Windows.Forms.Label lblIdPlanta;
		private System.Windows.Forms.Label lblPlanta;
		private System.Windows.Forms.TextBox txtNivel;
		private System.Windows.Forms.Label lblIdConcretera;
		private System.Windows.Forms.ComboBox cmbConcretera;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPlanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsPlanta dsPlanta1;
        private LancNeo.dsConcretera dsConcretera1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Planta()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planta));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.lblIdPlanta = new System.Windows.Forms.Label();
            this.lblPlanta = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblIdConcretera = new System.Windows.Forms.Label();
            this.sqlDAPlanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
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
            this.panel2.Controls.Add(this.cmbConcretera);
            this.panel2.Controls.Add(this.txtIdNivel);
            this.panel2.Controls.Add(this.lblIdPlanta);
            this.panel2.Controls.Add(this.lblPlanta);
            this.panel2.Controls.Add(this.txtNivel);
            this.panel2.Controls.Add(this.lblIdConcretera);
            this.panel2.Location = new System.Drawing.Point(48, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 192);
            this.panel2.TabIndex = 6;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsPlanta1.Planta;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(224, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 3;
            // 
            // dsPlanta1
            // 
            this.dsPlanta1.DataSetName = "dsPlanta";
            this.dsPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPlanta1, "Planta.IdConcretera", true));
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "Concretera";
            this.cmbConcretera.Location = new System.Drawing.Point(120, 128);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(304, 21);
            this.cmbConcretera.TabIndex = 2;
            this.cmbConcretera.ValueMember = "IdConcretera";
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlanta1, "Planta.IdPlanta", true));
            this.txtIdNivel.Location = new System.Drawing.Point(119, 46);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(100, 20);
            this.txtIdNivel.TabIndex = 1;
            this.txtIdNivel.Text = "textBox1";
            // 
            // lblIdPlanta
            // 
            this.lblIdPlanta.Location = new System.Drawing.Point(31, 42);
            this.lblIdPlanta.Name = "lblIdPlanta";
            this.lblIdPlanta.Size = new System.Drawing.Size(80, 23);
            this.lblIdPlanta.TabIndex = 0;
            this.lblIdPlanta.Text = "Id Planta:";
            this.lblIdPlanta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPlanta
            // 
            this.lblPlanta.Location = new System.Drawing.Point(31, 82);
            this.lblPlanta.Name = "lblPlanta";
            this.lblPlanta.Size = new System.Drawing.Size(80, 23);
            this.lblPlanta.TabIndex = 0;
            this.lblPlanta.Text = "Planta:";
            this.lblPlanta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtNivel
            // 
            this.txtNivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlanta1, "Planta.Planta", true));
            this.txtNivel.Location = new System.Drawing.Point(119, 86);
            this.txtNivel.MaxLength = 50;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(97, 20);
            this.txtNivel.TabIndex = 1;
            this.txtNivel.Text = "textBox1";
            // 
            // lblIdConcretera
            // 
            this.lblIdConcretera.Location = new System.Drawing.Point(31, 120);
            this.lblIdConcretera.Name = "lblIdConcretera";
            this.lblIdConcretera.Size = new System.Drawing.Size(80, 23);
            this.lblIdConcretera.TabIndex = 0;
            this.lblIdConcretera.Text = "Id Concretera:";
            this.lblIdConcretera.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // sqlDAPlanta
            // 
            this.sqlDAPlanta.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAPlanta.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAPlanta.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAPlanta.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Planta", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("Planta", "Planta"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera")})});
            this.sqlDAPlanta.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Planta WHERE (IdConcretera = @Original_IdConcretera) AND (IdPlanta = " +
                "@Original_IdPlanta) AND (Planta = @Original_Planta OR @Original_Planta IS NULL A" +
                "ND Planta IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdConcretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPlanta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Planta", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Planta", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.Int, 4, "IdPlanta"),
            new System.Data.SqlClient.SqlParameter("@Planta", System.Data.SqlDbType.NVarChar, 50, "Planta"),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdPlanta, Planta, IdConcretera FROM Planta ORDER BY IdPlanta";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.Int, 4, "IdPlanta"),
            new System.Data.SqlClient.SqlParameter("@Planta", System.Data.SqlDbType.NVarChar, 50, "Planta"),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPlanta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Planta", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Planta", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera ORDER BY Concretera";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // Planta
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAPlanta;
            this.dsGeneral = this.dsPlanta1;
            this.Name = "Planta";
            this.NombreTabla = "Planta";
            this.Text = "Planta";
            this.Load += new System.EventHandler(this.Planta_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Planta_Load(object sender, System.EventArgs e)
		{
			LlenaConcretera();
			this.buscaBtn1.Catalogo = this;
		}
		private void LlenaConcretera()
		{

			sqlDAConcretera.Fill(dsConcretera1, "Concretera");

		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbConcretera.SelectedIndex = -1;
		}
	}
}
