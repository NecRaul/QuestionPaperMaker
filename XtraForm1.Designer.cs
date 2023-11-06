namespace QuestionPaperMaker
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            commonBar1 = new DevExpress.XtraRichEdit.UI.CommonBar();
            undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            btnOpenDocument = new DevExpress.XtraBars.BarButtonItem();
            fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            encryptDocumentItem1 = new DevExpress.XtraRichEdit.UI.EncryptDocumentItem();
            showDocumentPropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem();
            richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController(components);
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)richEditBarController1).BeginInit();
            SuspendLayout();
            // 
            // richEditControl
            // 
            richEditControl.Dock = DockStyle.Fill;
            richEditControl.Location = new Point(0, 24);
            richEditControl.MenuManager = barManager1;
            richEditControl.Name = "richEditControl";
            richEditControl.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            richEditControl.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            richEditControl.Size = new Size(898, 484);
            richEditControl.TabIndex = 0;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { commonBar1 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { undoItem1, redoItem1, fileNewItem1, fileOpenItem1, fileSaveItem1, fileSaveAsItem1, quickPrintItem1, printItem1, printPreviewItem1, encryptDocumentItem1, showDocumentPropertiesFormItem1, btnOpenDocument });
            barManager1.MaxItemId = 12;
            // 
            // commonBar1
            // 
            commonBar1.Control = richEditControl;
            commonBar1.DockCol = 0;
            commonBar1.DockRow = 0;
            commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(undoItem1), new DevExpress.XtraBars.LinkPersistInfo(redoItem1), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, fileNewItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "N", ""), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, fileSaveAsItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "A", ""), new DevExpress.XtraBars.LinkPersistInfo(quickPrintItem1), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, printItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "P", ""), new DevExpress.XtraBars.LinkPersistInfo(printPreviewItem1) });
            // 
            // undoItem1
            // 
            undoItem1.Id = 0;
            undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            redoItem1.Id = 1;
            redoItem1.Name = "redoItem1";
            // 
            // fileNewItem1
            // 
            fileNewItem1.Id = 2;
            fileNewItem1.Name = "fileNewItem1";
            // 
            // btnOpenDocument
            // 
            btnOpenDocument.Caption = "barButtonItem1";
            btnOpenDocument.Id = 11;
            btnOpenDocument.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnOpenDocument.ImageOptions.SvgImage");
            btnOpenDocument.Name = "btnOpenDocument";
            toolTipTitleItem1.Text = "Open (Ctrl+O)";
            toolTipItem1.Text = "Open a document.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            btnOpenDocument.SuperTip = superToolTip1;
            // 
            // fileSaveAsItem1
            // 
            fileSaveAsItem1.Id = 5;
            fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // quickPrintItem1
            // 
            quickPrintItem1.Id = 6;
            quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            printItem1.Id = 7;
            printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            printPreviewItem1.Id = 8;
            printPreviewItem1.Name = "printPreviewItem1";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(898, 24);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 508);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(898, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 24);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 484);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(898, 24);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 484);
            // 
            // fileOpenItem1
            // 
            fileOpenItem1.Id = 3;
            fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            fileSaveItem1.Id = 4;
            fileSaveItem1.Name = "fileSaveItem1";
            // 
            // encryptDocumentItem1
            // 
            encryptDocumentItem1.Id = 9;
            encryptDocumentItem1.Name = "encryptDocumentItem1";
            // 
            // showDocumentPropertiesFormItem1
            // 
            showDocumentPropertiesFormItem1.Id = 10;
            showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1";
            // 
            // richEditBarController1
            // 
            richEditBarController1.BarItems.Add(undoItem1);
            richEditBarController1.BarItems.Add(redoItem1);
            richEditBarController1.BarItems.Add(fileNewItem1);
            richEditBarController1.BarItems.Add(fileOpenItem1);
            richEditBarController1.BarItems.Add(fileSaveItem1);
            richEditBarController1.BarItems.Add(fileSaveAsItem1);
            richEditBarController1.BarItems.Add(quickPrintItem1);
            richEditBarController1.BarItems.Add(printItem1);
            richEditBarController1.BarItems.Add(printPreviewItem1);
            richEditBarController1.BarItems.Add(encryptDocumentItem1);
            richEditBarController1.BarItems.Add(showDocumentPropertiesFormItem1);
            richEditBarController1.Control = richEditControl;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 508);
            Controls.Add(richEditControl);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "XtraForm1";
            Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)richEditBarController1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
        private DevExpress.XtraRichEdit.UI.PrintItem printItem1;
        private DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraRichEdit.UI.EncryptDocumentItem encryptDocumentItem1;
        private DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem showDocumentPropertiesFormItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraBars.BarButtonItem btnOpenDocument;
    }
}