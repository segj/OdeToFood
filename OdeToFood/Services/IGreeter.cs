namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetMessageOfDay();
    }

    public class Greeter : IGreeter
    {
        public string GetMessageOfDay()
        {
            return "Greetings! JA";
        }
    }
}