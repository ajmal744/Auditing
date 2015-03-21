namespace Auditing.Core
{
    public interface IFileVersionProvider
    {
        string CurrentAssemblyLocation { get; set; }

        string GetExecutingAssemblyFileVersion();
    }
}
