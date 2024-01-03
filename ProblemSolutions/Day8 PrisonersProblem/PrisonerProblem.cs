namespace ProblemSolutions.Day8_PrisonersProblem
{
    public class PrisonerProblem
    {
        private const int PRISONER_NUMBER = 100;
        private readonly HashSet<int> boxes = new HashSet<int>();
        public PrisonerProblem()
        {
            boxes.Add(0);
            LoadBoxes();
            Console.WriteLine("tamamlandı");
        }

        private void LoadBoxes()
        {
            while (boxes.Count < PRISONER_NUMBER + 1)
            {
                Random rand = new Random();
                boxes.Add(rand.Next(1, 101));
            }
        }

        public bool Run()
        {
            int winCount = 0;
            for (int i = 1; i < PRISONER_NUMBER + 1; i++)
            {
                int counter = 0;
                int temp = i;
                while (true)
                {
                    if (boxes.ElementAt(temp) == i)
                    {
                        winCount++;
                        break;
                    }
                    else
                    {
                        temp = boxes.ElementAt(temp);
                        counter++;
                    }
                    if (counter > 50)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("win count -> {0}", winCount);
            if(winCount == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
