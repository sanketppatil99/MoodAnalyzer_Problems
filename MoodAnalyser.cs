using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        public string AnalyzerMood(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "Sad";
            else
            return "Happy";
        }
    }
}
