using System;
using System.Collections.Generic;
using System.Text;

namespace NewEnglishMegaProject
{
    class EnglishFile
    {
        public EnglishFile(int day, string month, List<TranslateSource> translateSources)
        {
            Day = day;
            Month = month;
            TranslateSources = translateSources;
        }
        public int Day { get; }
        public string Month { get; }
        public List<TranslateSource> TranslateSources { get; }
    }

}
