﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionPaperMaker
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1(string documentPath)
        {
            InitializeComponent();
            richEditControl.LoadDocument("");
            richEditControl.Document.ReplaceAll("", "", DevExpress.XtraRichEdit.API.Native.SearchOptions.None);
        }
    }
}