using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Reflection
{
    public class MoodAnalyser
    {
        public string message;
        //public MoodAnalyser()
        //{
        //}

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            string mood;
            if (message == "I am in a Happy mood")
                mood = "Happy";
            else if (message == "I am in a Sad mood")
                mood = "Sad";
            else
                mood = null;
            return mood;
        }
    }
}