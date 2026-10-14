using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiniProject.Models
{
    public class AnswerList : List<Answer>
    {
        public AnswerList() : base() { }
        public AnswerList(IEnumerable<Answer> answers) : base(answers)
        {

        }
    }
}
