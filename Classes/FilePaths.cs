using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worship
{
    internal class FilePaths
    {
        public string MainPptFilePath { get; set; }
        public string ChoirPraiseTitlePptFilePath { get; set; }
        public string BibleTitlePptFilePath { get; set; }
        public string CreedPptFilePath { get; set; }
        public string PrayerPptFilePath { get; set; }
        public string VersePptFilePath { get; set; }
        public string LyricsPptFilePath { get; set; }
        public string HymnPptFolderFilePath { get; set; }
        public string BibleTxtFolderFilePath { get; set; }
        public string ChurchPositionTxtFilePath { get; set; }
        public string selectFirstVerseTxtFilePath { get; set; }
        public string selectSecondVerseTxtFilePath { get; set; }
        public string ChoirBackgroundFilePath { get; set; }
        public string ChoirPraiseLyricsFilePath { get; set; }
        public string OpeningHymnPptFilePath { get; set; }
        public string OfferingHymnPptFilePath { get; set; }
        public string ClosingHymnPptFilePath { get; set; }
        public FilePaths()
        {
            MainPptFilePath = "C:\\WorshipPPT\\Main.pptx";
            ChoirPraiseTitlePptFilePath = "C:\\WorshipPPT\\ChoirPraiseTitle.pptx";
            BibleTitlePptFilePath = "C:\\WorshipPPT\\BibleTitle.pptx";
            CreedPptFilePath = "C:\\WorshipPPT\\Creed.pptx";
            PrayerPptFilePath = "C:\\WorshipPPT\\Prayer.pptx";
            VersePptFilePath = "C:\\WorshipPPT\\Verse.pptx";
            ChoirBackgroundFilePath = "C:\\WorshipPPT\\ChoirBackground.pptx";
            ChoirPraiseLyricsFilePath = "C:\\WorshipPPT\\ChoirPraiseLyrics.pptx";
            OpeningHymnPptFilePath = "C:\\WorshipPPT\\OpeningHymn.pptx";
            OfferingHymnPptFilePath = "C:\\WorshipPPT\\OfferingHymn.pptx";
            ClosingHymnPptFilePath = "C:\\WorshipPPT\\ClosingHymn.pptx";

            HymnPptFolderFilePath = "C:\\WorshipPPT\\Hymn";
            BibleTxtFolderFilePath = "C:\\WorshipPPT\\Bible";
            ChurchPositionTxtFilePath = "C:\\WorshipPPT\\ChurchPosition.txt";
            selectFirstVerseTxtFilePath  = "C:\\WorshipPPT\\Bible2\\{selectFirstVerse}.txt";
            selectSecondVerseTxtFilePath  = "C:\\WorshipPPT\\Bible2\\{selectSecondVerse}.txt"
;        }        
    }
}
