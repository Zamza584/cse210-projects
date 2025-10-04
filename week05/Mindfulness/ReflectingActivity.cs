namespace mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>();
        private List<string> _questions = new List<string>();
        public ReflectingActivity()
        {
            _name = "Reflecting Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");

            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful ?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");

        }
        public void StartReflecting()
        {
            ShowSpinner(2);
            Console.WriteLine("Reflect on this prompt:");
            DisplayPrompt();
            ShowSpinner(3);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.WriteLine("Reflect on these questions related to this prompt:");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                ShowSpinner(3);
                DisplayQuestions();
                ShowSpinner(3);
            }

        }
        public string GetRandomPrompt()
        {
            Random random = new Random();
            int randomNum = random.Next(1, _prompts.Count() - 1);

            return _prompts[randomNum];
        }
        public string GetRandomQuestion()
        {

            Random random = new Random();
            int randomNum = random.Next(1, _questions.Count() - 1);

            return _questions[randomNum];

        }
        public void DisplayPrompt()
        {
            Console.WriteLine(GetRandomPrompt());
        }
        public void DisplayQuestions()
        {
            Console.WriteLine(GetRandomQuestion());
        }

    }
}