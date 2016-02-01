using Blobs.Core.Engine;
using Blobs.Core.Factories;
using Blobs.Interfaces;
using Blobs.IO;

namespace Blobs
{
    class BlobsMain
    {
        static void Main()
        {
            IInputController inputController = new ConsoleInputController();
            IRenderer renderer = new ConsoleRenderer();

            ICommandFactory commandFactory = new CommandFactory();
            IBlobFactory blobFactory = new BlobFactory();
            IAttackFactory attackFactory = new AttackFactory();
            IBehaviorFactory behaviorFactory = new BehaviorFactory();

            IEngine engine = new Engine(renderer, inputController, commandFactory, blobFactory, attackFactory,
                behaviorFactory);

            engine.Run();
        }
    }
}
