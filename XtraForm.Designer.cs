namespace QuestionPaperMaker
{
    partial class XtraForm
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
            txtFaculty = new DevExpress.XtraEditors.TextEdit();
            txtGroup = new DevExpress.XtraEditors.TextEdit();
            txtClass = new DevExpress.XtraEditors.TextEdit();
            txtTeacher = new DevExpress.XtraEditors.TextEdit();
            txtYearAndSemester = new DevExpress.XtraEditors.TextEdit();
            btnLoad = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            btnPreview = new DevExpress.XtraEditors.SimpleButton();
            spnPaperCount = new DevExpress.XtraEditors.SpinEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtFaculty.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGroup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtClass.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTeacher.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYearAndSemester.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnPaperCount.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtFaculty
            // 
            txtFaculty.Location = new Point(127, 14);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.Size = new Size(100, 20);
            txtFaculty.TabIndex = 0;
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(127, 40);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(100, 20);
            txtGroup.TabIndex = 1;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(127, 66);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(100, 20);
            txtClass.TabIndex = 2;
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(127, 92);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(100, 20);
            txtTeacher.TabIndex = 3;
            // 
            // txtYearAndSemester
            // 
            txtYearAndSemester.Location = new Point(127, 118);
            txtYearAndSemester.Name = "txtYearAndSemester";
            txtYearAndSemester.Size = new Size(100, 20);
            txtYearAndSemester.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(25, 170);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(98, 23);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Sualları yüklə";
            btnLoad.Click += btnLoad_Click;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(86, 17);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(35, 13);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "Fakültə";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(81, 43);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(40, 13);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "Qrup №";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(72, 69);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(49, 13);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "Fənnin adı";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(25, 95);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(96, 13);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "İmtahan qəbul edən";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(59, 121);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(62, 13);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "İl və semestr";
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(129, 170);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(98, 23);
            btnPreview.TabIndex = 11;
            btnPreview.Text = "Biletləri yarat";
            btnPreview.Click += btnPreview_Click;
            // 
            // spnPaperCount
            // 
            spnPaperCount.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spnPaperCount.Location = new Point(127, 144);
            spnPaperCount.Name = "spnPaperCount";
            spnPaperCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spnPaperCount.Size = new Size(100, 20);
            spnPaperCount.TabIndex = 12;
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(79, 147);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(42, 13);
            labelControl6.TabIndex = 13;
            labelControl6.Text = "Bilet sayı";
            // 
            // XtraForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 218);
            Controls.Add(labelControl6);
            Controls.Add(spnPaperCount);
            Controls.Add(btnPreview);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(btnLoad);
            Controls.Add(txtYearAndSemester);
            Controls.Add(txtTeacher);
            Controls.Add(txtClass);
            Controls.Add(txtGroup);
            Controls.Add(txtFaculty);
            Name = "XtraForm";
            Text = "XtraForm";
            ((System.ComponentModel.ISupportInitialize)txtFaculty.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGroup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtClass.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTeacher.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtYearAndSemester.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnPaperCount.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFaculty;
        private DevExpress.XtraEditors.TextEdit txtGroup;
        private DevExpress.XtraEditors.TextEdit txtClass;
        private DevExpress.XtraEditors.TextEdit txtTeacher;
        private DevExpress.XtraEditors.TextEdit txtYearAndSemester;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SpinEdit spnPaperCount;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}