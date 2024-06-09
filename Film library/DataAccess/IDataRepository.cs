
namespace Film_library.DataAccess
{
    public interface IDataRepository
    {
        List<T> Read<T>(string filePath);
        void Write<T>(string filePath, List<T> @object);
    }
}