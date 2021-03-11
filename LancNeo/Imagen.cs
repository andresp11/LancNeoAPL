using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace LancNeo
{
    public partial class Imagen : CatalogoGenerico
    {
        private string IdUsuario;
        public Imagen()
        {
            InitializeComponent();
        }

        private void Imagen_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            dsTipInf1.Informe.AddInformeRow(0, "Inspección Visual");
            dsTipInf1.Informe.AddInformeRow(1, "Ultrasonido");
            dsTipInf1.Informe.AddInformeRow(2, "Calificación de Soldadura");
            dsTipInf1.Informe.AddInformeRow(3, "Liquidos penetrantes");
            dsTipInf1.Informe.AddInformeRow(4, "Radiografía");
//            dsTipInf1.Informe.AddInformeRow(5, "Radiografía");
            dsNorma1.Normas.AddNormasRow(0, "Visita", "");
            dsNorma1.Normas.AddNormasRow(1, "Semana", "");

            buscaBtn1.Catalogo = this;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
        }

        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            cmbIdObra.SelectedIndex = -1;
            dtpFmuestreo.Value = DateTime.Now.AddDays(1);
            dtpFmuestreo.Value = DateTime.Today;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPROCESO_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.ShowReadOnly = true;
            dlgOpenFile.Filter = "Archivos PDF (*.pdf)|*.pdf";
            if(dlgOpenFile.ShowDialog() == DialogResult.OK)
			{
                String NombreArchivo = "";
                String strFileNamePath = dlgOpenFile.FileName;
                String strSql = " Update Imagen Set Imagen = @Imagen";
                
                strSql += " From Imagen Where Folio = @IdFolio And Tipo = @Tipo";
                FileStream fs = new FileStream(strFileNamePath,FileMode.Open);
                
                long FileLen = fs.Length;
                if (FileLen > 0)
                {
                    byte[] input = new byte[FileLen];
                    fs.Read(input,0,Convert.ToInt32(FileLen));
                    sqlComGraba= new SqlCommand(strSql,sqlConn);
                    
                    sqlComGraba.Parameters.Add("@Imagen", System.Data.SqlDbType.Image);
                    sqlComGraba.Parameters.Add("@IdFolio", System.Data.SqlDbType.Char,10);
                    sqlComGraba.Parameters.Add("@Tipo", System.Data.SqlDbType.SmallInt);

                    sqlComGraba.Parameters["@Imagen"].Value = input;
                    sqlComGraba.Parameters["@IdFolio"].Value = txtFolio.Text;
                    sqlComGraba.Parameters["@Tipo"].Value = comboBox1.SelectedIndex;

                    try
                    {
                        sqlConn.Open();
                        sqlComGraba.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    finally
                    {
                        if (sqlConn.State == ConnectionState.Open)
                        {
                            sqlConn.Close();
                        }
                    fs.Close();
                    }

                }
                
            } 

          
            
        }

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            txtUsrMov.Text = IdUsuario;
            base.btnGuardar_Click(sender, e);
        }
    }
}
