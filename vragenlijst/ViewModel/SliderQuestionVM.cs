using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vragenlijst.Domain;

namespace vragenlijst.ViewModel
{
    public class SliderQuestionVM
    {

        private SliderQuestion sliderQuestion;

        public SliderQuestionVM()
        {
            sliderQuestion = new SliderQuestion();
        }
        public string Question
        {
            get
            {
                return sliderQuestion.QuestionString;
            }
            set
            {
                sliderQuestion.QuestionString = value;
            }
        }

        public int MinVal
        {
            get
            {
                try
                {
                    return sliderQuestion.MinValue;

                }
                catch (NullReferenceException)
                {
                    return 0;
                }
            }
            set
            {
                //if (value > MaxVal)
                //{
                //    throw new MinValHigherThanMaxValException();
                //}
                //else
                //{
                    sliderQuestion.MinValue = value;
                //}

            }
        }
        public int MaxVal
        {
            get
            {
                try
                {
                    return sliderQuestion.MaxValue;
                }
                catch (NullReferenceException)
                {
                    return 99999999;
                }
                
            }
            set
            {
                //if (value < MinVal)
                //{
                //    throw new MinValHigherThanMaxValException();
                //}
                sliderQuestion.MaxValue = value;
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
                //if( value > MaxVal || value <= 0)
                //{
                //    throw new InvalStepSizeException();
                //}
                //else
                //{
                    sliderQuestion.StepSize = value;
                //}

            }
        }
        public SliderQuestion ToModel()
        {
            return sliderQuestion;
        }

    }
}
    