using System.IO;

namespace QuestionPaperMaker
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        private string wordDocument = string.Empty;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Word dokumentini seçin",
                Filter = "Word Documents|*.doc;*.docx",
                FilterIndex = 1,
                Multiselect = false,
            };
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            if (Path.GetExtension(dlg.FileName) != ".doc" && Path.GetExtension(dlg.FileName) != ".docx")
            {
                MessageBox.Show("Bu Word dokumenti deyil!", "Word", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            wordDocument = dlg.FileName;
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (wordDocument == "")
            {
                MessageBox.Show("Suallar yüklənməyib!", "Suallar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var arguments = new List<string>()
            {
                txtFaculty.Text,
                txtGroup.Text,
                txtSubject.Text,
                txtTeacher.Text,
                txtYearAndSemester.Text,
                spnPaperCount.Text
            };
            var frm = new FrmPreview(wordDocument, arguments);
            frm.ShowDialog();
        }
    }
}