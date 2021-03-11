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
	/// Descripción breve de RepMuestreador.
	/// </summary>
	public class RepMuestreador : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtFecha;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusMuestreador;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsBusMuestreador dsBusMuestreador1;
		private System.Data.SqlClient.SqlDataAdapter sqlDARepMuestreador;
		private LancNeo.dsRepMuestreador dsRepMuestreador1;
		private LancNeo.CryRepMuestreador cryRepMuestreador1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Windows.Forms.Panel panel1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepMuestreador;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsBusObra dsBusObra1;
        private CheckBox chbLab1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RepMuestreador()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepMuestreador));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.label1 = new System.Windows.Forms.Label();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusMuestreador1 = new LancNeo.dsBusMuestreador();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.sqlDABusMuestreador = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDARepMuestreador = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsRepMuestreador1 = new LancNeo.dsRepMuestreador();
            this.cryRepMuestreador1 = new LancNeo.CryRepMuestreador();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbLab1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.crvRepMuestreador = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMuestreador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepMuestreador1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de Muestreador";
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusMuestreador1.Muestreador;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(448, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 1;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsBusMuestreador1
            // 
            this.dsBusMuestreador1.DataSetName = "dsBusMuestreador";
            this.dsBusMuestreador1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusMuestreador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(464, 16);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(520, 16);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(40, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(560, 16);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(80, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(646, 0);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 6;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // sqlDABusMuestreador
            // 
            this.sqlDABusMuestreador.SelectCommand = this.sqlSelectCommand1;
            this.sqlDABusMuestreador.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestreador", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdObra, Fecha FROM Muestreador WHERE (IdObra = @IdObra) ORDER BY IdObra";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDARepMuestreador
            // 
            this.sqlDARepMuestreador.SelectCommand = this.sqlSelectCommand2;
            this.sqlDARepMuestreador.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RepMuestreado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona"),
                        new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hinicio", "Hinicio"),
                        new System.Data.Common.DataColumnMapping("Hfinal", "Hfinal"),
                        new System.Data.Common.DataColumnMapping("Vsolicitado", "Vsolicitado"),
                        new System.Data.Common.DataColumnMapping("Textra", "Textra"),
                        new System.Data.Common.DataColumnMapping("Volumen", "Volumen"),
                        new System.Data.Common.DataColumnMapping("Nmuestras", "Nmuestras"),
                        new System.Data.Common.DataColumnMapping("Ncilindros", "Ncilindros"),
                        new System.Data.Common.DataColumnMapping("M1dv", "M1dv"),
                        new System.Data.Common.DataColumnMapping("M3dv", "M3dv"),
                        new System.Data.Common.DataColumnMapping("M3d", "M3d"),
                        new System.Data.Common.DataColumnMapping("M7d", "M7d"),
                        new System.Data.Common.DataColumnMapping("M14d", "M14d"),
                        new System.Data.Common.DataColumnMapping("M28d", "M28d"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("Fecham", "Fecham"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("tipo", "tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Agregado1", "Agregado1"),
                        new System.Data.Common.DataColumnMapping("IdRemision", "IdRemision"),
                        new System.Data.Common.DataColumnMapping("IdOlla", "IdOlla"),
                        new System.Data.Common.DataColumnMapping("Volumen1", "Volumen1"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("RevObt", "RevObt"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa")})});
            this.sqlDARepMuestreador.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(this.sqlDARepMuestreador_RowUpdated);
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "[RepMuestreado]";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8)});
            // 
            // dsRepMuestreador1
            // 
            this.dsRepMuestreador1.DataSetName = "dsRepMuestreador";
            this.dsRepMuestreador1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsRepMuestreador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.chbLab1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 56);
            this.panel1.TabIndex = 8;
            // 
            // chbLab1
            // 
            this.chbLab1.Checked = true;
            this.chbLab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab1.Location = new System.Drawing.Point(106, 34);
            this.chbLab1.Name = "chbLab1";
            this.chbLab1.Size = new System.Drawing.Size(133, 21);
            this.chbLab1.TabIndex = 41;
            this.chbLab1.Text = "Incluye laboratorista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsBusObra1, "Obra.Idobra", true));
            this.comboBox1.DataSource = this.dsBusObra1.Obra;
            this.comboBox1.DisplayMember = "IdObra";
            this.comboBox1.Location = new System.Drawing.Point(376, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "IdObra";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crvRepMuestreador
            // 
            this.crvRepMuestreador.ActiveViewIndex = -1;
            this.crvRepMuestreador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepMuestreador.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepMuestreador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepMuestreador.EnableRefresh = false;
            this.crvRepMuestreador.Location = new System.Drawing.Point(0, 56);
            this.crvRepMuestreador.Name = "crvRepMuestreador";
            this.crvRepMuestreador.ShowCloseButton = false;
            this.crvRepMuestreador.ShowGroupTreeButton = false;
            this.crvRepMuestreador.ShowLogo = false;
            this.crvRepMuestreador.Size = new System.Drawing.Size(880, 645);
            this.crvRepMuestreador.TabIndex = 9;
            this.crvRepMuestreador.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.sqlCommand1.CommandText = "SELECT Obra.Idobra, Obra.Ubicacion, Obra.RFC, Razonsocial.Facturar FROM Obra LEFT" +
                " OUTER JOIN Razonsocial ON Obra.IdCliente = Razonsocial.IdCliente AND Obra.RFC =" +
                " Razonsocial.RFC ORDER BY Obra.Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // RepMuestreador
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(880, 701);
            this.Controls.Add(this.crvRepMuestreador);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "RepMuestreador";
            this.Text = "RepMuestreador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepMuestreador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMuestreador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepMuestreador1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void RepMuestreador_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBusObra1, "Obra");
//			comboBox1.SelectedIndex = -1;
			//			this.buscaBtn1.Catalogo = this;
//			LlenasSqlDA();
		}
		private void LlenasSqlDA()
		{
			sqlDABusMuestreador.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
			sqlDABusMuestreador.Fill(dsBusMuestreador1, "Muestreador");
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
//			txtIdobra.Text = dsBusMuestreador1.Tables["Muestreador"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
			try
			{
				btnVistaPrevia.Visible = false;
				if (dsBusMuestreador1.Tables.Count >= 0)
				{
					txtFecha.Text  = dsBusMuestreador1.Tables["Muestreador"].Rows[buscaBtn1.RegistroSeleccionado][1].ToString();
					btnVistaPrevia.Visible = true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			try
			{
				crvRepMuestreador.Visible = true;
                cryRepMuestreador1.SetDataSource(dsRepMuestreador1);				
				dsRepMuestreador1.Clear();
				sqlDARepMuestreador.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
				sqlDARepMuestreador.SelectCommand.Parameters["@Fecha"].Value = txtFecha.Text;
				sqlDARepMuestreador.Fill(dsRepMuestreador1, "RepMuestreado");

                cryRepMuestreador1.SetParameterValue("@Ineco", chbLab1.Checked);
				
				crvRepMuestreador.ReportSource = cryRepMuestreador1;
				//crvRepMuestreador.RefreshReport();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}

		}

		private void sqlDARepMuestreador_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{
		
		}

		private void txtFecha_TextChanged(object sender, System.EventArgs e)
		{
		    		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsBusMuestreador1.Clear();
			crvRepMuestreador.Visible = false;
			txtIdobra.Text = comboBox1.SelectedValue.ToString();
				buscaBtn1.Visible = true;
				LlenasSqlDA();
		}


	}
}
