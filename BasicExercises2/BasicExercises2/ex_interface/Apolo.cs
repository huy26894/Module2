using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2
{
    class Apolo : IRank
    {
        public string Ranking(float score)
        {
            if(score >= 85)
            {
                return "Distinction";
            }
            if (score >= 65)
            {
                return "Credit";
            }
            if (score >= 40)
            {
                return "Pass";
            }
            return "Fail";
        }
    }
}
