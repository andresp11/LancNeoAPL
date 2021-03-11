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
	/// Descripción breve de Resistencia.
	/// </summary>
	public class Resistencia : CatalogoGenerico 
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblResistenciaKg;
		private System.Windows.Forms.Label lblResistenciaMPa;
		private System.Windows.Forms.TextBox txtResKg;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAResistencia;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsResistencia dsResistencia1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.ComboBox cmbMezcla;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Resistencia()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			ArrayList Mezcla =new ArrayList();
			Mezcla.Add(new matCombo("Concreto",1));
			Mezcla.Add(new matCombo("Mortero",2));
			cmbMezcla.DataSource = Mezcla; //DataSource for lookup table 
			cmbMezcla.DisplayMember = "getName"; //Display value in lookup table
			cmbMezcla.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}
		protected struct matCombo
		{
			private string Descripcion;
			private float Identificador;
			public matCombo(string Nombre , float id)
			{
				Descripcion=Nombre;
				Identificador = id;
			}
			public string getName
			{
				get
				{
					return Descripcion;
				}
			}
			public float getId
			{
				get
				{
					return Identificador;
				}
			}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resistencia));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsResistencia1 = new LancNeo.dsResistencia();
            this.cmbMezcla = new System.Windows.Forms.ComboBox();
            this.txtResKg = new System.Windows.Forms.TextBox();
            this.lblResistenciaKg = new System.Windows.Forms.Label();
            this.lblResistenciaMPa = new System.Windows.Forms.Label();
            this.sqlDAResistencia = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsResistencia1)).BeginInit();
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
            this.panel1.Controls.Add(this.cmbMezcla);
            this.panel1.Controls.Add(this.txtResKg);
            this.panel1.Controls.Add(this.lblResistenciaKg);
            this.panel1.Controls.Add(this.lblResistenciaMPa);
            this.panel1.Location = new System.Drawing.Point(110, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 200);
            this.panel1.TabIndex = 0;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsResistencia1.Resistencia;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(268, 32);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsResistencia1
            // 
            this.dsResistencia1.DataSetName = "dsResistencia";
            this.dsResistencia1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsResistencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMezcla
            // 
            this.cmbMezcla.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsResistencia1, "Resistencia.ResistenciaMPa", true));
            this.cmbMezcla.Location = new System.Drawing.Point(168, 104);
            this.cmbMezcla.Name = "cmbMezcla";
            this.cmbMezcla.Size = new System.Drawing.Size(96, 21);
            this.cmbMezcla.TabIndex = 3;
            this.cmbMezcla.Text = "cmbMezcla";
            // 
            // txtResKg
            // 
            this.txtResKg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsResistencia1, "Resistencia.ResistenciaKG", true));
            this.txtResKg.Location = new System.Drawing.Point(164, 64);
            this.txtResKg.Name = "txtResKg";
            this.txtResKg.Size = new System.Drawing.Size(100, 20);
            this.txtResKg.TabIndex = 1;
            this.txtResKg.Text = "textBox1";
            // 
            // lblResistenciaKg
            // 
            this.lblResistenciaKg.Location = new System.Drawing.Point(20, 64);
            this.lblResistenciaKg.Name = "lblResistenciaKg";
            this.lblResistenciaKg.Size = new System.Drawing.Size(136, 23);
            this.lblResistenciaKg.TabIndex = 0;
            this.lblResistenciaKg.Text = "Resistencia en Kg/cm ²:";
            this.lblResistenciaKg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResistenciaMPa
            // 
            this.lblResistenciaMPa.Location = new System.Drawing.Point(20, 103);
            this.lblResistenciaMPa.Name = "lblResistenciaMPa";
            this.lblResistenciaMPa.Size = new System.Drawing.Size(136, 23);
            this.lblResistenciaMPa.TabIndex = 0;
            this.lblResistenciaMPa.Text = "Mezcla:";
            this.lblResistenciaMPa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAResistencia
            // 
            this.sqlDAResistencia.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAResistencia.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAResistencia.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAResistencia.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Resistencia", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("ResistenciaMPa", "ResistenciaMPa")})});
            this.sqlDAResistencia.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Resistencia WHERE (ResistenciaKG = @Original_ResistenciaKG) AND (Resi" +
                "stenciaMPa = @Original_ResistenciaMPa OR @Original_ResistenciaMPa IS NULL AND Re" +
                "sistenciaMPa IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKG", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaKG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaMPa", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaMPa", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Resistencia(ResistenciaKG, ResistenciaMPa) VALUES (@ResistenciaKG, @R" +
                "esistenciaMPa); SELECT ResistenciaKG, ResistenciaMPa FROM Resistencia WHERE (Res" +
                "istenciaKG = @ResistenciaKG)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 4, "ResistenciaKG"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaMPa", System.Data.SqlDbType.Real, 4, "ResistenciaMPa")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT ResistenciaKG, ResistenciaMPa FROM Resistencia";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 4, "ResistenciaKG"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaMPa", System.Data.SqlDbType.Real, 4, "ResistenciaMPa"),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKG", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaKG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaMPa", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaMPa", System.Data.DataRowVersion.Original, null)});
            // 
            // Resistencia
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDAResistencia;
            this.dsGeneral = this.dsResistencia1;
            this.Name = "Resistencia";
            this.NombreTabla = "Resistencia";
            this.Text = "Catálogo de Resistencias";
            this.Load += new System.EventHandler(this.Resistencia_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsResistencia1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Resistencia_Load(object sender, System.EventArgs e)
		{
			LlenaVistaPrevia();
			this.buscaBtn1.Catalogo = this;
		}
		private void LlenaVistaPrevia()
		{
			DataSet dsVista = new DataSet();
			String strSql = " SELECT ResistenciaKG, CASE ResistenciaMPa WHEN 1 THEN 'Concreto' WHEN 2 THEN 'Mortero' END AS Mezcla FROM Resistencia R";
			SqlDataAdapter sqlDAVP = new SqlDataAdapter(strSql, sqlConn);
			sqlDAVP.Fill(dsVista,"Resistencia");
			this.dsVistaPrevia = dsVista;
		}

	}
}
