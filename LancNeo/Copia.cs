using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Copia.
	/// </summary>
	public class Copia : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsBuscaObra dsBuscaObra1;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsBuscaObra dsBuscaObra2;
		private System.Windows.Forms.Label label1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObraO;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObraD;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.ComboBox cmbIdObraO;
		private System.Data.SqlClient.SqlCommand sqlComCopia;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private LancNeo.dsBusResistencia dsBusResistencia1;
		private System.Data.SqlClient.SqlDataAdapter sqlDARes;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private System.Windows.Forms.ComboBox cmbRes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBuscar;
		protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
		private System.Data.SqlClient.SqlCommand sqlComRemplaza;
        private TextBox txtIdObra;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Copia()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Copia));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObraO = new System.Windows.Forms.ComboBox();
            this.dsBuscaObra1 = new LancNeo.dsBuscaObra();
            this.dsBuscaObra2 = new LancNeo.dsBuscaObra();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusObraO = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObraD = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlComCopia = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRes = new System.Windows.Forms.ComboBox();
            this.dsBusResistencia1 = new LancNeo.dsBusResistencia();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlDARes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlComRemplaza = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.txtIdObra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObraO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(478, 4);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 13;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // txtIdObra
            // 
            this.txtIdObra.Location = new System.Drawing.Point(284, 44);
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(80, 20);
            this.txtIdObra.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Copia de obra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Obra destino:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Obra origen:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbIdObraO
            // 
            this.cmbIdObraO.DataSource = this.dsBuscaObra1.Obra;
            this.cmbIdObraO.DisplayMember = "Idobra";
            this.cmbIdObraO.Location = new System.Drawing.Point(284, 14);
            this.cmbIdObraO.Name = "cmbIdObraO";
            this.cmbIdObraO.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObraO.TabIndex = 9;
            this.cmbIdObraO.ValueMember = "IdObra";
            // 
            // dsBuscaObra1
            // 
            this.dsBuscaObra1.DataSetName = "dsBuscaObra";
            this.dsBuscaObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBuscaObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBuscaObra2
            // 
            this.dsBuscaObra2.DataSetName = "dsBuscaObra";
            this.dsBuscaObra2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBuscaObra2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDABusObraD
            // 
            this.sqlDABusObraD.SelectCommand = this.sqlCommand2;
            this.sqlDABusObraD.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // sqlComCopia
            // 
            this.sqlComCopia.CommandText = "[copia]";
            this.sqlComCopia.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComCopia.Connection = this.sqlConn;
            this.sqlComCopia.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObraOrigen", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdObraDestino", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbBtn1);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbRes);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(478, 4);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 43;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(282, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(174, 20);
            this.txtBuscar.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(234, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Buscar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbRes
            // 
            this.cmbRes.DataSource = this.dsBusResistencia1.Resistencia;
            this.cmbRes.DisplayMember = "Resistencia";
            this.cmbRes.Location = new System.Drawing.Point(282, 64);
            this.cmbRes.Name = "cmbRes";
            this.cmbRes.Size = new System.Drawing.Size(64, 21);
            this.cmbRes.TabIndex = 40;
            this.cmbRes.ValueMember = "ResistenciaKG";
            // 
            // dsBusResistencia1
            // 
            this.dsBusResistencia1.DataSetName = "dsBusResistencia";
            this.dsBusResistencia1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusResistencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(158, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Resistencia resultante:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sustitución de resistencias";
            // 
            // sqlDARes
            // 
            this.sqlDARes.SelectCommand = this.sqlSelectCommand7;
            this.sqlDARes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Resistencia", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("ResistenciaMPa", "ResistenciaMPa")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT ResistenciaKG, STR(ResistenciaKG) AS Resistencia FROM Resistencia";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // sqlComRemplaza
            // 
            this.sqlComRemplaza.CommandText = "[Remplaza]";
            this.sqlComRemplaza.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComRemplaza.Connection = this.sqlConn;
            this.sqlComRemplaza.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Busca", System.Data.SqlDbType.NVarChar, 20),
            new System.Data.SqlClient.SqlParameter("@IdObraDestino", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Resistencia", System.Data.SqlDbType.Real, 4)});
            // 
            // Copia
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(552, 189);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Copia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copia";
            this.Load += new System.EventHandler(this.Copia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusResistencia1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Copia_Load(object sender, System.EventArgs e)
		{
			sqlDABusObraO.Fill(dsBuscaObra1, "Obra");
			sqlDABusObraD.Fill(dsBuscaObra2, "Obra");
			sqlDARes.Fill(dsBusResistencia1,"Resistencia");
			cmbIdObraO.SelectedIndex = 0;
			cmbRes.SelectedIndex = 0;

		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            try
            {
                sqlConn.Open();
                sqlComCopia.Parameters["@IdObraOrigen"].Value = cmbIdObraO.SelectedValue;
                sqlComCopia.Parameters["@IdObraDestino"].Value = txtIdObra.Text.Trim();
                sqlComCopia.ExecuteNonQuery();
                MessageBox.Show("Copia terminada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

		}

		private void tbBtn1_Click(object sender, System.EventArgs e)
		{
			sqlConn.Open();
			sqlComRemplaza.Parameters["@Busca"].Value = txtBuscar.Text;
            sqlComRemplaza.Parameters["@IdObraDestino"].Value = txtIdObra.Text.Trim();
			sqlComRemplaza.Parameters["@Resistencia"].Value = cmbRes.SelectedValue;
			sqlComRemplaza.ExecuteNonQuery();
			sqlConn.Close();
		}

	}
}

