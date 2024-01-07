using System.Threading.Channels;

namespace ProblemSolutions.Day12_TermSplit
{
    public class TermSplit
    {
        public void Run(string str)
        {
            //string bracketString = "";
            //bool isBracketOpen = false;
            //for(int i = 0; i < str.Length; i++)
            //{
            //    var c = str[i];
            //    if(c == '(')
            //    {
            //        bracketString += str[i];
            //        isBracketOpen = true;
            //        continue;
            //    }
            //    if(c == ')')
            //    {
            //        bracketString += str[i];
            //        isBracketOpen = false;
            //        continue;
            //    }
            //    if(isBracketOpen)
            //    {
            //        bracketString += str[i];
            //    }
            //    if(!isBracketOpen)
            //}
            List<string> termList = new List<string>();
            termList.AddRange(str.Split(new char[]
            {
                '+',
                '-'
            }));
            termList.ForEach(Console.WriteLine);
        }
    }
}
