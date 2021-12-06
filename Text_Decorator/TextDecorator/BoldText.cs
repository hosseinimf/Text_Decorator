using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Decorator.TextDecorator
{
    public class BoldText : TextDecorat, IBoldText
    {
        public BoldText(IRegularText textObj) : base(textObj)
        {
            Mark1 = "<b>";
            Mark2 = "</b>";
        }
    }
}
