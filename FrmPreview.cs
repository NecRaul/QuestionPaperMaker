using Xceed.Words.NET;

namespace QuestionPaperMaker
{
    public partial class FrmPreview : DevExpress.XtraEditors.XtraForm
    {
        public FrmPreview(string documentPath, List<string> arguments)
        {
            InitializeComponent();
            DocX document = DocX.Load(documentPath);
            bool questions1Bool = false;
            bool questions2Bool = false;
            bool questions3Bool = false;
            bool questions4Bool = false;
            var questions1List = new List<string>();
            var questions2List = new List<string>();
            var questions3List = new List<string>();
            var questions4List = new List<string>();
            foreach (var paragraph in document.Paragraphs)
            {
                if (paragraph.Text == "1-ci sual*")
                {
                    questions1Bool = true;
                    continue;
                }
                if (paragraph.Text == "2-ci sual**")
                {
                    questions2Bool = true;
                    continue;
                }
                if (paragraph.Text == "3-cü sual***")
                {
                    questions3Bool = true;
                    continue;
                }
                if (paragraph.Text == "4-cü sual****")
                {
                    questions4Bool = true;
                    continue;
                }
                if (questions4Bool)
                {
                    questions4List.Add(paragraph.Text);
                    continue;
                }
                if (questions3Bool)
                {
                    questions3List.Add(paragraph.Text);
                    continue;
                }
                if (questions2Bool)
                {
                    questions2List.Add(paragraph.Text);
                    continue;
                }
                if (questions1Bool)
                {
                    questions1List.Add(paragraph.Text);
                    continue;
                }
            }
            var faculty = arguments[0];
            var group = arguments[1];
            var subject = arguments[2];
            var teacher = arguments[3];
            var yearAndSemester = arguments[4];
            var paperCount = Convert.ToInt32(arguments[5]);
            for (int i = 0; i < paperCount; i++)
            {
                richEditControl.Document.AppendDocumentContent("QuestionPaperTemplate.docx");
                if (i != paperCount - 1)
                    richEditControl.Document.AppendRtfText("{\\rtf1\\ansi \\page}");
                richEditControl.Document.ReplaceAll("[PaperCount]", (i + 1).ToString(), DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Faculty]", faculty, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Group]", group, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Subject]", subject, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Teacher]", teacher, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[YearAndSemester]", yearAndSemester, DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                var random = new Random();
                Func<List<string>, string> getRandomQuestion = (questionsList) =>
                {
                    int randomIndex = random.Next(0, questionsList.Count);
                    return questionsList[randomIndex];
                };
                richEditControl.Document.ReplaceAll("[Question 1]", getRandomQuestion(questions1List), DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Question 2]", getRandomQuestion(questions2List), DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Question 3]", getRandomQuestion(questions3List), DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
                richEditControl.Document.ReplaceAll("[Question 4]", getRandomQuestion(questions4List), DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
            }
        }
    }
}