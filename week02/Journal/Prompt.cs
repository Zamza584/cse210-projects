public class Prompt
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {

        Random random = new Random();
        int randomNumber = random.Next(1, 5); // I believe I used ai help to understand this next function

        return _prompts[randomNumber];
    }
}