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

namespace GoodTimePDFConverter.Classes
{
    public static class Conversor
    {
        private static Microsoft.Office.Interop.Word.Document wordDocument { get; set; }

        public static bool FileToPDF(FileInterface file, string outputPath)
        {
            try
            {
                if (file.file.Extension.Contains("doc"))
                {
                    string docOrigem = file.file.FullName;
                    string pdfSaida = outputPath + String.Format(@"\{0}.pdf", file.file.Name.Replace(file.file.Extension, ""));
                    //Utiliza as próprias dll do wor para realizar a conversão
                    Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                    wordDocument = appWord.Documents.Open(docOrigem);
                    wordDocument.ExportAsFixedFormat(pdfSaida, WdExportFormat.wdExportFormatPDF);

                    object saveOption = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
                    object originalFormat = Microsoft.Office.Interop.Word.WdOriginalFormat.wdWordDocument;
                    object routeDocument = false;

                    // Fecha a aplicação e o documento
                    appWord.Quit(ref saveOption, ref originalFormat, ref routeDocument);
                    wordDocument.Close();
                    return true;
                }
                else
                {
                    Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook excelWorkBook = null;

                    string paramSourceBookPath = file.file.FullName;
                    object paramMissing = Type.Missing;
                    string paramExportFilePath = outputPath + String.Format(@"\{0}.pdf", file.file.Name.Replace(file.file.Extension, ""));
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

                    // Save it in the target format.
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

                    // Quit Excel and release the ApplicationClass object.
                    if (excelApplication != null)
                    {
                        excelApplication.Quit();
                        excelApplication = null;
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
