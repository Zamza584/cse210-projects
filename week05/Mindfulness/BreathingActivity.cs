namespace mindfulness
{
    public class BreathingActivity : Activity
    {

        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "In this activity you will breath in and out for 5 seconds each.";
        }

        public void StartBreathing()
        {

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
    
                Console.Write("Breathe in... ");
                ShowCountDown(5);
                Console.WriteLine("");
                Console.Write("Breathe out... ");
                ShowCountDown(5);
                Console.WriteLine("");

            }

        }
    }
}