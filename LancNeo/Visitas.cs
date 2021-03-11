using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Visitas.
	/// </summary>
	public class Visitas : System.Windows.Forms.Form
	{
		private LancNeo.dsDGObra dsDGObra1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusEspecimen;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsBusEspMues dsBusEspMues1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisitas;
		private System.Data.SqlClient.SqlDataAdapter sqlDAServiciosR;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private LancNeo.dsServiciosR dsServiciosR1;
		private LancNeo.CryRepVisitas cryRepVisitas1;
		public System.Data.SqlClient.SqlDataAdapter sqlDAPresupuestoz;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private CheckBox cbkMortero;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Visitas()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visitas));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.dsDGObra1 = new LancNeo.dsDGObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusEspMues1 = new LancNeo.dsBusEspMues();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDABusEspecimen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.crvVisitas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAServiciosR = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsServiciosR1 = new LancNeo.dsServiciosR();
            this.cryRepVisitas1 = new LancNeo.CryRepVisitas();
            this.sqlDAPresupuestoz = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.cbkMortero = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEspMues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServiciosR1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsDGObra1
            // 
            this.dsDGObra1.DataSetName = "dsDGObra";
            this.dsDGObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDGObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDABusObra
            // 
            this.sqlDABusObra.SelectCommand = this.sqlCommand1;
            this.sqlDABusObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.cbkMortero);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 76);
            this.panel1.TabIndex = 12;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 650;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusEspMues1.Especimen;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(328, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsBusEspMues1
            // 
            this.dsBusEspMues1.DataSetName = "dsBusEspMues";
            this.dsBusEspMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusEspMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(730, 0);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(398, 34);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 36;
            this.cbkPrefijo.Text = "No prefijo";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(634, 36);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(634, 4);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsDGObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(240, 8);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios realizados";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(506, 20);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(330, 25);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // sqlDABusEspecimen
            // 
            this.sqlDABusEspecimen.SelectCommand = this.sqlSelectCommand3;
            this.sqlDABusEspecimen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Especimen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("tipo", "tipo")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // crvVisitas
            // 
            this.crvVisitas.ActiveViewIndex = -1;
            this.crvVisitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisitas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisitas.EnableRefresh = false;
            this.crvVisitas.Location = new System.Drawing.Point(0, 76);
            this.crvVisitas.Name = "crvVisitas";
            this.crvVisitas.ShowCloseButton = false;
           this.crvVisitas.ShowGroupTreeButton = false;
            this.crvVisitas.ShowLogo = false;
            this.crvVisitas.Size = new System.Drawing.Size(816, 465);
            this.crvVisitas.TabIndex = 13;
            this.crvVisitas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlDAServiciosR
            // 
            this.sqlDAServiciosR.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAServiciosR.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ServiciosRealizados", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObras", "IdObras"),
                        new System.Data.Common.DataColumnMapping("VisitasS", "VisitasS"),
                        new System.Data.Common.DataColumnMapping("VisitasAdS", "VisitasAdS"),
                        new System.Data.Common.DataColumnMapping("VisitasTTS", "VisitasTTS"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("mess", "mess"),
                        new System.Data.Common.DataColumnMapping("anos", "anos"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Diarias", "Diarias"),
                        new System.Data.Common.DataColumnMapping("Semanal", "Semanal"),
                        new System.Data.Common.DataColumnMapping("Mensual", "Mensual")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[ServiciosRealizados]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.Bit, 1)});
            // 
            // dsServiciosR1
            // 
            this.dsServiciosR1.DataSetName = "dsServiciosR";
            this.dsServiciosR1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsServiciosR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAPresupuestoz
            // 
            this.sqlDAPresupuestoz.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAPresupuestoz.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("PresupuestoZ", "PresupuestoZ"),
                        new System.Data.Common.DataColumnMapping("Duracion", "Duracion")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT Idobra, PresupuestoZ, Duracion FROM Obra WHERE (Idobra = @IdObra)";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // cbkMortero
            // 
            this.cbkMortero.Checked = true;
            this.cbkMortero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkMortero.Location = new System.Drawing.Point(398, 2);
            this.cbkMortero.Name = "cbkMortero";
            this.cbkMortero.Size = new System.Drawing.Size(102, 24);
            this.cbkMortero.TabIndex = 53;
            this.cbkMortero.Text = "Incluye mortero";
            // 
            // Visitas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(816, 541);
            this.Controls.Add(this.crvVisitas);
            this.Controls.Add(this.panel1);
            this.Name = "Visitas";
            this.Text = "Visitas de laboratoristas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Visitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEspMues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServiciosR1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Visitas_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsDGObra1, "Obra");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsBusEspMues1.Clear();
			//			crvRepMuestreador.Visible = false;
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			sqlDABusEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDABusEspecimen.Fill(dsBusEspMues1, "Especimen");
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			crvVisitas.Visible = true;
            cryRepVisitas1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cryRepVisitas1.SetDataSource(dsServiciosR1);
			dsServiciosR1.Clear();
			sqlDAServiciosR.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim() + (cbkPrefijo.Checked  ? "" : "%");
			sqlDAServiciosR.SelectCommand.Parameters["@FIni"].Value = dtpIni.Text;
			sqlDAServiciosR.SelectCommand.Parameters["@FFin"].Value = dtpFin.Text;
            sqlDAServiciosR.SelectCommand.Parameters["@Mortero"].Value = cbkMortero.Checked;
            sqlDAServiciosR.Fill(dsServiciosR1, "ServiciosRealizados");
			sqlDAPresupuestoz.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text.Trim();
			sqlDAPresupuestoz.Fill(dsServiciosR1, "Obra");


			cryRepVisitas1.SetParameterValue("@Cons", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][3].ToString());
			cryRepVisitas1.SetParameterValue("@Ubica", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][1].ToString());
			cryRepVisitas1.SetParameterValue("@Col", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][4].ToString());
			cryRepVisitas1.SetParameterValue("@Zona", dsDGObra1.Tables[0].Rows[cmbIdObra.SelectedIndex][5].ToString());

			
			crvVisitas.ReportSource = cryRepVisitas1;
			//crvVisitas.RefreshReport();
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			if(dsBusEspMues1.Tables["Especimen"].Rows.Count > 0)
			{
				dtpIni.Text = dsBusEspMues1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
				btnVistaPrevia.Visible = true;
			}
			else
			{
				btnVistaPrevia.Visible = false;
			}
		}
	}
}
