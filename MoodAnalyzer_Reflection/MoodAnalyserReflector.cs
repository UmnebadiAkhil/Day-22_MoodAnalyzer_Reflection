using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Reflection
{
    public class MoodAnalyserReflector
    {

        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserApp.MoodAnalyser");
                object moodAnalyserObject = MoodAnalyserFactory.CreateObjectOfMoodAnalyserUsingParameterizedConstructor("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser", message);
                MethodInfo method = type.GetMethod(methodName);
                object mood = method.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException e)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "No such method found");
            }
        }
    }
}
