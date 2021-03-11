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
	/// Descripción breve de Zona.
	/// </summary>
	public class Zona : CatalogoGenerico 
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAZona;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsZona dsZona1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblIdZona;
		private System.Windows.Forms.Label lblZona;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdLocal;
		private System.Windows.Forms.RadioButton rdForanea;
		private System.Windows.Forms.TextBox txtIdZona;
		private System.Windows.Forms.TextBox txtZona;
		private System.Windows.Forms.TextBox txtUbicacion;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Zona()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zona));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAZona = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsZona1 = new LancNeo.dsZona();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLocal = new System.Windows.Forms.RadioButton();
            this.rdForanea = new System.Windows.Forms.RadioButton();
            this.txtIdZona = new System.Windows.Forms.TextBox();
            this.lblIdZona = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsZona1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // sqlDAZona
            // 
            this.sqlDAZona.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAZona.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAZona.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAZona.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Zona", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona"),
                        new System.Data.Common.DataColumnMapping("Ubicación", "Ubicación")})});
            this.sqlDAZona.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicación", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicación", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Zona", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Zona", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Zona(IdZona, Zona, Ubicación) VALUES (@IdZona, @Zona, @Ubicación); SE" +
                "LECT IdZona, Zona, Ubicación FROM Zona WHERE (IdZona = @IdZona)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Zona", System.Data.SqlDbType.NVarChar, 50, "Zona"),
            new System.Data.SqlClient.SqlParameter("@Ubicación", System.Data.SqlDbType.Int, 4, "Ubicación")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdZona, Zona, Ubicación FROM Zona";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Zona", System.Data.SqlDbType.NVarChar, 50, "Zona"),
            new System.Data.SqlClient.SqlParameter("@Ubicación", System.Data.SqlDbType.Int, 4, "Ubicación"),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicación", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicación", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Zona", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Zona", System.Data.DataRowVersion.Original, null)});
            // 
            // dsZona1
            // 
            this.dsZona1.DataSetName = "dsZona";
            this.dsZona1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsZona1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.txtUbicacion);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtIdZona);
            this.panel1.Controls.Add(this.lblIdZona);
            this.panel1.Controls.Add(this.lblZona);
            this.panel1.Controls.Add(this.txtZona);
            this.panel1.Location = new System.Drawing.Point(68, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 248);
            this.panel1.TabIndex = 0;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = null;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(240, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsZona1, "Zona.Ubicación", true));
            this.txtUbicacion.Location = new System.Drawing.Point(168, 216);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(0, 20);
            this.txtUbicacion.TabIndex = 4;
            this.txtUbicacion.TextChanged += new System.EventHandler(this.txtUbicacion_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLocal);
            this.groupBox1.Controls.Add(this.rdForanea);
            this.groupBox1.Location = new System.Drawing.Point(104, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicación";
            // 
            // rdLocal
            // 
            this.rdLocal.Checked = true;
            this.rdLocal.Location = new System.Drawing.Point(58, 24);
            this.rdLocal.Name = "rdLocal";
            this.rdLocal.Size = new System.Drawing.Size(56, 24);
            this.rdLocal.TabIndex = 2;
            this.rdLocal.TabStop = true;
            this.rdLocal.Text = "Local";
            this.rdLocal.CheckedChanged += new System.EventHandler(this.rdLocal_CheckedChanged);
            // 
            // rdForanea
            // 
            this.rdForanea.Location = new System.Drawing.Point(134, 24);
            this.rdForanea.Name = "rdForanea";
            this.rdForanea.Size = new System.Drawing.Size(64, 24);
            this.rdForanea.TabIndex = 2;
            this.rdForanea.Text = "Foránea";
            this.rdForanea.CheckedChanged += new System.EventHandler(this.rdForanea_CheckedChanged);
            // 
            // txtIdZona
            // 
            this.txtIdZona.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsZona1, "Zona.IdZona", true));
            this.txtIdZona.Location = new System.Drawing.Point(168, 48);
            this.txtIdZona.MaxLength = 1;
            this.txtIdZona.Name = "txtIdZona";
            this.txtIdZona.Size = new System.Drawing.Size(64, 20);
            this.txtIdZona.TabIndex = 1;
            // 
            // lblIdZona
            // 
            this.lblIdZona.Location = new System.Drawing.Point(56, 48);
            this.lblIdZona.Name = "lblIdZona";
            this.lblIdZona.Size = new System.Drawing.Size(100, 23);
            this.lblIdZona.TabIndex = 0;
            this.lblIdZona.Text = "Id Zona:";
            this.lblIdZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZona
            // 
            this.lblZona.Location = new System.Drawing.Point(56, 88);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(100, 23);
            this.lblZona.TabIndex = 0;
            this.lblZona.Text = "Zona:";
            this.lblZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtZona
            // 
            this.txtZona.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsZona1, "Zona.Zona", true));
            this.txtZona.Location = new System.Drawing.Point(168, 96);
            this.txtZona.MaxLength = 50;
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(192, 20);
            this.txtZona.TabIndex = 1;
            // 
            // Zona
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDAZona;
            this.dsGeneral = this.dsZona1;
            this.Name = "Zona";
            this.NombreTabla = "Zona";
            this.Text = "Zona";
            this.Load += new System.EventHandler(this.Zona_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsZona1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void rdLocal_CheckedChanged(object sender, System.EventArgs e)
		{
			txtUbicacion.Text = "1";
		}

		private void rdForanea_CheckedChanged(object sender, System.EventArgs e)
		{
			txtUbicacion.Text = "2";
		}

		private void txtUbicacion_TextChanged(object sender, System.EventArgs e)
		{
			if(txtUbicacion.Text == "1")
			{
				rdForanea.Checked = false;
				rdLocal.Checked = true;
			}
			else
			{
				rdLocal.Checked = false;
				rdForanea.Checked = true;				
			}
		}

		private void Zona_Load(object sender, System.EventArgs e)
		{
			LlenaVistaPrevia();
			this.buscaBtn1.Catalogo = this;
		}
		private void LlenaVistaPrevia()
		{
			DataSet dsVista = new DataSet();
			String strSql = " SELECT IdZona, Zona, Case When Ubicación = 1 Then 'Local' Else 'Foránea' End As Ubicación FROM Zona ";
			SqlDataAdapter sqlDAVP = new SqlDataAdapter(strSql, sqlConn);
			sqlDAVP.Fill(dsVista,"Zona");
			this.dsVistaPrevia = dsVista;
			this.buscaBtn1.Datos = dsVista.Tables[0];

		}

	}
}
