using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Bascula.
	/// </summary>
	public class Bascula : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDABascula;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblIdBascula;
		private System.Windows.Forms.Label lblBascula;
		private LancNeo.dsBascula dsBascula1;
		private System.Windows.Forms.Panel panel1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Bascula()
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
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bascula));
            this.sqlDABascula = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.lblIdBascula = new System.Windows.Forms.Label();
            this.lblBascula = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dsBascula1 = new LancNeo.dsBascula();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBascula1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // sqlDABascula
            // 
            this.sqlDABascula.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDABascula.InsertCommand = this.sqlInsertCommand1;
            this.sqlDABascula.SelectCommand = this.sqlSelectCommand1;
            this.sqlDABascula.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Bascula", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdBascula", "IdBascula"),
                        new System.Data.Common.DataColumnMapping("Bascula", "Bascula")})});
            this.sqlDABascula.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Bascula WHERE (IdBascula = @Original_IdBascula) AND (Bascula = @Origi" +
                "nal_Bascula OR @Original_Bascula IS NULL AND Bascula IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdBascula", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdBascula", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Bascula", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Bascula", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Bascula(IdBascula, Bascula) VALUES (@IdBascula, @Bascula); SELECT IdB" +
                "ascula, Bascula FROM Bascula WHERE (IdBascula = @IdBascula)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdBascula", System.Data.SqlDbType.NVarChar, 2, "IdBascula"),
            new System.Data.SqlClient.SqlParameter("@Bascula", System.Data.SqlDbType.NVarChar, 50, "Bascula")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdBascula, Bascula FROM Bascula";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdBascula", System.Data.SqlDbType.NVarChar, 2, "IdBascula"),
            new System.Data.SqlClient.SqlParameter("@Bascula", System.Data.SqlDbType.NVarChar, 50, "Bascula"),
            new System.Data.SqlClient.SqlParameter("@Original_IdBascula", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdBascula", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Bascula", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Bascula", System.Data.DataRowVersion.Original, null)});
            // 
            // lblIdBascula
            // 
            this.lblIdBascula.Location = new System.Drawing.Point(32, 48);
            this.lblIdBascula.Name = "lblIdBascula";
            this.lblIdBascula.Size = new System.Drawing.Size(72, 23);
            this.lblIdBascula.TabIndex = 3;
            this.lblIdBascula.Text = "Id Báscula:";
            this.lblIdBascula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIdBascula.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBascula
            // 
            this.lblBascula.Location = new System.Drawing.Point(32, 88);
            this.lblBascula.Name = "lblBascula";
            this.lblBascula.Size = new System.Drawing.Size(72, 23);
            this.lblBascula.TabIndex = 3;
            this.lblBascula.Text = "Báscula:";
            this.lblBascula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBascula.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsBascula1, "Bascula.IdBascula", true));
            this.textBox1.Location = new System.Drawing.Point(112, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "textBox1";
            // 
            // dsBascula1
            // 
            this.dsBascula1.DataSetName = "dsBascula";
            this.dsBascula1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBascula1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsBascula1, "Bascula.Bascula", true));
            this.textBox2.Location = new System.Drawing.Point(112, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "textBox1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblIdBascula);
            this.panel1.Controls.Add(this.lblBascula);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(80, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 176);
            this.panel1.TabIndex = 8;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBascula1.Bascula;
            this.buscaBtn1.ForeColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(176, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // Bascula
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDABascula;
            this.dsGeneral = this.dsBascula1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Bascula";
            this.NombreTabla = "Bascula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catálogo de Básculas";
            this.Load += new System.EventHandler(this.Bascula_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBascula1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Bascula_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
