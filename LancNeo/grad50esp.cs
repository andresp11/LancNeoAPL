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
	/// Descripción breve de grad50esp.
	/// </summary>
	public class grad50esp : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Windows.Forms.Panel panel2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtNominal;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
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
		private System.Windows.Forms.Label label25;
		private System.Data.SqlClient.SqlDataAdapter sqlDAGrad50;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsAcero dsAcero1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAcero;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsGrad50Esp dsGrad50Esp1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAdGrad50Res;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.TextBox txtCortante1;
		private System.Windows.Forms.TextBox txtSeparacion;
		private System.Windows.Forms.TextBox txtAlturaCent;
		private System.Windows.Forms.TextBox txtMasa;
		private System.Windows.Forms.TextBox txtCortante2;
		public int nuevo;
		private System.Windows.Forms.TextBox txtDoblado;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private DataGridView dgGrad50Ens;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especificaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Muestra;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Diametro;
        private DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CargaFlu;
        private DataGridViewTextBoxColumn CargaMax;
        private DataGridViewTextBoxColumn EsfuerzoEla;
        private DataGridViewTextBoxColumn esfuerzoMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alargamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn separacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inclinacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobladoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cortante1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cortante2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Colada;
        private DataGridViewTextBoxColumn Remesa;
        private DataGridViewTextBoxColumn Observaciones;
        private TextBox txtUsrMov;
        private Label label28;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public grad50esp()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grad50esp));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsGrad50Esp1 = new LancNeo.dsGrad50Esp();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCortante1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeparacion = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDoblado = new System.Windows.Forms.TextBox();
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
            this.txtAlturaCent = new System.Windows.Forms.TextBox();
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
            this.txtCortante2 = new System.Windows.Forms.TextBox();
            this.sqlDAGrad50 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAcero = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAdGrad50Res = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgGrad50Ens = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargaFlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargaMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsfuerzoEla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alargamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.separacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inclinacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cortante1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cortante2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrad50Esp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrad50Ens)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 511);
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
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtGrado);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.txtCortante1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSeparacion);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txtNominal);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtDoblado);
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
            this.panel2.Controls.Add(this.txtAlturaCent);
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
            this.panel2.Controls.Add(this.txtCortante2);
            this.panel2.Location = new System.Drawing.Point(-4, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 96);
            this.panel2.TabIndex = 6;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsGrad50Esp1.Grad50Esp;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(98, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 41;
            // 
            // dsGrad50Esp1
            // 
            this.dsGrad50Esp1.DataSetName = "dsGrad50Esp";
            this.dsGrad50Esp1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsGrad50Esp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(930, 71);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 48;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(869, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 13);
            this.label28.TabIndex = 47;
            this.label28.Text = "Usuario:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(748, 10);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "cm²";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(182, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "(mm)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrado
            // 
            this.txtGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Grado", true));
            this.txtGrado.Location = new System.Drawing.Point(466, 24);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(60, 20);
            this.txtGrado.TabIndex = 6;
            this.txtGrado.Text = "textBox11";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(432, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 13);
            this.label27.TabIndex = 44;
            this.label27.Text = "Grado:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCortante1
            // 
            this.txtCortante1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Cortante1", true));
            this.txtCortante1.Location = new System.Drawing.Point(680, 72);
            this.txtCortante1.Name = "txtCortante1";
            this.txtCortante1.Size = new System.Drawing.Size(60, 20);
            this.txtCortante1.TabIndex = 33;
            this.txtCortante1.Text = "textBox11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cortante1:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSeparacion
            // 
            this.txtSeparacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Separacion", true));
            this.txtSeparacion.Location = new System.Drawing.Point(164, 72);
            this.txtSeparacion.Name = "txtSeparacion";
            this.txtSeparacion.Size = new System.Drawing.Size(56, 20);
            this.txtSeparacion.TabIndex = 16;
            this.txtSeparacion.Text = "textBox1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(106, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Separación:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNominal
            // 
            this.txtNominal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Area", true));
            this.txtNominal.Location = new System.Drawing.Point(726, 24);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(64, 20);
            this.txtNominal.TabIndex = 10;
            this.txtNominal.Text = "textBox3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(648, 26);
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
            this.label22.Location = new System.Drawing.Point(194, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Especificación";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDoblado
            // 
            this.txtDoblado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Doblado", true));
            this.txtDoblado.Location = new System.Drawing.Point(566, 72);
            this.txtDoblado.Name = "txtDoblado";
            this.txtDoblado.Size = new System.Drawing.Size(60, 20);
            this.txtDoblado.TabIndex = 31;
            this.txtDoblado.Text = "textBox11";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(522, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Doblado:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(482, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "(mm)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAncho
            // 
            this.txtAncho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Nominal", true));
            this.txtAncho.Location = new System.Drawing.Point(474, 72);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(44, 20);
            this.txtAncho.TabIndex = 27;
            this.txtAncho.Text = "textBox10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(432, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Nominal:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(394, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "(mm)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAltura
            // 
            this.txtAltura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Inclinacion", true));
            this.txtAltura.Location = new System.Drawing.Point(386, 72);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(42, 20);
            this.txtAltura.TabIndex = 24;
            this.txtAltura.Text = "textBox9";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(336, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Inclinación:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(296, 58);
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
            this.label13.Location = new System.Drawing.Point(74, 58);
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
            this.label12.Location = new System.Drawing.Point(938, 10);
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
            this.label11.Location = new System.Drawing.Point(838, 10);
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
            this.label10.Location = new System.Drawing.Point(604, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "(Kg/m)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlturaCent
            // 
            this.txtAlturaCent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Altura", true));
            this.txtAlturaCent.Location = new System.Drawing.Point(286, 72);
            this.txtAlturaCent.Name = "txtAlturaCent";
            this.txtAlturaCent.Size = new System.Drawing.Size(44, 20);
            this.txtAlturaCent.TabIndex = 17;
            this.txtAlturaCent.Text = "textBox8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Altura centro:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlarga
            // 
            this.txtAlarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Alargamiento", true));
            this.txtAlarga.Location = new System.Drawing.Point(70, 72);
            this.txtAlarga.Name = "txtAlarga";
            this.txtAlarga.Size = new System.Drawing.Size(32, 20);
            this.txtAlarga.TabIndex = 15;
            this.txtAlarga.Text = "textBox7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alargamiento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsMax
            // 
            this.txtEsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.EsfuerzoMax", true));
            this.txtEsMax.Location = new System.Drawing.Point(942, 24);
            this.txtEsMax.Name = "txtEsMax";
            this.txtEsMax.Size = new System.Drawing.Size(56, 20);
            this.txtEsMax.TabIndex = 13;
            this.txtEsMax.Text = "textBox6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(898, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Esfuerzo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsLE
            // 
            this.txtEsLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.EsfuerzoFlu", true));
            this.txtEsLE.Location = new System.Drawing.Point(838, 24);
            this.txtEsLE.Name = "txtEsLE";
            this.txtEsLE.Size = new System.Drawing.Size(56, 20);
            this.txtEsLE.TabIndex = 11;
            this.txtEsLE.Text = "textBox5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(792, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esfuerzo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMasa
            // 
            this.txtMasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Masa", true));
            this.txtMasa.Location = new System.Drawing.Point(596, 24);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(48, 20);
            this.txtMasa.TabIndex = 9;
            this.txtMasa.Text = "textBox4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Masa unitaria:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNumero
            // 
            this.cmbNumero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsGrad50Esp1, "Grad50Esp.Numero", true));
            this.cmbNumero.DataSource = this.dsAcero1.Acero;
            this.cmbNumero.DisplayMember = "Numero";
            this.cmbNumero.Location = new System.Drawing.Point(346, 24);
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
            this.label3.Location = new System.Drawing.Point(292, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEspec
            // 
            this.txtEspec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Especifica", true));
            this.txtEspec.Location = new System.Drawing.Point(264, 24);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(24, 20);
            this.txtEspec.TabIndex = 3;
            this.txtEspec.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Especificación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(48, 24);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(48, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
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
            this.label25.Location = new System.Drawing.Point(746, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 13);
            this.label25.TabIndex = 32;
            this.label25.Text = "Cortante2:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCortante2
            // 
            this.txtCortante2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGrad50Esp1, "Grad50Esp.Cortante2", true));
            this.txtCortante2.Location = new System.Drawing.Point(802, 72);
            this.txtCortante2.Name = "txtCortante2";
            this.txtCortante2.Size = new System.Drawing.Size(60, 20);
            this.txtCortante2.TabIndex = 34;
            this.txtCortante2.Text = "textBox11";
            this.txtCortante2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // sqlDAGrad50
            // 
            this.sqlDAGrad50.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAGrad50.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAGrad50.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAGrad50.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grad50Esp", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoFlu", "EsfuerzoFlu"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMax", "EsfuerzoMax"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("Separacion", "Separacion"),
                        new System.Data.Common.DataColumnMapping("Altura", "Altura"),
                        new System.Data.Common.DataColumnMapping("Inclinacion", "Inclinacion"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("Doblado", "Doblado"),
                        new System.Data.Common.DataColumnMapping("Cortante1", "Cortante1"),
                        new System.Data.Common.DataColumnMapping("Cortante2", "Cortante2"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAGrad50.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Numero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoFlu", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoFlu", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFlu", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFlu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMax", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Separacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Separacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Separacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Altura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Altura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Altura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Altura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Inclinacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Inclinacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Inclinacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nominal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nominal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Nominal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Doblado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cortante1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cortante1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cortante2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cortante2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.NVarChar, 0, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFlu", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFlu", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Separacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Altura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Altura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Inclinacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Nominal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Nominal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 0, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@Cortante1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Cortante2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Current, null),
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
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.NVarChar, 0, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFlu", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFlu", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Separacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Altura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Altura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Inclinacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Nominal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Nominal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 0, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@Cortante1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Cortante2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Numero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoFlu", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoFlu", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFlu", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoFlu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMax", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Separacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Separacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Separacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Altura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Altura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Altura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Altura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Inclinacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Inclinacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Inclinacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nominal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nominal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Nominal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Doblado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cortante1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cortante1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cortante2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cortante2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Original, null),
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
            // sqlDAdGrad50Res
            // 
            this.sqlDAdGrad50Res.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAdGrad50Res.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAdGrad50Res.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAdGrad50Res.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grad50Res", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Marca", "Marca"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("CargaFlu", "CargaFlu"),
                        new System.Data.Common.DataColumnMapping("CargaMax", "CargaMax"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoEla", "EsfuerzoEla"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMax", "EsfuerzoMax"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("Separacion", "Separacion"),
                        new System.Data.Common.DataColumnMapping("Altura", "Altura"),
                        new System.Data.Common.DataColumnMapping("Inclinacion", "Inclinacion"),
                        new System.Data.Common.DataColumnMapping("Doblado", "Doblado"),
                        new System.Data.Common.DataColumnMapping("Cortante1", "Cortante1"),
                        new System.Data.Common.DataColumnMapping("Cortante2", "Cortante2"),
                        new System.Data.Common.DataColumnMapping("Colada", "Colada"),
                        new System.Data.Common.DataColumnMapping("Remesa", "Remesa"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            this.sqlDAdGrad50Res.UpdateCommand = this.sqlUpdateCommand2;
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
            new System.Data.SqlClient.SqlParameter("@Original_Altura", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Altura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "CargaFlu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante1", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante2", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoEla", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoEla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Inclinacion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Separacion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "CargaFlu", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoEla", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoEla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Separacion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Altura", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Altura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Inclinacion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 15, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@Cortante1", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Cortante2", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.VarChar, 12, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.VarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones")});
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
            new System.Data.SqlClient.SqlParameter("@CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "CargaFlu", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoEla", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoEla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Separacion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Altura", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Altura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Inclinacion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 15, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@Cortante1", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Cortante2", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.VarChar, 12, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.VarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Altura", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Altura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "CargaFlu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante1", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante2", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoEla", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoEla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Inclinacion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Separacion", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Original, null)});
            // 
            // dgGrad50Ens
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgGrad50Ens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgGrad50Ens.AutoGenerateColumns = false;
            this.dgGrad50Ens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrad50Ens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.especificaDataGridViewTextBoxColumn,
            this.Muestra,
            this.Marca,
            this.Diametro,
            this.masaDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.CargaFlu,
            this.CargaMax,
            this.EsfuerzoEla,
            this.esfuerzoMaxDataGridViewTextBoxColumn,
            this.alargamientoDataGridViewTextBoxColumn,
            this.separacionDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.inclinacionDataGridViewTextBoxColumn,
            this.dobladoDataGridViewTextBoxColumn,
            this.cortante1DataGridViewTextBoxColumn,
            this.cortante2DataGridViewTextBoxColumn,
            this.Colada,
            this.Remesa,
            this.Observaciones});
            this.dgGrad50Ens.DataMember = "Grad50Esp.FK_Grad50Res_Grad50Esp";
            this.dgGrad50Ens.DataSource = this.dsGrad50Esp1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGrad50Ens.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgGrad50Ens.Location = new System.Drawing.Point(0, 168);
            this.dgGrad50Ens.Name = "dgGrad50Ens";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGrad50Ens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgGrad50Ens.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgGrad50Ens.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgGrad50Ens.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgGrad50Ens.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgGrad50Ens.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgGrad50Ens.Size = new System.Drawing.Size(1016, 336);
            this.dgGrad50Ens.TabIndex = 8;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.MaxInputLength = 0;
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            this.fOLIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fOLIODataGridViewTextBoxColumn.Visible = false;
            this.fOLIODataGridViewTextBoxColumn.Width = 5;
            // 
            // especificaDataGridViewTextBoxColumn
            // 
            this.especificaDataGridViewTextBoxColumn.DataPropertyName = "Especifica";
            this.especificaDataGridViewTextBoxColumn.HeaderText = "Especifica";
            this.especificaDataGridViewTextBoxColumn.MaxInputLength = 0;
            this.especificaDataGridViewTextBoxColumn.Name = "especificaDataGridViewTextBoxColumn";
            this.especificaDataGridViewTextBoxColumn.ReadOnly = true;
            this.especificaDataGridViewTextBoxColumn.Visible = false;
            this.especificaDataGridViewTextBoxColumn.Width = 5;
            // 
            // Muestra
            // 
            this.Muestra.DataPropertyName = "Muestra";
            this.Muestra.FillWeight = 70F;
            this.Muestra.HeaderText = "Muestra";
            this.Muestra.MaxInputLength = 5;
            this.Muestra.Name = "Muestra";
            this.Muestra.Width = 45;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MaxInputLength = 10;
            this.Marca.Name = "Marca";
            this.Marca.Width = 45;
            // 
            // Diametro
            // 
            this.Diametro.DataPropertyName = "Diametro";
            this.Diametro.HeaderText = "Diam";
            this.Diametro.MaxInputLength = 10;
            this.Diametro.Name = "Diametro";
            this.Diametro.Width = 40;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.Width = 35;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 35;
            // 
            // CargaFlu
            // 
            this.CargaFlu.DataPropertyName = "CargaFlu";
            this.CargaFlu.HeaderText = "Carga LE";
            this.CargaFlu.MaxInputLength = 8;
            this.CargaFlu.Name = "CargaFlu";
            this.CargaFlu.Width = 60;
            // 
            // CargaMax
            // 
            this.CargaMax.DataPropertyName = "CargaMax";
            this.CargaMax.HeaderText = "Carga Max";
            this.CargaMax.MaxInputLength = 8;
            this.CargaMax.Name = "CargaMax";
            this.CargaMax.Width = 60;
            // 
            // EsfuerzoEla
            // 
            this.EsfuerzoEla.DataPropertyName = "EsfuerzoEla";
            this.EsfuerzoEla.HeaderText = "Esfuerzo LE";
            this.EsfuerzoEla.MaxInputLength = 10;
            this.EsfuerzoEla.Name = "EsfuerzoEla";
            this.EsfuerzoEla.Width = 60;
            // 
            // esfuerzoMaxDataGridViewTextBoxColumn
            // 
            this.esfuerzoMaxDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn.HeaderText = "Esfuerzo Max";
            this.esfuerzoMaxDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.esfuerzoMaxDataGridViewTextBoxColumn.Name = "esfuerzoMaxDataGridViewTextBoxColumn";
            this.esfuerzoMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // alargamientoDataGridViewTextBoxColumn
            // 
            this.alargamientoDataGridViewTextBoxColumn.DataPropertyName = "Alargamiento";
            this.alargamientoDataGridViewTextBoxColumn.HeaderText = "Alarga";
            this.alargamientoDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.alargamientoDataGridViewTextBoxColumn.Name = "alargamientoDataGridViewTextBoxColumn";
            this.alargamientoDataGridViewTextBoxColumn.Width = 40;
            // 
            // separacionDataGridViewTextBoxColumn
            // 
            this.separacionDataGridViewTextBoxColumn.DataPropertyName = "Separacion";
            this.separacionDataGridViewTextBoxColumn.HeaderText = "Separa";
            this.separacionDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.separacionDataGridViewTextBoxColumn.Name = "separacionDataGridViewTextBoxColumn";
            this.separacionDataGridViewTextBoxColumn.Width = 40;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "Altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "Altura";
            this.alturaDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.Width = 40;
            // 
            // inclinacionDataGridViewTextBoxColumn
            // 
            this.inclinacionDataGridViewTextBoxColumn.DataPropertyName = "Inclinacion";
            this.inclinacionDataGridViewTextBoxColumn.HeaderText = "Inclina";
            this.inclinacionDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.inclinacionDataGridViewTextBoxColumn.Name = "inclinacionDataGridViewTextBoxColumn";
            this.inclinacionDataGridViewTextBoxColumn.Width = 40;
            // 
            // dobladoDataGridViewTextBoxColumn
            // 
            this.dobladoDataGridViewTextBoxColumn.DataPropertyName = "Doblado";
            this.dobladoDataGridViewTextBoxColumn.HeaderText = "Doblado";
            this.dobladoDataGridViewTextBoxColumn.MaxInputLength = 15;
            this.dobladoDataGridViewTextBoxColumn.Name = "dobladoDataGridViewTextBoxColumn";
            this.dobladoDataGridViewTextBoxColumn.Width = 60;
            // 
            // cortante1DataGridViewTextBoxColumn
            // 
            this.cortante1DataGridViewTextBoxColumn.DataPropertyName = "Cortante1";
            this.cortante1DataGridViewTextBoxColumn.HeaderText = "Cortante 1";
            this.cortante1DataGridViewTextBoxColumn.MaxInputLength = 10;
            this.cortante1DataGridViewTextBoxColumn.Name = "cortante1DataGridViewTextBoxColumn";
            this.cortante1DataGridViewTextBoxColumn.Width = 50;
            // 
            // cortante2DataGridViewTextBoxColumn
            // 
            this.cortante2DataGridViewTextBoxColumn.DataPropertyName = "Cortante2";
            this.cortante2DataGridViewTextBoxColumn.HeaderText = "Cortante 2";
            this.cortante2DataGridViewTextBoxColumn.MaxInputLength = 15;
            this.cortante2DataGridViewTextBoxColumn.Name = "cortante2DataGridViewTextBoxColumn";
            this.cortante2DataGridViewTextBoxColumn.Width = 50;
            // 
            // Colada
            // 
            this.Colada.DataPropertyName = "Colada";
            this.Colada.HeaderText = "Colada";
            this.Colada.MaxInputLength = 10;
            this.Colada.Name = "Colada";
            this.Colada.Width = 60;
            // 
            // Remesa
            // 
            this.Remesa.DataPropertyName = "Remesa";
            this.Remesa.HeaderText = "Remesa";
            this.Remesa.MaxInputLength = 10;
            this.Remesa.Name = "Remesa";
            this.Remesa.Width = 60;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MaxInputLength = 500;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 75;
            // 
            // grad50esp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1016, 533);
            this.Controls.Add(this.dgGrad50Ens);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAGrad50;
            this.dsGeneral = this.dsGrad50Esp1;
            this.Name = "grad50esp";
            this.NombreTabla = "grad50esp";
            this.Text = "grad50esp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.grad50esp_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgGrad50Ens, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrad50Esp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrad50Ens)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void grad50esp_Load(object sender, System.EventArgs e)
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
                base.BindingContext[dsGrad50Esp1,"Grad50Esp"].Position = this.BindingContext[dsGrad50Esp1,"Grad50Esp"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsGrad50Esp1.Tables["Grad50Res"].Clear();
			sqlDAdGrad50Res.Fill(dsGrad50Esp1,"Grad50Res");
			nuevo = 0;
		}

		public override void LoadDataSet()
		{

			//			sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			base.LoadDataSet();
			//dgGrad50Ens.SetDataBinding(dsGrad50Esp1, "Grad50Esp.Grad50");
			//string apl = dgGrad50Ens.TableStyles.ToString();
			dsGrad50Esp1.Tables["Grad50Res"].Clear();
			sqlDAdGrad50Res.Fill(dsGrad50Esp1,"Grad50Res");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsGrad50Esp objDataSetChanges = new LancNeo.dsGrad50Esp();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsGrad50Esp1,"Grad50Esp"].EndCurrentEdit();
			this.BindingContext[dsGrad50Esp1,"Grad50Res"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsGrad50Esp)(dsGrad50Esp1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsGrad50Esp1.Merge(objDataSetChanges);
					dsGrad50Esp1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsGrad50Esp ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAGrad50.Update(ChangedRows);
					sqlDAdGrad50Res.Update(ChangedRows);
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

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
		
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
				txtSeparacion.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][9].ToString();
				txtAlturaCent.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][10].ToString();
				txtAltura.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][15].ToString();
				txtAncho.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][1].ToString();
				txtCortante1.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][17].ToString();
				txtCortante2.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][18].ToString();
				txtDoblado.Text    = dsAcero1.Tables["Acero"].Rows[cmbNumero.SelectedIndex][13].ToString();
			}
		}
	}
}
