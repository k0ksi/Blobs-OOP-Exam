using System.Windows.Input;

namespace Blobs.Interfaces
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandName, IEngine engine);
    }
}