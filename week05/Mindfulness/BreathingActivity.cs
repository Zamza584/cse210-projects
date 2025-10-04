namespace mindfulness
{
    public class BreathingActivity : Activity
    {

        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
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
            }

        }
    }
}