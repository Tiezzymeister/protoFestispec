using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vragenlijst.Domain;

namespace vragenlijst.ViewModel
{
    class QuestionaireVM
    {
        private Questionaire questionaire;

        public QuestionaireVM()
        {
            questionaire = new Questionaire();
        }
        public List<Question> questions
        {
            get { return questionaire.questions; }
            set
            {
                this.questionaire.questions = value;
            }
        }
 
    }

}
