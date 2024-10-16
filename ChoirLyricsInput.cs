using Microsoft.Office.Core;
using PptSlides;
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
using MsoTriState = Microsoft.Office.Core.MsoTriState;

namespace Worship {
    public partial class ChoirLyricsInput : UserControl {
        public ChoirLyricsInput() {
            InitializeComponent();
            btnAdd.Click += new EventHandler(btnAdd_Click);
            rtbLyricsText.MouseDown += new MouseEventHandler(Event.ClearText);
            btnAdd.BackColor = Color.FromArgb(57, 57, 65);
            btnAdd.ForeColor = Color.White;
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            string text = rtbLyricsText.Text;
            FilePaths filePaths = new FilePaths();

            PowerPoint.Application PptApp = new PowerPoint.Application();
            PowerPoint.Presentation presentation = PptApp.Presentations.Add(MsoTriState.msoFalse);
            PptSlide pptSlide = new PptSlide(PptApp, presentation);

            string[] paragraph = text.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            string paragraphText = null;

            for (int i = 0; i < paragraph.Length; i++) {
                paragraphText = paragraph[i];
                pptSlide.CopyAndUpdateSlides(filePaths.ChoirBackgroundFilePath, paragraphText);
            }

            presentation.SaveAs(filePaths.ChoirPraiseLyricsFilePath);
            MessageBox.Show("성가대 가사 업데이트 완료!");
        }
    }
}
