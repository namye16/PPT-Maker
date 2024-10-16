using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BibleBookAbbreviations;

namespace Worship {
    public static class Event {
        private static bool RichTextBoxClear = false;
        public static TextBox txtSearch { get; set; }
        public static TextBox txtBibleReading { get; set; }
        public static TextBox txtStartChapter { get; set; }
        public static TextBox txtStartVerse { get; set; }
        public static TextBox txtEndChapter { get; set; }
        public static TextBox txtEndVerse { get; set; }
        /*public static TextBox txtOfferingHymn { get; set; }
        public static TextBox txtClosingHymn { get; set; }
        public static ComboBox cboPassage { get; set; }*/

        public static void ClearText(object sender, MouseEventArgs e) {
            if (sender is TextBox textBox) {
                textBox.Text = string.Empty;
                if (textBox.Name == "txtChoir") {
                    textBox.Text = "\"   \"";
                    textBox.Select(2, 1);
                }
            }
            if (sender is RichTextBox richTextBox) {
                if (!RichTextBoxClear) {
                    richTextBox.Text = string.Empty;
                }
                RichTextBoxClear = true;
            }
            /*if (sender is ComboBox comboBox) {
                if (comboBox.Name == "cboWorshipPraise" || comboBox.Name == "cboHymn") {
                    comboBox.Text = string.Empty;
                }
            }*/
        }

        public static void AllowCertainCharacters(object sender, KeyPressEventArgs e) {
            if (sender is TextBox textBox) {
                switch (textBox.Name) {
                    case "txtPrayer":
                        if (Char.IsPunctuation(e.KeyChar) ||Char.IsDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar)) {
                            e.Handled = true;
                            MessageBox.Show("한글만 입력해 주세요.");
                        }
                        break;
                    default:
                        if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) {
                            e.Handled = true;
                            MessageBox.Show("숫자만 입력해 주세요.");
                        }
                        break;
                }
            }
            /*if (sender is ComboBox comboBox) {
                if (comboBox.Name == "cboWorshipPraise" || comboBox.Name == "cboHymn") {
                    if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) {
                        e.Handled = true;
                        MessageBox.Show("숫자만 입력해 주세요.");
                    }
                }
            }*/
        }

        public static void ShowAbbreviation(object sender, EventArgs e) {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null) {
                var ComboBoxToTextBox = new Dictionary<string, (TextBox BibleReading, TextBox Search)>
                {
                    {"cboPassage", (txtBibleReading, txtSearch)}                       
                };

                if (ComboBoxToTextBox.TryGetValue(comboBox.Name, out var textBox)) {
                    string selectFullName = comboBox.SelectedItem.ToString();
                    textBox.BibleReading.Text = selectFullName;

                    Dictionary<string, string> abbreviations = BibleAbbreviations.keyValuePairs;
                    if (abbreviations.TryGetValue(selectFullName, out string abbreviation)) {
                        textBox.Search.Text = abbreviation;
                    }
                }
            }
        }

        public static void ResetFirstChapterVerse(object sender, EventArgs e) {
            txtStartChapter.Text = "";
            txtStartVerse.Text = "";
            txtEndChapter.Text = "";
            txtEndVerse.Text = "";
        }
    }
}
