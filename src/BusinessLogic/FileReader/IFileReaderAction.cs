using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IFileReaderAction
    {
        string Read(string path);

    }
}