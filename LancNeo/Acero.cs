using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Acero.
	/// </summary>
	public class Acero : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAAcero;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsAcero dsAcero1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtNominal;
		private System.Windows.Forms.TextBox txtMilimetros;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbMilimetros;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private LancNeo.dsClaAcero dsClaAcero1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.TextBox txtMasa;
		private System.Windows.Forms.TextBox txtEsfuerzoLE;
		private System.Windows.Forms.TextBox txtAlargamiento;
		private System.Windows.Forms.TextBox textEsfuerzoMAX;
		private System.Windows.Forms.TextBox txtAncho;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.TextBox txtInclinacion;
		private System.Windows.Forms.TextBox txtSeparación;
		private System.Windows.Forms.TextBox txtRTEF;
		private System.Windows.Forms.TextBox txtDoblado;
		private System.Windows.Forms.TextBox txtInclinacion50;
		private System.Windows.Forms.TextBox txtAltMinCua;
		private System.Windows.Forms.TextBox txtAltMinCen;
		private System.Windows.Forms.TextBox txtCortante1;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.TextBox txtCortante2;
		private System.Windows.Forms.TextBox txtSuma;
		private System.Windows.Forms.TextBox txtCostilla;
		private System.Windows.Forms.TextBox txtCoeficiente;
		private System.Windows.Forms.TextBox txtAngulo;
		private LancNeo.dsTipAcero dsTipAcero1;
		private System.Windows.Forms.Label lblSeparacion;
		private System.Windows.Forms.Label lblEsfuerzoMax;
		private System.Windows.Forms.Label lblEsfuerzoLE;
		private System.Windows.Forms.Label lblAncho;
		private System.Windows.Forms.Label lblAltura;
		private System.Windows.Forms.Label lblInclinacion;
		private System.Windows.Forms.Label lblRTEF;
		private System.Windows.Forms.Label lblInclinacion50;
		private System.Windows.Forms.Label lblAltMinCen;
		private System.Windows.Forms.Label lblCortante1;
		private System.Windows.Forms.Label lblArea;
		private System.Windows.Forms.Label lblCortante2;
		private System.Windows.Forms.Label lblCoeficiente;
		private System.Windows.Forms.Label lblSuma;
		private System.Windows.Forms.Label lblCostilla;
		private System.Windows.Forms.Label lblAngulo;
		private System.Windows.Forms.Label lblAltMinCua;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Acero()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acero));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAAcero = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsAcero1 = new LancNeo.dsAcero();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.txtCoeficiente = new System.Windows.Forms.TextBox();
            this.lblCoeficiente = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtCostilla = new System.Windows.Forms.TextBox();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblCostilla = new System.Windows.Forms.Label();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.txtAltMinCua = new System.Windows.Forms.TextBox();
            this.txtAltMinCen = new System.Windows.Forms.TextBox();
            this.lblAltMinCua = new System.Windows.Forms.Label();
            this.lblAltMinCen = new System.Windows.Forms.Label();
            this.txtCortante1 = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtCortante2 = new System.Windows.Forms.TextBox();
            this.lblCortante1 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCortante2 = new System.Windows.Forms.Label();
            this.txtRTEF = new System.Windows.Forms.TextBox();
            this.txtDoblado = new System.Windows.Forms.TextBox();
            this.txtInclinacion50 = new System.Windows.Forms.TextBox();
            this.lblRTEF = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblInclinacion50 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtInclinacion = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblInclinacion = new System.Windows.Forms.Label();
            this.txtSeparación = new System.Windows.Forms.TextBox();
            this.txtAlargamiento = new System.Windows.Forms.TextBox();
            this.textEsfuerzoMAX = new System.Windows.Forms.TextBox();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEsfuerzoMax = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dsTipAcero1 = new LancNeo.dsTipAcero();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtEsfuerzoLE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEsfuerzoLE = new System.Windows.Forms.Label();
            this.cmbMilimetros = new System.Windows.Forms.ComboBox();
            this.dsClaAcero1 = new LancNeo.dsClaAcero();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMilimetros = new System.Windows.Forms.TextBox();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClaAcero1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 407);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(798, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(798, 64);
            // 
            // sqlDAAcero
            // 
            this.sqlDAAcero.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAAcero.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAAcero.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAAcero.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Acero", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("Milimetros", "Milimetros"),
                        new System.Data.Common.DataColumnMapping("Clasificacion", "Clasificacion"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoLE", "EsfuerzoLE"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMAX", "EsfuerzoMAX"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("Separacion", "Separacion"),
                        new System.Data.Common.DataColumnMapping("Altura", "Altura"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Inclinacion", "Inclinacion"),
                        new System.Data.Common.DataColumnMapping("Doblado", "Doblado"),
                        new System.Data.Common.DataColumnMapping("RTEF", "RTEF"),
                        new System.Data.Common.DataColumnMapping("Inclinacion50", "Inclinacion50"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("Cortante1", "Cortante1"),
                        new System.Data.Common.DataColumnMapping("Cortante2", "Cortante2"),
                        new System.Data.Common.DataColumnMapping("AltMinCen", "AltMinCen"),
                        new System.Data.Common.DataColumnMapping("AltMinCua", "AltMinCua"),
                        new System.Data.Common.DataColumnMapping("Costilla", "Costilla"),
                        new System.Data.Common.DataColumnMapping("Suma", "Suma"),
                        new System.Data.Common.DataColumnMapping("Angulo", "Angulo"),
                        new System.Data.Common.DataColumnMapping("Coeficiente", "Coeficiente"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa")})});
            this.sqlDAAcero.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nominal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nominal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milimetros", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milimetros", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milimetros", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Milimetros", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Clasificacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Clasificacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Clasificacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Clasificacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Separacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Separacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Separacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Altura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Altura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Altura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Altura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ancho", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ancho", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Inclinacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Inclinacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Inclinacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Inclinacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Doblado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RTEF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RTEF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RTEF", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "RTEF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Inclinacion50", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Inclinacion50", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Inclinacion50", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion50", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cortante1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cortante1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cortante2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cortante2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AltMinCen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AltMinCen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCen", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AltMinCua", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AltMinCua", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCua", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Costilla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Costilla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Costilla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Suma", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suma", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Suma", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Angulo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Angulo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Coeficiente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Coeficiente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Coeficiente", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.Char, 0, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Nominal", System.Data.SqlDbType.NVarChar, 0, "Nominal"),
            new System.Data.SqlClient.SqlParameter("@Milimetros", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Milimetros", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Clasificacion", System.Data.SqlDbType.NVarChar, 0, "Clasificacion"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.SmallInt, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Int, 0, "EsfuerzoLE"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Int, 0, "EsfuerzoMAX"),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Separacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Altura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Altura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Inclinacion", System.Data.SqlDbType.NVarChar, 0, "Inclinacion"),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 0, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@RTEF", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "RTEF", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Inclinacion50", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion50", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Cortante1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Cortante2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCen", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCua", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Costilla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Suma", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Angulo", System.Data.SqlDbType.NVarChar, 0, "Angulo"),
            new System.Data.SqlClient.SqlParameter("@Coeficiente", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null)});
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
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.Char, 0, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Nominal", System.Data.SqlDbType.NVarChar, 0, "Nominal"),
            new System.Data.SqlClient.SqlParameter("@Milimetros", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Milimetros", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Clasificacion", System.Data.SqlDbType.NVarChar, 0, "Clasificacion"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.SmallInt, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Int, 0, "EsfuerzoLE"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Int, 0, "EsfuerzoMAX"),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Separacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Altura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Altura", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Inclinacion", System.Data.SqlDbType.NVarChar, 0, "Inclinacion"),
            new System.Data.SqlClient.SqlParameter("@Doblado", System.Data.SqlDbType.NVarChar, 0, "Doblado"),
            new System.Data.SqlClient.SqlParameter("@RTEF", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "RTEF", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Inclinacion50", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion50", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Cortante1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Cortante2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCen", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AltMinCua", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCua", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Costilla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Suma", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Angulo", System.Data.SqlDbType.NVarChar, 0, "Angulo"),
            new System.Data.SqlClient.SqlParameter("@Coeficiente", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nominal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nominal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milimetros", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milimetros", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milimetros", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Milimetros", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Clasificacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Clasificacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Clasificacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Clasificacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Separacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Separacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Separacion", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Separacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Altura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Altura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Altura", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Altura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ancho", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ancho", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Inclinacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Inclinacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Inclinacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Inclinacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Doblado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Doblado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doblado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RTEF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RTEF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RTEF", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "RTEF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Inclinacion50", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Inclinacion50", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Inclinacion50", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "Inclinacion50", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cortante1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cortante1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cortante2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cortante2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cortante2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Cortante2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AltMinCen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AltMinCen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCen", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AltMinCua", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AltMinCua", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AltMinCua", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "AltMinCua", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Costilla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Costilla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Costilla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Costilla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Suma", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suma", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Suma", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Suma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Angulo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Angulo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Angulo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Coeficiente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Coeficiente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Coeficiente", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(3)), "Coeficiente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null)});
            // 
            // dsAcero1
            // 
            this.dsAcero1.DataSetName = "dsAcero";
            this.dsAcero1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtCoeficiente);
            this.panel2.Controls.Add(this.lblCoeficiente);
            this.panel2.Controls.Add(this.txtSuma);
            this.panel2.Controls.Add(this.txtCostilla);
            this.panel2.Controls.Add(this.txtAngulo);
            this.panel2.Controls.Add(this.lblSuma);
            this.panel2.Controls.Add(this.lblCostilla);
            this.panel2.Controls.Add(this.lblAngulo);
            this.panel2.Controls.Add(this.txtAltMinCua);
            this.panel2.Controls.Add(this.txtAltMinCen);
            this.panel2.Controls.Add(this.lblAltMinCua);
            this.panel2.Controls.Add(this.lblAltMinCen);
            this.panel2.Controls.Add(this.txtCortante1);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.txtCortante2);
            this.panel2.Controls.Add(this.lblCortante1);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Controls.Add(this.lblCortante2);
            this.panel2.Controls.Add(this.txtRTEF);
            this.panel2.Controls.Add(this.txtDoblado);
            this.panel2.Controls.Add(this.txtInclinacion50);
            this.panel2.Controls.Add(this.lblRTEF);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.lblInclinacion50);
            this.panel2.Controls.Add(this.txtAncho);
            this.panel2.Controls.Add(this.txtAltura);
            this.panel2.Controls.Add(this.txtInclinacion);
            this.panel2.Controls.Add(this.lblAncho);
            this.panel2.Controls.Add(this.lblAltura);
            this.panel2.Controls.Add(this.lblInclinacion);
            this.panel2.Controls.Add(this.txtSeparación);
            this.panel2.Controls.Add(this.txtAlargamiento);
            this.panel2.Controls.Add(this.textEsfuerzoMAX);
            this.panel2.Controls.Add(this.lblSeparacion);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblEsfuerzoMax);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMasa);
            this.panel2.Controls.Add(this.txtGrado);
            this.panel2.Controls.Add(this.txtEsfuerzoLE);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblEsfuerzoLE);
            this.panel2.Controls.Add(this.cmbMilimetros);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMilimetros);
            this.panel2.Controls.Add(this.txtNominal);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 310);
            this.panel2.TabIndex = 0;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 700;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsAcero1.Acero;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(192, 22);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 36;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // txtCoeficiente
            // 
            this.txtCoeficiente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Coeficiente", true));
            this.txtCoeficiente.Location = new System.Drawing.Point(542, 100);
            this.txtCoeficiente.Name = "txtCoeficiente";
            this.txtCoeficiente.Size = new System.Drawing.Size(80, 20);
            this.txtCoeficiente.TabIndex = 31;
            this.txtCoeficiente.Text = "textBox1";
            // 
            // lblCoeficiente
            // 
            this.lblCoeficiente.AutoSize = true;
            this.lblCoeficiente.Location = new System.Drawing.Point(470, 100);
            this.lblCoeficiente.Name = "lblCoeficiente";
            this.lblCoeficiente.Size = new System.Drawing.Size(63, 13);
            this.lblCoeficiente.TabIndex = 53;
            this.lblCoeficiente.Text = "Coeficiente:";
            // 
            // txtSuma
            // 
            this.txtSuma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Suma", true));
            this.txtSuma.Location = new System.Drawing.Point(542, 54);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(80, 20);
            this.txtSuma.TabIndex = 29;
            this.txtSuma.Text = "textBox2";
            // 
            // txtCostilla
            // 
            this.txtCostilla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Costilla", true));
            this.txtCostilla.Location = new System.Drawing.Point(542, 30);
            this.txtCostilla.Name = "txtCostilla";
            this.txtCostilla.Size = new System.Drawing.Size(80, 20);
            this.txtCostilla.TabIndex = 37;
            this.txtCostilla.Text = "textBox1";
            // 
            // txtAngulo
            // 
            this.txtAngulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Angulo", true));
            this.txtAngulo.Location = new System.Drawing.Point(542, 78);
            this.txtAngulo.MaxLength = 10;
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(80, 20);
            this.txtAngulo.TabIndex = 30;
            this.txtAngulo.Text = "textBox1";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(436, 54);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(93, 13);
            this.lblSuma.TabIndex = 49;
            this.lblSuma.Text = "Suma de Costillas:";
            // 
            // lblCostilla
            // 
            this.lblCostilla.AutoSize = true;
            this.lblCostilla.Location = new System.Drawing.Point(490, 30);
            this.lblCostilla.Name = "lblCostilla";
            this.lblCostilla.Size = new System.Drawing.Size(43, 13);
            this.lblCostilla.TabIndex = 48;
            this.lblCostilla.Text = "Costilla:";
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Location = new System.Drawing.Point(492, 78);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(43, 13);
            this.lblAngulo.TabIndex = 47;
            this.lblAngulo.Text = "Ángulo:";
            // 
            // txtAltMinCua
            // 
            this.txtAltMinCua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.AltMinCua", true));
            this.txtAltMinCua.Location = new System.Drawing.Point(342, 270);
            this.txtAltMinCua.Name = "txtAltMinCua";
            this.txtAltMinCua.Size = new System.Drawing.Size(80, 20);
            this.txtAltMinCua.TabIndex = 27;
            this.txtAltMinCua.Text = "textBox2";
            // 
            // txtAltMinCen
            // 
            this.txtAltMinCen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.AltMinCen", true));
            this.txtAltMinCen.Location = new System.Drawing.Point(342, 246);
            this.txtAltMinCen.Name = "txtAltMinCen";
            this.txtAltMinCen.Size = new System.Drawing.Size(80, 20);
            this.txtAltMinCen.TabIndex = 26;
            this.txtAltMinCen.Text = "textBox1";
            // 
            // lblAltMinCua
            // 
            this.lblAltMinCua.AutoSize = true;
            this.lblAltMinCua.Location = new System.Drawing.Point(189, 270);
            this.lblAltMinCua.Name = "lblAltMinCua";
            this.lblAltMinCua.Size = new System.Drawing.Size(136, 13);
            this.lblAltMinCua.TabIndex = 43;
            this.lblAltMinCua.Text = "Altura minima a los Cuartos:";
            // 
            // lblAltMinCen
            // 
            this.lblAltMinCen.AutoSize = true;
            this.lblAltMinCen.Location = new System.Drawing.Point(210, 246);
            this.lblAltMinCen.Name = "lblAltMinCen";
            this.lblAltMinCen.Size = new System.Drawing.Size(116, 13);
            this.lblAltMinCen.TabIndex = 42;
            this.lblAltMinCen.Text = "Alturas minimas Centro:";
            // 
            // txtCortante1
            // 
            this.txtCortante1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Cortante1", true));
            this.txtCortante1.Location = new System.Drawing.Point(342, 198);
            this.txtCortante1.Name = "txtCortante1";
            this.txtCortante1.Size = new System.Drawing.Size(80, 20);
            this.txtCortante1.TabIndex = 24;
            this.txtCortante1.Text = "textBox2";
            // 
            // txtArea
            // 
            this.txtArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Area", true));
            this.txtArea.Location = new System.Drawing.Point(342, 174);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(80, 20);
            this.txtArea.TabIndex = 23;
            this.txtArea.Text = "textBox1";
            // 
            // txtCortante2
            // 
            this.txtCortante2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Cortante2", true));
            this.txtCortante2.Location = new System.Drawing.Point(342, 222);
            this.txtCortante2.MaxLength = 10;
            this.txtCortante2.Name = "txtCortante2";
            this.txtCortante2.Size = new System.Drawing.Size(80, 20);
            this.txtCortante2.TabIndex = 25;
            this.txtCortante2.Text = "textBox1";
            // 
            // lblCortante1
            // 
            this.lblCortante1.AutoSize = true;
            this.lblCortante1.Location = new System.Drawing.Point(275, 198);
            this.lblCortante1.Name = "lblCortante1";
            this.lblCortante1.Size = new System.Drawing.Size(59, 13);
            this.lblCortante1.TabIndex = 37;
            this.lblCortante1.Text = "Cortante 1:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(304, 174);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 36;
            this.lblArea.Text = "Area:";
            // 
            // lblCortante2
            // 
            this.lblCortante2.AutoSize = true;
            this.lblCortante2.Location = new System.Drawing.Point(275, 222);
            this.lblCortante2.Name = "lblCortante2";
            this.lblCortante2.Size = new System.Drawing.Size(59, 13);
            this.lblCortante2.TabIndex = 35;
            this.lblCortante2.Text = "Cortante 2:";
            // 
            // txtRTEF
            // 
            this.txtRTEF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.RTEF", true));
            this.txtRTEF.Location = new System.Drawing.Point(342, 126);
            this.txtRTEF.Name = "txtRTEF";
            this.txtRTEF.Size = new System.Drawing.Size(80, 20);
            this.txtRTEF.TabIndex = 20;
            this.txtRTEF.Text = "textBox2";
            // 
            // txtDoblado
            // 
            this.txtDoblado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Doblado", true));
            this.txtDoblado.Location = new System.Drawing.Point(342, 100);
            this.txtDoblado.Name = "txtDoblado";
            this.txtDoblado.Size = new System.Drawing.Size(80, 20);
            this.txtDoblado.TabIndex = 19;
            this.txtDoblado.Text = "textBox1";
            // 
            // txtInclinacion50
            // 
            this.txtInclinacion50.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Inclinacion50", true));
            this.txtInclinacion50.Location = new System.Drawing.Point(342, 150);
            this.txtInclinacion50.MaxLength = 10;
            this.txtInclinacion50.Name = "txtInclinacion50";
            this.txtInclinacion50.Size = new System.Drawing.Size(80, 20);
            this.txtInclinacion50.TabIndex = 22;
            this.txtInclinacion50.Text = "textBox1";
            // 
            // lblRTEF
            // 
            this.lblRTEF.AutoSize = true;
            this.lblRTEF.Location = new System.Drawing.Point(298, 126);
            this.lblRTEF.Name = "lblRTEF";
            this.lblRTEF.Size = new System.Drawing.Size(38, 13);
            this.lblRTEF.TabIndex = 31;
            this.lblRTEF.Text = "RTEF:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(285, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Doblado:";
            // 
            // lblInclinacion50
            // 
            this.lblInclinacion50.AutoSize = true;
            this.lblInclinacion50.Location = new System.Drawing.Point(258, 150);
            this.lblInclinacion50.Name = "lblInclinacion50";
            this.lblInclinacion50.Size = new System.Drawing.Size(76, 13);
            this.lblInclinacion50.TabIndex = 29;
            this.lblInclinacion50.Text = "Inclinación 50:";
            // 
            // txtAncho
            // 
            this.txtAncho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Ancho", true));
            this.txtAncho.Location = new System.Drawing.Point(342, 54);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(80, 20);
            this.txtAncho.TabIndex = 17;
            this.txtAncho.Text = "textBox2";
            // 
            // txtAltura
            // 
            this.txtAltura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Altura", true));
            this.txtAltura.Location = new System.Drawing.Point(342, 30);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(80, 20);
            this.txtAltura.TabIndex = 16;
            this.txtAltura.Text = "textBox1";
            // 
            // txtInclinacion
            // 
            this.txtInclinacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Inclinacion", true));
            this.txtInclinacion.Location = new System.Drawing.Point(342, 78);
            this.txtInclinacion.MaxLength = 10;
            this.txtInclinacion.Name = "txtInclinacion";
            this.txtInclinacion.Size = new System.Drawing.Size(80, 20);
            this.txtInclinacion.TabIndex = 18;
            this.txtInclinacion.Text = "textBox1";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(296, 54);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(41, 13);
            this.lblAncho.TabIndex = 25;
            this.lblAncho.Text = "Ancho:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(298, 30);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 24;
            this.lblAltura.Text = "Altura:";
            // 
            // lblInclinacion
            // 
            this.lblInclinacion.AutoSize = true;
            this.lblInclinacion.Location = new System.Drawing.Point(274, 78);
            this.lblInclinacion.Name = "lblInclinacion";
            this.lblInclinacion.Size = new System.Drawing.Size(61, 13);
            this.lblInclinacion.TabIndex = 23;
            this.lblInclinacion.Text = "Inclinación:";
            // 
            // txtSeparación
            // 
            this.txtSeparación.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Separacion", true));
            this.txtSeparación.Location = new System.Drawing.Point(86, 270);
            this.txtSeparación.Name = "txtSeparación";
            this.txtSeparación.Size = new System.Drawing.Size(80, 20);
            this.txtSeparación.TabIndex = 15;
            this.txtSeparación.Text = "textBox2";
            // 
            // txtAlargamiento
            // 
            this.txtAlargamiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Alargamiento", true));
            this.txtAlargamiento.Location = new System.Drawing.Point(86, 246);
            this.txtAlargamiento.Name = "txtAlargamiento";
            this.txtAlargamiento.Size = new System.Drawing.Size(80, 20);
            this.txtAlargamiento.TabIndex = 14;
            this.txtAlargamiento.Text = "textBox1";
            // 
            // textEsfuerzoMAX
            // 
            this.textEsfuerzoMAX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.EsfuerzoMAX", true));
            this.textEsfuerzoMAX.Location = new System.Drawing.Point(86, 222);
            this.textEsfuerzoMAX.MaxLength = 10;
            this.textEsfuerzoMAX.Name = "textEsfuerzoMAX";
            this.textEsfuerzoMAX.Size = new System.Drawing.Size(80, 20);
            this.textEsfuerzoMAX.TabIndex = 13;
            this.textEsfuerzoMAX.Text = "textBox1";
            // 
            // lblSeparacion
            // 
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.Location = new System.Drawing.Point(13, 270);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(64, 13);
            this.lblSeparacion.TabIndex = 19;
            this.lblSeparacion.Text = "Separación:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Alargamiento:";
            // 
            // lblEsfuerzoMax
            // 
            this.lblEsfuerzoMax.AutoSize = true;
            this.lblEsfuerzoMax.Location = new System.Drawing.Point(1, 222);
            this.lblEsfuerzoMax.Name = "lblEsfuerzoMax";
            this.lblEsfuerzoMax.Size = new System.Drawing.Size(74, 13);
            this.lblEsfuerzoMax.TabIndex = 17;
            this.lblEsfuerzoMax.Text = "EsfuerzoMAX:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAcero1, "Acero.Tipo", true));
            this.cmbTipo.DataSource = this.dsTipAcero1.TipAcero;
            this.cmbTipo.DisplayMember = "Descripcion";
            this.cmbTipo.Location = new System.Drawing.Point(86, 126);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(162, 21);
            this.cmbTipo.TabIndex = 8;
            this.cmbTipo.ValueMember = "Tipo";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged_1);
            // 
            // dsTipAcero1
            // 
            this.dsTipAcero1.DataSetName = "dsTipAcero";
            this.dsTipAcero1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsTipAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo:";
            // 
            // txtMasa
            // 
            this.txtMasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Masa", true));
            this.txtMasa.Location = new System.Drawing.Point(86, 174);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(80, 20);
            this.txtMasa.TabIndex = 10;
            this.txtMasa.Text = "textBox2";
            // 
            // txtGrado
            // 
            this.txtGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Grado", true));
            this.txtGrado.Location = new System.Drawing.Point(86, 150);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(80, 20);
            this.txtGrado.TabIndex = 9;
            this.txtGrado.Text = "textBox1";
            // 
            // txtEsfuerzoLE
            // 
            this.txtEsfuerzoLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.EsfuerzoLE", true));
            this.txtEsfuerzoLE.Location = new System.Drawing.Point(86, 198);
            this.txtEsfuerzoLE.MaxLength = 10;
            this.txtEsfuerzoLE.Name = "txtEsfuerzoLE";
            this.txtEsfuerzoLE.Size = new System.Drawing.Size(80, 20);
            this.txtEsfuerzoLE.TabIndex = 12;
            this.txtEsfuerzoLE.Text = "textBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Masa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grado:";
            // 
            // lblEsfuerzoLE
            // 
            this.lblEsfuerzoLE.AutoSize = true;
            this.lblEsfuerzoLE.Location = new System.Drawing.Point(12, 198);
            this.lblEsfuerzoLE.Name = "lblEsfuerzoLE";
            this.lblEsfuerzoLE.Size = new System.Drawing.Size(64, 13);
            this.lblEsfuerzoLE.TabIndex = 9;
            this.lblEsfuerzoLE.Text = "EsfuerzoLE:";
            // 
            // cmbMilimetros
            // 
            this.cmbMilimetros.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAcero1, "Acero.Clasificacion", true));
            this.cmbMilimetros.DataSource = this.dsClaAcero1.ClaAcero;
            this.cmbMilimetros.DisplayMember = "Clasificacion";
            this.cmbMilimetros.Location = new System.Drawing.Point(86, 100);
            this.cmbMilimetros.Name = "cmbMilimetros";
            this.cmbMilimetros.Size = new System.Drawing.Size(80, 21);
            this.cmbMilimetros.TabIndex = 7;
            this.cmbMilimetros.ValueMember = "Clasifica";
            // 
            // dsClaAcero1
            // 
            this.dsClaAcero1.DataSetName = "dsClaAcero";
            this.dsClaAcero1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsClaAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clasificación:";
            // 
            // txtMilimetros
            // 
            this.txtMilimetros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Milimetros", true));
            this.txtMilimetros.Location = new System.Drawing.Point(86, 78);
            this.txtMilimetros.Name = "txtMilimetros";
            this.txtMilimetros.Size = new System.Drawing.Size(80, 20);
            this.txtMilimetros.TabIndex = 5;
            this.txtMilimetros.Text = "textBox2";
            // 
            // txtNominal
            // 
            this.txtNominal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Nominal", true));
            this.txtNominal.Location = new System.Drawing.Point(86, 54);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(80, 20);
            this.txtNominal.TabIndex = 4;
            this.txtNominal.Text = "textBox1";
            // 
            // txtNumero
            // 
            this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAcero1, "Acero.Numero", true));
            this.txtNumero.Location = new System.Drawing.Point(86, 30);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(80, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Text = "textBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Milimetros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nominal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // Acero
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(798, 429);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAAcero;
            this.dsGeneral = this.dsAcero1;
            this.Name = "Acero";
            this.NombreTabla = "Acero";
            this.Text = "Acero";
            this.Load += new System.EventHandler(this.Acero_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClaAcero1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Acero_Load(object sender, System.EventArgs e)
		{
			dsClaAcero1.ClaAcero.AddClaAceroRow("A","A");
			dsClaAcero1.ClaAcero.AddClaAceroRow("B","B");
			dsClaAcero1.ClaAcero.AddClaAceroRow("C","C");
			dsTipAcero1.TipAcero.AddTipAceroRow(1,"Varilla");
			dsTipAcero1.TipAcero.AddTipAceroRow(2,"Alambre grado 50");
			dsTipAcero1.TipAcero.AddTipAceroRow(3,"Varillin, malla grado 60");
			buscaBtn1.Catalogo = this;

		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbMilimetros.SelectedIndex = -1;
			cmbTipo.SelectedIndex = -1;
		}


		private void cmbTipo_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			if(cmbTipo.SelectedIndex != -1)
			switch (cmbTipo.SelectedValue.ToString())
			{
				case "1":
					lblEsfuerzoLE.Text	="EsfuerzoLE:";
					lblSeparacion.Text	="Separación:";
					lblAltura.Visible	=true;
					txtAltura.Visible	=true;
					lblAncho.Visible	=true;
					txtAncho.Visible	=true;
					lblInclinacion.Visible=true;
					txtInclinacion.Visible=true;
					lblRTEF.Visible=true;
					txtRTEF.Visible=true;
					lblInclinacion50.Visible=false;
					txtInclinacion50.Visible=false;
					lblArea.Visible		=false;
					txtArea.Visible		=false;
					lblCortante1.Visible=false;
					txtCortante1.Visible=false;
					lblCortante2.Visible=false;
					txtCortante2.Visible=false;
					lblAltMinCen.Visible=false;
					txtAltMinCen.Visible=false;
					lblAltMinCua.Visible=false;
					txtAltMinCua.Visible=false;
					lblCostilla.Visible=false;
					txtCostilla.Visible=false;
					lblSuma.Visible=false;
					txtSuma.Visible=false;
					lblAngulo.Visible=false;
					txtAngulo.Visible=false;
					lblCoeficiente.Visible=false;
					txtCoeficiente.Visible=false;
					break;
				case "2":
					lblEsfuerzoLE.Text	="EsfuerzoFLU:";
					lblSeparacion.Text	="Separación:";
					lblAltura.Visible	=true;
					txtAltura.Visible	=true;
					lblAncho.Visible	=false;
					txtAncho.Visible	=false;
					lblInclinacion.Visible=false;
					txtInclinacion.Visible=false;
					lblRTEF.Visible=false;
					txtRTEF.Visible=false;
					lblInclinacion50.Visible=true;
					txtInclinacion50.Visible=true;
					lblArea.Visible		=true;
					txtArea.Visible		=true;
					lblCortante1.Visible=true;
					txtCortante1.Visible=true;
					lblCortante2.Visible=true;
					txtCortante2.Visible=true;
					lblAltMinCen.Visible=false;
					txtAltMinCen.Visible=false;
					lblAltMinCua.Visible=false;
					txtAltMinCua.Visible=false;
					lblCostilla.Visible=false;
					txtCostilla.Visible=false;
					lblSuma.Visible=false;
					txtSuma.Visible=false;
					lblAngulo.Visible=false;
					txtAngulo.Visible=false;
					lblCoeficiente.Visible=false;
					txtCoeficiente.Visible=false;
					break;
				case "3":
					lblEsfuerzoLE.Text	="EsfuerzoFLU:";
					lblSeparacion.Text	="Espaciamiento:";
					lblAltura.Visible	=false;
					txtAltura.Visible	=false;
					lblAncho.Visible	=true;
					txtAncho.Visible	=true;
					lblInclinacion.Visible=false;
					txtInclinacion.Visible=false;
					lblRTEF.Visible=false;
					txtRTEF.Visible=false;
					lblInclinacion50.Visible=false;
					txtInclinacion50.Visible=false;
					lblArea.Visible		=true;
					txtArea.Visible		=true;
					lblCortante1.Visible=false;
					txtCortante1.Visible=false;
					lblCortante2.Visible=false;
					txtCortante2.Visible=false;
					lblAltMinCen.Visible=true;
					txtAltMinCen.Visible=true;
					lblAltMinCua.Visible=true;
					txtAltMinCua.Visible=true;
					lblCostilla.Visible=true;
					txtCostilla.Visible=true;
					lblSuma.Visible=true;
					txtSuma.Visible=true;
					lblAngulo.Visible=true;
					txtAngulo.Visible=true;
					lblCoeficiente.Visible=true;
					txtCoeficiente.Visible=true;
					break;
				default:
					lblEsfuerzoLE.Text	="EsfuerzoLE:";
					lblSeparacion.Text	="Separación:";
					lblAltura.Visible	=true;
					txtAltura.Visible	=true;
					lblAncho.Visible	=true;
					txtAncho.Visible	=true;
					lblInclinacion.Visible=true;
					txtInclinacion.Visible=true;
					lblRTEF.Visible=true;
					txtRTEF.Visible=true;
					lblInclinacion50.Visible=false;
					txtInclinacion50.Visible=false;
					lblArea.Visible		=false;
					txtArea.Visible		=false;
					lblCortante1.Visible=false;
					txtCortante1.Visible=false;
					lblCortante2.Visible=false;
					txtCortante2.Visible=false;
					lblAltMinCen.Visible=false;
					txtAltMinCen.Visible=false;
					lblAltMinCua.Visible=false;
					txtAltMinCua.Visible=false;
					lblCostilla.Visible=false;
					txtCostilla.Visible=false;
					lblSuma.Visible=false;
					txtSuma.Visible=false;
					lblAngulo.Visible=false;
					txtAngulo.Visible=false;
					lblCoeficiente.Visible=false;
					txtCoeficiente.Visible=false;
					break;
			}
		}
	}
}
