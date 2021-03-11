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
	/// Descripción breve de Laboratorista.
	/// </summary>
	public class Laboratorista : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private LancNeo.dsLaboratorista dsLaboratorista1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNoEco;
		private System.Windows.Forms.Label lblLaboratorista;
		private System.Windows.Forms.Label lblZona;
		private System.Windows.Forms.Label lblNivel;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.ComboBox cmbZona;
		private System.Windows.Forms.TextBox txtNoEco;
		private System.Windows.Forms.TextBox txtLaboratorista;
		private System.Windows.Forms.ComboBox cmbNivel;
		private LancNeo.dsZona dsZona1;
		private LancNeo.dsNivel dsNivel1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAZona;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private System.Data.SqlClient.SqlCommand sqlCommand4;
		private System.Data.SqlClient.SqlDataAdapter sqlDANivel;
		private System.Data.SqlClient.SqlCommand sqlCommand5;
		private System.Data.SqlClient.SqlCommand sqlCommand6;
		private System.Data.SqlClient.SqlCommand sqlCommand7;
		private System.Data.SqlClient.SqlCommand sqlCommand8;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusq;
		private System.Data.SqlClient.SqlCommand sqlCommand11;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Laboratorista()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratorista));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.dsZona1 = new LancNeo.dsZona();
            this.txtNoEco = new System.Windows.Forms.TextBox();
            this.lblNoEco = new System.Windows.Forms.Label();
            this.lblLaboratorista = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtLaboratorista = new System.Windows.Forms.TextBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.dsNivel1 = new LancNeo.dsNivel();
            this.sqlDAZona = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDANivel = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusq = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand11 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsZona1)).BeginInit();
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
            // sqlDALaboratorista
            // 
            this.sqlDALaboratorista.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDALaboratorista.InsertCommand = this.sqlInsertCommand1;
            this.sqlDALaboratorista.SelectCommand = this.sqlSelectCommand1;
            this.sqlDALaboratorista.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorista", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("IdNivel", "IdNivel"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai")})});
            this.sqlDALaboratorista.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fechai", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fechai", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdNivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdNivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Laboratorista", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Laboratorista", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Laboratorista", System.Data.SqlDbType.NVarChar, 50, "Laboratorista"),
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@IdNivel", System.Data.SqlDbType.SmallInt, 2, "IdNivel"),
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.DateTime, 8, "Fechai")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT NoEco, Laboratorista, IdZona, IdNivel, Fechai FROM Laboratorista ORDER BY " +
                "NoEco";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Laboratorista", System.Data.SqlDbType.NVarChar, 50, "Laboratorista"),
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@IdNivel", System.Data.SqlDbType.SmallInt, 2, "IdNivel"),
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.DateTime, 8, "Fechai"),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fechai", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fechai", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdNivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdNivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Laboratorista", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Laboratorista", System.Data.DataRowVersion.Original, null)});
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.cmbZona);
            this.panel1.Controls.Add(this.txtNoEco);
            this.panel1.Controls.Add(this.lblNoEco);
            this.panel1.Controls.Add(this.lblLaboratorista);
            this.panel1.Controls.Add(this.lblZona);
            this.panel1.Controls.Add(this.lblNivel);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.txtLaboratorista);
            this.panel1.Controls.Add(this.cmbNivel);
            this.panel1.Location = new System.Drawing.Point(80, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 256);
            this.panel1.TabIndex = 0;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsLaboratorista1.Laboratorista;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(248, 8);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dtpFecha
            // 
            this.dtpFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLaboratorista1, "Laboratorista.Fechai", true));
            this.dtpFecha.Location = new System.Drawing.Point(144, 192);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2004, 7, 7, 0, 0, 0, 0);
            // 
            // cmbZona
            // 
            this.cmbZona.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsLaboratorista1, "Laboratorista.IdZona", true));
            this.cmbZona.DataSource = this.dsZona1.Zona;
            this.cmbZona.DisplayMember = "Zona";
            this.cmbZona.Location = new System.Drawing.Point(144, 112);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(256, 21);
            this.cmbZona.TabIndex = 2;
            this.cmbZona.ValueMember = "IdZona";
            // 
            // dsZona1
            // 
            this.dsZona1.DataSetName = "dsZona";
            this.dsZona1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsZona1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNoEco
            // 
            this.txtNoEco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLaboratorista1, "Laboratorista.NoEco", true));
            this.txtNoEco.Location = new System.Drawing.Point(144, 32);
            this.txtNoEco.Name = "txtNoEco";
            this.txtNoEco.Size = new System.Drawing.Size(100, 20);
            this.txtNoEco.TabIndex = 1;
            this.txtNoEco.Text = "textBox1";
            // 
            // lblNoEco
            // 
            this.lblNoEco.Location = new System.Drawing.Point(8, 32);
            this.lblNoEco.Name = "lblNoEco";
            this.lblNoEco.Size = new System.Drawing.Size(112, 23);
            this.lblNoEco.TabIndex = 0;
            this.lblNoEco.Text = "Número económico:";
            this.lblNoEco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLaboratorista
            // 
            this.lblLaboratorista.Location = new System.Drawing.Point(8, 72);
            this.lblLaboratorista.Name = "lblLaboratorista";
            this.lblLaboratorista.Size = new System.Drawing.Size(112, 23);
            this.lblLaboratorista.TabIndex = 0;
            this.lblLaboratorista.Text = "Laboratorista:";
            this.lblLaboratorista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZona
            // 
            this.lblZona.Location = new System.Drawing.Point(8, 112);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(112, 23);
            this.lblZona.TabIndex = 0;
            this.lblZona.Text = "Zona";
            this.lblZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNivel
            // 
            this.lblNivel.Location = new System.Drawing.Point(8, 152);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(112, 23);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(8, 192);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(112, 23);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha de Ingreso:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLaboratorista
            // 
            this.txtLaboratorista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLaboratorista1, "Laboratorista.Laboratorista", true));
            this.txtLaboratorista.Location = new System.Drawing.Point(144, 72);
            this.txtLaboratorista.Name = "txtLaboratorista";
            this.txtLaboratorista.Size = new System.Drawing.Size(256, 20);
            this.txtLaboratorista.TabIndex = 1;
            this.txtLaboratorista.Text = "textBox1";
            // 
            // cmbNivel
            // 
            this.cmbNivel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsLaboratorista1, "Laboratorista.IdNivel", true));
            this.cmbNivel.DataSource = this.dsNivel1.Nivel;
            this.cmbNivel.DisplayMember = "Nivel";
            this.cmbNivel.Location = new System.Drawing.Point(144, 152);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 2;
            this.cmbNivel.ValueMember = "IdNivel";
            // 
            // dsNivel1
            // 
            this.dsNivel1.DataSetName = "dsNivel";
            this.dsNivel1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsNivel1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAZona
            // 
            this.sqlDAZona.DeleteCommand = this.sqlCommand1;
            this.sqlDAZona.InsertCommand = this.sqlCommand2;
            this.sqlDAZona.SelectCommand = this.sqlCommand3;
            this.sqlDAZona.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Zona", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona"),
                        new System.Data.Common.DataColumnMapping("Ubicación", "Ubicación")})});
            this.sqlDAZona.UpdateCommand = this.sqlCommand4;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicación", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicación", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Zona", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Zona", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "INSERT INTO Zona(IdZona, Zona, Ubicación) VALUES (@IdZona, @Zona, @Ubicación); SE" +
                "LECT IdZona, Zona, Ubicación FROM Zona WHERE (IdZona = @IdZona)";
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Zona", System.Data.SqlDbType.NVarChar, 50, "Zona"),
            new System.Data.SqlClient.SqlParameter("@Ubicación", System.Data.SqlDbType.Int, 4, "Ubicación")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT IdZona, Zona, Ubicación FROM Zona";
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Zona", System.Data.SqlDbType.NVarChar, 50, "Zona"),
            new System.Data.SqlClient.SqlParameter("@Ubicación", System.Data.SqlDbType.Int, 4, "Ubicación"),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicación", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicación", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Zona", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Zona", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDANivel
            // 
            this.sqlDANivel.DeleteCommand = this.sqlCommand5;
            this.sqlDANivel.InsertCommand = this.sqlCommand6;
            this.sqlDANivel.SelectCommand = this.sqlCommand7;
            this.sqlDANivel.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Nivel", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdNivel", "IdNivel"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel")})});
            this.sqlDANivel.UpdateCommand = this.sqlCommand8;
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "DELETE FROM Nivel WHERE (IdNivel = @Original_IdNivel) AND (Nivel = @Original_Nive" +
                "l OR @Original_Nivel IS NULL AND Nivel IS NULL)";
            this.sqlCommand5.Connection = this.sqlConn;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdNivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdNivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = "INSERT INTO Nivel(IdNivel, Nivel) VALUES (@IdNivel, @Nivel); SELECT IdNivel, Nive" +
                "l FROM Nivel WHERE (IdNivel = @IdNivel) ORDER BY IdNivel";
            this.sqlCommand6.Connection = this.sqlConn;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNivel", System.Data.SqlDbType.SmallInt, 2, "IdNivel"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 50, "Nivel")});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = "SELECT IdNivel, Nivel FROM Nivel ORDER BY IdNivel";
            this.sqlCommand7.Connection = this.sqlConn;
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = resources.GetString("sqlCommand8.CommandText");
            this.sqlCommand8.Connection = this.sqlConn;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNivel", System.Data.SqlDbType.SmallInt, 2, "IdNivel"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 50, "Nivel"),
            new System.Data.SqlClient.SqlParameter("@Original_IdNivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdNivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDABusq
            // 
            this.sqlDABusq.SelectCommand = this.sqlCommand11;
            this.sqlDABusq.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorista", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("IdNivel", "IdNivel"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai")})});
            // 
            // sqlCommand11
            // 
            this.sqlCommand11.CommandText = resources.GetString("sqlCommand11.CommandText");
            this.sqlCommand11.Connection = this.sqlConn;
            // 
            // Laboratorista
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDALaboratorista;
            this.dsGeneral = this.dsLaboratorista1;
            this.Name = "Laboratorista";
            this.NombreTabla = "Laboratorista";
            this.Text = "Laboratorista";
            this.Load += new System.EventHandler(this.Laboratorista_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsZona1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNivel1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion



		private void Laboratorista_Load(object sender, System.EventArgs e)
		{			
			LlenaZona();
			LlenaNivel();
			this.buscaBtn1.Catalogo = this;
			EstableceVistaPrevia();
		}
		private void LlenaZona()
		{
			sqlDAZona.Fill(dsZona1,"Zona");
		}
		private void LlenaNivel()
		{
			sqlDANivel.Fill(dsNivel1, "Nivel");
		}

		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbZona.SelectedIndex = -1;
			cmbNivel.SelectedIndex = -1;
		}
		private void EstableceVistaPrevia()
		{
			DataSet dsVP = new DataSet();
			sqlDABusq.Fill(dsVP, "Laboratorista");
			dsVistaPrevia = dsVP;
		}
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			base.btnGuardar_Click(sender,e);
			EstableceVistaPrevia();
		}
	}
}
