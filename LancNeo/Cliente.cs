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
	/// Descripción breve de Cliente.
	/// </summary>
	public class Cliente : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel2;
		private System.Data.SqlClient.SqlDataAdapter sqlDACliente;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsCliente dsCliente1;
		private System.Windows.Forms.TextBox txtIdCliente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label label2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox txtDirección;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDiasr;
        private System.Windows.Forms.Label label13;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusCliente;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsBusCliente dsBusCliente1;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private TextBox textBox8;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Cliente()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
            //ArrayList revision =new ArrayList();
            //revision.Add(new matCombo1("Oficina",1));
            //revision.Add(new matCombo1("Obra",2));
            //cmbRevision.DataSource = revision; //DataSource for lookup table 
            //cmbRevision.DisplayMember = "getName"; //Display value in lookup table
            //cmbRevision.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusCliente1 = new LancNeo.dsBusCliente();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dsCliente1 = new LancNeo.dsCliente();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiasr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.sqlDACliente = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusCliente = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusCliente1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCliente1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 309);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(576, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(576, 64);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtDiasr);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtColonia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDirección);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIdCliente);
            this.panel2.Location = new System.Drawing.Point(8, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 230);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 600;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusCliente1.cliente;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(228, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 4;
            // 
            // dsBusCliente1
            // 
            this.dsBusCliente1.DataSetName = "dsBusCliente";
            this.dsBusCliente1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusCliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCliente1, "cliente.Pago", true));
            this.textBox8.Location = new System.Drawing.Point(450, 159);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(0, 20);
            this.textBox8.TabIndex = 78;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // dsCliente1
            // 
            this.dsCliente1.DataSetName = "dsCliente";
            this.dsCliente1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsCliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(140, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 31);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton5.ForeColor = System.Drawing.Color.White;
            this.radioButton5.Location = new System.Drawing.Point(73, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(76, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "PAQUETE";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(11, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "P. U.";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "N°:";
            // 
            // txtDiasr
            // 
            this.txtDiasr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCliente1, "cliente.diasr", true));
            this.txtDiasr.Location = new System.Drawing.Point(140, 155);
            this.txtDiasr.MaxLength = 50;
            this.txtDiasr.Name = "txtDiasr";
            this.txtDiasr.Size = new System.Drawing.Size(320, 20);
            this.txtDiasr.TabIndex = 6;
            this.txtDiasr.Text = "textBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Colonia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtColonia
            // 
            this.txtColonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCliente1, "cliente.Colonia", true));
            this.txtColonia.Location = new System.Drawing.Point(140, 122);
            this.txtColonia.MaxLength = 50;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(320, 20);
            this.txtColonia.TabIndex = 9;
            this.txtColonia.Text = "textBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDirección
            // 
            this.txtDirección.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCliente1, "cliente.Direccion", true));
            this.txtDirección.Location = new System.Drawing.Point(140, 98);
            this.txtDirección.MaxLength = 50;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(320, 20);
            this.txtDirección.TabIndex = 7;
            this.txtDirección.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCliente
            // 
            this.txtCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCliente1, "cliente.Cliente", true));
            this.txtCliente.Location = new System.Drawing.Point(140, 64);
            this.txtCliente.MaxLength = 80;
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(320, 32);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.Text = "0123456789012345678901234567890123456789";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdCliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCliente1, "cliente.IdCliente", true));
            this.txtIdCliente.Location = new System.Drawing.Point(140, 24);
            this.txtIdCliente.MaxLength = 4;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(32, 20);
            this.txtIdCliente.TabIndex = 0;
            this.txtIdCliente.Text = "textBox1";
            // 
            // sqlDACliente
            // 
            this.sqlDACliente.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDACliente.InsertCommand = this.sqlInsertCommand1;
            this.sqlDACliente.SelectCommand = this.sqlSelectCommand1;
            this.sqlDACliente.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "cliente", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("diasr", "diasr"),
                        new System.Data.Common.DataColumnMapping("Pago", "Pago")})});
            this.sqlDACliente.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdCliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_diasr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "diasr", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_diasr", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "diasr", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pago", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pago", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pago", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pago", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.NVarChar, 0, "Cliente"),
            new System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.NVarChar, 0, "Direccion"),
            new System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.NVarChar, 0, "Colonia"),
            new System.Data.SqlClient.SqlParameter("@diasr", System.Data.SqlDbType.NVarChar, 0, "diasr"),
            new System.Data.SqlClient.SqlParameter("@Pago", System.Data.SqlDbType.SmallInt, 0, "Pago")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        IdCliente, Cliente, Direccion, Colonia, diasr, Pago\r\nFROM          " +
    "  cliente";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdCliente", System.Data.SqlDbType.NVarChar, 0, "IdCliente"),
            new System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.NVarChar, 0, "Cliente"),
            new System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.NVarChar, 0, "Direccion"),
            new System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.NVarChar, 0, "Colonia"),
            new System.Data.SqlClient.SqlParameter("@diasr", System.Data.SqlDbType.NVarChar, 0, "diasr"),
            new System.Data.SqlClient.SqlParameter("@Pago", System.Data.SqlDbType.SmallInt, 0, "Pago"),
            new System.Data.SqlClient.SqlParameter("@Original_IdCliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colonia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_diasr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "diasr", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_diasr", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "diasr", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pago", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pago", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pago", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pago", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDABusCliente
            // 
            this.sqlDABusCliente.SelectCommand = this.sqlSelectCommand2;
            this.sqlDABusCliente.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "cliente", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdCliente, Cliente, Direccion FROM cliente";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // Cliente
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 331);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDACliente;
            this.dsGeneral = this.dsCliente1;
            this.Name = "Cliente";
            this.NombreTabla = "cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusCliente1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCliente1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void Cliente_Load(object sender, System.EventArgs e)
		{
			sqlDABusCliente.Fill(dsBusCliente1, "Cliente");
			this.buscaBtn1.Catalogo = this;
			EstableceVistaPrevia();
		}
		private void EstableceVistaPrevia()
		{
			DataSet dsVP = new DataSet();
			sqlDABusCliente.Fill(dsVP, "Cliente");
			dsVistaPrevia = dsVP;
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


	}
}
