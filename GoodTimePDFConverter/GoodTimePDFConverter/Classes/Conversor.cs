using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodTimePDFConverter.Forms;
using GoodTimePDFConverter.Properties;
using Microsoft.Office.Interop.Word;

namespace GoodTimePDFConverter.Classes
{
    public static class Conversor
    {
        private static Microsoft.Office.Interop.Word.Document wordDocument { get; set; }

        public static bool FileToPDF(FileInterface file, string outputPath, Principal context)
        {
            try
            {
                if (file.file.Extension.Contains("doc"))
                {
                    string docOrigem = file.file.FullName;
                    string pdfSaida = outputPath + String.Format(@"\{0}.pdf", file.file.Name);
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
