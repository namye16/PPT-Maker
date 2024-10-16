using BibleBookAbbreviations;
using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worship;
using static System.Net.Mime.MediaTypeNames;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace PptSlides {
    public class PptSlide {
        public PowerPoint.Application PptApp;
        public PowerPoint.Presentation Mainpresentation;

        public static TextBox txtSecondBibleReading { get; set; }

        public PptSlide(PowerPoint.Application app, PowerPoint.Presentation mainpt) {
            PptApp = app;
            Mainpresentation = mainpt;
        }

        public void CopyAndUpdateSlides(string filePath, string firstText = null, ComboBox combobox = null, string secondText = null) {
            try {
                PowerPoint.Presentation presentation = PptApp.Presentations.Open(filePath, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);
                foreach (PowerPoint.Slide slide in presentation.Slides) {
                    PowerPoint.Slide copySlide = CopySlide(slide);
                    UpdateText(copySlide, firstText, combobox, secondText);
                }
                presentation.Close();
            } catch (Exception e) {
                MessageBox.Show($"예외가 발생했습니다 : {e.Message} \n{e.StackTrace}");
            }
        }

        public PowerPoint.Slide CopySlide(PowerPoint.Slide slide) {
            try {
                slide.Copy();
                int position = Mainpresentation.Slides.Count + 1;
                PowerPoint.Slide pasteSlide = Mainpresentation.Slides.Paste(position)[1];
                pasteSlide.SlideShowTransition.EntryEffect = PowerPoint.PpEntryEffect.ppEffectNone;
                pasteSlide.Design = slide.Design;
                return pasteSlide;
            } catch (Exception e) {
                MessageBox.Show($"예외가 발생했습니다 : {e.Message} \n{e.StackTrace}");
                return null;
            }
        }

        public void UpdateText(PowerPoint.Slide slide, string firstText, ComboBox comboBox = null, string secondText = null) {
            if (firstText == null) return;

            string combineText = firstText;

            if (comboBox != null && comboBox.SelectedItem != null) {
                string selectChurchPosition = comboBox.SelectedItem.ToString();
                combineText = $"{firstText} {selectChurchPosition}";
            }

            if (!string.IsNullOrEmpty(secondText)) {
                combineText = $"{combineText} \n{secondText}";
            }

            foreach (PowerPoint.Shape shape in slide.Shapes) {
                if (shape.HasTextFrame == MsoTriState.msoTrue && shape.TextFrame.HasText == MsoTriState.msoTrue) {
                    shape.TextFrame.TextRange.Text = combineText;
                }
            }
        }

        public void LookupSubfiles(string number, string filePath) {
            string[] files = Directory.GetFiles(filePath, "*.pptx");
            foreach (string selectFile in files) {
                if (Path.GetFileNameWithoutExtension(selectFile) == number) {
                    CopyAndUpdateSlides(selectFile);
                    break;
                }
            }
        }

        public void BibleSlides(string filepath, System.Windows.Forms.ComboBox comboBox, string textbox = null) {
            if (comboBox.SelectedItem != null) {
                string selectBookName = comboBox.SelectedItem.ToString();
                string fileName;
                string bibleFilePath = filePaths.BibleTxtFolderFilePath;

                if (BibleAbbreviations.findFile.TryGetValue(selectBookName, out fileName)) {
                    string filePath = Path.Combine(bibleFilePath, $"{fileName}.txt");
                    if (System.IO.File.Exists(filePath)) {
                        string[] verses = System.IO.File.ReadAllLines(filePath, Encoding.Default);
                        if (textbox.Contains('~')) {
                            try {
                                string[] FirstLast = textbox.Split('~');
                                string[] First = FirstLast[0].Split(':');
                                string[] Last = FirstLast[1].Split(':');

                                if (First[0] ==  Last[0]) {
                                    for (int i = int.Parse(First[1]); i <= int.Parse(Last[1]); i++) {
                                        string chapterVerse = First[0] + ":" + i.ToString() + " ";
                                        AddVerse(verses, chapterVerse);
                                    }
                                }

                                else if(First[0] != Last[0]) {
                                    try {
                                        for (int i = int.Parse(First[1]); i <= 177; i++) {
                                            string chapterVerse = First[0] + ":" + i.ToString() + " ";
                                            AddVerse(verses, chapterVerse);
                                        }
                                    } catch {
                                        for (int j = 1; j <= int.Parse(Last[1]); j++) {
                                            string chapterVerse = Last[0] + ":" + j.ToString() + " ";
                                            AddVerse(verses, chapterVerse);
                                        }
                                    }
                                }
                            } catch {
                                MessageBox.Show("장:절을 확인해주세요.");
                            }
                        } else {
                            AddVerse(verses, textbox);
                        }
                    }
                }
            }
        }

        FilePaths filePaths = new FilePaths();

        public void AddVerse(string[] verses, string chapterVerse) {
            string verseText = verses.First(line => line.StartsWith(chapterVerse));
            if (verseText != null) {
                CopyAndUpdateSlides(filePaths.VersePptFilePath, verseText);
            } else {
                MessageBox.Show("장:절을 확인해주세요.");
            }
        }

/*        public void LyricsSlides(string filepath, string textbox = null) {
            CopyAndUpdateSlides(filepath, textbox);
        }*/
    }
}
