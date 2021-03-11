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
	/// Descripción breve de Especimen.
	/// </summary>
	public class Especimen : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAEspecimen;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsEspecimen dsEspecimen1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Windows.Forms.Label lblIdObra;
		private System.Windows.Forms.Label label16;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIdConcretera;
		private System.Windows.Forms.TextBox txtMuestra;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIdPlanta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtResistenciaKg;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtAgregado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtRevenimiento;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtResistencia;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox cmbPrueba;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox cmbIdDiametro;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox cmbNoEco;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.ComboBox cmbVapor;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox textBox5;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsTipoPrueba dsTipoPrueba1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private LancNeo.dsDiametro dsDiametro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorio;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private LancNeo.dsLaboratorio dsLaboratorio1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private LancNeo.dsLaboratorista dsLaboratorista1;
		private System.Windows.Forms.ComboBox cmbLaboratorio;
		private System.Windows.Forms.ComboBox cmbBascula;
		private System.Windows.Forms.ComboBox cmbManometro;
		private System.Windows.Forms.ComboBox cmbPrensa;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrensa;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
		private LancNeo.dsPrensa dsPrensa1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAManometro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsManometro dsManometro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDABascula;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
		private LancNeo.dsBascula dsBascula1;
		private System.Data.SqlClient.SqlDataAdapter sqlDACabeceador;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
		private LancNeo.dsCabeceador dsCabeceador1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAEnsaye;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand10;
		private LancNeo.dsEnsaye dsEnsaye1;
		private System.Windows.Forms.ComboBox cmbEnsaye;
		private System.Windows.Forms.ComboBox cmbCabeceador;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusca1;
		public System.Data.SqlClient.SqlCommand sqlSelectCommand11;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn2;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusca2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand12;
		private LancNeo.dsBusMuestra dsBusMuestra1;
		private System.Windows.Forms.TextBox txtCarga;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.TextBox txtMasa;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.TextBox txtTipoAgregado;
		private System.Windows.Forms.TextBox txtIdUsuario;
		private System.Windows.Forms.DateTimePicker dtpFechac;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand13;
		private System.Data.SqlClient.SqlDataAdapter sqlDAVP;
		private System.Windows.Forms.TextBox txtConcreto;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsBusObra dsBusObra1;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private LancNeo.dsBusEspecimen dsBusEspecimen1;
		private System.Windows.Forms.TextBox txtIdEspecimen;
        private System.Windows.Forms.TextBox txtDia;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Especimen()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			sqlDABusObra.Fill(dsBusObra1, "Obra");

			ArrayList vapores =new ArrayList();
			vapores.Add(new matCombo("Normal",1));
			vapores.Add(new matCombo("Vapor",2));
			cmbVapor.DataSource = vapores; //DataSource for lookup table 
			cmbVapor.DisplayMember = "getName"; //Display value in lookup table
			cmbVapor.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
/*			ArrayList dias =new ArrayList();
			for (int i = 1; i <=100; i++)
				dias.Add(new matCombo(i.ToString().Trim(),i));

			cmbDia.DataSource = dias; //DataSource for lookup table 
			cmbDia.DisplayMember = "getName"; //Display value in lookup table
			cmbDia.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
			ArrayList especim =new ArrayList();
			for (short i = 1; i <=16; i++)
				especim.Add(new matCombo1(i.ToString(),i));
			cmbEspecimen.DataSource = especim; //DataSource for lookup table 
			cmbEspecimen.DisplayMember = "getName"; //Display value in lookup table
			cmbEspecimen.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
*/
//			ArrayList tipos =new ArrayList();
//			tipos.Add(new matCombo("Normal",1));
//			tipos.Add(new matCombo("Rápido",2));
//			cmbTipos.DataSource = tipos; //DataSource for lookup table 
//			cmbTipos.DisplayMember = "getName"; //Display value in lookup table
//			cmbTipos.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}
		protected struct matCombo
		{
			private string Descripcion;
			private int Identificador;
			public matCombo(string Nombre , int id)
			{
				Descripcion=Nombre;
				Identificador = id;
			}
			public string getName
			{
				get
				{
					return Descripcion;
				}
			}
			public int getId
			{
				get
				{
					return Identificador;
				}
			}
		}
		protected struct matCombo1
		{
			private string Descripcion;
			private short Identificador;
			public matCombo1(string Nombre , short id)
			{
				Descripcion=Nombre;
				Identificador = id;
			}
			public string getName
			{
				get
				{
					return Descripcion;
				}
			}
			public short getId
			{
				get
				{
					return Identificador;
				}
			}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especimen));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAEspecimen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsEspecimen1 = new LancNeo.dsEspecimen();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusEspecimen1 = new LancNeo.dsBusEspecimen();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtIdEspecimen = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.txtConcreto = new System.Windows.Forms.TextBox();
            this.txtTipoAgregado = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbEnsaye = new System.Windows.Forms.ComboBox();
            this.dsEnsaye1 = new LancNeo.dsEnsaye();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbCabeceador = new System.Windows.Forms.ComboBox();
            this.dsCabeceador1 = new LancNeo.dsCabeceador();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbBascula = new System.Windows.Forms.ComboBox();
            this.dsBascula1 = new LancNeo.dsBascula();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbManometro = new System.Windows.Forms.ComboBox();
            this.dsManometro1 = new LancNeo.dsManometro();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbPrensa = new System.Windows.Forms.ComboBox();
            this.dsPrensa1 = new LancNeo.dsPrensa();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbNoEco = new System.Windows.Forms.ComboBox();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbIdDiametro = new System.Windows.Forms.ComboBox();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.label17 = new System.Windows.Forms.Label();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbVapor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRevenimiento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAgregado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResistenciaKg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPlanta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdObra = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFechac = new System.Windows.Forms.DateTimePicker();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.txtIdConcretera = new System.Windows.Forms.TextBox();
            this.buscaBtn2 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusMuestra1 = new LancNeo.dsBusMuestra();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrensa = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAManometro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABascula = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACabeceador = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAEnsaye = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusca1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand11 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusca2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAVP = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand13 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEspecimen1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEspecimen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnsaye1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabeceador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBascula1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManometro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrensa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMuestra1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 389);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(736, 24);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(736, 64);
            // 
            // sqlDAEspecimen
            // 
            this.sqlDAEspecimen.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAEspecimen.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAEspecimen.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAEspecimen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Especimen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("IdEspecimen", "IdEspecimen"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Vapor", "Vapor"),
                        new System.Data.Common.DataColumnMapping("Altura", "Altura"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("Carga", "Carga"),
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("Evaluacion", "Evaluacion"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("IdPrensa", "IdPrensa"),
                        new System.Data.Common.DataColumnMapping("IdManometro", "IdManometro"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("IdBascula", "IdBascula"),
                        new System.Data.Common.DataColumnMapping("IdCabeceador", "IdCabeceador"),
                        new System.Data.Common.DataColumnMapping("IdEnsaye", "IdEnsaye"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario"),
                        new System.Data.Common.DataColumnMapping("Fechac", "Fechac"),
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam")})});
            this.sqlDAEspecimen.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdEspecimen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEspecimen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Dia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vapor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vapor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Altura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Altura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Altura", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Altura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diametro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carga", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Carga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Resistencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Resistencia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Resistencia", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resistencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Evaluacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Evaluacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Evaluacion", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Evaluacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdPrensa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdPrensa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrensa", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrensa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdManometro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdManometro", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdManometro", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdManometro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdBascula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdBascula", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdBascula", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdBascula", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdCabeceador", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdCabeceador", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdCabeceador", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCabeceador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdEnsaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdEnsaye", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fechac", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fechac", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fechac", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fechac", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrueba", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdDiam", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDiam", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 0, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@IdEspecimen", System.Data.SqlDbType.SmallInt, 0, "IdEspecimen"),
            new System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Int, 0, "Dia"),
            new System.Data.SqlClient.SqlParameter("@Vapor", System.Data.SqlDbType.Int, 0, "Vapor"),
            new System.Data.SqlClient.SqlParameter("@Altura", System.Data.SqlDbType.Real, 0, "Altura"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Real, 0, "Masa"),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Real, 0, "Area"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.Real, 0, "Diametro"),
            new System.Data.SqlClient.SqlParameter("@Carga", System.Data.SqlDbType.Real, 0, "Carga"),
            new System.Data.SqlClient.SqlParameter("@Resistencia", System.Data.SqlDbType.Float, 0, "Resistencia"),
            new System.Data.SqlClient.SqlParameter("@Evaluacion", System.Data.SqlDbType.Bit, 0, "Evaluacion"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@IdPrensa", System.Data.SqlDbType.NVarChar, 0, "IdPrensa"),
            new System.Data.SqlClient.SqlParameter("@IdManometro", System.Data.SqlDbType.SmallInt, 0, "IdManometro"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@IdBascula", System.Data.SqlDbType.NVarChar, 0, "IdBascula"),
            new System.Data.SqlClient.SqlParameter("@IdCabeceador", System.Data.SqlDbType.NVarChar, 0, "IdCabeceador"),
            new System.Data.SqlClient.SqlParameter("@IdEnsaye", System.Data.SqlDbType.SmallInt, 0, "IdEnsaye"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Fechac", System.Data.SqlDbType.DateTime, 0, "Fechac"),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 0, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 0, "IdDiam")});
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
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 0, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@IdEspecimen", System.Data.SqlDbType.SmallInt, 0, "IdEspecimen"),
            new System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Int, 0, "Dia"),
            new System.Data.SqlClient.SqlParameter("@Vapor", System.Data.SqlDbType.Int, 0, "Vapor"),
            new System.Data.SqlClient.SqlParameter("@Altura", System.Data.SqlDbType.Real, 0, "Altura"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Real, 0, "Masa"),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Real, 0, "Area"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.Real, 0, "Diametro"),
            new System.Data.SqlClient.SqlParameter("@Carga", System.Data.SqlDbType.Real, 0, "Carga"),
            new System.Data.SqlClient.SqlParameter("@Resistencia", System.Data.SqlDbType.Float, 0, "Resistencia"),
            new System.Data.SqlClient.SqlParameter("@Evaluacion", System.Data.SqlDbType.Bit, 0, "Evaluacion"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@IdPrensa", System.Data.SqlDbType.NVarChar, 0, "IdPrensa"),
            new System.Data.SqlClient.SqlParameter("@IdManometro", System.Data.SqlDbType.SmallInt, 0, "IdManometro"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@IdBascula", System.Data.SqlDbType.NVarChar, 0, "IdBascula"),
            new System.Data.SqlClient.SqlParameter("@IdCabeceador", System.Data.SqlDbType.NVarChar, 0, "IdCabeceador"),
            new System.Data.SqlClient.SqlParameter("@IdEnsaye", System.Data.SqlDbType.SmallInt, 0, "IdEnsaye"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Fechac", System.Data.SqlDbType.DateTime, 0, "Fechac"),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 0, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 0, "IdDiam"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdEspecimen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEspecimen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Dia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vapor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vapor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Altura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Altura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Altura", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Altura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diametro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carga", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Carga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Resistencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Resistencia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Resistencia", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resistencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Evaluacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Evaluacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Evaluacion", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Evaluacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdPrensa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdPrensa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrensa", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrensa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdManometro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdManometro", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdManometro", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdManometro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdBascula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdBascula", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdBascula", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdBascula", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdCabeceador", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdCabeceador", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdCabeceador", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCabeceador", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdEnsaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdEnsaye", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fechac", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fechac", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fechac", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fechac", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrueba", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdDiam", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDiam", System.Data.DataRowVersion.Original, null)});
            // 
            // dsEspecimen1
            // 
            this.dsEspecimen1.DataSetName = "dsEspecimen";
            this.dsEspecimen1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsEspecimen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtDia);
            this.panel2.Controls.Add(this.txtIdEspecimen);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.txtConcreto);
            this.panel2.Controls.Add(this.txtTipoAgregado);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.txtCarga);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.txtMasa);
            this.panel2.Controls.Add(this.txtAltura);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.cmbEnsaye);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.cmbCabeceador);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.cmbBascula);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.cmbManometro);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.cmbPrensa);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.cmbNoEco);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.cmbLaboratorio);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.cmbIdDiametro);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.cmbPrueba);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtResistencia);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cmbVapor);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtGrado);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtRevenimiento);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtAgregado);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtResistenciaKg);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtIdPlanta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMuestra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblIdObra);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.dtpFechac);
            this.panel2.Controls.Add(this.txtIdUsuario);
            this.panel2.Controls.Add(this.txtIdobra);
            this.panel2.Controls.Add(this.txtIdConcretera);
            this.panel2.Controls.Add(this.buscaBtn2);
            this.panel2.Location = new System.Drawing.Point(8, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 288);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusEspecimen1.Especimen;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(112, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 7;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsBusEspecimen1
            // 
            this.dsBusEspecimen1.DataSetName = "dsBusEspecimen";
            this.dsBusEspecimen1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusEspecimen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDia
            // 
            this.txtDia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Dia", true));
            this.txtDia.Location = new System.Drawing.Point(128, 126);
            this.txtDia.MaxLength = 3;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(80, 20);
            this.txtDia.TabIndex = 5;
            this.txtDia.Text = "3";
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIdEspecimen
            // 
            this.txtIdEspecimen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.IdEspecimen", true));
            this.txtIdEspecimen.Location = new System.Drawing.Point(128, 102);
            this.txtIdEspecimen.MaxLength = 2;
            this.txtIdEspecimen.Name = "txtIdEspecimen";
            this.txtIdEspecimen.Size = new System.Drawing.Size(80, 20);
            this.txtIdEspecimen.TabIndex = 4;
            this.txtIdEspecimen.Text = "1";
            this.txtIdEspecimen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(48, 40);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(64, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "Idobra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            this.cmbIdObra.Leave += new System.EventHandler(this.cmbIdObra_Leave);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConcreto
            // 
            this.txtConcreto.Enabled = false;
            this.txtConcreto.Location = new System.Drawing.Point(408, 66);
            this.txtConcreto.Name = "txtConcreto";
            this.txtConcreto.ReadOnly = true;
            this.txtConcreto.Size = new System.Drawing.Size(56, 20);
            this.txtConcreto.TabIndex = 72;
            this.txtConcreto.Text = "textBox1";
            // 
            // txtTipoAgregado
            // 
            this.txtTipoAgregado.Enabled = false;
            this.txtTipoAgregado.Location = new System.Drawing.Point(664, 64);
            this.txtTipoAgregado.Name = "txtTipoAgregado";
            this.txtTipoAgregado.ReadOnly = true;
            this.txtTipoAgregado.Size = new System.Drawing.Size(48, 20);
            this.txtTipoAgregado.TabIndex = 69;
            this.txtTipoAgregado.Text = "textBox1";
            // 
            // txtFecha
            // 
            this.txtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Fecha", true));
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(392, 8);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(72, 20);
            this.txtFecha.TabIndex = 67;
            this.txtFecha.Text = "textBox1";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Diametro", true));
            this.textBox5.Location = new System.Drawing.Point(608, 256);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 44;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCarga
            // 
            this.txtCarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Carga", true));
            this.txtCarga.Location = new System.Drawing.Point(608, 230);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCarga.TabIndex = 42;
            this.txtCarga.Text = "0";
            this.txtCarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            this.txtArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Area", true));
            this.txtArea.Location = new System.Drawing.Point(608, 204);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 40;
            this.txtArea.Text = "0";
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMasa
            // 
            this.txtMasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Masa", true));
            this.txtMasa.Location = new System.Drawing.Point(608, 179);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(100, 20);
            this.txtMasa.TabIndex = 38;
            this.txtMasa.Text = "0";
            this.txtMasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAltura
            // 
            this.txtAltura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Altura", true));
            this.txtAltura.Location = new System.Drawing.Point(608, 152);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 36;
            this.txtAltura.Text = "0";
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(552, 258);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 13);
            this.label30.TabIndex = 59;
            this.label30.Text = "Diámetro:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(568, 232);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 58;
            this.label28.Text = "Carga:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(576, 206);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 13);
            this.label29.TabIndex = 57;
            this.label29.Text = "Area:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(568, 181);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 13);
            this.label27.TabIndex = 56;
            this.label27.Text = "Masa:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(568, 152);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 55;
            this.label26.Text = "Altura:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEnsaye
            // 
            this.cmbEnsaye.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.IdEnsaye", true));
            this.cmbEnsaye.DataSource = this.dsEnsaye1.Ensaye;
            this.cmbEnsaye.DisplayMember = "Ensaye";
            this.cmbEnsaye.Location = new System.Drawing.Point(328, 256);
            this.cmbEnsaye.Name = "cmbEnsaye";
            this.cmbEnsaye.Size = new System.Drawing.Size(184, 21);
            this.cmbEnsaye.TabIndex = 34;
            this.cmbEnsaye.ValueMember = "IdEnsaye";
            // 
            // dsEnsaye1
            // 
            this.dsEnsaye1.DataSetName = "dsEnsaye";
            this.dsEnsaye1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsEnsaye1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(272, 258);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "Ensaye:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCabeceador
            // 
            this.cmbCabeceador.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.IdCabeceador", true));
            this.cmbCabeceador.DataSource = this.dsCabeceador1.Cabeceador;
            this.cmbCabeceador.DisplayMember = "Cabeceador";
            this.cmbCabeceador.Location = new System.Drawing.Point(328, 230);
            this.cmbCabeceador.Name = "cmbCabeceador";
            this.cmbCabeceador.Size = new System.Drawing.Size(184, 21);
            this.cmbCabeceador.TabIndex = 32;
            this.cmbCabeceador.ValueMember = "IdCabaceador";
            // 
            // dsCabeceador1
            // 
            this.dsCabeceador1.DataSetName = "dsCabeceador";
            this.dsCabeceador1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsCabeceador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(248, 232);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 51;
            this.label24.Text = "Cabeceador:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBascula
            // 
            this.cmbBascula.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.IdBascula", true));
            this.cmbBascula.DataSource = this.dsBascula1.Bascula;
            this.cmbBascula.DisplayMember = "Bascula";
            this.cmbBascula.Location = new System.Drawing.Point(328, 204);
            this.cmbBascula.Name = "cmbBascula";
            this.cmbBascula.Size = new System.Drawing.Size(184, 21);
            this.cmbBascula.TabIndex = 30;
            this.cmbBascula.ValueMember = "IdBascula";
            // 
            // dsBascula1
            // 
            this.dsBascula1.DataSetName = "dsBascula";
            this.dsBascula1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBascula1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(264, 206);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "Bascula:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbManometro
            // 
            this.cmbManometro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.IdManometro", true));
            this.cmbManometro.DataSource = this.dsManometro1.Manometro;
            this.cmbManometro.DisplayMember = "Manometro";
            this.cmbManometro.Location = new System.Drawing.Point(328, 179);
            this.cmbManometro.Name = "cmbManometro";
            this.cmbManometro.Size = new System.Drawing.Size(184, 21);
            this.cmbManometro.TabIndex = 28;
            this.cmbManometro.ValueMember = "IdManometro";
            // 
            // dsManometro1
            // 
            this.dsManometro1.DataSetName = "dsManometro";
            this.dsManometro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsManometro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(248, 181);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Manómetro:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPrensa
            // 
            this.cmbPrensa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.IdPrensa", true));
            this.cmbPrensa.DataSource = this.dsPrensa1.Prensa;
            this.cmbPrensa.DisplayMember = "Prensa";
            this.cmbPrensa.Location = new System.Drawing.Point(328, 152);
            this.cmbPrensa.Name = "cmbPrensa";
            this.cmbPrensa.Size = new System.Drawing.Size(184, 21);
            this.cmbPrensa.TabIndex = 26;
            this.cmbPrensa.ValueMember = "IdPrensa";
            // 
            // dsPrensa1
            // 
            this.dsPrensa1.DataSetName = "dsPrensa";
            this.dsPrensa1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPrensa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(272, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "Prensa:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNoEco
            // 
            this.cmbNoEco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.NoEco", true));
            this.cmbNoEco.DataSource = this.dsLaboratorista1.Laboratorista;
            this.cmbNoEco.DisplayMember = "NoEco";
            this.cmbNoEco.Location = new System.Drawing.Point(328, 126);
            this.cmbNoEco.Name = "cmbNoEco";
            this.cmbNoEco.Size = new System.Drawing.Size(72, 21);
            this.cmbNoEco.TabIndex = 11;
            this.cmbNoEco.ValueMember = "NoEco";
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(240, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Laboratorista:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.IdLaboratorio", true));
            this.cmbLaboratorio.DataSource = this.dsLaboratorio1.Laboratorio;
            this.cmbLaboratorio.DisplayMember = "IdLaboratorio";
            this.cmbLaboratorio.Location = new System.Drawing.Point(328, 102);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(72, 21);
            this.cmbLaboratorio.TabIndex = 10;
            this.cmbLaboratorio.ValueMember = "IdLaboratorio";
            // 
            // dsLaboratorio1
            // 
            this.dsLaboratorio1.DataSetName = "dsLaboratorio";
            this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(248, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Laboratorio:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbIdDiametro
            // 
            this.cmbIdDiametro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.IdDiam", true));
            this.cmbIdDiametro.DataSource = this.dsDiametro1.Diametro;
            this.cmbIdDiametro.DisplayMember = "Diametro";
            this.cmbIdDiametro.Location = new System.Drawing.Point(128, 230);
            this.cmbIdDiametro.Name = "cmbIdDiametro";
            this.cmbIdDiametro.Size = new System.Drawing.Size(80, 21);
            this.cmbIdDiametro.TabIndex = 9;
            this.cmbIdDiametro.ValueMember = "IdDiam";
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(76, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Envase:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.IdPrueba", true));
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(128, 204);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(80, 21);
            this.cmbPrueba.TabIndex = 8;
            this.cmbPrueba.ValueMember = "IdPrueba";
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(77, 206);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Prueba:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResistencia
            // 
            this.txtResistencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Resistencia", true));
            this.txtResistencia.Location = new System.Drawing.Point(128, 152);
            this.txtResistencia.MaxLength = 7;
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.Size = new System.Drawing.Size(80, 20);
            this.txtResistencia.TabIndex = 6;
            this.txtResistencia.Text = "0";
            this.txtResistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Resistencia:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbVapor
            // 
            this.cmbVapor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsEspecimen1, "Especimen.Vapor", true));
            this.cmbVapor.ItemHeight = 13;
            this.cmbVapor.Location = new System.Drawing.Point(128, 179);
            this.cmbVapor.Name = "cmbVapor";
            this.cmbVapor.Size = new System.Drawing.Size(80, 21);
            this.cmbVapor.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Curado:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(97, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Dia:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "TA:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrado
            // 
            this.txtGrado.Enabled = false;
            this.txtGrado.Location = new System.Drawing.Point(616, 66);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.ReadOnly = true;
            this.txtGrado.Size = new System.Drawing.Size(16, 20);
            this.txtGrado.TabIndex = 28;
            this.txtGrado.Text = "textBox1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(584, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "GC:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRevenimiento
            // 
            this.txtRevenimiento.Enabled = false;
            this.txtRevenimiento.Location = new System.Drawing.Point(560, 66);
            this.txtRevenimiento.Name = "txtRevenimiento";
            this.txtRevenimiento.ReadOnly = true;
            this.txtRevenimiento.Size = new System.Drawing.Size(24, 20);
            this.txtRevenimiento.TabIndex = 26;
            this.txtRevenimiento.Text = "textBox1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "RV:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAgregado
            // 
            this.txtAgregado.Enabled = false;
            this.txtAgregado.Location = new System.Drawing.Point(496, 66);
            this.txtAgregado.Name = "txtAgregado";
            this.txtAgregado.ReadOnly = true;
            this.txtAgregado.Size = new System.Drawing.Size(24, 20);
            this.txtAgregado.TabIndex = 24;
            this.txtAgregado.Text = "textBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "TMA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "TP:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResistenciaKg
            // 
            this.txtResistenciaKg.Enabled = false;
            this.txtResistenciaKg.Location = new System.Drawing.Point(336, 66);
            this.txtResistenciaKg.Name = "txtResistenciaKg";
            this.txtResistenciaKg.ReadOnly = true;
            this.txtResistenciaKg.Size = new System.Drawing.Size(40, 20);
            this.txtResistenciaKg.TabIndex = 20;
            this.txtResistenciaKg.Text = "textBox1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "f\'c:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(328, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Concreto solicitado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdPlanta
            // 
            this.txtIdPlanta.Enabled = false;
            this.txtIdPlanta.Location = new System.Drawing.Point(248, 40);
            this.txtIdPlanta.Name = "txtIdPlanta";
            this.txtIdPlanta.ReadOnly = true;
            this.txtIdPlanta.Size = new System.Drawing.Size(80, 20);
            this.txtIdPlanta.TabIndex = 17;
            this.txtIdPlanta.Text = "textBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "IdPlanta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IdConcretera:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMuestra
            // 
            this.txtMuestra.Enabled = false;
            this.txtMuestra.Location = new System.Drawing.Point(664, 8);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.ReadOnly = true;
            this.txtMuestra.Size = new System.Drawing.Size(48, 20);
            this.txtMuestra.TabIndex = 14;
            this.txtMuestra.Text = "textBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Muestra:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "IdEspecimen:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Consecutivo", true));
            this.txtConsecutivo.Enabled = false;
            this.txtConsecutivo.Location = new System.Drawing.Point(552, 8);
            this.txtConsecutivo.MaxLength = 5;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.ReadOnly = true;
            this.txtConsecutivo.Size = new System.Drawing.Size(32, 20);
            this.txtConsecutivo.TabIndex = 9;
            this.txtConsecutivo.Text = "textBox1";
            this.txtConsecutivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consecutivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIdObra
            // 
            this.lblIdObra.AutoSize = true;
            this.lblIdObra.Location = new System.Drawing.Point(0, 40);
            this.lblIdObra.Name = "lblIdObra";
            this.lblIdObra.Size = new System.Drawing.Size(42, 13);
            this.lblIdObra.TabIndex = 5;
            this.lblIdObra.Text = "IdObra:";
            this.lblIdObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(344, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Fecha:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechac
            // 
            this.dtpFechac.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.Fechac", true));
            this.dtpFechac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechac.Location = new System.Drawing.Point(608, 36);
            this.dtpFechac.Name = "dtpFechac";
            this.dtpFechac.Size = new System.Drawing.Size(80, 20);
            this.dtpFechac.TabIndex = 71;
            this.dtpFechac.Value = new System.DateTime(2004, 8, 25, 12, 1, 0, 0);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.IdUsuario", true));
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Location = new System.Drawing.Point(560, 36);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(32, 20);
            this.txtIdUsuario.TabIndex = 70;
            // 
            // txtIdobra
            // 
            this.txtIdobra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsEspecimen1, "Especimen.IdObra", true));
            this.txtIdobra.Enabled = false;
            this.txtIdobra.Location = new System.Drawing.Point(120, 24);
            this.txtIdobra.MaxLength = 6;
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 3;
            this.txtIdobra.Text = "textBox1";
            // 
            // txtIdConcretera
            // 
            this.txtIdConcretera.Enabled = false;
            this.txtIdConcretera.Location = new System.Drawing.Point(248, 8);
            this.txtIdConcretera.Name = "txtIdConcretera";
            this.txtIdConcretera.ReadOnly = true;
            this.txtIdConcretera.Size = new System.Drawing.Size(80, 20);
            this.txtIdConcretera.TabIndex = 13;
            this.txtIdConcretera.Text = "textBox1";
            // 
            // buscaBtn2
            // 
            this.buscaBtn2.AnchoColTit = true;
            this.buscaBtn2.AnchoDlgBusq = 700;
            this.buscaBtn2.BackColor = System.Drawing.SystemColors.Control;
            this.buscaBtn2.Datos = this.dsBusMuestra1.Muestras;
            this.buscaBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn2.Icon")));
            this.buscaBtn2.Location = new System.Drawing.Point(112, 0);
            this.buscaBtn2.Name = "buscaBtn2";
            this.buscaBtn2.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn2.TabIndex = 8;
            this.buscaBtn2.Visible = false;
            this.buscaBtn2.Click += new System.EventHandler(this.buscaBtn2_Click);
            // 
            // dsBusMuestra1
            // 
            this.dsBusMuestra1.DataSetName = "dsBusMuestra";
            this.dsBusMuestra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusMuestra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAPrueba
            // 
            this.sqlDAPrueba.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAPrueba.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipoprueba", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdPrueba, Prueba FROM Tipoprueba";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDADiametro
            // 
            this.sqlDADiametro.SelectCommand = this.sqlSelectCommand3;
            this.sqlDADiametro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Diametro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdDiam, Diametro FROM Diametro";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDALaboratorio
            // 
            this.sqlDALaboratorio.SelectCommand = this.sqlSelectCommand4;
            this.sqlDALaboratorio.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT IdLaboratorio, Laboratorio, IdZona FROM Laboratorio ORDER BY IdLaboratorio" +
                ", Laboratorio";
            this.sqlSelectCommand4.Connection = this.sqlConn;
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
            this.sqlSelectCommand5.CommandText = "SELECT NoEco, Laboratorista, IdZona, IdNivel, Fechai FROM Laboratorista ORDER BY " +
                "NoEco";
            this.sqlSelectCommand5.Connection = this.sqlConn;
            // 
            // sqlDAPrensa
            // 
            this.sqlDAPrensa.SelectCommand = this.sqlSelectCommand6;
            this.sqlDAPrensa.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Prensa", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrensa", "IdPrensa"),
                        new System.Data.Common.DataColumnMapping("Prensa", "Prensa")})});
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = "SELECT IdPrensa, Prensa FROM Prensa";
            this.sqlSelectCommand6.Connection = this.sqlConn;
            // 
            // sqlDAManometro
            // 
            this.sqlDAManometro.SelectCommand = this.sqlSelectCommand7;
            this.sqlDAManometro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Manometro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdManometro", "IdManometro"),
                        new System.Data.Common.DataColumnMapping("Manometro", "Manometro")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT IdManometro, Manometro FROM Manometro";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // sqlDABascula
            // 
            this.sqlDABascula.SelectCommand = this.sqlSelectCommand8;
            this.sqlDABascula.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Bascula", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdBascula", "IdBascula"),
                        new System.Data.Common.DataColumnMapping("Bascula", "Bascula")})});
            // 
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = "SELECT IdBascula, Bascula FROM Bascula";
            this.sqlSelectCommand8.Connection = this.sqlConn;
            // 
            // sqlDACabeceador
            // 
            this.sqlDACabeceador.SelectCommand = this.sqlSelectCommand9;
            this.sqlDACabeceador.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Cabeceador", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCabaceador", "IdCabaceador"),
                        new System.Data.Common.DataColumnMapping("Cabeceador", "Cabeceador")})});
            // 
            // sqlSelectCommand9
            // 
            this.sqlSelectCommand9.CommandText = "SELECT IdCabaceador, Cabeceador FROM Cabeceador";
            this.sqlSelectCommand9.Connection = this.sqlConn;
            // 
            // sqlDAEnsaye
            // 
            this.sqlDAEnsaye.SelectCommand = this.sqlSelectCommand10;
            this.sqlDAEnsaye.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Ensaye", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdEnsaye", "IdEnsaye"),
                        new System.Data.Common.DataColumnMapping("Ensaye", "Ensaye")})});
            // 
            // sqlSelectCommand10
            // 
            this.sqlSelectCommand10.CommandText = "SELECT IdEnsaye, Ensaye FROM Ensaye";
            this.sqlSelectCommand10.Connection = this.sqlConn;
            // 
            // sqlDABusca1
            // 
            this.sqlDABusca1.SelectCommand = this.sqlSelectCommand11;
            this.sqlDABusca1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Especimen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("IdEspecimen", "IdEspecimen")})});
            // 
            // sqlSelectCommand11
            // 
            this.sqlSelectCommand11.CommandText = resources.GetString("sqlSelectCommand11.CommandText");
            this.sqlSelectCommand11.Connection = this.sqlConn;
            this.sqlSelectCommand11.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Obra")});
            // 
            // sqlDABusca2
            // 
            this.sqlDABusca2.SelectCommand = this.sqlSelectCommand12;
            this.sqlDABusca2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado")})});
            // 
            // sqlSelectCommand12
            // 
            this.sqlSelectCommand12.CommandText = resources.GetString("sqlSelectCommand12.CommandText");
            this.sqlSelectCommand12.Connection = this.sqlConn;
            this.sqlSelectCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Obra")});
            // 
            // sqlDAVP
            // 
            this.sqlDAVP.SelectCommand = this.sqlSelectCommand13;
            this.sqlDAVP.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Especimen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Agregados", "Agregados"),
                        new System.Data.Common.DataColumnMapping("IdEspecimen", "IdEspecimen"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Vapor", "Vapor"),
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro")})});
            // 
            // sqlSelectCommand13
            // 
            this.sqlSelectCommand13.CommandText = resources.GetString("sqlSelectCommand13.CommandText");
            this.sqlSelectCommand13.Connection = this.sqlConn;
            this.sqlSelectCommand13.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Obra")});
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
            // Especimen
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(736, 413);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAEspecimen;
            this.dsGeneral = this.dsEspecimen1;
            this.LandScape = true;
            this.Name = "Especimen";
            this.NombreTabla = "Especimen";
            this.Text = "Especimen";
            this.Load += new System.EventHandler(this.Especimen_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsEspecimen1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEspecimen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnsaye1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabeceador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBascula1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManometro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrensa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMuestra1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void Especimen_Load(object sender, System.EventArgs e)
		{
			cmbIdObra.SelectedIndex = 0;
			LlenasSqlDA();
			this.buscaBtn1.Catalogo = this;
			EstableceVistaPrevia();
		}
		private void LlenasSqlDA()
		{
			sqlDAPrueba.Fill(dsTipoPrueba1, "Tipoprueba");
			sqlDADiametro.Fill(dsDiametro1, "Diametro");
			sqlDALaboratorio.Fill(dsLaboratorio1, "Laboratorio");
			sqlDALaboratorista.Fill(dsLaboratorista1, "Laboratorista");
			sqlDAPrensa.Fill(dsPrensa1, "Prensa");
			sqlDAManometro.Fill(dsManometro1, "Manometro");
			sqlDABascula.Fill(dsBascula1, "Bascula");
			sqlDACabeceador.Fill(dsCabeceador1, "Cabeceador");
			sqlDAEnsaye.Fill(dsEnsaye1, "Ensaye");
			dsEspecimen1.Clear();
			dsBusMuestra1.Clear();
			sqlDABusca1.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			sqlDABusca1.Fill(dsBusEspecimen1,"Especimen");
			sqlDABusca2.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			sqlDABusca2.Fill(dsBusMuestra1,"Muestras");
		}

		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = false;
			this.buscaBtn2.Visible = true;
			base.btnNuevo_Click(sender, e);
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			txtIdUsuario.Text = "admin";
			dtpFechac.Value = DateTime.Now.AddDays(1);
			dtpFechac.Value = DateTime.Today; // .Now. .AddMilliseconds(1);
			
			cmbPrueba.SelectedIndex = 1;
			cmbPrueba.SelectedIndex = 0;
			cmbIdDiametro.SelectedIndex = 1;
			cmbIdDiametro.SelectedIndex = 0;
			cmbVapor.SelectedIndex = 0;
			cmbLaboratorio.SelectedIndex = -1;
			cmbLaboratorio.SelectedIndex = 0;
			cmbNoEco.SelectedIndex = -1;
			cmbNoEco.SelectedIndex = 0;
			cmbPrensa.SelectedIndex = -1;
			cmbManometro.SelectedIndex = -1;
			cmbBascula.SelectedIndex = -1;
			cmbCabeceador.SelectedIndex = -1;
			cmbEnsaye.SelectedIndex = -1;
		}

		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = true;
			this.buscaBtn2.Visible = false;
			base.btnGuardar_Click(sender, e);
			dsBusEspecimen1.Clear();
			dsBusMuestra1.Clear();
			sqlDABusca1.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			sqlDABusca1.Fill(dsBusEspecimen1,"Especimen");
			sqlDABusca2.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			sqlDABusca2.Fill(dsBusMuestra1,"Muestras");
			EstableceVistaPrevia();
		}
		protected override void btnEliminar_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = true;
			this.buscaBtn2.Visible = false;
			base.btnEliminar_Click(sender, e);
		}
	
		protected override void btnCancelar_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = true;
			this.buscaBtn2.Visible = false;
			base.btnCancelar_Click(sender, e);
		}
		protected override void btnDeshacer_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = true;
			this.buscaBtn2.Visible = false;
			base.btnDeshacer_Click(sender, e);
		}
		protected override void btnPrimero_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = true;
			this.buscaBtn2.Visible = false;
			base.btnPrimero_Click(sender, e);
			posiciona(this.BindingContext[dsEspecimen1,"Especimen"].Position);
		}
		protected override void btnAnterior_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = true;
			this.buscaBtn2.Visible = false;
			base.btnAnterior_Click(sender, e);
			posiciona(this.BindingContext[dsEspecimen1,"Especimen"].Position);
		}
	
		protected override void btnSiguiente_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = true;
			this.buscaBtn2.Visible = false;
			base.btnSiguiente_Click(sender, e);
			posiciona(this.BindingContext[dsEspecimen1,"Especimen"].Position);
		}
		protected override void btnUltimo_Click(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Visible = true;
			this.buscaBtn2.Visible = false;
			base.btnUltimo_Click(sender, e);
			posiciona(this.BindingContext[dsEspecimen1,"Especimen"].Position);
		}

		private void EstableceVistaPrevia()
		{
			DataSet dsVP = new DataSet();
			sqlDAVP.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			sqlDAVP.Fill(dsVP, "Especimen");
			dsVistaPrevia = dsVP;//dsVP;
		}


		private void buscaBtn2_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (dsBusMuestra1.Tables.Count >= 0)
				{
					txtIdobra.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][0].ToString();
					txtFecha.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][2].ToString();
					txtConsecutivo.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][3].ToString();
					txtMuestra.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][1].ToString();
					txtIdConcretera.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][4].ToString();
					txtIdPlanta.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][5].ToString();
					txtResistenciaKg.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][6].ToString();
					txtConcreto.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][7].ToString();
					txtAgregado.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][8].ToString();
					txtRevenimiento.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][9].ToString();
					txtGrado.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][10].ToString();
					txtTipoAgregado.Text = dsBusMuestra1.Tables["Muestras"].Rows[buscaBtn2.RegistroSeleccionado][11].ToString();
				}
			}
			catch(Exception ex)
			{
				//MessageBox.Show(ex.Message );
			}
		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (dsBusEspecimen1.Tables.Count >= 0)
				{
					txtMuestra.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][3].ToString();
					txtIdConcretera.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][5].ToString();
					txtIdPlanta.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][6].ToString();
					txtResistenciaKg.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][7].ToString();
					txtConcreto.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][8].ToString();
					txtAgregado.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][9].ToString();
					txtRevenimiento.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][10].ToString();
					txtGrado.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][11].ToString();
					txtTipoAgregado.Text = dsBusEspecimen1.Tables["Especimen"].Rows[buscaBtn1.RegistroSeleccionado][12].ToString();
				}
			}
			catch(Exception ex)
			{
				//MessageBox.Show(ex.Message );
			}
		}
		private void posiciona(int registro)
		{
			try
			{
				if (dsBusEspecimen1.Tables.Count >= 0)
				{
					txtMuestra.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][3].ToString();
					txtIdConcretera.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][5].ToString();
					txtIdPlanta.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][6].ToString();
					txtResistenciaKg.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][7].ToString();
					txtConcreto.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][8].ToString();
					txtAgregado.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][9].ToString();
					txtRevenimiento.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][10].ToString();
					txtGrado.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][11].ToString();
					txtTipoAgregado.Text = dsBusEspecimen1.Tables["Especimen"].Rows[registro][12].ToString();
				}
			}
			catch(Exception ex)
			{
				//MessageBox.Show(ex.Message );
			}
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
//			if (txtIdobra.Text != cmbIdObra.SelectedValue.ToString())
			{
				txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
				dsBusEspecimen1.Clear();
				dsBusMuestra1.Clear();
				sqlDABusca1.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
				sqlDABusca1.Fill(dsBusEspecimen1,"Especimen");
				sqlDABusca2.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
				sqlDABusca2.Fill(dsBusMuestra1,"Muestras");

				DataSet objDataSetChanges = ((LancNeo.dsEspecimen)(dsEspecimen1.GetChanges()));
				this.BindingContext[dsEspecimen1,"Especimen"].EndCurrentEdit();
				if ((objDataSetChanges != null)) 
				{
					switch(MessageBox.Show("Desea Guardar los cambios ", "Existen cambios", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						case DialogResult.Yes:
							btnGuardar_Click(sender,null);
							break;
						case DialogResult.No:
							break;
					}
				}
				this.LoadDataSet();
				dsEspecimen1.Clear();
				sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
				sqlDAEspecimen.Fill(dsEspecimen1, "Especimen");
				EstableceVistaPrevia();
			}
		}
		public override void LoadDataSet()
		{

			sqlDAEspecimen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			base.LoadDataSet();
//			dgMuestras.SetDataBinding(dsMuestra1, "Muestreador.MuestreadorMuestras");
		}

		private void cmbIdObra_Leave(object sender, System.EventArgs e)
		{
			cmbIdObra_SelectedIndexChanged(sender, null);
		}



	}
}
