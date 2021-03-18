using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodTimePDFConverter.Forms;
using GoodTimePDFConverter.Properties;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Collections;

namespace GoodTimePDFConverter.Classes
{
    public static class Conversor
    {
        public static ArrayList Arquivos = new ArrayList();

        private static Microsoft.Office.Interop.Word.Document wordDocument { get; set; }

        private static bool ArquivoAberto(string path)
        {
            try
            {
                FileStream file = File.OpenWrite(path);
                file.Close();
                return false;
            }
            catch
            {
                return true;
            }
        }

        private static string RetornarOutputCorreto(string path, string name)
        {
            int cont = 1;
            string output = path + String.Format(@"\{0}.pdf", name);
            while(File.Exists(output))
            {
                output = path + String.Format(@"\{0}({1}).pdf", name, cont);
            }
            return output;
        }

        public static bool FileToPDF(FileInterface file, string outputPath)
        {
            try
            {
                if (ArquivoAberto(file.file.FullName))
                {
                    DialogResult closed;
                    do
                    {
                        closed = MessageBox.Show(String.Format("O arquivo {0} não pode ser convertido pois está sendo " +
                                                 "usado por outro processo neste momento. Por favor, feche o arquivo " +
                                                 "e clique em 'Sim' se deseja continuar. Para cancelar a conversão deste arquivo, clique em 'Não'.", file.file.Name), "Erro - Arquivo aberto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (!ArquivoAberto(file.file.FullName))
                            break;
                    }
                    while (closed.Equals(DialogResult.Yes));
                    if (closed.Equals(DialogResult.No))
                    {
                        Arquivo arquivo = new Arquivo(file.file.Name, file.file.Extension, "Cancelado", "Conversão cancelada pelo usuário");
                        Arquivos.Add(arquivo);
                        return false;
                    }
                }
                if (file.file.Extension.Contains("doc"))
                {
                    string wordDoc = file.file.FullName;
                    string output = RetornarOutputCorreto(outputPath, file.file.Name.Replace(file.file.Extension, ""));
                    Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                    
                    wordDocument = appWord.Documents.Open(wordDoc);
                    wordDocument.ExportAsFixedFormat(output, WdExportFormat.wdExportFormatPDF);

                    object saveOption = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
                    object originalFormat = Microsoft.Office.Interop.Word.WdOriginalFormat.wdWordDocument;
                    object routeDocument = false;

                    appWord.Quit(ref saveOption, ref originalFormat, ref routeDocument);
                    Arquivo arquivo = new Arquivo(file.file.Name, file.file.Extension, "Convertido", "Arquivo convertido com sucesso!");
                    Arquivos.Add(arquivo);
                    return true;
                }
                else
                {
                    Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook excelWorkBook = null;

                    string paramSourceBookPath = file.file.FullName;
                    object paramMissing = Type.Missing;
                    //string paramExportFilePath = outputPath + String.Format(@"\{0}.pdf", file.file.Name.Replace(file.file.Extension, ""));
                    string paramExportFilePath = RetornarOutputCorreto(outputPath, file.file.Name.Replace(file.file.Extension, ""));
                    XlFixedFormatType paramExportFormat = XlFixedFormatType.xlTypePDF;
                    XlFixedFormatQuality paramExportQuality = XlFixedFormatQuality.xlQualityStandard;
                    bool paramOpenAfterPublish = false;
                    bool paramIncludeDocProps = true;
                    bool paramIgnorePrintAreas = true;
                    object paramFromPage = Type.Missing;
                    object paramToPage = Type.Missing;

                    excelWorkBook = excelApplication.Workbooks.Open(paramSourceBookPath,
        paramMissing, paramMissing, paramMissing, paramMissing,
        paramMissing, paramMissing, paramMissing, paramMissing,
        paramMissing, paramMissing, paramMissing, paramMissing,
        paramMissing, paramMissing);

                    if (excelWorkBook != null)
                        excelWorkBook.ExportAsFixedFormat(paramExportFormat,
                            paramExportFilePath, paramExportQuality,
                            paramIncludeDocProps, paramIgnorePrintAreas, paramFromPage,
                            paramToPage, paramOpenAfterPublish,
                            paramMissing);

                    if (excelWorkBook != null)
                    {
                        excelWorkBook.Close(false, paramMissing, paramMissing);
                        excelWorkBook = null;
                    }

                    if (excelApplication != null)
                    {
                        excelApplication.Quit();
                        excelApplication = null;
                    }
                    Arquivo arquivo = new Arquivo(file.file.Name, file.file.Extension, "Convertido", "Arquivo convertido com sucesso!");
                    Arquivos.Add(arquivo);
                    return true;
                }
            }
            catch (Exception erro)
            {
                Arquivo arquivo = new Arquivo(file.file.Name, file.file.Extension, "Erro", erro.Message);
                Arquivos.Add(arquivo);
                return false;
            }
        }
    }
}
