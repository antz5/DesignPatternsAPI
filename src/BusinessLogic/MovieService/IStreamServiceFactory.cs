namespace BusinessLogic.MovieService
{
    public interface IStreamServiceFactory
    {
        IStreamService GetStreamService(StreamServiceEnum streamService);
    }
}