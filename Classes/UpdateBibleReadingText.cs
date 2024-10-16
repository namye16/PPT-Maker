using BibleBookAbbreviations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Worship {
    public static class UpdateBibleReadingText {        
        public static TextBox txtSearch { get; set; }        
        public static TextBox txtBibleReading { get; set; }        
        public static TextBox txtStartChapter { get; set; }
        public static TextBox txtStartVerse { get; set; }
        public static TextBox txtEndChapter { get; set; }
        public static TextBox txtEndVerse { get; set; }
        public static TextBox txtCurrentBibleReading { get; set; }
        public static TextBox txtCurrentSearch { get; set; }
        public static ComboBox cboPassage { get; set; }

        public static void UpdateBibleReading(object sender, EventArgs e) {
            //bibleReading();            
        }
        public static void bibleReading(TextBox BibleReading, TextBox Search) {
            string SelectedBible = cboPassage.SelectedItem?.ToString() ?? "";
            string StartChapter = txtStartChapter.Text;
            string StartVerse = txtStartVerse.Text;
            string EndChapter = txtEndChapter.Text;
            string EndVerse = txtEndVerse.Text;            

            if (!string.IsNullOrWhiteSpace(StartChapter)) {
                string BibleReadingText = $"{SelectedBible} {StartChapter}";
                txtBibleReading.Text = BibleReadingText;

                Dictionary<string, string> abbreviations = BibleAbbreviations.keyValuePairs;
                if (abbreviations.TryGetValue(SelectedBible, out string abbreviation)) {
                    txtSearch.Text = $"{abbreviation}{StartChapter}";
                }
            }

            if (!string.IsNullOrWhiteSpace(StartVerse)) {
                txtBibleReading.Text = $"{SelectedBible} {StartChapter}장 {StartVerse}절";

                Dictionary<string, string> abbreviations = BibleAbbreviations.keyValuePairs;
                if (abbreviations.TryGetValue(SelectedBible, out string abbreviation)) {
                    txtSearch.Text = $"{abbreviation}{StartChapter}:{StartVerse}";
                }
            }

            if (!string.IsNullOrWhiteSpace(EndChapter)) {
                if (StartChapter == EndChapter) {
                    txtBibleReading.Text = $"{SelectedBible} {StartChapter}장 {StartVerse}~{EndVerse}절";

                    Dictionary<string, string> abbreviations = BibleAbbreviations.keyValuePairs;
                    if (abbreviations.TryGetValue(SelectedBible, out string abbreviation)) {
                        txtSearch.Text = $"{abbreviation}{StartChapter}:{StartVerse}~{abbreviation}{EndChapter}:{EndVerse}";
                    }
                }
                if (StartChapter != EndChapter) {
                    txtBibleReading.Text = $"{SelectedBible} {StartChapter}장 {StartVerse}절 ~ {EndChapter}장 {EndVerse}절";

                    Dictionary<string, string> abbreviations = BibleAbbreviations.keyValuePairs;
                    if (abbreviations.TryGetValue(SelectedBible, out string abbreviation)) {
                        txtSearch.Text = $"{abbreviation}{StartChapter}:{StartVerse}~{abbreviation}{EndChapter}:{EndVerse}";
                    }                    
                }
            }
            BibleReading.Text = txtBibleReading.Text;
            Search.Text = txtSearch.Text;
        }
    }
}
