using BibleBookAbbreviations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worship {
    public static class LoadList {
        public static ComboBox cboChurchPosition { get; set; }
        public static ComboBox cboBookName { get; set; }
        public static TextBox txtHymn { get; set; }
        public static TextBox txtWorshipPraise { get; set; }
        public static TextBox txtPrayer { get; set; }
        public static TextBox txtChoir { get; set; }
        public static TextBox txtStartChapter { get; set; }
        public static TextBox txtStartVerse { get; set; }
        public static TextBox txtEndChapter { get; set; }
        public static TextBox txtEndVerse { get; set; }
        public static TextBox txtClosingHymn { get; set; }
        public static TextBox txtOfferingHymn { get; set; }
        public static CheckBox chkpreparationScreen {  get; set; }
        public static CheckBox chkOpeningHymn { get; set; }
        public static CheckBox chkWorshipPraise { get; set; }
        public static CheckBox chkCreed { get; set; }
        public static CheckBox chkHymn { get; set; }
        public static CheckBox chkPrayer { get; set; }
        public static CheckBox chkBibleReading { get; set; }
        public static CheckBox chkChoirPraiseTitle { get; set; }
        public static CheckBox chkChoirPraiseLyrics { get; set; }
        public static CheckBox chkClosingHymn { get; set; }
        public static CheckBox chkOfferingHymn { get; set; }
        public static CheckBox chkLordsPrayer { get; set; }

        public static void loadBibleBookList(string filepath, System.Windows.Forms.ComboBox comboBox) {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string[] files = Directory.GetFiles(filepath, "*.txt");

            foreach (string str in files) {
                string fileName = Path.GetFileNameWithoutExtension(str);
                int blank = fileName.IndexOf(" ");
                string bookName = fileName.Substring(blank+1);
                comboBox.Items.Add(bookName);
                comboBox.SelectedIndex = 0;           
            }
        }

        public static void loadChurchPositionList(string filepath, System.Windows.Forms.ComboBox comboBox) {
            if (File.Exists(filepath)) {
                try {
                    string[] lines = System.IO.File.ReadAllLines(filepath);
                    foreach (string line in lines) {
                        comboBox.Items.Add(line);
                        comboBox.SelectedIndex = 0;
                    }
                } catch {
                    MessageBox.Show("메모장이 비었습니다.");
                }
            }
        }

        public static bool messageList() {
            List<string> Message = new List<string>();
            if (chkpreparationScreen.Checked == false && chkOpeningHymn.Checked == false && chkWorshipPraise.Checked == false && chkCreed.Checked == false && chkHymn.Checked == false && chkPrayer.Checked == false && chkBibleReading.Checked == false && chkChoirPraiseTitle.Checked == false && chkChoirPraiseLyrics.Checked == false && chkOfferingHymn.Checked == false && chkClosingHymn.Checked == false && chkLordsPrayer.Checked == false) {
                Message.Add("슬라이드를 선택해 주세요");
            }
            if (chkPrayer.Checked == true) {
                if (cboChurchPosition.SelectedItem == null || txtPrayer.Text == "") {
                    Message.Add("대표기도를 확인해 주세요");
                }
            }
            if (chkWorshipPraise.Checked == true) {
                if (txtWorshipPraise.Text == "") {
                    Message.Add("찬송1을 입력해 주세요");
                }
            }
            if (chkHymn.Checked == true) {
                if (txtHymn.Text == "") {
                    Message.Add("찬송2를 입력해 주세요");
                }
            }
            if (chkClosingHymn.Checked == true) {
                if (txtClosingHymn.Text == "") {
                    Message.Add("찬송3을 입력해 주세요");
                }
            }
            if (chkOfferingHymn.Checked == true) {
                if (txtOfferingHymn.Text == "") {
                    Message.Add("헌금찬송을 입력해 주세요");
                }
            }
            if (chkChoirPraiseTitle.Checked ==  true) {
                if (txtChoir.Text == "\"   \"") {
                    Message.Add("성가대 찬양을 입력해 주세요");
                }
            }
            if (chkBibleReading.Checked == true) {
                if (cboBookName.SelectedItem ==  null || txtStartChapter.Text == "" || txtStartVerse.Text == "") {
                    Message.Add("본문을 선택해 주세요");
                }
            }
            
            if (Message.Count > 0) {
                MessageBox.Show(string.Join("\n", Message));
                return true;
            }
            return false;
        }
    }
}
