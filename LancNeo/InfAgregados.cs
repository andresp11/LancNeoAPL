using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ZedGraph;
using System.IO;

namespace LancNeo
{
    /// <summary>
    /// Descripción breve de InfAgregados.
    /// </summary>
    public class InfAgregados : System.Windows.Forms.Form
    {
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAInfAgregados;
        private LancNeo.dsBusObra dsBusObra1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private LancNeo.dsFirmas dsFirmas1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFolioFin;
        private System.Windows.Forms.TextBox txtFolioIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdobra;
        public System.Data.SqlClient.SqlDataAdapter sqlDAAgregadosInf;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsAgregadosInf dsAgregadosInf1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfAgregados;
        private System.Data.SqlClient.SqlDataAdapter sqlDAInfAgregadosMal;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private LancNeo.dsInfAgregadosMal dsInfAgregadosMal1;
        private System.Windows.Forms.PictureBox pictureBox1;
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.CheckBox chbDuplicado;
        private System.Windows.Forms.CheckBox chbLeyenda;
        private System.Data.SqlClient.SqlDataAdapter sqlDANorma;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Windows.Forms.CheckBox chbLab;
        private System.Windows.Forms.CheckBox chbLab1;
        private SqlConnection sqlConn;
        private dsInfAgregados dsInfAgregados1;
        private CryRepAgregados cryRepAgregados1;
        private CheckBox chbTodos;
        private CheckBox chbRespaldo;
        private DBGraphics memGraphics;

        public InfAgregados()
        {
            //
            // Necesario para admitir el Diseñador de Windows Forms
            //
            InitializeComponent();
            memGraphics = new DBGraphics();
            //
            // TODO: agregar código de constructor después de llamar a InitializeComponent
            //
        }

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfAgregados));
            this.sqlDAInfAgregados = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsAgregadosInf1 = new LancNeo.dsAgregadosInf();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolioFin = new System.Windows.Forms.TextBox();
            this.txtFolioIni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.chbLab1 = new System.Windows.Forms.CheckBox();
            this.sqlDAAgregadosInf = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvInfAgregados = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAInfAgregadosMal = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsInfAgregadosMal1 = new LancNeo.dsInfAgregadosMal();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsInfAgregados1 = new LancNeo.dsInfAgregados();
            this.cryRepAgregados1 = new LancNeo.CryRepAgregados();
            this.chbRespaldo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregadosInf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfAgregadosMal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfAgregados1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDAInfAgregados
            // 
            this.sqlDAInfAgregados.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAInfAgregados.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AgregadosRep", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("Muestreadas", "Muestreadas"),
                        new System.Data.Common.DataColumnMapping("Procedencia", "Procedencia"),
                        new System.Data.Common.DataColumnMapping("Usarse", "Usarse"),
                        new System.Data.Common.DataColumnMapping("MasaSuelta", "MasaSuelta"),
                        new System.Data.Common.DataColumnMapping("MasaCompacta", "MasaCompacta"),
                        new System.Data.Common.DataColumnMapping("MasaEspecifica", "MasaEspecifica"),
                        new System.Data.Common.DataColumnMapping("Agua", "Agua"),
                        new System.Data.Common.DataColumnMapping("Impureza", "Impureza"),
                        new System.Data.Common.DataColumnMapping("Fino", "Fino"),
                        new System.Data.Common.DataColumnMapping("Finura", "Finura"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[AgregadosRep]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "AFB"),
            new System.Data.SqlClient.SqlParameter("@FolioIni", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "39/13"),
            new System.Data.SqlClient.SqlParameter("@FOlioFin", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "39/13")});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAFirmas
            // 
            this.sqlDAFirmas.SelectCommand = this.sqlSelectCommand7;
            this.sqlDAFirmas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Firmas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdFirma", "IdFirma"),
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Cargo", "Cargo"),
                        new System.Data.Common.DataColumnMapping("Imprime", "Imprime")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT IdFirma, Nombre, Cargo, Imprime FROM Firmas WHERE (Imprime = 1) ORDER BY I" +
    "dFirma";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.chbRespaldo);
            this.panel1.Controls.Add(this.chbTodos);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chbDuplicado);
            this.panel1.Controls.Add(this.txtTamaño);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFolioFin);
            this.panel1.Controls.Add(this.txtFolioIni);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.chbLab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 95);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 650;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsAgregadosInf1.Agregados;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(332, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsAgregadosInf1
            // 
            this.dsAgregadosInf1.DataSetName = "dsAgregadosInf";
            this.dsAgregadosInf1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAgregadosInf1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(630, 0);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbTodos
            // 
            this.chbTodos.ForeColor = System.Drawing.Color.White;
            this.chbTodos.Location = new System.Drawing.Point(400, 28);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(126, 25);
            this.chbTodos.TabIndex = 76;
            this.chbTodos.Text = "Todos los informes";
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(210, 54);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 24);
            this.chbLab.TabIndex = 38;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Checked = true;
            this.chbLeyenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(532, 53);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(108, 25);
            this.chbLeyenda.TabIndex = 32;
            this.chbLeyenda.Text = "Formato leyenda";
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.ForeColor = System.Drawing.Color.White;
            this.chbDuplicado.Location = new System.Drawing.Point(212, 26);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(89, 24);
            this.chbDuplicado.TabIndex = 31;
            this.chbDuplicado.Text = "¿Duplicado?";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(532, 32);
            this.txtTamaño.MaxLength = 25;
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(74, 20);
            this.txtTamaño.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(537, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tamaño nominal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtFolioFin
            // 
            this.txtFolioFin.Location = new System.Drawing.Point(782, 46);
            this.txtFolioFin.Name = "txtFolioFin";
            this.txtFolioFin.Size = new System.Drawing.Size(54, 20);
            this.txtFolioFin.TabIndex = 28;
            this.txtFolioFin.Visible = false;
            // 
            // txtFolioIni
            // 
            this.txtFolioIni.Location = new System.Drawing.Point(470, 2);
            this.txtFolioIni.Name = "txtFolioIni";
            this.txtFolioIni.Size = new System.Drawing.Size(54, 20);
            this.txtFolioIni.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(720, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Folio final:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Folio inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(243, 2);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de calidad de agregados petreos";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(366, 32);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // chbLab1
            // 
            this.chbLab1.Checked = true;
            this.chbLab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab1.ForeColor = System.Drawing.Color.White;
            this.chbLab1.Location = new System.Drawing.Point(718, 0);
            this.chbLab1.Name = "chbLab1";
            this.chbLab1.Size = new System.Drawing.Size(130, 24);
            this.chbLab1.TabIndex = 75;
            this.chbLab1.Text = "Incluye laboratorista";
            // 
            // sqlDAAgregadosInf
            // 
            this.sqlDAAgregadosInf.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAAgregadosInf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Agregados", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Muestreadas", "Muestreadas"),
                        new System.Data.Common.DataColumnMapping("Procedencia", "Procedencia"),
                        new System.Data.Common.DataColumnMapping("Usarse", "Usarse")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT FOLIO, IdObra, Material, ConsObra, Fmuestreo, Fensaye, Finforme, NoEco, Se" +
    "mana, Muestreadas, Procedencia, Usarse FROM Agregados WHERE (IdObra = @IdObra) O" +
    "RDER BY FOLIO";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // crvInfAgregados
            // 
            this.crvInfAgregados.ActiveViewIndex = -1;
            this.crvInfAgregados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfAgregados.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfAgregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfAgregados.EnableRefresh = false;
            this.crvInfAgregados.Location = new System.Drawing.Point(0, 95);
            this.crvInfAgregados.Name = "crvInfAgregados";
            this.crvInfAgregados.ShowCloseButton = false;
            this.crvInfAgregados.ShowGroupTreeButton = false;
            this.crvInfAgregados.ShowLogo = false;
            this.crvInfAgregados.Size = new System.Drawing.Size(856, 553);
            this.crvInfAgregados.TabIndex = 13;
            this.crvInfAgregados.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlDAInfAgregadosMal
            // 
            this.sqlDAInfAgregadosMal.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAInfAgregadosMal.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AgregadosMal", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Grava", "Grava"),
                        new System.Data.Common.DataColumnMapping("GravaSI", "GravaSI"),
                        new System.Data.Common.DataColumnMapping("Arena", "Arena"),
                        new System.Data.Common.DataColumnMapping("ArenaSI", "ArenaSI"),
                        new System.Data.Common.DataColumnMapping("Acumulado", "Acumulado"),
                        new System.Data.Common.DataColumnMapping("Quepasa", "Quepasa"),
                        new System.Data.Common.DataColumnMapping("Nomina", "Nomina"),
                        new System.Data.Common.DataColumnMapping("NominalSup", "NominalSup")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdFolioFin", System.Data.SqlDbType.Char, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Current, "15/14"),
            new System.Data.SqlClient.SqlParameter("@IdFolioini", System.Data.SqlDbType.Char, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Current, "15/14")});
            // 
            // dsInfAgregadosMal1
            // 
            this.dsInfAgregadosMal1.DataSetName = "dsInfAgregadosMal";
            this.dsInfAgregadosMal1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsInfAgregadosMal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 402);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // sqlDANorma
            // 
            this.sqlDANorma.SelectCommand = this.sqlSelectCommand4;
            this.sqlDANorma.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Normas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdNorma", "IdNorma"),
                        new System.Data.Common.DataColumnMapping("Informe", "Informe"),
                        new System.Data.Common.DataColumnMapping("Normas", "Normas"),
                        new System.Data.Common.DataColumnMapping("Titulo", "Titulo"),
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme"),
                        new System.Data.Common.DataColumnMapping("Norma1", "Norma1"),
                        new System.Data.Common.DataColumnMapping("Norma2", "Norma2"),
                        new System.Data.Common.DataColumnMapping("Norma3", "Norma3"),
                        new System.Data.Common.DataColumnMapping("Norma4", "Norma4"),
                        new System.Data.Common.DataColumnMapping("Norma5", "Norma5")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme, Norma1, Norma2, Norma3, Norma" +
    "4, Norma5 FROM Normas WHERE (IdNorma = 10) ORDER BY IdNorma";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // dsInfAgregados1
            // 
            this.dsInfAgregados1.DataSetName = "dsInfAgregados";
            this.dsInfAgregados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chbRespaldo
            // 
            this.chbRespaldo.ForeColor = System.Drawing.Color.White;
            this.chbRespaldo.Location = new System.Drawing.Point(400, 54);
            this.chbRespaldo.Name = "chbRespaldo";
            this.chbRespaldo.Size = new System.Drawing.Size(82, 24);
            this.chbRespaldo.TabIndex = 81;
            this.chbRespaldo.Text = "Respaldo";
            // 
            // InfAgregados
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(856, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crvInfAgregados);
            this.Controls.Add(this.panel1);
            this.Name = "InfAgregados";
            this.Text = "InfAgregados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfAgregados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgregadosInf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfAgregadosMal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfAgregados1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        protected GraphPane myPane;

        private void InfAgregados_Load(object sender, System.EventArgs e)
        {
            sqlDABusObra.Fill(dsBusObra1, "Obra");
        }

        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            if (dsAgregadosInf1.Tables["Agregados"].Rows.Count > 0)
            {
                txtFolioIni.Text = dsAgregadosInf1.Tables["Agregados"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
                txtFolioFin.Text = dsAgregadosInf1.Tables["Agregados"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
                btnVistaPrevia.Visible = true;
            }
            else
            {
                btnVistaPrevia.Visible = false;
            }
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            buscaBtn1.Visible = true;
            dsAgregadosInf1.Clear();
            sqlDAAgregadosInf.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAAgregadosInf.Fill(dsAgregadosInf1, "Agregados");
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            int j = 0;
            int k = 0;
            double[] x = new double[12];
            double[] y = new double[12];
            double[] x1 = new double[12];
            double[] y1 = new double[12];

            crvInfAgregados.Visible = true;
            dsInfAgregados1.Clear();

            // cryRepAgregados1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryRepAgregados1.SetDataSource(dsInfAgregados1);

            sqlDAInfAgregados.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAInfAgregados.SelectCommand.Parameters["@FolioIni"].Value = (chbTodos.Checked ? " " : txtFolioIni.Text);
            sqlDAInfAgregados.SelectCommand.Parameters["@FolioFin"].Value = (chbTodos.Checked ? "zzzzz" : txtFolioIni.Text);
            sqlDAInfAgregados.Fill(dsInfAgregados1, "AgregadosRep");
            //sqlDAInfAgregadosMal.SelectCommand.Parameters["@IdFolioIni"].Value = txtFolioIni.Text;
            //sqlDAInfAgregadosMal.SelectCommand.Parameters["@IdFolioFin"].Value = txtFolioFin.Text;
            //sqlDAInfAgregadosMal.Fill(dsInfAgregados1, "AgregadosMal");
            sqlDAFirmas.Fill(dsFirmas1, "Firmas");
            sqlDANorma.Fill(dsInfAgregados1, "Normas");
            cryRepAgregados1.SetDataSource(dsInfAgregados1);
            cryRepAgregados1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
            cryRepAgregados1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
            cryRepAgregados1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
            cryRepAgregados1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
            cryRepAgregados1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
            cryRepAgregados1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
            cryRepAgregados1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
            cryRepAgregados1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
            cryRepAgregados1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
            cryRepAgregados1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
            cryRepAgregados1.SetParameterValue("@Finura", dsInfAgregados1.Tables["AgregadosRep"].Rows[0][21].ToString(), "Subreport2");
            cryRepAgregados1.SetParameterValue("@Material", dsInfAgregados1.Tables["AgregadosRep"].Rows[0][6].ToString(), "Subreport2");
            cryRepAgregados1.SetParameterValue("@Tamaño", txtTamaño.Text, "Subreport2");
            cryRepAgregados1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
            cryRepAgregados1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
            cryRepAgregados1.SetParameterValue("@LabLey", chbLab.Checked);
            cryRepAgregados1.SetParameterValue("@Ineco", chbLab1.Checked);
            cryRepAgregados1.SetParameterValue("@Respaldo", chbRespaldo.Checked);

            memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
            this.ClientRectangle.Width, this.ClientRectangle.Height);

            myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "", "");
            SetSize();
            int ejex;
            double MaxX = 0;

            CurveItem curve;
            string folio;
            int rens;
            for (int m = 0; m < dsInfAgregados1.Tables["AgregadosRep"].Rows.Count; m++)
            {

                sqlDAInfAgregadosMal.SelectCommand.Parameters["@IdFolioIni"].Value = dsInfAgregados1.Tables["AgregadosRep"].Rows[m][0].ToString().Trim();
                sqlDAInfAgregadosMal.SelectCommand.Parameters["@IdFolioFin"].Value = dsInfAgregados1.Tables["AgregadosRep"].Rows[m][0].ToString().Trim();
                sqlDAInfAgregadosMal.Fill(dsInfAgregados1, "AgregadosMal");

                folio = "Folio = '" + dsInfAgregados1.Tables["AgregadosRep"].Rows[m][0].ToString().Trim() + "'";
                DataRow[] filas;
                filas = dsInfAgregados1.Tables["AgregadosMal"].Select(folio);
                rens = filas.Length;
                int Material = (filas[0][6].ToString() == "Arena" ? 1 : 2);
                if (Material == 1)
                {
                    ejex = 4;
                    MaxX = 25;
                }
                else
                {
                    ejex = 2;
                    MaxX = 40;
                }
                //Curva que pasa
                string acotacion = "Pasa";
                for (k = 0; k < 12; k++)
                    x[k] = y[k] = 0;
                k = 0;
                for (j = 11; j > 1 - 1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][7].ToString() != "")
                    {
                        x[k] = double.Parse(filas[j][ejex].ToString());
                        y[k++] = double.Parse(filas[j][7].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x, y, Color.Blue, SymbolType.Circle);
                curve.Line.Width = 2.0F;
                curve.Line.Style = DashStyle.Dash;
                curve.Symbol.PenWidth = 6.0F;
                curve.Symbol.Fill = new Fill(Color.Blue);
                //Limite inferior
                acotacion = "Li";
                for (k = 0; k < 12; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = 11; j > 1 - 1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][8].ToString() != "")
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][8].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.Red, SymbolType.Diamond);
                curve.Line.Width = 2.0F;
                curve.Symbol.Fill = new Fill(Color.Red);
                curve.Symbol.PenWidth = 6.0F;
                //Limite superior
                acotacion = "Ls";
                for (k = 0; k < 12; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = 11; j > 1 - 1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][9].ToString() != "")
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][9].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.DarkGreen, SymbolType.Triangle);
                curve.Line.Width = 2.0F;
                curve.Symbol.PenWidth = 6.0F;
                curve.Symbol.Fill = new Fill(Color.DarkGreen);

                acotacion = "Pasa";
                for (k = 0; k < 12; k++)
                    x[k] = y[k] = 0;
                k = 0;
                for (j = 11; j > 1 - 1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][5].ToString() != "")
                    {
                        ArrowItem arrow = new ArrowItem(Color.Gray, 0, float.Parse(filas[j][ejex].ToString()), 0, float.Parse(filas[j][ejex].ToString()), 100);
                        arrow.CoordinateFrame = CoordType.AxisXYScale;
                        arrow.PenWidth = 0F;
                        myPane.ArrowList.Add(arrow);
                    }
                }
                //                myPane.XAxis.ScaledMinorTic(0);
                //                myPane.XAxis.IsMinorInsideTic = false;
                //                myPane.XAxis.TicSize = 0;
                //                myPane.XAxis.IsShowGrid = false;
                //                myPane.XAxis.IsInsideTic = false;
                //                myPane.XAxis.ScaleFontSpec.Angle = 0;
                //                myPane.XAxis.NumDec = 0;
                //                myPane.XAxis.Min = 1;
                //                myPane.XAxis.Max = MaxX;

                ////				MessageBox.Show(myPane.XAxis.ScaleFormat.ToString()); //esta buena
                //                myPane.XAxis.Type = AxisType.Log;
                ////				myPane.XAxis.PickLogScale();

                //                myPane.XAxis.ScaleFormat = "{0:d###.##}";
                //                myPane.XAxis.IsShowTitle = false;
                //                myPane.XAxis.ScaleFontSpec.FontColor = Color.White;

                //            myPane.YAxis.IsShowGrid = true;
                //            myPane.YAxis.ScaleFontSpec.Angle = 90;
                //            myPane.YAxis.Min = 0;
                //            myPane.YAxis.Max = 100;

                //            myPane.Legend.IsVisible = false;
                //            myPane.PaneFill = new Fill( Color.White, Color.White, 0F );
                //            myPane.AxisChange( this.CreateGraphics() );

                //            pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
                //            MemoryStream ms = new MemoryStream();
                //            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //            byte[] arrImage = ms.GetBuffer();
                //            ms.Close();

                //            myPane.Image.Dispose();
                //            pictureBox1.Image.Dispose();
                //            dsInfAgregados1.Grafica.AddGraficaRow(txtFolioIni.Text,arrImage);

                guardagrafica(dsInfAgregados1.Tables["AgregadosRep"].Rows[m][0].ToString().Trim(), MaxX);
                myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "", "");
                SetSize();

            }

            crvInfAgregados.ReportSource = cryRepAgregados1;
            //crvInfAgregados.RefreshReport();
        }
        private void SetSize()
        {
            Rectangle paneRect = pictureBox1.ClientRectangle; //this.ClientRectangle;
            paneRect.Inflate(0, 0);
            this.myPane.PaneRect = paneRect;
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void guardagrafica(string folio, double max)
        {

            decimal dMax = decimal.Parse(max.ToString());
            myPane.XAxis.ScaledMinorTic(0);
            myPane.XAxis.IsMinorInsideTic = false;
            myPane.XAxis.TicSize = 0;
            myPane.XAxis.IsShowGrid = false;
            myPane.XAxis.IsInsideTic = false;
            myPane.XAxis.ScaleFontSpec.Angle = 0;
            myPane.XAxis.NumDec = 0;
            myPane.XAxis.Min = 1;
            myPane.XAxis.Max = max;

            myPane.XAxis.Type = AxisType.Log;

            myPane.XAxis.ScaleFormat = "{0:d###.##}";
            myPane.XAxis.IsShowTitle = false;
            myPane.XAxis.ScaleFontSpec.FontColor = Color.White;

            myPane.YAxis.IsShowGrid = true;
            myPane.YAxis.ScaleFontSpec.Angle = 90;
            myPane.YAxis.Min = 0;
            myPane.YAxis.Max = 100;

            myPane.Legend.IsVisible = false;
            myPane.PaneFill = new Fill(Color.White, Color.White, 0F);
            myPane.AxisChange(this.CreateGraphics());

            pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] arrImage = ms.GetBuffer();
            ms.Close();

            myPane.Image.Dispose();
            pictureBox1.Image.Dispose();
            dsInfAgregados1.Grafica.AddGraficaRow(folio, arrImage);
        }

    }
}
