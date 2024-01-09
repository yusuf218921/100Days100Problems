namespace ProblemSolutions.Day15_Arrow
{
    public class Arrow
    {
        public string[] ArrowRun(int num)
        {
            bool reverse = false;
            int length = num % 2 == 0 ? num * 2 : num * 2 - 1;
            string[] arrow = new string[length];
            for (int i = 0; i < length; i++)
            {
                if(i == (int)Math.Ceiling((double)length / 2))
                    reverse = true;
                if (!reverse)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        arrow[i] += "<";
                    }
                }
                else 
                {
                    for (int j = length - i; j > 0 ; j--)
                    {
                        arrow[i] += "<";
                    }
                }
            }
            return arrow;
        }
    }
}
