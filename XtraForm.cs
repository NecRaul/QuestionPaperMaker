using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
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
    public partial class XtraForm : DevExpress.XtraEditors.XtraForm
    {
        private string wordDocument = string.Empty;
        public XtraForm()
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
            if (Path.GetExtension(dlg.FileName) != ".doc" || Path.GetExtension(dlg.FileName) != ".docx")
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
            var arguments = new List<string>();
            arguments.Add("");
            arguments.Add("");
            arguments.Add("");
            arguments.Add("");
            arguments.Add("");
            var frm = new XtraForm1(wordDocument, arguments);
            frm.ShowDialog();
        }
    }
}