namespace Exercise.Domain.Api
{
    /// <summary>
    /// Public layer of API.
    /// Returns message information from a provider.
    /// </summary>
    public interface IMessageService
    {
        string GetHelloWorldMessage();
    }
}
