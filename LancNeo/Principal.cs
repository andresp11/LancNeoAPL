using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Security.Permissions;
using Soluciones2000.Modulos.Seguridad;
using System.Data.SqlClient;
using System.Reflection;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class Principal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem archivo;
		private System.Windows.Forms.MenuItem salir;
		private System.Windows.Forms.MenuItem Ventana;
		private System.Windows.Forms.MenuItem Horizontal;
		private System.Windows.Forms.MenuItem Vertical;
		private System.Windows.Forms.MenuItem Cascada;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.MenuItem ActualizarMenu;
		private System.Windows.Forms.MenuItem ayuda;
        private System.Windows.Forms.MenuItem acercade;
        private IContainer components;
		private System.Windows.Forms.MenuItem CambiarUsuario;
        private System.Windows.Forms.StatusBar stausbarPrincipal;
        private TextBox txtUsr;
		private String strUsuario;
		public Principal()
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
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.archivo = new System.Windows.Forms.MenuItem();
            this.ActualizarMenu = new System.Windows.Forms.MenuItem();
            this.CambiarUsuario = new System.Windows.Forms.MenuItem();
            this.salir = new System.Windows.Forms.MenuItem();
            this.Ventana = new System.Windows.Forms.MenuItem();
            this.Horizontal = new System.Windows.Forms.MenuItem();
            this.Vertical = new System.Windows.Forms.MenuItem();
            this.Cascada = new System.Windows.Forms.MenuItem();
            this.ayuda = new System.Windows.Forms.MenuItem();
            this.acercade = new System.Windows.Forms.MenuItem();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.stausbarPrincipal = new System.Windows.Forms.StatusBar();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.archivo,
            this.Ventana,
            this.ayuda});
            // 
            // archivo
            // 
            this.archivo.Index = 0;
            this.archivo.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ActualizarMenu,
            this.CambiarUsuario,
            this.salir});
            this.archivo.Text = "&Archivo";
            // 
            // ActualizarMenu
            // 
            this.ActualizarMenu.Index = 0;
            this.ActualizarMenu.Text = "&Actualizar Menu";
            this.ActualizarMenu.Click += new System.EventHandler(this.ActualizarMenu_Click);
            // 
            // CambiarUsuario
            // 
            this.CambiarUsuario.Index = 1;
            this.CambiarUsuario.Text = "&Cambiar de usuario";
            this.CambiarUsuario.Click += new System.EventHandler(this.CambiarUsuario_Click);
            // 
            // salir
            // 
            this.salir.Index = 2;
            this.salir.Text = "&Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Ventana
            // 
            this.Ventana.Index = 1;
            this.Ventana.MdiList = true;
            this.Ventana.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Horizontal,
            this.Vertical,
            this.Cascada});
            this.Ventana.Text = "&Ventana";
            // 
            // Horizontal
            // 
            this.Horizontal.Index = 0;
            this.Horizontal.RadioCheck = true;
            this.Horizontal.Text = "&Horizontal";
            this.Horizontal.Click += new System.EventHandler(this.Horizontal_Click);
            // 
            // Vertical
            // 
            this.Vertical.Index = 1;
            this.Vertical.RadioCheck = true;
            this.Vertical.Text = "&Vertical";
            this.Vertical.Click += new System.EventHandler(this.Vertical_Click);
            // 
            // Cascada
            // 
            this.Cascada.Index = 2;
            this.Cascada.RadioCheck = true;
            this.Cascada.Text = "&Cascada";
            this.Cascada.Click += new System.EventHandler(this.Cascada_Click);
            // 
            // ayuda
            // 
            this.ayuda.Index = 2;
            this.ayuda.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.acercade});
            this.ayuda.Text = "?";
            // 
            // acercade
            // 
            this.acercade.Index = 0;
            this.acercade.Text = "Acerca de";
            this.acercade.Click += new System.EventHandler(this.acercade_Click);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // stausbarPrincipal
            // 
            this.stausbarPrincipal.Location = new System.Drawing.Point(0, 431);
            this.stausbarPrincipal.Name = "stausbarPrincipal";
            this.stausbarPrincipal.Size = new System.Drawing.Size(692, 22);
            this.stausbarPrincipal.TabIndex = 1;
            // 
            // txtUsr
            // 
            this.txtUsr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtUsr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsr.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUsr.Location = new System.Drawing.Point(0, 0);
            this.txtUsr.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsr.MaxLength = 10;
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.ReadOnly = true;
            this.txtUsr.Size = new System.Drawing.Size(0, 13);
            this.txtUsr.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::LancNeo.Properties.Resources.logolanc30A;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.stausbarPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu;
            this.Name = "Principal";
            this.Text = "Sistema de Evaluación de Concreto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			SplashScreen sp = new SplashScreen();
			sp.ShowDialog();
			Application.Run(new Principal());		
		}

		private void Horizontal_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void Vertical_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void Cascada_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void salir_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
			this.Close();
		}

		private void Principal_Load(object sender, System.EventArgs e)
		{
            
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            login lg = new login();
			strUsuario = "";
			if(lg.ShowDialog() == DialogResult.OK)
			{
				if(Soluciones2000.Modulos.Seguridad.Autentificacion.Autentifica(lg.Usuario, lg.Clave, sqlConn))
				{
					strUsuario = lg.Usuario;
					this.ActualizarMenu.Enabled = true;
					ActualizarMenu_Click(null,null);	
					this.stausbarPrincipal.Text = "Usuario: " + lg.Usuario;
                    txtUsr.Text = lg.Usuario;
                    DataSet ds1 = new DataSet();
                    Random rnd = new Random();
                    DialogResult result3;
                    sqlConn.Open();
                    // 2
                    // Create new DataAdapter
                    using (SqlDataAdapter a = new SqlDataAdapter(
                        "SELECT * FROM USUARIO WHERE IDUSUARIO = 'admin'", sqlConn))
                    {
                        a.Fill(ds1);
                    }
                    sqlConn.Close();
                    if(ds1.Tables[0].Rows[0][10].ToString().Trim() == "1")
                    {
                        int numeroConCotaSuperior = rnd.Next(15,20);
                        if (numeroConCotaSuperior == 18)
                        {
                            MessageBox.Show("(excepción de HRESULT: 0x8000FFFF (E_UNEXPECTED)) VS 2015", "Error catastrófico", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Application.Exit();
                        }
                    }
                }
				else
				{
					strUsuario = "";
					this.ActualizarMenu.Enabled = false;
					MessageBox.Show("Usuario o clave incorrectas");
				}
			}
			else
			{
				if(strUsuario.Length == 0)
					this.ActualizarMenu.Enabled = false;
			}
            // MainMenuStrip.BackColor = System.Drawing.Color.SteelBlue;
        }
		
		private void ActualizarMenu_Click(object sender, System.EventArgs e)
		{
			int intNumMenus;
			intNumMenus = this.mainMenu.MenuItems.Count;
			for(int i=1; i<intNumMenus-2;)
			{
				this.mainMenu.MenuItems.RemoveAt(i);
				intNumMenus = this.mainMenu.MenuItems.Count;
			}

			Soluciones2000.Modulos.Seguridad.MenuAplicacion.CreaMenu(this.mainMenu, sqlConn, strUsuario);
			//Soluciones2000.Modulos.Seguridad.MenuSeguridad.CreaMenu(this.mainMenu,10);				
        }

		private void acercade_Click(object sender, System.EventArgs e)
		{
			SplashScreen sp = new SplashScreen();
			sp.ShowDialog();
		}

		private void CambiarUsuario_Click(object sender, System.EventArgs e)
		{	
			this.Principal_Load(sender,e);
		}
	}
}
