using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vragenlijst.Domain
{
    class SliderQeustion : Question
    {
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public int StepSize { get; set; }

        public SliderQeustion()
        {

        }
    }
}
