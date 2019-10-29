using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vragenlijst.Domain
{
    class TextQuestion : Question
    {
        public int MaxChars { get; set; }

        public TextQuestion()
        {

        }
    }
}
