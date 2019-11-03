using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vragenlijst.Domain;

namespace vragenlijst.ViewModel
{

    public class TextQuestionVM
    {
        public TextQuestion textQuestion;
        public TextQuestionVM()
        {
            textQuestion = new TextQuestion();
        }

        public string Question
        {
            get
            {
                return textQuestion.QuestionString;
            }
            set
            {
                textQuestion.QuestionString = value;
            }
        }
        public int MaxChars
        {
            get
            {
                return textQuestion.MaxChars;
            }
            set
            {
                textQuestion.MaxChars = value;
            }
        }
        public TextQuestion ToModel()
        {
            return textQuestion;
        }
    }

}
