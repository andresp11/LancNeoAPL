using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Asfaltico.
	/// </summary>
	public class Asfaltico : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Data.SqlClient.SqlDataAdapter sqlDAAsfaltico;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private LancNeo.dsAsfaltico dsAsfaltico1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.DateTimePicker dtpFmuestreo;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtpFensaye;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtSemana;
		private System.Windows.Forms.DateTimePicker dtpFinforme;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbNoeco;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtObserva;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.TextBox textBox29;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox44;
		private System.Windows.Forms.TextBox textBox45;
		private System.Windows.Forms.TextBox textBox46;
		private System.Windows.Forms.TextBox textBox47;
		private System.Windows.Forms.TextBox textBox48;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.TextBox textBox38;
		private System.Windows.Forms.TextBox textBox39;
		private System.Windows.Forms.TextBox textBox40;
		private System.Windows.Forms.TextBox textBox41;
		private System.Windows.Forms.TextBox textBox42;
		private System.Windows.Forms.TextBox textBox43;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox textBox49;
		private System.Windows.Forms.TextBox textBox50;
		private System.Windows.Forms.TextBox textBox51;
		private System.Windows.Forms.TextBox textBox52;
		private System.Windows.Forms.TextBox textBox53;
		private System.Windows.Forms.TextBox textBox54;
		private System.Windows.Forms.TextBox textBox55;
		private System.Windows.Forms.TextBox textBox56;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox6;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsLaboratorista dsLaboratorista1;
		private LancNeo.dsBusObra dsBusObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusAsfaltico;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsBusAsfaltico dsBusAsfaltico1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.DateTimePicker dtpFrecibo;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.Label label56;
        private TextBox txtUsrMov;
        private Label label59;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Asfaltico()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asfaltico));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAAsfaltico = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusAsfaltico1 = new LancNeo.dsBusAsfaltico();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNoeco = new System.Windows.Forms.ComboBox();
            this.dsAsfaltico1 = new LancNeo.dsAsfaltico();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.dtpFrecibo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFmuestreo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFensaye = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.dtpFinforme = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusAsfaltico = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusAsfaltico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAsfaltico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 537);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1010, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1010, 64);
            // 
            // sqlDAAsfaltico
            // 
            this.sqlDAAsfaltico.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAAsfaltico.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAAsfaltico.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAAsfaltico.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Asfaltico", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Frecibo", "Frecibo"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("Usarse", "Usarse"),
                        new System.Data.Common.DataColumnMapping("Tratamiento", "Tratamiento"),
                        new System.Data.Common.DataColumnMapping("Deposito", "Deposito"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Viaje", "Viaje"),
                        new System.Data.Common.DataColumnMapping("TendidoI", "TendidoI"),
                        new System.Data.Common.DataColumnMapping("TendidoF", "TendidoF"),
                        new System.Data.Common.DataColumnMapping("Carril", "Carril"),
                        new System.Data.Common.DataColumnMapping("Franja", "Franja"),
                        new System.Data.Common.DataColumnMapping("TSalida", "TSalida"),
                        new System.Data.Common.DataColumnMapping("TTendido", "TTendido"),
                        new System.Data.Common.DataColumnMapping("Tcompacta", "Tcompacta"),
                        new System.Data.Common.DataColumnMapping("MSeca", "MSeca"),
                        new System.Data.Common.DataColumnMapping("MLP", "MLP"),
                        new System.Data.Common.DataColumnMapping("Absor", "Absor"),
                        new System.Data.Common.DataColumnMapping("Desgaste", "Desgaste"),
                        new System.Data.Common.DataColumnMapping("Tritura", "Tritura"),
                        new System.Data.Common.DataColumnMapping("Alarga", "Alarga"),
                        new System.Data.Common.DataColumnMapping("Part", "Part"),
                        new System.Data.Common.DataColumnMapping("Arena", "Arena"),
                        new System.Data.Common.DataColumnMapping("Lineal", "Lineal"),
                        new System.Data.Common.DataColumnMapping("Asfalto", "Asfalto"),
                        new System.Data.Common.DataColumnMapping("Marca", "Marca"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Afinidad", "Afinidad"),
                        new System.Data.Common.DataColumnMapping("PMSeca", "PMSeca"),
                        new System.Data.Common.DataColumnMapping("PMLP", "PMLP"),
                        new System.Data.Common.DataColumnMapping("PAbsor", "PAbsor"),
                        new System.Data.Common.DataColumnMapping("PDesgaste", "PDesgaste"),
                        new System.Data.Common.DataColumnMapping("PTritura", "PTritura"),
                        new System.Data.Common.DataColumnMapping("PAlarga", "PAlarga"),
                        new System.Data.Common.DataColumnMapping("PPart", "PPart"),
                        new System.Data.Common.DataColumnMapping("PArena", "PArena"),
                        new System.Data.Common.DataColumnMapping("PLineal", "PLineal"),
                        new System.Data.Common.DataColumnMapping("PAsfalto", "PAsfalto"),
                        new System.Data.Common.DataColumnMapping("PMarca", "PMarca"),
                        new System.Data.Common.DataColumnMapping("PTipo", "PTipo"),
                        new System.Data.Common.DataColumnMapping("PCantidad", "PCantidad"),
                        new System.Data.Common.DataColumnMapping("PAfinidad", "PAfinidad"),
                        new System.Data.Common.DataColumnMapping("MEsp", "MEsp"),
                        new System.Data.Common.DataColumnMapping("Estabilidad", "Estabilidad"),
                        new System.Data.Common.DataColumnMapping("Flujo", "Flujo"),
                        new System.Data.Common.DataColumnMapping("Vacios", "Vacios"),
                        new System.Data.Common.DataColumnMapping("VAM", "VAM"),
                        new System.Data.Common.DataColumnMapping("EMEsp", "EMEsp"),
                        new System.Data.Common.DataColumnMapping("EEstabilidad", "EEstabilidad"),
                        new System.Data.Common.DataColumnMapping("EFlujo", "EFlujo"),
                        new System.Data.Common.DataColumnMapping("EVacios", "EVacios"),
                        new System.Data.Common.DataColumnMapping("EVAM", "EVAM"),
                        new System.Data.Common.DataColumnMapping("TipoC", "TipoC"),
                        new System.Data.Common.DataColumnMapping("Penetra", "Penetra"),
                        new System.Data.Common.DataColumnMapping("Viscosdad", "Viscosdad"),
                        new System.Data.Common.DataColumnMapping("Recomendad", "Recomendad"),
                        new System.Data.Common.DataColumnMapping("Aplicada", "Aplicada"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAAsfaltico.UpdateCommand = this.sqlUpdateCommand1;
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Fmuestreo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fensaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fensaye", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Finforme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Frecibo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Frecibo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Frecibo", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Frecibo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Material", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Usarse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Usarse", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Usarse", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usarse", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tratamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tratamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tratamiento", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tratamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Deposito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Deposito", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Deposito", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Deposito", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ubicacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Viaje", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Viaje", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Viaje", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "Viaje", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TendidoI", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TendidoI", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TendidoI", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TendidoI", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TendidoF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TendidoF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TendidoF", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TendidoF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carril", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carril", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carril", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Carril", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Franja", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Franja", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Franja", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Franja", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TSalida", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TSalida", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TSalida", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TSalida", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TTendido", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TTendido", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TTendido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TTendido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tcompacta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tcompacta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tcompacta", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Tcompacta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MSeca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MSeca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MSeca", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "MSeca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MLP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MLP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MLP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "MLP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Absor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Absor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Absor", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Absor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Desgaste", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Desgaste", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Desgaste", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Desgaste", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tritura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tritura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tritura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Tritura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alarga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alarga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alarga", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Alarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Part", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Part", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Part", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Part", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Arena", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Arena", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Arena", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arena", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lineal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lineal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lineal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Lineal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Asfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Asfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Asfalto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Asfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Marca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cantidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cantidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Afinidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Afinidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Afinidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Afinidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PMSeca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PMSeca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PMSeca", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "PMSeca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PMLP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PMLP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PMLP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "PMLP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAbsor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAbsor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAbsor", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAbsor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PDesgaste", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PDesgaste", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PDesgaste", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PDesgaste", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PTritura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PTritura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PTritura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PTritura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAlarga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAlarga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAlarga", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAlarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PPart", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PPart", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PPart", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PPart", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PArena", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PArena", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PArena", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PArena", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PLineal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PLineal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PLineal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PLineal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAsfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAsfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAsfalto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAsfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PMarca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PMarca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PMarca", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PMarca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PTipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PTipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PTipo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PCantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PCantidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PCantidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PCantidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAfinidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAfinidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAfinidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAfinidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MEsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MEsp", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MEsp", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "MEsp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Estabilidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Estabilidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Estabilidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "Estabilidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Flujo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Flujo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Flujo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Flujo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Vacios", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Vacios", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Vacios", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Vacios", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VAM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VAM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VAM", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "VAM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EMEsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EMEsp", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EMEsp", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "EMEsp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EEstabilidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EEstabilidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EEstabilidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "EEstabilidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EFlujo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EFlujo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EFlujo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EFlujo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EVacios", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EVacios", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EVacios", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EVacios", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EVAM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EVAM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EVAM", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EVAM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TipoC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TipoC", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Penetra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Penetra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Penetra", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Penetra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Viscosdad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Viscosdad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Viscosdad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Viscosdad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Recomendad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Recomendad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Recomendad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Recomendad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Aplicada", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Aplicada", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Aplicada", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Aplicada", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, "Fmuestreo"),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.SmallDateTime, 0, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.SmallDateTime, 0, "Finforme"),
            new System.Data.SqlClient.SqlParameter("@Frecibo", System.Data.SqlDbType.SmallDateTime, 0, "Frecibo"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.NVarChar, 0, "Material"),
            new System.Data.SqlClient.SqlParameter("@Usarse", System.Data.SqlDbType.NVarChar, 0, "Usarse"),
            new System.Data.SqlClient.SqlParameter("@Tratamiento", System.Data.SqlDbType.NVarChar, 0, "Tratamiento"),
            new System.Data.SqlClient.SqlParameter("@Deposito", System.Data.SqlDbType.NVarChar, 0, "Deposito"),
            new System.Data.SqlClient.SqlParameter("@Ubicacion", System.Data.SqlDbType.NVarChar, 0, "Ubicacion"),
            new System.Data.SqlClient.SqlParameter("@Viaje", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "Viaje", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TendidoI", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TendidoI", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TendidoF", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TendidoF", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Carril", System.Data.SqlDbType.NVarChar, 0, "Carril"),
            new System.Data.SqlClient.SqlParameter("@Franja", System.Data.SqlDbType.NVarChar, 0, "Franja"),
            new System.Data.SqlClient.SqlParameter("@TSalida", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TSalida", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TTendido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TTendido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tcompacta", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Tcompacta", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MSeca", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "MSeca", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MLP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "MLP", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Absor", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Absor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Desgaste", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Desgaste", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tritura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Tritura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alarga", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Alarga", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Part", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Part", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Arena", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arena", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Lineal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Lineal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Asfalto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Asfalto", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.NVarChar, 0, "Marca"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.NVarChar, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cantidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Afinidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Afinidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PMSeca", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "PMSeca", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PMLP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "PMLP", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PAbsor", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAbsor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PDesgaste", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PDesgaste", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PTritura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PTritura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PAlarga", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAlarga", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PPart", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PPart", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PArena", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PArena", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PLineal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PLineal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PAsfalto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAsfalto", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PMarca", System.Data.SqlDbType.NVarChar, 0, "PMarca"),
            new System.Data.SqlClient.SqlParameter("@PTipo", System.Data.SqlDbType.NVarChar, 0, "PTipo"),
            new System.Data.SqlClient.SqlParameter("@PCantidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PCantidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PAfinidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAfinidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MEsp", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "MEsp", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Estabilidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "Estabilidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Flujo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Flujo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Vacios", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Vacios", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@VAM", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "VAM", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EMEsp", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "EMEsp", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EEstabilidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "EEstabilidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EFlujo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EFlujo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EVacios", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EVacios", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EVAM", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EVAM", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TipoC", System.Data.SqlDbType.NVarChar, 0, "TipoC"),
            new System.Data.SqlClient.SqlParameter("@Penetra", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Penetra", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Viscosdad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Viscosdad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Recomendad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Recomendad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Aplicada", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Aplicada", System.Data.DataRowVersion.Current, null),
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
            new System.Data.SqlClient.SqlParameter("@Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, "Fmuestreo"),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.SmallDateTime, 0, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.SmallDateTime, 0, "Finforme"),
            new System.Data.SqlClient.SqlParameter("@Frecibo", System.Data.SqlDbType.SmallDateTime, 0, "Frecibo"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.NVarChar, 0, "Material"),
            new System.Data.SqlClient.SqlParameter("@Usarse", System.Data.SqlDbType.NVarChar, 0, "Usarse"),
            new System.Data.SqlClient.SqlParameter("@Tratamiento", System.Data.SqlDbType.NVarChar, 0, "Tratamiento"),
            new System.Data.SqlClient.SqlParameter("@Deposito", System.Data.SqlDbType.NVarChar, 0, "Deposito"),
            new System.Data.SqlClient.SqlParameter("@Ubicacion", System.Data.SqlDbType.NVarChar, 0, "Ubicacion"),
            new System.Data.SqlClient.SqlParameter("@Viaje", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "Viaje", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TendidoI", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TendidoI", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TendidoF", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TendidoF", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Carril", System.Data.SqlDbType.NVarChar, 0, "Carril"),
            new System.Data.SqlClient.SqlParameter("@Franja", System.Data.SqlDbType.NVarChar, 0, "Franja"),
            new System.Data.SqlClient.SqlParameter("@TSalida", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TSalida", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TTendido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TTendido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tcompacta", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Tcompacta", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MSeca", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "MSeca", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MLP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "MLP", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Absor", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Absor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Desgaste", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Desgaste", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tritura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Tritura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alarga", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Alarga", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Part", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Part", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Arena", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arena", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Lineal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Lineal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Asfalto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Asfalto", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.NVarChar, 0, "Marca"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.NVarChar, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cantidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Afinidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Afinidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PMSeca", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "PMSeca", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PMLP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "PMLP", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PAbsor", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAbsor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PDesgaste", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PDesgaste", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PTritura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PTritura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PAlarga", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAlarga", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PPart", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PPart", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PArena", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PArena", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PLineal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PLineal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PAsfalto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAsfalto", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PMarca", System.Data.SqlDbType.NVarChar, 0, "PMarca"),
            new System.Data.SqlClient.SqlParameter("@PTipo", System.Data.SqlDbType.NVarChar, 0, "PTipo"),
            new System.Data.SqlClient.SqlParameter("@PCantidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PCantidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@PAfinidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAfinidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MEsp", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "MEsp", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Estabilidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "Estabilidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Flujo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Flujo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Vacios", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Vacios", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@VAM", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "VAM", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EMEsp", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "EMEsp", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EEstabilidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "EEstabilidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EFlujo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EFlujo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EVacios", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EVacios", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EVAM", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EVAM", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TipoC", System.Data.SqlDbType.NVarChar, 0, "TipoC"),
            new System.Data.SqlClient.SqlParameter("@Penetra", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Penetra", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Viscosdad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Viscosdad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Recomendad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Recomendad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Aplicada", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Aplicada", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConsObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fmuestreo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fensaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fensaye", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Finforme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Frecibo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Frecibo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Frecibo", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Frecibo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoEco", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Material", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Usarse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Usarse", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Usarse", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usarse", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tratamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tratamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tratamiento", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tratamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Deposito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Deposito", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Deposito", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Deposito", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ubicacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Viaje", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Viaje", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Viaje", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "Viaje", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TendidoI", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TendidoI", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TendidoI", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TendidoI", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TendidoF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TendidoF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TendidoF", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TendidoF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carril", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carril", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carril", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Carril", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Franja", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Franja", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Franja", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Franja", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TSalida", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TSalida", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TSalida", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TSalida", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TTendido", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TTendido", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TTendido", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "TTendido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tcompacta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tcompacta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tcompacta", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Tcompacta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MSeca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MSeca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MSeca", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "MSeca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MLP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MLP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MLP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "MLP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Absor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Absor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Absor", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Absor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Desgaste", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Desgaste", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Desgaste", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Desgaste", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tritura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tritura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tritura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Tritura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alarga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alarga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alarga", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Alarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Part", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Part", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Part", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Part", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Arena", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Arena", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Arena", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arena", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lineal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lineal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lineal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Lineal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Asfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Asfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Asfalto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Asfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Marca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cantidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cantidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Afinidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Afinidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Afinidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Afinidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PMSeca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PMSeca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PMSeca", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "PMSeca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PMLP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PMLP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PMLP", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "PMLP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAbsor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAbsor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAbsor", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAbsor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PDesgaste", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PDesgaste", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PDesgaste", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PDesgaste", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PTritura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PTritura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PTritura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PTritura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAlarga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAlarga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAlarga", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAlarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PPart", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PPart", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PPart", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PPart", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PArena", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PArena", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PArena", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PArena", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PLineal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PLineal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PLineal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PLineal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAsfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAsfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAsfalto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAsfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PMarca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PMarca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PMarca", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PMarca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PTipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PTipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PTipo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PCantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PCantidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PCantidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PCantidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAfinidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAfinidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAfinidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "PAfinidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MEsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MEsp", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MEsp", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "MEsp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Estabilidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Estabilidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Estabilidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "Estabilidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Flujo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Flujo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Flujo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Flujo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Vacios", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Vacios", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Vacios", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Vacios", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VAM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VAM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VAM", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "VAM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EMEsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EMEsp", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EMEsp", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "EMEsp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EEstabilidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EEstabilidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EEstabilidad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "EEstabilidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EFlujo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EFlujo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EFlujo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EFlujo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EVacios", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EVacios", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EVacios", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EVacios", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EVAM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EVAM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EVAM", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EVAM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TipoC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TipoC", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Penetra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Penetra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Penetra", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Penetra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Viscosdad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Viscosdad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Viscosdad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Viscosdad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Recomendad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Recomendad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Recomendad", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Recomendad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Aplicada", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Aplicada", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Aplicada", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "Aplicada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscaBtn1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbNoeco);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtObserva);
            this.groupBox1.Controls.Add(this.dtpFrecibo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFmuestreo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpFensaye);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSemana);
            this.groupBox1.Controls.Add(this.dtpFinforme);
            this.groupBox1.Controls.Add(this.txtConsecutivo);
            this.groupBox1.Controls.Add(this.cmbIdObra);
            this.groupBox1.Controls.Add(this.txtFolio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 312);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusAsfaltico1.Asfaltico;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(182, 18);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 53;
            // 
            // dsBusAsfaltico1
            // 
            this.dsBusAsfaltico1.DataSetName = "dsBusAsfaltico";
            this.dsBusAsfaltico1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusAsfaltico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ensayado por:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNoeco
            // 
            this.cmbNoeco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAsfaltico1, "Asfaltico.NoEco", true));
            this.cmbNoeco.DataSource = this.dsLaboratorista1;
            this.cmbNoeco.DisplayMember = "Laboratorista.Laboratorista";
            this.cmbNoeco.Location = new System.Drawing.Point(102, 210);
            this.cmbNoeco.Name = "cmbNoeco";
            this.cmbNoeco.Size = new System.Drawing.Size(178, 21);
            this.cmbNoeco.TabIndex = 61;
            this.cmbNoeco.ValueMember = "Laboratorista.NoEco";
            // 
            // dsAsfaltico1
            // 
            this.dsAsfaltico1.DataSetName = "dsAsfaltico";
            this.dsAsfaltico1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAsfaltico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Observaciones:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObserva
            // 
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Observaciones", true));
            this.txtObserva.Location = new System.Drawing.Point(102, 234);
            this.txtObserva.MaxLength = 512;
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserva.Size = new System.Drawing.Size(178, 74);
            this.txtObserva.TabIndex = 62;
            this.txtObserva.Text = "textBox5";
            // 
            // dtpFrecibo
            // 
            this.dtpFrecibo.CustomFormat = "dd/MM/yyyy";
            this.dtpFrecibo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Frecibo", true));
            this.dtpFrecibo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrecibo.Location = new System.Drawing.Point(102, 164);
            this.dtpFrecibo.Name = "dtpFrecibo";
            this.dtpFrecibo.Size = new System.Drawing.Size(84, 20);
            this.dtpFrecibo.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Fecha de recibo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFmuestreo
            // 
            this.dtpFmuestreo.CustomFormat = "dd/MM/yyyy";
            this.dtpFmuestreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Fmuestreo", true));
            this.dtpFmuestreo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFmuestreo.Location = new System.Drawing.Point(102, 116);
            this.dtpFmuestreo.Name = "dtpFmuestreo";
            this.dtpFmuestreo.Size = new System.Drawing.Size(84, 20);
            this.dtpFmuestreo.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Fecha muestreo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFensaye
            // 
            this.dtpFensaye.CustomFormat = "dd/MM/yyyy";
            this.dtpFensaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Fensaye", true));
            this.dtpFensaye.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFensaye.Location = new System.Drawing.Point(102, 188);
            this.dtpFensaye.Name = "dtpFensaye";
            this.dtpFensaye.Size = new System.Drawing.Size(84, 20);
            this.dtpFensaye.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Fecha ensaye:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(102, 92);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(66, 20);
            this.txtSemana.TabIndex = 47;
            this.txtSemana.Text = "textBox3";
            // 
            // dtpFinforme
            // 
            this.dtpFinforme.CustomFormat = "dd/MM/yyyy";
            this.dtpFinforme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Finforme", true));
            this.dtpFinforme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinforme.Location = new System.Drawing.Point(102, 140);
            this.dtpFinforme.Name = "dtpFinforme";
            this.dtpFinforme.Size = new System.Drawing.Size(84, 20);
            this.dtpFinforme.TabIndex = 49;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.ConsObra", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(102, 68);
            this.txtConsecutivo.MaxLength = 4;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
            this.txtConsecutivo.TabIndex = 46;
            this.txtConsecutivo.Text = "textBox2";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAsfaltico1, "Asfaltico.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(102, 44);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 45;
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
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(102, 20);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 44;
            this.txtFolio.Text = "textBox1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Semana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Fecha informe:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Consecutivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox24);
            this.groupBox2.Controls.Add(this.label57);
            this.groupBox2.Controls.Add(this.textBox23);
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.textBox25);
            this.groupBox2.Controls.Add(this.label58);
            this.groupBox2.Controls.Add(this.textBox22);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.label53);
            this.groupBox2.Controls.Add(this.textBox18);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(286, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 152);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // textBox24
            // 
            this.textBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Tcompacta", true));
            this.textBox24.Location = new System.Drawing.Point(212, 86);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(28, 20);
            this.textBox24.TabIndex = 31;
            this.textBox24.Text = "textBox24";
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(136, 86);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(74, 32);
            this.label57.TabIndex = 30;
            this.label57.Text = "Al iniciar compactación";
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.TTendido", true));
            this.textBox23.Location = new System.Drawing.Point(212, 64);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(28, 20);
            this.textBox23.TabIndex = 29;
            this.textBox23.Text = "textBox23";
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(134, 66);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(76, 16);
            this.label56.TabIndex = 28;
            this.label56.Text = "En el tendido:";
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(18, 108);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(86, 38);
            this.label55.TabIndex = 24;
            this.label55.Text = "Temperatura mezcla al salir de la planta:";
            // 
            // textBox25
            // 
            this.textBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Franja", true));
            this.textBox25.Location = new System.Drawing.Point(106, 86);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(28, 20);
            this.textBox25.TabIndex = 27;
            this.textBox25.Text = "textBox25";
            // 
            // label58
            // 
            this.label58.Location = new System.Drawing.Point(64, 66);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(40, 16);
            this.label58.TabIndex = 26;
            this.label58.Text = "Carril:";
            // 
            // textBox22
            // 
            this.textBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.TSalida", true));
            this.textBox22.Location = new System.Drawing.Point(106, 108);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(28, 20);
            this.textBox22.TabIndex = 25;
            this.textBox22.Text = "textBox22";
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Carril", true));
            this.textBox20.Location = new System.Drawing.Point(106, 64);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(28, 20);
            this.textBox20.TabIndex = 23;
            this.textBox20.Text = "textBox20";
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(68, 86);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(36, 18);
            this.label54.TabIndex = 22;
            this.label54.Text = "Franja:";
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.TendidoF", true));
            this.textBox19.Location = new System.Drawing.Point(148, 42);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(28, 20);
            this.textBox19.TabIndex = 21;
            this.textBox19.Text = "textBox19";
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(138, 44);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(10, 23);
            this.label53.TabIndex = 20;
            this.label53.Text = "a";
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.TendidoI", true));
            this.textBox18.Location = new System.Drawing.Point(106, 42);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(28, 20);
            this.textBox18.TabIndex = 19;
            this.textBox18.Text = "textBox18";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(40, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 18);
            this.label22.TabIndex = 18;
            this.label22.Text = "Tendido en:";
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Viaje", true));
            this.textBox17.Location = new System.Drawing.Point(106, 20);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(28, 20);
            this.textBox17.TabIndex = 17;
            this.textBox17.Text = "textBox17";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(72, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 18);
            this.label20.TabIndex = 16;
            this.label20.Text = "Viaje:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.textBox21);
            this.groupBox3.Controls.Add(this.textBox26);
            this.groupBox3.Controls.Add(this.textBox27);
            this.groupBox3.Controls.Add(this.textBox28);
            this.groupBox3.Controls.Add(this.textBox29);
            this.groupBox3.Controls.Add(this.textBox30);
            this.groupBox3.Controls.Add(this.textBox31);
            this.groupBox3.Controls.Add(this.textBox32);
            this.groupBox3.Controls.Add(this.textBox33);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Location = new System.Drawing.Point(524, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 152);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 94);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 13);
            this.label35.TabIndex = 114;
            this.label35.Text = "usado";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 78);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(39, 13);
            this.label34.TabIndex = 113;
            this.label34.Text = "Aditivo";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(188, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 13);
            this.label27.TabIndex = 112;
            this.label27.Text = "Proyecto";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(152, 13);
            this.label28.TabIndex = 111;
            this.label28.Text = "CARACTERISTICAS MEZCLA";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PAfinidad", true));
            this.textBox16.Location = new System.Drawing.Point(182, 128);
            this.textBox16.MaxLength = 5;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(58, 20);
            this.textBox16.TabIndex = 110;
            this.textBox16.Text = "textBox3";
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PCantidad", true));
            this.textBox21.Location = new System.Drawing.Point(182, 106);
            this.textBox21.MaxLength = 5;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(58, 20);
            this.textBox21.TabIndex = 109;
            this.textBox21.Text = "textBox3";
            // 
            // textBox26
            // 
            this.textBox26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PTipo", true));
            this.textBox26.Location = new System.Drawing.Point(182, 84);
            this.textBox26.MaxLength = 5;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(58, 20);
            this.textBox26.TabIndex = 108;
            this.textBox26.Text = "textBox26";
            // 
            // textBox27
            // 
            this.textBox27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PMarca", true));
            this.textBox27.Location = new System.Drawing.Point(182, 62);
            this.textBox27.MaxLength = 5;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(58, 20);
            this.textBox27.TabIndex = 107;
            this.textBox27.Text = "textBox3";
            // 
            // textBox28
            // 
            this.textBox28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PAsfalto", true));
            this.textBox28.Location = new System.Drawing.Point(182, 40);
            this.textBox28.MaxLength = 5;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(58, 20);
            this.textBox28.TabIndex = 106;
            this.textBox28.Text = "textBox3";
            // 
            // textBox29
            // 
            this.textBox29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Afinidad", true));
            this.textBox29.Location = new System.Drawing.Point(122, 128);
            this.textBox29.MaxLength = 5;
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(58, 20);
            this.textBox29.TabIndex = 105;
            this.textBox29.Text = "textBox3";
            // 
            // textBox30
            // 
            this.textBox30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Cantidad", true));
            this.textBox30.Location = new System.Drawing.Point(122, 106);
            this.textBox30.MaxLength = 5;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(58, 20);
            this.textBox30.TabIndex = 104;
            this.textBox30.Text = "textBox3";
            // 
            // textBox31
            // 
            this.textBox31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Tipo", true));
            this.textBox31.Location = new System.Drawing.Point(122, 84);
            this.textBox31.MaxLength = 5;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(58, 20);
            this.textBox31.TabIndex = 103;
            this.textBox31.Text = "textBox31";
            // 
            // textBox32
            // 
            this.textBox32.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Marca", true));
            this.textBox32.Location = new System.Drawing.Point(122, 62);
            this.textBox32.MaxLength = 5;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(58, 20);
            this.textBox32.TabIndex = 102;
            this.textBox32.Text = "textBox3";
            // 
            // textBox33
            // 
            this.textBox33.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Asfalto", true));
            this.textBox33.Location = new System.Drawing.Point(122, 40);
            this.textBox33.MaxLength = 5;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(58, 20);
            this.textBox33.TabIndex = 101;
            this.textBox33.Text = "textBox3";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(60, 132);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(48, 13);
            this.label29.TabIndex = 100;
            this.label29.Text = "Afinidad:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(54, 110);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 13);
            this.label30.TabIndex = 99;
            this.label30.Text = "Cantidad:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(78, 88);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 13);
            this.label31.TabIndex = 98;
            this.label31.Text = "Tipo:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(68, 66);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 13);
            this.label32.TabIndex = 97;
            this.label32.Text = "Marca:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 44);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 13);
            this.label33.TabIndex = 96;
            this.label33.Text = "Contenido asfalto:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox34);
            this.groupBox4.Controls.Add(this.textBox35);
            this.groupBox4.Controls.Add(this.textBox36);
            this.groupBox4.Controls.Add(this.textBox37);
            this.groupBox4.Controls.Add(this.textBox38);
            this.groupBox4.Controls.Add(this.textBox39);
            this.groupBox4.Controls.Add(this.textBox40);
            this.groupBox4.Controls.Add(this.textBox41);
            this.groupBox4.Controls.Add(this.textBox42);
            this.groupBox4.Controls.Add(this.textBox43);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.textBox44);
            this.groupBox4.Controls.Add(this.textBox45);
            this.groupBox4.Controls.Add(this.textBox46);
            this.groupBox4.Controls.Add(this.textBox47);
            this.groupBox4.Controls.Add(this.textBox48);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.label45);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Location = new System.Drawing.Point(774, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 312);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // textBox34
            // 
            this.textBox34.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.EVAM", true));
            this.textBox34.Location = new System.Drawing.Point(146, 126);
            this.textBox34.MaxLength = 5;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(58, 20);
            this.textBox34.TabIndex = 170;
            this.textBox34.Text = "textBox3";
            // 
            // textBox35
            // 
            this.textBox35.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.EVacios", true));
            this.textBox35.Location = new System.Drawing.Point(146, 104);
            this.textBox35.MaxLength = 5;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(58, 20);
            this.textBox35.TabIndex = 169;
            this.textBox35.Text = "textBox3";
            // 
            // textBox36
            // 
            this.textBox36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.EFlujo", true));
            this.textBox36.Location = new System.Drawing.Point(146, 82);
            this.textBox36.MaxLength = 5;
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(58, 20);
            this.textBox36.TabIndex = 168;
            this.textBox36.Text = "textBox36";
            // 
            // textBox37
            // 
            this.textBox37.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.EEstabilidad", true));
            this.textBox37.Location = new System.Drawing.Point(146, 60);
            this.textBox37.MaxLength = 5;
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(58, 20);
            this.textBox37.TabIndex = 167;
            this.textBox37.Text = "textBox3";
            // 
            // textBox38
            // 
            this.textBox38.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.EMEsp", true));
            this.textBox38.Location = new System.Drawing.Point(146, 38);
            this.textBox38.MaxLength = 5;
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(58, 20);
            this.textBox38.TabIndex = 166;
            this.textBox38.Text = "textBox3";
            // 
            // textBox39
            // 
            this.textBox39.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.VAM", true));
            this.textBox39.Location = new System.Drawing.Point(76, 126);
            this.textBox39.MaxLength = 5;
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(58, 20);
            this.textBox39.TabIndex = 165;
            this.textBox39.Text = "textBox3";
            // 
            // textBox40
            // 
            this.textBox40.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Vacios", true));
            this.textBox40.Location = new System.Drawing.Point(76, 104);
            this.textBox40.MaxLength = 5;
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(58, 20);
            this.textBox40.TabIndex = 164;
            this.textBox40.Text = "textBox3";
            // 
            // textBox41
            // 
            this.textBox41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Flujo", true));
            this.textBox41.Location = new System.Drawing.Point(76, 82);
            this.textBox41.MaxLength = 5;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(58, 20);
            this.textBox41.TabIndex = 163;
            this.textBox41.Text = "textBox41";
            // 
            // textBox42
            // 
            this.textBox42.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Estabilidad", true));
            this.textBox42.Location = new System.Drawing.Point(76, 60);
            this.textBox42.MaxLength = 5;
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(58, 20);
            this.textBox42.TabIndex = 162;
            this.textBox42.Text = "textBox3";
            // 
            // textBox43
            // 
            this.textBox43.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.MEsp", true));
            this.textBox43.Location = new System.Drawing.Point(76, 38);
            this.textBox43.MaxLength = 5;
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(58, 20);
            this.textBox43.TabIndex = 161;
            this.textBox43.Text = "textBox3";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(24, 130);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(42, 13);
            this.label38.TabIndex = 160;
            this.label38.Text = "V.A.M.:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(24, 108);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(42, 13);
            this.label39.TabIndex = 159;
            this.label39.Text = "Vacios:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(32, 86);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(32, 13);
            this.label40.TabIndex = 158;
            this.label40.Text = "Flujo:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(2, 64);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(61, 13);
            this.label41.TabIndex = 157;
            this.label41.Text = "Estabilidad:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(34, 42);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(32, 13);
            this.label42.TabIndex = 156;
            this.label42.Text = "M.E.:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(146, 20);
            this.label36.Name = "label36";
            this.label36.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label36.Size = new System.Drawing.Size(76, 13);
            this.label36.TabIndex = 155;
            this.label36.Text = "Especificación";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(67, 20);
            this.label37.Name = "label37";
            this.label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label37.Size = new System.Drawing.Size(59, 13);
            this.label37.TabIndex = 154;
            this.label37.Text = "Especimen";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox44
            // 
            this.textBox44.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Aplicada", true));
            this.textBox44.Location = new System.Drawing.Point(136, 264);
            this.textBox44.MaxLength = 5;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(58, 20);
            this.textBox44.TabIndex = 153;
            this.textBox44.Text = "textBox3";
            // 
            // textBox45
            // 
            this.textBox45.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Recomendad", true));
            this.textBox45.Location = new System.Drawing.Point(136, 242);
            this.textBox45.MaxLength = 5;
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(58, 20);
            this.textBox45.TabIndex = 152;
            this.textBox45.Text = "textBox3";
            // 
            // textBox46
            // 
            this.textBox46.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Viscosdad", true));
            this.textBox46.Location = new System.Drawing.Point(136, 220);
            this.textBox46.MaxLength = 5;
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(58, 20);
            this.textBox46.TabIndex = 151;
            this.textBox46.Text = "textBox46";
            // 
            // textBox47
            // 
            this.textBox47.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Penetra", true));
            this.textBox47.Location = new System.Drawing.Point(136, 198);
            this.textBox47.MaxLength = 5;
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(58, 20);
            this.textBox47.TabIndex = 150;
            this.textBox47.Text = "textBox3";
            // 
            // textBox48
            // 
            this.textBox48.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.TipoC", true));
            this.textBox48.Location = new System.Drawing.Point(136, 176);
            this.textBox48.MaxLength = 5;
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(58, 20);
            this.textBox48.TabIndex = 149;
            this.textBox48.Text = "textBox3";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(44, 268);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(80, 13);
            this.label44.TabIndex = 148;
            this.label44.Text = "Temp. de aplic:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(10, 246);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(113, 13);
            this.label45.TabIndex = 147;
            this.label45.Text = "Temp. Recomendada:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(64, 224);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(61, 13);
            this.label46.TabIndex = 146;
            this.label46.Text = "Viscosidad:";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(58, 202);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(67, 13);
            this.label47.TabIndex = 145;
            this.label47.Text = "Penetración:";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(96, 180);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(31, 13);
            this.label48.TabIndex = 144;
            this.label48.Text = "Tipo:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(156, 162);
            this.label43.Name = "label43";
            this.label43.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label43.Size = new System.Drawing.Size(39, 13);
            this.label43.TabIndex = 143;
            this.label43.Text = "Asfalto";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textBox49);
            this.groupBox5.Controls.Add(this.textBox50);
            this.groupBox5.Controls.Add(this.textBox51);
            this.groupBox5.Controls.Add(this.textBox52);
            this.groupBox5.Controls.Add(this.textBox53);
            this.groupBox5.Controls.Add(this.textBox54);
            this.groupBox5.Controls.Add(this.textBox55);
            this.groupBox5.Controls.Add(this.textBox56);
            this.groupBox5.Controls.Add(this.label49);
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Controls.Add(this.textBox15);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Location = new System.Drawing.Point(288, 214);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(486, 162);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 140;
            this.label5.Text = "Proyecto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(334, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 139;
            this.label13.Text = "% Que pasa";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox49
            // 
            this.textBox49.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PLineal", true));
            this.textBox49.Location = new System.Drawing.Point(404, 112);
            this.textBox49.MaxLength = 5;
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(58, 20);
            this.textBox49.TabIndex = 138;
            this.textBox49.Text = "textBox3";
            // 
            // textBox50
            // 
            this.textBox50.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PArena", true));
            this.textBox50.Location = new System.Drawing.Point(404, 88);
            this.textBox50.MaxLength = 5;
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(58, 20);
            this.textBox50.TabIndex = 137;
            this.textBox50.Text = "textBox50";
            // 
            // textBox51
            // 
            this.textBox51.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PPart", true));
            this.textBox51.Location = new System.Drawing.Point(404, 64);
            this.textBox51.MaxLength = 5;
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(58, 20);
            this.textBox51.TabIndex = 136;
            this.textBox51.Text = "textBox3";
            // 
            // textBox52
            // 
            this.textBox52.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PAlarga", true));
            this.textBox52.Location = new System.Drawing.Point(404, 40);
            this.textBox52.MaxLength = 5;
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(58, 20);
            this.textBox52.TabIndex = 135;
            this.textBox52.Text = "textBox3";
            // 
            // textBox53
            // 
            this.textBox53.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Lineal", true));
            this.textBox53.Location = new System.Drawing.Point(344, 112);
            this.textBox53.MaxLength = 5;
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(58, 20);
            this.textBox53.TabIndex = 134;
            this.textBox53.Text = "textBox3";
            // 
            // textBox54
            // 
            this.textBox54.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Arena", true));
            this.textBox54.Location = new System.Drawing.Point(344, 88);
            this.textBox54.MaxLength = 5;
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(58, 20);
            this.textBox54.TabIndex = 133;
            this.textBox54.Text = "textBox54";
            // 
            // textBox55
            // 
            this.textBox55.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Part", true));
            this.textBox55.Location = new System.Drawing.Point(344, 64);
            this.textBox55.MaxLength = 5;
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(58, 20);
            this.textBox55.TabIndex = 132;
            this.textBox55.Text = "textBox3";
            // 
            // textBox56
            // 
            this.textBox56.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Alarga", true));
            this.textBox56.Location = new System.Drawing.Point(344, 40);
            this.textBox56.MaxLength = 5;
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(58, 20);
            this.textBox56.TabIndex = 131;
            this.textBox56.Text = "textBox3";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(236, 114);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(94, 13);
            this.label49.TabIndex = 130;
            this.label49.Text = "Contracción lineal:";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(232, 88);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(96, 13);
            this.label50.TabIndex = 129;
            this.label50.Text = "Equiv. de arena %:";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(288, 64);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(43, 13);
            this.label51.TabIndex = 128;
            this.label51.Text = "Part. %:";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(248, 40);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(81, 13);
            this.label52.TabIndex = 127;
            this.label52.Text = "Part. alargadas:";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(172, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 112;
            this.label26.Text = "Proyecto";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "% Que pasa";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PTritura", true));
            this.textBox11.Location = new System.Drawing.Point(170, 136);
            this.textBox11.MaxLength = 5;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(58, 20);
            this.textBox11.TabIndex = 110;
            this.textBox11.Text = "textBox3";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PDesgaste", true));
            this.textBox12.Location = new System.Drawing.Point(170, 112);
            this.textBox12.MaxLength = 5;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(58, 20);
            this.textBox12.TabIndex = 109;
            this.textBox12.Text = "textBox3";
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PAbsor", true));
            this.textBox13.Location = new System.Drawing.Point(170, 88);
            this.textBox13.MaxLength = 5;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(58, 20);
            this.textBox13.TabIndex = 108;
            this.textBox13.Text = "textBox13";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PMLP", true));
            this.textBox14.Location = new System.Drawing.Point(170, 64);
            this.textBox14.MaxLength = 5;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(58, 20);
            this.textBox14.TabIndex = 107;
            this.textBox14.Text = "textBox3";
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.PMSeca", true));
            this.textBox15.Location = new System.Drawing.Point(170, 40);
            this.textBox15.MaxLength = 5;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(58, 20);
            this.textBox15.TabIndex = 106;
            this.textBox15.Text = "textBox3";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Tritura", true));
            this.textBox1.Location = new System.Drawing.Point(110, 136);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 105;
            this.textBox1.Text = "textBox3";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Desgaste", true));
            this.textBox2.Location = new System.Drawing.Point(110, 112);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 104;
            this.textBox2.Text = "textBox3";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Absor", true));
            this.textBox3.Location = new System.Drawing.Point(110, 88);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 20);
            this.textBox3.TabIndex = 103;
            this.textBox3.Text = "textBox3";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.MLP", true));
            this.textBox9.Location = new System.Drawing.Point(110, 64);
            this.textBox9.MaxLength = 5;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(58, 20);
            this.textBox9.TabIndex = 102;
            this.textBox9.Text = "textBox3";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.MSeca", true));
            this.textBox10.Location = new System.Drawing.Point(110, 40);
            this.textBox10.MaxLength = 5;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(58, 20);
            this.textBox10.TabIndex = 101;
            this.textBox10.Text = "textBox3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 100;
            this.label19.Text = "% Trituración:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(44, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 99;
            this.label21.Text = "Desgaste:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 98;
            this.label23.Text = "Absorción:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(68, 66);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 97;
            this.label24.Text = "M.E.:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 13);
            this.label25.TabIndex = 96;
            this.label25.Text = "M.E. Seca suelta:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.txtUsrMov);
            this.groupBox6.Controls.Add(this.label59);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(2, 376);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1002, 160);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Ubicacion", true));
            this.textBox8.Location = new System.Drawing.Point(190, 126);
            this.textBox8.MaxLength = 50;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(376, 20);
            this.textBox8.TabIndex = 66;
            this.textBox8.Text = "textBox3";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(729, 19);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 66;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Red;
            this.label59.Location = new System.Drawing.Point(668, 23);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(54, 13);
            this.label59.TabIndex = 65;
            this.label59.Text = "Usuario:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Usarse", true));
            this.textBox7.Location = new System.Drawing.Point(190, 100);
            this.textBox7.MaxLength = 50;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(376, 20);
            this.textBox7.TabIndex = 65;
            this.textBox7.Text = "textBox3";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Deposito", true));
            this.textBox6.Location = new System.Drawing.Point(190, 74);
            this.textBox6.MaxLength = 50;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(376, 20);
            this.textBox6.TabIndex = 64;
            this.textBox6.Text = "textBox3";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Tratamiento", true));
            this.textBox5.Location = new System.Drawing.Point(190, 48);
            this.textBox5.MaxLength = 50;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(376, 20);
            this.textBox5.TabIndex = 63;
            this.textBox5.Text = "textBox3";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAsfaltico1, "Asfaltico.Material", true));
            this.textBox4.Location = new System.Drawing.Point(190, 22);
            this.textBox4.MaxLength = 50;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(376, 20);
            this.textBox4.TabIndex = 62;
            this.textBox4.Text = "textBox3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(64, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 13);
            this.label18.TabIndex = 71;
            this.label18.Text = "Ubicación del Banco:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(92, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 70;
            this.label17.Text = "Para usarse en:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Clase de deposito muestreado";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "Tratamiento previo al muestreo:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Descripción del material:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // sqlDABusAsfaltico
            // 
            this.sqlDABusAsfaltico.SelectCommand = this.sqlSelectCommand2;
            this.sqlDABusAsfaltico.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Asfaltico", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Material", "Material")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT FOLIO, IdObra, ConsObra, Fmuestreo, Fensaye, Finforme, NoEco, Material FRO" +
    "M Asfaltico ORDER BY FOLIO";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // Asfaltico
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1010, 559);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.DAGeneral = this.sqlDAAsfaltico;
            this.dsGeneral = this.dsAsfaltico1;
            this.Name = "Asfaltico";
            this.NombreTabla = "Asfaltico";
            this.Text = "Asfaltico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Asfaltico_Load);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusAsfaltico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAsfaltico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Asfaltico_Load(object sender, System.EventArgs e)
		{
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
			sqlDABusAsfaltico.Fill(dsBusAsfaltico1,"Asfaltico");
			sqlDABusObra.Fill(dsBusObra1,"Obra");
			sqlDALaboratorista.Fill(dsLaboratorista1,"Laboratorista");
			sqlDAAsfaltico.Fill(dsAsfaltico1,"Asfaltico");
			
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbIdObra.SelectedIndex = -1;
			cmbNoeco.SelectedIndex = -1;
			dtpFmuestreo.Value = DateTime.Now.AddDays(1);
			dtpFmuestreo.Value = DateTime.Today; 
			dtpFinforme.Value = DateTime.Now.AddDays(1);
			dtpFinforme.Value = DateTime.Today; 
			dtpFensaye.Value = DateTime.Now.AddDays(1);
			dtpFensaye.Value = DateTime.Today; 
			dtpFrecibo.Value = DateTime.Now.AddDays(1);
			dtpFrecibo.Value = DateTime.Today; 
		}

		private void textBox8_TextChanged(object sender, System.EventArgs e)
		{
		
		}

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            txtUsrMov.Text = IdUsuario;
            base.btnGuardar_Click(sender, e);
        }

		

		

		
	}
}
