using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Unidad.
	/// </summary>
	public class Unidad : CatalogoGenerico 
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblIdUnidad;
		private System.Windows.Forms.Label lblUnidad;
		private System.Windows.Forms.Label lblFactor;
		private System.Windows.Forms.Label lblUnAgreg;
		private System.Windows.Forms.Label lblUnReven;
		private System.Windows.Forms.TextBox txtIdUnidad;
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.TextBox txtFactor;
		private System.Windows.Forms.TextBox txtUniAgreg;
		private System.Windows.Forms.TextBox txtUniReven;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsUnidad dsUnidad1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.TextBox txtfUagregado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUfrevenimiento;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Unidad()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unidad));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUfrevenimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfUagregado = new System.Windows.Forms.TextBox();
            this.txtIdUnidad = new System.Windows.Forms.TextBox();
            this.lblIdUnidad = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblFactor = new System.Windows.Forms.Label();
            this.lblUnAgreg = new System.Windows.Forms.Label();
            this.lblUnReven = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtFactor = new System.Windows.Forms.TextBox();
            this.txtUniAgreg = new System.Windows.Forms.TextBox();
            this.txtUniReven = new System.Windows.Forms.TextBox();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUfrevenimiento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtfUagregado);
            this.panel2.Controls.Add(this.txtIdUnidad);
            this.panel2.Controls.Add(this.lblIdUnidad);
            this.panel2.Controls.Add(this.lblUnidad);
            this.panel2.Controls.Add(this.lblFactor);
            this.panel2.Controls.Add(this.lblUnAgreg);
            this.panel2.Controls.Add(this.lblUnReven);
            this.panel2.Controls.Add(this.txtUnidad);
            this.panel2.Controls.Add(this.txtFactor);
            this.panel2.Controls.Add(this.txtUniAgreg);
            this.panel2.Controls.Add(this.txtUniReven);
            this.panel2.Location = new System.Drawing.Point(72, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 277);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsUnidad1.Unidad;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(304, 8);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Conversión unidad revenimiento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUfrevenimiento
            // 
            this.txtUfrevenimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.FacRev", true));
            this.txtUfrevenimiento.Location = new System.Drawing.Point(200, 232);
            this.txtUfrevenimiento.Name = "txtUfrevenimiento";
            this.txtUfrevenimiento.Size = new System.Drawing.Size(100, 20);
            this.txtUfrevenimiento.TabIndex = 6;
            this.txtUfrevenimiento.Text = "txtUrevenimiento";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conversión unidad agregado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtfUagregado
            // 
            this.txtfUagregado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.FacMax", true));
            this.txtfUagregado.Location = new System.Drawing.Point(200, 200);
            this.txtfUagregado.Name = "txtfUagregado";
            this.txtfUagregado.Size = new System.Drawing.Size(100, 20);
            this.txtfUagregado.TabIndex = 4;
            this.txtfUagregado.Text = "txtUrevenimiento";
            // 
            // txtIdUnidad
            // 
            this.txtIdUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.IdUnidad", true));
            this.txtIdUnidad.Location = new System.Drawing.Point(200, 40);
            this.txtIdUnidad.Name = "txtIdUnidad";
            this.txtIdUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtIdUnidad.TabIndex = 1;
            this.txtIdUnidad.Text = "textBox1";
            // 
            // lblIdUnidad
            // 
            this.lblIdUnidad.Location = new System.Drawing.Point(48, 35);
            this.lblIdUnidad.Name = "lblIdUnidad";
            this.lblIdUnidad.Size = new System.Drawing.Size(136, 23);
            this.lblIdUnidad.TabIndex = 0;
            this.lblIdUnidad.Text = "Id Unidad:";
            this.lblIdUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnidad
            // 
            this.lblUnidad.Location = new System.Drawing.Point(48, 64);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(136, 23);
            this.lblUnidad.TabIndex = 0;
            this.lblUnidad.Text = "Descripción:";
            this.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFactor
            // 
            this.lblFactor.Location = new System.Drawing.Point(48, 96);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(136, 23);
            this.lblFactor.TabIndex = 0;
            this.lblFactor.Text = "Factor a Kg f/ cm ²:";
            this.lblFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnAgreg
            // 
            this.lblUnAgreg.Location = new System.Drawing.Point(48, 128);
            this.lblUnAgreg.Name = "lblUnAgreg";
            this.lblUnAgreg.Size = new System.Drawing.Size(136, 23);
            this.lblUnAgreg.TabIndex = 0;
            this.lblUnAgreg.Text = "Unidad del agregado:";
            this.lblUnAgreg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnReven
            // 
            this.lblUnReven.Location = new System.Drawing.Point(48, 160);
            this.lblUnReven.Name = "lblUnReven";
            this.lblUnReven.Size = new System.Drawing.Size(136, 23);
            this.lblUnReven.TabIndex = 0;
            this.lblUnReven.Text = "Unidad del revenimiento:";
            this.lblUnReven.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnidad
            // 
            this.txtUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.Undescr", true));
            this.txtUnidad.Location = new System.Drawing.Point(200, 72);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 1;
            this.txtUnidad.Text = "textBox1";
            // 
            // txtFactor
            // 
            this.txtFactor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.Factor", true));
            this.txtFactor.Location = new System.Drawing.Point(200, 104);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Size = new System.Drawing.Size(100, 20);
            this.txtFactor.TabIndex = 1;
            this.txtFactor.Text = "textBox1";
            // 
            // txtUniAgreg
            // 
            this.txtUniAgreg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.MaxagrUn", true));
            this.txtUniAgreg.Location = new System.Drawing.Point(200, 136);
            this.txtUniAgreg.Name = "txtUniAgreg";
            this.txtUniAgreg.Size = new System.Drawing.Size(100, 20);
            this.txtUniAgreg.TabIndex = 1;
            this.txtUniAgreg.Text = "textBox1";
            // 
            // txtUniReven
            // 
            this.txtUniReven.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.RevenUn", true));
            this.txtUniReven.Location = new System.Drawing.Point(200, 168);
            this.txtUniReven.Name = "txtUniReven";
            this.txtUniReven.Size = new System.Drawing.Size(100, 20);
            this.txtUniReven.TabIndex = 1;
            this.txtUniReven.Text = "txtUagregado";
            // 
            // sqlDAUnidad
            // 
            this.sqlDAUnidad.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAUnidad.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAUnidad.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAUnidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn"),
                        new System.Data.Common.DataColumnMapping("FacMax", "FacMax"),
                        new System.Data.Common.DataColumnMapping("FacRev", "FacRev")})});
            this.sqlDAUnidad.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdUnidad", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUnidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FacMax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FacMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FacRev", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FacRev", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Factor", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Factor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MaxagrUn", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MaxagrUn", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RevenUn", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevenUn", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Undescr", System.Data.SqlDbType.NVarChar, 7, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Undescr", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2, "IdUnidad"),
            new System.Data.SqlClient.SqlParameter("@Undescr", System.Data.SqlDbType.NVarChar, 7, "Undescr"),
            new System.Data.SqlClient.SqlParameter("@Factor", System.Data.SqlDbType.Real, 4, "Factor"),
            new System.Data.SqlClient.SqlParameter("@MaxagrUn", System.Data.SqlDbType.NVarChar, 2, "MaxagrUn"),
            new System.Data.SqlClient.SqlParameter("@RevenUn", System.Data.SqlDbType.NVarChar, 2, "RevenUn"),
            new System.Data.SqlClient.SqlParameter("@FacMax", System.Data.SqlDbType.Real, 4, "FacMax"),
            new System.Data.SqlClient.SqlParameter("@FacRev", System.Data.SqlDbType.Real, 4, "FacRev")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdUnidad, Undescr, Factor, MaxagrUn, RevenUn, FacMax, FacRev FROM Unidad";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2, "IdUnidad"),
            new System.Data.SqlClient.SqlParameter("@Undescr", System.Data.SqlDbType.NVarChar, 7, "Undescr"),
            new System.Data.SqlClient.SqlParameter("@Factor", System.Data.SqlDbType.Real, 4, "Factor"),
            new System.Data.SqlClient.SqlParameter("@MaxagrUn", System.Data.SqlDbType.NVarChar, 2, "MaxagrUn"),
            new System.Data.SqlClient.SqlParameter("@RevenUn", System.Data.SqlDbType.NVarChar, 2, "RevenUn"),
            new System.Data.SqlClient.SqlParameter("@FacMax", System.Data.SqlDbType.Real, 4, "FacMax"),
            new System.Data.SqlClient.SqlParameter("@FacRev", System.Data.SqlDbType.Real, 4, "FacRev"),
            new System.Data.SqlClient.SqlParameter("@Original_IdUnidad", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUnidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FacMax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FacMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FacRev", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FacRev", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Factor", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Factor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MaxagrUn", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MaxagrUn", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RevenUn", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevenUn", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Undescr", System.Data.SqlDbType.NVarChar, 7, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Undescr", System.Data.DataRowVersion.Original, null)});
            // 
            // Unidad
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAUnidad;
            this.dsGeneral = this.dsUnidad1;
            this.Name = "Unidad";
            this.NombreTabla = "Unidad";
            this.Text = "Catálogo de Unidad de Medida";
            this.Load += new System.EventHandler(this.Unidad_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Unidad_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;
		}
	}
}
