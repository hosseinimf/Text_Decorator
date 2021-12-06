using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Decorator.TextDecorator
{
    public class DeletedText : TextDecorat, IDeletedText
    {
        public DeletedText(IRegularText textObj) : base(textObj)
        {
            Mark1 = "<del>";
            Mark2 = "</del>";
        }
    }
}
