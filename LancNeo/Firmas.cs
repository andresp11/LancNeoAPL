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
	/// Descripción breve de Firmas.
	/// </summary>
	public class Firmas : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsFirmas dsFirmas1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtIdFirma;
		private System.Windows.Forms.Label IdFirma;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCargo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbImprime;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private Label label12;
        private TextBox textBox9;
        private Label label13;
        private TextBox textBox10;
        private Label label14;
        private TextBox textBox11;
        private Label label15;
        private TextBox textBox12;
        private Label label16;
        private TextBox textBox13;
        private Label label17;
        private TextBox textBox14;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox8;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Firmas()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			ArrayList imprime =new ArrayList();
			imprime.Add(new matCombo1("Si",1));
			imprime.Add(new matCombo1("No",2));
			cmbImprime.DataSource = imprime; //DataSource for lookup table 
			cmbImprime.DisplayMember = "getName"; //Display value in lookup table
			cmbImprime.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firmas));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbImprime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.IdFirma = new System.Windows.Forms.Label();
            this.txtIdFirma = new System.Windows.Forms.TextBox();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 535);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(623, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(623, 64);
            // 
            // sqlDAFirmas
            // 
            this.sqlDAFirmas.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAFirmas.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAFirmas.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAFirmas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Firmas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdFirma", "IdFirma"),
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Cargo", "Cargo"),
                        new System.Data.Common.DataColumnMapping("Imprime", "Imprime"),
                        new System.Data.Common.DataColumnMapping("Concreto", "Concreto"),
                        new System.Data.Common.DataColumnMapping("Mortero", "Mortero"),
                        new System.Data.Common.DataColumnMapping("Acero", "Acero"),
                        new System.Data.Common.DataColumnMapping("Prefabricados", "Prefabricados"),
                        new System.Data.Common.DataColumnMapping("Grados", "Grados"),
                        new System.Data.Common.DataColumnMapping("Conector", "Conector"),
                        new System.Data.Common.DataColumnMapping("Toron", "Toron"),
                        new System.Data.Common.DataColumnMapping("Soldadura", "Soldadura"),
                        new System.Data.Common.DataColumnMapping("Moduloelastico", "Moduloelastico"),
                        new System.Data.Common.DataColumnMapping("Petreos", "Petreos"),
                        new System.Data.Common.DataColumnMapping("Materiales", "Materiales"),
                        new System.Data.Common.DataColumnMapping("PlacaAcero", "PlacaAcero"),
                        new System.Data.Common.DataColumnMapping("Volumetrica", "Volumetrica"),
                        new System.Data.Common.DataColumnMapping("Compactacion", "Compactacion")})});
            this.sqlDAFirmas.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdFirma", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdFirma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cargo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cargo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Imprime", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imprime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Concreto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Concreto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Concreto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concreto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mortero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Acero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Acero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Prefabricados", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Prefabricados", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Prefabricados", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prefabricados", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grados", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grados", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grados", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grados", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Conector", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Conector", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Conector", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Conector", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Toron", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Toron", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Toron", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Toron", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Soldadura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Soldadura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Soldadura", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Soldadura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Moduloelastico", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Moduloelastico", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Moduloelastico", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Moduloelastico", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Petreos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Petreos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Petreos", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Petreos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Materiales", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Materiales", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Materiales", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Materiales", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PlacaAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PlacaAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PlacaAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PlacaAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Volumetrica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Volumetrica", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Volumetrica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Volumetrica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Compactacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Compactacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Compactacion", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Compactacion", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@IdFirma", System.Data.SqlDbType.SmallInt, 0, "IdFirma"),
            new System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"),
            new System.Data.SqlClient.SqlParameter("@Cargo", System.Data.SqlDbType.VarChar, 0, "Cargo"),
            new System.Data.SqlClient.SqlParameter("@Imprime", System.Data.SqlDbType.SmallInt, 0, "Imprime"),
            new System.Data.SqlClient.SqlParameter("@Concreto", System.Data.SqlDbType.SmallInt, 0, "Concreto"),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.SmallInt, 0, "Mortero"),
            new System.Data.SqlClient.SqlParameter("@Acero", System.Data.SqlDbType.SmallInt, 0, "Acero"),
            new System.Data.SqlClient.SqlParameter("@Prefabricados", System.Data.SqlDbType.SmallInt, 0, "Prefabricados"),
            new System.Data.SqlClient.SqlParameter("@Grados", System.Data.SqlDbType.SmallInt, 0, "Grados"),
            new System.Data.SqlClient.SqlParameter("@Conector", System.Data.SqlDbType.SmallInt, 0, "Conector"),
            new System.Data.SqlClient.SqlParameter("@Toron", System.Data.SqlDbType.SmallInt, 0, "Toron"),
            new System.Data.SqlClient.SqlParameter("@Soldadura", System.Data.SqlDbType.SmallInt, 0, "Soldadura"),
            new System.Data.SqlClient.SqlParameter("@Moduloelastico", System.Data.SqlDbType.SmallInt, 0, "Moduloelastico"),
            new System.Data.SqlClient.SqlParameter("@Petreos", System.Data.SqlDbType.SmallInt, 0, "Petreos"),
            new System.Data.SqlClient.SqlParameter("@Materiales", System.Data.SqlDbType.SmallInt, 0, "Materiales"),
            new System.Data.SqlClient.SqlParameter("@PlacaAcero", System.Data.SqlDbType.SmallInt, 0, "PlacaAcero"),
            new System.Data.SqlClient.SqlParameter("@Volumetrica", System.Data.SqlDbType.SmallInt, 0, "Volumetrica"),
            new System.Data.SqlClient.SqlParameter("@Compactacion", System.Data.SqlDbType.SmallInt, 0, "Compactacion")});
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
            new System.Data.SqlClient.SqlParameter("@IdFirma", System.Data.SqlDbType.SmallInt, 0, "IdFirma"),
            new System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"),
            new System.Data.SqlClient.SqlParameter("@Cargo", System.Data.SqlDbType.VarChar, 0, "Cargo"),
            new System.Data.SqlClient.SqlParameter("@Imprime", System.Data.SqlDbType.SmallInt, 0, "Imprime"),
            new System.Data.SqlClient.SqlParameter("@Concreto", System.Data.SqlDbType.SmallInt, 0, "Concreto"),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.SmallInt, 0, "Mortero"),
            new System.Data.SqlClient.SqlParameter("@Acero", System.Data.SqlDbType.SmallInt, 0, "Acero"),
            new System.Data.SqlClient.SqlParameter("@Prefabricados", System.Data.SqlDbType.SmallInt, 0, "Prefabricados"),
            new System.Data.SqlClient.SqlParameter("@Grados", System.Data.SqlDbType.SmallInt, 0, "Grados"),
            new System.Data.SqlClient.SqlParameter("@Conector", System.Data.SqlDbType.SmallInt, 0, "Conector"),
            new System.Data.SqlClient.SqlParameter("@Toron", System.Data.SqlDbType.SmallInt, 0, "Toron"),
            new System.Data.SqlClient.SqlParameter("@Soldadura", System.Data.SqlDbType.SmallInt, 0, "Soldadura"),
            new System.Data.SqlClient.SqlParameter("@Moduloelastico", System.Data.SqlDbType.SmallInt, 0, "Moduloelastico"),
            new System.Data.SqlClient.SqlParameter("@Petreos", System.Data.SqlDbType.SmallInt, 0, "Petreos"),
            new System.Data.SqlClient.SqlParameter("@Materiales", System.Data.SqlDbType.SmallInt, 0, "Materiales"),
            new System.Data.SqlClient.SqlParameter("@PlacaAcero", System.Data.SqlDbType.SmallInt, 0, "PlacaAcero"),
            new System.Data.SqlClient.SqlParameter("@Volumetrica", System.Data.SqlDbType.SmallInt, 0, "Volumetrica"),
            new System.Data.SqlClient.SqlParameter("@Compactacion", System.Data.SqlDbType.SmallInt, 0, "Compactacion"),
            new System.Data.SqlClient.SqlParameter("@Original_IdFirma", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdFirma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cargo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cargo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Imprime", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imprime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Concreto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Concreto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Concreto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concreto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mortero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Acero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Acero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Prefabricados", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Prefabricados", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Prefabricados", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prefabricados", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grados", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grados", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grados", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grados", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Conector", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Conector", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Conector", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Conector", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Toron", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Toron", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Toron", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Toron", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Soldadura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Soldadura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Soldadura", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Soldadura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Moduloelastico", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Moduloelastico", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Moduloelastico", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Moduloelastico", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Petreos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Petreos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Petreos", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Petreos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Materiales", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Materiales", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Materiales", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Materiales", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PlacaAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PlacaAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PlacaAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PlacaAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Volumetrica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Volumetrica", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Volumetrica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Volumetrica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Compactacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Compactacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Compactacion", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Compactacion", System.Data.DataRowVersion.Original, null)});
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBox13);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBox14);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbImprime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCargo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.IdFirma);
            this.panel2.Controls.Add(this.txtIdFirma);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 441);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsFirmas1.Firmas;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(344, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Compactación:";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Compactacion", true));
            this.textBox9.Location = new System.Drawing.Point(424, 275);
            this.textBox9.MaxLength = 1;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(43, 20);
            this.textBox9.TabIndex = 35;
            this.textBox9.Text = "textBox9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Volumetrica:";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Volumetrica", true));
            this.textBox10.Location = new System.Drawing.Point(424, 249);
            this.textBox10.MaxLength = 1;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(43, 20);
            this.textBox10.TabIndex = 33;
            this.textBox10.Text = "textBox1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(383, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Placa:";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.PlacaAcero", true));
            this.textBox11.Location = new System.Drawing.Point(424, 223);
            this.textBox11.MaxLength = 1;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(43, 20);
            this.textBox11.TabIndex = 31;
            this.textBox11.Text = "textBox11";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(362, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Materiales:";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Materiales", true));
            this.textBox12.Location = new System.Drawing.Point(424, 197);
            this.textBox12.MaxLength = 1;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(43, 20);
            this.textBox12.TabIndex = 29;
            this.textBox12.Text = "textBox1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(374, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Petreos:";
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Petreos", true));
            this.textBox13.Location = new System.Drawing.Point(424, 171);
            this.textBox13.MaxLength = 1;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(43, 20);
            this.textBox13.TabIndex = 27;
            this.textBox13.Text = "textBox13";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(361, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "M. Elástico";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Moduloelastico", true));
            this.textBox14.Location = new System.Drawing.Point(424, 145);
            this.textBox14.MaxLength = 1;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(43, 20);
            this.textBox14.TabIndex = 25;
            this.textBox14.Text = "textBox1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Soldadura:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Soldadura", true));
            this.textBox5.Location = new System.Drawing.Point(424, 120);
            this.textBox5.MaxLength = 1;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 23;
            this.textBox5.Text = "textBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Toron:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Toron", true));
            this.textBox6.Location = new System.Drawing.Point(160, 275);
            this.textBox6.MaxLength = 1;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(43, 20);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "textBox6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Conector";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Conector", true));
            this.textBox7.Location = new System.Drawing.Point(160, 249);
            this.textBox7.MaxLength = 1;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(43, 20);
            this.textBox7.TabIndex = 19;
            this.textBox7.Text = "textBox1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Grados:";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Grados", true));
            this.textBox8.Location = new System.Drawing.Point(160, 223);
            this.textBox8.MaxLength = 1;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(43, 20);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "textBox8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Prefabricados:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Prefabricados", true));
            this.textBox3.Location = new System.Drawing.Point(160, 197);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "textBox1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Acero:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Acero", true));
            this.textBox4.Location = new System.Drawing.Point(160, 171);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "textBox4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mortero:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Mortero", true));
            this.textBox2.Location = new System.Drawing.Point(160, 145);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "textBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Concreto:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Concreto", true));
            this.textBox1.Location = new System.Drawing.Point(160, 119);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "textBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imprime:";
            // 
            // cmbImprime
            // 
            this.cmbImprime.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsFirmas1, "Firmas.Imprime", true));
            this.cmbImprime.DataSource = this.dsFirmas1.Firmas;
            this.cmbImprime.DisplayMember = "Imprime";
            this.cmbImprime.Location = new System.Drawing.Point(160, 92);
            this.cmbImprime.Name = "cmbImprime";
            this.cmbImprime.Size = new System.Drawing.Size(121, 21);
            this.cmbImprime.TabIndex = 6;
            this.cmbImprime.ValueMember = "Imprime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Cargo", true));
            this.txtCargo.Location = new System.Drawing.Point(160, 68);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(168, 20);
            this.txtCargo.TabIndex = 4;
            this.txtCargo.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(160, 44);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "OOOOOOOOOOOOOOOOOOOO";
            // 
            // IdFirma
            // 
            this.IdFirma.AutoSize = true;
            this.IdFirma.Location = new System.Drawing.Point(112, 24);
            this.IdFirma.Name = "IdFirma";
            this.IdFirma.Size = new System.Drawing.Size(44, 13);
            this.IdFirma.TabIndex = 1;
            this.IdFirma.Text = "IdFirma:";
            // 
            // txtIdFirma
            // 
            this.txtIdFirma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsFirmas1, "Firmas.IdFirma", true));
            this.txtIdFirma.Location = new System.Drawing.Point(160, 20);
            this.txtIdFirma.Name = "txtIdFirma";
            this.txtIdFirma.Size = new System.Drawing.Size(100, 20);
            this.txtIdFirma.TabIndex = 0;
            this.txtIdFirma.Text = "textBox1";
            // 
            // Firmas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(623, 557);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAFirmas;
            this.dsGeneral = this.dsFirmas1;
            this.Name = "Firmas";
            this.NombreTabla = "Firmas";
            this.Text = "Firmas";
            this.Load += new System.EventHandler(this.Firmas_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Firmas_Load(object sender, System.EventArgs e)
		{
			this.buscaBtn1.Catalogo = this;

		}

	}
}
