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
	/// Descripción breve de Empresas.
	/// </summary>
	public class Empresas : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDARazonSocial;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsRazonSocial dsRazonSocial1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtRFC;
		private System.Windows.Forms.Label label1;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFacturar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTelOfi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.TextBox txtTelT;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtDirT;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusEmpresa;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsBusEmpresa dsBusEmpresa1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusCliente;
		private LancNeo.dsBusCliente dsBusCliente1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private Label label2;
        private TextBox textBox8;
        private Label label18;
        private TextBox textBox5;
        private Label label19;
        private TextBox textBox6;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton6;
        private Label label13;
        private Label label14;
        private Label label16;
        private TextBox textBox3;
        private Label label17;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label12;
        private Label label11;
        private Label label9;
        private TextBox textBox2;
        private Label label20;
        private TextBox textBox7;
        private RadioButton radioButton7;
        private DateTimePicker dtphini;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label21;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label22;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Empresas()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
            //ArrayList pago =new ArrayList();
            //pago.Add(new matCombo1("Oficina",1));
            //pago.Add(new matCombo1("Obra",2));
            //cmbPago.DataSource = pago; //DataSource for lookup table 
            //cmbPago.DisplayMember = "getName"; //Display value in lookup table
            //cmbPago.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresas));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDARazonSocial = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsRazonSocial1 = new LancNeo.dsRazonSocial();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusEmpresa1 = new LancNeo.dsBusEmpresa();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtphini = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDirT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelOfi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFacturar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.dsBusCliente1 = new LancNeo.dsBusCliente();
            this.sqlDABusEmpresa = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusCliente = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRazonSocial1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEmpresa1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusCliente1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 510);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(678, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(678, 64);
            // 
            // sqlDARazonSocial
            // 
            this.sqlDARazonSocial.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDARazonSocial.InsertCommand = this.sqlInsertCommand1;
            this.sqlDARazonSocial.SelectCommand = this.sqlSelectCommand1;
            this.sqlDARazonSocial.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Razonsocial", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar"),
                        new System.Data.Common.DataColumnMapping("Domicilio", "Domicilio"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Codpos", "Codpos"),
                        new System.Data.Common.DataColumnMapping("Lugar", "Lugar"),
                        new System.Data.Common.DataColumnMapping("Coloniat", "Coloniat"),
                        new System.Data.Common.DataColumnMapping("Telefonot", "Telefonot"),
                        new System.Data.Common.DataColumnMapping("Encargada", "Encargada"),
                        new System.Data.Common.DataColumnMapping("email", "email"),
                        new System.Data.Common.DataColumnMapping("Revision", "Revision"),
                        new System.Data.Common.DataColumnMapping("Pagos", "Pagos"),
                        new System.Data.Common.DataColumnMapping("diar", "diar"),
                        new System.Data.Common.DataColumnMapping("diap", "diap"),
                        new System.Data.Common.DataColumnMapping("rhoin", "rhoin"),
                        new System.Data.Common.DataColumnMapping("rhfin", "rhfin"),
                        new System.Data.Common.DataColumnMapping("phoin", "phoin"),
                        new System.Data.Common.DataColumnMapping("phofi", "phofi"),
                        new System.Data.Common.DataColumnMapping("Fpago", "Fpago"),
                        new System.Data.Common.DataColumnMapping("Banco", "Banco"),
                        new System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"),
                        new System.Data.Common.DataColumnMapping("CURP", "CURP")})});
            this.sqlDARazonSocial.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IsNull_IdCliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdCliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RFC", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RFC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Facturar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Facturar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Facturar", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Facturar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Domicilio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Domicilio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Domicilio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Codpos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Codpos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Codpos", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Codpos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lugar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lugar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lugar", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lugar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Coloniat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Coloniat", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Coloniat", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coloniat", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Telefonot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefonot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Telefonot", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefonot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Encargada", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Encargada", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Encargada", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Encargada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "email", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "email", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Revision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Revision", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Revision", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revision", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pagos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pagos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pagos", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pagos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_diar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "diar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_diar", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "diar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_diap", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "diap", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_diap", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "diap", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_rhoin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "rhoin", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_rhoin", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rhoin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_rhfin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "rhfin", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_rhfin", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rhfin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_phoin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phoin", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_phoin", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phoin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_phofi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phofi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_phofi", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phofi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fpago", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fpago", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fpago", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fpago", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Banco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Banco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Banco", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Banco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cuenta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cuenta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cuenta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CURP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CURP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CURP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CURP", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@Facturar", System.Data.SqlDbType.NVarChar, 0, "Facturar"),
            new System.Data.SqlClient.SqlParameter("@Domicilio", System.Data.SqlDbType.NVarChar, 0, "Domicilio"),
            new System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.NVarChar, 0, "Colonia"),
            new System.Data.SqlClient.SqlParameter("@Codpos", System.Data.SqlDbType.Real, 0, "Codpos"),
            new System.Data.SqlClient.SqlParameter("@Lugar", System.Data.SqlDbType.NVarChar, 0, "Lugar"),
            new System.Data.SqlClient.SqlParameter("@Coloniat", System.Data.SqlDbType.NVarChar, 0, "Coloniat"),
            new System.Data.SqlClient.SqlParameter("@Telefonot", System.Data.SqlDbType.NVarChar, 0, "Telefonot"),
            new System.Data.SqlClient.SqlParameter("@Encargada", System.Data.SqlDbType.VarChar, 0, "Encargada"),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 0, "email"),
            new System.Data.SqlClient.SqlParameter("@Revision", System.Data.SqlDbType.SmallInt, 0, "Revision"),
            new System.Data.SqlClient.SqlParameter("@Pagos", System.Data.SqlDbType.SmallInt, 0, "Pagos"),
            new System.Data.SqlClient.SqlParameter("@diar", System.Data.SqlDbType.VarChar, 0, "diar"),
            new System.Data.SqlClient.SqlParameter("@diap", System.Data.SqlDbType.VarChar, 0, "diap"),
            new System.Data.SqlClient.SqlParameter("@rhoin", System.Data.SqlDbType.Time, 0, "rhoin"),
            new System.Data.SqlClient.SqlParameter("@rhfin", System.Data.SqlDbType.Time, 0, "rhfin"),
            new System.Data.SqlClient.SqlParameter("@phoin", System.Data.SqlDbType.Time, 0, "phoin"),
            new System.Data.SqlClient.SqlParameter("@phofi", System.Data.SqlDbType.Time, 0, "phofi"),
            new System.Data.SqlClient.SqlParameter("@Fpago", System.Data.SqlDbType.SmallInt, 0, "Fpago"),
            new System.Data.SqlClient.SqlParameter("@Banco", System.Data.SqlDbType.VarChar, 0, "Banco"),
            new System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 0, "Cuenta"),
            new System.Data.SqlClient.SqlParameter("@CURP", System.Data.SqlDbType.VarChar, 0, "CURP")});
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
            new System.Data.SqlClient.SqlParameter("@Facturar", System.Data.SqlDbType.NVarChar, 0, "Facturar"),
            new System.Data.SqlClient.SqlParameter("@Domicilio", System.Data.SqlDbType.NVarChar, 0, "Domicilio"),
            new System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.NVarChar, 0, "Colonia"),
            new System.Data.SqlClient.SqlParameter("@Codpos", System.Data.SqlDbType.Real, 0, "Codpos"),
            new System.Data.SqlClient.SqlParameter("@Lugar", System.Data.SqlDbType.NVarChar, 0, "Lugar"),
            new System.Data.SqlClient.SqlParameter("@Coloniat", System.Data.SqlDbType.NVarChar, 0, "Coloniat"),
            new System.Data.SqlClient.SqlParameter("@Telefonot", System.Data.SqlDbType.NVarChar, 0, "Telefonot"),
            new System.Data.SqlClient.SqlParameter("@Encargada", System.Data.SqlDbType.VarChar, 0, "Encargada"),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 0, "email"),
            new System.Data.SqlClient.SqlParameter("@Revision", System.Data.SqlDbType.SmallInt, 0, "Revision"),
            new System.Data.SqlClient.SqlParameter("@Pagos", System.Data.SqlDbType.SmallInt, 0, "Pagos"),
            new System.Data.SqlClient.SqlParameter("@diar", System.Data.SqlDbType.VarChar, 0, "diar"),
            new System.Data.SqlClient.SqlParameter("@diap", System.Data.SqlDbType.VarChar, 0, "diap"),
            new System.Data.SqlClient.SqlParameter("@rhoin", System.Data.SqlDbType.Time, 0, "rhoin"),
            new System.Data.SqlClient.SqlParameter("@rhfin", System.Data.SqlDbType.Time, 0, "rhfin"),
            new System.Data.SqlClient.SqlParameter("@phoin", System.Data.SqlDbType.Time, 0, "phoin"),
            new System.Data.SqlClient.SqlParameter("@phofi", System.Data.SqlDbType.Time, 0, "phofi"),
            new System.Data.SqlClient.SqlParameter("@Fpago", System.Data.SqlDbType.SmallInt, 0, "Fpago"),
            new System.Data.SqlClient.SqlParameter("@Banco", System.Data.SqlDbType.VarChar, 0, "Banco"),
            new System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 0, "Cuenta"),
            new System.Data.SqlClient.SqlParameter("@CURP", System.Data.SqlDbType.VarChar, 0, "CURP"),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdCliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdCliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RFC", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RFC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Facturar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Facturar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Facturar", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Facturar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Domicilio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Domicilio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Domicilio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Codpos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Codpos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Codpos", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Codpos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lugar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lugar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lugar", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lugar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Coloniat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Coloniat", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Coloniat", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Coloniat", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Telefonot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefonot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Telefonot", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefonot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Encargada", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Encargada", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Encargada", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Encargada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "email", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "email", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Revision", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Revision", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Revision", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Revision", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pagos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pagos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pagos", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pagos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_diar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "diar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_diar", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "diar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_diap", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "diap", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_diap", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "diap", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_rhoin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "rhoin", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_rhoin", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rhoin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_rhfin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "rhfin", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_rhfin", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rhfin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_phoin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phoin", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_phoin", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phoin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_phofi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phofi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_phofi", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phofi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fpago", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fpago", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fpago", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fpago", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Banco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Banco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Banco", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Banco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cuenta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cuenta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cuenta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CURP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CURP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CURP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CURP", System.Data.DataRowVersion.Original, null)});
            // 
            // dsRazonSocial1
            // 
            this.dsRazonSocial1.DataSetName = "dsRazonSocial";
            this.dsRazonSocial1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsRazonSocial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dtphini);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTelT);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtDirT);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtCP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTelOfi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtColonia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDirección);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFacturar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtRFC);
            this.panel2.Location = new System.Drawing.Point(12, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 432);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusEmpresa1.Razonsocial;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(233, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Busca");
            // 
            // dsBusEmpresa1
            // 
            this.dsBusEmpresa1.DataSetName = "dsBusEmpresa";
            this.dsBusEmpresa1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusEmpresa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 13);
            this.label21.TabIndex = 108;
            this.label21.Text = "Entidad federativa:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Coloniat", true));
            this.textBox9.Location = new System.Drawing.Point(107, 154);
            this.textBox9.MaxLength = 50;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(320, 20);
            this.textBox9.TabIndex = 4;
            this.textBox9.Text = "textBox1";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:mm";
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.phofi", true));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(458, 316);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker3.TabIndex = 106;
            this.dateTimePicker3.Value = new System.DateTime(2004, 10, 20, 10, 57, 50, 679);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.phoin", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(350, 313);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker2.TabIndex = 105;
            this.dateTimePicker2.Value = new System.DateTime(2004, 10, 20, 10, 57, 50, 679);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.rhfin", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(458, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker1.TabIndex = 104;
            this.dateTimePicker1.Value = new System.DateTime(2004, 10, 20, 10, 57, 50, 679);
            // 
            // dtphini
            // 
            this.dtphini.CustomFormat = "HH:mm";
            this.dtphini.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.rhoin", true));
            this.dtphini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphini.Location = new System.Drawing.Point(350, 283);
            this.dtphini.Name = "dtphini";
            this.dtphini.ShowUpDown = true;
            this.dtphini.Size = new System.Drawing.Size(56, 20);
            this.dtphini.TabIndex = 103;
            this.dtphini.Value = new System.DateTime(2004, 10, 20, 10, 57, 50, 679);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(298, 380);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 102;
            this.label20.Text = "Cuenta:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Cuenta", true));
            this.textBox7.Location = new System.Drawing.Point(342, 376);
            this.textBox7.MaxLength = 0;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(172, 20);
            this.textBox7.TabIndex = 101;
            this.textBox7.Text = "textBox7";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 380);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 100;
            this.label18.Text = "Banco:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Banco", true));
            this.textBox5.Location = new System.Drawing.Point(107, 376);
            this.textBox5.MaxLength = 0;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 20);
            this.textBox5.TabIndex = 99;
            this.textBox5.Text = "textBox5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 348);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 98;
            this.label19.Text = "Forma de pago:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Pagos", true));
            this.textBox6.Location = new System.Drawing.Point(28, 401);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(0, 20);
            this.textBox6.TabIndex = 97;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(107, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 31);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton7.Location = new System.Drawing.Point(168, 9);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(64, 17);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Efectivo";
            this.radioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(71, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Transferencia";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton6.ForeColor = System.Drawing.Color.White;
            this.radioButton6.Location = new System.Drawing.Point(3, 8);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(62, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Cheque";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 94;
            this.label13.Text = "a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "de";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 91;
            this.label16.Text = "día:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.diap", true));
            this.textBox3.Location = new System.Drawing.Point(277, 313);
            this.textBox3.MaxLength = 9;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 20);
            this.textBox3.TabIndex = 90;
            this.textBox3.Text = "textBox3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(64, 317);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "Pagos:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Fpago", true));
            this.textBox4.Location = new System.Drawing.Point(28, 313);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(0, 20);
            this.textBox4.TabIndex = 88;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(107, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 31);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(80, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Obra";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(3, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "En oficina";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(431, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "a";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "de";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "día:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.diar", true));
            this.textBox2.Location = new System.Drawing.Point(277, 283);
            this.textBox2.MaxLength = 9;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 81;
            this.textBox2.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Revisión:";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Revision", true));
            this.textBox8.Location = new System.Drawing.Point(28, 283);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(0, 20);
            this.textBox8.TabIndex = 79;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(107, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 31);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton5.ForeColor = System.Drawing.Color.White;
            this.radioButton5.Location = new System.Drawing.Point(80, 8);
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
            this.radioButton4.Location = new System.Drawing.Point(3, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "En oficina";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.email", true));
            this.textBox1.Location = new System.Drawing.Point(107, 229);
            this.textBox1.MaxLength = 70;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(320, 43);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "textBox1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Telefonos:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelT
            // 
            this.txtTelT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Telefonot", true));
            this.txtTelT.Location = new System.Drawing.Point(107, 203);
            this.txtTelT.MaxLength = 50;
            this.txtTelT.Name = "txtTelT";
            this.txtTelT.Size = new System.Drawing.Size(320, 20);
            this.txtTelT.TabIndex = 7;
            this.txtTelT.Text = "textBox1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Encargado pagos:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDirT
            // 
            this.txtDirT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Encargada", true));
            this.txtDirT.Location = new System.Drawing.Point(107, 177);
            this.txtDirT.MaxLength = 50;
            this.txtDirT.Name = "txtDirT";
            this.txtDirT.Size = new System.Drawing.Size(320, 20);
            this.txtDirT.TabIndex = 6;
            this.txtDirT.Text = "textBox1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "C.P:";
            // 
            // txtCP
            // 
            this.txtCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Codpos", true));
            this.txtCP.Location = new System.Drawing.Point(383, 20);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(44, 20);
            this.txtCP.TabIndex = 5;
            this.txtCP.Text = "textBox2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lugar de pago:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelOfi
            // 
            this.txtTelOfi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Lugar", true));
            this.txtTelOfi.Location = new System.Drawing.Point(107, 403);
            this.txtTelOfi.MaxLength = 50;
            this.txtTelOfi.Name = "txtTelOfi";
            this.txtTelOfi.Size = new System.Drawing.Size(320, 20);
            this.txtTelOfi.TabIndex = 21;
            this.txtTelOfi.Text = "textBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Colonia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtColonia
            // 
            this.txtColonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Colonia", true));
            this.txtColonia.Location = new System.Drawing.Point(107, 130);
            this.txtColonia.MaxLength = 50;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(320, 20);
            this.txtColonia.TabIndex = 3;
            this.txtColonia.Text = "textBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dirección:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDirección
            // 
            this.txtDirección.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Domicilio", true));
            this.txtDirección.Location = new System.Drawing.Point(107, 106);
            this.txtDirección.MaxLength = 50;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(320, 20);
            this.txtDirección.TabIndex = 2;
            this.txtDirección.Text = "textBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Facturar a:";
            // 
            // txtFacturar
            // 
            this.txtFacturar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.Facturar", true));
            this.txtFacturar.Location = new System.Drawing.Point(107, 66);
            this.txtFacturar.MaxLength = 80;
            this.txtFacturar.Multiline = true;
            this.txtFacturar.Name = "txtFacturar";
            this.txtFacturar.Size = new System.Drawing.Size(320, 36);
            this.txtFacturar.TabIndex = 1;
            this.txtFacturar.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R.F.C.:";
            // 
            // txtRFC
            // 
            this.txtRFC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.RFC", true));
            this.txtRFC.Location = new System.Drawing.Point(107, 20);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 20);
            this.txtRFC.TabIndex = 0;
            this.txtRFC.Text = "textBox1";
            // 
            // dsBusCliente1
            // 
            this.dsBusCliente1.DataSetName = "dsBusCliente";
            this.dsBusCliente1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusCliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDABusEmpresa
            // 
            this.sqlDABusEmpresa.SelectCommand = this.sqlSelectCommand2;
            this.sqlDABusEmpresa.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Razonsocial", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     ISNULL(IdCliente, \' \') AS IdCliente, RFC, Facturar, \' \' AS Cliente\r\nFR" +
    "OM         Razonsocial\r\nORDER BY RFC";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDABusCliente
            // 
            this.sqlDABusCliente.SelectCommand = this.sqlSelectCommand3;
            this.sqlDABusCliente.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "cliente", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdCliente, Cliente, Direccion FROM cliente ORDER BY Cliente";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(468, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 109;
            this.label22.Text = "CURP:";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRazonSocial1, "Razonsocial.CURP", true));
            this.textBox10.Location = new System.Drawing.Point(514, 40);
            this.textBox10.MaxLength = 18;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 20);
            this.textBox10.TabIndex = 110;
            this.textBox10.Text = "012345678912345678";
            // 
            // Empresas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(678, 532);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDARazonSocial;
            this.dsGeneral = this.dsRazonSocial1;
            this.Name = "Empresas";
            this.NombreTabla = "Razonsocial";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Empresas_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsRazonSocial1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEmpresa1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusCliente1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Empresas_Load(object sender, System.EventArgs e)
		{
			sqlDABusEmpresa.Fill(dsBusEmpresa1, "Razonsocial");
			sqlDABusCliente.Fill(dsBusCliente1, "Cliente");
			this.buscaBtn1.Catalogo = this;
			EstableceVistaPrevia();
		}
		private void EstableceVistaPrevia()
		{
			DataSet dsVP = new DataSet();
			sqlDABusEmpresa.Fill(dsVP, "Razonsocial");
			dsVistaPrevia = dsVP;
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int CarpCopia = int.Parse(textBox6.Text);
            switch (CarpCopia)
            {
                case 1:
                    radioButton2.Checked = true;
                    break;
                case 2:
                    radioButton1.Checked = true;
                    break;
                default:
                    radioButton2.Checked = false;
                    radioButton1.Checked = false;
                    break;
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                textBox6.Text = "1";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox6.Text = "2";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int TipoLab = int.Parse(textBox4.Text);
            switch (TipoLab)
            {
                case 1:
                    radioButton6.Checked = true;
                    break;
                case 2:
                    radioButton3.Checked = true;
                    break;
                case 3:
                    radioButton7.Checked = true;
                    break;
                default:
                    radioButton6.Checked = false;
                    radioButton3.Checked = false;
                    radioButton7.Checked = false;
                    break;
            }
        }

        
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
                textBox4.Text = "1";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                textBox4.Text = "2";

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
                textBox4.Text = "3";

        }

	}
}
