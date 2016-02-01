using System;
using System.Linq;
using System.Reflection;
using Blobs.Attributes;
using Blobs.Interfaces;

namespace Blobs.Core.Factories
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand CreateCommand(string commandName, IEngine engine)
        {
            var commandType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(
                    c =>
                        c.CustomAttributes.Any(a => a.AttributeType == typeof(CommandAttribute)) &&
                        c.Name.ToLower() == commandName.ToLower());

            //if (commandType == null)
            //{
            //    throw new ArgumentNullException(nameof(commandType), "Unknown command");
            //}

            var command = Activator.CreateInstance(commandType, engine) as ICommand;

            return command;
        }
    }
}