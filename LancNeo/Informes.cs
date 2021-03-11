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
	/// Descripción breve de Informes.
	/// </summary>
	public class Informes : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAInformes;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsInformes dsInformes1;
		private System.Windows.Forms.Panel panel2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdInformes;
		private System.Windows.Forms.TextBox txtInformes;
		private System.Windows.Forms.Label label2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtcorto;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Informes()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informes));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAInformes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsInformes1 = new LancNeo.dsInformes();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.txtcorto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInformes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdInformes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInformes1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 263);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(576, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(576, 64);
            // 
            // sqlDAInformes
            // 
            this.sqlDAInformes.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAInformes.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAInformes.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAInformes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Informes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme"),
                        new System.Data.Common.DataColumnMapping("Informe", "Informe"),
                        new System.Data.Common.DataColumnMapping("InformeCorto", "InformeCorto")})});
            this.sqlDAInformes.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdInforme", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdInforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Informe", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Informe", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_InformeCorto", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InformeCorto", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.VarChar, 10, "IdInforme"),
            new System.Data.SqlClient.SqlParameter("@Informe", System.Data.SqlDbType.VarChar, 50, "Informe"),
            new System.Data.SqlClient.SqlParameter("@InformeCorto", System.Data.SqlDbType.VarChar, 15, "InformeCorto")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdInforme, Informe, InformeCorto FROM Informes ORDER BY IdInforme";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.VarChar, 10, "IdInforme"),
            new System.Data.SqlClient.SqlParameter("@Informe", System.Data.SqlDbType.VarChar, 50, "Informe"),
            new System.Data.SqlClient.SqlParameter("@InformeCorto", System.Data.SqlDbType.VarChar, 15, "InformeCorto"),
            new System.Data.SqlClient.SqlParameter("@Original_IdInforme", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdInforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Informe", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Informe", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_InformeCorto", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InformeCorto", System.Data.DataRowVersion.Original, null)});
            // 
            // dsInformes1
            // 
            this.dsInformes1.DataSetName = "dsInformes";
            this.dsInformes1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsInformes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtcorto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtInformes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdInformes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 136);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsInformes1.Informes;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(176, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 54;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // txtcorto
            // 
            this.txtcorto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsInformes1, "Informes.InformeCorto", true));
            this.txtcorto.Location = new System.Drawing.Point(72, 104);
            this.txtcorto.Name = "txtcorto";
            this.txtcorto.Size = new System.Drawing.Size(100, 20);
            this.txtcorto.TabIndex = 59;
            this.txtcorto.Text = "textBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Identificador:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInformes
            // 
            this.txtInformes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsInformes1, "Informes.Informe", true));
            this.txtInformes.Location = new System.Drawing.Point(72, 64);
            this.txtInformes.Name = "txtInformes";
            this.txtInformes.Size = new System.Drawing.Size(336, 20);
            this.txtInformes.TabIndex = 57;
            this.txtInformes.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Informe:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdInformes
            // 
            this.txtIdInformes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsInformes1, "Informes.IdInforme", true));
            this.txtIdInformes.Location = new System.Drawing.Point(72, 22);
            this.txtIdInformes.Name = "txtIdInformes";
            this.txtIdInformes.Size = new System.Drawing.Size(100, 20);
            this.txtIdInformes.TabIndex = 55;
            this.txtIdInformes.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "IdInforme:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Informes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 285);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAInformes;
            this.dsGeneral = this.dsInformes1;
            this.Name = "Informes";
            this.NombreTabla = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsInformes1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Informes_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}
	}
}
