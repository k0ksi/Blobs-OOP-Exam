using Blobs.Interfaces;

namespace Blobs.Core.Engine.Commands
{
    public abstract class Command : ICommand
    {
        protected Command(IEngine engine)
        {
            this.Engine = engine;
        }

        public IEngine Engine { get; }

        public abstract void Execute(params string[] commandParams);
    }
}