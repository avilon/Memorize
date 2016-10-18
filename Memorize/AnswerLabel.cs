using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorize
{
    class AnswerLabel : Label
    {
        public AnswerLabel(int index)
            : base()
        {
            ndx = index;
        }

        public int Index
        {
            get
            {
                return ndx;
            }
        }

        private int ndx;
    }
}
