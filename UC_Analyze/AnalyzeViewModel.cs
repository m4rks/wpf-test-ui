using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_Analyze
{
    public class AnalyzeViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private string displayText;

        public string DisplayText
        {
            get { return displayText; }
            set { displayText = value; }
        }


        public AnalyzeViewModel()
        {
            Name = "Name prop";
            DisplayText = "Displaytext Prop";
            Text = "Text prop";
        }
    }
}
