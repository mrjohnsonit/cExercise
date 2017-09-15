namespace Exercise.Domain.Api
{
    /// <summary>
    /// Provides messages from a data source.
    /// </summary>
    public interface IMesssageProvider
    {
        string GetHelloWorldMessage();
    }
}
