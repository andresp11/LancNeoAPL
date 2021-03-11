using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Grado.
	/// </summary>
	public class Grado : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblGrado;
		private System.Windows.Forms.Label lblPorcentaje;
		private System.Windows.Forms.Label lblPruebas;
		private System.Windows.Forms.Label lblPorPromedio;
		private System.Windows.Forms.Label lblConsecutivo;
		private System.Windows.Forms.Label lblConstante;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.TextBox txtPorcentaje;
		private System.Windows.Forms.TextBox txtPruebas;
		private System.Windows.Forms.TextBox txtPorPromedio;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.TextBox txtConstante;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAGrado;
		private LancNeo.dsGrado dsGrado1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Grado()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grado));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAGrado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblPruebas = new System.Windows.Forms.Label();
            this.lblPorPromedio = new System.Windows.Forms.Label();
            this.lblConsecutivo = new System.Windows.Forms.Label();
            this.lblConstante = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsGrado1 = new LancNeo.dsGrado();
            this.txtConstante = new System.Windows.Forms.TextBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtPorPromedio = new System.Windows.Forms.TextBox();
            this.txtPruebas = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.panelToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrado1)).BeginInit();
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
            // sqlDAGrado
            // 
            this.sqlDAGrado.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAGrado.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAGrado.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAGrado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Porcentaje", "Porcentaje"),
                        new System.Data.Common.DataColumnMapping("Pruebas", "Pruebas"),
                        new System.Data.Common.DataColumnMapping("Porpromedio", "Porpromedio"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("Constante", "Constante")})});
            this.sqlDAGrado.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Constante", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Constante", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Porcentaje", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Porcentaje", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Porpromedio", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Porpromedio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Pruebas", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pruebas", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Porcentaje", System.Data.SqlDbType.Real, 4, "Porcentaje"),
            new System.Data.SqlClient.SqlParameter("@Pruebas", System.Data.SqlDbType.SmallInt, 2, "Pruebas"),
            new System.Data.SqlClient.SqlParameter("@Porpromedio", System.Data.SqlDbType.Real, 4, "Porpromedio"),
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 2, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@Constante", System.Data.SqlDbType.Real, 4, "Constante")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Grado, Porcentaje, Pruebas, Porpromedio, Consecutivo, Constante FROM Grado" +
                "";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 1, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Porcentaje", System.Data.SqlDbType.Real, 4, "Porcentaje"),
            new System.Data.SqlClient.SqlParameter("@Pruebas", System.Data.SqlDbType.SmallInt, 2, "Pruebas"),
            new System.Data.SqlClient.SqlParameter("@Porpromedio", System.Data.SqlDbType.Real, 4, "Porpromedio"),
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 2, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@Constante", System.Data.SqlDbType.Real, 4, "Constante"),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Constante", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Constante", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Porcentaje", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Porcentaje", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Porpromedio", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Porpromedio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Pruebas", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pruebas", System.Data.DataRowVersion.Original, null)});
            // 
            // lblGrado
            // 
            this.lblGrado.Location = new System.Drawing.Point(88, 24);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(152, 23);
            this.lblGrado.TabIndex = 3;
            this.lblGrado.Text = "Grado:";
            this.lblGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Location = new System.Drawing.Point(88, 64);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(152, 23);
            this.lblPorcentaje.TabIndex = 4;
            this.lblPorcentaje.Text = "Porcentaje máximo de error:";
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPruebas
            // 
            this.lblPruebas.Location = new System.Drawing.Point(88, 104);
            this.lblPruebas.Name = "lblPruebas";
            this.lblPruebas.Size = new System.Drawing.Size(152, 23);
            this.lblPruebas.TabIndex = 5;
            this.lblPruebas.Text = "Mínimo de pruebas:";
            this.lblPruebas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPorPromedio
            // 
            this.lblPorPromedio.Location = new System.Drawing.Point(88, 144);
            this.lblPorPromedio.Name = "lblPorPromedio";
            this.lblPorPromedio.Size = new System.Drawing.Size(152, 23);
            this.lblPorPromedio.TabIndex = 6;
            this.lblPorPromedio.Text = "Porcentaje máximo de error promedio:";
            this.lblPorPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConsecutivo
            // 
            this.lblConsecutivo.Location = new System.Drawing.Point(88, 176);
            this.lblConsecutivo.Name = "lblConsecutivo";
            this.lblConsecutivo.Size = new System.Drawing.Size(152, 23);
            this.lblConsecutivo.TabIndex = 7;
            this.lblConsecutivo.Text = "Número consecutivo:";
            this.lblConsecutivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConstante
            // 
            this.lblConstante.Location = new System.Drawing.Point(88, 216);
            this.lblConstante.Name = "lblConstante";
            this.lblConstante.Size = new System.Drawing.Size(152, 23);
            this.lblConstante.TabIndex = 8;
            this.lblConstante.Text = "Constante:";
            this.lblConstante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.txtConstante);
            this.panel1.Controls.Add(this.txtConsecutivo);
            this.panel1.Controls.Add(this.txtPorPromedio);
            this.panel1.Controls.Add(this.txtPruebas);
            this.panel1.Controls.Add(this.txtPorcentaje);
            this.panel1.Controls.Add(this.txtGrado);
            this.panel1.Controls.Add(this.lblPorcentaje);
            this.panel1.Controls.Add(this.lblConsecutivo);
            this.panel1.Controls.Add(this.lblPorPromedio);
            this.panel1.Controls.Add(this.lblConstante);
            this.panel1.Controls.Add(this.lblPruebas);
            this.panel1.Controls.Add(this.lblGrado);
            this.panel1.Location = new System.Drawing.Point(72, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 256);
            this.panel1.TabIndex = 9;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsGrado1.Grado;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(320, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsGrado1
            // 
            this.dsGrado1.DataSetName = "dsGrado";
            this.dsGrado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsGrado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConstante
            // 
            this.txtConstante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrado1, "Grado.Constante", true));
            this.txtConstante.Location = new System.Drawing.Point(248, 216);
            this.txtConstante.Name = "txtConstante";
            this.txtConstante.Size = new System.Drawing.Size(64, 20);
            this.txtConstante.TabIndex = 14;
            this.txtConstante.Text = "textBox6";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrado1, "Grado.Consecutivo", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(248, 176);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(64, 20);
            this.txtConsecutivo.TabIndex = 13;
            this.txtConsecutivo.Text = "textBox5";
            // 
            // txtPorPromedio
            // 
            this.txtPorPromedio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrado1, "Grado.Porpromedio", true));
            this.txtPorPromedio.Location = new System.Drawing.Point(248, 136);
            this.txtPorPromedio.Name = "txtPorPromedio";
            this.txtPorPromedio.Size = new System.Drawing.Size(64, 20);
            this.txtPorPromedio.TabIndex = 12;
            this.txtPorPromedio.Text = "textBox4";
            // 
            // txtPruebas
            // 
            this.txtPruebas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrado1, "Grado.Pruebas", true));
            this.txtPruebas.Location = new System.Drawing.Point(248, 104);
            this.txtPruebas.Name = "txtPruebas";
            this.txtPruebas.Size = new System.Drawing.Size(64, 20);
            this.txtPruebas.TabIndex = 11;
            this.txtPruebas.Text = "textBox3";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrado1, "Grado.Porcentaje", true));
            this.txtPorcentaje.Location = new System.Drawing.Point(248, 64);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(64, 20);
            this.txtPorcentaje.TabIndex = 10;
            this.txtPorcentaje.Text = "textBox2";
            // 
            // txtGrado
            // 
            this.txtGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrado1, "Grado.Grado", true));
            this.txtGrado.Location = new System.Drawing.Point(248, 24);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(64, 20);
            this.txtGrado.TabIndex = 9;
            this.txtGrado.Text = "textBox1";
            // 
            // Grado
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDAGrado;
            this.dsGeneral = this.dsGrado1;
            this.Name = "Grado";
            this.NombreTabla = "Grado";
            this.Text = "Grado";
            this.Load += new System.EventHandler(this.Grado_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrado1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Grado_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}
	}
}
