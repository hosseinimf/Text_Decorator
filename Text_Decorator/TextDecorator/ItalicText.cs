using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Decorator.TextDecorator
{
    class ItalicText : TextDecorat, IItalicText
    {
        public ItalicText(IRegularText textObj) : base(textObj)
        {
            Mark1 = "<i>";
            Mark2 = "</i>";
        }
    }
}
