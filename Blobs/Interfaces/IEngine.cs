using System.Collections.Generic;

namespace Blobs.Interfaces
{
    public interface IEngine
    {
        IBlobFactory BlobFactory { get; }

        IAttackFactory AttackFactory { get; }

        IBehaviorFactory BehaviorFactory { get; }

        IEnumerable<IBlob> Blobs { get; } 

        ICommandFactory CommandFactory { get; }

        void Run();

        void ExecuteCommand(string commandInput);

        void Render(string message, params object[] parameters);

        void AddBlob(IBlob blob);
    }
}