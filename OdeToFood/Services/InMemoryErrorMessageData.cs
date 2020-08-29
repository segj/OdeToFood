using OdeToFood.Models;


namespace OdeToFood.Services
{
    public class InMemoryErrorMessageData : IErrorMessageData
    {
        public ErrorMessage GetModelNullException()
        {
            ErrorMessage _errorMessage = new ErrorMessage
            {
                id = 1,
                message = "Model nullpoiter exception"
            };

            return _errorMessage;
        }
        
    }
}
