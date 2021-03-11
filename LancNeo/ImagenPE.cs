using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.IO;
using System.Data.SqlClient;

namespace LancNeo
{
    public partial class ImagenPE : CatalogoGenerico
    {
        private string IdUsuario;
        public ImagenPE()
        {
            InitializeComponent();
        }

        private void ImagenPE_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            sqlDAConcepto.Fill(dsConcepto1, "Concepto");
        }

        private void btnPROCESO_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.ShowReadOnly = true;
            dlgOpenFile.Filter = "Archivos PDF (*.pdf)|*.pdf";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                String NombreArchivo = "";
                String strFileNamePath = dlgOpenFile.FileName;
                String strSql = " Update ImagenPE Set Imagen = @Imagen";

                strSql += " From ImagenPE Where Folio = @IdFolio And IdConcepto = @IdConcepto And IdObra = @IdObra";
                FileStream fs = new FileStream(strFileNamePath, FileMode.Open);

                long FileLen = fs.Length;
                if (FileLen > 0)
                {
                    byte[] input = new byte[FileLen];
                    fs.Read(input, 0, Convert.ToInt32(FileLen));
                    sqlComGraba = new SqlCommand(strSql, sqlConn);

                    sqlComGraba.Parameters.Add("@Imagen", System.Data.SqlDbType.Image);
                    sqlComGraba.Parameters.Add("@IdFolio", System.Data.SqlDbType.Char, 10);
                    sqlComGraba.Parameters.Add("@IdConcepto", System.Data.SqlDbType.SmallInt);
                    sqlComGraba.Parameters.Add("@IdObra", System.Data.SqlDbType.NVarChar, 6);

                    sqlComGraba.Parameters["@Imagen"].Value = input;
                    sqlComGraba.Parameters["@IdFolio"].Value = txtFolio.Text;
                    sqlComGraba.Parameters["@IdConcepto"].Value = comboBox1.SelectedValue;
                    sqlComGraba.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;

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
                        MessageBox.Show(" Se incorporo el archivo ", "Proceso terminado.", 
    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
            }
        }

        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            cmbIdObra.SelectedIndex = -1;
            dtpFmuestreo.Value = DateTime.Now.AddDays(1);
            dtpFmuestreo.Value = DateTime.Today;
        }
        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            txtUsrMov.Text = IdUsuario;
            base.btnGuardar_Click(sender, e);
        }

        private void btnPROCESO_Load(object sender, EventArgs e)
        {

        }
    }
}
