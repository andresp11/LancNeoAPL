using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de CompactaMdor.
	/// </summary>
	public class CompactaMdor : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Data.SqlClient.SqlDataAdapter sqlDACompactaMdor;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsCompactaMdor dsCompactaMdor1;
		private System.Windows.Forms.Panel panel2;
        private LancNeo.dsLaboratorista dsLaboratorista1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
        private LancNeo.dsBusObra dsBusObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox txtObserva;
		private System.Windows.Forms.TextBox txtSemana;
		private System.Windows.Forms.ComboBox cmbNoeco;
		private System.Windows.Forms.DateTimePicker dtpFinforme;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlDataAdapter sqlDACompactaRes;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private DataGridView dgCompacta;
        protected tbBtn tbBtn1;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cALADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lOCALIZACIONDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Etapa;
        private DataGridViewTextBoxColumn cAPADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profunCapaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aguaOptimaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ahuaLugarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masaSecaMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masaSecaLugarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obtenidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promedioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requeridoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Observaciones;
        private TextBox txtUsrMov;
        private Label label59;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CompactaMdor()
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompactaMdor));
            this.sqlDACompactaMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsCompactaMdor1 = new LancNeo.dsCompactaMdor();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.cmbNoeco = new System.Windows.Forms.ComboBox();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.dtpFinforme = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACompactaRes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgCompacta = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALIZACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profunCapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aguaOptimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahuaLugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaSecaMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaSecaLugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtenidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requeridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompactaMdor1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompacta)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 645);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1022, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Controls.Add(this.tbBtn1);
            this.panelToolBar.Size = new System.Drawing.Size(1022, 64);
            this.panelToolBar.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnDeshacer, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnPrimero, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnEliminar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnVistaPrevia, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnAnterior, 0);
            this.panelToolBar.Controls.SetChildIndex(this.tbBtn1, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnUltimo, 0);
            // 
            // sqlDACompactaMdor
            // 
            this.sqlDACompactaMdor.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDACompactaMdor.InsertCommand = this.sqlInsertCommand1;
            this.sqlDACompactaMdor.SelectCommand = this.sqlSelectCommand1;
            this.sqlDACompactaMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompactaMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FInforme", "FInforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDACompactaMdor.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConsObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FInforme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FInforme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FInforme", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FInforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 0, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@FInforme", System.Data.SqlDbType.SmallDateTime, 0, "FInforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     FOLIO, IdObra, ConsObra, FInforme, NoEco, Semana, Observaciones, IdUsu" +
    "ario\r\nFROM         CompactaMdor";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 0, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@FInforme", System.Data.SqlDbType.SmallDateTime, 0, "FInforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConsObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FInforme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FInforme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FInforme", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FInforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // dsCompactaMdor1
            // 
            this.dsCompactaMdor1.DataSetName = "dsCompactaMdor";
            this.dsCompactaMdor1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsCompactaMdor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.txtObserva);
            this.panel2.Controls.Add(this.txtSemana);
            this.panel2.Controls.Add(this.cmbNoeco);
            this.panel2.Controls.Add(this.dtpFinforme);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 148);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsCompactaMdor1.CompactaMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(118, 6);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 35;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCompactaMdor1, "CompactaMdor.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(807, 10);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 68;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Red;
            this.label59.Location = new System.Drawing.Point(746, 14);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(54, 13);
            this.label59.TabIndex = 67;
            this.label59.Text = "Usuario:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObserva
            // 
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCompactaMdor1, "CompactaMdor.Observaciones", true));
            this.txtObserva.Location = new System.Drawing.Point(4, 72);
            this.txtObserva.MaxLength = 1024;
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserva.Size = new System.Drawing.Size(972, 68);
            this.txtObserva.TabIndex = 7;
            this.txtObserva.Text = "textBox5";
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCompactaMdor1, "CompactaMdor.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(648, 8);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(46, 20);
            this.txtSemana.TabIndex = 4;
            this.txtSemana.Text = "textBox3";
            // 
            // cmbNoeco
            // 
            this.cmbNoeco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCompactaMdor1, "CompactaMdor.NoEco", true));
            this.cmbNoeco.DataSource = this.dsLaboratorista1.Laboratorista;
            this.cmbNoeco.DisplayMember = "Laboratorista";
            this.cmbNoeco.Location = new System.Drawing.Point(288, 38);
            this.cmbNoeco.Name = "cmbNoeco";
            this.cmbNoeco.Size = new System.Drawing.Size(306, 21);
            this.cmbNoeco.TabIndex = 6;
            this.cmbNoeco.ValueMember = "NoEco";
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFinforme
            // 
            this.dtpFinforme.CustomFormat = "dd/MM/yyyy";
            this.dtpFinforme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCompactaMdor1, "CompactaMdor.FInforme", true));
            this.dtpFinforme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinforme.Location = new System.Drawing.Point(510, 8);
            this.dtpFinforme.Name = "dtpFinforme";
            this.dtpFinforme.Size = new System.Drawing.Size(84, 20);
            this.dtpFinforme.TabIndex = 3;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCompactaMdor1, "CompactaMdor.ConsObra", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(360, 8);
            this.txtConsecutivo.MaxLength = 4;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
            this.txtConsecutivo.TabIndex = 2;
            this.txtConsecutivo.Text = "textBox2";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCompactaMdor1, "CompactaMdor.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(220, 8);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCompactaMdor1, "CompactaMdor.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(50, 4);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 0;
            this.txtFolio.Text = "textBox1";
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Observaciones:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Semana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ensayado por:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha informe:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Consecutivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // sqlDALaboratorista
            // 
            this.sqlDALaboratorista.SelectCommand = this.sqlSelectCommand5;
            this.sqlDALaboratorista.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorista", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("IdNivel", "IdNivel"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT NoEco, LTRIM(STR(NoEco)) + \' \' + Laboratorista AS Laboratorista, IdZona, I" +
    "dNivel, Fechai FROM Laboratorista ORDER BY NoEco";
            this.sqlSelectCommand5.Connection = this.sqlConn;
            // 
            // sqlDACompactaRes
            // 
            this.sqlDACompactaRes.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDACompactaRes.InsertCommand = this.sqlInsertCommand2;
            this.sqlDACompactaRes.SelectCommand = this.sqlSelectCommand2;
            this.sqlDACompactaRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompactaRes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("CALA", "CALA"),
                        new System.Data.Common.DataColumnMapping("FECHA", "FECHA"),
                        new System.Data.Common.DataColumnMapping("LOCALIZACION", "LOCALIZACION"),
                        new System.Data.Common.DataColumnMapping("CAPA", "CAPA"),
                        new System.Data.Common.DataColumnMapping("ProfunCapa", "ProfunCapa"),
                        new System.Data.Common.DataColumnMapping("AguaOptima", "AguaOptima"),
                        new System.Data.Common.DataColumnMapping("AhuaLugar", "AhuaLugar"),
                        new System.Data.Common.DataColumnMapping("MasaSecaMax", "MasaSecaMax"),
                        new System.Data.Common.DataColumnMapping("MasaSecaLugar", "MasaSecaLugar"),
                        new System.Data.Common.DataColumnMapping("Obtenido", "Obtenido"),
                        new System.Data.Common.DataColumnMapping("Promedio", "Promedio"),
                        new System.Data.Common.DataColumnMapping("Requerido", "Requerido"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("Etapa", "Etapa")})});
            this.sqlDACompactaRes.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CALA", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CALA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FECHA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FECHA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FECHA", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FECHA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOCALIZACION", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOCALIZACION", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOCALIZACION", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOCALIZACION", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CAPA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CAPA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CAPA", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CAPA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProfunCapa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProfunCapa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProfunCapa", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProfunCapa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AguaOptima", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AguaOptima", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AguaOptima", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "AguaOptima", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AhuaLugar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AhuaLugar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AhuaLugar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "AhuaLugar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasaSecaMax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasaSecaMax", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasaSecaMax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaSecaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasaSecaLugar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasaSecaLugar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasaSecaLugar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaSecaLugar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Obtenido", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Obtenido", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Obtenido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Obtenido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Promedio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Promedio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Promedio", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Promedio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Requerido", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Requerido", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Requerido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Requerido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Etapa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Etapa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Etapa", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Etapa", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@CALA", System.Data.SqlDbType.Char, 0, "CALA"),
            new System.Data.SqlClient.SqlParameter("@FECHA", System.Data.SqlDbType.SmallDateTime, 0, "FECHA"),
            new System.Data.SqlClient.SqlParameter("@LOCALIZACION", System.Data.SqlDbType.NVarChar, 0, "LOCALIZACION"),
            new System.Data.SqlClient.SqlParameter("@CAPA", System.Data.SqlDbType.NVarChar, 0, "CAPA"),
            new System.Data.SqlClient.SqlParameter("@ProfunCapa", System.Data.SqlDbType.SmallInt, 0, "ProfunCapa"),
            new System.Data.SqlClient.SqlParameter("@AguaOptima", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "AguaOptima", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AhuaLugar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "AhuaLugar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MasaSecaMax", System.Data.SqlDbType.Int, 0, "MasaSecaMax"),
            new System.Data.SqlClient.SqlParameter("@MasaSecaLugar", System.Data.SqlDbType.Int, 0, "MasaSecaLugar"),
            new System.Data.SqlClient.SqlParameter("@Obtenido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Obtenido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Promedio", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Promedio", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Requerido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Requerido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Etapa", System.Data.SqlDbType.NChar, 0, "Etapa")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.Char, 10, "FOLIO")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@CALA", System.Data.SqlDbType.Char, 0, "CALA"),
            new System.Data.SqlClient.SqlParameter("@FECHA", System.Data.SqlDbType.SmallDateTime, 0, "FECHA"),
            new System.Data.SqlClient.SqlParameter("@LOCALIZACION", System.Data.SqlDbType.NVarChar, 0, "LOCALIZACION"),
            new System.Data.SqlClient.SqlParameter("@CAPA", System.Data.SqlDbType.NVarChar, 0, "CAPA"),
            new System.Data.SqlClient.SqlParameter("@ProfunCapa", System.Data.SqlDbType.SmallInt, 0, "ProfunCapa"),
            new System.Data.SqlClient.SqlParameter("@AguaOptima", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "AguaOptima", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AhuaLugar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "AhuaLugar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MasaSecaMax", System.Data.SqlDbType.Int, 0, "MasaSecaMax"),
            new System.Data.SqlClient.SqlParameter("@MasaSecaLugar", System.Data.SqlDbType.Int, 0, "MasaSecaLugar"),
            new System.Data.SqlClient.SqlParameter("@Obtenido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Obtenido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Promedio", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Promedio", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Requerido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Requerido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Etapa", System.Data.SqlDbType.NChar, 0, "Etapa"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CALA", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CALA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FECHA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FECHA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FECHA", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FECHA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOCALIZACION", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOCALIZACION", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOCALIZACION", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOCALIZACION", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CAPA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CAPA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CAPA", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CAPA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProfunCapa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProfunCapa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProfunCapa", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProfunCapa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AguaOptima", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AguaOptima", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AguaOptima", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "AguaOptima", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AhuaLugar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AhuaLugar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AhuaLugar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "AhuaLugar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasaSecaMax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasaSecaMax", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasaSecaMax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaSecaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasaSecaLugar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasaSecaLugar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasaSecaLugar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaSecaLugar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Obtenido", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Obtenido", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Obtenido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Obtenido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Promedio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Promedio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Promedio", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Promedio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Requerido", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Requerido", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Requerido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Requerido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Etapa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Etapa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Etapa", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Etapa", System.Data.DataRowVersion.Original, null)});
            // 
            // dgCompacta
            // 
            this.dgCompacta.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgCompacta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCompacta.AutoGenerateColumns = false;
            this.dgCompacta.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgCompacta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompacta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCompacta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompacta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.cALADataGridViewTextBoxColumn,
            this.lOCALIZACIONDataGridViewTextBoxColumn,
            this.Etapa,
            this.cAPADataGridViewTextBoxColumn,
            this.profunCapaDataGridViewTextBoxColumn,
            this.aguaOptimaDataGridViewTextBoxColumn,
            this.ahuaLugarDataGridViewTextBoxColumn,
            this.masaSecaMaxDataGridViewTextBoxColumn,
            this.masaSecaLugarDataGridViewTextBoxColumn,
            this.obtenidoDataGridViewTextBoxColumn,
            this.promedioDataGridViewTextBoxColumn,
            this.requeridoDataGridViewTextBoxColumn,
            this.Observaciones});
            this.dgCompacta.DataMember = "CompactaMdor.Compacta";
            this.dgCompacta.DataSource = this.dsCompactaMdor1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCompacta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCompacta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCompacta.Location = new System.Drawing.Point(0, 222);
            this.dgCompacta.Name = "dgCompacta";
            this.dgCompacta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgCompacta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgCompacta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgCompacta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            this.dgCompacta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCompacta.Size = new System.Drawing.Size(1022, 423);
            this.dgCompacta.TabIndex = 36;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            this.fOLIODataGridViewTextBoxColumn.Visible = false;
            this.fOLIODataGridViewTextBoxColumn.Width = 5;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.Width = 60;
            // 
            // cALADataGridViewTextBoxColumn
            // 
            this.cALADataGridViewTextBoxColumn.DataPropertyName = "CALA";
            this.cALADataGridViewTextBoxColumn.HeaderText = "CALA";
            this.cALADataGridViewTextBoxColumn.Name = "cALADataGridViewTextBoxColumn";
            this.cALADataGridViewTextBoxColumn.Width = 50;
            // 
            // lOCALIZACIONDataGridViewTextBoxColumn
            // 
            this.lOCALIZACIONDataGridViewTextBoxColumn.DataPropertyName = "LOCALIZACION";
            this.lOCALIZACIONDataGridViewTextBoxColumn.HeaderText = "LOCALIZACION";
            this.lOCALIZACIONDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.lOCALIZACIONDataGridViewTextBoxColumn.Name = "lOCALIZACIONDataGridViewTextBoxColumn";
            this.lOCALIZACIONDataGridViewTextBoxColumn.Width = 230;
            // 
            // Etapa
            // 
            this.Etapa.DataPropertyName = "Etapa";
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.MaxInputLength = 20;
            this.Etapa.Name = "Etapa";
            this.Etapa.Width = 130;
            // 
            // cAPADataGridViewTextBoxColumn
            // 
            this.cAPADataGridViewTextBoxColumn.DataPropertyName = "CAPA";
            this.cAPADataGridViewTextBoxColumn.HeaderText = "CAPA";
            this.cAPADataGridViewTextBoxColumn.Name = "cAPADataGridViewTextBoxColumn";
            this.cAPADataGridViewTextBoxColumn.Width = 55;
            // 
            // profunCapaDataGridViewTextBoxColumn
            // 
            this.profunCapaDataGridViewTextBoxColumn.DataPropertyName = "ProfunCapa";
            this.profunCapaDataGridViewTextBoxColumn.HeaderText = "Profun Capa";
            this.profunCapaDataGridViewTextBoxColumn.Name = "profunCapaDataGridViewTextBoxColumn";
            this.profunCapaDataGridViewTextBoxColumn.Width = 40;
            // 
            // aguaOptimaDataGridViewTextBoxColumn
            // 
            this.aguaOptimaDataGridViewTextBoxColumn.DataPropertyName = "AguaOptima";
            this.aguaOptimaDataGridViewTextBoxColumn.HeaderText = "Agua Optima";
            this.aguaOptimaDataGridViewTextBoxColumn.Name = "aguaOptimaDataGridViewTextBoxColumn";
            this.aguaOptimaDataGridViewTextBoxColumn.Width = 45;
            // 
            // ahuaLugarDataGridViewTextBoxColumn
            // 
            this.ahuaLugarDataGridViewTextBoxColumn.DataPropertyName = "AhuaLugar";
            this.ahuaLugarDataGridViewTextBoxColumn.HeaderText = "Agua Lugar";
            this.ahuaLugarDataGridViewTextBoxColumn.Name = "ahuaLugarDataGridViewTextBoxColumn";
            this.ahuaLugarDataGridViewTextBoxColumn.Width = 40;
            // 
            // masaSecaMaxDataGridViewTextBoxColumn
            // 
            this.masaSecaMaxDataGridViewTextBoxColumn.DataPropertyName = "MasaSecaMax";
            this.masaSecaMaxDataGridViewTextBoxColumn.HeaderText = "Masa SecaMax";
            this.masaSecaMaxDataGridViewTextBoxColumn.Name = "masaSecaMaxDataGridViewTextBoxColumn";
            this.masaSecaMaxDataGridViewTextBoxColumn.Width = 45;
            // 
            // masaSecaLugarDataGridViewTextBoxColumn
            // 
            this.masaSecaLugarDataGridViewTextBoxColumn.DataPropertyName = "MasaSecaLugar";
            this.masaSecaLugarDataGridViewTextBoxColumn.HeaderText = "Masa SecaLugar";
            this.masaSecaLugarDataGridViewTextBoxColumn.Name = "masaSecaLugarDataGridViewTextBoxColumn";
            this.masaSecaLugarDataGridViewTextBoxColumn.Width = 45;
            // 
            // obtenidoDataGridViewTextBoxColumn
            // 
            this.obtenidoDataGridViewTextBoxColumn.DataPropertyName = "Obtenido";
            this.obtenidoDataGridViewTextBoxColumn.HeaderText = "Obtenido";
            this.obtenidoDataGridViewTextBoxColumn.Name = "obtenidoDataGridViewTextBoxColumn";
            this.obtenidoDataGridViewTextBoxColumn.Width = 53;
            // 
            // promedioDataGridViewTextBoxColumn
            // 
            this.promedioDataGridViewTextBoxColumn.DataPropertyName = "Promedio";
            this.promedioDataGridViewTextBoxColumn.HeaderText = "Promedio";
            this.promedioDataGridViewTextBoxColumn.Name = "promedioDataGridViewTextBoxColumn";
            this.promedioDataGridViewTextBoxColumn.Width = 52;
            // 
            // requeridoDataGridViewTextBoxColumn
            // 
            this.requeridoDataGridViewTextBoxColumn.DataPropertyName = "Requerido";
            this.requeridoDataGridViewTextBoxColumn.HeaderText = "Requerido";
            this.requeridoDataGridViewTextBoxColumn.Name = "requeridoDataGridViewTextBoxColumn";
            this.requeridoDataGridViewTextBoxColumn.Width = 55;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MaxInputLength = 100;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 190;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(597, 0);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 56;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // CompactaMdor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1022, 667);
            this.Controls.Add(this.dgCompacta);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDACompactaMdor;
            this.dsGeneral = this.dsCompactaMdor1;
            this.Name = "CompactaMdor";
            this.NombreTabla = "CompactaMdor";
            this.Text = "Compactación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompactaMdor_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.dgCompacta, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCompactaMdor1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompacta)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void CompactaMdor_Load(object sender, System.EventArgs e)
		{
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
			sqlDABusObra.Fill(dsBusObra1,"Obra");
			sqlDALaboratorista.Fill(dsLaboratorista1,"Laboratorista");
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbIdObra.SelectedIndex = -1;
			cmbNoeco.SelectedIndex = -1;
			dtpFinforme.Value = DateTime.Now.AddDays(1);
			dtpFinforme.Value = DateTime.Today; 
		}
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			int renglon = 0;
			string folio = "";
			try 
			{
				// Intente actualizar el origen de datos.
                txtUsrMov.Text = IdUsuario;
				base.BindingContext[dsCompactaMdor1,"CompactaMdor"].Position = this.BindingContext[dsCompactaMdor1,"CompactaMdor"].Position;
				renglon = this.BindingContext[dsCompactaMdor1,"CompactaMdor"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}

			dsCompactaMdor1.Tables["CompactaRes"].Rows.Clear();
			sqlDACompactaRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDACompactaRes.Fill(dsCompactaMdor1,"CompactaRes");
			if(dsCompactaMdor1.CompactaRes.Rows.Count > 0)
			{
				folio = txtFolio.Text;
				this.LoadDataSet();
				renglon = -1;
				foreach(DataRow dr in dsCompactaMdor1.CompactaMdor )
				{
					try
					{					
						if(dr[0].ToString().ToUpper().Trim() == folio.ToUpper().Trim())
							break;
					}
					catch(Exception )
					{
						//MessageBox.Show(ex.Message);
					}
					finally
					{
						renglon++;
					}
				}
				base.BindingContext[dsCompactaMdor1,"CompactaMdor"].Position = renglon;
				base.dsGeneral_PositionChanged();
				dsCompactaMdor1.Tables["CompactaRes"].Rows.Clear();
				sqlDACompactaRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
				sqlDACompactaRes.Fill(dsCompactaMdor1,"CompactaRes");
			}
		}

		public override void LoadDataSet()
		{

			sqlDACompactaRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			base.LoadDataSet();
//			dgCompacta.SetDataBinding(dsCompactaMdor1, "CompactaMdor.Compacta");
//			string apl = dgCompacta.TableStyles.ToString();
			sqlDACompactaRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDACompactaRes.Fill(dsCompactaMdor1,"CompactaRes");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
            LancNeo.dsCompactaMdor objDataSetChanges = new LancNeo.dsCompactaMdor();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsCompactaMdor1,"CompactaMdor"].EndCurrentEdit();
			this.BindingContext[dsCompactaMdor1,"CompactaRes"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

            objDataSetChanges = ((LancNeo.dsCompactaMdor)(dsCompactaMdor1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsCompactaMdor1.Merge(objDataSetChanges);
					dsCompactaMdor1.AcceptChanges();
				}
				catch (System.Exception eUpdate) 
				{
					// Agregar aquí el código de control de errores.
					throw eUpdate;
				}
				// Agregar código para comprobar en el conjunto de datos devuelto los errores que se puedan haber
				// introducido en el error del objeto de fila.
			}

		}
		private void UpdateDataSource1(LancNeo.dsCompactaMdor ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDACompactaMdor.Update(ChangedRows);
					sqlDACompactaRes.Update(ChangedRows);
				}
			}
			catch (System.Exception updateException) 
			{
				// Agregar aquí el código de control de errores.
				throw updateException;
			}
			finally 
			{
				// Cerrar la conexión independientemente de si se inició una excepción o no.
				this.sqlConn.Close();
			}
		}

		private void txtFolio_TextChanged(object sender, System.EventArgs e)
		{
			dsCompactaMdor1.Tables["CompactaRes"].Rows.Clear();
			sqlDACompactaRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDACompactaRes.Fill(dsCompactaMdor1,"CompactaRes");
		}

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            DataSet _tmp = new DataSet();
            DataTable _dt = dsCompactaMdor1.Tables["CompactaRes"].Clone();
            _tmp.Tables.Add(_dt);
            int cuantos = dsCompactaMdor1.CompactaRes.Rows.Count;
            if (cuantos > 0)
            {
                int c = cuantos - 1;
                _tmp.Tables[0].ImportRow(dsCompactaMdor1.Tables["CompactaRes"].Rows[c]);
                _tmp.Tables[0].Rows[0]["Cala"] = "9Cambiar";
//                dsCompactaMdor1.CompactaRes.AddCompactaResRow( (_tmp.Tables[0].Rows[0][0], _tmp.Tables[0].Rows[0][1], _tmp.Tables[0].Rows[0][2], _tmp.Tables[0].Rows[0][3], _tmp.Tables[0].Rows[0][4], _tmp.Tables[0].Rows[0][5], _tmp.Tables[0].Rows[0][6], _tmp.Tables[0].Rows[0][7], _tmp.Tables[0].Rows[0][8], _tmp.Tables[0].Rows[0][9], _tmp.Tables[0].Rows[0][10], _tmp.Tables[0].Rows[0][11], _tmp.Tables[0].Rows[0][12], _tmp.Tables[0].Rows[0][13]);
                dsCompactaMdor1.Tables["CompactaRes"].Rows.Add(_tmp.Tables[0].Rows[0][0], _tmp.Tables[0].Rows[0][1], _tmp.Tables[0].Rows[0][2], _tmp.Tables[0].Rows[0][3], _tmp.Tables[0].Rows[0][4], _tmp.Tables[0].Rows[0][5], _tmp.Tables[0].Rows[0][6], _tmp.Tables[0].Rows[0][7], _tmp.Tables[0].Rows[0][8], _tmp.Tables[0].Rows[0][9], _tmp.Tables[0].Rows[0][10], _tmp.Tables[0].Rows[0][11], _tmp.Tables[0].Rows[0][12], _tmp.Tables[0].Rows[0][13]);
//                dsCompactaMdor1.CompactaRes.ImportRow(_tmp.Tables[0].Rows[0]);
//                dgCompacta.Rows.AddCopy(c);
                }
            //dgCompacta.Refresh();            
        }

	}
}
