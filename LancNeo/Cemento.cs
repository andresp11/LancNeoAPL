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
	/// Descripción breve de Cemento.
	/// </summary>
	public class Cemento : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label IdObra;
		private System.Windows.Forms.DateTimePicker dtpHri;
        private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.Label Fecha;
		private System.Windows.Forms.TextBox txtIdObra;
        private System.Windows.Forms.Label Cementolbl;
        private dsCemento dsCemento1;
        private SqlCommand sqlSelectCommand1;
        private SqlCommand sqlInsertCommand1;
        private SqlCommand sqlUpdateCommand1;
        private SqlCommand sqlDeleteCommand1;
        private SqlDataAdapter sqlDACemento;
        private dsCemento dsCemento;
        public SqlDataAdapter sqlDABusObra;
        private SqlCommand sqlCommand1;
        private dsBusObra dsBusObra1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Cemento()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cemento));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dtpHri = new System.Windows.Forms.DateTimePicker();
            this.dsCemento = new LancNeo.dsCemento();
            this.Cementolbl = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.IdObra = new System.Windows.Forms.Label();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACemento = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 267);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(648, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(648, 64);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.dtpHri);
            this.panel2.Controls.Add(this.Cementolbl);
            this.panel2.Controls.Add(this.Fecha);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.IdObra);
            this.panel2.Controls.Add(this.txtIdObra);
            this.panel2.Location = new System.Drawing.Point(40, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 176);
            this.panel2.TabIndex = 5;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsCemento.Cemento;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(357, 12);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 8;
            this.buscaBtn1.Load += new System.EventHandler(this.buscaBtn1_Load);
            // 
            // dtpHri
            // 
            this.dtpHri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCemento, "Cemento.Fecha", true));
            this.dtpHri.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHri.Location = new System.Drawing.Point(176, 56);
            this.dtpHri.Name = "dtpHri";
            this.dtpHri.Size = new System.Drawing.Size(88, 20);
            this.dtpHri.TabIndex = 9;
            this.dtpHri.ValueChanged += new System.EventHandler(this.dtpHri_ValueChanged);
            // 
            // dsCemento
            // 
            this.dsCemento.DataSetName = "dsCemento";
            this.dsCemento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cementolbl
            // 
            this.Cementolbl.AutoSize = true;
            this.Cementolbl.Location = new System.Drawing.Point(112, 88);
            this.Cementolbl.Name = "Cementolbl";
            this.Cementolbl.Size = new System.Drawing.Size(52, 13);
            this.Cementolbl.TabIndex = 5;
            this.Cementolbl.Text = "Cemento:";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(112, 56);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(40, 13);
            this.Fecha.TabIndex = 3;
            this.Fecha.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCemento, "Cemento.Cemento", true));
            this.txtNombre.Location = new System.Drawing.Point(176, 88);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // IdObra
            // 
            this.IdObra.AutoSize = true;
            this.IdObra.Location = new System.Drawing.Point(112, 24);
            this.IdObra.Name = "IdObra";
            this.IdObra.Size = new System.Drawing.Size(42, 13);
            this.IdObra.TabIndex = 1;
            this.IdObra.Text = "IdObra:";
            // 
            // txtIdObra
            // 
            this.txtIdObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCemento, "Cemento.IdObra", true));
            this.txtIdObra.Location = new System.Drawing.Point(176, 24);
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(100, 20);
            this.txtIdObra.TabIndex = 0;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     IdObra, Fecha, Cemento\r\nFROM         Cemento\r\nORDER BY IdObra";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Cemento] ([IdObra], [Fecha], [Cemento]) VALUES (@IdObra, @Fecha, @Ce" +
    "mento);\r\nSELECT IdObra, Fecha, Cemento FROM Cemento WHERE (Fecha = @Fecha) AND (" +
    "IdObra = @IdObra) ORDER BY IdObra";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.SmallDateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Cemento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Cemento", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.SmallDateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Cemento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Cemento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cemento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Cemento", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Cemento] WHERE (([IdObra] = @Original_IdObra) AND ([Fecha] = @Origin" +
    "al_Fecha) AND ((@IsNull_Cemento = 1 AND [Cemento] IS NULL) OR ([Cemento] = @Orig" +
    "inal_Cemento)))";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cemento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Cemento", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDACemento
            // 
            this.sqlDACemento.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDACemento.InsertCommand = this.sqlInsertCommand1;
            this.sqlDACemento.SelectCommand = this.sqlSelectCommand1;
            this.sqlDACemento.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Cemento", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Cemento", "Cemento")})});
            this.sqlDACemento.UpdateCommand = this.sqlUpdateCommand1;
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
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cemento
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(648, 289);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDACemento;
            this.dsGeneral = this.dsCemento;
            this.Name = "Cemento";
            this.NombreTabla = "Cemento";
            this.Text = "br";
            this.Load += new System.EventHandler(this.Cemento_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Cemento_Load(object sender, System.EventArgs e)
		{
            buscaBtn1.Catalogo = this;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
		}

		private void dtpHri_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }
	}
}
