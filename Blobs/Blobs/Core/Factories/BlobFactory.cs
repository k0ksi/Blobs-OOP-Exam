using Blobs.Interfaces;
using Blobs.Models;

namespace Blobs.Core.Factories
{
    public class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(string name, int health, int damage, IBehavior behavior, IAttack attack)
        {
            var blob = new Blob(name, health, damage, behavior, attack);

            return blob;
        }
    }
}