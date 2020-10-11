using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNetCore.Models;

namespace WebApiNetCore.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil 0 egg", Line = "Water", Platform = "Pan" },
                new Command { Id = 1, HowTo = "Boil 1 egg", Line = "Milk", Platform = "Pan" },
                new Command { Id = 2, HowTo = "Boil 2 egg", Line = "Whiskey", Platform = "Pan" }
            };
            return commands;
            
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Water", Platform = "Pan" };
        }
    }
}
