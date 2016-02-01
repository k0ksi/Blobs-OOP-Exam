using System;
using Blobs.Exceptions;
using Blobs.Interfaces;

namespace Blobs.Models
{
    public abstract class Behavior : IBehavior
    {
        private IBlob blob;

        public IBlob Blob
        {
            get { return this.blob; }
            set
            {
                if (value == null)
                {
                    throw new GameObjectPropertyNullException(String.Format(Messages.Messages.NullGameObject, nameof(this.blob)));
                }

                this.blob = value;
            }
        }

        public bool IsTriggered { get; set; }

        public int TurnsSinceTriggered { get; set; }
        
        public void TriggerBehavior()
        {
            if (this.TurnsSinceTriggered == 0)
            {
                this.UpdateOnTrigger();
            }
        }

        public abstract void UpdateOnTrigger();

        public abstract void UpdateOnTurn();
    }
}