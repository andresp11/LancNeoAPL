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
	/// <summary>Inner
	/// Descripción breve de Mustra.
	/// </summary>
	public class Mustra : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMuestreador;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMuestras;
		private LancNeo.dsMuestra dsMuestra1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblIdObra;
		private System.Data.SqlClient.SqlDataAdapter sqlDANoEco;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsLaboratorista dsLaboratorista1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusq;
		private System.Windows.Forms.ComboBox cmbNoEco;
		private System.Windows.Forms.Label lblVolSol;
		private System.Windows.Forms.TextBox txtVolsol;
		private System.Windows.Forms.Label lblTieExt;
		private System.Windows.Forms.TextBox txtTieExt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtVolumen;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNmuestras;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNcilidros;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtM1dv;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtM3dv;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtM3d;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtM7d;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtM14d;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txt28d;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtObserva;
		private LancNeo.dsBusMues dsBusMues1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private LancNeo.dsConcretera dsConcretera1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private LancNeo.dsPlanta dsPlanta1;
		private System.Data.SqlClient.SqlDataAdapter sqlDARes;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsResistencia dsResistencia1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAGrado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
		private LancNeo.dsGrado dsGrado1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATAgregado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private LancNeo.dsAgregado dsAgregado1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADescarga;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand10;
        private LancNeo.dsDescarga dsDescarga1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsBusObra dsBusObra1;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.TextBox txtIdObra;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtphini;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtphfin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtSemana;
		private System.Data.SqlClient.SqlDataAdapter sqlDATipo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand11;
        private LancNeo.dsTipo dsTipo1;
        private LancNeo.dsLaboratorista dsLaboratorista2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private DataGridView dgMuestras;
        private DataGridViewTextBoxColumn revObtDataGridViewTextBoxColumn;
        private dsOrigenCo dsOrigenCo1;
        private dsResBajo dsResBajo1;
        private TextBox txtNE;
        private Label label6;
        private TextBox txtSuma;
        protected tbBtn tbBtn1;
        private Label label10;
        private TextBox txtMuestra;
        private SqlCommand sqlSelectCommand12;
        private SqlDataAdapter sqlDAFecha;
        private dsFechaM dsFechaM1;
        private Label label11;
        private TextBox txtCemento;
        private TextBox txtEje;
        private Label label14;
        private Label label15;
        private TextBox txtEle;
        private Label label16;
        private TextBox txtNiv;
        private Label label17;
        private TextBox txtEdi;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

        private int cambia = 0;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn consecutivoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idConcreteraDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn IdPlanta;
        private DataGridViewComboBoxColumn ResistenciaKG;
        private DataGridViewComboBoxColumn Tipo;
        private DataGridViewTextBoxColumn agregadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revenimentoDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Grado;
        private DataGridViewComboBoxColumn TA;
        private DataGridViewTextBoxColumn Nesp;
        private DataGridViewTextBoxColumn idRemisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idOllaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn VolumenO;
        private DataGridViewTextBoxColumn hsalidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hllegadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RevObt;
        private DataGridViewTextBoxColumn mUCFDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn noEcoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Elemento;
        private DataGridViewTextBoxColumn ejesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edifDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observaDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Descarga;
        private DataGridViewComboBoxColumn Origen;
        private DataGridViewComboBoxColumn ResBajo;
        private int regist = 2;

		public Mustra()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mustra));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlDAMuestreador = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAMuestras = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsMuestra1 = new LancNeo.dsMuestra();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusMues1 = new LancNeo.dsBusMues();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label5 = new System.Windows.Forms.Label();
            this.txtM1dv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNcilidros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNmuestras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblTieExt = new System.Windows.Forms.Label();
            this.txtTieExt = new System.Windows.Forms.TextBox();
            this.lblVolSol = new System.Windows.Forms.Label();
            this.txtVolsol = new System.Windows.Forms.TextBox();
            this.cmbNoEco = new System.Windows.Forms.ComboBox();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.lblIdObra = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtphini = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtphfin = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.txt28d = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtM14d = new System.Windows.Forms.TextBox();
            this.txtM7d = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtM3d = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtM3dv = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNE = new System.Windows.Forms.TextBox();
            this.buscaBtn2 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.sqlDANoEco = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusq = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.sqlDARes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsResistencia1 = new LancNeo.dsResistencia();
            this.sqlDAGrado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.dsGrado1 = new LancNeo.dsGrado();
            this.sqlDATAgregado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.dsAgregado1 = new LancNeo.dsAgregado();
            this.sqlDADescarga = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand10 = new System.Data.SqlClient.SqlCommand();
            this.dsDescarga1 = new LancNeo.dsDescarga();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATipo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand11 = new System.Data.SqlClient.SqlCommand();
            this.dsTipo1 = new LancNeo.dsTipo();
            this.dsLaboratorista2 = new LancNeo.dsLaboratorista();
            this.dgMuestras = new System.Windows.Forms.DataGridView();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConcreteraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdPlanta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ResistenciaKG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.agregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Nesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRemisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOllaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumenO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hllegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevObt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUCFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Elemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descarga = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsOrigenCo1 = new LancNeo.dsOrigenCo();
            this.ResBajo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsResBajo1 = new LancNeo.dsResBajo();
            this.sqlSelectCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAFecha = new System.Data.SqlClient.SqlDataAdapter();
            this.dsFechaM1 = new LancNeo.dsFechaM();
            this.txtEje = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNiv = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEdi = new System.Windows.Forms.TextBox();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMuestra1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResistencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescarga1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuestras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenCo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResBajo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFechaM1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 592);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1368, 32);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1368, 64);
            // 
            // sqlDAMuestreador
            // 
            this.sqlDAMuestreador.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAMuestreador.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAMuestreador.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAMuestreador.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestreador", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hinicio", "Hinicio"),
                        new System.Data.Common.DataColumnMapping("Hfinal", "Hfinal"),
                        new System.Data.Common.DataColumnMapping("Vsolicitado", "Vsolicitado"),
                        new System.Data.Common.DataColumnMapping("Textra", "Textra"),
                        new System.Data.Common.DataColumnMapping("Volumen", "Volumen"),
                        new System.Data.Common.DataColumnMapping("Nmuestras", "Nmuestras"),
                        new System.Data.Common.DataColumnMapping("Ncilindros", "Ncilindros"),
                        new System.Data.Common.DataColumnMapping("M1dv", "M1dv"),
                        new System.Data.Common.DataColumnMapping("M3dv", "M3dv"),
                        new System.Data.Common.DataColumnMapping("M3d", "M3d"),
                        new System.Data.Common.DataColumnMapping("M7d", "M7d"),
                        new System.Data.Common.DataColumnMapping("M14d", "M14d"),
                        new System.Data.Common.DataColumnMapping("M28d", "M28d"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("Cemento", "Cemento")})});
            this.sqlDAMuestreador.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Hinicio", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hinicio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Hfinal", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hfinal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Vsolicitado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Vsolicitado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Vsolicitado", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vsolicitado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Textra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Textra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Textra", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Textra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Volumen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Volumen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Volumen", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Volumen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nmuestras", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nmuestras", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ncilindros", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ncilindros", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ncilindros", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ncilindros", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M1dv", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M1dv", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M1dv", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M1dv", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M3dv", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M3dv", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M3dv", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M3dv", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M3d", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M3d", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M3d", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M3d", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M7d", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M7d", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M7d", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M7d", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M14d", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M14d", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M14d", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M14d", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M28d", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M28d", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M28d", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M28d", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cemento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Cemento", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Hinicio", System.Data.SqlDbType.DateTime, 0, "Hinicio"),
            new System.Data.SqlClient.SqlParameter("@Hfinal", System.Data.SqlDbType.DateTime, 0, "Hfinal"),
            new System.Data.SqlClient.SqlParameter("@Vsolicitado", System.Data.SqlDbType.Real, 0, "Vsolicitado"),
            new System.Data.SqlClient.SqlParameter("@Textra", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Textra", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Volumen", System.Data.SqlDbType.Float, 0, "Volumen"),
            new System.Data.SqlClient.SqlParameter("@Nmuestras", System.Data.SqlDbType.SmallInt, 0, "Nmuestras"),
            new System.Data.SqlClient.SqlParameter("@Ncilindros", System.Data.SqlDbType.SmallInt, 0, "Ncilindros"),
            new System.Data.SqlClient.SqlParameter("@M1dv", System.Data.SqlDbType.SmallInt, 0, "M1dv"),
            new System.Data.SqlClient.SqlParameter("@M3dv", System.Data.SqlDbType.SmallInt, 0, "M3dv"),
            new System.Data.SqlClient.SqlParameter("@M3d", System.Data.SqlDbType.SmallInt, 0, "M3d"),
            new System.Data.SqlClient.SqlParameter("@M7d", System.Data.SqlDbType.SmallInt, 0, "M7d"),
            new System.Data.SqlClient.SqlParameter("@M14d", System.Data.SqlDbType.SmallInt, 0, "M14d"),
            new System.Data.SqlClient.SqlParameter("@M28d", System.Data.SqlDbType.SmallInt, 0, "M28d"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Cemento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Cemento", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Hinicio", System.Data.SqlDbType.DateTime, 0, "Hinicio"),
            new System.Data.SqlClient.SqlParameter("@Hfinal", System.Data.SqlDbType.DateTime, 0, "Hfinal"),
            new System.Data.SqlClient.SqlParameter("@Vsolicitado", System.Data.SqlDbType.Real, 0, "Vsolicitado"),
            new System.Data.SqlClient.SqlParameter("@Textra", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Textra", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Volumen", System.Data.SqlDbType.Float, 0, "Volumen"),
            new System.Data.SqlClient.SqlParameter("@Nmuestras", System.Data.SqlDbType.SmallInt, 0, "Nmuestras"),
            new System.Data.SqlClient.SqlParameter("@Ncilindros", System.Data.SqlDbType.SmallInt, 0, "Ncilindros"),
            new System.Data.SqlClient.SqlParameter("@M1dv", System.Data.SqlDbType.SmallInt, 0, "M1dv"),
            new System.Data.SqlClient.SqlParameter("@M3dv", System.Data.SqlDbType.SmallInt, 0, "M3dv"),
            new System.Data.SqlClient.SqlParameter("@M3d", System.Data.SqlDbType.SmallInt, 0, "M3d"),
            new System.Data.SqlClient.SqlParameter("@M7d", System.Data.SqlDbType.SmallInt, 0, "M7d"),
            new System.Data.SqlClient.SqlParameter("@M14d", System.Data.SqlDbType.SmallInt, 0, "M14d"),
            new System.Data.SqlClient.SqlParameter("@M28d", System.Data.SqlDbType.SmallInt, 0, "M28d"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Cemento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Cemento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Hinicio", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hinicio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Hfinal", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hfinal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Vsolicitado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Vsolicitado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Vsolicitado", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vsolicitado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Textra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Textra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Textra", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Textra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Volumen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Volumen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Volumen", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Volumen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nmuestras", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nmuestras", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ncilindros", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ncilindros", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ncilindros", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ncilindros", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M1dv", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M1dv", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M1dv", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M1dv", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M3dv", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M3dv", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M3dv", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M3dv", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M3d", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M3d", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M3d", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M3d", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M7d", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M7d", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M7d", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M7d", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M14d", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M14d", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M14d", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M14d", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_M28d", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "M28d", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_M28d", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "M28d", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cemento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Cemento", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDAMuestras
            // 
            this.sqlDAMuestras.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAMuestras.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAMuestras.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAMuestras.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("IdRemision", "IdRemision"),
                        new System.Data.Common.DataColumnMapping("IdOlla", "IdOlla"),
                        new System.Data.Common.DataColumnMapping("VolumenO", "VolumenO"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("RevObt", "RevObt"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("IdDescarga", "IdDescarga"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("ResBajo", "ResBajo"),
                        new System.Data.Common.DataColumnMapping("Hsalida", "Hsalida"),
                        new System.Data.Common.DataColumnMapping("Hllegada", "Hllegada"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("MUCF", "MUCF"),
                        new System.Data.Common.DataColumnMapping("NEsp", "NEsp"),
                        new System.Data.Common.DataColumnMapping("Ejes1", "Ejes1"),
                        new System.Data.Common.DataColumnMapping("Edif1", "Edif1"),
                        new System.Data.Common.DataColumnMapping("Nivel1", "Nivel1"),
                        new System.Data.Common.DataColumnMapping("Elemento1", "Elemento1")})});
            this.sqlDAMuestras.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Muestra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcretera", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdPlanta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdPlanta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKG", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaKG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Revenimento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Revenimento", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdAgregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdRemision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdRemision", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdRemision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdRemision", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdOlla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdOlla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdOlla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdOlla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VolumenO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VolumenO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VolumenO", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VolumenO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Hora", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hora", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hora", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RevObt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RevObt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RevObt", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevObt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Elemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ejes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ejes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nivel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edif", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edif", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdDescarga", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDescarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Origen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Origen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Origen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Origen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ResBajo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResBajo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ResBajo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResBajo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Hsalida", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hsalida", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Hsalida", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hsalida", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Hllegada", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hllegada", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Hllegada", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hllegada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MUCF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MUCF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MUCF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MUCF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NEsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NEsp", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NEsp", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NEsp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ejes1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ejes1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ejes1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ejes1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edif1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edif1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edif1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edif1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nivel1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nivel1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Elemento1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Elemento1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento1", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 0, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 0, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 0, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.Int, 0, "IdPlanta"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 0, "ResistenciaKG"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 0, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimento", System.Data.SqlDbType.Real, 0, "Revenimento"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 0, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@IdRemision", System.Data.SqlDbType.NVarChar, 0, "IdRemision"),
            new System.Data.SqlClient.SqlParameter("@IdOlla", System.Data.SqlDbType.Int, 0, "IdOlla"),
            new System.Data.SqlClient.SqlParameter("@VolumenO", System.Data.SqlDbType.Float, 0, "VolumenO"),
            new System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.DateTime, 0, "Hora"),
            new System.Data.SqlClient.SqlParameter("@RevObt", System.Data.SqlDbType.Real, 0, "RevObt"),
            new System.Data.SqlClient.SqlParameter("@Elemento", System.Data.SqlDbType.NVarChar, 0, "Elemento"),
            new System.Data.SqlClient.SqlParameter("@Ejes", System.Data.SqlDbType.NVarChar, 0, "Ejes"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 0, "Nivel"),
            new System.Data.SqlClient.SqlParameter("@Edif", System.Data.SqlDbType.NVarChar, 0, "Edif"),
            new System.Data.SqlClient.SqlParameter("@Observa", System.Data.SqlDbType.NText, 0, "Observa"),
            new System.Data.SqlClient.SqlParameter("@IdDescarga", System.Data.SqlDbType.SmallInt, 0, "IdDescarga"),
            new System.Data.SqlClient.SqlParameter("@Origen", System.Data.SqlDbType.Int, 0, "Origen"),
            new System.Data.SqlClient.SqlParameter("@ResBajo", System.Data.SqlDbType.Int, 0, "ResBajo"),
            new System.Data.SqlClient.SqlParameter("@Hsalida", System.Data.SqlDbType.DateTime, 0, "Hsalida"),
            new System.Data.SqlClient.SqlParameter("@Hllegada", System.Data.SqlDbType.DateTime, 0, "Hllegada"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@MUCF", System.Data.SqlDbType.Int, 0, "MUCF"),
            new System.Data.SqlClient.SqlParameter("@NEsp", System.Data.SqlDbType.SmallInt, 0, "NEsp"),
            new System.Data.SqlClient.SqlParameter("@Ejes1", System.Data.SqlDbType.NVarChar, 0, "Ejes1"),
            new System.Data.SqlClient.SqlParameter("@Edif1", System.Data.SqlDbType.NVarChar, 0, "Edif1"),
            new System.Data.SqlClient.SqlParameter("@Nivel1", System.Data.SqlDbType.NVarChar, 0, "Nivel1"),
            new System.Data.SqlClient.SqlParameter("@Elemento1", System.Data.SqlDbType.NVarChar, 0, "Elemento1")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Current, "FFB")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 0, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 0, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 0, "IdConcretera"),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.Int, 0, "IdPlanta"),
            new System.Data.SqlClient.SqlParameter("@ResistenciaKG", System.Data.SqlDbType.Real, 0, "ResistenciaKG"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Agregado", System.Data.SqlDbType.Real, 0, "Agregado"),
            new System.Data.SqlClient.SqlParameter("@Revenimento", System.Data.SqlDbType.Real, 0, "Revenimento"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@IdAgregado", System.Data.SqlDbType.Int, 0, "IdAgregado"),
            new System.Data.SqlClient.SqlParameter("@IdRemision", System.Data.SqlDbType.NVarChar, 0, "IdRemision"),
            new System.Data.SqlClient.SqlParameter("@IdOlla", System.Data.SqlDbType.Int, 0, "IdOlla"),
            new System.Data.SqlClient.SqlParameter("@VolumenO", System.Data.SqlDbType.Float, 0, "VolumenO"),
            new System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.DateTime, 0, "Hora"),
            new System.Data.SqlClient.SqlParameter("@RevObt", System.Data.SqlDbType.Real, 0, "RevObt"),
            new System.Data.SqlClient.SqlParameter("@Elemento", System.Data.SqlDbType.NVarChar, 0, "Elemento"),
            new System.Data.SqlClient.SqlParameter("@Ejes", System.Data.SqlDbType.NVarChar, 0, "Ejes"),
            new System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.NVarChar, 0, "Nivel"),
            new System.Data.SqlClient.SqlParameter("@Edif", System.Data.SqlDbType.NVarChar, 0, "Edif"),
            new System.Data.SqlClient.SqlParameter("@Observa", System.Data.SqlDbType.NText, 0, "Observa"),
            new System.Data.SqlClient.SqlParameter("@IdDescarga", System.Data.SqlDbType.SmallInt, 0, "IdDescarga"),
            new System.Data.SqlClient.SqlParameter("@Origen", System.Data.SqlDbType.Int, 0, "Origen"),
            new System.Data.SqlClient.SqlParameter("@ResBajo", System.Data.SqlDbType.Int, 0, "ResBajo"),
            new System.Data.SqlClient.SqlParameter("@Hsalida", System.Data.SqlDbType.DateTime, 0, "Hsalida"),
            new System.Data.SqlClient.SqlParameter("@Hllegada", System.Data.SqlDbType.DateTime, 0, "Hllegada"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@MUCF", System.Data.SqlDbType.Int, 0, "MUCF"),
            new System.Data.SqlClient.SqlParameter("@NEsp", System.Data.SqlDbType.SmallInt, 0, "NEsp"),
            new System.Data.SqlClient.SqlParameter("@Ejes1", System.Data.SqlDbType.NVarChar, 0, "Ejes1"),
            new System.Data.SqlClient.SqlParameter("@Edif1", System.Data.SqlDbType.NVarChar, 0, "Edif1"),
            new System.Data.SqlClient.SqlParameter("@Nivel1", System.Data.SqlDbType.NVarChar, 0, "Nivel1"),
            new System.Data.SqlClient.SqlParameter("@Elemento1", System.Data.SqlDbType.NVarChar, 0, "Elemento1"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Muestra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcretera", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcretera", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdPlanta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdPlanta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPlanta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ResistenciaKG", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResistenciaKG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agregado", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Revenimento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Revenimento", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revenimento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdAgregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdRemision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdRemision", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdRemision", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdRemision", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdOlla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdOlla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdOlla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdOlla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VolumenO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VolumenO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VolumenO", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VolumenO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Hora", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hora", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hora", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RevObt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RevObt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RevObt", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevObt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Elemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ejes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ejes", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ejes", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nivel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edif", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edif", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edif", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdDescarga", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDescarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Origen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Origen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Origen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Origen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ResBajo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResBajo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ResBajo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResBajo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Hsalida", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hsalida", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Hsalida", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hsalida", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Hllegada", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hllegada", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Hllegada", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hllegada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MUCF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MUCF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MUCF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MUCF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NEsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NEsp", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NEsp", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NEsp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ejes1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ejes1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ejes1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ejes1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edif1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edif1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edif1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edif1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nivel1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nivel1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nivel1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Elemento1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Elemento1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Elemento1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elemento1", System.Data.DataRowVersion.Original, null)});
            // 
            // dsMuestra1
            // 
            this.dsMuestra1.DataSetName = "dsMuestra";
            this.dsMuestra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsMuestra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.tbBtn1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCemento);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtMuestra);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSuma);
            this.panel2.Controls.Add(this.txtSemana);
            this.panel2.Controls.Add(this.txtIdObra);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtM1dv);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNcilidros);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNmuestras);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtVolumen);
            this.panel2.Controls.Add(this.lblTieExt);
            this.panel2.Controls.Add(this.txtTieExt);
            this.panel2.Controls.Add(this.lblVolSol);
            this.panel2.Controls.Add(this.txtVolsol);
            this.panel2.Controls.Add(this.cmbNoEco);
            this.panel2.Controls.Add(this.lblIdObra);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtphini);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dtphfin);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txt28d);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtM14d);
            this.panel2.Controls.Add(this.txtM7d);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtM3d);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtM3dv);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.txtObserva);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(16, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 128);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusMues1.Muestreador;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(112, -2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            // 
            // dsBusMues1
            // 
            this.dsBusMues1.DataSetName = "dsBusMues";
            this.dsBusMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(83, 57);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 56;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(196, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Cemento:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCemento
            // 
            this.txtCemento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Cemento", true));
            this.txtCemento.Location = new System.Drawing.Point(257, 103);
            this.txtCemento.MaxLength = 5;
            this.txtCemento.Name = "txtCemento";
            this.txtCemento.Size = new System.Drawing.Size(48, 20);
            this.txtCemento.TabIndex = 59;
            this.txtCemento.Text = "textBox1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Muestra:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(49, 86);
            this.txtMuestra.MaxLength = 6;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(32, 20);
            this.txtMuestra.TabIndex = 57;
            this.txtMuestra.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Suma Cilindros:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(386, 48);
            this.txtSuma.MaxLength = 4;
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(32, 20);
            this.txtSuma.TabIndex = 42;
            this.txtSuma.Text = "textBox2";
            this.txtSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(492, 6);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(32, 20);
            this.txtSemana.TabIndex = 5;
            this.txtSemana.Text = "textBox1";
            // 
            // txtIdObra
            // 
            this.txtIdObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.IdObra", true));
            this.txtIdObra.Location = new System.Drawing.Point(120, 14);
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(48, 20);
            this.txtIdObra.TabIndex = 40;
            this.txtIdObra.Text = "textBox1";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(44, 6);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.Tag = "ACE";
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "1 día vapor:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtM1dv
            // 
            this.txtM1dv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.M1dv", true));
            this.txtM1dv.Location = new System.Drawing.Point(492, 31);
            this.txtM1dv.MaxLength = 4;
            this.txtM1dv.Name = "txtM1dv";
            this.txtM1dv.Size = new System.Drawing.Size(32, 20);
            this.txtM1dv.TabIndex = 11;
            this.txtM1dv.Text = "textBox2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "N° de Cilindros:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNcilidros
            // 
            this.txtNcilidros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Ncilindros", true));
            this.txtNcilidros.Location = new System.Drawing.Point(386, 27);
            this.txtNcilidros.MaxLength = 4;
            this.txtNcilidros.Name = "txtNcilidros";
            this.txtNcilidros.Size = new System.Drawing.Size(32, 20);
            this.txtNcilidros.TabIndex = 10;
            this.txtNcilidros.Text = "textBox2";
            this.txtNcilidros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "N° de muestras:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNmuestras
            // 
            this.txtNmuestras.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Nmuestras", true));
            this.txtNmuestras.Location = new System.Drawing.Point(260, 31);
            this.txtNmuestras.MaxLength = 4;
            this.txtNmuestras.Name = "txtNmuestras";
            this.txtNmuestras.Size = new System.Drawing.Size(32, 20);
            this.txtNmuestras.TabIndex = 9;
            this.txtNmuestras.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(153, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "m3 reales colados:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVolumen
            // 
            this.txtVolumen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Volumen", true));
            this.txtVolumen.Location = new System.Drawing.Point(257, 80);
            this.txtVolumen.MaxLength = 5;
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(48, 20);
            this.txtVolumen.TabIndex = 18;
            this.txtVolumen.Text = "textBox1";
            // 
            // lblTieExt
            // 
            this.lblTieExt.AutoSize = true;
            this.lblTieExt.Location = new System.Drawing.Point(179, 58);
            this.lblTieExt.Name = "lblTieExt";
            this.lblTieExt.Size = new System.Drawing.Size(71, 13);
            this.lblTieExt.TabIndex = 17;
            this.lblTieExt.Text = "Tiempo extra:";
            this.lblTieExt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTieExt
            // 
            this.txtTieExt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Textra", true));
            this.txtTieExt.Location = new System.Drawing.Point(257, 58);
            this.txtTieExt.MaxLength = 4;
            this.txtTieExt.Name = "txtTieExt";
            this.txtTieExt.Size = new System.Drawing.Size(48, 20);
            this.txtTieExt.TabIndex = 17;
            this.txtTieExt.Text = "textBox1";
            // 
            // lblVolSol
            // 
            this.lblVolSol.AutoSize = true;
            this.lblVolSol.Location = new System.Drawing.Point(804, 8);
            this.lblVolSol.Name = "lblVolSol";
            this.lblVolSol.Size = new System.Drawing.Size(98, 13);
            this.lblVolSol.TabIndex = 15;
            this.lblVolSol.Text = "Volumen solicitado:";
            this.lblVolSol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVolsol
            // 
            this.txtVolsol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Vsolicitado", true));
            this.txtVolsol.Location = new System.Drawing.Point(916, 6);
            this.txtVolsol.MaxLength = 6;
            this.txtVolsol.Name = "txtVolsol";
            this.txtVolsol.Size = new System.Drawing.Size(56, 20);
            this.txtVolsol.TabIndex = 8;
            this.txtVolsol.Text = "0";
            // 
            // cmbNoEco
            // 
            this.cmbNoEco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsMuestra1, "Muestreador.NoEco", true));
            this.cmbNoEco.DataSource = this.dsLaboratorista1.Laboratorista;
            this.cmbNoEco.DisplayMember = "NoEco";
            this.cmbNoEco.Location = new System.Drawing.Point(364, 6);
            this.cmbNoEco.Name = "cmbNoEco";
            this.cmbNoEco.Size = new System.Drawing.Size(64, 21);
            this.cmbNoEco.TabIndex = 4;
            this.cmbNoEco.ValueMember = "NoEco";
            this.cmbNoEco.SelectedIndexChanged += new System.EventHandler(this.cmbNoEco_SelectedIndexChanged);
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIdObra
            // 
            this.lblIdObra.AutoSize = true;
            this.lblIdObra.Location = new System.Drawing.Point(0, 6);
            this.lblIdObra.Name = "lblIdObra";
            this.lblIdObra.Size = new System.Drawing.Size(42, 13);
            this.lblIdObra.TabIndex = 1;
            this.lblIdObra.Text = "IdObra:";
            this.lblIdObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yy";
            this.dtpFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Fecha", true));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(220, 6);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowUpDown = true;
            this.dtpFecha.Size = new System.Drawing.Size(72, 20);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2004, 8, 13, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(524, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Hora inicio:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtphini
            // 
            this.dtphini.CustomFormat = "HH:mm";
            this.dtphini.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Hinicio", true));
            this.dtphini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphini.Location = new System.Drawing.Point(588, 6);
            this.dtphini.Name = "dtphini";
            this.dtphini.ShowUpDown = true;
            this.dtphini.Size = new System.Drawing.Size(56, 20);
            this.dtphini.TabIndex = 6;
            this.dtphini.Value = new System.DateTime(2004, 10, 20, 10, 57, 50, 679);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(660, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Hora termino:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtphfin
            // 
            this.dtphfin.CustomFormat = "HH:mm";
            this.dtphfin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Hfinal", true));
            this.dtphfin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphfin.Location = new System.Drawing.Point(740, 6);
            this.dtphfin.Name = "dtphfin";
            this.dtphfin.ShowUpDown = true;
            this.dtphfin.Size = new System.Drawing.Size(56, 20);
            this.dtphfin.TabIndex = 7;
            this.dtphfin.Value = new System.DateTime(2004, 10, 20, 10, 57, 51, 620);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(892, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 23);
            this.label22.TabIndex = 36;
            this.label22.Text = "28 días:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt28d
            // 
            this.txt28d.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.M28d", true));
            this.txt28d.Location = new System.Drawing.Point(940, 31);
            this.txt28d.MaxLength = 2;
            this.txt28d.Name = "txt28d";
            this.txt28d.Size = new System.Drawing.Size(32, 20);
            this.txt28d.TabIndex = 16;
            this.txt28d.Text = "textBox2";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(812, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 23);
            this.label21.TabIndex = 34;
            this.label21.Text = "14 días:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtM14d
            // 
            this.txtM14d.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.M14d", true));
            this.txtM14d.Location = new System.Drawing.Point(860, 31);
            this.txtM14d.MaxLength = 2;
            this.txtM14d.Name = "txtM14d";
            this.txtM14d.Size = new System.Drawing.Size(32, 20);
            this.txtM14d.TabIndex = 15;
            this.txtM14d.Text = "textBox2";
            // 
            // txtM7d
            // 
            this.txtM7d.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.M7d", true));
            this.txtM7d.Location = new System.Drawing.Point(764, 31);
            this.txtM7d.MaxLength = 2;
            this.txtM7d.Name = "txtM7d";
            this.txtM7d.Size = new System.Drawing.Size(32, 20);
            this.txtM7d.TabIndex = 14;
            this.txtM7d.Text = "textBox2";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(724, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 23);
            this.label20.TabIndex = 32;
            this.label20.Text = "7 días:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(644, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 23);
            this.label19.TabIndex = 30;
            this.label19.Text = "3 días:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtM3d
            // 
            this.txtM3d.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.M3d", true));
            this.txtM3d.Location = new System.Drawing.Point(684, 31);
            this.txtM3d.MaxLength = 2;
            this.txtM3d.Name = "txtM3d";
            this.txtM3d.Size = new System.Drawing.Size(32, 20);
            this.txtM3d.TabIndex = 13;
            this.txtM3d.Text = "textBox2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(548, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "3 día vapor:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtM3dv
            // 
            this.txtM3dv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.M3dv", true));
            this.txtM3dv.Location = new System.Drawing.Point(612, 31);
            this.txtM3dv.MaxLength = 2;
            this.txtM3dv.Name = "txtM3dv";
            this.txtM3dv.Size = new System.Drawing.Size(32, 20);
            this.txtM3dv.TabIndex = 12;
            this.txtM3dv.Text = "textBox2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(429, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "Observaciones:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObserva
            // 
            this.txtObserva.AcceptsReturn = true;
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMuestra1, "Muestreador.Observaciones", true));
            this.txtObserva.Location = new System.Drawing.Point(311, 67);
            this.txtObserva.MaxLength = 255;
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserva.Size = new System.Drawing.Size(661, 56);
            this.txtObserva.TabIndex = 19;
            this.txtObserva.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(180, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Semana:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(180, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fecha:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Laboratorista:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNE
            // 
            this.txtNE.Location = new System.Drawing.Point(1060, 124);
            this.txtNE.Name = "txtNE";
            this.txtNE.Size = new System.Drawing.Size(86, 20);
            this.txtNE.TabIndex = 41;
            this.txtNE.Visible = false;
            // 
            // buscaBtn2
            // 
            this.buscaBtn2.AnchoDlgBusq = 0;
            this.buscaBtn2.BackColor = System.Drawing.SystemColors.Control;
            this.buscaBtn2.Datos = null;
            this.buscaBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn2.Icon")));
            this.buscaBtn2.Location = new System.Drawing.Point(112, 8);
            this.buscaBtn2.Name = "buscaBtn2";
            this.buscaBtn2.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn2.TabIndex = 37;
            // 
            // sqlDANoEco
            // 
            this.sqlDANoEco.SelectCommand = this.sqlSelectCommand3;
            this.sqlDANoEco.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorista", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT NoEco, Laboratorista, IdZona, IdNivel, Fechai FROM Laboratorista ORDER BY " +
    "NoEco";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDABusq
            // 
            this.sqlDABusq.SelectCommand = this.sqlSelectCommand4;
            this.sqlDABusq.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestreador", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.SelectCommand = this.sqlSelectCommand5;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera ORDER BY IdConcretera";
            this.sqlSelectCommand5.Connection = this.sqlConn;
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlSelectCommand6.CommandText = "SELECT DISTINCT IdPlanta, \' \' AS Planta, \' \' AS IdConcretera\r\nFROM            Pla" +
    "nta\r\nORDER BY IdPlanta";
            this.sqlSelectCommand6.Connection = this.sqlConn;
            // 
            // dsPlanta1
            // 
            this.dsPlanta1.DataSetName = "dsPlanta";
            this.dsPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlSelectCommand7.CommandText = "SELECT ResistenciaKG, ResistenciaMPa FROM Resistencia ORDER BY ResistenciaKG";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsResistencia1
            // 
            this.dsResistencia1.DataSetName = "dsResistencia";
            this.dsResistencia1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsResistencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsGrado1
            // 
            this.dsGrado1.DataSetName = "dsGrado";
            this.dsGrado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsGrado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsAgregado1
            // 
            this.dsAgregado1.DataSetName = "dsAgregado";
            this.dsAgregado1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAgregado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDADescarga
            // 
            this.sqlDADescarga.SelectCommand = this.sqlSelectCommand10;
            this.sqlDADescarga.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Descarga", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdDescarga", "IdDescarga"),
                        new System.Data.Common.DataColumnMapping("Descarga", "Descarga")})});
            // 
            // sqlSelectCommand10
            // 
            this.sqlSelectCommand10.CommandText = "SELECT IdDescarga, Descarga FROM Descarga";
            this.sqlSelectCommand10.Connection = this.sqlConn;
            // 
            // dsDescarga1
            // 
            this.dsDescarga1.DataSetName = "dsDescarga";
            this.dsDescarga1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDescarga1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsTipo1
            // 
            this.dsTipo1.DataSetName = "dsTipo";
            this.dsTipo1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLaboratorista2
            // 
            this.dsLaboratorista2.DataSetName = "dsLaboratorista";
            this.dsLaboratorista2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgMuestras
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgMuestras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgMuestras.AutoGenerateColumns = false;
            this.dgMuestras.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMuestras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMuestras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.consecutivoDataGridViewTextBoxColumn,
            this.muestraDataGridViewTextBoxColumn,
            this.idConcreteraDataGridViewTextBoxColumn,
            this.IdPlanta,
            this.ResistenciaKG,
            this.Tipo,
            this.agregadoDataGridViewTextBoxColumn,
            this.revenimentoDataGridViewTextBoxColumn,
            this.Grado,
            this.TA,
            this.Nesp,
            this.idRemisionDataGridViewTextBoxColumn,
            this.idOllaDataGridViewTextBoxColumn,
            this.VolumenO,
            this.hsalidaDataGridViewTextBoxColumn,
            this.hllegadaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.RevObt,
            this.mUCFDataGridViewTextBoxColumn,
            this.noEcoDataGridViewTextBoxColumn,
            this.Elemento,
            this.ejesDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.edifDataGridViewTextBoxColumn,
            this.observaDataGridViewTextBoxColumn,
            this.Descarga,
            this.Origen,
            this.ResBajo});
            this.dgMuestras.DataMember = "Muestreador.MuestreadorMuestras";
            this.dgMuestras.DataSource = this.dsMuestra1;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMuestras.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgMuestras.Location = new System.Drawing.Point(2, 206);
            this.dgMuestras.Name = "dgMuestras";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMuestras.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgMuestras.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgMuestras.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMuestras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgMuestras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgMuestras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgMuestras.Size = new System.Drawing.Size(1354, 272);
            this.dgMuestras.TabIndex = 21;
            this.dgMuestras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMuestras_CellContentClick);
            this.dgMuestras.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgMuestras_DefaultValuesNeeded);
            this.dgMuestras.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMuestras_RowEnter);
            this.dgMuestras.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMuestras_RowLeave);
            this.dgMuestras.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgMuestras_RowsAdded);
            this.dgMuestras.Enter += new System.EventHandler(this.dgMuestras_Enter);
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObraDataGridViewTextBoxColumn.Visible = false;
            this.idObraDataGridViewTextBoxColumn.Width = 5;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Visible = false;
            this.fechaDataGridViewTextBoxColumn.Width = 5;
            // 
            // consecutivoDataGridViewTextBoxColumn
            // 
            this.consecutivoDataGridViewTextBoxColumn.DataPropertyName = "Consecutivo";
            this.consecutivoDataGridViewTextBoxColumn.HeaderText = "Cons.";
            this.consecutivoDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.consecutivoDataGridViewTextBoxColumn.Name = "consecutivoDataGridViewTextBoxColumn";
            this.consecutivoDataGridViewTextBoxColumn.Width = 30;
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            this.muestraDataGridViewTextBoxColumn.Width = 45;
            // 
            // idConcreteraDataGridViewTextBoxColumn
            // 
            this.idConcreteraDataGridViewTextBoxColumn.DataPropertyName = "IdConcretera";
            this.idConcreteraDataGridViewTextBoxColumn.DataSource = this.dsConcretera1;
            this.idConcreteraDataGridViewTextBoxColumn.DisplayMember = "Concretera.IdConcretera";
            this.idConcreteraDataGridViewTextBoxColumn.HeaderText = "Concretera";
            this.idConcreteraDataGridViewTextBoxColumn.Name = "idConcreteraDataGridViewTextBoxColumn";
            this.idConcreteraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idConcreteraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idConcreteraDataGridViewTextBoxColumn.ValueMember = "Concretera.IdConcretera";
            this.idConcreteraDataGridViewTextBoxColumn.Width = 65;
            // 
            // IdPlanta
            // 
            this.IdPlanta.DataPropertyName = "IdPlanta";
            this.IdPlanta.DataSource = this.dsPlanta1;
            this.IdPlanta.DisplayMember = "Planta.IdPlanta";
            this.IdPlanta.HeaderText = "Planta";
            this.IdPlanta.Name = "IdPlanta";
            this.IdPlanta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdPlanta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdPlanta.ValueMember = "Planta.IdPlanta";
            this.IdPlanta.Width = 50;
            // 
            // ResistenciaKG
            // 
            this.ResistenciaKG.DataPropertyName = "ResistenciaKG";
            this.ResistenciaKG.DataSource = this.dsResistencia1;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            this.ResistenciaKG.DefaultCellStyle = dataGridViewCellStyle11;
            this.ResistenciaKG.DisplayMember = "Resistencia.ResistenciaKG";
            this.ResistenciaKG.HeaderText = "f\'c";
            this.ResistenciaKG.Name = "ResistenciaKG";
            this.ResistenciaKG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ResistenciaKG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ResistenciaKG.ValueMember = "Resistencia.ResistenciaKG";
            this.ResistenciaKG.Width = 45;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.DataSource = this.dsTipo1;
            this.Tipo.DisplayMember = "Tipo.DesTipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tipo.ValueMember = "Tipo.Tipo";
            this.Tipo.Width = 60;
            // 
            // agregadoDataGridViewTextBoxColumn
            // 
            this.agregadoDataGridViewTextBoxColumn.DataPropertyName = "Agregado";
            this.agregadoDataGridViewTextBoxColumn.HeaderText = "TMA";
            this.agregadoDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.agregadoDataGridViewTextBoxColumn.Name = "agregadoDataGridViewTextBoxColumn";
            this.agregadoDataGridViewTextBoxColumn.Width = 30;
            // 
            // revenimentoDataGridViewTextBoxColumn
            // 
            this.revenimentoDataGridViewTextBoxColumn.DataPropertyName = "Revenimento";
            this.revenimentoDataGridViewTextBoxColumn.HeaderText = "Rv";
            this.revenimentoDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.revenimentoDataGridViewTextBoxColumn.Name = "revenimentoDataGridViewTextBoxColumn";
            this.revenimentoDataGridViewTextBoxColumn.Width = 25;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "Grado";
            this.Grado.DataSource = this.dsGrado1;
            this.Grado.DisplayMember = "Grado.Grado";
            this.Grado.HeaderText = "GC";
            this.Grado.Name = "Grado";
            this.Grado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Grado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Grado.ValueMember = "Grado.Grado";
            this.Grado.Width = 30;
            // 
            // TA
            // 
            this.TA.DataPropertyName = "IdAgregado";
            this.TA.DataSource = this.dsAgregado1;
            this.TA.DisplayMember = "Agregado.Tipo";
            this.TA.HeaderText = "TA";
            this.TA.Name = "TA";
            this.TA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TA.ValueMember = "Agregado.IdAgregado";
            this.TA.Width = 60;
            // 
            // Nesp
            // 
            this.Nesp.DataPropertyName = "Nesp";
            this.Nesp.HeaderText = "E\'s";
            this.Nesp.MaxInputLength = 2;
            this.Nesp.Name = "Nesp";
            this.Nesp.ToolTipText = "Número de especimenes";
            this.Nesp.Width = 30;
            // 
            // idRemisionDataGridViewTextBoxColumn
            // 
            this.idRemisionDataGridViewTextBoxColumn.DataPropertyName = "IdRemision";
            this.idRemisionDataGridViewTextBoxColumn.HeaderText = "Remisión";
            this.idRemisionDataGridViewTextBoxColumn.MaxInputLength = 12;
            this.idRemisionDataGridViewTextBoxColumn.Name = "idRemisionDataGridViewTextBoxColumn";
            this.idRemisionDataGridViewTextBoxColumn.Width = 55;
            // 
            // idOllaDataGridViewTextBoxColumn
            // 
            this.idOllaDataGridViewTextBoxColumn.DataPropertyName = "IdOlla";
            this.idOllaDataGridViewTextBoxColumn.HeaderText = "Olla";
            this.idOllaDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.idOllaDataGridViewTextBoxColumn.Name = "idOllaDataGridViewTextBoxColumn";
            this.idOllaDataGridViewTextBoxColumn.Width = 35;
            // 
            // VolumenO
            // 
            this.VolumenO.DataPropertyName = "VolumenO";
            this.VolumenO.HeaderText = "Vol";
            this.VolumenO.Name = "VolumenO";
            this.VolumenO.Width = 35;
            // 
            // hsalidaDataGridViewTextBoxColumn
            // 
            this.hsalidaDataGridViewTextBoxColumn.DataPropertyName = "Hsalida";
            dataGridViewCellStyle12.Format = "t";
            dataGridViewCellStyle12.NullValue = null;
            this.hsalidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.hsalidaDataGridViewTextBoxColumn.HeaderText = "Sal.";
            this.hsalidaDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.hsalidaDataGridViewTextBoxColumn.Name = "hsalidaDataGridViewTextBoxColumn";
            this.hsalidaDataGridViewTextBoxColumn.Width = 38;
            // 
            // hllegadaDataGridViewTextBoxColumn
            // 
            this.hllegadaDataGridViewTextBoxColumn.DataPropertyName = "Hllegada";
            dataGridViewCellStyle13.Format = "t";
            dataGridViewCellStyle13.NullValue = null;
            this.hllegadaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.hllegadaDataGridViewTextBoxColumn.HeaderText = "Lleg";
            this.hllegadaDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.hllegadaDataGridViewTextBoxColumn.Name = "hllegadaDataGridViewTextBoxColumn";
            this.hllegadaDataGridViewTextBoxColumn.Width = 38;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            dataGridViewCellStyle14.Format = "t";
            dataGridViewCellStyle14.NullValue = null;
            this.horaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.Width = 38;
            // 
            // RevObt
            // 
            this.RevObt.DataPropertyName = "RevObt";
            this.RevObt.HeaderText = "RevObt";
            this.RevObt.MaxInputLength = 3;
            this.RevObt.Name = "RevObt";
            this.RevObt.Width = 25;
            // 
            // mUCFDataGridViewTextBoxColumn
            // 
            this.mUCFDataGridViewTextBoxColumn.DataPropertyName = "MUCF";
            this.mUCFDataGridViewTextBoxColumn.HeaderText = "MUCF";
            this.mUCFDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.mUCFDataGridViewTextBoxColumn.Name = "mUCFDataGridViewTextBoxColumn";
            this.mUCFDataGridViewTextBoxColumn.Width = 35;
            // 
            // noEcoDataGridViewTextBoxColumn
            // 
            this.noEcoDataGridViewTextBoxColumn.DataPropertyName = "NoEco";
            this.noEcoDataGridViewTextBoxColumn.DataSource = this.dsLaboratorista2;
            this.noEcoDataGridViewTextBoxColumn.DisplayMember = "Laboratorista.NoEco";
            this.noEcoDataGridViewTextBoxColumn.HeaderText = "NoEco";
            this.noEcoDataGridViewTextBoxColumn.Name = "noEcoDataGridViewTextBoxColumn";
            this.noEcoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.noEcoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.noEcoDataGridViewTextBoxColumn.ValueMember = "Laboratorista.NoEco";
            this.noEcoDataGridViewTextBoxColumn.Width = 45;
            // 
            // Elemento
            // 
            this.Elemento.DataPropertyName = "Elemento";
            this.Elemento.HeaderText = "Elemento";
            this.Elemento.MaxInputLength = 110;
            this.Elemento.Name = "Elemento";
            this.Elemento.Width = 95;
            // 
            // ejesDataGridViewTextBoxColumn
            // 
            this.ejesDataGridViewTextBoxColumn.DataPropertyName = "Ejes";
            this.ejesDataGridViewTextBoxColumn.HeaderText = "Ejes";
            this.ejesDataGridViewTextBoxColumn.MaxInputLength = 135;
            this.ejesDataGridViewTextBoxColumn.Name = "ejesDataGridViewTextBoxColumn";
            this.ejesDataGridViewTextBoxColumn.Width = 95;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.MaxInputLength = 35;
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.Width = 25;
            // 
            // edifDataGridViewTextBoxColumn
            // 
            this.edifDataGridViewTextBoxColumn.DataPropertyName = "Edif";
            this.edifDataGridViewTextBoxColumn.HeaderText = "Edificio";
            this.edifDataGridViewTextBoxColumn.MaxInputLength = 70;
            this.edifDataGridViewTextBoxColumn.Name = "edifDataGridViewTextBoxColumn";
            this.edifDataGridViewTextBoxColumn.Width = 70;
            // 
            // observaDataGridViewTextBoxColumn
            // 
            this.observaDataGridViewTextBoxColumn.DataPropertyName = "Observa";
            this.observaDataGridViewTextBoxColumn.HeaderText = "Observa";
            this.observaDataGridViewTextBoxColumn.Name = "observaDataGridViewTextBoxColumn";
            this.observaDataGridViewTextBoxColumn.Width = 75;
            // 
            // Descarga
            // 
            this.Descarga.DataPropertyName = "IdDescarga";
            this.Descarga.DataSource = this.dsDescarga1;
            this.Descarga.DisplayMember = "Descarga.Descarga";
            this.Descarga.HeaderText = "Descarga";
            this.Descarga.Name = "Descarga";
            this.Descarga.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Descarga.ValueMember = "Descarga.IdDescarga";
            this.Descarga.Width = 75;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.DataSource = this.dsOrigenCo1;
            this.Origen.DisplayMember = "OrigenCo.Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Origen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Origen.ValueMember = "OrigenCo.IdOrigen";
            this.Origen.Width = 55;
            // 
            // dsOrigenCo1
            // 
            this.dsOrigenCo1.DataSetName = "dsOrigenCo";
            this.dsOrigenCo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ResBajo
            // 
            this.ResBajo.DataPropertyName = "ResBajo";
            this.ResBajo.DataSource = this.dsResBajo1;
            this.ResBajo.DisplayMember = "ResBajo.ResBajo";
            this.ResBajo.HeaderText = "ResBajo";
            this.ResBajo.Name = "ResBajo";
            this.ResBajo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ResBajo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ResBajo.ValueMember = "ResBajo.IdResBajo";
            this.ResBajo.Width = 65;
            // 
            // dsResBajo1
            // 
            this.dsResBajo1.DataSetName = "dsResBajo";
            this.dsResBajo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand12
            // 
            this.sqlSelectCommand12.CommandText = "SELECT     TOP (1) Fecha\r\nFROM         Muestras\r\nWHERE     (IdObra = @IdObra) AND" +
    " (Muestra = @Muestra)";
            this.sqlSelectCommand12.Connection = this.sqlConn;
            this.sqlSelectCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.Int, 4, "Muestra")});
            // 
            // sqlDAFecha
            // 
            this.sqlDAFecha.SelectCommand = this.sqlSelectCommand12;
            this.sqlDAFecha.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha")})});
            // 
            // dsFechaM1
            // 
            this.dsFechaM1.DataSetName = "dsFechaM";
            this.dsFechaM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEje
            // 
            this.txtEje.Location = new System.Drawing.Point(242, 496);
            this.txtEje.MaxLength = 135;
            this.txtEje.Multiline = true;
            this.txtEje.Name = "txtEje";
            this.txtEje.Size = new System.Drawing.Size(170, 75);
            this.txtEje.TabIndex = 22;
            this.txtEje.Leave += new System.EventHandler(this.txtEje_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(245, 481);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ejes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 481);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Elemento";
            // 
            // txtEle
            // 
            this.txtEle.AcceptsReturn = true;
            this.txtEle.Location = new System.Drawing.Point(5, 496);
            this.txtEle.MaxLength = 135;
            this.txtEle.Multiline = true;
            this.txtEle.Name = "txtEle";
            this.txtEle.Size = new System.Drawing.Size(170, 75);
            this.txtEle.TabIndex = 24;
            this.txtEle.Leave += new System.EventHandler(this.txtEle_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(447, 481);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Nivel";
            // 
            // txtNiv
            // 
            this.txtNiv.Location = new System.Drawing.Point(444, 496);
            this.txtNiv.MaxLength = 35;
            this.txtNiv.Multiline = true;
            this.txtNiv.Name = "txtNiv";
            this.txtNiv.Size = new System.Drawing.Size(48, 75);
            this.txtNiv.TabIndex = 28;
            this.txtNiv.Text = "12345";
            this.txtNiv.Leave += new System.EventHandler(this.txtNiv_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(513, 481);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Edificio";
            // 
            // txtEdi
            // 
            this.txtEdi.Location = new System.Drawing.Point(510, 496);
            this.txtEdi.MaxLength = 135;
            this.txtEdi.Multiline = true;
            this.txtEdi.Name = "txtEdi";
            this.txtEdi.Size = new System.Drawing.Size(92, 75);
            this.txtEdi.TabIndex = 26;
            this.txtEdi.Text = "123456789012";
            this.txtEdi.Leave += new System.EventHandler(this.txtEdi_Leave);
            // 
            // Mustra
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1368, 624);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNiv);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEdi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEje);
            this.Controls.Add(this.txtNE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgMuestras);
            this.DAGeneral = this.sqlDAMuestreador;
            this.dsGeneral = this.dsMuestra1;
            this.MinimizeBox = false;
            this.Name = "Mustra";
            this.NombreTabla = "Muestreador";
            this.Text = "Muestras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mustra_Load);
            this.Controls.SetChildIndex(this.dgMuestras, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.txtNE, 0);
            this.Controls.SetChildIndex(this.txtEje, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtEle, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txtEdi, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txtNiv, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMuestra1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResistencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescarga1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuestras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenCo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResBajo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFechaM1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Mustra_Load(object sender, System.EventArgs e)
		{
            sqlDABusObra.Fill(dsBusObra1, "Obra");

			this.buscaBtn1.Catalogo = this;
            dsResBajo1.ResBajo.AddResBajoRow(1,"Aceptable");
            dsResBajo1.ResBajo.AddResBajoRow(2, "No Aceptable");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(1,"Lanc");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(2,"Cliente");
            dsOrigenCo1.OrigenCo.AddOrigenCoRow(3,"Obra");
            EstableceVistaPrevia(); 
            LlenaLaboratorista(); 
            cmbIdObra.SelectedIndex = 0;
            cmbIdObra.SelectedIndex = 1;
            cmbIdObra.SelectedIndex = 0;
        }
		private void LlenaLaboratorista()
		{
			sqlDANoEco.Fill(dsLaboratorista1, "Laboratorista");
			sqlDANoEco.Fill(dsLaboratorista2, "Laboratorista");
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");
            sqlDAConcretera.Fill(dsConcretera1, "Concretera");
            sqlDAPLanta.Fill(dsPlanta1, "Planta");
            sqlDARes.Fill(dsResistencia1, "Resistencia");
            sqlDAGrado.Fill(dsGrado1, "Grado");
            sqlDATAgregado.Fill(dsAgregado1, "Agregado");
            sqlDADescarga.Fill(dsDescarga1, "Descarga");
            sqlDATipo.Fill(dsTipo1, "Tipo");
            if (cmbIdObra.SelectedValue == null)
                sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = "AC";
            else
                sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            dsMuestra1.Muestras.Clear();
            //sqlDAMuestras.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAMuestras.Fill(dsMuestra1, "Muestras");
		}

		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			txtIdObra.Text = cmbIdObra.SelectedValue.ToString();
            cmbNoEco.SelectedIndex = -1;
            cmbNoEco.SelectedIndex = 1;
            cmbNoEco.SelectedIndex = 0;
			dtpFecha.Value = DateTime.Now.AddDays(1);
			dtpFecha.Value = DateTime.Today; // .Now. .AddMilliseconds(1);
			dtphini.Value  = DateTime.Now.AddDays(1);
			dtphini.Value  = DateTime.Today;
			dtphfin.Value  = DateTime.Now.AddDays(1);
			dtphfin.Value  = DateTime.Today;
		}

		private void EstableceVistaPrevia()
		{
			DataSet dsVP = new DataSet();
			dsBusMues1.Clear();
			sqlDABusq.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			sqlDABusq.Fill(dsBusMues1, "Muestreador");
			dsVistaPrevia = dsBusMues1;//dsVP;
		}

		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
            if (int.Parse(txtNE.Text) != cmbNoEco.SelectedIndex)
                cmbNoEco.SelectedIndex = int.Parse(txtNE.Text);
            try 
			{
				// Intente actualizar el origen de datos.
				base.BindingContext[dsMuestra1,"Muestreador"].Position = this.BindingContext[dsMuestra1,"Muestreador"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}

			EstableceVistaPrevia();
            if (dgMuestras.Rows.Count > 1)
            {
            int sumatoria = 0;
            foreach (DataGridViewRow row in dgMuestras.Rows)
                sumatoria += Convert.ToInt32(row.Cells["Nesp"].Value);    //aqui recorre las celdas y las va sumando
            txtSuma.Text = Convert.ToString(sumatoria);
            if (double.Parse(txtSuma.Text) != double.Parse(txtNcilidros.Text))
            {
                EspPro EP = new EspPro();
                EP.Text = txtIdObra.Text + "|" + dtpFecha.Text;
                DialogResult resp1 = EP.ShowDialog();
                if (resp1 == DialogResult.Cancel)
                {
                }
            }
            }


		}

		public override void LoadDataSet()
		{

            if(cmbIdObra.SelectedValue == null)
                sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = "AC";
            else
                sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
            
            base.LoadDataSet();
            dsMuestra1.Muestras.Clear();
            dsMuestra1.Tables["Muestras"].Clear();
            sqlDAMuestras.SelectCommand.Parameters["@IdObra"].Value = dsMuestra1.Muestreador.Rows[0][0].ToString();
            sqlDAMuestras.Fill(dsMuestra1, "Muestras");
            regist = 0;

		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsMuestra objDataSetChanges = new LancNeo.dsMuestra();
			// Detener las ediciones actuales.
// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsMuestra1,"Muestreador"].EndCurrentEdit();
//			this.BindingContext[dsMuestra1,"Muestras"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));
//Anterior            objDataSetChanges = ((LancNeo.dsMuestra)(dsMuestra1.GetChanges()));

			objDataSetChanges = ((LancNeo.dsMuestra)(dsMuestra1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsMuestra1.Merge(objDataSetChanges);
					dsMuestra1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsMuestra ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAMuestreador.Update(ChangedRows);
					sqlDAMuestras.Update(ChangedRows);
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


		private void clickapl(object sender, System.EventArgs e)
		{
			string apl = dgMuestras.CurrentCell.ToString();
//			MessageBox.Show(sender.ToString()+" "+e.ToString());
//			MessageBox.Show(dgMuestras.Controls[][5].ToString());			
		}


		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsBusMues1.Clear();
			sqlDABusq.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			sqlDABusq.Fill(dsBusMues1, "Muestreador");

			DataSet objDataSetChanges = ((LancNeo.dsMuestra)(dsMuestra1.GetChanges()));
			this.BindingContext[dsMuestra1,"Muestreador"].EndCurrentEdit();
//			this.BindingContext[dsMuestra1,"Muestras"].EndCurrentEdit();
			if ((objDataSetChanges != null)) 
			{
				switch(MessageBox.Show("Desea Guardar los cambios ", "Existen cambios", System.Windows.Forms.MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Yes:
						btnGuardar_Click(sender,null);
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						break;
				}
			}
			this.LoadDataSet();
            //dsMuestra1.Muestras.Clear();
            //sqlDAMuestras.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            //sqlDAMuestras.Fill(dsMuestra1, "Muestras");
//            cambia = 1;
//            dgMuestras_RowEnter(sender, null);
		}

        private void dgMuestras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbNoEco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNE.Text = cmbNoEco.SelectedIndex.ToString();
        }

        private void dgMuestras_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cambia = 0;
        }

        private void dgMuestras_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Tipo"].Value = 1;
            e.Row.Cells["TA"].Value = 1;
            e.Row.Cells["Grado"].Value = "A";
            e.Row.Cells["Descarga"].Value = 1;
            e.Row.Cells["ResBajo"].Value = 1;
            e.Row.Cells["Origen"].Value = 1;
            e.Row.Cells["Nesp"].Value = 4;
        }

 
        private void tbBtn1_Click(object sender, EventArgs e)
        {
            if (dsMuestra1.Muestras.Count > 1)
            {
                dsFechaM1.Clear();
                sqlDAFecha.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			    sqlDAFecha.SelectCommand.Parameters["@Muestra"].Value = txtMuestra.Text.Trim();
			    sqlDAFecha.Fill(dsFechaM1, "Muestras");
                
     			int curr = 0;
                foreach (DataRow dr in dsMuestra1.Muestreador.Rows) 
		    	{
			    	try
				    {					
					    if(dr["Fecha"].ToString() == dsFechaM1.Muestras.Rows[0][0].ToString())
						    break;
                        else
                            curr++;                      
				    }
				    catch(Exception )
				    {
					    //MessageBox.Show(ex.Message);
				    }
				    finally
				    {
					    //curr++;
				    }
    			}
       			try
    			{
	    			this.BindingContext[dsMuestra1,"Muestreador"].Position = curr;
                    this.dsGeneral_PositionChanged();
			    }
			    catch(Exception ex)
			    {
				    statusBar1.Panels[2].Text = ex.Message;	
    //				statusBar1.Panels[2].Icon = iconoError;
    				statusBar1.Panels[2].ToolTipText = ex.Message;
	    		}
            }
        }

        private void dgMuestras_Enter(object sender, EventArgs e)
        {
//            dgMuestras_RowEnter(sender, null);
        }

        private void dgMuestras_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int registros = dgMuestras.Rows.Count;
            regist = (e == null ? 0 : e.RowIndex);
            if (dgMuestras.Rows[regist].Cells[22].Value != null && dgMuestras.Rows[regist].Cells[23].Value != null && dgMuestras.Rows[regist].Cells[24].Value != null && dgMuestras.Rows[regist].Cells[25].Value != null)
            {
                txtEle.Text = dgMuestras.Rows[e.RowIndex].Cells[22].Value.ToString();
                txtEje.Text = dgMuestras.Rows[e.RowIndex].Cells[23].Value.ToString();
                txtNiv.Text = dgMuestras.Rows[e.RowIndex].Cells[24].Value.ToString();
                txtEdi.Text = dgMuestras.Rows[e.RowIndex].Cells[25].Value.ToString();
            }
        }

        private void txtEle_Leave(object sender, EventArgs e)
        {
            dgMuestras.Rows[regist].Cells[22].Value = txtEle.Text;
        }

        private void txtEje_Leave(object sender, EventArgs e)
        {
            dgMuestras.Rows[regist].Cells[23].Value = txtEje.Text;
        }

        private void txtNiv_Leave(object sender, EventArgs e)
        {
            dgMuestras.Rows[regist].Cells[24].Value = txtNiv.Text;
        }

        private void txtEdi_Leave(object sender, EventArgs e)
        {
            dgMuestras.Rows[regist].Cells[25].Value = txtEdi.Text;
        }

        private void dgMuestras_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
 
            cambia = 1;
        }
	}
}


	