namespace ProblemSolutions.Day4_FindDublicate
{
    public class FindDublicate
    {
        /// <summary>
        /// Finds 2 or more identical characters
        /// </summary>
        /// <param name="arg"></param>
        public void Run(string arg)
        {
            string str = arg.ToLower();
            string dublicateStr = "";
            char c;
            for (int i = 0; i < str.Length - 1; i++)
            {
                c = str[i];
                for (int j = i + 1; j < str.Length; j++)
                {
                    if(c == str[j] && !dublicateStr.Contains(c))
                    {
                        
                        dublicateStr += c;
                        break;
                    }
                }
            }
            Console.WriteLine(dublicateStr);
        }
    }
}
