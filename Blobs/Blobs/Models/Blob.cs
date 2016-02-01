using System;
using Blobs.Attributes;
using Blobs.Exceptions;
using Blobs.Interfaces;

namespace Blobs.Models
{
    [GameObject]
    public class Blob : GameObject, IBlob
    {
        private int health;
        private int attackDamage;
        private IBehavior behavior;
        private IAttack attack;

        public Blob(
            string name,
            int health,
            int attackDamage,
            IBehavior behavior,
            IAttack attack) 
            : base(name)
        {
            this.Name = name;
            this.Health = health;
            this.AttackDamage = attackDamage;
            this.Behavior = behavior;
            this.AttackType = attack;
        }

        public int AttackDamage
        {
            get { return this.attackDamage; }
            set
            {
                if (value < 0)
                {
                    throw new GameObjectPropertyOutOfRangeException(
                        String.Format(Messages.Messages.NegativePropertyException, nameof(this.attackDamage)));
                }

                this.attackDamage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.health = value;
            }
        }

        public IBehavior Behavior
        {
            get { return this.behavior; }
            set
            {
                if (value == null)
                {
                    throw new GameObjectPropertyNullException(string.Format(Messages.Messages.NullGameObject, nameof(this.behavior)));
                }

                this.behavior = value;
            }
        }

        public IAttack AttackType
        {
            get { return this.attack; }
            set
            {
                if (value == null)
                {
                    throw new GameObjectPropertyNullException(string.Format(Messages.Messages.NullGameObject, nameof(this.attack)));
                }

                this.attack = value;
            }
        }

        public bool IsAlive => this.Health > 0;

        public override string ToString()
        {
            string blobDetails = $"Blob {this.Name}";
            if (this.IsAlive)
            {
                blobDetails += $": {this.Health} HP, {this.AttackDamage} Damage";
            }
            else
            {
                blobDetails += " KILLED";
            }

            return blobDetails;
        }
    }
}