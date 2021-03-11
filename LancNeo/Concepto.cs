using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Concepto.
	/// </summary>
	public class Concepto : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdConcepto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtConcepto;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcepto;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsConcepto dsConcepto1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Concepto()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concepto));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConcepto1 = new LancNeo.dsConcepto();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdConcepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDAConcepto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcepto1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 351);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(600, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(600, 64);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtConcepto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdConcepto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(96, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 144);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConcepto1.Concepto;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(224, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsConcepto1
            // 
            this.dsConcepto1.DataSetName = "dsConcepto";
            this.dsConcepto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcepto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConcepto
            // 
            this.txtConcepto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConcepto1, "Concepto.Concepto", true));
            this.txtConcepto.Location = new System.Drawing.Point(104, 88);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(312, 20);
            this.txtConcepto.TabIndex = 3;
            this.txtConcepto.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Concepto:";
            // 
            // txtIdConcepto
            // 
            this.txtIdConcepto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConcepto1, "Concepto.IdConcepto", true));
            this.txtIdConcepto.Location = new System.Drawing.Point(104, 24);
            this.txtIdConcepto.Name = "txtIdConcepto";
            this.txtIdConcepto.Size = new System.Drawing.Size(100, 20);
            this.txtIdConcepto.TabIndex = 1;
            this.txtIdConcepto.Text = "textBox1";
            this.txtIdConcepto.TextChanged += new System.EventHandler(this.txtIdConcepto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdConcepto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sqlDAConcepto
            // 
            this.sqlDAConcepto.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAConcepto.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAConcepto.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAConcepto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concepto", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            this.sqlDAConcepto.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Concepto WHERE (IdConcepto = @Original_IdConcepto) AND (Concepto = @O" +
                "riginal_Concepto OR @Original_Concepto IS NULL AND Concepto IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdConcepto", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Concepto", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concepto", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Concepto(IdConcepto, Concepto) VALUES (@IdConcepto, @Concepto); SELEC" +
                "T IdConcepto, Concepto FROM Concepto WHERE (IdConcepto = @IdConcepto)";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcepto", System.Data.SqlDbType.SmallInt, 2, "IdConcepto"),
            new System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.VarChar, 50, "Concepto")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdConcepto, Concepto FROM Concepto";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcepto", System.Data.SqlDbType.SmallInt, 2, "IdConcepto"),
            new System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.VarChar, 50, "Concepto"),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcepto", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Concepto", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concepto", System.Data.DataRowVersion.Original, null)});
            // 
            // Concepto
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(600, 373);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAConcepto;
            this.dsGeneral = this.dsConcepto1;
            this.Name = "Concepto";
            this.NombreTabla = "Concepto";
            this.Text = "Concepto";
            this.Load += new System.EventHandler(this.Concepto_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcepto1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void txtIdConcepto_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Concepto_Load(object sender, System.EventArgs e)
		{
			buscaBtn1.Catalogo = this;
		}
	}
}
