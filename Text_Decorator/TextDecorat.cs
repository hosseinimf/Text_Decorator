using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Decorator.TextDecorator;

namespace Text_Decorator
{
    public class TextDecorat : IRegularText
    {
        public IRegularText TextObj { get; set; }
        public string Mark1 { get; set; }
        public string Mark2 { get; set; }
        public string Str { get; set; }

        public TextDecorat(IRegularText textObj)
        {
            TextObj = textObj;
        }

        public string GetText(string text)
        {
            return Mark1 + TextObj.GetText(text) + Mark2;
        }


    }
}
