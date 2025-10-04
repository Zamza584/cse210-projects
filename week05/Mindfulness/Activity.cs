
using System.Dynamic;

namespace mindfulness
{
    public class Activity
    {
        protected int _duration;
        protected string _name;
        protected string _description;

        public Activity()
        {
        }
        public void DisplayStartMessage()
        {
            Console.WriteLine($"{_name}");
            Console.WriteLine($"{_description}");
            Console.Write($"How long in seconds will this session take?: ");
            _duration = int.Parse(Console.ReadLine());
        }

        public void DisplayEndMessage()
        {
            Console.WriteLine($"Good job with completing the activity ");
            Thread.Sleep(1000);
            Console.WriteLine($"Name of activity: {_name} Duration: {_duration} seconds, Hope you have a lovely day =)");
            Thread.Sleep(5000);
        }

        public void ShowSpinner(int seconds)
        {
            List<string> animations = new List<string>();

            animations.Add("|");
            animations.Add("/");
            animations.Add("-");
            animations.Add("\\");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(animations[i]);
                Thread.Sleep(500);
                Console.Write("\b \b");

                i++;

                if (i > 3)
                {
                    i = 0;
                }
            }

        }
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public int GetDuration()
        {
            return _duration;
        }

    }
}
