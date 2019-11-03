using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vragenlijst.Domain
{
    public class TextQuestion : Question
    {
        public int MaxChars { get; set; }
        public override string QuestionString { get ; set; }

        public TextQuestion()
        {

        }
    }
}
