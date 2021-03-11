using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Ensaye.
	/// </summary>
	public class Ensaye : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblIdEnsaye;
		private System.Windows.Forms.Label lblEnsaye;
		private System.Data.SqlClient.SqlDataAdapter sqlDAEnsaye;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsEnsaye dsEnsaye1;
		private System.Windows.Forms.TextBox txtIdEnsaye;
		private System.Windows.Forms.TextBox txtEnsaye;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Ensaye()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ensaye));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsEnsaye1 = new LancNeo.dsEnsaye();
            this.txtIdEnsaye = new System.Windows.Forms.TextBox();
            this.lblIdEnsaye = new System.Windows.Forms.Label();
            this.lblEnsaye = new System.Windows.Forms.Label();
            this.txtEnsaye = new System.Windows.Forms.TextBox();
            this.sqlDAEnsaye = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnsaye1)).BeginInit();
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
            this.panel1.Controls.Add(this.txtIdEnsaye);
            this.panel1.Controls.Add(this.lblIdEnsaye);
            this.panel1.Controls.Add(this.lblEnsaye);
            this.panel1.Controls.Add(this.txtEnsaye);
            this.panel1.Location = new System.Drawing.Point(88, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 205);
            this.panel1.TabIndex = 3;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsEnsaye1.Ensaye;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(296, 40);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsEnsaye1
            // 
            this.dsEnsaye1.DataSetName = "dsEnsaye";
            this.dsEnsaye1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsEnsaye1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdEnsaye
            // 
            this.txtIdEnsaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEnsaye1, "Ensaye.IdEnsaye", true));
            this.txtIdEnsaye.Location = new System.Drawing.Point(192, 75);
            this.txtIdEnsaye.Name = "txtIdEnsaye";
            this.txtIdEnsaye.Size = new System.Drawing.Size(100, 20);
            this.txtIdEnsaye.TabIndex = 1;
            this.txtIdEnsaye.Text = "textBox1";
            // 
            // lblIdEnsaye
            // 
            this.lblIdEnsaye.Location = new System.Drawing.Point(80, 75);
            this.lblIdEnsaye.Name = "lblIdEnsaye";
            this.lblIdEnsaye.Size = new System.Drawing.Size(100, 23);
            this.lblIdEnsaye.TabIndex = 0;
            this.lblIdEnsaye.Text = "Id Ensaye:";
            this.lblIdEnsaye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnsaye
            // 
            this.lblEnsaye.Location = new System.Drawing.Point(80, 107);
            this.lblEnsaye.Name = "lblEnsaye";
            this.lblEnsaye.Size = new System.Drawing.Size(100, 23);
            this.lblEnsaye.TabIndex = 0;
            this.lblEnsaye.Text = "Ensaye:";
            this.lblEnsaye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEnsaye
            // 
            this.txtEnsaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEnsaye1, "Ensaye.Ensaye", true));
            this.txtEnsaye.Location = new System.Drawing.Point(192, 107);
            this.txtEnsaye.Name = "txtEnsaye";
            this.txtEnsaye.Size = new System.Drawing.Size(100, 20);
            this.txtEnsaye.TabIndex = 1;
            this.txtEnsaye.Text = "textBox1";
            // 
            // sqlDAEnsaye
            // 
            this.sqlDAEnsaye.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAEnsaye.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAEnsaye.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAEnsaye.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Ensaye", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdEnsaye", "IdEnsaye"),
                        new System.Data.Common.DataColumnMapping("Ensaye", "Ensaye")})});
            this.sqlDAEnsaye.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Ensaye WHERE (IdEnsaye = @Original_IdEnsaye) AND (Ensaye = @Original_" +
                "Ensaye OR @Original_Ensaye IS NULL AND Ensaye IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdEnsaye", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ensaye", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ensaye", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Ensaye(IdEnsaye, Ensaye) VALUES (@IdEnsaye, @Ensaye); SELECT IdEnsaye" +
                ", Ensaye FROM Ensaye WHERE (IdEnsaye = @IdEnsaye)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdEnsaye", System.Data.SqlDbType.NVarChar, 2, "IdEnsaye"),
            new System.Data.SqlClient.SqlParameter("@Ensaye", System.Data.SqlDbType.NVarChar, 50, "Ensaye")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdEnsaye, Ensaye FROM Ensaye";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdEnsaye", System.Data.SqlDbType.NVarChar, 2, "IdEnsaye"),
            new System.Data.SqlClient.SqlParameter("@Ensaye", System.Data.SqlDbType.NVarChar, 50, "Ensaye"),
            new System.Data.SqlClient.SqlParameter("@Original_IdEnsaye", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ensaye", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ensaye", System.Data.DataRowVersion.Original, null)});
            // 
            // Ensaye
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDAEnsaye;
            this.dsGeneral = this.dsEnsaye1;
            this.Name = "Ensaye";
            this.NombreTabla = "Ensaye";
            this.Text = "Ensaye";
            this.Load += new System.EventHandler(this.Ensaye_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnsaye1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Ensaye_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}

		
	}
}
