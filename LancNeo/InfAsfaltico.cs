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
    /// Descripción breve de InfAsfaltico.
    /// </summary>
    public class InfAsfaltico : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.CheckBox chbLab;
        private System.Windows.Forms.CheckBox chbLeyenda;
        private System.Windows.Forms.CheckBox chbDuplicado;
        private System.Windows.Forms.TextBox txtFolioIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdobra;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsInfAsfaltico dsInfAsfaltico1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAInfAsfaltico;
        private System.Data.SqlClient.SqlDataAdapter sqlDAInfAsfalticoMal;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfAsfaltico;
        public LancNeo.CryRepAsfalto CryRepAsfalto1;
        private LancNeo.dsFirmas dsFirmas1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private LancNeo.dsBusObra dsBusObra1;
        private LancNeo.dsBusAsfaltico dsBusAsfaltico1;
        private System.Data.SqlClient.SqlDataAdapter sqlDABusAsfaltico;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DBGraphics memGraphics;
        private CheckBox chbTodos;
        public SqlDataAdapter sqlDANorma;
        private SqlCommand sqlSelectCommand4;
        private CheckBox chbRespaldo;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public InfAsfaltico()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfAsfaltico));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusAsfaltico1 = new LancNeo.dsBusAsfaltico();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbRespaldo = new System.Windows.Forms.CheckBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.txtFolioIni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sqlDAInfAsfaltico = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsInfAsfaltico1 = new LancNeo.dsInfAsfaltico();
            this.sqlDAInfAsfalticoMal = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvInfAsfaltico = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CryRepAsfalto1 = new LancNeo.CryRepAsfalto();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusAsfaltico = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusAsfaltico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfAsfaltico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.txtFolioIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 100);
            this.panel1.TabIndex = 14;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 650;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusAsfaltico1.Asfaltico;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(547, 2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsBusAsfaltico1
            // 
            this.dsBusAsfaltico1.DataSetName = "dsBusAsfaltico";
            this.dsBusAsfaltico1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusAsfaltico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(780, 3);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 65);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbRespaldo
            // 
            this.chbRespaldo.ForeColor = System.Drawing.Color.White;
            this.chbRespaldo.Location = new System.Drawing.Point(645, 68);
            this.chbRespaldo.Name = "chbRespaldo";
            this.chbRespaldo.Size = new System.Drawing.Size(82, 24);
            this.chbRespaldo.TabIndex = 80;
            this.chbRespaldo.Text = "Respaldo";
            // 
            // chbTodos
            // 
            this.chbTodos.ForeColor = System.Drawing.Color.White;
            this.chbTodos.Location = new System.Drawing.Point(645, 38);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(137, 25);
            this.chbTodos.TabIndex = 79;
            this.chbTodos.Text = "Todos los informes";
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(405, 38);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 25);
            this.chbLab.TabIndex = 37;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(525, 69);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(114, 24);
            this.chbLeyenda.TabIndex = 32;
            this.chbLeyenda.Text = "Formato Leyenda";
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.ForeColor = System.Drawing.Color.White;
            this.chbDuplicado.Location = new System.Drawing.Point(405, 68);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(114, 23);
            this.chbDuplicado.TabIndex = 31;
            this.chbDuplicado.Text = "¿Duplicado?";
            // 
            // txtFolioIni
            // 
            this.txtFolioIni.Location = new System.Drawing.Point(685, 9);
            this.txtFolioIni.Name = "txtFolioIni";
            this.txtFolioIni.Size = new System.Drawing.Size(54, 20);
            this.txtFolioIni.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(615, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Folio inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(463, 3);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de ensaye de concreto asfaltico";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(570, 36);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 430);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // sqlDAInfAsfaltico
            // 
            this.sqlDAInfAsfaltico.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAInfAsfaltico.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AsfalticoRep", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Frecibo", "Frecibo"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("Usarse", "Usarse"),
                        new System.Data.Common.DataColumnMapping("Tratamietno", "Tratamietno"),
                        new System.Data.Common.DataColumnMapping("Deposito", "Deposito"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Viaje", "Viaje"),
                        new System.Data.Common.DataColumnMapping("TendidoI", "TendidoI"),
                        new System.Data.Common.DataColumnMapping("TendidoF", "TendidoF"),
                        new System.Data.Common.DataColumnMapping("Carril", "Carril"),
                        new System.Data.Common.DataColumnMapping("Franja", "Franja"),
                        new System.Data.Common.DataColumnMapping("TSalida", "TSalida"),
                        new System.Data.Common.DataColumnMapping("TTendido", "TTendido"),
                        new System.Data.Common.DataColumnMapping("TCompacta", "TCompacta"),
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
                        new System.Data.Common.DataColumnMapping("Mesp", "Mesp"),
                        new System.Data.Common.DataColumnMapping("Estabilidad", "Estabilidad"),
                        new System.Data.Common.DataColumnMapping("Flujo", "Flujo"),
                        new System.Data.Common.DataColumnMapping("Vacios", "Vacios"),
                        new System.Data.Common.DataColumnMapping("VAM", "VAM"),
                        new System.Data.Common.DataColumnMapping("EMesp", "EMesp"),
                        new System.Data.Common.DataColumnMapping("EEstabilidad", "EEstabilidad"),
                        new System.Data.Common.DataColumnMapping("EFlujo", "EFlujo"),
                        new System.Data.Common.DataColumnMapping("EVacios", "EVacios"),
                        new System.Data.Common.DataColumnMapping("EVAM", "EVAM"),
                        new System.Data.Common.DataColumnMapping("TipoC", "TipoC"),
                        new System.Data.Common.DataColumnMapping("Penetra", "Penetra"),
                        new System.Data.Common.DataColumnMapping("Viscosdad", "Viscosdad"),
                        new System.Data.Common.DataColumnMapping("Recomendad", "Recomendad"),
                        new System.Data.Common.DataColumnMapping("Aplicada", "Aplicada"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion1", "Ubicacion1"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[AsfalticoRep]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FolioIni", System.Data.SqlDbType.Char, 10),
            new System.Data.SqlClient.SqlParameter("@FOlioFin", System.Data.SqlDbType.Char, 10),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsInfAsfaltico1
            // 
            this.dsInfAsfaltico1.DataSetName = "dsInfAsfaltico";
            this.dsInfAsfaltico1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsInfAsfaltico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAInfAsfalticoMal
            // 
            this.sqlDAInfAsfalticoMal.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAInfAsfalticoMal.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AsfalticoMal", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Malla", "Malla"),
                        new System.Data.Common.DataColumnMapping("Linea1", "Linea1"),
                        new System.Data.Common.DataColumnMapping("Linea2", "Linea2"),
                        new System.Data.Common.DataColumnMapping("Quepasa", "Quepasa"),
                        new System.Data.Common.DataColumnMapping("Proyecto", "Proyecto")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        Folio, Renglon, Malla, Linea1, Linea2, Quepasa, Proyecto, Designaci" +
    "on\r\nFROM            AsfalticoMal\r\nWHERE        (Folio <= @FolioFin) AND (Folio >" +
    "= @FolioIni)\r\nORDER BY Folio, Renglon";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FolioFin", System.Data.SqlDbType.Char, 10, "Folio"),
            new System.Data.SqlClient.SqlParameter("@FolioIni", System.Data.SqlDbType.Char, 10, "Folio")});
            // 
            // crvInfAsfaltico
            // 
            this.crvInfAsfaltico.ActiveViewIndex = -1;
            this.crvInfAsfaltico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfAsfaltico.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfAsfaltico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfAsfaltico.EnableRefresh = false;
            this.crvInfAsfaltico.Location = new System.Drawing.Point(0, 100);
            this.crvInfAsfaltico.Name = "crvInfAsfaltico";
            this.crvInfAsfaltico.ShowCloseButton = false;
            this.crvInfAsfaltico.ShowGroupTreeButton = false;
            this.crvInfAsfaltico.ShowLogo = false;
            this.crvInfAsfaltico.ShowParameterPanelButton = false;
            this.crvInfAsfaltico.ShowRefreshButton = false;
            this.crvInfAsfaltico.Size = new System.Drawing.Size(856, 548);
            this.crvInfAsfaltico.TabIndex = 77;
            this.crvInfAsfaltico.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlSelectCommand7.CommandText = "SELECT     IdFirma, Nombre, Cargo, Imprime\r\nFROM         Firmas\r\nWHERE     (Impri" +
    "me = 1) AND (Materiales < 6)\r\nORDER BY Materiales";
            this.sqlSelectCommand7.Connection = this.sqlConn;
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
            // sqlDABusAsfaltico
            // 
            this.sqlDABusAsfaltico.SelectCommand = this.sqlCommand2;
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
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT FOLIO, IdObra, ConsObra, Fmuestreo, Fensaye, Finforme, NoEco, Material FRO" +
    "M Asfaltico WHERE (IdObra = @IdObra) ORDER BY ConsObra DESC, FOLIO";
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
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
    "4, Norma5 FROM Normas WHERE (IdNorma = @IdNorma)";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNorma", System.Data.SqlDbType.SmallInt, 2, "IdNorma")});
            // 
            // InfAsfaltico
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(856, 648);
            this.Controls.Add(this.crvInfAsfaltico);
            this.Controls.Add(this.panel1);
            this.Name = "InfAsfaltico";
            this.Text = "InfAsfaltico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfAsfaltico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusAsfaltico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfAsfaltico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        protected GraphPane myPane;

        private void InfAsfaltico_Load(object sender, System.EventArgs e)
        {
            sqlDABusObra.Fill(dsBusObra1, "Obra");
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            buscaBtn1.Visible = true;
            dsBusAsfaltico1.Clear();
            sqlDABusAsfaltico.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDABusAsfaltico.Fill(dsBusAsfaltico1, "Asfaltico");
        }

        private void buscaBtn1_Click(object sender, System.EventArgs e)
        {
            if (dsBusAsfaltico1.Tables["Asfaltico"].Rows.Count > 0)
            {
                txtFolioIni.Text = dsBusAsfaltico1.Tables["Asfaltico"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
                btnVistaPrevia.Visible = true;
            }
            else
            {
                btnVistaPrevia.Visible = false;
            }
        }

        private void SetSize()
        {
            Rectangle paneRect = pictureBox1.ClientRectangle; //this.ClientRectangle;
            paneRect.Inflate(0, 0);
            this.myPane.PaneRect = paneRect;
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            int j = 0;
            int k = 0;

            crvInfAsfaltico.Visible = true;

            CryRepAsfalto1.SetDataSource(dsInfAsfaltico1);

            dsInfAsfaltico1.Clear();
            dsFirmas1.Clear();
            sqlDAInfAsfaltico.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDAInfAsfaltico.SelectCommand.Parameters["@FolioIni"].Value = (chbTodos.Checked ? "  " : txtFolioIni.Text);
            sqlDAInfAsfaltico.SelectCommand.Parameters["@FolioFin"].Value = (chbTodos.Checked ? "zzzzz" : txtFolioIni.Text);
            sqlDAInfAsfaltico.Fill(dsInfAsfaltico1, "AsfalticoRep");
            sqlDAFirmas.Fill(dsFirmas1, "Firmas");
            sqlDANorma.SelectCommand.Parameters["@IdNorma"].Value = 15;
            sqlDANorma.Fill(dsInfAsfaltico1, "Normas");
            CryRepAsfalto1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
            CryRepAsfalto1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
            CryRepAsfalto1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
            CryRepAsfalto1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
            CryRepAsfalto1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
            CryRepAsfalto1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
            CryRepAsfalto1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
            CryRepAsfalto1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
            CryRepAsfalto1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
            CryRepAsfalto1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
            CryRepAsfalto1.SetParameterValue("@Lab", chbLab.Checked);
            CryRepAsfalto1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
            CryRepAsfalto1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
            CryRepAsfalto1.SetParameterValue("@Respaldo", chbRespaldo.Checked);

            int ejex, rens = 0;


            memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
                this.ClientRectangle.Width, this.ClientRectangle.Height);

            myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "", "");
            SetSize();
            TextItem texe = new TextItem();
            double MaxX = 0, MinX = 0;

            CurveItem curve;
            ejex = 2;
            string folio;
            for (int m = 0; m < dsInfAsfaltico1.Tables["AsfalticoREP"].Rows.Count; m++)
            {

                sqlDAInfAsfalticoMal.SelectCommand.Parameters["@FolioIni"].Value = dsInfAsfaltico1.Tables["AsfalticoREP"].Rows[m][0].ToString().Trim();
                sqlDAInfAsfalticoMal.SelectCommand.Parameters["@FolioFin"].Value = dsInfAsfaltico1.Tables["AsfalticoREP"].Rows[m][0].ToString().Trim();
                sqlDAInfAsfalticoMal.Fill(dsInfAsfaltico1, "AsfalticoMal");

                folio = "Folio = '" + dsInfAsfaltico1.Tables["AsfalticoREP"].Rows[m][0].ToString().Trim() + "'";
                DataRow[] filas;
                filas = dsInfAsfaltico1.Tables["AsfalticoMal"].Select(folio);
                rens = filas.Length;
                double[] x = new double[rens];
                double[] y = new double[rens];
                double[] x1 = new double[rens];
                double[] y1 = new double[rens];
                MaxX = double.Parse(filas[0][2].ToString());
                MinX = double.Parse(filas[rens - 1][2].ToString());
                //Curva que pasa
                string acotacion = "Pasa";
                for (k = 0; k < rens; k++)
                    x[k] = y[k] = 0;
                k = 0;
                for (j = (rens - 1); j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][5].ToString() != "")
                    {
                        x[k] = double.Parse(filas[j][ejex].ToString());
                        y[k++] = double.Parse(filas[j][5].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x, y, Color.Blue, SymbolType.Triangle);
                curve.Line.Width = 1.0F;
                curve.Line.Style = DashStyle.Solid;
                curve.Symbol.PenWidth = 3.0F;
                curve.Symbol.Fill = new Fill(Color.Blue);
                //Limite inferior
                acotacion = "Proyecto";
                for (k = 0; k < rens; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = rens - 1; j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][6].ToString() != "")
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][6].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.Red, SymbolType.Star);
                curve.Line.Width = 1.0F;
                curve.Line.Style = DashStyle.Solid;
                curve.Symbol.PenWidth = 6.0F;
                curve.Symbol.Fill = new Fill(Color.Red);
                //Limite superior
                acotacion = "L1";
                for (k = 0; k < rens; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = (rens - 1); j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][3].ToString() != "0" )
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][3].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.DarkGreen, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Symbol.IsVisible = false;
                //Limite inferior
                acotacion = "L2";
                for (k = 0; k < rens; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = (rens - 1); j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][4].ToString() != "0.00")
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][4].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.Brown, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Symbol.IsVisible = false;

                int si = -3;
                string acota = "";
                acotacion = "Pasa";
                for (k = 0; k < rens; k++)
                    x[k] = y[k] = 0;
                k = 0;
                for (j = (rens - 1); j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][3].ToString() != "")
                    {
                        ArrowItem arrow = new ArrowItem(Color.Gray, 0, float.Parse(filas[j][ejex].ToString()), 0, float.Parse(filas[j][ejex].ToString()), 100);
                        arrow.CoordinateFrame = CoordType.AxisXYScale;
                        arrow.PenWidth = 0.0F;
                        //if (filas[j][ejex].ToString() == "0.425")
                        //    arrow.PenWidth = 3.0F;
                        //if (float.Parse(filas[j][ejex].ToString()) == 4.75)
                        //    arrow.PenWidth = 3.0F;
//                        filas = dsInfAsfaltico1.Tables["AsfalticoMal"].Select(folio);

                        acota = dsInfAsfaltico1.Tables["AsfalticoMal"].Rows[j][ejex].ToString().Trim();
                        int lacota = acota.Length  - 1;
                        acota = (acota.Substring(lacota, 1) == "0" ? acota.Substring(0, lacota ) : acota);
                        myPane.ArrowList.Add(arrow);

                        texe = new TextItem(acota, float.Parse(dsInfAsfaltico1.Tables["AsfalticoMal"].Rows[j][ejex].ToString()), si);
//                        si = (si == -2 ? -6 : -2);
                        texe.FontSpec.IsBold = true;
                        texe.FontSpec.FrameColor = Color.White;
                        texe.FontSpec.Size = 10;
                        texe.FontSpec.Family = "Times New Roman";
                        //                        texe.FontSpec.Angle = 270;
                        myPane.TextList.Add(texe);
                        //texe = new TextItem(dsInfAsfaltico1.Tables["AsfalticoMal"].Rows[j][ejex + 1].ToString(), float.Parse(dsInfAsfaltico1.Tables["AsfalticoMal"].Rows[j][ejex].ToString()), 105);
                        //texe.FontSpec.IsBold = false;
                        //texe.FontSpec.FrameColor = Color.White;
                        //texe.FontSpec.Size = 9;
                        //texe.FontSpec.Family = "Times New Roman";
                        //myPane.TextList.Add(texe);

                    }
                }

                guardagrafica(dsInfAsfaltico1.Tables["AsfalticoREP"].Rows[m][0].ToString().Trim(), MinX, MaxX);
                myPane = new GraphPane(new Rectangle(10, 10, 10, 10), "", "", "");
                SetSize();

            }

            //myPane.XAxis.IsMinorInsideTic = false;
            //myPane.XAxis.IsShowGrid = true;
            //myPane.XAxis.ScaleFontSpec.Angle = 0;
            //myPane.XAxis.Min = MinX;
            //myPane.XAxis.Max = MaxX;
            //myPane.XAxis.Type = AxisType.Log;
            //myPane.XAxis.ScaleFormat = "{0:d###.##}";
            //myPane.XAxis.ScaleFontSpec.FontColor = Color.White;
            //myPane.XAxis.Title = "MALLA NÚMERO";
            //myPane.YAxis.IsShowGrid = true;
            //myPane.YAxis.ScaleFontSpec.Angle = 90;
            //myPane.YAxis.Min = 0;
            //myPane.YAxis.Max = 100;
            //myPane.YAxis.Title = "% QUE PASA";


            //myPane.Legend.IsVisible = false;
            //myPane.Title = "GRAFICA DE COMPOSICION GRANULOMETRICA";
            //myPane.PaneFill = new Fill( Color.White, Color.White, 0F );
            //myPane.AxisChange( this.CreateGraphics() );

            //pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            //MemoryStream ms = new MemoryStream();
            //pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //byte[] arrImage = ms.GetBuffer();
            //ms.Close();

            //myPane.Image.Dispose();
            //pictureBox1.Image.Dispose();
            //dsInfAsfaltico1.Grafica.AddGraficaRow(txtFolioIni.Text,arrImage);
            //			CryRepAsfalto1.SetParameterValue("@MaxX", MaxX);
            crvInfAsfaltico.ReportSource = CryRepAsfalto1;

            //crvInfAsfaltico.RefreshReport();

        }

        private void guardagrafica(string folio, double min, double max)
        {

            decimal dMax = decimal.Parse(max.ToString());
            myPane.XAxis.IsMinorInsideTic = false;
            myPane.XAxis.IsShowGrid = true;
            myPane.XAxis.ScaleFontSpec.Angle = 0;
            myPane.XAxis.Min = min;
            myPane.XAxis.Max = max;
            myPane.XAxis.Type = AxisType.Log;
            myPane.XAxis.ScaleFormat = "{0:d###.##}";
            myPane.XAxis.ScaleFontSpec.FontColor = Color.White;
            //myPane.XAxis.Title = "Malla númeo";
            myPane.YAxis.IsShowGrid = true;
            myPane.YAxis.ScaleFontSpec.Angle = 90;
            myPane.YAxis.Min = 0;
            myPane.YAxis.Max = 100;
            myPane.YAxis.ScaleFontSpec.Size = 10;
            //myPane.YAxis.Title = "% que pasa";
            myPane.Legend.IsVisible = false;
            //myPane.Title = "Gráfica de composición granulométrica";
            myPane.PaneFill = new Fill(Color.White, Color.White, 0F);
            myPane.AxisChange(this.CreateGraphics());

            pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] arrImage = ms.GetBuffer();
            ms.Close();

            myPane.Image.Dispose();
            pictureBox1.Image.Dispose();
            dsInfAsfaltico1.Grafica.AddGraficaRow(folio, arrImage, dMax);

        }
    }
}
