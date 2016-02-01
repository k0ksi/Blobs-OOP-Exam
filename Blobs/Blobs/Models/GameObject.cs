using System;
using Blobs.Exceptions;
using Blobs.Interfaces;

namespace Blobs.Models
{
    public abstract class GameObject : IGameObject
    {
        private string name;

        protected GameObject(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new GameObjectNullOrEmptyException(String.Format(Messages.Messages.StringCannotBeNullOrEmpty,
                        nameof(this.name)));
                }

                this.name = value;
            }
        }
    }
}