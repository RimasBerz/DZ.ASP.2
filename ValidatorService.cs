using System.Text.RegularExpressions;

namespace WebApplication1.Servicies
{
    public class ValidatorService : IValidatorService
    {
        public bool ValidateNonEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            return true;
        }

        public bool ValidateLogin(string login)
        {
            return Regex.IsMatch(login, @"^[a-zA-Z_][a-zA-Z0-9_]*$");
        }
    }
}
