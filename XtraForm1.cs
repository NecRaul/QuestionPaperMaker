using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionPaperMaker
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1(string documentPath, List<string> arguments)
        {
            InitializeComponent();
            var faculty = arguments[0];
            var group = arguments[1];
            var subject = arguments[2];
            var teacher = arguments[3];
            var yearAndSemester = arguments[4];
            var paperCount = Convert.ToInt32(arguments[5]);
            for (int i = 0; i < paperCount; i++)
            {
                richEditControl.Document.AppendDocumentContent("Template.docx");
                if (i != paperCount - 1)
                    richEditControl.Document.AppendRtfText("{\\rtf1\\ansi \\page}");
                richEditControl.Document.ReplaceAll("[PaperCount]", (i + 1).ToString(), DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Faculty]", faculty, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Group]", group, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Subject]", subject, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Teacher]", teacher, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[YearAndSemester]", yearAndSemester, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
            }
        }
    }
}