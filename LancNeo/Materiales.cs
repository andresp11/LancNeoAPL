using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
//using DataGridExtensions;
using System.Data;
using System.Data.SqlClient;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Materiales.
	/// </summary>
	public class Materiales : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMateriales;
        private LancNeo.dsMateriales dsMateriales1;
		private System.Windows.Forms.Panel panel2;
		protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtpFmuestreo;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker dtpFensaye;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
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
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbNoeco;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtObserva;
		private System.Windows.Forms.TextBox textBox11;
        private LancNeo.dsBusObra dsBusObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private LancNeo.dsLaboratorista dsLaboratorista1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusMateriales;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsBusMateriales dsBusMateriales1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMaterialesMal;
		private System.Windows.Forms.DataGrid dgMateriales;
		private System.Windows.Forms.DataGridTableStyle dgtsapl;
		private System.Windows.Forms.DataGridTextBoxColumn Folio;
		private System.Windows.Forms.DataGridTextBoxColumn Renglon;
		public System.Windows.Forms.DataGridTextBoxColumn Grava;
		private System.Windows.Forms.DataGridTextBoxColumn GravaSI;
		private System.Windows.Forms.DataGridTextBoxColumn Linea1;
		private System.Windows.Forms.DataGridTextBoxColumn Linea2;
		private System.Windows.Forms.DataGridTextBoxColumn Linea3;
		private System.Windows.Forms.DataGridTextBoxColumn Linea4;
		private System.Windows.Forms.DataGridTextBoxColumn Quepasa;
		private System.Windows.Forms.DataGridTableStyle dgtsapl1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		public System.Data.SqlClient.SqlDataAdapter sqlDAMallasM;
        private LancNeo.dsMallasM dsMallasM1;
		private System.Windows.Forms.CheckBox chbLimte;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.CheckBox chbPlastico;
		private System.Windows.Forms.CheckBox chbIndice;
		private System.Windows.Forms.CheckBox chbLineal;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.TextBox txtXMasaMaxima;
		private System.Windows.Forms.TextBox txtXMasaSuelta;
		private System.Windows.Forms.TextBox txtXAgua;
		private System.Windows.Forms.TextBox txtXSoporte;
		private System.Windows.Forms.TextBox txtXExpansion;
		private System.Windows.Forms.TextBox txtXLiquido;
		private System.Windows.Forms.TextBox txtXLineal;
		private System.Windows.Forms.TextBox txtXIndice;
		private System.Windows.Forms.TextBox txtXPlastico;
		private System.Windows.Forms.TextBox txtXMediana;
		private System.Windows.Forms.TextBox txtXGruesas;
		private System.Windows.Forms.TextBox txtXRocas;
		private System.Windows.Forms.TextBox txtXArcillas;
		private System.Windows.Forms.TextBox txtXLimos;
		private System.Windows.Forms.TextBox txtXFina;
		private System.Windows.Forms.TextBox txtXArena;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Windows.Forms.CheckBox chbXAgua;
		private System.Windows.Forms.CheckBox chbXMasaMaxima;
		private System.Windows.Forms.CheckBox chbXMasaSuelta;
		private System.Windows.Forms.CheckBox chbXLiquido;
		private System.Windows.Forms.CheckBox chbXSoporte;
		private System.Windows.Forms.CheckBox chbXExpansion;
		private System.Windows.Forms.CheckBox chbXLineal;
		private System.Windows.Forms.CheckBox chbXIndice;
		private System.Windows.Forms.CheckBox chbXGruesa;
		private System.Windows.Forms.CheckBox chbXRocas;
		private System.Windows.Forms.CheckBox chbXMediana;
		private System.Windows.Forms.CheckBox chbXLimos;
		private System.Windows.Forms.CheckBox chbXFina;
		private System.Windows.Forms.CheckBox chbXArena;
		private System.Windows.Forms.CheckBox chbXArcillas;
		private System.Windows.Forms.DataGridTextBoxColumn Especifica;
		private System.Windows.Forms.CheckBox chbXPlastico;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Materiales()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materiales));
            this.sqlDAMateriales = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsMateriales1 = new LancNeo.dsMateriales();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusMateriales1 = new LancNeo.dsBusMateriales();
            this.chbLineal = new System.Windows.Forms.CheckBox();
            this.chbIndice = new System.Windows.Forms.CheckBox();
            this.chbPlastico = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.chbLimte = new System.Windows.Forms.CheckBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFmuestreo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFensaye = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNoeco = new System.Windows.Forms.ComboBox();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusMateriales = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAMaterialesMal = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgMateriales = new System.Windows.Forms.DataGrid();
            this.dgtsapl = new System.Windows.Forms.DataGridTableStyle();
            this.Folio = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Renglon = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Grava = new System.Windows.Forms.DataGridTextBoxColumn();
            this.GravaSI = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Linea1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Linea2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Linea3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Linea4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Quepasa = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Especifica = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtsapl1 = new System.Windows.Forms.DataGridTableStyle();
            this.sqlDAMallasM = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsMallasM1 = new LancNeo.dsMallasM();
            this.txtXSoporte = new System.Windows.Forms.TextBox();
            this.txtXExpansion = new System.Windows.Forms.TextBox();
            this.txtXAgua = new System.Windows.Forms.TextBox();
            this.txtXMasaMaxima = new System.Windows.Forms.TextBox();
            this.txtXMasaSuelta = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtXLineal = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtXIndice = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtXPlastico = new System.Windows.Forms.TextBox();
            this.txtXLiquido = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtXArcillas = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtXLimos = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtXFina = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtXMediana = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtXGruesas = new System.Windows.Forms.TextBox();
            this.txtXRocas = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.txtXArena = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.chbXAgua = new System.Windows.Forms.CheckBox();
            this.chbXMasaMaxima = new System.Windows.Forms.CheckBox();
            this.chbXMasaSuelta = new System.Windows.Forms.CheckBox();
            this.chbXLiquido = new System.Windows.Forms.CheckBox();
            this.chbXSoporte = new System.Windows.Forms.CheckBox();
            this.chbXExpansion = new System.Windows.Forms.CheckBox();
            this.chbXMediana = new System.Windows.Forms.CheckBox();
            this.chbXGruesa = new System.Windows.Forms.CheckBox();
            this.chbXRocas = new System.Windows.Forms.CheckBox();
            this.chbXLineal = new System.Windows.Forms.CheckBox();
            this.chbXIndice = new System.Windows.Forms.CheckBox();
            this.chbXPlastico = new System.Windows.Forms.CheckBox();
            this.chbXArena = new System.Windows.Forms.CheckBox();
            this.chbXArcillas = new System.Windows.Forms.CheckBox();
            this.chbXLimos = new System.Windows.Forms.CheckBox();
            this.chbXFina = new System.Windows.Forms.CheckBox();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriales1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMateriales1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMallasM1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 623);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1010, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Controls.Add(this.tbBtn1);
            this.panelToolBar.Size = new System.Drawing.Size(1010, 64);
            this.panelToolBar.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnDeshacer, 0);
            this.panelToolBar.Controls.SetChildIndex(this.tbBtn1, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnAnterior, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnUltimo, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnEliminar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnVistaPrevia, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnPrimero, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnSiguiente, 0);
            // 
            // sqlDAMateriales
            // 
            this.sqlDAMateriales.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAMateriales.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAMateriales.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAMateriales.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Materiales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("Muestreadas", "Muestreadas"),
                        new System.Data.Common.DataColumnMapping("Procedencia", "Procedencia"),
                        new System.Data.Common.DataColumnMapping("Usarse", "Usarse"),
                        new System.Data.Common.DataColumnMapping("MasaSuelta", "MasaSuelta"),
                        new System.Data.Common.DataColumnMapping("MasaMaxima", "MasaMaxima"),
                        new System.Data.Common.DataColumnMapping("Agua", "Agua"),
                        new System.Data.Common.DataColumnMapping("Expansion", "Expansion"),
                        new System.Data.Common.DataColumnMapping("Soporte", "Soporte"),
                        new System.Data.Common.DataColumnMapping("Liquido", "Liquido"),
                        new System.Data.Common.DataColumnMapping("Plastico", "Plastico"),
                        new System.Data.Common.DataColumnMapping("Indice", "Indice"),
                        new System.Data.Common.DataColumnMapping("Lineal", "Lineal"),
                        new System.Data.Common.DataColumnMapping("Rocas", "Rocas"),
                        new System.Data.Common.DataColumnMapping("Gruesas", "Gruesas"),
                        new System.Data.Common.DataColumnMapping("Mediana", "Mediana"),
                        new System.Data.Common.DataColumnMapping("Fina", "Fina"),
                        new System.Data.Common.DataColumnMapping("Limas", "Limas"),
                        new System.Data.Common.DataColumnMapping("Arcillas", "Arcillas"),
                        new System.Data.Common.DataColumnMapping("Valor", "Valor"),
                        new System.Data.Common.DataColumnMapping("Arena", "Arena"),
                        new System.Data.Common.DataColumnMapping("Sucs", "Sucs"),
                        new System.Data.Common.DataColumnMapping("MasaEspecifica", "MasaEspecifica"),
                        new System.Data.Common.DataColumnMapping("Absorcion", "Absorcion"),
                        new System.Data.Common.DataColumnMapping("XMasaSuelta", "XMasaSuelta"),
                        new System.Data.Common.DataColumnMapping("XMasaMaxima", "XMasaMaxima"),
                        new System.Data.Common.DataColumnMapping("XAgua", "XAgua"),
                        new System.Data.Common.DataColumnMapping("XExpansion", "XExpansion"),
                        new System.Data.Common.DataColumnMapping("XSoporte", "XSoporte"),
                        new System.Data.Common.DataColumnMapping("XLiquido", "XLiquido"),
                        new System.Data.Common.DataColumnMapping("XPlastico", "XPlastico"),
                        new System.Data.Common.DataColumnMapping("XIndice", "XIndice"),
                        new System.Data.Common.DataColumnMapping("XLineal", "XLineal"),
                        new System.Data.Common.DataColumnMapping("XRocas", "XRocas"),
                        new System.Data.Common.DataColumnMapping("XGruesas", "XGruesas"),
                        new System.Data.Common.DataColumnMapping("XMediana", "XMediana"),
                        new System.Data.Common.DataColumnMapping("XFina", "XFina"),
                        new System.Data.Common.DataColumnMapping("XLimas", "XLimas"),
                        new System.Data.Common.DataColumnMapping("XArcillas", "XArcillas"),
                        new System.Data.Common.DataColumnMapping("XValor", "XValor"),
                        new System.Data.Common.DataColumnMapping("XArena", "XArena")})});
            this.sqlDAMateriales.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Absorcion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Absorcion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Agua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Arcillas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arcillas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Arena", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arena", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expansion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Expansion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fensaye", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fina", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Fina", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fmuestreo", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Gruesas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Gruesas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Indice", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Indice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Limas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Limas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Lineal", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Lineal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Liquido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Liquido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MasaEspecifica", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "MasaEspecifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MasaMaxima", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaMaxima", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MasaSuelta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaSuelta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Mediana", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Mediana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestreadas", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestreadas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 512, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Plastico", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Plastico", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Procedencia", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Procedencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Rocas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Rocas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Soporte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Soporte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Sucs", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sucs", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Usarse", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usarse", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Valor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Valor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XAgua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XAgua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XArcillas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XArcillas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XArena", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XArena", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XExpansion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XExpansion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XFina", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XFina", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XGruesas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XGruesas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XIndice", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XIndice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XLimas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XLimas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XLineal", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XLineal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XLiquido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "XLiquido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XMasaMaxima", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "XMasaMaxima", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XMasaSuelta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "XMasaSuelta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XMediana", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XMediana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XPlastico", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XPlastico", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XRocas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XRocas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XSoporte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XSoporte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XValor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XValor", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConnection1.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.NVarChar, 50, "Material"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 2, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@Fmuestreo", System.Data.SqlDbType.DateTime, 4, "Fmuestreo"),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.DateTime, 4, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.DateTime, 4, "Finforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 2, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 512, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Muestreadas", System.Data.SqlDbType.NVarChar, 30, "Muestreadas"),
            new System.Data.SqlClient.SqlParameter("@Procedencia", System.Data.SqlDbType.NVarChar, 50, "Procedencia"),
            new System.Data.SqlClient.SqlParameter("@Usarse", System.Data.SqlDbType.NVarChar, 50, "Usarse"),
            new System.Data.SqlClient.SqlParameter("@MasaSuelta", System.Data.SqlDbType.Int, 4, "MasaSuelta"),
            new System.Data.SqlClient.SqlParameter("@MasaMaxima", System.Data.SqlDbType.Int, 4, "MasaMaxima"),
            new System.Data.SqlClient.SqlParameter("@Agua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Agua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Expansion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Expansion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Soporte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Soporte", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Liquido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Liquido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Plastico", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Plastico", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Indice", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Indice", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Lineal", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Lineal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Rocas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Rocas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Gruesas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Gruesas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Mediana", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Mediana", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Fina", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Fina", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Limas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Limas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Arcillas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arcillas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Valor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Valor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Arena", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arena", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Sucs", System.Data.SqlDbType.NVarChar, 50, "Sucs"),
            new System.Data.SqlClient.SqlParameter("@MasaEspecifica", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "MasaEspecifica", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Absorcion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Absorcion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XMasaSuelta", System.Data.SqlDbType.Int, 4, "XMasaSuelta"),
            new System.Data.SqlClient.SqlParameter("@XMasaMaxima", System.Data.SqlDbType.Int, 4, "XMasaMaxima"),
            new System.Data.SqlClient.SqlParameter("@XAgua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XAgua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XExpansion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XExpansion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XSoporte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XSoporte", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XLiquido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "XLiquido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XPlastico", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XPlastico", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XIndice", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XIndice", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XLineal", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XLineal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XRocas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XRocas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XGruesas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XGruesas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XMediana", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XMediana", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XFina", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XFina", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XLimas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XLimas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XArcillas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XArcillas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XValor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XValor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XArena", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XArena", System.Data.DataRowVersion.Current, null)});
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
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.NVarChar, 50, "Material"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 2, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@Fmuestreo", System.Data.SqlDbType.DateTime, 4, "Fmuestreo"),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.DateTime, 4, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.DateTime, 4, "Finforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 2, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 512, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Muestreadas", System.Data.SqlDbType.NVarChar, 30, "Muestreadas"),
            new System.Data.SqlClient.SqlParameter("@Procedencia", System.Data.SqlDbType.NVarChar, 50, "Procedencia"),
            new System.Data.SqlClient.SqlParameter("@Usarse", System.Data.SqlDbType.NVarChar, 50, "Usarse"),
            new System.Data.SqlClient.SqlParameter("@MasaSuelta", System.Data.SqlDbType.Int, 4, "MasaSuelta"),
            new System.Data.SqlClient.SqlParameter("@MasaMaxima", System.Data.SqlDbType.Int, 4, "MasaMaxima"),
            new System.Data.SqlClient.SqlParameter("@Agua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Agua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Expansion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Expansion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Soporte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Soporte", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Liquido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Liquido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Plastico", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Plastico", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Indice", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Indice", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Lineal", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Lineal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Rocas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Rocas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Gruesas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Gruesas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Mediana", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Mediana", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Fina", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Fina", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Limas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Limas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Arcillas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arcillas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Valor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Valor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Arena", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arena", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Sucs", System.Data.SqlDbType.NVarChar, 50, "Sucs"),
            new System.Data.SqlClient.SqlParameter("@MasaEspecifica", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "MasaEspecifica", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Absorcion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Absorcion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XMasaSuelta", System.Data.SqlDbType.Int, 4, "XMasaSuelta"),
            new System.Data.SqlClient.SqlParameter("@XMasaMaxima", System.Data.SqlDbType.Int, 4, "XMasaMaxima"),
            new System.Data.SqlClient.SqlParameter("@XAgua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XAgua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XExpansion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XExpansion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XSoporte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XSoporte", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XLiquido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "XLiquido", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XPlastico", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XPlastico", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XIndice", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XIndice", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XLineal", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XLineal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XRocas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XRocas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XGruesas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XGruesas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XMediana", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XMediana", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XFina", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XFina", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XLimas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XLimas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XArcillas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XArcillas", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XValor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XValor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@XArena", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XArena", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Absorcion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Absorcion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Agua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Agua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Arcillas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arcillas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Arena", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Arena", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expansion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Expansion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fensaye", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fina", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Fina", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fmuestreo", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Gruesas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Gruesas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Indice", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Indice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Limas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Limas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Lineal", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Lineal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Liquido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Liquido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MasaEspecifica", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "MasaEspecifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MasaMaxima", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaMaxima", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MasaSuelta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasaSuelta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Mediana", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Mediana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestreadas", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestreadas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 512, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Plastico", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Plastico", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Procedencia", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Procedencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Rocas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Rocas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Soporte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Soporte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Sucs", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sucs", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Usarse", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usarse", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Valor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Valor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XAgua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XAgua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XArcillas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XArcillas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XArena", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XArena", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XExpansion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XExpansion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XFina", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XFina", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XGruesas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XGruesas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XIndice", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XIndice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XLimas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XLimas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XLineal", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XLineal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XLiquido", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(0)), "XLiquido", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XMasaMaxima", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "XMasaMaxima", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XMasaSuelta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "XMasaSuelta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XMediana", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XMediana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XPlastico", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XPlastico", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XRocas", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XRocas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XSoporte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XSoporte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_XValor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "XValor", System.Data.DataRowVersion.Original, null)});
            // 
            // dsMateriales1
            // 
            this.dsMateriales1.DataSetName = "dsMateriales";
            this.dsMateriales1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsMateriales1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.chbLineal);
            this.panel2.Controls.Add(this.chbIndice);
            this.panel2.Controls.Add(this.chbPlastico);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.chbLimte);
            this.panel2.Controls.Add(this.textBox23);
            this.panel2.Controls.Add(this.textBox24);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.textBox22);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.textBox20);
            this.panel2.Controls.Add(this.textBox21);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.textBox18);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.textBox19);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.textBox14);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.textBox15);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.textBox16);
            this.panel2.Controls.Add(this.textBox17);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.textBox13);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtpFmuestreo);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dtpFensaye);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSemana);
            this.panel2.Controls.Add(this.dtpFinforme);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbNoeco);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtObserva);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(8, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 202);
            this.panel2.TabIndex = 6;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.SystemColors.Control;
            this.buscaBtn1.Datos = this.dsBusMateriales1.Materiales;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(172, 10);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 21;
            // 
            // dsBusMateriales1
            // 
            this.dsBusMateriales1.DataSetName = "dsBusMateriales";
            this.dsBusMateriales1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusMateriales1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chbLineal
            // 
            this.chbLineal.Location = new System.Drawing.Point(812, 88);
            this.chbLineal.Name = "chbLineal";
            this.chbLineal.Size = new System.Drawing.Size(14, 24);
            this.chbLineal.TabIndex = 89;
            this.chbLineal.CheckedChanged += new System.EventHandler(this.chbLineal_CheckedChanged);
            // 
            // chbIndice
            // 
            this.chbIndice.Location = new System.Drawing.Point(812, 66);
            this.chbIndice.Name = "chbIndice";
            this.chbIndice.Size = new System.Drawing.Size(14, 24);
            this.chbIndice.TabIndex = 88;
            this.chbIndice.CheckedChanged += new System.EventHandler(this.chbIndice_CheckedChanged);
            // 
            // chbPlastico
            // 
            this.chbPlastico.Location = new System.Drawing.Point(812, 44);
            this.chbPlastico.Name = "chbPlastico";
            this.chbPlastico.Size = new System.Drawing.Size(14, 24);
            this.chbPlastico.TabIndex = 87;
            this.chbPlastico.CheckedChanged += new System.EventHandler(this.chbPlastico_CheckedChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(802, 4);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 13);
            this.label34.TabIndex = 86;
            this.label34.Text = "(null)";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbLimte
            // 
            this.chbLimte.Location = new System.Drawing.Point(812, 22);
            this.chbLimte.Name = "chbLimte";
            this.chbLimte.Size = new System.Drawing.Size(14, 24);
            this.chbLimte.TabIndex = 85;
            this.chbLimte.CheckedChanged += new System.EventHandler(this.chbLimte_CheckedChanged);
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Absorcion", true));
            this.textBox23.Location = new System.Drawing.Point(932, 174);
            this.textBox23.MaxLength = 5;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(58, 20);
            this.textBox23.TabIndex = 33;
            this.textBox23.Text = "textBox3";
            // 
            // textBox24
            // 
            this.textBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.MasaEspecifica", true));
            this.textBox24.Location = new System.Drawing.Point(932, 152);
            this.textBox24.MaxLength = 5;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(58, 20);
            this.textBox24.TabIndex = 32;
            this.textBox24.Text = "textBox3";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(872, 176);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 13);
            this.label32.TabIndex = 84;
            this.label32.Text = "Absorción:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(842, 154);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 13);
            this.label33.TabIndex = 83;
            this.label33.Text = "Masa especifica:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox22
            // 
            this.textBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Sucs", true));
            this.textBox22.Location = new System.Drawing.Point(666, 170);
            this.textBox22.MaxLength = 50;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(166, 20);
            this.textBox22.TabIndex = 31;
            this.textBox22.Text = "textBox3";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(734, 150);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 13);
            this.label31.TabIndex = 79;
            this.label31.Text = "SUCS";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Arena", true));
            this.textBox20.Location = new System.Drawing.Point(594, 172);
            this.textBox20.MaxLength = 5;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(58, 20);
            this.textBox20.TabIndex = 30;
            this.textBox20.Text = "textBox3";
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Valor", true));
            this.textBox21.Location = new System.Drawing.Point(594, 150);
            this.textBox21.MaxLength = 5;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(58, 20);
            this.textBox21.TabIndex = 29;
            this.textBox21.Text = "textBox3";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(476, 174);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 13);
            this.label29.TabIndex = 78;
            this.label29.Text = "Equivalente de arena:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(494, 152);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(93, 13);
            this.label30.TabIndex = 77;
            this.label30.Text = "Valor cementante:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel9.Location = new System.Drawing.Point(834, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(6, 220);
            this.panel9.TabIndex = 74;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Location = new System.Drawing.Point(10, -2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(8, 182);
            this.panel10.TabIndex = 47;
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Arcillas", true));
            this.textBox18.Location = new System.Drawing.Point(908, 112);
            this.textBox18.MaxLength = 5;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(58, 20);
            this.textBox18.TabIndex = 28;
            this.textBox18.Text = "textBox3";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(856, 114);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 13);
            this.label27.TabIndex = 72;
            this.label27.Text = "Arcillas:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Limas", true));
            this.textBox19.Location = new System.Drawing.Point(908, 90);
            this.textBox19.MaxLength = 5;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(58, 20);
            this.textBox19.TabIndex = 27;
            this.textBox19.Text = "textBox3";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(862, 92);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 13);
            this.label28.TabIndex = 70;
            this.label28.Text = "Limos:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Fina", true));
            this.textBox14.Location = new System.Drawing.Point(908, 68);
            this.textBox14.MaxLength = 5;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(58, 20);
            this.textBox14.TabIndex = 26;
            this.textBox14.Text = "textBox3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(872, 70);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 68;
            this.label23.Text = "Fina:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Mediana", true));
            this.textBox15.Location = new System.Drawing.Point(908, 46);
            this.textBox15.MaxLength = 5;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(58, 20);
            this.textBox15.TabIndex = 25;
            this.textBox15.Text = "textBox3";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(850, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 13);
            this.label24.TabIndex = 66;
            this.label24.Text = "Mediana:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Gruesas", true));
            this.textBox16.Location = new System.Drawing.Point(908, 24);
            this.textBox16.MaxLength = 5;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(58, 20);
            this.textBox16.TabIndex = 24;
            this.textBox16.Text = "textBox3";
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Rocas", true));
            this.textBox17.Location = new System.Drawing.Point(908, 2);
            this.textBox17.MaxLength = 5;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(58, 20);
            this.textBox17.TabIndex = 23;
            this.textBox17.Text = "textBox3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(856, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 65;
            this.label25.Text = "Gruesa:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(862, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 64;
            this.label26.Text = "Rocas:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Lineal", true));
            this.textBox13.Location = new System.Drawing.Point(750, 90);
            this.textBox13.MaxLength = 5;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(58, 20);
            this.textBox13.TabIndex = 22;
            this.textBox13.Text = "textBox3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(662, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "Contracc. lineal:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(656, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 220);
            this.panel5.TabIndex = 58;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(10, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 182);
            this.panel6.TabIndex = 47;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Indice", true));
            this.textBox12.Location = new System.Drawing.Point(750, 68);
            this.textBox12.MaxLength = 5;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(58, 20);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "textBox3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(668, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "Índice plástico:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Material", true));
            this.textBox11.Location = new System.Drawing.Point(330, 56);
            this.textBox11.MaxLength = 50;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(122, 20);
            this.textBox11.TabIndex = 10;
            this.textBox11.Text = "textBox11";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Plastico", true));
            this.textBox10.Location = new System.Drawing.Point(750, 46);
            this.textBox10.MaxLength = 5;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(58, 20);
            this.textBox10.TabIndex = 20;
            this.textBox10.Text = "textBox3";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Liquido", true));
            this.textBox9.Location = new System.Drawing.Point(750, 24);
            this.textBox9.MaxLength = 5;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(58, 20);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "(null)";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Soporte", true));
            this.textBox8.Location = new System.Drawing.Point(594, 90);
            this.textBox8.MaxLength = 5;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(58, 20);
            this.textBox8.TabIndex = 18;
            this.textBox8.Text = "textBox3";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Expansion", true));
            this.textBox7.Location = new System.Drawing.Point(594, 68);
            this.textBox7.MaxLength = 5;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(58, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "textBox3";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Agua", true));
            this.textBox6.Location = new System.Drawing.Point(594, 46);
            this.textBox6.MaxLength = 5;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(58, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "textBox3";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.MasaMaxima", true));
            this.textBox5.Location = new System.Drawing.Point(594, 24);
            this.textBox5.MaxLength = 5;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(58, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "textBox3";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.MasaSuelta", true));
            this.textBox4.Location = new System.Drawing.Point(594, 2);
            this.textBox4.MaxLength = 5;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(58, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "textBox3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(668, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Limite plastico:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(674, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "Limite liquido:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(478, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "Valor relativo soporte:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(530, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Expansión:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(472, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Contenido agua optimo:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(496, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Masa vol máxima:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(504, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Masa vol suelta:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(456, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 218);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(10, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 182);
            this.panel4.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Para usarse en:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFmuestreo
            // 
            this.dtpFmuestreo.CustomFormat = "dd/MM/yyyy";
            this.dtpFmuestreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Fmuestreo", true));
            this.dtpFmuestreo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFmuestreo.Location = new System.Drawing.Point(102, 104);
            this.dtpFmuestreo.Name = "dtpFmuestreo";
            this.dtpFmuestreo.Size = new System.Drawing.Size(84, 20);
            this.dtpFmuestreo.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Fecha muestreo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Usarse", true));
            this.textBox3.Location = new System.Drawing.Point(330, 80);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "textBox3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Material:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFensaye
            // 
            this.dtpFensaye.CustomFormat = "dd/MM/yyyy";
            this.dtpFensaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Fensaye", true));
            this.dtpFensaye.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFensaye.Location = new System.Drawing.Point(102, 152);
            this.dtpFensaye.Name = "dtpFensaye";
            this.dtpFensaye.Size = new System.Drawing.Size(84, 20);
            this.dtpFensaye.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fecha ensaye:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Procedencia", true));
            this.textBox2.Location = new System.Drawing.Point(330, 32);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "textBox3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Procedencia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Muestreadas", true));
            this.textBox1.Location = new System.Drawing.Point(330, 8);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "textBox3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Muestreadas:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(102, 80);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(66, 20);
            this.txtSemana.TabIndex = 4;
            this.txtSemana.Text = "textBox3";
            // 
            // dtpFinforme
            // 
            this.dtpFinforme.CustomFormat = "dd/MM/yyyy";
            this.dtpFinforme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Finforme", true));
            this.dtpFinforme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinforme.Location = new System.Drawing.Point(102, 128);
            this.dtpFinforme.Name = "dtpFinforme";
            this.dtpFinforme.Size = new System.Drawing.Size(84, 20);
            this.dtpFinforme.TabIndex = 6;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.ConsObra", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(102, 56);
            this.txtConsecutivo.MaxLength = 4;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
            this.txtConsecutivo.TabIndex = 3;
            this.txtConsecutivo.Text = "textBox2";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsMateriales1, "Materiales.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(102, 32);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 2;
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
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(102, 8);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Semana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha informe:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Consecutivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ensayado por:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNoeco
            // 
            this.cmbNoeco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsMateriales1, "Materiales.NoEco", true));
            this.cmbNoeco.DataSource = this.dsLaboratorista1;
            this.cmbNoeco.DisplayMember = "Laboratorista.Laboratorista";
            this.cmbNoeco.Location = new System.Drawing.Point(274, 104);
            this.cmbNoeco.Name = "cmbNoeco";
            this.cmbNoeco.Size = new System.Drawing.Size(178, 21);
            this.cmbNoeco.TabIndex = 12;
            this.cmbNoeco.ValueMember = "Laboratorista.NoEco";
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
            this.label10.Location = new System.Drawing.Point(188, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Observaciones:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObserva
            // 
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.Observaciones", true));
            this.txtObserva.Location = new System.Drawing.Point(274, 128);
            this.txtObserva.MaxLength = 512;
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserva.Size = new System.Drawing.Size(178, 48);
            this.txtObserva.TabIndex = 13;
            this.txtObserva.Text = "textBox5";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel7.Location = new System.Drawing.Point(458, 136);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 6);
            this.panel7.TabIndex = 61;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(760, 0);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 54;
            this.tbBtn1.Load += new System.EventHandler(this.tbBtn1_Load);
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
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
            // sqlDABusMateriales
            // 
            this.sqlDABusMateriales.SelectCommand = this.sqlSelectCommand2;
            this.sqlDABusMateriales.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Materiales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Muestreadas", "Muestreadas"),
                        new System.Data.Common.DataColumnMapping("Procedencia", "Procedencia"),
                        new System.Data.Common.DataColumnMapping("Usarse", "Usarse")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDAMaterialesMal
            // 
            this.sqlDAMaterialesMal.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAMaterialesMal.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAMaterialesMal.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAMaterialesMal.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "MaterialesMal", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Grava", "Grava"),
                        new System.Data.Common.DataColumnMapping("GravaSI", "GravaSI"),
                        new System.Data.Common.DataColumnMapping("Linea1", "Linea1"),
                        new System.Data.Common.DataColumnMapping("Linea2", "Linea2"),
                        new System.Data.Common.DataColumnMapping("Linea3", "Linea3"),
                        new System.Data.Common.DataColumnMapping("Linea4", "Linea4"),
                        new System.Data.Common.DataColumnMapping("Quepasa", "Quepasa"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica")})});
            this.sqlDAMaterialesMal.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Renglon", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Renglon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grava", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Grava", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_GravaSI", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GravaSI", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Linea1", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Linea2", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Linea3", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Linea4", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Quepasa", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Quepasa", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.VarChar, 10, "Folio"),
            new System.Data.SqlClient.SqlParameter("@Renglon", System.Data.SqlDbType.SmallInt, 2, "Renglon"),
            new System.Data.SqlClient.SqlParameter("@Grava", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Grava", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@GravaSI", System.Data.SqlDbType.VarChar, 10, "GravaSI"),
            new System.Data.SqlClient.SqlParameter("@Linea1", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea2", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea3", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea3", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea4", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea4", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Quepasa", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Quepasa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Especifica", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT Folio, Renglon, Grava, GravaSI, Linea1, Linea2, Linea3, Linea4, Quepasa, E" +
    "specifica FROM MaterialesMal WHERE (Folio = @Folio) ORDER BY Folio, Renglon DESC" +
    "";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.VarChar, 10, "Folio")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.VarChar, 10, "Folio"),
            new System.Data.SqlClient.SqlParameter("@Renglon", System.Data.SqlDbType.SmallInt, 2, "Renglon"),
            new System.Data.SqlClient.SqlParameter("@Grava", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Grava", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@GravaSI", System.Data.SqlDbType.VarChar, 10, "GravaSI"),
            new System.Data.SqlClient.SqlParameter("@Linea1", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea2", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea3", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea3", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea4", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea4", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Quepasa", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Quepasa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Especifica", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Renglon", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Renglon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grava", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Grava", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_GravaSI", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GravaSI", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Linea1", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Linea2", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Linea3", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Linea4", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Quepasa", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Quepasa", System.Data.DataRowVersion.Original, null)});
            // 
            // dgMateriales
            // 
            this.dgMateriales.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgMateriales.BackColor = System.Drawing.Color.Gainsboro;
            this.dgMateriales.BackgroundColor = System.Drawing.Color.Silver;
            this.dgMateriales.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgMateriales.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgMateriales.CaptionText = "Composición granulométrica del material";
            this.dgMateriales.DataMember = "Materiales.MaterialesMaterialesMal";
            this.dgMateriales.DataSource = this.dsMateriales1;
            this.dgMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMateriales.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgMateriales.Location = new System.Drawing.Point(14, 286);
            this.dgMateriales.Name = "dgMateriales";
            this.dgMateriales.Size = new System.Drawing.Size(736, 328);
            this.dgMateriales.TabIndex = 7;
            this.dgMateriales.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dgtsapl,
            this.dgtsapl1});
            // 
            // dgtsapl
            // 
            this.dgtsapl.DataGrid = this.dgMateriales;
            this.dgtsapl.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.Folio,
            this.Renglon,
            this.Grava,
            this.GravaSI,
            this.Linea1,
            this.Linea2,
            this.Linea3,
            this.Linea4,
            this.Quepasa,
            this.Especifica});
            this.dgtsapl.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgtsapl.MappingName = "MaterialesMal";
            // 
            // Folio
            // 
            this.Folio.Format = "";
            this.Folio.FormatInfo = null;
            this.Folio.HeaderText = "Folio";
            this.Folio.MappingName = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Width = 0;
            // 
            // Renglon
            // 
            this.Renglon.Format = "";
            this.Renglon.FormatInfo = null;
            this.Renglon.HeaderText = "Renglon";
            this.Renglon.MappingName = "Renglon";
            this.Renglon.ReadOnly = true;
            this.Renglon.Width = 75;
            // 
            // Grava
            // 
            this.Grava.Format = "";
            this.Grava.FormatInfo = null;
            this.Grava.HeaderText = "Grava";
            this.Grava.MappingName = "Grava";
            this.Grava.ReadOnly = true;
            this.Grava.Width = 75;
            // 
            // GravaSI
            // 
            this.GravaSI.Format = "";
            this.GravaSI.FormatInfo = null;
            this.GravaSI.HeaderText = "Grava SI";
            this.GravaSI.MappingName = "GravaSI";
            this.GravaSI.ReadOnly = true;
            this.GravaSI.Width = 75;
            // 
            // Linea1
            // 
            this.Linea1.Format = "";
            this.Linea1.FormatInfo = null;
            this.Linea1.HeaderText = "Linea1";
            this.Linea1.MappingName = "Linea1";
            this.Linea1.ReadOnly = true;
            this.Linea1.Width = 75;
            // 
            // Linea2
            // 
            this.Linea2.Format = "";
            this.Linea2.FormatInfo = null;
            this.Linea2.HeaderText = "Linea2";
            this.Linea2.MappingName = "Linea2";
            this.Linea2.ReadOnly = true;
            this.Linea2.Width = 75;
            // 
            // Linea3
            // 
            this.Linea3.Format = "";
            this.Linea3.FormatInfo = null;
            this.Linea3.HeaderText = "Linea3";
            this.Linea3.MappingName = "Linea3";
            this.Linea3.ReadOnly = true;
            this.Linea3.Width = 75;
            // 
            // Linea4
            // 
            this.Linea4.Format = "";
            this.Linea4.FormatInfo = null;
            this.Linea4.HeaderText = "Linea4";
            this.Linea4.MappingName = "Linea4";
            this.Linea4.ReadOnly = true;
            this.Linea4.Width = 75;
            // 
            // Quepasa
            // 
            this.Quepasa.Format = "";
            this.Quepasa.FormatInfo = null;
            this.Quepasa.HeaderText = "% Que pasa";
            this.Quepasa.MappingName = "Quepasa";
            this.Quepasa.Width = 85;
            // 
            // Especifica
            // 
            this.Especifica.Format = "";
            this.Especifica.FormatInfo = null;
            this.Especifica.HeaderText = "Especifica";
            this.Especifica.MappingName = "Especifica";
            this.Especifica.Width = 75;
            // 
            // dgtsapl1
            // 
            this.dgtsapl1.DataGrid = this.dgMateriales;
            this.dgtsapl1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // sqlDAMallasM
            // 
            this.sqlDAMallasM.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAMallasM.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "MallasM", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Grava", "Grava"),
                        new System.Data.Common.DataColumnMapping("GravaSI", "GravaSI"),
                        new System.Data.Common.DataColumnMapping("Linea1", "Linea1"),
                        new System.Data.Common.DataColumnMapping("Linea2", "Linea2"),
                        new System.Data.Common.DataColumnMapping("Linea3", "Linea3"),
                        new System.Data.Common.DataColumnMapping("Linea4", "Linea4"),
                        new System.Data.Common.DataColumnMapping("Quepasa", "Quepasa")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT Renglon, Grava, GravaSI, Linea1, Linea2, Linea3, Linea4, Quepasa FROM Mall" +
    "asM ORDER BY Renglon";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // dsMallasM1
            // 
            this.dsMallasM1.DataSetName = "dsMallasM";
            this.dsMallasM1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsMallasM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtXSoporte
            // 
            this.txtXSoporte.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XSoporte", true));
            this.txtXSoporte.Location = new System.Drawing.Point(882, 362);
            this.txtXSoporte.MaxLength = 5;
            this.txtXSoporte.Name = "txtXSoporte";
            this.txtXSoporte.Size = new System.Drawing.Size(58, 20);
            this.txtXSoporte.TabIndex = 56;
            this.txtXSoporte.Text = "textBox3";
            // 
            // txtXExpansion
            // 
            this.txtXExpansion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XExpansion", true));
            this.txtXExpansion.Location = new System.Drawing.Point(882, 342);
            this.txtXExpansion.MaxLength = 5;
            this.txtXExpansion.Name = "txtXExpansion";
            this.txtXExpansion.Size = new System.Drawing.Size(58, 20);
            this.txtXExpansion.TabIndex = 55;
            this.txtXExpansion.Text = "textBox3";
            // 
            // txtXAgua
            // 
            this.txtXAgua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XAgua", true));
            this.txtXAgua.Location = new System.Drawing.Point(882, 322);
            this.txtXAgua.MaxLength = 5;
            this.txtXAgua.Name = "txtXAgua";
            this.txtXAgua.Size = new System.Drawing.Size(58, 20);
            this.txtXAgua.TabIndex = 54;
            this.txtXAgua.Text = "textBox3";
            // 
            // txtXMasaMaxima
            // 
            this.txtXMasaMaxima.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XMasaMaxima", true));
            this.txtXMasaMaxima.Location = new System.Drawing.Point(882, 300);
            this.txtXMasaMaxima.MaxLength = 5;
            this.txtXMasaMaxima.Name = "txtXMasaMaxima";
            this.txtXMasaMaxima.Size = new System.Drawing.Size(58, 20);
            this.txtXMasaMaxima.TabIndex = 53;
            this.txtXMasaMaxima.Text = "textBox3";
            // 
            // txtXMasaSuelta
            // 
            this.txtXMasaSuelta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XMasaSuelta", true));
            this.txtXMasaSuelta.Location = new System.Drawing.Point(882, 280);
            this.txtXMasaSuelta.MaxLength = 5;
            this.txtXMasaSuelta.Name = "txtXMasaSuelta";
            this.txtXMasaSuelta.Size = new System.Drawing.Size(58, 20);
            this.txtXMasaSuelta.TabIndex = 52;
            this.txtXMasaSuelta.Text = "textBox3";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(766, 364);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(109, 13);
            this.label35.TabIndex = 61;
            this.label35.Text = "Valor relativo soporte:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(816, 342);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 13);
            this.label36.TabIndex = 60;
            this.label36.Text = "Expansión:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(756, 322);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(119, 13);
            this.label37.TabIndex = 59;
            this.label37.Text = "Contenido agua optimo:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(784, 302);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(91, 13);
            this.label38.TabIndex = 58;
            this.label38.Text = "Masa vol máxima:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(791, 284);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(84, 13);
            this.label39.TabIndex = 57;
            this.label39.Text = "Masa vol suelta:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXLineal
            // 
            this.txtXLineal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XLineal", true));
            this.txtXLineal.Location = new System.Drawing.Point(882, 446);
            this.txtXLineal.MaxLength = 5;
            this.txtXLineal.Name = "txtXLineal";
            this.txtXLineal.Size = new System.Drawing.Size(58, 20);
            this.txtXLineal.TabIndex = 65;
            this.txtXLineal.Text = "textBox3";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(792, 448);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(83, 13);
            this.label40.TabIndex = 69;
            this.label40.Text = "Contracc. lineal:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXIndice
            // 
            this.txtXIndice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XIndice", true));
            this.txtXIndice.Location = new System.Drawing.Point(882, 424);
            this.txtXIndice.MaxLength = 5;
            this.txtXIndice.Name = "txtXIndice";
            this.txtXIndice.Size = new System.Drawing.Size(58, 20);
            this.txtXIndice.TabIndex = 64;
            this.txtXIndice.Text = "textBox3";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(797, 428);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(78, 13);
            this.label41.TabIndex = 68;
            this.label41.Text = "Índice plástico:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXPlastico
            // 
            this.txtXPlastico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XPlastico", true));
            this.txtXPlastico.Location = new System.Drawing.Point(882, 402);
            this.txtXPlastico.MaxLength = 5;
            this.txtXPlastico.Name = "txtXPlastico";
            this.txtXPlastico.Size = new System.Drawing.Size(58, 20);
            this.txtXPlastico.TabIndex = 63;
            this.txtXPlastico.Text = "textBox3";
            // 
            // txtXLiquido
            // 
            this.txtXLiquido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XLiquido", true));
            this.txtXLiquido.Location = new System.Drawing.Point(882, 382);
            this.txtXLiquido.MaxLength = 5;
            this.txtXLiquido.Name = "txtXLiquido";
            this.txtXLiquido.Size = new System.Drawing.Size(58, 20);
            this.txtXLiquido.TabIndex = 62;
            this.txtXLiquido.Text = "(null)";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(799, 408);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(76, 13);
            this.label42.TabIndex = 67;
            this.label42.Text = "Limite plastico:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(805, 386);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(70, 13);
            this.label43.TabIndex = 66;
            this.label43.Text = "Limite liquido:";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXArcillas
            // 
            this.txtXArcillas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XArcillas", true));
            this.txtXArcillas.Location = new System.Drawing.Point(882, 578);
            this.txtXArcillas.MaxLength = 5;
            this.txtXArcillas.Name = "txtXArcillas";
            this.txtXArcillas.Size = new System.Drawing.Size(58, 20);
            this.txtXArcillas.TabIndex = 95;
            this.txtXArcillas.Text = "textBox3";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(832, 580);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(43, 13);
            this.label44.TabIndex = 101;
            this.label44.Text = "Arcillas:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXLimos
            // 
            this.txtXLimos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XLimas", true));
            this.txtXLimos.Location = new System.Drawing.Point(882, 556);
            this.txtXLimos.MaxLength = 5;
            this.txtXLimos.Name = "txtXLimos";
            this.txtXLimos.Size = new System.Drawing.Size(58, 20);
            this.txtXLimos.TabIndex = 94;
            this.txtXLimos.Text = "textBox3";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(838, 558);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(37, 13);
            this.label45.TabIndex = 100;
            this.label45.Text = "Limos:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXFina
            // 
            this.txtXFina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XFina", true));
            this.txtXFina.Location = new System.Drawing.Point(882, 534);
            this.txtXFina.MaxLength = 5;
            this.txtXFina.Name = "txtXFina";
            this.txtXFina.Size = new System.Drawing.Size(58, 20);
            this.txtXFina.TabIndex = 93;
            this.txtXFina.Text = "textBox3";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(845, 536);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(30, 13);
            this.label46.TabIndex = 99;
            this.label46.Text = "Fina:";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXMediana
            // 
            this.txtXMediana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XMediana", true));
            this.txtXMediana.Location = new System.Drawing.Point(882, 512);
            this.txtXMediana.MaxLength = 5;
            this.txtXMediana.Name = "txtXMediana";
            this.txtXMediana.Size = new System.Drawing.Size(58, 20);
            this.txtXMediana.TabIndex = 92;
            this.txtXMediana.Text = "textBox3";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(824, 514);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(51, 13);
            this.label47.TabIndex = 98;
            this.label47.Text = "Mediana:";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXGruesas
            // 
            this.txtXGruesas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XGruesas", true));
            this.txtXGruesas.Location = new System.Drawing.Point(882, 490);
            this.txtXGruesas.MaxLength = 5;
            this.txtXGruesas.Name = "txtXGruesas";
            this.txtXGruesas.Size = new System.Drawing.Size(58, 20);
            this.txtXGruesas.TabIndex = 91;
            this.txtXGruesas.Text = "textBox3";
            // 
            // txtXRocas
            // 
            this.txtXRocas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XRocas", true));
            this.txtXRocas.Location = new System.Drawing.Point(882, 468);
            this.txtXRocas.MaxLength = 5;
            this.txtXRocas.Name = "txtXRocas";
            this.txtXRocas.Size = new System.Drawing.Size(58, 20);
            this.txtXRocas.TabIndex = 90;
            this.txtXRocas.Text = "textBox3";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(831, 492);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(44, 13);
            this.label48.TabIndex = 97;
            this.label48.Text = "Gruesa:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(834, 472);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 13);
            this.label49.TabIndex = 96;
            this.label49.Text = "Rocas:";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXArena
            // 
            this.txtXArena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsMateriales1, "Materiales.XArena", true));
            this.txtXArena.Location = new System.Drawing.Point(882, 598);
            this.txtXArena.MaxLength = 5;
            this.txtXArena.Name = "txtXArena";
            this.txtXArena.Size = new System.Drawing.Size(58, 20);
            this.txtXArena.TabIndex = 90;
            this.txtXArena.Text = "textBox3";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(764, 600);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(111, 13);
            this.label50.TabIndex = 91;
            this.label50.Text = "Equivalente de arena:";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbXAgua
            // 
            this.chbXAgua.Location = new System.Drawing.Point(946, 320);
            this.chbXAgua.Name = "chbXAgua";
            this.chbXAgua.Size = new System.Drawing.Size(14, 24);
            this.chbXAgua.TabIndex = 105;
            this.chbXAgua.CheckedChanged += new System.EventHandler(this.chbXAgua_CheckedChanged);
            // 
            // chbXMasaMaxima
            // 
            this.chbXMasaMaxima.Location = new System.Drawing.Point(946, 298);
            this.chbXMasaMaxima.Name = "chbXMasaMaxima";
            this.chbXMasaMaxima.Size = new System.Drawing.Size(14, 24);
            this.chbXMasaMaxima.TabIndex = 104;
            this.chbXMasaMaxima.CheckedChanged += new System.EventHandler(this.chbXMasaMaxima_CheckedChanged);
            // 
            // chbXMasaSuelta
            // 
            this.chbXMasaSuelta.Location = new System.Drawing.Point(946, 278);
            this.chbXMasaSuelta.Name = "chbXMasaSuelta";
            this.chbXMasaSuelta.Size = new System.Drawing.Size(14, 24);
            this.chbXMasaSuelta.TabIndex = 103;
            this.chbXMasaSuelta.CheckedChanged += new System.EventHandler(this.chbXMasaSuelta_CheckedChanged);
            // 
            // chbXLiquido
            // 
            this.chbXLiquido.Location = new System.Drawing.Point(946, 380);
            this.chbXLiquido.Name = "chbXLiquido";
            this.chbXLiquido.Size = new System.Drawing.Size(14, 24);
            this.chbXLiquido.TabIndex = 108;
            this.chbXLiquido.CheckedChanged += new System.EventHandler(this.chbXLiquido_CheckedChanged);
            // 
            // chbXSoporte
            // 
            this.chbXSoporte.Location = new System.Drawing.Point(946, 360);
            this.chbXSoporte.Name = "chbXSoporte";
            this.chbXSoporte.Size = new System.Drawing.Size(14, 24);
            this.chbXSoporte.TabIndex = 107;
            this.chbXSoporte.CheckedChanged += new System.EventHandler(this.chbXSoporte_CheckedChanged);
            // 
            // chbXExpansion
            // 
            this.chbXExpansion.Location = new System.Drawing.Point(946, 340);
            this.chbXExpansion.Name = "chbXExpansion";
            this.chbXExpansion.Size = new System.Drawing.Size(14, 24);
            this.chbXExpansion.TabIndex = 106;
            this.chbXExpansion.CheckedChanged += new System.EventHandler(this.chbXExpansion_CheckedChanged);
            // 
            // chbXMediana
            // 
            this.chbXMediana.Location = new System.Drawing.Point(946, 512);
            this.chbXMediana.Name = "chbXMediana";
            this.chbXMediana.Size = new System.Drawing.Size(14, 24);
            this.chbXMediana.TabIndex = 114;
            this.chbXMediana.CheckedChanged += new System.EventHandler(this.chbXMediana_CheckedChanged);
            // 
            // chbXGruesa
            // 
            this.chbXGruesa.Location = new System.Drawing.Point(946, 490);
            this.chbXGruesa.Name = "chbXGruesa";
            this.chbXGruesa.Size = new System.Drawing.Size(14, 24);
            this.chbXGruesa.TabIndex = 113;
            this.chbXGruesa.CheckedChanged += new System.EventHandler(this.chbXGruesa_CheckedChanged);
            // 
            // chbXRocas
            // 
            this.chbXRocas.Location = new System.Drawing.Point(946, 468);
            this.chbXRocas.Name = "chbXRocas";
            this.chbXRocas.Size = new System.Drawing.Size(14, 24);
            this.chbXRocas.TabIndex = 112;
            this.chbXRocas.CheckedChanged += new System.EventHandler(this.chbXRocas_CheckedChanged);
            // 
            // chbXLineal
            // 
            this.chbXLineal.Location = new System.Drawing.Point(946, 446);
            this.chbXLineal.Name = "chbXLineal";
            this.chbXLineal.Size = new System.Drawing.Size(14, 24);
            this.chbXLineal.TabIndex = 111;
            this.chbXLineal.CheckedChanged += new System.EventHandler(this.chbXLineal_CheckedChanged);
            // 
            // chbXIndice
            // 
            this.chbXIndice.Location = new System.Drawing.Point(946, 424);
            this.chbXIndice.Name = "chbXIndice";
            this.chbXIndice.Size = new System.Drawing.Size(14, 24);
            this.chbXIndice.TabIndex = 110;
            this.chbXIndice.CheckedChanged += new System.EventHandler(this.chbXIndice_CheckedChanged);
            // 
            // chbXPlastico
            // 
            this.chbXPlastico.Location = new System.Drawing.Point(946, 402);
            this.chbXPlastico.Name = "chbXPlastico";
            this.chbXPlastico.Size = new System.Drawing.Size(14, 24);
            this.chbXPlastico.TabIndex = 109;
            this.chbXPlastico.CheckedChanged += new System.EventHandler(this.chbXPlastico_CheckedChanged);
            // 
            // chbXArena
            // 
            this.chbXArena.Location = new System.Drawing.Point(946, 598);
            this.chbXArena.Name = "chbXArena";
            this.chbXArena.Size = new System.Drawing.Size(14, 24);
            this.chbXArena.TabIndex = 118;
            this.chbXArena.CheckedChanged += new System.EventHandler(this.chbXArena_CheckedChanged);
            // 
            // chbXArcillas
            // 
            this.chbXArcillas.Location = new System.Drawing.Point(946, 576);
            this.chbXArcillas.Name = "chbXArcillas";
            this.chbXArcillas.Size = new System.Drawing.Size(14, 24);
            this.chbXArcillas.TabIndex = 117;
            this.chbXArcillas.CheckedChanged += new System.EventHandler(this.chbXArcillas_CheckedChanged);
            // 
            // chbXLimos
            // 
            this.chbXLimos.Location = new System.Drawing.Point(946, 554);
            this.chbXLimos.Name = "chbXLimos";
            this.chbXLimos.Size = new System.Drawing.Size(14, 24);
            this.chbXLimos.TabIndex = 116;
            this.chbXLimos.CheckedChanged += new System.EventHandler(this.chbXLimos_CheckedChanged);
            // 
            // chbXFina
            // 
            this.chbXFina.Location = new System.Drawing.Point(946, 532);
            this.chbXFina.Name = "chbXFina";
            this.chbXFina.Size = new System.Drawing.Size(14, 24);
            this.chbXFina.TabIndex = 115;
            this.chbXFina.CheckedChanged += new System.EventHandler(this.chbXFina_CheckedChanged);
            // 
            // Materiales
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1010, 645);
            this.Controls.Add(this.chbXArena);
            this.Controls.Add(this.chbXArcillas);
            this.Controls.Add(this.chbXLimos);
            this.Controls.Add(this.chbXFina);
            this.Controls.Add(this.chbXMediana);
            this.Controls.Add(this.chbXGruesa);
            this.Controls.Add(this.chbXRocas);
            this.Controls.Add(this.chbXLineal);
            this.Controls.Add(this.chbXIndice);
            this.Controls.Add(this.chbXPlastico);
            this.Controls.Add(this.chbXLiquido);
            this.Controls.Add(this.chbXSoporte);
            this.Controls.Add(this.chbXExpansion);
            this.Controls.Add(this.chbXAgua);
            this.Controls.Add(this.chbXMasaMaxima);
            this.Controls.Add(this.chbXMasaSuelta);
            this.Controls.Add(this.txtXLineal);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.txtXIndice);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.txtXPlastico);
            this.Controls.Add(this.txtXLiquido);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.txtXSoporte);
            this.Controls.Add(this.txtXExpansion);
            this.Controls.Add(this.txtXAgua);
            this.Controls.Add(this.txtXMasaMaxima);
            this.Controls.Add(this.txtXMasaSuelta);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.dgMateriales);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtXLimos);
            this.Controls.Add(this.txtXArcillas);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.txtXFina);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.txtXMediana);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.txtXGruesas);
            this.Controls.Add(this.txtXRocas);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.txtXArena);
            this.DAGeneral = this.sqlDAMateriales;
            this.dsGeneral = this.dsMateriales1;
            this.Name = "Materiales";
            this.NombreTabla = "Materiales";
            this.Text = "Materiales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Materiales_Load);
            this.Controls.SetChildIndex(this.txtXArena, 0);
            this.Controls.SetChildIndex(this.label50, 0);
            this.Controls.SetChildIndex(this.label49, 0);
            this.Controls.SetChildIndex(this.label48, 0);
            this.Controls.SetChildIndex(this.txtXRocas, 0);
            this.Controls.SetChildIndex(this.txtXGruesas, 0);
            this.Controls.SetChildIndex(this.label47, 0);
            this.Controls.SetChildIndex(this.txtXMediana, 0);
            this.Controls.SetChildIndex(this.label46, 0);
            this.Controls.SetChildIndex(this.txtXFina, 0);
            this.Controls.SetChildIndex(this.label45, 0);
            this.Controls.SetChildIndex(this.label44, 0);
            this.Controls.SetChildIndex(this.txtXArcillas, 0);
            this.Controls.SetChildIndex(this.txtXLimos, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgMateriales, 0);
            this.Controls.SetChildIndex(this.label39, 0);
            this.Controls.SetChildIndex(this.label38, 0);
            this.Controls.SetChildIndex(this.label37, 0);
            this.Controls.SetChildIndex(this.label36, 0);
            this.Controls.SetChildIndex(this.label35, 0);
            this.Controls.SetChildIndex(this.txtXMasaSuelta, 0);
            this.Controls.SetChildIndex(this.txtXMasaMaxima, 0);
            this.Controls.SetChildIndex(this.txtXAgua, 0);
            this.Controls.SetChildIndex(this.txtXExpansion, 0);
            this.Controls.SetChildIndex(this.txtXSoporte, 0);
            this.Controls.SetChildIndex(this.label43, 0);
            this.Controls.SetChildIndex(this.label42, 0);
            this.Controls.SetChildIndex(this.txtXLiquido, 0);
            this.Controls.SetChildIndex(this.txtXPlastico, 0);
            this.Controls.SetChildIndex(this.label41, 0);
            this.Controls.SetChildIndex(this.txtXIndice, 0);
            this.Controls.SetChildIndex(this.label40, 0);
            this.Controls.SetChildIndex(this.txtXLineal, 0);
            this.Controls.SetChildIndex(this.chbXMasaSuelta, 0);
            this.Controls.SetChildIndex(this.chbXMasaMaxima, 0);
            this.Controls.SetChildIndex(this.chbXAgua, 0);
            this.Controls.SetChildIndex(this.chbXExpansion, 0);
            this.Controls.SetChildIndex(this.chbXSoporte, 0);
            this.Controls.SetChildIndex(this.chbXLiquido, 0);
            this.Controls.SetChildIndex(this.chbXPlastico, 0);
            this.Controls.SetChildIndex(this.chbXIndice, 0);
            this.Controls.SetChildIndex(this.chbXLineal, 0);
            this.Controls.SetChildIndex(this.chbXRocas, 0);
            this.Controls.SetChildIndex(this.chbXGruesa, 0);
            this.Controls.SetChildIndex(this.chbXMediana, 0);
            this.Controls.SetChildIndex(this.chbXFina, 0);
            this.Controls.SetChildIndex(this.chbXLimos, 0);
            this.Controls.SetChildIndex(this.chbXArcillas, 0);
            this.Controls.SetChildIndex(this.chbXArena, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriales1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMateriales1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMallasM1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Materiales_Load(object sender, System.EventArgs e)
		{
			buscaBtn1.Catalogo = this;
			sqlDABusMateriales.Fill(dsBusMateriales1,"Materiales");
			sqlDABusObra.Fill(dsBusObra1,"Obra");
			sqlDALaboratorista.Fill(dsLaboratorista1,"Laboratorista");
			sqlDAMaterialesMal.Fill(dsMateriales1,"MaterialesMal");
			sqlDAMallasM.Fill(dsMallasM1,"MallasM");
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
		}

		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Intente actualizar el origen de datos.
				base.BindingContext[dsMateriales1,"Materiales"].Position = this.BindingContext[dsMateriales1,"Materiales"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsBusMateriales1.Clear();
			sqlDABusMateriales.Fill(dsBusMateriales1,"Materiales");
			dsMateriales1.MaterialesMal.Clear();
			sqlDAMaterialesMal.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDAMaterialesMal.Fill(dsMateriales1,"MaterialesMal");

		}
		public override void LoadDataSet()
		{
			base.LoadDataSet();
			dgMateriales.SetDataBinding(dsMateriales1, "Materiales.MaterialesMaterialesMal");
			string apl = dgMateriales.TableStyles.ToString();
			sqlDAMaterialesMal.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDAMaterialesMal.Fill(dsMateriales1,"MaterialesMal");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            LancNeo.dsMateriales objDataSetChanges = new LancNeo.dsMateriales();
			// Detener las ediciones actuales.
			this.BindingContext[dsMateriales1,"Materiales"].EndCurrentEdit();
			this.BindingContext[dsMateriales1,"MaterialesMal"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
            objDataSetChanges = ((LancNeo.dsMateriales)(dsMateriales1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsMateriales1.Merge(objDataSetChanges);
					dsMateriales1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsMateriales ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAMateriales.Update(ChangedRows);
					sqlDAMaterialesMal.Update(ChangedRows);
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

		private void tbBtn1_Click(object sender, System.EventArgs e)
		{
			int renglones = int.Parse(dgMateriales.VisibleRowCount.ToString());
			if (renglones <= 1)
			{
				DataColumn[] Llave = new DataColumn[2]; 

				try 
				{
					for (int i = 0; i < 13; i++)
					{
						Object[] Matriz = new Object[10]; 
						Llave[0] = dsMateriales1.Tables["MaterialesMal"].Columns["Folio"];
						Llave[1] = dsMateriales1.Tables["MaterialesMal"].Columns["Renglon"];
						Matriz[0] = txtFolio.Text;
						for (int j = 1; j <8; j++)
							if (dsMallasM1.Tables[0].Rows[i][j-1].ToString() != "0")
								Matriz[j] = dsMallasM1.Tables[0].Rows[i][j-1].ToString();
						dsMateriales1.Tables["MaterialesMal"].BeginLoadData();
						dsMateriales1.Tables["MaterialesMal"].LoadDataRow(Matriz,	false); 
						dsMateriales1.Tables["MaterialesMal"].EndLoadData();
					}
				}
				catch(Exception e1) 
				{
					MessageBox.Show(e1.ToString());
				}
				finally 
				{
				}
				dgMateriales.Show();
				dgMateriales.Refresh();
			}
		}

		private void txtFolio_TextChanged(object sender, System.EventArgs e)
		{
			dsMateriales1.MaterialesMal.Clear();
			sqlDAMaterialesMal.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDAMaterialesMal.Fill(dsMateriales1,"MaterialesMal");
		
		}

		private void chbLimte_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbLimte.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg][18] = DBNull.Value;
				chbLimte.Checked = false;
			}

		}

		private void chbPlastico_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbPlastico.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg][19] = DBNull.Value;
				chbPlastico.Checked = false;
			}
		}

		private void chbIndice_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbIndice.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg][20] = DBNull.Value;
				chbIndice.Checked = false;
			}

		}

		private void chbLineal_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbLineal.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg][21] = DBNull.Value;
				chbLineal.Checked = false;
			}

		}

		private void tbBtn1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void chbXMasaSuelta_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXMasaSuelta.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XMasaSuelta"] = DBNull.Value;
				chbXMasaSuelta.Checked = false;
			}
		}

		private void chbXMasaMaxima_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXMasaMaxima.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XMasaMaxima"] = DBNull.Value;
				chbXMasaMaxima.Checked = false;
			}
		}

		private void chbXAgua_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXAgua.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XAgua"] = DBNull.Value;
				chbXAgua.Checked = false;
			}
		}

		private void chbXExpansion_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXExpansion.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XExpansion"] = DBNull.Value;
				chbXExpansion.Checked = false;
			}
		}

		private void chbXSoporte_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXSoporte.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XSoporte"] = DBNull.Value;
				chbXSoporte.Checked = false;
			}
		}

		private void chbXLiquido_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXLiquido.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XLiquido"] = DBNull.Value;
				chbXLiquido.Checked = false;
			}
		}

		private void chbXPlastico_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXPlastico.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XPlastico"] = DBNull.Value;
				chbXPlastico.Checked = false;
			}
		}

		private void chbXIndice_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXIndice.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XIndice"] = DBNull.Value;
				chbXIndice.Checked = false;
			}
		}

		private void chbXLineal_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXLineal.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XLineal"] = DBNull.Value;
				chbXLineal.Checked = false;
			}
		}

		private void chbXRocas_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXRocas.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XRocas"] = DBNull.Value;
				chbXRocas.Checked = false;
			}
		}

		private void chbXGruesa_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXGruesa.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XGruesa"] = DBNull.Value;
				chbXGruesa.Checked = false;
			}
		}

		private void chbXMediana_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXMediana.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XMediana"] = DBNull.Value;
				chbXMediana.Checked = false;
			}
		}

		private void chbXFina_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXFina.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XFina"] = DBNull.Value;
				chbXFina.Checked = false;
			}
		}

		private void chbXLimos_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXLimos.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XLimas"] = DBNull.Value;
				chbXLimos.Checked = false;
			}
		}

		private void chbXArcillas_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXArcillas.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XArcillas"] = DBNull.Value;
				chbXArcillas.Checked = false;
			}
		}

		private void chbXArena_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbXArena.Checked)
			{
				int reg = this.BindingContext[dsMateriales1,"Materiales"].Position;
				dsMateriales1.Tables["Materiales"].Rows[reg]["XArena"] = DBNull.Value;
				chbXArena.Checked = false;
			}
		}

		

		

		

		
		

		


	}
}
