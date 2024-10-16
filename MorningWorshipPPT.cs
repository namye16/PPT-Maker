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
using PptSlides;
using static System.Net.WebRequestMethods;
using System.Threading;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;


namespace Worship {
    public partial class MorningWorshipPPT : UserControl {
        private int TextBoxLocationY = 120;
        private List<TextBox> textBoxBR = new List<TextBox>();
        private List<TextBox> textBoxS = new List<TextBox>();
        public MorningWorshipPPT() {
            InitializeComponent();
            
            btnAdd.BackColor = Color.FromArgb(57, 57, 65);
            btnAdd.ForeColor = Color.White;
            btnCreate.BackColor = Color.FromArgb(57, 57, 65);
            btnCreate.ForeColor = Color.White;

            Event.txtSearch = txtSearch;
            Event.txtBibleReading = txtBibleReading;
            Event.txtStartChapter =txtStartChapter;
            Event.txtStartVerse = txtStartVerse;
            Event.txtEndChapter = txtEndChapter;
            Event.txtEndVerse = txtEndVerse;
            /*Event.txtOfferingHymn = txtOfferingHymn;
            Event.txtClosingHymn = txtClosingHymn;
            Event.cboPassage = cboBookName;*/

            UpdateBibleReadingText.txtSearch = txtSearch;
            UpdateBibleReadingText.txtBibleReading = txtBibleReading;
            UpdateBibleReadingText.txtStartChapter =txtStartChapter;
            UpdateBibleReadingText.txtStartVerse = txtStartVerse;
            UpdateBibleReadingText.txtEndChapter = txtEndChapter;
            UpdateBibleReadingText.txtEndVerse = txtEndVerse;
            UpdateBibleReadingText.txtCurrentBibleReading = txtCurrentBibleReading;
            UpdateBibleReadingText.txtCurrentSearch = txtCurrentSearch;
            UpdateBibleReadingText.cboPassage = cboBookName;

            LoadList.cboChurchPosition = cboChurchPosition;
            LoadList.cboFirstPassage = cboBookName;
            LoadList.txtHymn = txtHymn;
            LoadList.txtWorshipPraise = txtWorshipPraise;
            LoadList.txtPrayer = txtPrayer;
            LoadList.txtChoir = txtChoir;
            LoadList.txtStartChapter = txtStartChapter;
            LoadList.txtStartVerse  = txtStartVerse;
            LoadList.txtEndChapter = txtEndChapter;
            LoadList.txtEndVerse = txtEndVerse;
            LoadList.txtClosingHymn = txtClosingHymn;
            LoadList.txtOfferingHymn = txtOfferingHymn;

            LoadList.chkpreparationScreen = chkpreparationScreen;
            LoadList.chkOpeningHymn = chkOpeningHymn;
            LoadList.chkWorshipPraise = chkWorshipPraise;
            LoadList.chkCreed = chkCreed;
            LoadList.chkHymn = chkHymn;
            LoadList.chkPrayer = chkPrayer;
            LoadList.chkBibleReading = chkBibleReading;
            LoadList.chkChoirPraiseTitle = chkChoirPraiseTitle;
            LoadList.chkChoirPraiseLyrics = chkChoirPraiseLyrics;
            LoadList.chkClosingHymn = chkClosingHymn;
            LoadList.chkOfferingHymn = chkOfferingHymn;
            LoadList.chkLordsPrayer = chkLordsPrayer;

            txtWorshipPraise.MouseDown += new MouseEventHandler(Event.ClearText);
            txtHymn.MouseDown += new MouseEventHandler(Event.ClearText);
            txtPrayer.MouseDown += new MouseEventHandler(Event.ClearText);
            txtChoir.MouseDown += new MouseEventHandler(Event.ClearText);
            txtStartChapter.MouseDown += new MouseEventHandler(Event.ClearText);
            txtStartVerse.MouseDown += new MouseEventHandler(Event.ClearText);
            txtEndChapter.MouseDown += new MouseEventHandler(Event.ClearText);
            txtEndVerse.MouseDown += new MouseEventHandler(Event.ClearText);
            txtOfferingHymn.MouseDown += new MouseEventHandler(Event.ClearText);
            txtClosingHymn.MouseDown += new MouseEventHandler(Event.ClearText);

            txtWorshipPraise.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            txtHymn.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            txtPrayer.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            txtStartChapter.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            txtStartVerse.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            txtEndChapter.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            txtEndVerse.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            txtOfferingHymn.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);
            txtClosingHymn.KeyPress += new KeyPressEventHandler(Event.AllowCertainCharacters);

            txtStartChapter.TextChanged += new EventHandler(UpdateBibleReadingText.UpdateBibleReading);
            txtStartVerse.TextChanged += new EventHandler(UpdateBibleReadingText.UpdateBibleReading);
            txtEndChapter.TextChanged += new EventHandler(UpdateBibleReadingText.UpdateBibleReading);
            txtEndVerse.TextChanged += new EventHandler(UpdateBibleReadingText.UpdateBibleReading);

            cboBookName.SelectedIndexChanged += new EventHandler(Event.ShowAbbreviation);
            cboBookName.DropDownClosed += new EventHandler(cboBookName_DropDownClosed);
            chkSelectAll.CheckedChanged += new EventHandler(chkSelectAll_CheckedChanged);
            btnCreate.Click += new EventHandler(btnCreate_Click);
            btnAdd.Click += new EventHandler(btnAdd_Click);
            this.Load += new EventHandler(MainForm_Load);

            
        }
        public void MainForm_Load(object sender, EventArgs e) {
            LoadList.loadChurchPositionList(filePaths.ChurchPositionTxtFilePath, cboChurchPosition);
            LoadList.loadBibleBookList(filePaths.BibleTxtFolderFilePath, cboBookName);
            //comboBox();            
        }

        FilePaths filePaths = new FilePaths();
        private void btnCreate_Click(object sender, EventArgs e) {
            if (LoadList.messageList()) {
                return;
            }

            Thread thread = new Thread(new ThreadStart(createPpt));
            {
                thread.Start();
            };
        }
        private void createPpt() {
            PowerPoint.Application PptApp = new PowerPoint.Application();
            PowerPoint.Presentation presentation = PptApp.Presentations.Add(MsoTriState.msoFalse);
            PptSlides.PptSlide slidePaste = new PptSlides.PptSlide(PptApp, presentation);

            if (chkpreparationScreen.Checked) {
                slidePaste.CopyAndUpdateSlides(filePaths.MainPptFilePath);
            }

            if (chkOpeningHymn.Checked) {
                slidePaste.CopyAndUpdateSlides(filePaths.OpeningHymnPptFilePath);
            }

            if (chkWorshipPraise.Checked) {
                slidePaste.LookupSubfiles(txtWorshipPraise.Text, filePaths.HymnPptFolderFilePath);
            }
            if (chkCreed.Checked) {
                slidePaste.CopyAndUpdateSlides(filePaths.CreedPptFilePath);
            }
            if (chkHymn.Checked) {
                slidePaste.LookupSubfiles(txtHymn.Text, filePaths.HymnPptFolderFilePath);
            }

            if (chkPrayer.Checked) {
                if (cboChurchPosition.InvokeRequired) {
                    cboChurchPosition.Invoke(new MethodInvoker(delegate {
                        slidePaste.CopyAndUpdateSlides(filePaths.PrayerPptFilePath, txtPrayer.Text, cboChurchPosition);
                    }));
                } else {
                    slidePaste.CopyAndUpdateSlides(filePaths.PrayerPptFilePath, txtPrayer.Text, cboChurchPosition);
                }
            }

            if (chkBibleReading.Checked) {
                slidePaste.CopyAndUpdateSlides(filePaths.BibleTitlePptFilePath, txtBibleReading.Text);

                if (cboBookName.InvokeRequired) {
                    cboBookName.Invoke(new MethodInvoker(delegate {
                        slidePaste.BibleSlides(cboBookName.SelectedItem.ToString(), cboBookName, txtSearch.Text);
                    }));
                } else {
                    slidePaste.BibleSlides(cboBookName.SelectedItem.ToString(), cboBookName, txtSearch.Text);
                }
            }

            if (chkChoirPraiseTitle.Checked) {
                slidePaste.CopyAndUpdateSlides(filePaths.ChoirPraiseTitlePptFilePath, txtChoir.Text);
            }

            if (chkChoirPraiseLyrics.Checked) {
                slidePaste.CopyAndUpdateSlides(filePaths.ChoirPraiseLyricsFilePath);
            }

            if (chkOfferingHymn.Checked) {
                slidePaste.LookupSubfiles(txtOfferingHymn.Text, filePaths.HymnPptFolderFilePath);
            }

            if (chkClosingHymn.Checked) {
                slidePaste.LookupSubfiles(txtClosingHymn.Text, filePaths.HymnPptFolderFilePath);
            }

            presentation.SaveAs(@"C:\Users\admin\Desktop\오전예배.ppt", PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoFalse);
            PptApp.Presentations.Open(@"C:\Users\admin\Desktop\오전예배.ppt");
        }
        private void cboBookName_DropDownClosed(object sender, EventArgs e) {
            Event.ResetFirstChapterVerse(cboBookName, e);
        }
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e) {
            if (chkSelectAll.Checked == true)
                checkAll();
            else
                uncheckAll();
        }
        private void checkAll() {
            chkpreparationScreen.Checked = true;
            chkOpeningHymn.Checked = true;
            chkWorshipPraise.Checked = true;
            chkCreed.Checked = true;
            chkHymn.Checked = true;
            chkPrayer.Checked = true;
            chkBibleReading.Checked = true;
            chkChoirPraiseTitle.Checked = true;
            chkChoirPraiseLyrics.Checked = true;
            chkOfferingHymn.Checked = true;
            chkClosingHymn.Checked = true;
            chkLordsPrayer.Checked = true;
        }
        private void uncheckAll() {
            chkpreparationScreen.Checked = false;
            chkOpeningHymn.Checked = false;
            chkWorshipPraise.Checked = false;
            chkCreed.Checked = false;
            chkHymn.Checked = false;
            chkPrayer.Checked = false;
            chkBibleReading.Checked = false;
            chkChoirPraiseTitle.Checked = false;
            chkChoirPraiseLyrics.Checked = false;
            chkOfferingHymn.Checked = false;
            chkClosingHymn.Checked = false;
            chkLordsPrayer.Checked= false;
        }

        private void AddBR() {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new System.Drawing.Point(142, TextBoxLocationY);
            newTextBox.Size = new Size(244, 23);
            newTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            newTextBox.BorderStyle = BorderStyle.FixedSingle;
            newTextBox.BackColor = Color.FromArgb(27, 28, 31);
            newTextBox.ForeColor = Color.White;
            panel2.Controls.Add(newTextBox);
            textBoxBR.Add(newTextBox);

            if (TextBoxLocationY > panel2.Height) {
                panel2.Height = TextBoxLocationY + 25;
            }
        }

        private void AddS() {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new System.Drawing.Point(56, TextBoxLocationY);
            newTextBox.Size = new Size(79, 23);
            newTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            newTextBox.BorderStyle = BorderStyle.FixedSingle;
            newTextBox.Visible = false;
            panel2.Controls.Add(newTextBox);
            textBoxS.Add(newTextBox);

            if (TextBoxLocationY > panel2.Height) {
                panel2.Height = TextBoxLocationY + 25;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            /*int currentY = TextBoxLocationY;
            AddNewTextBox(102, currentY, 244, 23);
            AddNewTextBox(12, currentY, 79, 23);*/
            AddBR();
            AddS();
            TextBoxLocationY += 26;

            //UpdateBibleReadingText.bibleReading();
            UpdateBibleReadingText.bibleReading(txtCurrentBibleReading, txtCurrentSearch);
            /*foreach (TextBox textBox in textBoxes) {
                
            }*/
        }

        private void chkFrequentlyUsedItems_CheckedChanged(object sender, EventArgs e) {
            if (chkFrequentlyUsedItems.Checked == true)
                checkFrequently();
            else
                uncheckFrequently();
        }
        private void checkFrequently() {
            chkpreparationScreen.Checked = true;
            chkWorshipPraise.Checked = true;
            chkCreed.Checked = true;
            chkHymn.Checked = true;
            chkPrayer.Checked = true;
            chkBibleReading.Checked = true;
            chkChoirPraiseTitle.Checked = true;
            chkChoirPraiseLyrics.Checked = true;
        }
        private void uncheckFrequently() {
            chkpreparationScreen.Checked = false;
            chkWorshipPraise.Checked = false;
            chkCreed.Checked = false;
            chkHymn.Checked = false;
            chkPrayer.Checked = false;
            chkBibleReading.Checked = false;
            chkChoirPraiseTitle.Checked = false;
            chkChoirPraiseLyrics.Checked = false;
        }
    }
}
