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
	/// Descripción breve de Valoresfp.
	/// </summary>
	public class Valoresfp : CatalogoGenerico 
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblConsecutivo;
		private System.Windows.Forms.Label lblGrado;
		private System.Windows.Forms.Label lblResistenciaMPa;
		private System.Windows.Forms.Label lblResistenciaKg;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.TextBox txtResistenciaMPa;
		private System.Windows.Forms.TextBox txtResistenciaKg;
		private System.Windows.Forms.ComboBox cmbGrado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAValoresfp;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsValoresfp dsValoresfp1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Valoresfp()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valoresfp));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsValoresfp1 = new LancNeo.dsValoresfp();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.lblConsecutivo = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblResistenciaMPa = new System.Windows.Forms.Label();
            this.lblResistenciaKg = new System.Windows.Forms.Label();
            this.txtResistenciaMPa = new System.Windows.Forms.TextBox();
            this.txtResistenciaKg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlDAValoresfp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsValoresfp1)).BeginInit();
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
            this.panel2.Controls.Add(this.cmbGrado);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.lblConsecutivo);
            this.panel2.Controls.Add(this.lblGrado);
            this.panel2.Controls.Add(this.lblResistenciaMPa);
            this.panel2.Controls.Add(this.lblResistenciaKg);
            this.panel2.Controls.Add(this.txtResistenciaMPa);
            this.panel2.Controls.Add(this.txtResistenciaKg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(72, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 248);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsValoresfp1.ValoresFp;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(288, 24);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsValoresfp1
            // 
            this.dsValoresfp1.DataSetName = "dsValoresfp";
            this.dsValoresfp1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsValoresfp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbGrado
            // 
            this.cmbGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValoresfp1, "ValoresFp.Grado", true));
            this.cmbGrado.Location = new System.Drawing.Point(184, 95);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(121, 21);
            this.cmbGrado.TabIndex = 2;
            this.cmbGrado.Text = "comboBox1";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValoresfp1, "ValoresFp.Consecutivo", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(184, 63);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(100, 20);
            this.txtConsecutivo.TabIndex = 1;
            this.txtConsecutivo.Text = "textBox1";
            // 
            // lblConsecutivo
            // 
            this.lblConsecutivo.Location = new System.Drawing.Point(107, 63);
            this.lblConsecutivo.Name = "lblConsecutivo";
            this.lblConsecutivo.Size = new System.Drawing.Size(72, 23);
            this.lblConsecutivo.TabIndex = 0;
            this.lblConsecutivo.Text = "Consecutivo:";
            this.lblConsecutivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrado
            // 
            this.lblGrado.Location = new System.Drawing.Point(107, 95);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(72, 23);
            this.lblGrado.TabIndex = 0;
            this.lblGrado.Text = "Grado:";
            this.lblGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResistenciaMPa
            // 
            this.lblResistenciaMPa.Location = new System.Drawing.Point(107, 127);
            this.lblResistenciaMPa.Name = "lblResistenciaMPa";
            this.lblResistenciaMPa.Size = new System.Drawing.Size(72, 23);
            this.lblResistenciaMPa.TabIndex = 0;
            this.lblResistenciaMPa.Text = "Resistencia:";
            this.lblResistenciaMPa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResistenciaKg
            // 
            this.lblResistenciaKg.Location = new System.Drawing.Point(107, 159);
            this.lblResistenciaKg.Name = "lblResistenciaKg";
            this.lblResistenciaKg.Size = new System.Drawing.Size(72, 23);
            this.lblResistenciaKg.TabIndex = 0;
            this.lblResistenciaKg.Text = "Resistencia:";
            this.lblResistenciaKg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResistenciaMPa
            // 
            this.txtResistenciaMPa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValoresfp1, "ValoresFp.ResistenciaMPa", true));
            this.txtResistenciaMPa.Location = new System.Drawing.Point(184, 127);
            this.txtResistenciaMPa.Name = "txtResistenciaMPa";
            this.txtResistenciaMPa.Size = new System.Drawing.Size(100, 20);
            this.txtResistenciaMPa.TabIndex = 1;
            this.txtResistenciaMPa.Text = "textBox1";
            // 
            // txtResistenciaKg
            // 
            this.txtResistenciaKg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsValoresfp1, "ValoresFp.ResistenciaKg", true));
            this.txtResistenciaKg.Location = new System.Drawing.Point(184, 159);
            this.txtResistenciaKg.Name = "txtResistenciaKg";
            this.txtResistenciaKg.Size = new System.Drawing.Size(100, 20);
            this.txtResistenciaKg.TabIndex = 1;
            this.txtResistenciaKg.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(288, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MPa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(288, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kg/cm ²";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sqlDAValoresfp
            // 
            this.sqlDAValoresfp.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAValoresfp.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAValoresfp.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAValoresfp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ValoresFp", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("ResistenciaMPa", "ResistenciaMPa"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKg", "ResistenciaKg")})});
            this.sqlDAValoresfp.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKg", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaKg", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaMPa", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaMPa", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.Int, 4, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1, "Grado"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaMPa", System.Data.SqlDbType.Real, 4, "ResistenciaMPa"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKg", System.Data.SqlDbType.Real, 4, "ResistenciaKg")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Consecutivo, Grado, ResistenciaMPa, ResistenciaKg FROM ValoresFp ORDER BY " +
                "Consecutivo";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.Int, 4, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1, "Grado"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaMPa", System.Data.SqlDbType.Real, 4, "ResistenciaMPa"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKg", System.Data.SqlDbType.Real, 4, "ResistenciaKg"),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKg", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaKg", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaMPa", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaMPa", System.Data.DataRowVersion.Original, null)});
            // 
            // Valoresfp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAValoresfp;
            this.dsGeneral = this.dsValoresfp1;
            this.Name = "Valoresfp";
            this.NombreTabla = "Valoresfp";
            this.Text = "Tabla de Valores fp mínimos";
            this.Load += new System.EventHandler(this.Valoresfp_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsValoresfp1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion



		private void Valoresfp_Load(object sender, System.EventArgs e)
		{
			LlenaGrado();
			this.buscaBtn1.Catalogo = this;
		}
		private void LlenaGrado()
		{
			try
			{
				String strSql = " Select Grado From Grado";
				SqlCommand sqlCmd = new SqlCommand(strSql, sqlConn);
				sqlConn.Open();
				SqlDataReader dr = sqlCmd.ExecuteReader();
				while(dr.Read())
				{
					cmbGrado.Items.Add(dr["Grado"].ToString());
				}
			}
			catch(Exception ex)
			{
				ex.ToString();
			}
			finally
			{
				if(sqlConn.State == ConnectionState.Open)
				{
					sqlConn.Close();
				}
			}
		}

	}
}
