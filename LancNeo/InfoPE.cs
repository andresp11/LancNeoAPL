using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;

namespace LancNeo
{
    public partial class InfoPE : Form
    {
        public InfoPE()
        {
            InitializeComponent();
        }

        private void InfoPE_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    txtUsrMov.Text = MyControl.Text;
            }
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
            cmbIdObra.SelectedIndex = 0;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            cmbIdObra_SelectedIndexChanged(sender, null);
        }

        private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dsBusImagen1.Clear();
            sqlDABusImagen.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
            sqlDABusImagen.Fill(dsBusImagen1, "Imagen");
            if (txtUsrMov.Text.Trim().ToUpper() == "ALFREDO" || txtUsrMov.Text.Trim().ToUpper() == "JULIO" || txtUsrMov.Text.Trim().ToUpper() == "ADMIN")
                btnPROCESO.Visible = true;
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            string nombre = " ";
            if (dsBusImagen1.Tables[0].Rows.Count > 0)
            {

                int fila = dataGridView1.CurrentRow.Index;
                byte[] midato = new byte[0];
                DataRow renglon;
                renglon = dsBusImagen1.Tables[0].Rows[fila];
                midato = (byte[])renglon["Imagen"];
                MemoryStream mem = new MemoryStream(midato);

                int ArraySize = new int();
                ArraySize = midato.GetUpperBound(0);

                nombre = dsBusImagen1.Tables[0].Rows[fila][5].ToString().Trim();
                FileStream fs = new FileStream(@"C:\Users\Public\Downloads\" + nombre + " .Pdf", FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(midato, 0, ArraySize);
                fs.Close();
                string ruta = @"C:\Users\Public\Downloads\" + nombre + " .Pdf";
                Process P = new Process();
                try
                {
                    P.StartInfo.FileName = ruta;
                    P.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    P.Start();
                    //Espera el proceso para que lo termine y continuar 
                    P.WaitForExit();
                    //Liberar 
                    P.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " No se puede abrir el documento " + ruta, "Error");
                }

            }
        }

        private void btnPROCESO_Click(object sender, EventArgs e)
        {
            string nombre = " ";
            string nombre1 = " ";
            string nombre2 = " ";
            folderBrowserDialog1.SelectedPath = @"Bibliotecas\Documentos";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int fila = 0; fila < dsBusImagen1.Tables[0].Rows.Count; fila++)
                {
                    byte[] midato = new byte[0];
                    DataRow renglon;
                    renglon = dsBusImagen1.Tables[0].Rows[fila];
                    try
                    {
                        midato = (byte[])renglon["Imagen"];
                        MemoryStream mem = new MemoryStream(midato);

                        if (mem != null)
                        {
                            int ArraySize = new int();
                            ArraySize = midato.GetUpperBound(0);

                            nombre = dsBusImagen1.Tables[0].Rows[fila][5].ToString().Trim();
                            nombre1 = dsBusImagen1.Tables[0].Rows[fila][6].ToString().Trim().Replace("/", "-");
                            nombre2 = cmbIdObra.SelectedValue.ToString().Replace("/", "-");
                            nombre2 = nombre2.Replace("\\", "-");

                            FileStream fs = new FileStream(folderBrowserDialog1.SelectedPath.ToString() + "\\" + nombre2.Trim() + nombre.Trim() + nombre1 + ".Pdf", FileMode.OpenOrCreate, FileAccess.Write);
                            fs.Write(midato, 0, ArraySize);
                            fs.Close();
                            fs.Dispose();
                            mem.Dispose();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Esta vacio el documento:" + dsBusImagen1.Tables[0].Rows[fila][6].ToString().Trim() +
                        System.Environment.NewLine + System.Environment.NewLine, "Problemas con la exportación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //                    string ruta = @"C:\Users\Public\Downloads\" + nombre + " .Pdf";
                }
                MessageBox.Show("Se encuentra en:" + folderBrowserDialog1.SelectedPath.ToString() +
                    System.Environment.NewLine + System.Environment.NewLine, "Termino la exportación de archvios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



    }
}
