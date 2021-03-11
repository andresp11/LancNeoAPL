using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace LancNeo
{
    public partial class IncFactura : Form
    {
        private DataTable dataTables = new DataTable();
        public IncFactura()
        {
            InitializeComponent();
        }

        private void btSelExc_Click(object sender, EventArgs e)
        {
            dlAbrir.CheckFileExists = true;
            dlAbrir.CheckPathExists = true;
            dlAbrir.Multiselect = false;
            dlAbrir.DefaultExt = "pdf";
            dlAbrir.FileName = "";
            dlAbrir.Filter = "File XLS (*.xlsx)|*.xlsx|All the files (*.*)|*.*";
            dlAbrir.Title = "Seleccione el archivo de excel a incorporar";
            if (dlAbrir.ShowDialog() == DialogResult.OK)
            {
                txtFicheroPDFOrigen.Text = dlAbrir.FileName;
            }
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaFicheroPDFOrigenDividir = txtFicheroPDFOrigen.Text;

                if (!File.Exists(rutaFicheroPDFOrigenDividir))
                {
                    MessageBox.Show("El archivo origen de excel no existe.", " XLSX El arrchivo de excel no existe ",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFicheroPDFOrigen.Focus();
                }
                else
                {
                    ReadAsDataTable(txtFicheroPDFOrigen.Text);
                    MessageBox.Show("Termino la incorporación de las facturas." +
                    System.Environment.NewLine + System.Environment.NewLine , "Proceso finalizado exitosamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception errorM)
            {
                MessageBox.Show("Error durante la incorporación de las facturas." +
                    System.Environment.NewLine + System.Environment.NewLine +
                    errorM.Message, "Error incorporando el archivo XLSX",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadAsDataTable(string fileName)
        {

            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();

                //foreach (Cell cell in rows.ElementAt(0))
                //{
                //    dataTables.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                //}
                int renglon = 0;
                string[] fac = new string[16];
                string[] Cob = new string[7];

                bool facturas = false;
                foreach (Row row in rows)
                {
                    DataRow dataRow = dataTables.NewRow();
                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                    {
                        if (GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i)) == "NCFI")
                        {
                            facturas = false;
                            renglon = 99999;
                        }
                        if (GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i)) == "FACI")
                        {
                            facturas = true;
                            fac[1] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                            fac[0] = fac[2] = fac[3] = fac[4] = fac[5] = fac[6] = fac[7] = fac[8] = fac[9] = fac[10] = fac[11] = fac[12] = fac[13] = "";
                            renglon = 1;
                        }
                        else
                        {
                            if (renglon == 1 && facturas)
                            {
                                switch (i)
                                {
                                    case 2:
                                        fac[0] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 3:
                                        fac[2] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 4:
                                        fac[3] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 5:
                                        fac[4] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 6:
                                        fac[5] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 7:
                                        fac[6] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 9:
                                        fac[7] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 10:
                                        fac[8] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 12:
                                        //if (fac[0] == "00005132")
                                            //renglon = renglon;
                                        fac[12] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        fac[12] = (fac[12].IndexOf("E") > 0 ? "0" : fac[12]);
                                        break;
                                    case 13:
                                        fac[13] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    default:
                                        //                                        Console.WriteLine("Default case");
                                        break;
                                }
                            }
                            if (renglon == 2 && facturas && i == 2)
                                fac[9] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                            if (renglon > 2 && facturas)
                            {
                                switch (i)
                                {
                                    case 1:
                                        Cob[0] = fac[0];
                                        Cob[1] = (renglon - 3).ToString();
                                        break;
                                    case 5:
                                        Cob[2] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 7:
                                        Cob[3] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    case 12:
                                        Cob[6] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                                        break;
                                    default:
                                        //                                        Console.WriteLine("Default case");
                                        break;
                                }
                            }
                        }
                        if (facturas == false)
                            break;
                    }
                    if (facturas == true && renglon == 2)
                    {

                        
                        sqlComInserta.Parameters["@Numdoc"].Value = fac[0];
                        sqlComInserta.Parameters["@TipoDoc"].Value = fac[1];
                        sqlComInserta.Parameters["@Fecha"].Value = fac[2];
                        sqlComInserta.Parameters["@Recepcion"].Value = fac[3];
                        sqlComInserta.Parameters["@Vencimiento"].Value = fac[4];
                        sqlComInserta.Parameters["@IdCliente"].Value = fac[5];
                        sqlComInserta.Parameters["@Cliente"].Value = fac[6];
                        sqlComInserta.Parameters["@s"].Value = fac[7];
                        sqlComInserta.Parameters["@N"].Value = fac[8];
                        sqlComInserta.Parameters["@Agente"].Value = fac[9];
                        sqlComInserta.Parameters["@Importe"].Value = fac[13];
                        sqlComInserta.Parameters["@Saldo"].Value = fac[12];

                        try
                        {
                            sqlConn.Open();
                            sqlComInserta.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                        finally
                        {
                            if (sqlConn.State == ConnectionState.Open)
                                sqlConn.Close();
                        }
                    }
                    if (facturas == true && renglon > 2)
                    {
                        sqlComInsertaCob.Parameters["@Numdoc"].Value = Cob[0];
                        sqlComInsertaCob.Parameters["@NCobro"].Value = Cob[1];
                        sqlComInsertaCob.Parameters["@Fecha"].Value = Cob[2];
                        sqlComInsertaCob.Parameters["@Concepto"].Value = Cob[3];
                        sqlComInsertaCob.Parameters["@ICobrado"].Value = Cob[6];
                        try
                        {
                            sqlConn.Open();
                            sqlComInsertaCob.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                        finally
                        {
                            if (sqlConn.State == ConnectionState.Open)
                                sqlConn.Close();
                        }
                    }
                    if (renglon == 99999)
                        break;
                    renglon++;
                    if (renglon > 3)
                    dataTables.Rows.Add(dataRow);
                }
            }
        }

        private static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            try
            {
                SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
                string value = cell.CellValue.InnerXml;

                if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                {
                    return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
                }
                else
                {
                    return value;
                }
            }
            catch
            {
                return null;
            }

        }

        private void tbBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();
                sqlComValida.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
            }
            //dsIncFac1.Clear();
            //sqlDAFactura.Fill(dsIncFac1, "Factura");
        }

        private void IncFactura_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sqlDAObras.Fill(dsObra1, "Obra");
            sqlDAAgente.Fill(dsAgente1, "Factura");
            sqlDAObra.Fill(dsObraFac1, "Factura");
            
        }

        private void tbBtn3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();
                sqlDAFactura.Update(dsIncFac1, "Factura");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            MessageBox.Show("Proceso terminado");
            dsIncFac1.Clear();
            sqlDAFactura.Fill(dsIncFac1, "Factura");
        }

        private void dwvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 

        private void rbtAlineada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAlineada.Checked)
            {
                cmbAgente.Visible = true;
                cmbObras.Visible = false;
            }
        }

        private void rdbSin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSin.Checked)
            {
                cmbAgente.Visible = false;
                cmbObras.Visible = true;
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            dsIncFac1.Clear();
            sqlDAFactura.SelectCommand.Parameters["@Tipo"].Value = rdbSin.Checked;
            sqlDAFactura.SelectCommand.Parameters["@Agente"].Value = cmbAgente.SelectedValue;
            sqlDAFactura.SelectCommand.Parameters["@Obra"].Value = cmbObras.SelectedValue;
            sqlDAFactura.Fill(dsIncFac1, "Factura");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFicheroPDFOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBtn1_Load(object sender, EventArgs e)
        {

        }

        private void btSelObs_Click(object sender, EventArgs e)
        {
            dlAbrirO.CheckFileExists = true;
            dlAbrirO.CheckPathExists = true;
            dlAbrirO.Multiselect = false;
            dlAbrirO.DefaultExt = "xlxs";
            dlAbrirO.FileName = "";
            dlAbrirO.Filter = "File XLS (*.xlsx)|*.xlsx|All the files (*.*)|*.*";
            dlAbrirO.Title = "Seleccione el archivo de excel a incorporar";
            if (dlAbrirO.ShowDialog() == DialogResult.OK)
            {
                txtArcObs.Text = dlAbrirO.FileName;
            }
        }

        private void tbBtn4_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaFicheroPDFOrigenDividir = txtArcObs.Text;

                if (!File.Exists(rutaFicheroPDFOrigenDividir))
                {
                    MessageBox.Show("El archivo origen de excel no existe.", " XLSX El arrchivo de excel no existe ",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFicheroPDFOrigen.Focus();
                }
                else
                {
                    ReadAsDataTableO(txtArcObs.Text);
                    MessageBox.Show("Termino la incorporación de las facturas." +
                    System.Environment.NewLine + System.Environment.NewLine, "Proceso finalizado exitosamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception errorM)
            {
                MessageBox.Show("Error durante la incorporación de las observaciones de facturas." +
                    System.Environment.NewLine + System.Environment.NewLine +
                    errorM.Message, "Error incorporando el archivo XLSX",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ReadAsDataTableO(string fileName)
        {
            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();
                string[] fac = new string[30];

                foreach (Row row in rows)
                {
                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                    {
                        fac[i] = "";
                        fac[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                    }
                    if (fac[8].Substring(0,4) == "FACI")
                    {
                        sqlComInsObj.Parameters["@Numdoc"].Value = fac[8].Substring(6,8);
                        sqlComInsObj.Parameters["@Obser"].Value = fac[7];
                        try
                        {
                            sqlConn.Open();
                            sqlComInsObj.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                        finally
                        {
                            if (sqlConn.State == ConnectionState.Open)
                                sqlConn.Close();
                        }
                    }
                }
            }
        }

        private void tbBtn5_Click(object sender, EventArgs e)
        {

            try
            {
                string rutaFicheroPDFOrigenDividir = txtArcAge.Text;

                if (!File.Exists(rutaFicheroPDFOrigenDividir))
                {
                    MessageBox.Show("El archivo origen de excel no existe.", " XLSX El archivo de excel no existe ",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtArcAge.Focus();
                }
                else
                {
                    ReadAsDataTable1(txtArcAge.Text);
                    MessageBox.Show("Termino la incorporación de agentes." +
                    System.Environment.NewLine + System.Environment.NewLine, "Proceso finalizado exitosamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception errorM)
            {
                MessageBox.Show("Error durante la incorporación de Agentes." +
                    System.Environment.NewLine + System.Environment.NewLine +
                    errorM.Message, "Error incorporando el archivo XLSX",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ReadAsDataTable1(string fileName)
        {
            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();
                string[] fac = new string[30];

                foreach (Row row in rows)
                {
                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                    {
                        fac[i] = "";
                        fac[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                    }
                    if (fac[0] != null)
                        if (fac[0].Length > 7 && fac[0] != "AGENTE: /   ")
                    if (fac[0].Substring(0, 7) == "AGENTE:")
                    {
                        string IdAgente = "", IdObra = "", Agente = "", Facs = fac[0].ToString().Trim();
                                if (Facs.Length > 0)
                                {
                                    try
                                    {
                                        if (Facs.Substring(13, 1) == "L")
                                        {
                                            IdAgente = Facs.Substring(8, 3);
                                            int po1 = Facs.IndexOf(" ", 13);
                                            IdObra = Facs.Substring(13, po1 - 13);
                                            int po2 = IdObra.IndexOf("/", 0);
                                            if (po2 > 0)
                                                IdObra = IdObra.Substring(0, po2) + IdObra.Substring(po2 + 1);
                                            Agente = Facs.Substring(13);
                                        }
                                        else
                                        {
                                            IdAgente = Facs.Substring(8, 3);
                                            int po1 = Facs.IndexOf(" ", 13);
                                            if (po1 != -1)
                                                IdObra = Facs.Substring(13, po1 - 13);
                                            else
                                                IdObra = Facs.Substring(13);
                                            //int po2 = IdObra.IndexOf("/", 0);
                                            //if (po2 > 0)
                                            //    IdObra = IdObra.Substring(0, po2) + IdObra.Substring(po2 + 1);
                                            Agente = Facs.Substring(13);

                                        }
                                    }
                                    catch (Exception ex1)
                                    {
                                        ex1.ToString();
                                    }
                                    sqlComInsAge.Parameters["@IdAgente"].Value = IdAgente;
                                    sqlComInsAge.Parameters["@IdObra"].Value = @IdObra;
                                    sqlComInsAge.Parameters["@Agente"].Value = Agente;
                                    try
                                    {
                                        sqlConn.Open();
                                        sqlComInsAge.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        ex.ToString();
                                    }
                                    finally
                                    {
                                        if (sqlConn.State == ConnectionState.Open)
                                            sqlConn.Close();
                                    }
                                }
                    }
                }
            }
        }

        private void btSelAge_Click(object sender, EventArgs e)
        {
            dlAbrirA.CheckFileExists = true;
            dlAbrirA.CheckPathExists = true;
            dlAbrirA.Multiselect = false;
            dlAbrirA.DefaultExt = "xlxs";
            dlAbrirA.FileName = "";
            dlAbrirA.Filter = "File XLS (*.xlsx)|*.xlsx|All the files (*.*)|*.*";
            dlAbrirA.Title = "Seleccione el archivo de excel a incorporar";
            if (dlAbrirA.ShowDialog() == DialogResult.OK)
            {
                txtArcAge.Text = dlAbrirA.FileName;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbBtn6_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();
                sqlComLimpia.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
            }
            MessageBox.Show("Proceso terminado","Observaciones depuradas");
            dsIncFac1.Clear();
        }
    }
}
