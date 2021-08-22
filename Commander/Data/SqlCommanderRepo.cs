using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Commander.Models;


namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context = null;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            var command = _context.Commands.FirstOrDefault(command => command.Id == id);

            return command;
        }
    }
}
