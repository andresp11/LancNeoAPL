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
	/// Descripción breve de Gra60Esp.
	/// </summary>
	public class Gra60Esp : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Windows.Forms.Panel panel2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtNominal;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtDoblado;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtInlcina;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtAncho;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtSepara;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtAlarga;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEsMax;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEsLE;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbNumero;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEspec;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAGra60Esp;
		private LancNeo.dsGra60Esp dsGra60Esp1;
		private LancNeo.dsAcero dsAcero1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAcero;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDAGra60Res;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		public int nuevo;
		private System.Windows.Forms.TextBox txtCorrugado;
		private System.Windows.Forms.TextBox txtMasa;
		private System.Windows.Forms.TextBox txtAngulo;
		private System.Windows.Forms.TextBox txtSuma;
		private System.Windows.Forms.TextBox txtEspaciamiento;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private DataGridView dgGra60Ens;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especificaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diametroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaFluDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoFLUDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoMAXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alargamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn espaciamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn altMinCenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn altaMinCuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anchoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costillaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anguloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coeficienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobladoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coladaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private TextBox txtUsrMov;
        private Label label28;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Gra60Esp()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gra60Esp));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsGra60Esp1 = new LancNeo.dsGra60Esp();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCorrugado = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspaciamiento = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDoblado = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtInlcina = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSepara = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAlarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEsMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEsLE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.dsAcero1 = new LancNeo.dsAcero();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.sqlDAGra60Esp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAcero = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAGra60Res = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgGra60Ens = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diametroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaFluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoFLUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoMAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alargamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espaciamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altMinCenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altaMinCuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anchoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costillaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anguloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coeficienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGra60Esp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGra60Ens)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 553);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1016, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1016, 64);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.txtGrado);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.txtCorrugado);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.txtSuma);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEspaciamiento);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txtNominal);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtDoblado);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtInlcina);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtAncho);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtAltura);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSepara);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtAlarga);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEsMax);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEsLE);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMasa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbNumero);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEspec);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.txtAngulo);
            this.panel2.Location = new System.Drawing.Point(-4, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 96);
            this.panel2.TabIndex = 5;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsGra60Esp1.Gra60Esp;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(98, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 41;
            this.buscaBtn1.Load += new System.EventHandler(this.buscaBtn1_Load);
            // 
            // dsGra60Esp1
            // 
            this.dsGra60Esp1.DataSetName = "dsGra60Esp";
            this.dsGra60Esp1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsGra60Esp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(722, 36);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 46;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(661, 40);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 13);
            this.label28.TabIndex = 45;
            this.label28.Text = "Usuario:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrado
            // 
            this.txtGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Grado", true));
            this.txtGrado.Location = new System.Drawing.Point(346, 36);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(60, 20);
            this.txtGrado.TabIndex = 6;
            this.txtGrado.Text = "textBox11";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(312, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 13);
            this.label27.TabIndex = 44;
            this.label27.Text = "Grado:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCorrugado
            // 
            this.txtCorrugado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Coeficiente", true));
            this.txtCorrugado.Location = new System.Drawing.Point(800, 70);
            this.txtCorrugado.Name = "txtCorrugado";
            this.txtCorrugado.Size = new System.Drawing.Size(60, 20);
            this.txtCorrugado.TabIndex = 37;
            this.txtCorrugado.Text = "textBox11";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(746, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 13);
            this.label26.TabIndex = 42;
            this.label26.Text = "Corrugado:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSuma
            // 
            this.txtSuma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Suma", true));
            this.txtSuma.Location = new System.Drawing.Point(580, 70);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(60, 20);
            this.txtSuma.TabIndex = 33;
            this.txtSuma.Text = "textBox11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Suma:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEspaciamiento
            // 
            this.txtEspaciamiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Espaciamiento", true));
            this.txtEspaciamiento.Location = new System.Drawing.Point(72, 70);
            this.txtEspaciamiento.Name = "txtEspaciamiento";
            this.txtEspaciamiento.Size = new System.Drawing.Size(56, 20);
            this.txtEspaciamiento.TabIndex = 16;
            this.txtEspaciamiento.Text = "textBox1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(4, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Espaciamiento";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNominal
            // 
            this.txtNominal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Area", true));
            this.txtNominal.Location = new System.Drawing.Point(622, 14);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(64, 20);
            this.txtNominal.TabIndex = 10;
            this.txtNominal.Text = "textBox3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(544, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 36;
            this.label23.Text = "Área Nominal:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gold;
            this.label22.Location = new System.Drawing.Point(482, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Especificación";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDoblado
            // 
            this.txtDoblado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Doblado", true));
            this.txtDoblado.Location = new System.Drawing.Point(910, 70);
            this.txtDoblado.Name = "txtDoblado";
            this.txtDoblado.Size = new System.Drawing.Size(74, 20);
            this.txtDoblado.TabIndex = 40;
            this.txtDoblado.Text = "textBox1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(864, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Doblado:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInlcina
            // 
            this.txtInlcina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Costilla", true));
            this.txtInlcina.Location = new System.Drawing.Point(484, 70);
            this.txtInlcina.Name = "txtInlcina";
            this.txtInlcina.Size = new System.Drawing.Size(60, 20);
            this.txtInlcina.TabIndex = 31;
            this.txtInlcina.Text = "textBox11";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(692, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "(Grados)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(440, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Costilla:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(408, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "(mm)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAncho
            // 
            this.txtAncho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Ancho", true));
            this.txtAncho.Location = new System.Drawing.Point(390, 70);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(44, 20);
            this.txtAncho.TabIndex = 27;
            this.txtAncho.Text = "textBox10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(356, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Ancho:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(318, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "(mm)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAltura
            // 
            this.txtAltura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.AltMinCua", true));
            this.txtAltura.Location = new System.Drawing.Point(310, 70);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(42, 20);
            this.txtAltura.TabIndex = 24;
            this.txtAltura.Text = "textBox9";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(246, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Altura cuartas:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(206, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "(mm)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(970, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "(%)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(834, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = " Max (Kg/cm²)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(734, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Flu (Kg/cm²)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "(Kg/m)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSepara
            // 
            this.txtSepara.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.AltMinCen", true));
            this.txtSepara.Location = new System.Drawing.Point(196, 70);
            this.txtSepara.Name = "txtSepara";
            this.txtSepara.Size = new System.Drawing.Size(44, 20);
            this.txtSepara.TabIndex = 17;
            this.txtSepara.Text = "textBox8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Altura centro:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlarga
            // 
            this.txtAlarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Alargamiento", true));
            this.txtAlarga.Location = new System.Drawing.Point(966, 14);
            this.txtAlarga.Name = "txtAlarga";
            this.txtAlarga.Size = new System.Drawing.Size(32, 20);
            this.txtAlarga.TabIndex = 15;
            this.txtAlarga.Text = "textBox7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(902, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alargamiento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsMax
            // 
            this.txtEsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.EsfuerzoMAX", true));
            this.txtEsMax.Location = new System.Drawing.Point(838, 14);
            this.txtEsMax.Name = "txtEsMax";
            this.txtEsMax.Size = new System.Drawing.Size(56, 20);
            this.txtEsMax.TabIndex = 13;
            this.txtEsMax.Text = "textBox6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(794, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Esfuerzo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsLE
            // 
            this.txtEsLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.EsfuerzoFLU", true));
            this.txtEsLE.Location = new System.Drawing.Point(734, 14);
            this.txtEsLE.Name = "txtEsLE";
            this.txtEsLE.Size = new System.Drawing.Size(56, 20);
            this.txtEsLE.TabIndex = 11;
            this.txtEsLE.Text = "textBox5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esfuerzo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMasa
            // 
            this.txtMasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Masa", true));
            this.txtMasa.Location = new System.Drawing.Point(492, 14);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(48, 20);
            this.txtMasa.TabIndex = 9;
            this.txtMasa.Text = "textBox4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Masa unitaria:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNumero
            // 
            this.cmbNumero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsGra60Esp1, "Gra60Esp.Numero", true));
            this.cmbNumero.DataSource = this.dsAcero1.Acero;
            this.cmbNumero.DisplayMember = "Numero";
            this.cmbNumero.Location = new System.Drawing.Point(346, 14);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(80, 21);
            this.cmbNumero.TabIndex = 5;
            this.cmbNumero.ValueMember = "Numero";
            this.cmbNumero.SelectedIndexChanged += new System.EventHandler(this.cmbNumero_SelectedIndexChanged);
            // 
            // dsAcero1
            // 
            this.dsAcero1.DataSetName = "dsAcero";
            this.dsAcero1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.UseMnemonic = false;
            // 
            // txtEspec
            // 
            this.txtEspec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Especifica", true));
            this.txtEspec.Location = new System.Drawing.Point(264, 14);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(24, 20);
            this.txtEspec.TabIndex = 3;
            this.txtEspec.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Especificación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(48, 14);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(48, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(644, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 13);
            this.label25.TabIndex = 32;
            this.label25.Text = "Angulo:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAngulo
            // 
            this.txtAngulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGra60Esp1, "Gra60Esp.Angulo", true));
            this.txtAngulo.Location = new System.Drawing.Point(684, 70);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(60, 20);
            this.txtAngulo.TabIndex = 34;
            this.txtAngulo.Text = "textBox11";
            // 
            // sqlDAGra60Esp
            // 
            this.sqlDAGra60Esp.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAGra60Esp.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAGra60Esp.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAGra60Esp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Gra60Esp", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoFLU", "EsfuerzoFLU"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMAX", "EsfuerzoMAX"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("Espaciamiento", "Espaciamiento"),
                        new System.Data.Common.DataColumnMapping("AltMinCen", "AltMinCen"),
                        new System.Data.Common.DataColumnMapping("AltMinCua", "AltMinCua"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Costilla", "Costilla"),
                        new System.Data.Common.DataColumnMapping("Suma", "Suma"),
                        new System.Data.Common.DataColumnMapping("Angulo", "Angulo"),
                        new System.Data.Common.DataColumnMapping("Coeficiente", "Coeficiente"),
                        new System.Data.Common.DataColumnMapping("Doblado", "Doblado"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAGra60Esp.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Numero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoFLU", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Espaciamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Espaciamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Espaciamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espaciamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AltMinCen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AltMinCen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCen", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AltMinCua", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AltMinCua", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCua", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ancho", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ancho", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Costilla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Costilla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Costilla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Suma", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suma", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Suma", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Angulo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Angulo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Coeficiente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Coeficiente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Coeficiente", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Doblado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 0, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.Char, 0, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMAX", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Espaciamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espaciamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCen", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCua", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Costilla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Suma", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Angulo", System.Data.SqlDbType.NVarChar, 0, "Angulo"),
            new System.Data.SqlClient.SqlParameter("@Coeficiente", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 0, "Doblado"),
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
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 0, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.Char, 0, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMAX", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Espaciamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espaciamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCen", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCua", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Costilla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Suma", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Angulo", System.Data.SqlDbType.NVarChar, 0, "Angulo"),
            new System.Data.SqlClient.SqlParameter("@Coeficiente", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 0, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Numero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoFLU", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Espaciamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Espaciamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Espaciamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espaciamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AltMinCen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AltMinCen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCen", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AltMinCua", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AltMinCua", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCua", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ancho", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ancho", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Costilla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Costilla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Costilla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Suma", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suma", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Suma", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Angulo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Angulo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Coeficiente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Coeficiente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Coeficiente", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Doblado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDAAcero
            // 
            this.sqlDAAcero.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAAcero.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Acero", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("Milimetros", "Milimetros"),
                        new System.Data.Common.DataColumnMapping("Clasificacion", "Clasificacion")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDAGra60Res
            // 
            this.sqlDAGra60Res.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAGra60Res.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAGra60Res.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAGra60Res.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Gra60Res", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Marca", "Marca"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("CargaFlu", "CargaFlu"),
                        new System.Data.Common.DataColumnMapping("CargaMax", "CargaMax"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoFLU", "EsfuerzoFLU"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMAX", "EsfuerzoMAX"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("Espaciamiento", "Espaciamiento"),
                        new System.Data.Common.DataColumnMapping("AltMinCen", "AltMinCen"),
                        new System.Data.Common.DataColumnMapping("AltaMinCua", "AltaMinCua"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Costilla", "Costilla"),
                        new System.Data.Common.DataColumnMapping("Suma", "Suma"),
                        new System.Data.Common.DataColumnMapping("Angulo", "Angulo"),
                        new System.Data.Common.DataColumnMapping("Coeficiente", "Coeficiente"),
                        new System.Data.Common.DataColumnMapping("Doblado", "Doblado"),
                        new System.Data.Common.DataColumnMapping("Colada", "Colada"),
                        new System.Data.Common.DataColumnMapping("Remesa", "Remesa"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            this.sqlDAGra60Res.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCen", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AltaMinCua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltaMinCua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Angulo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFlu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Coeficiente", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Costilla", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Espaciamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espaciamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Suma", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.NVarChar, 10, "Marca"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFlu", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMAX", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Espaciamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espaciamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCen", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltaMinCua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltaMinCua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Costilla", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Suma", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Angulo", System.Data.SqlDbType.Int, 4, "Angulo"),
            new System.Data.SqlClient.SqlParameter("@Coeficiente", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 15, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.NVarChar, 12, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.NVarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 50, "Observaciones")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.NVarChar, 10, "Marca"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFlu", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMAX", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Espaciamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espaciamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCen", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltaMinCua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltaMinCua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Costilla", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Suma", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Angulo", System.Data.SqlDbType.Int, 4, "Angulo"),
            new System.Data.SqlClient.SqlParameter("@Coeficiente", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 15, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.NVarChar, 12, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.NVarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 50, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCen", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AltaMinCua", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltaMinCua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Angulo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFlu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Coeficiente", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Costilla", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Espaciamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espaciamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Suma", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Original, null)});
            // 
            // dgGra60Ens
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgGra60Ens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgGra60Ens.AutoGenerateColumns = false;
            this.dgGra60Ens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGra60Ens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.especificaDataGridViewTextBoxColumn,
            this.muestraDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.diametroDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.cargaFluDataGridViewTextBoxColumn,
            this.cargaMaxDataGridViewTextBoxColumn,
            this.esfuerzoFLUDataGridViewTextBoxColumn,
            this.esfuerzoMAXDataGridViewTextBoxColumn,
            this.alargamientoDataGridViewTextBoxColumn,
            this.espaciamientoDataGridViewTextBoxColumn,
            this.altMinCenDataGridViewTextBoxColumn,
            this.altaMinCuaDataGridViewTextBoxColumn,
            this.anchoDataGridViewTextBoxColumn,
            this.costillaDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.anguloDataGridViewTextBoxColumn,
            this.coeficienteDataGridViewTextBoxColumn,
            this.dobladoDataGridViewTextBoxColumn,
            this.coladaDataGridViewTextBoxColumn,
            this.remesaDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgGra60Ens.DataMember = "Gra60Esp.Gra60";
            this.dgGra60Ens.DataSource = this.dsGra60Esp1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGra60Ens.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgGra60Ens.Location = new System.Drawing.Point(0, 168);
            this.dgGra60Ens.Name = "dgGra60Ens";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgGra60Ens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgGra60Ens.Size = new System.Drawing.Size(1016, 379);
            this.dgGra60Ens.TabIndex = 6;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            this.fOLIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fOLIODataGridViewTextBoxColumn.Visible = false;
            // 
            // especificaDataGridViewTextBoxColumn
            // 
            this.especificaDataGridViewTextBoxColumn.DataPropertyName = "Especifica";
            this.especificaDataGridViewTextBoxColumn.HeaderText = "Especifica";
            this.especificaDataGridViewTextBoxColumn.Name = "especificaDataGridViewTextBoxColumn";
            this.especificaDataGridViewTextBoxColumn.ReadOnly = true;
            this.especificaDataGridViewTextBoxColumn.Visible = false;
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            this.muestraDataGridViewTextBoxColumn.Width = 45;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 45;
            // 
            // diametroDataGridViewTextBoxColumn
            // 
            this.diametroDataGridViewTextBoxColumn.DataPropertyName = "Diametro";
            this.diametroDataGridViewTextBoxColumn.HeaderText = "Diam";
            this.diametroDataGridViewTextBoxColumn.Name = "diametroDataGridViewTextBoxColumn";
            this.diametroDataGridViewTextBoxColumn.Width = 40;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.Width = 40;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 40;
            // 
            // cargaFluDataGridViewTextBoxColumn
            // 
            this.cargaFluDataGridViewTextBoxColumn.DataPropertyName = "CargaFlu";
            this.cargaFluDataGridViewTextBoxColumn.HeaderText = "Carga Flu";
            this.cargaFluDataGridViewTextBoxColumn.Name = "cargaFluDataGridViewTextBoxColumn";
            this.cargaFluDataGridViewTextBoxColumn.Width = 55;
            // 
            // cargaMaxDataGridViewTextBoxColumn
            // 
            this.cargaMaxDataGridViewTextBoxColumn.DataPropertyName = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn.HeaderText = "Carga Max";
            this.cargaMaxDataGridViewTextBoxColumn.Name = "cargaMaxDataGridViewTextBoxColumn";
            this.cargaMaxDataGridViewTextBoxColumn.Width = 55;
            // 
            // esfuerzoFLUDataGridViewTextBoxColumn
            // 
            this.esfuerzoFLUDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoFLU";
            this.esfuerzoFLUDataGridViewTextBoxColumn.HeaderText = "Esfuerzo FLU";
            this.esfuerzoFLUDataGridViewTextBoxColumn.Name = "esfuerzoFLUDataGridViewTextBoxColumn";
            this.esfuerzoFLUDataGridViewTextBoxColumn.Width = 55;
            // 
            // esfuerzoMAXDataGridViewTextBoxColumn
            // 
            this.esfuerzoMAXDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoMAX";
            this.esfuerzoMAXDataGridViewTextBoxColumn.HeaderText = "Esfuerzo MAX";
            this.esfuerzoMAXDataGridViewTextBoxColumn.Name = "esfuerzoMAXDataGridViewTextBoxColumn";
            this.esfuerzoMAXDataGridViewTextBoxColumn.Width = 55;
            // 
            // alargamientoDataGridViewTextBoxColumn
            // 
            this.alargamientoDataGridViewTextBoxColumn.DataPropertyName = "Alargamiento";
            this.alargamientoDataGridViewTextBoxColumn.HeaderText = "Alarga";
            this.alargamientoDataGridViewTextBoxColumn.Name = "alargamientoDataGridViewTextBoxColumn";
            this.alargamientoDataGridViewTextBoxColumn.Width = 40;
            // 
            // espaciamientoDataGridViewTextBoxColumn
            // 
            this.espaciamientoDataGridViewTextBoxColumn.DataPropertyName = "Espaciamiento";
            this.espaciamientoDataGridViewTextBoxColumn.HeaderText = "Espaciamiento";
            this.espaciamientoDataGridViewTextBoxColumn.Name = "espaciamientoDataGridViewTextBoxColumn";
            this.espaciamientoDataGridViewTextBoxColumn.Width = 60;
            // 
            // altMinCenDataGridViewTextBoxColumn
            // 
            this.altMinCenDataGridViewTextBoxColumn.DataPropertyName = "AltMinCen";
            this.altMinCenDataGridViewTextBoxColumn.HeaderText = "Alt Min Cen";
            this.altMinCenDataGridViewTextBoxColumn.Name = "altMinCenDataGridViewTextBoxColumn";
            this.altMinCenDataGridViewTextBoxColumn.Width = 45;
            // 
            // altaMinCuaDataGridViewTextBoxColumn
            // 
            this.altaMinCuaDataGridViewTextBoxColumn.DataPropertyName = "AltaMinCua";
            this.altaMinCuaDataGridViewTextBoxColumn.HeaderText = "Alt Min Cua";
            this.altaMinCuaDataGridViewTextBoxColumn.Name = "altaMinCuaDataGridViewTextBoxColumn";
            this.altaMinCuaDataGridViewTextBoxColumn.Width = 45;
            // 
            // anchoDataGridViewTextBoxColumn
            // 
            this.anchoDataGridViewTextBoxColumn.DataPropertyName = "Ancho";
            this.anchoDataGridViewTextBoxColumn.HeaderText = "Ancho";
            this.anchoDataGridViewTextBoxColumn.Name = "anchoDataGridViewTextBoxColumn";
            this.anchoDataGridViewTextBoxColumn.Width = 45;
            // 
            // costillaDataGridViewTextBoxColumn
            // 
            this.costillaDataGridViewTextBoxColumn.DataPropertyName = "Costilla";
            this.costillaDataGridViewTextBoxColumn.HeaderText = "Costilla";
            this.costillaDataGridViewTextBoxColumn.Name = "costillaDataGridViewTextBoxColumn";
            this.costillaDataGridViewTextBoxColumn.Width = 50;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.Width = 45;
            // 
            // anguloDataGridViewTextBoxColumn
            // 
            this.anguloDataGridViewTextBoxColumn.DataPropertyName = "Angulo";
            this.anguloDataGridViewTextBoxColumn.HeaderText = "Angulo";
            this.anguloDataGridViewTextBoxColumn.Name = "anguloDataGridViewTextBoxColumn";
            this.anguloDataGridViewTextBoxColumn.Width = 45;
            // 
            // coeficienteDataGridViewTextBoxColumn
            // 
            this.coeficienteDataGridViewTextBoxColumn.DataPropertyName = "Coeficiente";
            this.coeficienteDataGridViewTextBoxColumn.HeaderText = "Coeficiente";
            this.coeficienteDataGridViewTextBoxColumn.Name = "coeficienteDataGridViewTextBoxColumn";
            this.coeficienteDataGridViewTextBoxColumn.Width = 60;
            // 
            // dobladoDataGridViewTextBoxColumn
            // 
            this.dobladoDataGridViewTextBoxColumn.DataPropertyName = "Doblado";
            this.dobladoDataGridViewTextBoxColumn.HeaderText = "Doblado";
            this.dobladoDataGridViewTextBoxColumn.Name = "dobladoDataGridViewTextBoxColumn";
            this.dobladoDataGridViewTextBoxColumn.Width = 60;
            // 
            // coladaDataGridViewTextBoxColumn
            // 
            this.coladaDataGridViewTextBoxColumn.DataPropertyName = "Colada";
            this.coladaDataGridViewTextBoxColumn.HeaderText = "Colada";
            this.coladaDataGridViewTextBoxColumn.Name = "coladaDataGridViewTextBoxColumn";
            this.coladaDataGridViewTextBoxColumn.Width = 60;
            // 
            // remesaDataGridViewTextBoxColumn
            // 
            this.remesaDataGridViewTextBoxColumn.DataPropertyName = "Remesa";
            this.remesaDataGridViewTextBoxColumn.HeaderText = "Remesa";
            this.remesaDataGridViewTextBoxColumn.Name = "remesaDataGridViewTextBoxColumn";
            this.remesaDataGridViewTextBoxColumn.Width = 60;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // Gra60Esp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1016, 575);
            this.Controls.Add(this.dgGra60Ens);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAGra60Esp;
            this.dsGeneral = this.dsGra60Esp1;
            this.Name = "Gra60Esp";
            this.NombreTabla = "Gra60Esp";
            this.Text = "Gra60Esp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gra60Esp_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgGra60Ens, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGra60Esp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGra60Ens)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Gra60Esp_Load(object sender, System.EventArgs e)
		{
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
			sqlDAAcero.Fill(dsAcero1,"Acero");
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbNumero.SelectedIndex = 0;
			nuevo = 1;
		}
		
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsGra60Esp1,"Gra60Esp"].Position = this.BindingContext[dsGra60Esp1,"Gra60Esp"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsGra60Esp1.Tables["Gra60Res"].Clear();
			sqlDAGra60Res.Fill(dsGra60Esp1,"Gra60Res");
			nuevo = 0;
		}

		public override void LoadDataSet()
		{

			//			sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			base.LoadDataSet();
			//dgGra60Ens.SetDataBinding(dsGra60Esp1, "Gra60Esp.Gra60");
			//string apl = dgGra60Ens.TableStyles.ToString();
			dsGra60Esp1.Tables["Gra60Res"].Clear();
			sqlDAGra60Res.Fill(dsGra60Esp1,"Gra60Res");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsGra60Esp objDataSetChanges = new LancNeo.dsGra60Esp();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsGra60Esp1,"Gra60Esp"].EndCurrentEdit();
			this.BindingContext[dsGra60Esp1,"Gra60Res"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsGra60Esp)(dsGra60Esp1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsGra60Esp1.Merge(objDataSetChanges);
					dsGra60Esp1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsGra60Esp ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAGra60Esp.Update(ChangedRows);
					sqlDAGra60Res.Update(ChangedRows);
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

		private void cmbNumero_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (nuevo == 1)
			{
				txtGrado.Text   = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][5].ToString();
				txtNominal.Text = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][16].ToString();
				txtMasa.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][25].ToString();
				txtEsLE.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][6].ToString();
				txtEsMax.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][7].ToString();
				txtAlarga.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][8].ToString();
				txtEspaciamiento.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][9].ToString();
				txtSepara.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][19].ToString();
				txtAltura.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][20].ToString();
				txtAncho.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][11].ToString();
				txtInlcina.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][21].ToString();
				txtSuma.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][22].ToString();
				txtAngulo.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][23].ToString();
				txtCorrugado.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][24].ToString();
				txtDoblado.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][13].ToString();
			}
		}

        private void buscaBtn1_Load(object sender, EventArgs e)
        {

        }
		
	}

}
