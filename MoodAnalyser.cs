using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyzerMood()
        {
            try
            {
                if (this.message.ToLower().Contains("sad"))
                    return "Sad";
                else
                return "Happy";
            }
            catch (Exception ex)
            {
                return "Happy";
            }
        }


    }
}
