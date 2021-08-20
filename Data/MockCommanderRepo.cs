using System.Collections.Generic;

using Commander.Models;

namespace Commander.Data
{
    public class MockCommander : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {

            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut onion", Line = "Take knife, cut it", Platform = "Wooden plate" },
                new Command { Id = 2, HowTo = "Serve a dish", Line = "Take dish, serve it", Platform = "Table" },
            };

            return commands;
        }
        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }

    }
}