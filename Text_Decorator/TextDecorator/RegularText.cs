using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Decorator.TextDecorator
{
    public class RegularText : IRegularText
    {
        public string Text { get; set; }
        public string Mark1 { get; set; } = "";
        public string Mark2 { get; set; } = "";
        public RegularText()
        {
            
        }


        public string GetText(string text)
        {
            return Mark1 + text + Mark2;
        }
    }
}
