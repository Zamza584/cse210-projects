namespace mindfulness
{
    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts = new List<string>();

        public ListingActivity()
        {
            _name = "Listing Activity";
            _description = "In this activity you will be given a question and you will be given some time to respond to this question.";

            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");


        }
        public void StartListing()
        {
            Console.WriteLine("Please think about the following prompt:");
            ShowSpinner(2);
            Console.WriteLine(GetRandomPrompt());
            Console.WriteLine("When ready press enter:");
            Console.ReadLine();
            Console.Write("Begin writing in: ");
            ShowCountDown(5);
            Console.WriteLine("");


            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.ReadLine();
                _count++;
            }
            Console.WriteLine($"Number of Items entered: {_count}");

        }
        public string GetRandomPrompt()
        {

            Random random = new Random();
            int randomNum = random.Next(1, _prompts.Count() + 1);
            return _prompts[randomNum];

        }
    }
}