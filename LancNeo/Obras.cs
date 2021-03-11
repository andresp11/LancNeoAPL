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
	/// Descripción breve de Obras.
	/// </summary>
	public class Obras : CatalogoGenerico
	{
        private string IdUsuario;
       
        private System.Data.SqlClient.SqlDataAdapter sqlDAObras;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsObra dsObra1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtIdObra;
		private System.Windows.Forms.Label label1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsBusObra dsBusObra1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUbicacion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSuperintendente;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtJfrente;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtSolicitud;
		private System.Windows.Forms.TextBox txtPresupuesto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label20;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusEmpresa;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusCliente;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
        private LancNeo.dsBusCliente dsBusCliente1;
        private LancNeo.dsLaboratorista dsLaboratorista1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private LancNeo.dsLaboratorio dsLaboratorio1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorio;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDAZona;
        private LancNeo.dsZona dsZona1;
		private System.Windows.Forms.TextBox txtObra;
		private System.Windows.Forms.ComboBox cmbRfc;
		private System.Windows.Forms.ComboBox cmbCliente;
		private System.Windows.Forms.ComboBox cmbZona;
		private System.Windows.Forms.ComboBox cmbNoEco;
		private System.Windows.Forms.ComboBox cmbLaboratorio;
		private System.Windows.Forms.ComboBox cmbSoldadura;
		private System.Windows.Forms.ComboBox cmbCarpeta;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox cmbOrigen;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox cmbCoef;
		private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtPresupuestoz;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private TextBox txtParadox;
        private Label label26;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private Label label28;
        private TextBox textBox4;
        private Label label27;
        private TextBox textBox3;
        private Label label33;
        private Label label32;
        private Label label31;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private Label label30;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label29;
        private GroupBox groupBox3;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox9;
        private TextBox textBox8;
        private RadioButton radioButton8;
        private Label label35;
        private TextBox textBox12;
        private Label label36;
        private TextBox textBox13;
        private Label label34;
        private TextBox textBox11;
        private Label label25;
        private TextBox textBox10;
        private CachedCryTarjeta cachedCryTarjeta1;
        private CachedCryTarjeta cachedCryTarjeta2;
        private dsBusEmp dsBusEmp1;
        private TextBox textBox14;
        private Label label37;
        private TextBox textBox19;
        private Label label42;
        private TextBox textBox18;
        private Label label41;
        private TextBox textBox17;
        private Label label40;
        private TextBox textBox16;
        private Label label39;
        private TextBox textBox15;
        private Label label38;
        private TextBox textBox20;
        private CheckBox checkBox10;
        private Label label43;
        private TextBox textBox21;
        private Label label44;
        private TextBox txtUsrMov;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        protected tbBtn tbBtn1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Obras()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
            InitializeComponent();
			ArrayList soldadura =new ArrayList();
			soldadura.Add(new matCombo1("Si",1));
			soldadura.Add(new matCombo1("No",2));
			cmbSoldadura.DataSource = soldadura; //DataSource for lookup table 
			cmbSoldadura.DisplayMember = "getName"; //Display value in lookup table
			cmbSoldadura.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
			ArrayList carpeta =new ArrayList();
			carpeta.Add(new matCombo2("Chica","C"));
			carpeta.Add(new matCombo2("Grande","G"));
			cmbCarpeta.DataSource = carpeta; //DataSource for lookup table 
			cmbCarpeta.DisplayMember = "getName"; //Display value in lookup table
			cmbCarpeta.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
			ArrayList Origen =new ArrayList();
			Origen.Add(new matCombo1("Origen",1));
			Origen.Add(new matCombo1("Destino",2));
			cmbOrigen.DataSource = Origen; //DataSource for lookup table 
			cmbOrigen.DisplayMember = "getName"; //Display value in lookup table
			cmbOrigen.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
			ArrayList Coef =new ArrayList();
			Coef.Add(new matCombo1("Si",1));
			Coef.Add(new matCombo1("No",2));
			cmbCoef.DataSource = Coef; //DataSource for lookup table 
			cmbCoef.DisplayMember = "getName"; //Display value in lookup table
			cmbCoef.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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
		protected struct matCombo2
		{
			private string Descripcion;
			private string Identificador;
			public matCombo2(string Nombre , string id)
			{
				Descripcion   = Nombre;
				Identificador = id;
			}
			public string getName
			{
				get
				{
					return Descripcion;
				}
			}
			public string getId
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
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obras));
            this.sqlDAObras = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsObra1 = new LancNeo.dsObra();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label44 = new System.Windows.Forms.Label();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPresupuestoz = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbCoef = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbSoldadura = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.dsZona1 = new LancNeo.dsZona();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbCarpeta = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNoEco = new System.Windows.Forms.ComboBox();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJfrente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSuperintendente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRfc = new System.Windows.Forms.ComboBox();
            this.dsBusEmp1 = new LancNeo.dsBusEmp();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dsBusCliente1 = new LancNeo.dsBusCliente();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.txtParadox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusEmpresa = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusCliente = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAZona = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.cachedCryTarjeta1 = new LancNeo.CachedCryTarjeta();
            this.cachedCryTarjeta2 = new LancNeo.CachedCryTarjeta();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsObra1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsZona1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusCliente1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 668);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(805, 31);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Controls.Add(this.tbBtn1);
            this.panelToolBar.Size = new System.Drawing.Size(805, 64);
            this.panelToolBar.Controls.SetChildIndex(this.btnDeshacer, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnVistaPrevia, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnPrimero, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnAnterior, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnUltimo, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnEliminar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.tbBtn1, 0);
            // 
            // sqlDAObras
            // 
            this.sqlDAObras.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAObras.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAObras.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAObras.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Codigop", "Codigop"),
                        new System.Data.Common.DataColumnMapping("Sintendente", "Sintendente"),
                        new System.Data.Common.DataColumnMapping("Jfrente", "Jfrente"),
                        new System.Data.Common.DataColumnMapping("Telefono", "Telefono"),
                        new System.Data.Common.DataColumnMapping("Solicitud", "Solicitud"),
                        new System.Data.Common.DataColumnMapping("Presupuesto", "Presupuesto"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai"),
                        new System.Data.Common.DataColumnMapping("Fechaf", "Fechaf"),
                        new System.Data.Common.DataColumnMapping("Carpeta", "Carpeta"),
                        new System.Data.Common.DataColumnMapping("Diaj", "Diaj"),
                        new System.Data.Common.DataColumnMapping("Horaj", "Horaj"),
                        new System.Data.Common.DataColumnMapping("Soldadura", "Soldadura"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("Coeficiente", "Coeficiente"),
                        new System.Data.Common.DataColumnMapping("PresupuestoZ", "PresupuestoZ"),
                        new System.Data.Common.DataColumnMapping("Duracion", "Duracion"),
                        new System.Data.Common.DataColumnMapping("Paradox", "Paradox"),
                        new System.Data.Common.DataColumnMapping("Informes", "Informes"),
                        new System.Data.Common.DataColumnMapping("Contrato", "Contrato"),
                        new System.Data.Common.DataColumnMapping("Tipolab", "Tipolab"),
                        new System.Data.Common.DataColumnMapping("Certificado", "Certificado"),
                        new System.Data.Common.DataColumnMapping("SerConcreto", "SerConcreto"),
                        new System.Data.Common.DataColumnMapping("SerSoldadura", "SerSoldadura"),
                        new System.Data.Common.DataColumnMapping("PlaCim", "PlaCim"),
                        new System.Data.Common.DataColumnMapping("PlaPT", "PlaPT"),
                        new System.Data.Common.DataColumnMapping("PlaCorte", "PlaCorte"),
                        new System.Data.Common.DataColumnMapping("SerAcero", "SerAcero"),
                        new System.Data.Common.DataColumnMapping("SerTerra", "SerTerra"),
                        new System.Data.Common.DataColumnMapping("SerPrefa", "SerPrefa"),
                        new System.Data.Common.DataColumnMapping("SerMor", "SerMor"),
                        new System.Data.Common.DataColumnMapping("AccesoWEB", "AccesoWEB"),
                        new System.Data.Common.DataColumnMapping("InfResbajas", "InfResbajas"),
                        new System.Data.Common.DataColumnMapping("Infemail", "Infemail"),
                        new System.Data.Common.DataColumnMapping("InfTelefono", "InfTelefono"),
                        new System.Data.Common.DataColumnMapping("InfOriginal", "InfOriginal"),
                        new System.Data.Common.DataColumnMapping("InfCopia", "InfCopia"),
                        new System.Data.Common.DataColumnMapping("TelResidente", "TelResidente"),
                        new System.Data.Common.DataColumnMapping("Correo1", "Correo1"),
                        new System.Data.Common.DataColumnMapping("Correo2", "Correo2"),
                        new System.Data.Common.DataColumnMapping("Correo3", "Correo3"),
                        new System.Data.Common.DataColumnMapping("Correo4", "Correo4"),
                        new System.Data.Common.DataColumnMapping("Correo5", "Correo5"),
                        new System.Data.Common.DataColumnMapping("SeEspe", "SeEspe"),
                        new System.Data.Common.DataColumnMapping("CualEsp", "CualEsp"),
                        new System.Data.Common.DataColumnMapping("DelOMun", "DelOMun"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAObras.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IsNull_IdCliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdCliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RFC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RFC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RFC", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RFC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Idobra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Idobra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ubicacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Codigop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Codigop", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Codigop", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Codigop", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Sintendente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sintendente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Sintendente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sintendente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Jfrente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Jfrente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Jfrente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Jfrente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Solicitud", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Solicitud", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Solicitud", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Solicitud", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Presupuesto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Presupuesto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Presupuesto", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Presupuesto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdLaboratorio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fechai", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fechai", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fechai", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fechai", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fechaf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fechaf", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fechaf", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fechaf", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carpeta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carpeta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carpeta", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Carpeta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diaj", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diaj", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diaj", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diaj", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Horaj", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Horaj", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Horaj", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Horaj", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Soldadura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Soldadura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Soldadura", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Soldadura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdZona", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Origen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Origen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Origen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Origen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Coeficiente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Coeficiente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Coeficiente", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coeficiente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PresupuestoZ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PresupuestoZ", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PresupuestoZ", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PresupuestoZ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Duracion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Duracion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Duracion", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Duracion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Paradox", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Paradox", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Paradox", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Paradox", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Informes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Informes", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Informes", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Informes", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Contrato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contrato", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Contrato", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contrato", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipolab", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipolab", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipolab", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipolab", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Certificado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Certificado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Certificado", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Certificado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerConcreto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerConcreto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerConcreto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerConcreto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerSoldadura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerSoldadura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerSoldadura", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerSoldadura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PlaCim", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PlaCim", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PlaCim", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PlaCim", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PlaPT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PlaPT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PlaPT", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PlaPT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PlaCorte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PlaCorte", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PlaCorte", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PlaCorte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerTerra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerTerra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerTerra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerTerra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerPrefa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerPrefa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerPrefa", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerPrefa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerMor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerMor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerMor", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerMor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AccesoWEB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AccesoWEB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AccesoWEB", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccesoWEB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InfResbajas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InfResbajas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InfResbajas", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InfResbajas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Infemail", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Infemail", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Infemail", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Infemail", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InfTelefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InfTelefono", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InfTelefono", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InfTelefono", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InfOriginal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InfOriginal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InfOriginal", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InfOriginal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InfCopia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InfCopia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InfCopia", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InfCopia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TelResidente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TelResidente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TelResidente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TelResidente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo3", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo4", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo5", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SeEspe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SeEspe", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SeEspe", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SeEspe", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CualEsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CualEsp", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CualEsp", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CualEsp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DelOMun", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DelOMun", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DelOMun", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DelOMun", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IdCliente", System.Data.SqlDbType.NVarChar, 0, "IdCliente"),
            new System.Data.SqlClient.SqlParameter("@RFC", System.Data.SqlDbType.NVarChar, 0, "RFC"),
            new System.Data.SqlClient.SqlParameter("@Idobra", System.Data.SqlDbType.NVarChar, 0, "Idobra"),
            new System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.NVarChar, 0, "Descripcion"),
            new System.Data.SqlClient.SqlParameter("@Ubicacion", System.Data.SqlDbType.NVarChar, 0, "Ubicacion"),
            new System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.NVarChar, 0, "Colonia"),
            new System.Data.SqlClient.SqlParameter("@Codigop", System.Data.SqlDbType.NVarChar, 0, "Codigop"),
            new System.Data.SqlClient.SqlParameter("@Sintendente", System.Data.SqlDbType.NVarChar, 0, "Sintendente"),
            new System.Data.SqlClient.SqlParameter("@Jfrente", System.Data.SqlDbType.NVarChar, 0, "Jfrente"),
            new System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.NVarChar, 0, "Telefono"),
            new System.Data.SqlClient.SqlParameter("@Solicitud", System.Data.SqlDbType.NVarChar, 0, "Solicitud"),
            new System.Data.SqlClient.SqlParameter("@Presupuesto", System.Data.SqlDbType.NVarChar, 0, "Presupuesto"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.DateTime, 0, "Fechai"),
            new System.Data.SqlClient.SqlParameter("@Fechaf", System.Data.SqlDbType.DateTime, 0, "Fechaf"),
            new System.Data.SqlClient.SqlParameter("@Carpeta", System.Data.SqlDbType.NVarChar, 0, "Carpeta"),
            new System.Data.SqlClient.SqlParameter("@Diaj", System.Data.SqlDbType.NVarChar, 0, "Diaj"),
            new System.Data.SqlClient.SqlParameter("@Horaj", System.Data.SqlDbType.DateTime, 0, "Horaj"),
            new System.Data.SqlClient.SqlParameter("@Soldadura", System.Data.SqlDbType.SmallInt, 0, "Soldadura"),
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 0, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Origen", System.Data.SqlDbType.SmallInt, 0, "Origen"),
            new System.Data.SqlClient.SqlParameter("@Coeficiente", System.Data.SqlDbType.SmallInt, 0, "Coeficiente"),
            new System.Data.SqlClient.SqlParameter("@PresupuestoZ", System.Data.SqlDbType.NVarChar, 0, "PresupuestoZ"),
            new System.Data.SqlClient.SqlParameter("@Duracion", System.Data.SqlDbType.SmallInt, 0, "Duracion"),
            new System.Data.SqlClient.SqlParameter("@Paradox", System.Data.SqlDbType.NChar, 0, "Paradox"),
            new System.Data.SqlClient.SqlParameter("@Informes", System.Data.SqlDbType.VarChar, 0, "Informes"),
            new System.Data.SqlClient.SqlParameter("@Contrato", System.Data.SqlDbType.NVarChar, 0, "Contrato"),
            new System.Data.SqlClient.SqlParameter("@Tipolab", System.Data.SqlDbType.SmallInt, 0, "Tipolab"),
            new System.Data.SqlClient.SqlParameter("@Certificado", System.Data.SqlDbType.SmallInt, 0, "Certificado"),
            new System.Data.SqlClient.SqlParameter("@SerConcreto", System.Data.SqlDbType.SmallInt, 0, "SerConcreto"),
            new System.Data.SqlClient.SqlParameter("@SerSoldadura", System.Data.SqlDbType.SmallInt, 0, "SerSoldadura"),
            new System.Data.SqlClient.SqlParameter("@PlaCim", System.Data.SqlDbType.SmallInt, 0, "PlaCim"),
            new System.Data.SqlClient.SqlParameter("@PlaPT", System.Data.SqlDbType.SmallInt, 0, "PlaPT"),
            new System.Data.SqlClient.SqlParameter("@PlaCorte", System.Data.SqlDbType.SmallInt, 0, "PlaCorte"),
            new System.Data.SqlClient.SqlParameter("@SerAcero", System.Data.SqlDbType.SmallInt, 0, "SerAcero"),
            new System.Data.SqlClient.SqlParameter("@SerTerra", System.Data.SqlDbType.SmallInt, 0, "SerTerra"),
            new System.Data.SqlClient.SqlParameter("@SerPrefa", System.Data.SqlDbType.SmallInt, 0, "SerPrefa"),
            new System.Data.SqlClient.SqlParameter("@SerMor", System.Data.SqlDbType.SmallInt, 0, "SerMor"),
            new System.Data.SqlClient.SqlParameter("@AccesoWEB", System.Data.SqlDbType.VarChar, 0, "AccesoWEB"),
            new System.Data.SqlClient.SqlParameter("@InfResbajas", System.Data.SqlDbType.VarChar, 0, "InfResbajas"),
            new System.Data.SqlClient.SqlParameter("@Infemail", System.Data.SqlDbType.NVarChar, 0, "Infemail"),
            new System.Data.SqlClient.SqlParameter("@InfTelefono", System.Data.SqlDbType.NVarChar, 0, "InfTelefono"),
            new System.Data.SqlClient.SqlParameter("@InfOriginal", System.Data.SqlDbType.SmallInt, 0, "InfOriginal"),
            new System.Data.SqlClient.SqlParameter("@InfCopia", System.Data.SqlDbType.SmallInt, 0, "InfCopia"),
            new System.Data.SqlClient.SqlParameter("@TelResidente", System.Data.SqlDbType.NVarChar, 0, "TelResidente"),
            new System.Data.SqlClient.SqlParameter("@Correo1", System.Data.SqlDbType.NVarChar, 0, "Correo1"),
            new System.Data.SqlClient.SqlParameter("@Correo2", System.Data.SqlDbType.NVarChar, 0, "Correo2"),
            new System.Data.SqlClient.SqlParameter("@Correo3", System.Data.SqlDbType.NVarChar, 0, "Correo3"),
            new System.Data.SqlClient.SqlParameter("@Correo4", System.Data.SqlDbType.NVarChar, 0, "Correo4"),
            new System.Data.SqlClient.SqlParameter("@Correo5", System.Data.SqlDbType.NVarChar, 0, "Correo5"),
            new System.Data.SqlClient.SqlParameter("@SeEspe", System.Data.SqlDbType.SmallInt, 0, "SeEspe"),
            new System.Data.SqlClient.SqlParameter("@CualEsp", System.Data.SqlDbType.NVarChar, 0, "CualEsp"),
            new System.Data.SqlClient.SqlParameter("@DelOMun", System.Data.SqlDbType.NVarChar, 0, "DelOMun"),
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
            new System.Data.SqlClient.SqlParameter("@IdCliente", System.Data.SqlDbType.NVarChar, 0, "IdCliente"),
            new System.Data.SqlClient.SqlParameter("@RFC", System.Data.SqlDbType.NVarChar, 0, "RFC"),
            new System.Data.SqlClient.SqlParameter("@Idobra", System.Data.SqlDbType.NVarChar, 0, "Idobra"),
            new System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.NVarChar, 0, "Descripcion"),
            new System.Data.SqlClient.SqlParameter("@Ubicacion", System.Data.SqlDbType.NVarChar, 0, "Ubicacion"),
            new System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.NVarChar, 0, "Colonia"),
            new System.Data.SqlClient.SqlParameter("@Codigop", System.Data.SqlDbType.NVarChar, 0, "Codigop"),
            new System.Data.SqlClient.SqlParameter("@Sintendente", System.Data.SqlDbType.NVarChar, 0, "Sintendente"),
            new System.Data.SqlClient.SqlParameter("@Jfrente", System.Data.SqlDbType.NVarChar, 0, "Jfrente"),
            new System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.NVarChar, 0, "Telefono"),
            new System.Data.SqlClient.SqlParameter("@Solicitud", System.Data.SqlDbType.NVarChar, 0, "Solicitud"),
            new System.Data.SqlClient.SqlParameter("@Presupuesto", System.Data.SqlDbType.NVarChar, 0, "Presupuesto"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.DateTime, 0, "Fechai"),
            new System.Data.SqlClient.SqlParameter("@Fechaf", System.Data.SqlDbType.DateTime, 0, "Fechaf"),
            new System.Data.SqlClient.SqlParameter("@Carpeta", System.Data.SqlDbType.NVarChar, 0, "Carpeta"),
            new System.Data.SqlClient.SqlParameter("@Diaj", System.Data.SqlDbType.NVarChar, 0, "Diaj"),
            new System.Data.SqlClient.SqlParameter("@Horaj", System.Data.SqlDbType.DateTime, 0, "Horaj"),
            new System.Data.SqlClient.SqlParameter("@Soldadura", System.Data.SqlDbType.SmallInt, 0, "Soldadura"),
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 0, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Origen", System.Data.SqlDbType.SmallInt, 0, "Origen"),
            new System.Data.SqlClient.SqlParameter("@Coeficiente", System.Data.SqlDbType.SmallInt, 0, "Coeficiente"),
            new System.Data.SqlClient.SqlParameter("@PresupuestoZ", System.Data.SqlDbType.NVarChar, 0, "PresupuestoZ"),
            new System.Data.SqlClient.SqlParameter("@Duracion", System.Data.SqlDbType.SmallInt, 0, "Duracion"),
            new System.Data.SqlClient.SqlParameter("@Paradox", System.Data.SqlDbType.NChar, 0, "Paradox"),
            new System.Data.SqlClient.SqlParameter("@Informes", System.Data.SqlDbType.VarChar, 0, "Informes"),
            new System.Data.SqlClient.SqlParameter("@Contrato", System.Data.SqlDbType.NVarChar, 0, "Contrato"),
            new System.Data.SqlClient.SqlParameter("@Tipolab", System.Data.SqlDbType.SmallInt, 0, "Tipolab"),
            new System.Data.SqlClient.SqlParameter("@Certificado", System.Data.SqlDbType.SmallInt, 0, "Certificado"),
            new System.Data.SqlClient.SqlParameter("@SerConcreto", System.Data.SqlDbType.SmallInt, 0, "SerConcreto"),
            new System.Data.SqlClient.SqlParameter("@SerSoldadura", System.Data.SqlDbType.SmallInt, 0, "SerSoldadura"),
            new System.Data.SqlClient.SqlParameter("@PlaCim", System.Data.SqlDbType.SmallInt, 0, "PlaCim"),
            new System.Data.SqlClient.SqlParameter("@PlaPT", System.Data.SqlDbType.SmallInt, 0, "PlaPT"),
            new System.Data.SqlClient.SqlParameter("@PlaCorte", System.Data.SqlDbType.SmallInt, 0, "PlaCorte"),
            new System.Data.SqlClient.SqlParameter("@SerAcero", System.Data.SqlDbType.SmallInt, 0, "SerAcero"),
            new System.Data.SqlClient.SqlParameter("@SerTerra", System.Data.SqlDbType.SmallInt, 0, "SerTerra"),
            new System.Data.SqlClient.SqlParameter("@SerPrefa", System.Data.SqlDbType.SmallInt, 0, "SerPrefa"),
            new System.Data.SqlClient.SqlParameter("@SerMor", System.Data.SqlDbType.SmallInt, 0, "SerMor"),
            new System.Data.SqlClient.SqlParameter("@AccesoWEB", System.Data.SqlDbType.VarChar, 0, "AccesoWEB"),
            new System.Data.SqlClient.SqlParameter("@InfResbajas", System.Data.SqlDbType.VarChar, 0, "InfResbajas"),
            new System.Data.SqlClient.SqlParameter("@Infemail", System.Data.SqlDbType.NVarChar, 0, "Infemail"),
            new System.Data.SqlClient.SqlParameter("@InfTelefono", System.Data.SqlDbType.NVarChar, 0, "InfTelefono"),
            new System.Data.SqlClient.SqlParameter("@InfOriginal", System.Data.SqlDbType.SmallInt, 0, "InfOriginal"),
            new System.Data.SqlClient.SqlParameter("@InfCopia", System.Data.SqlDbType.SmallInt, 0, "InfCopia"),
            new System.Data.SqlClient.SqlParameter("@TelResidente", System.Data.SqlDbType.NVarChar, 0, "TelResidente"),
            new System.Data.SqlClient.SqlParameter("@Correo1", System.Data.SqlDbType.NVarChar, 0, "Correo1"),
            new System.Data.SqlClient.SqlParameter("@Correo2", System.Data.SqlDbType.NVarChar, 0, "Correo2"),
            new System.Data.SqlClient.SqlParameter("@Correo3", System.Data.SqlDbType.NVarChar, 0, "Correo3"),
            new System.Data.SqlClient.SqlParameter("@Correo4", System.Data.SqlDbType.NVarChar, 0, "Correo4"),
            new System.Data.SqlClient.SqlParameter("@Correo5", System.Data.SqlDbType.NVarChar, 0, "Correo5"),
            new System.Data.SqlClient.SqlParameter("@SeEspe", System.Data.SqlDbType.SmallInt, 0, "SeEspe"),
            new System.Data.SqlClient.SqlParameter("@CualEsp", System.Data.SqlDbType.NVarChar, 0, "CualEsp"),
            new System.Data.SqlClient.SqlParameter("@DelOMun", System.Data.SqlDbType.NVarChar, 0, "DelOMun"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdCliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdCliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RFC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RFC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RFC", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RFC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Idobra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Idobra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ubicacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Codigop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Codigop", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Codigop", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Codigop", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Sintendente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sintendente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Sintendente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sintendente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Jfrente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Jfrente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Jfrente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Jfrente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Solicitud", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Solicitud", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Solicitud", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Solicitud", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Presupuesto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Presupuesto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Presupuesto", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Presupuesto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdLaboratorio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fechai", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fechai", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fechai", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fechai", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fechaf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fechaf", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fechaf", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fechaf", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carpeta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carpeta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carpeta", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Carpeta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diaj", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diaj", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diaj", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diaj", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Horaj", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Horaj", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Horaj", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Horaj", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Soldadura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Soldadura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Soldadura", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Soldadura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdZona", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Origen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Origen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Origen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Origen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Coeficiente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Coeficiente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Coeficiente", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coeficiente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PresupuestoZ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PresupuestoZ", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PresupuestoZ", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PresupuestoZ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Duracion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Duracion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Duracion", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Duracion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Paradox", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Paradox", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Paradox", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Paradox", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Informes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Informes", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Informes", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Informes", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Contrato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Contrato", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Contrato", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contrato", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipolab", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipolab", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipolab", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipolab", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Certificado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Certificado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Certificado", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Certificado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerConcreto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerConcreto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerConcreto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerConcreto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerSoldadura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerSoldadura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerSoldadura", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerSoldadura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PlaCim", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PlaCim", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PlaCim", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PlaCim", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PlaPT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PlaPT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PlaPT", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PlaPT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PlaCorte", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PlaCorte", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PlaCorte", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PlaCorte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerTerra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerTerra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerTerra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerTerra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerPrefa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerPrefa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerPrefa", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerPrefa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SerMor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SerMor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SerMor", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SerMor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AccesoWEB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AccesoWEB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AccesoWEB", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccesoWEB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InfResbajas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InfResbajas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InfResbajas", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InfResbajas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Infemail", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Infemail", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Infemail", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Infemail", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InfTelefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InfTelefono", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InfTelefono", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InfTelefono", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InfOriginal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InfOriginal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InfOriginal", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InfOriginal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InfCopia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InfCopia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InfCopia", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InfCopia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TelResidente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TelResidente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TelResidente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TelResidente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo3", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo4", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Correo5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Correo5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Correo5", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Correo5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SeEspe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SeEspe", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SeEspe", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SeEspe", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CualEsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CualEsp", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CualEsp", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CualEsp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DelOMun", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DelOMun", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DelOMun", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DelOMun", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // dsObra1
            // 
            this.dsObra1.DataSetName = "dsObra";
            this.dsObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.label44);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label43);
            this.panel2.Controls.Add(this.textBox21);
            this.panel2.Controls.Add(this.textBox20);
            this.panel2.Controls.Add(this.checkBox10);
            this.panel2.Controls.Add(this.textBox19);
            this.panel2.Controls.Add(this.label42);
            this.panel2.Controls.Add(this.textBox18);
            this.panel2.Controls.Add(this.label41);
            this.panel2.Controls.Add(this.textBox17);
            this.panel2.Controls.Add(this.label40);
            this.panel2.Controls.Add(this.textBox16);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.textBox15);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.textBox14);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.textBox13);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.checkBox7);
            this.panel2.Controls.Add(this.checkBox8);
            this.panel2.Controls.Add(this.checkBox9);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox6);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.txtPresupuestoz);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.cmbCoef);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.cmbOrigen);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.cmbSoldadura);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.cmbZona);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cmbCarpeta);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmbNoEco);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cmbLaboratorio);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtPresupuesto);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSolicitud);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtJfrente);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSuperintendente);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtUbicacion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtObra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbRfc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIdObra);
            this.panel2.Controls.Add(this.txtParadox);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(14, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 597);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusObra1.Obra;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(607, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 41;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Red;
            this.label44.Location = new System.Drawing.Point(504, 561);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(54, 13);
            this.label44.TabIndex = 105;
            this.label44.Text = "Usuario:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.IdUsuario", true));
            this.txtUsrMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrMov.ForeColor = System.Drawing.Color.Red;
            this.txtUsrMov.Location = new System.Drawing.Point(558, 557);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.Size = new System.Drawing.Size(73, 20);
            this.txtUsrMov.TabIndex = 104;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(1, 76);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(99, 13);
            this.label43.TabIndex = 102;
            this.label43.Text = "Municipio o delega:";
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.DelOMun", true));
            this.textBox21.Location = new System.Drawing.Point(104, 72);
            this.textBox21.MaxLength = 50;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(328, 20);
            this.textBox21.TabIndex = 101;
            this.textBox21.Text = "textBox2";
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.CualEsp", true));
            this.textBox20.Location = new System.Drawing.Point(317, 352);
            this.textBox20.MaxLength = 20;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(121, 20);
            this.textBox20.TabIndex = 100;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.SeEspe", true));
            this.checkBox10.Location = new System.Drawing.Point(361, 336);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(77, 17);
            this.checkBox10.TabIndex = 99;
            this.checkBox10.Text = "Especiales";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Correo5", true));
            this.textBox19.Location = new System.Drawing.Point(104, 236);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(267, 20);
            this.textBox19.TabIndex = 98;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(-1, 237);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(101, 13);
            this.label42.TabIndex = 97;
            this.label42.Text = "Persona autorizada:";
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Correo4", true));
            this.textBox18.Location = new System.Drawing.Point(484, 502);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(267, 20);
            this.textBox18.TabIndex = 96;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(433, 506);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(50, 13);
            this.label41.TabIndex = 95;
            this.label41.Text = "Correo 4:";
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Correo3", true));
            this.textBox17.Location = new System.Drawing.Point(484, 476);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(267, 20);
            this.textBox17.TabIndex = 94;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(433, 480);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 13);
            this.label40.TabIndex = 93;
            this.label40.Text = "Correo 3:";
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Correo2", true));
            this.textBox16.Location = new System.Drawing.Point(484, 451);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(267, 20);
            this.textBox16.TabIndex = 92;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(433, 455);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(50, 13);
            this.label39.TabIndex = 91;
            this.label39.Text = "Correo 2:";
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Correo1", true));
            this.textBox15.Location = new System.Drawing.Point(484, 426);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(267, 20);
            this.textBox15.TabIndex = 90;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(433, 430);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(50, 13);
            this.label38.TabIndex = 89;
            this.label38.Text = "Correo 1:";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.PresupuestoZ", true));
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox14.Location = new System.Drawing.Point(560, 75);
            this.textBox14.MaxLength = 10;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(108, 20);
            this.textBox14.TabIndex = 87;
            this.textBox14.Text = "textBox3";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(484, 75);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 13);
            this.label37.TabIndex = 88;
            this.label37.Text = "Presupuesto";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(251, 468);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(52, 13);
            this.label35.TabIndex = 86;
            this.label35.Text = "Teléfono:";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.InfTelefono", true));
            this.textBox12.Location = new System.Drawing.Point(303, 464);
            this.textBox12.MaxLength = 50;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(126, 20);
            this.textBox12.TabIndex = 84;
            this.textBox12.Text = "textBox2";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(63, 468);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 13);
            this.label36.TabIndex = 85;
            this.label36.Text = "email:";
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Infemail", true));
            this.textBox13.Location = new System.Drawing.Point(101, 464);
            this.textBox13.MaxLength = 50;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(142, 20);
            this.textBox13.TabIndex = 83;
            this.textBox13.Text = "textBox2";
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(2, 440);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(97, 27);
            this.label34.TabIndex = 82;
            this.label34.Text = "Aviso resistencia baja a:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.InfResbajas", true));
            this.textBox11.Location = new System.Drawing.Point(101, 440);
            this.textBox11.MaxLength = 50;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(328, 20);
            this.textBox11.TabIndex = 81;
            this.textBox11.Text = "textBox2";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(1, 413);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 27);
            this.label25.TabIndex = 80;
            this.label25.Text = "Acceso consulta a intenet:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.AccesoWEB", true));
            this.textBox10.Location = new System.Drawing.Point(102, 416);
            this.textBox10.MaxLength = 50;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(328, 20);
            this.textBox10.TabIndex = 79;
            this.textBox10.Text = "textBox2";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.InfCopia", true));
            this.textBox9.Location = new System.Drawing.Point(624, 373);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(0, 20);
            this.textBox9.TabIndex = 78;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.InfOriginal", true));
            this.textBox8.Location = new System.Drawing.Point(568, 375);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(0, 20);
            this.textBox8.TabIndex = 77;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Certificado", true));
            this.textBox7.Location = new System.Drawing.Point(568, 275);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Presupuesto", true));
            this.textBox6.Location = new System.Drawing.Point(568, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Tipolab", true));
            this.textBox5.Location = new System.Drawing.Point(470, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(0, 20);
            this.textBox5.TabIndex = 76;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(115, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 38);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Original en:";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton9.Location = new System.Drawing.Point(123, 14);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(39, 17);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "No";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton5.ForeColor = System.Drawing.Color.White;
            this.radioButton5.Location = new System.Drawing.Point(67, 14);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Obra";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(7, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Oficina";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(4, 378);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 13);
            this.label33.TabIndex = 73;
            this.label33.Text = "Entrega de informes:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(507, 271);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 13);
            this.label32.TabIndex = 72;
            this.label32.Text = "Certificado:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(459, 249);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(108, 13);
            this.label31.TabIndex = 71;
            this.label31.Text = "Carpetas entregadas:";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.SerSoldadura", true));
            this.checkBox7.Location = new System.Drawing.Point(238, 355);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(74, 17);
            this.checkBox7.TabIndex = 28;
            this.checkBox7.Text = "Soldadura";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.SerMor", true));
            this.checkBox8.Location = new System.Drawing.Point(166, 355);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(62, 17);
            this.checkBox8.TabIndex = 27;
            this.checkBox8.Text = "Mortero";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.SerPrefa", true));
            this.checkBox9.Location = new System.Drawing.Point(71, 355);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(91, 17);
            this.checkBox9.TabIndex = 26;
            this.checkBox9.Text = "Prefabricados";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 337);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 13);
            this.label30.TabIndex = 67;
            this.label30.Text = "Servicios:";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.SerTerra", true));
            this.checkBox4.Location = new System.Drawing.Point(233, 336);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 17);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "Terracerias";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.SerAcero", true));
            this.checkBox5.Location = new System.Drawing.Point(174, 336);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(54, 17);
            this.checkBox5.TabIndex = 24;
            this.checkBox5.Text = "Acero";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.SerConcreto", true));
            this.checkBox6.Location = new System.Drawing.Point(93, 336);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 17);
            this.checkBox6.TabIndex = 23;
            this.checkBox6.Text = "Concreto";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(486, 205);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 13);
            this.label29.TabIndex = 63;
            this.label29.Text = "Solici. Planos:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.PlaCorte", true));
            this.checkBox3.Location = new System.Drawing.Point(663, 204);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 17);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "Corte";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.PlaPT", true));
            this.checkBox2.Location = new System.Drawing.Point(615, 204);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(43, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "PT.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsObra1, "Obra.PlaCim", true));
            this.checkBox1.Location = new System.Drawing.Point(559, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Cim.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(28, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 31);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.Location = new System.Drawing.Point(160, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Por visita";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton3.Location = new System.Drawing.Point(253, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Laboratorio de obra";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(7, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Laboratorista de planta";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(254, 214);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 13);
            this.label28.TabIndex = 56;
            this.label28.Text = "Teléfono:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.TelResidente", true));
            this.textBox4.Location = new System.Drawing.Point(306, 210);
            this.textBox4.MaxLength = 50;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "textBox2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(41, 125);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 13);
            this.label27.TabIndex = 54;
            this.label27.Text = "Informes a:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Informes", true));
            this.textBox3.Location = new System.Drawing.Point(104, 121);
            this.textBox3.MaxLength = 100;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(328, 43);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "textBox2";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Gold;
            this.label26.Location = new System.Drawing.Point(448, 310);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 13);
            this.label26.TabIndex = 52;
            this.label26.Text = "Cliente control2000:";
            // 
            // txtPresupuestoz
            // 
            this.txtPresupuestoz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Presupuesto", true));
            this.txtPresupuestoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuestoz.ForeColor = System.Drawing.Color.Green;
            this.txtPresupuestoz.Location = new System.Drawing.Point(568, 333);
            this.txtPresupuestoz.MaxLength = 3;
            this.txtPresupuestoz.Name = "txtPresupuestoz";
            this.txtPresupuestoz.Size = new System.Drawing.Size(108, 20);
            this.txtPresupuestoz.TabIndex = 9;
            this.txtPresupuestoz.Text = "textBox3";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gold;
            this.label24.Location = new System.Drawing.Point(464, 333);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "Obra control2000:";
            // 
            // cmbCoef
            // 
            this.cmbCoef.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.Coeficiente", true));
            this.cmbCoef.Location = new System.Drawing.Point(568, 358);
            this.cmbCoef.Name = "cmbCoef";
            this.cmbCoef.Size = new System.Drawing.Size(64, 21);
            this.cmbCoef.TabIndex = 39;
            this.cmbCoef.Text = "comboBox1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Fuchsia;
            this.label23.Location = new System.Drawing.Point(491, 362);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Coeficiente:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.Origen", true));
            this.cmbOrigen.Location = new System.Drawing.Point(568, 382);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(64, 21);
            this.cmbOrigen.TabIndex = 40;
            this.cmbOrigen.Text = "comboBox5";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Fuchsia;
            this.label22.Location = new System.Drawing.Point(518, 386);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "Origen:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(55, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Colonia:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Colonia", true));
            this.textBox1.Location = new System.Drawing.Point(104, 49);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "textBox2";
            // 
            // cmbSoldadura
            // 
            this.cmbSoldadura.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.Soldadura", true));
            this.cmbSoldadura.Location = new System.Drawing.Point(560, 178);
            this.cmbSoldadura.Name = "cmbSoldadura";
            this.cmbSoldadura.Size = new System.Drawing.Size(108, 21);
            this.cmbSoldadura.TabIndex = 17;
            this.cmbSoldadura.Text = "comboBox1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(198, 540);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Zona:";
            // 
            // cmbZona
            // 
            this.cmbZona.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.IdZona", true));
            this.cmbZona.DataSource = this.dsZona1.Zona;
            this.cmbZona.DisplayMember = "Zona";
            this.cmbZona.Location = new System.Drawing.Point(234, 536);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(196, 21);
            this.cmbZona.TabIndex = 36;
            this.cmbZona.ValueMember = "IdZona";
            // 
            // dsZona1
            // 
            this.dsZona1.DataSetName = "dsZona";
            this.dsZona1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsZona1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Horaj", true));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(348, 312);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker3.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(501, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Soldadura:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(312, 312);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Hora:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 312);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Días de Junta:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Diaj", true));
            this.textBox2.Location = new System.Drawing.Point(112, 312);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "textBox2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(512, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Carpeta:";
            // 
            // cmbCarpeta
            // 
            this.cmbCarpeta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.Carpeta", true));
            this.cmbCarpeta.Location = new System.Drawing.Point(560, 153);
            this.cmbCarpeta.Name = "cmbCarpeta";
            this.cmbCarpeta.Size = new System.Drawing.Size(108, 21);
            this.cmbCarpeta.TabIndex = 14;
            this.cmbCarpeta.Text = "comboBox5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(239, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Fecha de Termino:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Fechaf", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(339, 286);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Fecha de Inicio:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Fechai", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 286);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 560);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "No. Eco.:";
            // 
            // cmbNoEco
            // 
            this.cmbNoEco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.NoEco", true));
            this.cmbNoEco.DataSource = this.dsLaboratorista1.Laboratorista;
            this.cmbNoEco.DisplayMember = "Laboratorista";
            this.cmbNoEco.Location = new System.Drawing.Point(102, 560);
            this.cmbNoEco.Name = "cmbNoEco";
            this.cmbNoEco.Size = new System.Drawing.Size(328, 21);
            this.cmbNoEco.TabIndex = 37;
            this.cmbNoEco.ValueMember = "NoEco";
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 536);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Laboratorio:";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.IdLaboratorio", true));
            this.cmbLaboratorio.DataSource = this.dsLaboratorio1.Laboratorio;
            this.cmbLaboratorio.DisplayMember = "IdLaboratorio";
            this.cmbLaboratorio.Location = new System.Drawing.Point(102, 536);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(92, 21);
            this.cmbLaboratorio.TabIndex = 35;
            this.cmbLaboratorio.ValueMember = "IdLaboratorio";
            // 
            // dsLaboratorio1
            // 
            this.dsLaboratorio1.DataSetName = "dsLaboratorio";
            this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(509, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Contrato:";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Contrato", true));
            this.txtPresupuesto.Location = new System.Drawing.Point(560, 126);
            this.txtPresupuesto.MaxLength = 6;
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(108, 20);
            this.txtPresupuesto.TabIndex = 12;
            this.txtPresupuesto.Text = "textBox2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Solicitud No.:";
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Solicitud", true));
            this.txtSolicitud.Location = new System.Drawing.Point(560, 101);
            this.txtSolicitud.MaxLength = 10;
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.Size = new System.Drawing.Size(108, 20);
            this.txtSolicitud.TabIndex = 7;
            this.txtSolicitud.Text = "textBox2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Telefono", true));
            this.txtTelefono.Location = new System.Drawing.Point(198, 96);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(234, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "textBox2";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Residente/resp. de obra:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtJfrente
            // 
            this.txtJfrente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Jfrente", true));
            this.txtJfrente.Location = new System.Drawing.Point(104, 170);
            this.txtJfrente.MaxLength = 100;
            this.txtJfrente.Multiline = true;
            this.txtJfrente.Name = "txtJfrente";
            this.txtJfrente.Size = new System.Drawing.Size(328, 36);
            this.txtJfrente.TabIndex = 8;
            this.txtJfrente.Text = "textBox2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "email:";
            // 
            // txtSuperintendente
            // 
            this.txtSuperintendente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Sintendente", true));
            this.txtSuperintendente.Location = new System.Drawing.Point(104, 210);
            this.txtSuperintendente.MaxLength = 50;
            this.txtSuperintendente.Name = "txtSuperintendente";
            this.txtSuperintendente.Size = new System.Drawing.Size(142, 20);
            this.txtSuperintendente.TabIndex = 10;
            this.txtSuperintendente.Text = "textBox2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "C.P.:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Codigop", true));
            this.txtCodigo.Location = new System.Drawing.Point(104, 96);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(36, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.Text = "textBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Ubicacion", true));
            this.txtUbicacion.Location = new System.Drawing.Point(104, 1);
            this.txtUbicacion.MaxLength = 50;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(328, 20);
            this.txtUbicacion.TabIndex = 1;
            this.txtUbicacion.Text = "textBox2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Obra:";
            // 
            // txtObra
            // 
            this.txtObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Descripcion", true));
            this.txtObra.Location = new System.Drawing.Point(104, 26);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(497, 20);
            this.txtObra.TabIndex = 2;
            this.txtObra.Text = "textBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Facturar a.:";
            // 
            // cmbRfc
            // 
            this.cmbRfc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.RFC", true));
            this.cmbRfc.DataSource = this.dsBusEmp1;
            this.cmbRfc.DisplayMember = "Razonsocial.Facturar";
            this.cmbRfc.Location = new System.Drawing.Point(102, 511);
            this.cmbRfc.Name = "cmbRfc";
            this.cmbRfc.Size = new System.Drawing.Size(328, 21);
            this.cmbRfc.TabIndex = 34;
            this.cmbRfc.ValueMember = "RFC";
            // 
            // dsBusEmp1
            // 
            this.dsBusEmp1.DataSetName = "dsBusEmp";
            this.dsBusEmp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsObra1, "Obra.IdCliente", true));
            this.cmbCliente.DataSource = this.dsBusCliente1.cliente;
            this.cmbCliente.DisplayMember = "Cliente";
            this.cmbCliente.Location = new System.Drawing.Point(102, 488);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(328, 21);
            this.cmbCliente.TabIndex = 33;
            this.cmbCliente.ValueMember = "IdCliente";
            // 
            // dsBusCliente1
            // 
            this.dsBusCliente1.DataSetName = "dsBusCliente";
            this.dsBusCliente1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusCliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdObra:";
            // 
            // txtIdObra
            // 
            this.txtIdObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Idobra", true));
            this.txtIdObra.Location = new System.Drawing.Point(495, 1);
            this.txtIdObra.MaxLength = 6;
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(100, 20);
            this.txtIdObra.TabIndex = 0;
            this.txtIdObra.Text = "textBox1";
            // 
            // txtParadox
            // 
            this.txtParadox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsObra1, "Obra.Paradox", true));
            this.txtParadox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParadox.ForeColor = System.Drawing.Color.Green;
            this.txtParadox.Location = new System.Drawing.Point(568, 306);
            this.txtParadox.Name = "txtParadox";
            this.txtParadox.Size = new System.Drawing.Size(100, 20);
            this.txtParadox.TabIndex = 38;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(296, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 38);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Copia en:";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton10.Location = new System.Drawing.Point(129, 15);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(39, 17);
            this.radioButton10.TabIndex = 2;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "No";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton6.ForeColor = System.Drawing.Color.White;
            this.radioButton6.Location = new System.Drawing.Point(74, 15);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(48, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Obra";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.ForeColor = System.Drawing.Color.White;
            this.radioButton8.Location = new System.Drawing.Point(-108, 0);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(58, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Oficina";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton7.ForeColor = System.Drawing.Color.White;
            this.radioButton7.Location = new System.Drawing.Point(12, 15);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(58, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Oficina";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // sqlDABusObra
            // 
            this.sqlDABusObra.SelectCommand = this.sqlSelectCommand2;
            this.sqlDABusObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     Idobra, Ubicacion, RFC, Informes AS Facturar\r\nFROM         Obra\r\nORDER" +
    " BY Idobra";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDABusEmpresa
            // 
            this.sqlDABusEmpresa.SelectCommand = this.sqlCommand1;
            this.sqlDABusEmpresa.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Razonsocial", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT     RFC, Facturar\r\nFROM         Razonsocial\r\nORDER BY Facturar";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDABusCliente
            // 
            this.sqlDABusCliente.SelectCommand = this.sqlCommand2;
            this.sqlDABusCliente.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "cliente", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT IdCliente, Cliente, Direccion FROM cliente ORDER BY Cliente";
            this.sqlCommand2.Connection = this.sqlConn;
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
            this.sqlSelectCommand5.CommandText = "SELECT     NoEco, LTRIM(STR(NoEco)) + \' \' + Laboratorista AS Laboratorista, IdZon" +
    "a, IdNivel, Fechai\r\nFROM         Laboratorista\r\nORDER BY NoEco";
            this.sqlSelectCommand5.Connection = this.sqlConn;
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
            this.sqlSelectCommand4.CommandText = "SELECT IdLaboratorio, Laboratorio, IdZona FROM Laboratorio ORDER BY Laboratorio";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // sqlDAZona
            // 
            this.sqlDAZona.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAZona.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Zona", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona"),
                        new System.Data.Common.DataColumnMapping("Ubicación", "Ubicación")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdZona, Zona, Ubicación FROM Zona";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(598, 0);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 60;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // Obras
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(805, 699);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAObras;
            this.dsGeneral = this.dsObra1;
            this.Name = "Obras";
            this.NombreTabla = "Obra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Obras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Obras_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsObra1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsZona1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEmp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusCliente1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Obras_Load(object sender, System.EventArgs e)
		{
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }

            LlenasSqlDA();
			this.buscaBtn1.Catalogo = this;
			EstableceVistaPrevia();

		}
		private void LlenasSqlDA()
		{
			sqlDABusCliente.Fill(dsBusCliente1, "Cliente");
			sqlDALaboratorio.Fill(dsLaboratorio1, "Laboratorio");
			sqlDALaboratorista.Fill(dsLaboratorista1, "Laboratorista");
			sqlDAZona.Fill(dsZona1, "Zona");
            sqlDABusEmpresa.Fill(dsBusEmp1, "Razonsocial");
            sqlDABusObra.Fill(dsBusObra1, "Obra");
		}
		private void EstableceVistaPrevia()
		{
			DataSet dsVP = new DataSet();
			sqlDABusObra.Fill(dsVP, "Obra");
			dsVistaPrevia = dsVP;
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbLaboratorio.SelectedIndex = 0;
			cmbNoEco.SelectedIndex = 0;
			cmbCliente.SelectedIndex = 0;
			cmbRfc.SelectedIndex = 0;
			cmbZona.SelectedIndex = 0;
			cmbCarpeta.SelectedIndex = 0;
			cmbSoldadura.SelectedIndex = 0;
            tbBtn1.Visible = false;
		}

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int TipoLab = int.Parse(textBox5.Text);
            switch (TipoLab)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
                default:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox5.Text = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                textBox5.Text = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                textBox5.Text = "3";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int CarpCopia = int.Parse(textBox8.Text);
            switch (CarpCopia)
            {
                case 1:
                    radioButton4.Checked = true;
                    break;
                case 2:
                    radioButton5.Checked = true;
                    break;
                default:
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton9.Checked = true;
                    break;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                textBox8.Text = "1";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                textBox8.Text = "2";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int CarpCopia = int.Parse(textBox9.Text);
            switch (CarpCopia)
            {
                case 1:
                    radioButton7.Checked = true;
                    break;
                case 2:
                    radioButton6.Checked = true;
                    break;
                default:
                    radioButton6.Checked = false;
                    radioButton7.Checked = false;
                    radioButton10.Checked = true;
                    break;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
                textBox9.Text = "1";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
                textBox9.Text = "2";
        }
        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            txtUsrMov.Text = IdUsuario;
            base.btnGuardar_Click(sender, e);
            tbBtn1.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
                textBox8.Text = "0";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
                textBox9.Text = "0";
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            if (txtIdObra.Text.Trim().Length == 3) return;
            DialogResult result = MessageBox.Show("¿Desea copiar los datos generales de la obra principal", "Copiar datos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                String strSql = " SELECT * FROM Obra where idobra = '" + txtIdObra.Text.Substring(0, 3) + "'";
                SqlCommand sqlCmd = new SqlCommand(strSql, sqlConn);
                try
                {
                    sqlConn.Open();
                    SqlDataReader dr = sqlCmd.ExecuteReader();
                    if (dr.Read())
                    {
                        int renglon = this.BindingContext[dsObra1,"Obra"].Position;
                        dsObra1.Obra.Rows[renglon]["IdCliente"] = dr["IdCliente"].ToString();
                        dsObra1.Obra.Rows[renglon]["DelOMun"] = dr["DelOMun"].ToString();
                        dsObra1.Obra.Rows[renglon]["TelResidente"] = dr["TelResidente"].ToString();
                        dsObra1.Obra.Rows[renglon]["Correo1"] = dr["Correo1"].ToString();
                        dsObra1.Obra.Rows[renglon]["InfTelefono"] = dr["InfTelefono"].ToString();
                        dsObra1.Obra.Rows[renglon]["Infemail"] = dr["Infemail"].ToString();
                        dsObra1.Obra.Rows[renglon]["InfResbajas"] = dr["InfResbajas"].ToString();
                        dsObra1.Obra.Rows[renglon]["Informes"] = dr["Informes"].ToString();
                        dsObra1.Obra.Rows[renglon]["Ubicacion"] = dr["Ubicacion"].ToString();
                        dsObra1.Obra.Rows[renglon]["Colonia"] = dr["Colonia"].ToString();
                        dsObra1.Obra.Rows[renglon]["Codigop"] = dr["Codigop"].ToString();
                        dsObra1.Obra.Rows[renglon]["NoEco"] = dr["NoEco"].ToString();
                        dsObra1.Obra.Rows[renglon]["RFC"] = dr["RFC"].ToString();
                        dsObra1.Obra.Rows[renglon]["InfOriginal"] = dr["InfOriginal"].ToString();
                        dsObra1.Obra.Rows[renglon]["InfCopia"] = dr["InfCopia"].ToString();
                        btnGuardar_Click(sender, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sqlConn.State == ConnectionState.Open)
                    {
                        sqlConn.Close();
                    }
                }
            }
            else if (result == DialogResult.No)
            {
            }

        }
	}
}
