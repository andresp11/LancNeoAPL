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
	/// Descripción breve de Conec60Esp.
	/// </summary>
	public class Conec60Esp : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Data.SqlClient.SqlDataAdapter sqlDAConecEsp;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.Panel panel2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtEsMax;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEsLE;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEspec;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label1;
		private LancNeo.dsConecEsp dsConecEsp1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAcero;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsAcero dsAcero1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConceRes;
		private System.Windows.Forms.ComboBox cmbNumero;
		private System.Windows.Forms.Label label3;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label9;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private DataGridView dgConecRes;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especificaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn juntaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fallaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaFLUDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaMAXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoFLUDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coladaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private TextBox txtUsrMov;
        private Label label59;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Conec60Esp()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conec60Esp));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlDAConecEsp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsConecEsp1 = new LancNeo.dsConecEsp();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.dsAcero1 = new LancNeo.dsAcero();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEsMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEsLE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDAAcero = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConceRes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgConecRes = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juntaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaFLUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaMAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoFLUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConecEsp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConecRes)).BeginInit();
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
            // sqlDAConecEsp
            // 
            this.sqlDAConecEsp.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAConecEsp.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAConecEsp.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAConecEsp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ConecEsp", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Aci", "Aci"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoFLU", "EsfuerzoFLU"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMAX", "EsfuerzoMAX"),
                        new System.Data.Common.DataColumnMapping("AciI", "AciI"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoFLU1", "EsfuerzoFLU1"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMAX1", "EsfuerzoMAX1"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAConecEsp.UpdateCommand = this.sqlUpdateCommand1;
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Aci", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Aci", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Aci", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Aci", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoFLU", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AciI", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AciI", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AciI", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AciI", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoFLU1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoFLU1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoFLU1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoMAX1", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@Aci", System.Data.SqlDbType.NVarChar, 0, "Aci"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoMAX", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AciI", System.Data.SqlDbType.NVarChar, 0, "AciI"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoFLU1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoMAX1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        FOLIO, Especifica, Numero, Aci, EsfuerzoFLU, EsfuerzoMAX, AciI, Esf" +
    "uerzoFLU1, EsfuerzoMAX1, IdUsuario\r\nFROM            ConecEsp\r\nORDER BY FOLIO, Es" +
    "pecifica";
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
            new System.Data.SqlClient.SqlParameter("@Aci", System.Data.SqlDbType.NVarChar, 0, "Aci"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoMAX", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AciI", System.Data.SqlDbType.NVarChar, 0, "AciI"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoFLU1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoMAX1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Numero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Aci", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Aci", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Aci", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Aci", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoFLU", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AciI", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AciI", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AciI", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AciI", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoFLU1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoFLU1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoFLU1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(1)), "EsfuerzoMAX1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmbNumero);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtEsMax);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEsLE);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtGrado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEspec);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 72);
            this.panel2.TabIndex = 5;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsConecEsp1.ConecEsp;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(118, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 32;
            // 
            // dsConecEsp1
            // 
            this.dsConecEsp1.DataSetName = "dsConecEsp";
            this.dsConecEsp1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConecEsp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.EsfuerzoMAX1", true));
            this.textBox1.Location = new System.Drawing.Point(782, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = "textBox6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Esfuerzo maximo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.EsfuerzoFLU1", true));
            this.textBox2.Location = new System.Drawing.Point(646, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.Text = "textBox5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Esfuerzo LE:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.AciI", true));
            this.textBox3.Location = new System.Drawing.Point(442, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "textBox3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Norma 2):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbNumero
            // 
            this.cmbNumero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsConecEsp1, "ConecEsp.Numero", true));
            this.cmbNumero.DataSource = this.dsAcero1.Acero;
            this.cmbNumero.DisplayMember = "Numero";
            this.cmbNumero.Location = new System.Drawing.Point(286, 44);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(80, 21);
            this.cmbNumero.TabIndex = 37;
            this.cmbNumero.ValueMember = "Numero";
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
            this.label3.Location = new System.Drawing.Point(231, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Diámetro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gold;
            this.label22.Location = new System.Drawing.Point(844, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Especificación";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(790, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = " (Kg/cm²)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(654, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = " (Kg/cm²)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsMax
            // 
            this.txtEsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.EsfuerzoMAX", true));
            this.txtEsMax.Location = new System.Drawing.Point(782, 16);
            this.txtEsMax.Name = "txtEsMax";
            this.txtEsMax.Size = new System.Drawing.Size(56, 20);
            this.txtEsMax.TabIndex = 13;
            this.txtEsMax.Text = "textBox6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Esfuerzo maximo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsLE
            // 
            this.txtEsLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.EsfuerzoFLU", true));
            this.txtEsLE.Location = new System.Drawing.Point(646, 16);
            this.txtEsLE.Name = "txtEsLE";
            this.txtEsLE.Size = new System.Drawing.Size(56, 20);
            this.txtEsLE.TabIndex = 11;
            this.txtEsLE.Text = "textBox5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(586, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esfuerzo LE:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrado
            // 
            this.txtGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.Aci", true));
            this.txtGrado.Location = new System.Drawing.Point(442, 16);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(120, 20);
            this.txtGrado.TabIndex = 7;
            this.txtGrado.Text = "ACI-3185-08";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Norma 1):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEspec
            // 
            this.txtEspec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.Especifica", true));
            this.txtEspec.Location = new System.Drawing.Point(286, 16);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(24, 20);
            this.txtEspec.TabIndex = 3;
            this.txtEspec.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Especificación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(62, 14);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(48, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.sqlSelectCommand2.CommandText = "SELECT Numero, Nominal, Milimetros, Clasificacion FROM Acero ORDER BY Numero";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDAConceRes
            // 
            this.sqlDAConceRes.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAConceRes.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAConceRes.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAConceRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ConceRes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Junta", "Junta"),
                        new System.Data.Common.DataColumnMapping("Falla", "Falla"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("CargaFLU", "CargaFLU"),
                        new System.Data.Common.DataColumnMapping("CargaMAX", "CargaMAX"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoFLU", "EsfuerzoFLU"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMax", "EsfuerzoMax"),
                        new System.Data.Common.DataColumnMapping("Colada", "Colada"),
                        new System.Data.Common.DataColumnMapping("Remesa", "Remesa"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            this.sqlDAConceRes.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMAX", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Falla", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Falla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Junta", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Junta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 10, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 12, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Junta", System.Data.SqlDbType.VarChar, 10, "Junta"),
            new System.Data.SqlClient.SqlParameter("@Falla", System.Data.SqlDbType.VarChar, 100, "Falla"),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMAX", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMAX", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.NVarChar, 12, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.NVarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 50, "Observaciones")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT FOLIO, Especifica, Muestra, Numero, Grado, Junta, Falla, Area, CargaFLU, C" +
    "argaMAX, EsfuerzoFLU, EsfuerzoMax, Colada, Remesa, Observaciones FROM ConceRes O" +
    "RDER BY FOLIO, Especifica, Muestra";
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
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 10, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 12, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Junta", System.Data.SqlDbType.VarChar, 10, "Junta"),
            new System.Data.SqlClient.SqlParameter("@Falla", System.Data.SqlDbType.VarChar, 100, "Falla"),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMAX", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMAX", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoFLU", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.NVarChar, 12, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.NVarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 50, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMAX", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoFLU", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoFLU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Falla", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Falla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Junta", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Junta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null)});
            // 
            // dgConecRes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgConecRes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConecRes.AutoGenerateColumns = false;
            this.dgConecRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConecRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.especificaDataGridViewTextBoxColumn,
            this.muestraDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn,
            this.juntaDataGridViewTextBoxColumn,
            this.fallaDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.cargaFLUDataGridViewTextBoxColumn,
            this.cargaMAXDataGridViewTextBoxColumn,
            this.esfuerzoFLUDataGridViewTextBoxColumn,
            this.esfuerzoMaxDataGridViewTextBoxColumn,
            this.coladaDataGridViewTextBoxColumn,
            this.remesaDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgConecRes.DataMember = "ConecEsp.Conce";
            this.dgConecRes.DataSource = this.dsConecEsp1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgConecRes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgConecRes.Location = new System.Drawing.Point(0, 142);
            this.dgConecRes.Name = "dgConecRes";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgConecRes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgConecRes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgConecRes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgConecRes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgConecRes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgConecRes.Size = new System.Drawing.Size(1016, 336);
            this.dgConecRes.TabIndex = 8;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            this.fOLIODataGridViewTextBoxColumn.Visible = false;
            // 
            // especificaDataGridViewTextBoxColumn
            // 
            this.especificaDataGridViewTextBoxColumn.DataPropertyName = "Especifica";
            this.especificaDataGridViewTextBoxColumn.HeaderText = "Especifica";
            this.especificaDataGridViewTextBoxColumn.Name = "especificaDataGridViewTextBoxColumn";
            this.especificaDataGridViewTextBoxColumn.Visible = false;
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "Grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "Grado";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            // 
            // juntaDataGridViewTextBoxColumn
            // 
            this.juntaDataGridViewTextBoxColumn.DataPropertyName = "Junta";
            this.juntaDataGridViewTextBoxColumn.HeaderText = "Junta";
            this.juntaDataGridViewTextBoxColumn.Name = "juntaDataGridViewTextBoxColumn";
            // 
            // fallaDataGridViewTextBoxColumn
            // 
            this.fallaDataGridViewTextBoxColumn.DataPropertyName = "Falla";
            this.fallaDataGridViewTextBoxColumn.HeaderText = "Falla";
            this.fallaDataGridViewTextBoxColumn.Name = "fallaDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // cargaFLUDataGridViewTextBoxColumn
            // 
            this.cargaFLUDataGridViewTextBoxColumn.DataPropertyName = "CargaFLU";
            this.cargaFLUDataGridViewTextBoxColumn.HeaderText = "CargaFLU";
            this.cargaFLUDataGridViewTextBoxColumn.Name = "cargaFLUDataGridViewTextBoxColumn";
            // 
            // cargaMAXDataGridViewTextBoxColumn
            // 
            this.cargaMAXDataGridViewTextBoxColumn.DataPropertyName = "CargaMAX";
            this.cargaMAXDataGridViewTextBoxColumn.HeaderText = "CargaMAX";
            this.cargaMAXDataGridViewTextBoxColumn.Name = "cargaMAXDataGridViewTextBoxColumn";
            // 
            // esfuerzoFLUDataGridViewTextBoxColumn
            // 
            this.esfuerzoFLUDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoFLU";
            this.esfuerzoFLUDataGridViewTextBoxColumn.HeaderText = "EsfuerzoFLU";
            this.esfuerzoFLUDataGridViewTextBoxColumn.Name = "esfuerzoFLUDataGridViewTextBoxColumn";
            // 
            // esfuerzoMaxDataGridViewTextBoxColumn
            // 
            this.esfuerzoMaxDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn.HeaderText = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn.Name = "esfuerzoMaxDataGridViewTextBoxColumn";
            // 
            // coladaDataGridViewTextBoxColumn
            // 
            this.coladaDataGridViewTextBoxColumn.DataPropertyName = "Colada";
            this.coladaDataGridViewTextBoxColumn.HeaderText = "Colada";
            this.coladaDataGridViewTextBoxColumn.Name = "coladaDataGridViewTextBoxColumn";
            // 
            // remesaDataGridViewTextBoxColumn
            // 
            this.remesaDataGridViewTextBoxColumn.DataPropertyName = "Remesa";
            this.remesaDataGridViewTextBoxColumn.HeaderText = "Remesa";
            this.remesaDataGridViewTextBoxColumn.Name = "remesaDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsConecEsp1, "ConecEsp.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(920, 45);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 72;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Red;
            this.label59.Location = new System.Drawing.Point(859, 49);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(54, 13);
            this.label59.TabIndex = 71;
            this.label59.Text = "Usuario:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Conec60Esp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1016, 533);
            this.Controls.Add(this.dgConecRes);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAConecEsp;
            this.dsGeneral = this.dsConecEsp1;
            this.Name = "Conec60Esp";
            this.NombreTabla = "ConecEsp";
            this.Text = "Conec60Esp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Conec60Esp_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgConecRes, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConecEsp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConecRes)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Conec60Esp_Load(object sender, System.EventArgs e)
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

		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsConecEsp1,"ConecEsp"].Position = this.BindingContext[dsConecEsp1,"ConecEsp"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsConecEsp1.Tables["ConceRes"].Clear();
			sqlDAConceRes.Fill(dsConecEsp1,"ConceRes");
		}

		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			txtGrado.Text="ACI-3185-08";
		}

		public override void LoadDataSet()
		{

			//			sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			base.LoadDataSet();
			//dgConecRes.SetDataBinding(dsConecEsp1, "ConecEsp.Conce");
			//string apl = dgConecRes.TableStyles.ToString();
			dsConecEsp1.Tables["ConceRes"].Clear();
			sqlDAConceRes.Fill(dsConecEsp1,"ConceRes");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsConecEsp objDataSetChanges = new LancNeo.dsConecEsp();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsConecEsp1,"ConecEsp"].EndCurrentEdit();
			this.BindingContext[dsConecEsp1,"ConceRes"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsConecEsp)(dsConecEsp1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsConecEsp1.Merge(objDataSetChanges);
					dsConecEsp1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsConecEsp ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAConecEsp.Update(ChangedRows);
					sqlDAConceRes.Update(ChangedRows);
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

		private void label9_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}
