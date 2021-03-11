using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Procesa.
	/// </summary>
	public class Procesa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIdObraO;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Data.SqlClient.SqlCommand sqlComAgrega;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpIni;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtIdobra;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObraO;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label6;
        private DateTimePicker dtpPFi;
        private Label label5;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
        private DateTimePicker dtpPFf;
        private Label label7;
        private System.Data.SqlClient.SqlCommand sqlComAgregaP;
        private TextBox txtFIMin;
        private TextBox txtFIMax;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Procesa()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Procesa));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.txtFIMin = new System.Windows.Forms.TextBox();
            this.txtFIMax = new System.Windows.Forms.TextBox();
            this.dtpPFf = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPFi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObraO = new System.Windows.Forms.ComboBox();
            this.dsBuscaObra1 = new LancNeo.dsBuscaObra();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlComAgrega = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusObraO = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlComAgregaP = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.txtFIMin);
            this.panel1.Controls.Add(this.txtFIMax);
            this.panel1.Controls.Add(this.dtpPFf);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpPFi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.cbkPrefijo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObraO);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 192);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(692, 86);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 49;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(692, 2);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 13;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // txtFIMin
            // 
            this.txtFIMin.Enabled = false;
            this.txtFIMin.Location = new System.Drawing.Point(584, 123);
            this.txtFIMin.Name = "txtFIMin";
            this.txtFIMin.Size = new System.Drawing.Size(84, 20);
            this.txtFIMin.TabIndex = 51;
            // 
            // txtFIMax
            // 
            this.txtFIMax.Enabled = false;
            this.txtFIMax.Location = new System.Drawing.Point(584, 94);
            this.txtFIMax.Name = "txtFIMax";
            this.txtFIMax.Size = new System.Drawing.Size(84, 20);
            this.txtFIMax.TabIndex = 50;
            // 
            // dtpPFf
            // 
            this.dtpPFf.Enabled = false;
            this.dtpPFf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPFf.Location = new System.Drawing.Point(466, 120);
            this.dtpPFf.Name = "dtpPFf";
            this.dtpPFf.Size = new System.Drawing.Size(84, 20);
            this.dtpPFf.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Fechas de NUEVOS PRECIOS";
            // 
            // dtpPFi
            // 
            this.dtpPFi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPFi.Location = new System.Drawing.Point(465, 95);
            this.dtpPFi.Name = "dtpPFi";
            this.dtpPFi.Size = new System.Drawing.Size(84, 20);
            this.dtpPFi.TabIndex = 44;
            this.dtpPFi.ValueChanged += new System.EventHandler(this.dtpPFi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Inicial:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(584, 42);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(556, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(584, 8);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(548, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Inicial:";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(452, 26);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 39;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.ForeColor = System.Drawing.Color.White;
            this.cbkPrefijo.Location = new System.Drawing.Point(366, 40);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 37;
            this.cbkPrefijo.Text = "No prefijo";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 82);
            this.label3.TabIndex = 14;
            this.label3.Text = "Acumula y agrupa los servicios de todos los informes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbIdObraO
            // 
            this.cmbIdObraO.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObraO.DisplayMember = "Idobra";
            this.cmbIdObraO.Location = new System.Drawing.Point(366, 8);
            this.cmbIdObraO.Name = "cmbIdObraO";
            this.cmbIdObraO.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObraO.TabIndex = 9;
            this.cmbIdObraO.ValueMember = "IdObra";
            this.cmbIdObraO.SelectedIndexChanged += new System.EventHandler(this.cmbIdObraO_SelectedIndexChanged);
            // 
            // dsBuscaObra1
            // 
            this.dsBuscaObra1.DataSetName = "dsBuscaObra";
            this.dsBuscaObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBuscaObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(378, 10);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 43;
            this.txtIdobra.Visible = false;
            // 
            // sqlComAgrega
            // 
            this.sqlComAgrega.CommandText = "[agregaconcentra]";
            this.sqlComAgrega.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComAgrega.Connection = this.sqlConn;
            this.sqlComAgrega.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin", System.Data.SqlDbType.DateTime, 8)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDABusObraO
            // 
            this.sqlDABusObraO.SelectCommand = this.sqlCommand1;
            this.sqlDABusObraO.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            // sqlComAgregaP
            // 
            this.sqlComAgregaP.CommandText = "[actualizaprecios]";
            this.sqlComAgregaP.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComAgregaP.Connection = this.sqlConn;
            this.sqlComAgregaP.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@FfMax", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FfMin", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FiMax", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FiMin", System.Data.SqlDbType.SmallDateTime, 4)});
            // 
            // Procesa
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(942, 204);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Procesa";
            this.Text = "Procesa servicios";
            this.Load += new System.EventHandler(this.Procesa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			try
			{
				sqlConn.Open();
				sqlComAgrega.Parameters["@IdObra"].Value = txtIdobra.Text.Trim() + (cbkPrefijo.Checked ? "" : "%");
				sqlComAgrega.Parameters["@Fini"].Value = dtpIni.Value;
				sqlComAgrega.Parameters["@Ffin"].Value = dtpFin.Value;
				int error = sqlComAgrega.ExecuteNonQuery();
				MessageBox.Show("Proceso terminado");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
			sqlConn.Close();
		}

		private void cmbIdObraO_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtIdobra.Text = cmbIdObraO.SelectedValue.ToString();
		}

		private void Procesa_Load(object sender, System.EventArgs e)
		{
            DateTime ff;
            sqlDABusObraO.Fill(dsBuscaObra1, "Obra");
            dtpPFi.Value = System.Convert.ToDateTime("01/01/" + DateTime.Now.Year.ToString());
            dtpPFf.Value = dtpPFi.Value.AddMonths(6);
            dtpPFf.Value = dtpPFf.Value.AddDays(-1);
            txtFIMax.Text = dtpPFi.Value.AddMonths(-6).ToString().Substring(0,10);
            ff = dtpPFi.Value.AddDays(-1);
            txtFIMin.Text = ff.ToString().Substring(0, 10);

		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpPFi_ValueChanged(object sender, EventArgs e)
        {
            DateTime ff;
            dtpPFf.Value = dtpPFi.Value.AddMonths(6);
            dtpPFf.Value = dtpPFf.Value.AddDays(-1);
            txtFIMax.Text = dtpPFi.Value.AddMonths(-6).ToString().Substring(0, 10);
            ff = dtpPFi.Value.AddDays(-1);
            txtFIMin.Text = ff.ToString().Substring(0, 10);
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();
            sqlComAgregaP.Parameters["@Ffmax"].Value = dtpPFf.Value.ToString().Substring(0, 10);
            sqlComAgregaP.Parameters["@Ffmin"].Value = dtpPFi.Value.ToString().Substring(0, 10);
            sqlComAgregaP.Parameters["@Fimax"].Value = txtFIMin.Text;
            sqlComAgregaP.Parameters["@Fimin"].Value = txtFIMax.Text;
            int error = sqlComAgregaP.ExecuteNonQuery();
            MessageBox.Show("Proceso terminado");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message );
			}
			sqlConn.Close();
        }
	}
}
