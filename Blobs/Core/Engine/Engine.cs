using System;
using System.Collections.Generic;
using System.Linq;
using Blobs.Interfaces;

namespace Blobs.Core.Engine
{
    public class Engine : IEngine
    {
        private readonly IRenderer renderer;
        private readonly IInputController inputController;
        private readonly ICollection<IBlob> blobs;

        public Engine(IRenderer renderer, IInputController inputController,  ICommandFactory commandFactory, IBlobFactory blobFactory, IAttackFactory attackFactory, IBehaviorFactory behaviorFactory)
        {
            this.renderer = renderer;
            this.inputController = inputController;
            this.CommandFactory = commandFactory;
            this.blobs = new List<IBlob>();
            this.BlobFactory = blobFactory;
            this.AttackFactory = attackFactory;
            this.BehaviorFactory = behaviorFactory;
        }

        public IBlobFactory BlobFactory { get; }

        public IAttackFactory AttackFactory { get; }

        public IBehaviorFactory BehaviorFactory { get; }

        public IEnumerable<IBlob> Blobs => this.blobs;

        public ICommandFactory CommandFactory { get; }

        public void Run()
        {
            while (true)
            {
                string commandInput = this.inputController.ReadInput();


                this.ExecuteCommand(commandInput);
                this.IncrementTurnsSinceTriggeredCount();
                this.UpdateBlobs();
            }
        }

        public void ExecuteCommand(string commandInput)
        {
            const string commandSuffix = "Command";

            var commandInfo = commandInput.Split();
            var commandName = commandInfo[0].Replace("-", string.Empty) + commandSuffix;
            var commandParams = commandInfo.Skip(1).ToArray();

            var command = this.CommandFactory.CreateCommand(commandName, this);

            command.Execute(commandParams);
        }

        public void Render(string message, params object[] parameters)
        {
            this.renderer.Print(message, parameters);
        }

        public void AddBlob(IBlob blob)
        {
            this.blobs.Add(blob);
        }

        private void IncrementTurnsSinceTriggeredCount()
        {
            foreach (var blob in this.Blobs)
            {
                if (blob.Behavior.IsTriggered)
                {
                    blob.Behavior.TurnsSinceTriggered++;
                }
            }
        }

        private void UpdateBlobs()
        {
            foreach (var blob in this.Blobs)
            {
                if (blob.Behavior.IsTriggered && blob.Behavior.TurnsSinceTriggered > 1)
                {
                    blob.Behavior.UpdateOnTurn();
                }
            }
        }
    }
}