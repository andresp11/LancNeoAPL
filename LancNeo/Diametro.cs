using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;


namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Diametro.
	/// </summary>
	public class Diametro : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAdiametro;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsDiametro dsDiametro1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Diámetro;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox txtIdDiametro;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFigura;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Diametro()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diametro));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAdiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.txtFigura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Diámetro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDiametro = new System.Windows.Forms.TextBox();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 351);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(624, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(624, 64);
            // 
            // sqlDAdiametro
            // 
            this.sqlDAdiametro.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAdiametro.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAdiametro.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAdiametro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Diametro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("Figura", "Figura")})});
            this.sqlDAdiametro.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdDiam", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDiam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Figura", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Figura", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Diametro(IdDiam, Diametro, Figura) VALUES (@IdDiam, @Diametro, @Figur" +
                "a); SELECT IdDiam, Diametro, Figura FROM Diametro WHERE (IdDiam = @IdDiam)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 2, "IdDiam"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.VarChar, 10, "Diametro"),
            new System.Data.SqlClient.SqlParameter("@Figura", System.Data.SqlDbType.VarChar, 30, "Figura")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdDiam, Diametro, Figura FROM Diametro";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 2, "IdDiam"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.VarChar, 10, "Diametro"),
            new System.Data.SqlClient.SqlParameter("@Figura", System.Data.SqlDbType.VarChar, 30, "Figura"),
            new System.Data.SqlClient.SqlParameter("@Original_IdDiam", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDiam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Figura", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Figura", System.Data.DataRowVersion.Original, null)});
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.txtFigura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.Diámetro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdDiametro);
            this.panel1.Location = new System.Drawing.Point(112, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 168);
            this.panel1.TabIndex = 3;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsDiametro1.Diametro;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(270, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // txtFigura
            // 
            this.txtFigura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDiametro1, "Diametro.Figura", true));
            this.txtFigura.Location = new System.Drawing.Point(166, 121);
            this.txtFigura.Name = "txtFigura";
            this.txtFigura.Size = new System.Drawing.Size(100, 20);
            this.txtFigura.TabIndex = 6;
            this.txtFigura.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Figura geométrica:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDiametro1, "Diametro.Diametro", true));
            this.textBox2.Location = new System.Drawing.Point(166, 88);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Diámetro
            // 
            this.Diámetro.Location = new System.Drawing.Point(54, 88);
            this.Diámetro.Name = "Diámetro";
            this.Diámetro.Size = new System.Drawing.Size(100, 23);
            this.Diámetro.TabIndex = 2;
            this.Diámetro.Text = "Diámetro:";
            this.Diámetro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdDiametro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdDiametro
            // 
            this.txtIdDiametro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDiametro1, "Diametro.IdDiam", true));
            this.txtIdDiametro.Location = new System.Drawing.Point(166, 48);
            this.txtIdDiametro.MaxLength = 4;
            this.txtIdDiametro.Name = "txtIdDiametro";
            this.txtIdDiametro.Size = new System.Drawing.Size(100, 20);
            this.txtIdDiametro.TabIndex = 0;
            this.txtIdDiametro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Diametro
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 373);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDAdiametro;
            this.dsGeneral = this.dsDiametro1;
            this.Name = "Diametro";
            this.NombreTabla = "Diametro";
            this.Text = "Diametro";
            this.Load += new System.EventHandler(this.Diametro_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Diametro_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
