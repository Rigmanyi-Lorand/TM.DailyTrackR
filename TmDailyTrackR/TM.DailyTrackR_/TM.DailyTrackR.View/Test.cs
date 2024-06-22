using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.DailyTrackR.View
{
    internal class Test
    {
        public Test(string text, bool check, List<string> combobox, string link)
        {
            this.Text = text;
            this.ComboboxList = combobox;
            this.Check = check;
            this.Link = link;
        }
        public string Text { get; set; }

        public bool Check { get; set; }

        public List<string> ComboboxList { get; set; }

        public string Link { get; set; }
    }
}
