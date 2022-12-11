
namespace Advent_Of_Code_2022.Days
{
    public class Day1
    {
        Methods method = new Methods();
        public void Part1()
        {
            StreamReader sr = new StreamReader(method.path+"day1.txt");
            int elf = 0;

            List<int> q = new List<int>();

            string input = sr.ReadToEnd();
            input = input.Replace("\r", "");
            string[] test = input.Split("\n");

            foreach (string cal in test)
            {
                if (cal == "")
                {
                    q.Add(elf);
                    elf = 0;
                }
                else
                {
                    elf += int.Parse(cal);
                }
            }
            sr.Close();

            method.DayLine(1);
            method.Awnser(q.Max());
        }

        public void Part2()
        {
            StreamReader sr = new StreamReader(method.path + "day1.txt");
            int elf = 0;

            List<int> q = new List<int>();

            string input = sr.ReadToEnd();
            input = input.Replace("\r", "");
            string[] test = input.Split("\n");

            foreach (string cal in test)
            {
                if (cal == "")
                {
                    q.Add(elf);
                    elf = 0;
                }
                else
                {
                    elf += int.Parse(cal);
                }
            }
            sr.Close();

            var numbers = q.OrderByDescending(x => x).Take(3);

            method.DayLine(1);
            method.Awnser(numbers.Sum());
        }
    }
}
