using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vragenlijst.Domain;

namespace vragenlijst.ViewModel
{
    public class SliderQuestionVM : QuestionVM
    {
        public SliderQuestion sliderQuestion;
        public SliderQuestionVM()
        {
            sliderQuestion = new SliderQuestion();
        }
        public int MaxVal { 
            get
            {
                return sliderQuestion.MaxValue;
            } 
            set 
            {
                sliderQuestion.MaxValue = value;
            }   
        }
        public int MinValue
        {
            get
            {
                return sliderQuestion.MinValue;
            }
            set
            {
                sliderQuestion.MinValue = value;
            }
        }
        public int Stepsize
        {
            get
            {
                return sliderQuestion.StepSize;
            }
            set
            {
                sliderQuestion.StepSize = value;
            }
        }
        public SliderQuestion ToModel()
        {
            return sliderQuestion;
        }
    }
}
    