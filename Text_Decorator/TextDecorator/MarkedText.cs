using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Decorator.TextDecorator
{
    public class MarkedText :TextDecorat, IMarkedText
    {
        public MarkedText(IRegularText textObj) : base(textObj)
        {
            Mark1 = "<mark>";
            Mark2 = "</mark>";
        }
    }
}
