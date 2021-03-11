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
	/// Descripción breve de Secante.
	/// </summary>
	public class Secante : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Data.SqlClient.SqlDataAdapter sqlDASecante;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsSecante dsSecante1;
        private LancNeo.dsBusObra dsBusObra1;
        private LancNeo.dsLaboratorista dsLaboratorista1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.Panel panel2;
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
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dtpFensaye;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private LancNeo.dsConcretera dsConcretera1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATAgregado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
        private LancNeo.dsTipo dsTipo1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
        private LancNeo.dsAgregado dsAgregado1;
		private System.Data.SqlClient.SqlDataAdapter sqlDARes;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private System.Data.SqlClient.SqlDataAdapter sqlDATipo;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand11;
		private System.Data.SqlClient.SqlDataAdapter sqlDASecanteRes;
        private LancNeo.dsCoPlanta dsCoPlanta1;
        private LancNeo.dsGrado dsGrado1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAGrado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
		private System.Windows.Forms.Panel panel3;
		private System.Data.SqlClient.SqlDataAdapter sqlDASecantePro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private DataGridView dgSecanteP;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MuestraP;
        private DataGridViewTextBoxColumn promedioPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promedioRDataGridViewTextBoxColumn;
        private DataGridView dgSecante;
        private DataGridViewTextBoxColumn revenimientoDataGridViewTextBoxColumn;
        private dsResSec dsResSec1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idCroncreteraDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn IdPlanta;
        private DataGridViewComboBoxColumn ResistenciaKG;
        private DataGridViewComboBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agregadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Rev;
        private DataGridViewComboBoxColumn gradoDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idAgregadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idRemisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revObtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn cilindroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resistenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obtenidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promedioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requeridoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ejesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edifDataGridViewTextBoxColumn;
        private TextBox txtUsrMov;
        private Label label59;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Secante()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secante));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlDASecante = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsSecante1 = new LancNeo.dsSecante();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dtpFensaye = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.cmbNoeco = new System.Windows.Forms.ComboBox();
            this.dtpFinforme = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDASecanteRes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.sqlDATAgregado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.dsTipo1 = new LancNeo.dsTipo();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsAgregado1 = new LancNeo.dsAgregado();
            this.sqlDARes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATipo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand11 = new System.Data.SqlClient.SqlCommand();
            this.dsCoPlanta1 = new LancNeo.dsCoPlanta();
            this.dsGrado1 = new LancNeo.dsGrado();
            this.sqlDAGrado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgSecanteP = new System.Windows.Forms.DataGridView();
            this.MuestraP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlDASecantePro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dgSecante = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCroncreteraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdPlanta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ResistenciaKG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsResSec1 = new LancNeo.dsResSec();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.agregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idAgregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idRemisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revObtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cilindroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtenidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requeridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecante1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrado1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSecanteP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSecante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResSec1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 591);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1018, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1018, 64);
            // 
            // sqlDASecante
            // 
            this.sqlDASecante.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDASecante.InsertCommand = this.sqlInsertCommand1;
            this.sqlDASecante.SelectCommand = this.sqlSelectCommand1;
            this.sqlDASecante.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Secante", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("PromedioP", "PromedioP"),
                        new System.Data.Common.DataColumnMapping("PromedioR", "PromedioR"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDASecante.UpdateCommand = this.sqlUpdateCommand1;
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Fensaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fensaye", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Finforme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PromedioP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PromedioP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PromedioP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PromedioR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PromedioR", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PromedioR", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioR", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.SmallDateTime, 0, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.SmallDateTime, 0, "Finforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@PromedioP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioP", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PromedioR", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioR", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
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
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.SmallDateTime, 0, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.SmallDateTime, 0, "Finforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@PromedioP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioP", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PromedioR", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioR", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConsObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fensaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fensaye", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Finforme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PromedioP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PromedioP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PromedioP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PromedioR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PromedioR", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PromedioR", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioR", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // dsSecante1
            // 
            this.dsSecante1.DataSetName = "dsSecante";
            this.dsSecante1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsSecante1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.dtpFensaye);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
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
            this.panel2.Location = new System.Drawing.Point(2, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 160);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsSecante1.Secante;
            this.buscaBtn1.ForeColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(194, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 34;
            // 
            // dtpFensaye
            // 
            this.dtpFensaye.CustomFormat = "dd/MM/yyyy";
            this.dtpFensaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.Fensaye", true));
            this.dtpFensaye.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFensaye.Location = new System.Drawing.Point(362, 32);
            this.dtpFensaye.Name = "dtpFensaye";
            this.dtpFensaye.Size = new System.Drawing.Size(84, 20);
            this.dtpFensaye.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fecha ensaye:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.PromedioR", true));
            this.textBox2.Location = new System.Drawing.Point(546, 32);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "textBox3";
            this.textBox2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Requerido:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.PromedioP", true));
            this.textBox1.Location = new System.Drawing.Point(546, 8);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "textBox3";
            this.textBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Promedio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Visible = false;
            // 
            // txtObserva
            // 
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.Observaciones", true));
            this.txtObserva.Location = new System.Drawing.Point(362, 80);
            this.txtObserva.MaxLength = 512;
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserva.Size = new System.Drawing.Size(394, 68);
            this.txtObserva.TabIndex = 10;
            this.txtObserva.Text = "textBox5";
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(102, 80);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(66, 20);
            this.txtSemana.TabIndex = 4;
            this.txtSemana.Text = "textBox3";
            // 
            // cmbNoeco
            // 
            this.cmbNoeco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSecante1, "Secante.NoEco", true));
            this.cmbNoeco.DataSource = this.dsLaboratorista1.Laboratorista;
            this.cmbNoeco.DisplayMember = "Laboratorista";
            this.cmbNoeco.Location = new System.Drawing.Point(362, 56);
            this.cmbNoeco.Name = "cmbNoeco";
            this.cmbNoeco.Size = new System.Drawing.Size(392, 21);
            this.cmbNoeco.TabIndex = 7;
            this.cmbNoeco.ValueMember = "NoEco";
            // 
            // dtpFinforme
            // 
            this.dtpFinforme.CustomFormat = "dd/MM/yyyy";
            this.dtpFinforme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.Finforme", true));
            this.dtpFinforme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinforme.Location = new System.Drawing.Point(362, 8);
            this.dtpFinforme.Name = "dtpFinforme";
            this.dtpFinforme.Size = new System.Drawing.Size(84, 20);
            this.dtpFinforme.TabIndex = 5;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.ConsObra", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(102, 56);
            this.txtConsecutivo.MaxLength = 4;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
            this.txtConsecutivo.TabIndex = 3;
            this.txtConsecutivo.Text = "textBox2";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSecante1, "Secante.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(102, 32);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 2;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(102, 8);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Observaciones:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Semana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ensayado por:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha informe:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Consecutivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDASecanteRes
            // 
            this.sqlDASecanteRes.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDASecanteRes.InsertCommand = this.sqlInsertCommand2;
            this.sqlDASecanteRes.SelectCommand = this.sqlSelectCommand2;
            this.sqlDASecanteRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SecanteRes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("IdCroncretera", "IdCroncretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimiento", "Revenimiento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("IdRemision", "IdRemision"),
                        new System.Data.Common.DataColumnMapping("RevObt", "RevObt"),
                        new System.Data.Common.DataColumnMapping("Cilindro", "Cilindro"),
                        new System.Data.Common.DataColumnMapping("Edad", "Edad"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("Obtenido", "Obtenido"),
                        new System.Data.Common.DataColumnMapping("Promedio", "Promedio"),
                        new System.Data.Common.DataColumnMapping("Requerido", "Requerido"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif")})});
            this.sqlDASecanteRes.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cilindro", System.Data.SqlDbType.NVarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cilindro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Edif", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ejes", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdAgregado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdCroncretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCroncretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPlanta", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdRemision", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdRemision", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Obtenido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Obtenido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Promedio", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Promedio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Requerido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Requerido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resistencia", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Resistencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKG", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "ResistenciaKG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RevObt", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevObt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Revenimiento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revenimiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 4, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@IdCroncretera", System.Data.SqlDbType.NVarChar, 10, "IdCroncretera"),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.NVarChar, 10, "IdPlanta"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "ResistenciaKG", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Int, 4, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimiento", System.Data.SqlDbType.Int, 4, "Revenimiento"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 50, "Grado"),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@IdRemision", System.Data.SqlDbType.NVarChar, 10, "IdRemision"),
            new System.Data.SqlClient.SqlParameter("@RevObt", System.Data.SqlDbType.Int, 4, "RevObt"),
            new System.Data.SqlClient.SqlParameter("@Cilindro", System.Data.SqlDbType.NVarChar, 4, "Cilindro"),
            new System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Int, 4, "Masa"),
            new System.Data.SqlClient.SqlParameter("@Resistencia", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Resistencia", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Obtenido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Obtenido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Promedio", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Promedio", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Requerido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Requerido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Elemento", System.Data.SqlDbType.NVarChar, 20, "Elemento"),
            new System.Data.SqlClient.SqlParameter("@Ejes", System.Data.SqlDbType.NVarChar, 20, "Ejes"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 5, "Nivel"),
            new System.Data.SqlClient.SqlParameter("@Edif", System.Data.SqlDbType.NVarChar, 6, "Edif")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.VarChar, 10, "FOLIO")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 4, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@IdCroncretera", System.Data.SqlDbType.NVarChar, 10, "IdCroncretera"),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.NVarChar, 10, "IdPlanta"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "ResistenciaKG", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Int, 4, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimiento", System.Data.SqlDbType.Int, 4, "Revenimiento"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 50, "Grado"),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 4, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@IdRemision", System.Data.SqlDbType.NVarChar, 10, "IdRemision"),
            new System.Data.SqlClient.SqlParameter("@RevObt", System.Data.SqlDbType.Int, 4, "RevObt"),
            new System.Data.SqlClient.SqlParameter("@Cilindro", System.Data.SqlDbType.NVarChar, 4, "Cilindro"),
            new System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Int, 4, "Masa"),
            new System.Data.SqlClient.SqlParameter("@Resistencia", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Resistencia", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Obtenido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Obtenido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Promedio", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Promedio", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Requerido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Requerido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Elemento", System.Data.SqlDbType.NVarChar, 20, "Elemento"),
            new System.Data.SqlClient.SqlParameter("@Ejes", System.Data.SqlDbType.NVarChar, 20, "Ejes"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 5, "Nivel"),
            new System.Data.SqlClient.SqlParameter("@Edif", System.Data.SqlDbType.NVarChar, 6, "Edif"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cilindro", System.Data.SqlDbType.NVarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cilindro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Edif", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ejes", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdAgregado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdCroncretera", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCroncretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPlanta", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdRemision", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdRemision", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Obtenido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Obtenido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Promedio", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Promedio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Requerido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Requerido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resistencia", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(9)), ((byte)(3)), "Resistencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKG", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "ResistenciaKG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RevObt", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevObt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Revenimiento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revenimiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null)});
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDATAgregado
            // 
            this.sqlDATAgregado.SelectCommand = this.sqlSelectCommand9;
            this.sqlDATAgregado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Agregado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo")})});
            // 
            // sqlSelectCommand9
            // 
            this.sqlSelectCommand9.CommandText = "SELECT IdAgregado, Agregado, Tipo FROM Agregado";
            this.sqlSelectCommand9.Connection = this.sqlConn;
            // 
            // dsTipo1
            // 
            this.dsTipo1.DataSetName = "dsTipo";
            this.dsTipo1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAPLanta
            // 
            this.sqlDAPLanta.SelectCommand = this.sqlSelectCommand6;
            this.sqlDAPLanta.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Planta", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("Planta", "Planta")})});
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = "SELECT DISTINCT RTRIM(LTRIM(STR(IdPlanta))) AS IdPlanta\r\nFROM            Planta\r\n" +
    "ORDER BY IdPlanta";
            this.sqlSelectCommand6.Connection = this.sqlConn;
            // 
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.SelectCommand = this.sqlCommand2;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera ORDER BY IdConcretera";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // dsAgregado1
            // 
            this.dsAgregado1.DataSetName = "dsAgregado";
            this.dsAgregado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAgregado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlSelectCommand7.CommandText = "SELECT        CONVERT(decimal(10, 3), ResistenciaKG) AS ResistenciaKG, Resistenci" +
    "aMPa\r\nFROM            Resistencia\r\nORDER BY ResistenciaKG + 0";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // sqlDATipo
            // 
            this.sqlDATipo.SelectCommand = this.sqlSelectCommand11;
            this.sqlDATipo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo")})});
            // 
            // sqlSelectCommand11
            // 
            this.sqlSelectCommand11.CommandText = "SELECT Tipo, DesTipo FROM Tipo ORDER BY Tipo";
            this.sqlSelectCommand11.Connection = this.sqlConn;
            // 
            // dsCoPlanta1
            // 
            this.dsCoPlanta1.DataSetName = "dsCoPlanta";
            this.dsCoPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsCoPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsGrado1
            // 
            this.dsGrado1.DataSetName = "dsGrado";
            this.dsGrado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsGrado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAGrado
            // 
            this.sqlDAGrado.SelectCommand = this.sqlSelectCommand8;
            this.sqlDAGrado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grado", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Porcentaje", "Porcentaje"),
                        new System.Data.Common.DataColumnMapping("Pruebas", "Pruebas"),
                        new System.Data.Common.DataColumnMapping("Porpromedio", "Porpromedio"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("Constante", "Constante")})});
            // 
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = "SELECT Grado, Porcentaje, Pruebas, Porpromedio, Consecutivo, Constante FROM Grado" +
    "";
            this.sqlSelectCommand8.Connection = this.sqlConn;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dgSecanteP);
            this.panel3.Location = new System.Drawing.Point(778, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 160);
            this.panel3.TabIndex = 22;
            // 
            // dgSecanteP
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSecanteP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgSecanteP.AutoGenerateColumns = false;
            this.dgSecanteP.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSecanteP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgSecanteP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSecanteP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MuestraP,
            this.promedioPDataGridViewTextBoxColumn,
            this.promedioRDataGridViewTextBoxColumn});
            this.dgSecanteP.DataMember = "Secante.SecanteSecantePro";
            this.dgSecanteP.DataSource = this.dsSecante1;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSecanteP.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgSecanteP.Location = new System.Drawing.Point(0, 0);
            this.dgSecanteP.Name = "dgSecanteP";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSecanteP.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgSecanteP.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgSecanteP.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSecanteP.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgSecanteP.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgSecanteP.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSecanteP.Size = new System.Drawing.Size(232, 156);
            this.dgSecanteP.TabIndex = 0;
            // 
            // MuestraP
            // 
            this.MuestraP.DataPropertyName = "Muestra";
            this.MuestraP.HeaderText = "Muestra";
            this.MuestraP.MaxInputLength = 7;
            this.MuestraP.Name = "MuestraP";
            this.MuestraP.Width = 50;
            // 
            // promedioPDataGridViewTextBoxColumn
            // 
            this.promedioPDataGridViewTextBoxColumn.DataPropertyName = "PromedioP";
            this.promedioPDataGridViewTextBoxColumn.HeaderText = "PromedioP";
            this.promedioPDataGridViewTextBoxColumn.MaxInputLength = 13;
            this.promedioPDataGridViewTextBoxColumn.Name = "promedioPDataGridViewTextBoxColumn";
            this.promedioPDataGridViewTextBoxColumn.Width = 58;
            // 
            // promedioRDataGridViewTextBoxColumn
            // 
            this.promedioRDataGridViewTextBoxColumn.DataPropertyName = "PromedioR";
            this.promedioRDataGridViewTextBoxColumn.HeaderText = "PromedioR";
            this.promedioRDataGridViewTextBoxColumn.MaxInputLength = 13;
            this.promedioRDataGridViewTextBoxColumn.Name = "promedioRDataGridViewTextBoxColumn";
            this.promedioRDataGridViewTextBoxColumn.Width = 63;
            // 
            // sqlDASecantePro
            // 
            this.sqlDASecantePro.DeleteCommand = this.sqlDeleteCommand3;
            this.sqlDASecantePro.InsertCommand = this.sqlInsertCommand3;
            this.sqlDASecantePro.SelectCommand = this.sqlSelectCommand3;
            this.sqlDASecantePro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SecantePro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("PromedioP", "PromedioP"),
                        new System.Data.Common.DataColumnMapping("PromedioR", "PromedioR")})});
            this.sqlDASecantePro.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlConn;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PromedioP", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PromedioR", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioR", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlConn;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 4, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@PromedioP", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioP", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PromedioR", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioR", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT FOLIO, Muestra, PromedioP, PromedioR FROM SecantePro WHERE (FOLIO = @Folio" +
    ")";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.VarChar, 10, "FOLIO")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlConn;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 4, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@PromedioP", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioP", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PromedioR", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioR", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PromedioP", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PromedioR", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(3)), "PromedioR", System.Data.DataRowVersion.Original, null)});
            // 
            // dgSecante
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSecante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgSecante.AutoGenerateColumns = false;
            this.dgSecante.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSecante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgSecante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSecante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.fechaDataGridViewTextBoxColumn,
            this.idCroncreteraDataGridViewTextBoxColumn,
            this.IdPlanta,
            this.ResistenciaKG,
            this.tipoDataGridViewTextBoxColumn,
            this.agregadoDataGridViewTextBoxColumn,
            this.Rev,
            this.gradoDataGridViewTextBoxColumn,
            this.idAgregadoDataGridViewTextBoxColumn,
            this.idRemisionDataGridViewTextBoxColumn,
            this.revObtDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.cilindroDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.resistenciaDataGridViewTextBoxColumn,
            this.obtenidoDataGridViewTextBoxColumn,
            this.promedioDataGridViewTextBoxColumn,
            this.requeridoDataGridViewTextBoxColumn,
            this.elementoDataGridViewTextBoxColumn,
            this.ejesDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.edifDataGridViewTextBoxColumn});
            this.dgSecante.DataMember = "Secante.SecanteSecanteRes";
            this.dgSecante.DataSource = this.dsSecante1;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSecante.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgSecante.Location = new System.Drawing.Point(2, 264);
            this.dgSecante.Name = "dgSecante";
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSecante.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgSecante.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgSecante.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSecante.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgSecante.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgSecante.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSecante.Size = new System.Drawing.Size(1012, 320);
            this.dgSecante.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FOLIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "FOLIO";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 0;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 67;
            // 
            // idCroncreteraDataGridViewTextBoxColumn
            // 
            this.idCroncreteraDataGridViewTextBoxColumn.DataPropertyName = "IdCroncretera";
            this.idCroncreteraDataGridViewTextBoxColumn.DataSource = this.dsConcretera1;
            this.idCroncreteraDataGridViewTextBoxColumn.DisplayMember = "Concretera.Concretera";
            this.idCroncreteraDataGridViewTextBoxColumn.HeaderText = "Concretera";
            this.idCroncreteraDataGridViewTextBoxColumn.Name = "idCroncreteraDataGridViewTextBoxColumn";
            this.idCroncreteraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCroncreteraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCroncreteraDataGridViewTextBoxColumn.ValueMember = "Concretera.IdConcretera";
            this.idCroncreteraDataGridViewTextBoxColumn.Width = 67;
            // 
            // IdPlanta
            // 
            this.IdPlanta.DataPropertyName = "IdPlanta";
            this.IdPlanta.DataSource = this.dsCoPlanta1;
            this.IdPlanta.DisplayMember = "Planta.IdPlanta";
            this.IdPlanta.HeaderText = "IdPlanta";
            this.IdPlanta.Name = "IdPlanta";
            this.IdPlanta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdPlanta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdPlanta.ValueMember = "Planta.IdPlanta";
            this.IdPlanta.Width = 48;
            // 
            // ResistenciaKG
            // 
            this.ResistenciaKG.DataPropertyName = "ResistenciaKG";
            this.ResistenciaKG.DataSource = this.dsResSec1;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = null;
            this.ResistenciaKG.DefaultCellStyle = dataGridViewCellStyle18;
            this.ResistenciaKG.DisplayMember = "Resistencia.ResistenciaKG";
            this.ResistenciaKG.HeaderText = "ResKG";
            this.ResistenciaKG.Name = "ResistenciaKG";
            this.ResistenciaKG.ValueMember = "Resistencia.ResistenciaKG";
            this.ResistenciaKG.Width = 50;
            // 
            // dsResSec1
            // 
            this.dsResSec1.DataSetName = "dsResSec";
            this.dsResSec1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.DataSource = this.dsTipo1;
            this.tipoDataGridViewTextBoxColumn.DisplayMember = "Tipo.DesTipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipoDataGridViewTextBoxColumn.ValueMember = "Tipo.Tipo";
            this.tipoDataGridViewTextBoxColumn.Width = 64;
            // 
            // agregadoDataGridViewTextBoxColumn
            // 
            this.agregadoDataGridViewTextBoxColumn.DataPropertyName = "Agregado";
            this.agregadoDataGridViewTextBoxColumn.HeaderText = "TAM";
            this.agregadoDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.agregadoDataGridViewTextBoxColumn.Name = "agregadoDataGridViewTextBoxColumn";
            this.agregadoDataGridViewTextBoxColumn.Width = 30;
            // 
            // Rev
            // 
            this.Rev.DataPropertyName = "Revenimiento";
            this.Rev.HeaderText = "Rev";
            this.Rev.MaxInputLength = 3;
            this.Rev.Name = "Rev";
            this.Rev.Width = 25;
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "Grado";
            this.gradoDataGridViewTextBoxColumn.DataSource = this.dsGrado1;
            this.gradoDataGridViewTextBoxColumn.DisplayMember = "Grado.Grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "Gr";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            this.gradoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gradoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gradoDataGridViewTextBoxColumn.ValueMember = "Grado.Grado";
            this.gradoDataGridViewTextBoxColumn.Width = 45;
            // 
            // idAgregadoDataGridViewTextBoxColumn
            // 
            this.idAgregadoDataGridViewTextBoxColumn.DataPropertyName = "IdAgregado";
            this.idAgregadoDataGridViewTextBoxColumn.DataSource = this.dsAgregado1;
            this.idAgregadoDataGridViewTextBoxColumn.DisplayMember = "Agregado.Tipo";
            this.idAgregadoDataGridViewTextBoxColumn.HeaderText = "Agregado";
            this.idAgregadoDataGridViewTextBoxColumn.Name = "idAgregadoDataGridViewTextBoxColumn";
            this.idAgregadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idAgregadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idAgregadoDataGridViewTextBoxColumn.ValueMember = "Agregado.IdAgregado";
            this.idAgregadoDataGridViewTextBoxColumn.Width = 65;
            // 
            // idRemisionDataGridViewTextBoxColumn
            // 
            this.idRemisionDataGridViewTextBoxColumn.DataPropertyName = "IdRemision";
            this.idRemisionDataGridViewTextBoxColumn.HeaderText = "Remisión";
            this.idRemisionDataGridViewTextBoxColumn.MaxInputLength = 12;
            this.idRemisionDataGridViewTextBoxColumn.Name = "idRemisionDataGridViewTextBoxColumn";
            this.idRemisionDataGridViewTextBoxColumn.Width = 55;
            // 
            // revObtDataGridViewTextBoxColumn
            // 
            this.revObtDataGridViewTextBoxColumn.DataPropertyName = "RevObt";
            this.revObtDataGridViewTextBoxColumn.HeaderText = "RevObt";
            this.revObtDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.revObtDataGridViewTextBoxColumn.Name = "revObtDataGridViewTextBoxColumn";
            this.revObtDataGridViewTextBoxColumn.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Muestra";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mtra";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 30;
            // 
            // cilindroDataGridViewTextBoxColumn
            // 
            this.cilindroDataGridViewTextBoxColumn.DataPropertyName = "Cilindro";
            this.cilindroDataGridViewTextBoxColumn.HeaderText = "Cil";
            this.cilindroDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.cilindroDataGridViewTextBoxColumn.Name = "cilindroDataGridViewTextBoxColumn";
            this.cilindroDataGridViewTextBoxColumn.Width = 30;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.Width = 35;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.Width = 35;
            // 
            // resistenciaDataGridViewTextBoxColumn
            // 
            this.resistenciaDataGridViewTextBoxColumn.DataPropertyName = "Resistencia";
            this.resistenciaDataGridViewTextBoxColumn.HeaderText = "Resistencia";
            this.resistenciaDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.resistenciaDataGridViewTextBoxColumn.Name = "resistenciaDataGridViewTextBoxColumn";
            this.resistenciaDataGridViewTextBoxColumn.Width = 35;
            // 
            // obtenidoDataGridViewTextBoxColumn
            // 
            this.obtenidoDataGridViewTextBoxColumn.DataPropertyName = "Obtenido";
            this.obtenidoDataGridViewTextBoxColumn.HeaderText = "Obtenido";
            this.obtenidoDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.obtenidoDataGridViewTextBoxColumn.Name = "obtenidoDataGridViewTextBoxColumn";
            this.obtenidoDataGridViewTextBoxColumn.Width = 35;
            // 
            // promedioDataGridViewTextBoxColumn
            // 
            this.promedioDataGridViewTextBoxColumn.DataPropertyName = "Promedio";
            this.promedioDataGridViewTextBoxColumn.HeaderText = "Promedio";
            this.promedioDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.promedioDataGridViewTextBoxColumn.Name = "promedioDataGridViewTextBoxColumn";
            this.promedioDataGridViewTextBoxColumn.Width = 35;
            // 
            // requeridoDataGridViewTextBoxColumn
            // 
            this.requeridoDataGridViewTextBoxColumn.DataPropertyName = "Requerido";
            this.requeridoDataGridViewTextBoxColumn.HeaderText = "Requerido";
            this.requeridoDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.requeridoDataGridViewTextBoxColumn.Name = "requeridoDataGridViewTextBoxColumn";
            this.requeridoDataGridViewTextBoxColumn.Width = 40;
            // 
            // elementoDataGridViewTextBoxColumn
            // 
            this.elementoDataGridViewTextBoxColumn.DataPropertyName = "Elemento";
            this.elementoDataGridViewTextBoxColumn.HeaderText = "Elemento";
            this.elementoDataGridViewTextBoxColumn.Name = "elementoDataGridViewTextBoxColumn";
            this.elementoDataGridViewTextBoxColumn.Width = 95;
            // 
            // ejesDataGridViewTextBoxColumn
            // 
            this.ejesDataGridViewTextBoxColumn.DataPropertyName = "Ejes";
            this.ejesDataGridViewTextBoxColumn.HeaderText = "Ejes";
            this.ejesDataGridViewTextBoxColumn.Name = "ejesDataGridViewTextBoxColumn";
            this.ejesDataGridViewTextBoxColumn.Width = 75;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.Width = 45;
            // 
            // edifDataGridViewTextBoxColumn
            // 
            this.edifDataGridViewTextBoxColumn.DataPropertyName = "Edif";
            this.edifDataGridViewTextBoxColumn.HeaderText = "Edif";
            this.edifDataGridViewTextBoxColumn.Name = "edifDataGridViewTextBoxColumn";
            this.edifDataGridViewTextBoxColumn.Width = 25;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSecante1, "Secante.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(102, 128);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 70;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Red;
            this.label59.Location = new System.Drawing.Point(41, 132);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(54, 13);
            this.label59.TabIndex = 69;
            this.label59.Text = "Usuario:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Secante
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1018, 613);
            this.Controls.Add(this.dgSecante);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDASecante;
            this.dsGeneral = this.dsSecante1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Secante";
            this.NombreTabla = "Secante";
            this.Text = "Secante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Secante_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.dgSecante, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSecante1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrado1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSecanteP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSecante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResSec1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Secante_Load(object sender, System.EventArgs e)
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
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
			sqlDAPLanta.Fill(dsCoPlanta1,"PLanta");
			sqlDARes.Fill(dsResSec1,"Resistencia");
			sqlDAGrado.Fill(dsGrado1,"Grado");
			sqlDATAgregado.Fill(dsAgregado1,"Agregado");
			sqlDATipo.Fill(dsTipo1,"Tipo");
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbIdObra.SelectedIndex = -1;
			cmbNoeco.SelectedIndex = -1;
			dtpFinforme.Value = DateTime.Now.AddDays(1);
			dtpFinforme.Value = DateTime.Today; 
			dtpFensaye.Value = DateTime.Now.AddDays(1);
			dtpFensaye.Value = DateTime.Today; 
		}
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
                // Intente actualizar el origen de datos.
                txtUsrMov.Text = IdUsuario;
                base.BindingContext[dsSecante1,"Secante"].Position = this.BindingContext[dsSecante1,"Secante"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsSecante1.Tables["SecanteRes"].Clear();
			sqlDASecanteRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDASecanteRes.Fill(dsSecante1,"SecanteRes");
			dsSecante1.Tables["SecantePro"].Clear();
			sqlDASecantePro.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDASecantePro.Fill(dsSecante1,"SecantePro");
		}
		public override void LoadDataSet()
		{
			base.LoadDataSet();
			dsSecante1.Tables["SecanteRes"].Clear();
			sqlDASecanteRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDASecanteRes.Fill(dsSecante1,"SecanteRes");
			dsSecante1.Tables["SecantePro"].Clear();
			sqlDASecantePro.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDASecantePro.Fill(dsSecante1,"SecantePro");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            LancNeo.dsSecante objDataSetChanges = new LancNeo.dsSecante();
			// Detener las ediciones actuales.
			this.BindingContext[dsSecante1,"Secante"].EndCurrentEdit();
			this.BindingContext[dsSecante1,"SecanteRes"].EndCurrentEdit();
			this.BindingContext[dsSecante1,"SecantePro"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
            objDataSetChanges = ((LancNeo.dsSecante)(dsSecante1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsSecante1.Merge(objDataSetChanges);
					dsSecante1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsSecante ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDASecante.Update(ChangedRows);
					sqlDASecanteRes.Update(ChangedRows);
					sqlDASecantePro.Update(ChangedRows);
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
			dsSecante1.Tables["SecanteRes"].Clear();
			sqlDASecanteRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDASecanteRes.Fill(dsSecante1,"SecanteRes");
			dsSecante1.Tables["SecantePro"].Clear();
			sqlDASecantePro.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDASecantePro.Fill(dsSecante1,"SecantePro");
		}
	}
}
