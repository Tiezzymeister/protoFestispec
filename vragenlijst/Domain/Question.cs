using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vragenlijst.Domain
{
    public abstract class Question
    {
        public abstract string QuestionString { get; set;}
        public Question()
        {

        }


    }
}
