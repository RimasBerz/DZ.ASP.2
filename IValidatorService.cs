namespace WebApplication1.Servicies
{
    public interface IValidatorService
    {
        bool ValidateNonEmpty(string input);
        bool ValidateLogin(string login);
    }
}
