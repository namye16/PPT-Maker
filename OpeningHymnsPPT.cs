using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace Worship {
    public partial class OpeningHymnsPPT : UserControl {
        private int textBoxLocationY = 48;
        private int labelLocationY = 50;
        private int labelCount = 2;
        private List<TextBox> textBoxes = new List<TextBox>();
        public OpeningHymnsPPT() {
            InitializeComponent();
            btnNumberAdd.Click += new EventHandler(btnNumberAdd_Click);
            btnCreate.Click += new EventHandler(btnCreate_Click);
            btnAdd.Click += new EventHandler(btnAdd_Click);
            txtHymn.MouseDown += new MouseEventHandler(Event.ClearText);
            txtHymn.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            btnNumberAdd.BackColor = Color.FromArgb(231, 236, 245);
            btnNumberAdd.ForeColor = Color.FromArgb(27, 28, 31);
            btnCreate.BackColor = Color.FromArgb(231, 236, 245);
            btnCreate.ForeColor = Color.FromArgb(27, 28, 31);
            btnAdd.BackColor = Color.FromArgb(231, 236, 245);
            btnAdd.ForeColor = Color.FromArgb(27, 28, 31);
        }
        FilePaths filePaths = new FilePaths();
        private void btnNumberAdd_Click(object sender, EventArgs e) {
            AddNewTextBox();
            AddNewLabel();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            PowerPoint.Application PptApp = new PowerPoint.Application();
            PowerPoint.Presentation presentation = PptApp.Presentations.Add(MsoTriState.msoFalse);
            PptSlides.PptSlide slidePaste = new PptSlides.PptSlide(PptApp, presentation);

            string hymnNumber = txtHymn.Text;
            slidePaste.LookupSubfiles(hymnNumber, filePaths.HymnPptFolderFilePath);

            foreach (TextBox textBox in textBoxes) {
                string addHymnNumber = textBox.Text;
                slidePaste.LookupSubfiles(addHymnNumber, filePaths.HymnPptFolderFilePath);
            }

            presentation.SaveAs(@"C:\Users\admin\Desktop\찬송가.ppt", PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoFalse);
            PptApp.Presentations.Open(@"C:\Users\admin\Desktop\찬송가.ppt");
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            PowerPoint.Application PptApp = new PowerPoint.Application();
            PowerPoint.Presentation presentation = PptApp.Presentations.Add(MsoTriState.msoFalse);
            PptSlides.PptSlide slidePaste = new PptSlides.PptSlide(PptApp, presentation);

            string hymnNumber = txtHymn.Text;
            slidePaste.LookupSubfiles(hymnNumber, filePaths.HymnPptFolderFilePath);

            foreach (TextBox textBox in textBoxes) {
                string addHymnNumber = textBox.Text;
                slidePaste.LookupSubfiles(addHymnNumber, filePaths.HymnPptFolderFilePath);
            }

            presentation.SaveAs(filePaths.OpeningHymnPptFilePath);
            MessageBox.Show("시작찬송 업데이트 완료!");
        }

        private void AddNewTextBox() {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new System.Drawing.Point(82, textBoxLocationY);
            newTextBox.Size = new Size(244, 23);
            newTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            newTextBox.BorderStyle = BorderStyle.FixedSingle;
            newTextBox.BackColor = Color.White;
            newTextBox.ForeColor = Color.FromArgb(27, 28, 31);
            panel2.Controls.Add(newTextBox);
            textBoxes.Add(newTextBox);
            textBoxLocationY += 26;

            if (textBoxLocationY > panel2.Height) {
                panel2.Height = textBoxLocationY + 5;
            }
        }

        private void AddNewLabel() {
            Label newLabel = new Label();
            newLabel.Text = labelCount + ".";
            newLabel.Location = new System.Drawing.Point(59, labelLocationY);
            newLabel.Size = new Size(17, 15);
            newLabel.ForeColor = Color.FromArgb(27, 28, 31);
            newLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            panel2.Controls.Add(newLabel);
            labelLocationY += 26;
            labelCount++;
        }
    }
}
