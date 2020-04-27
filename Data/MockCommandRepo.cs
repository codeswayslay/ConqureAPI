using ConqureAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConqureAPI.Data
{
    public class MockCommandRepo : ICommandRepo
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return new List<Command>
            {
                new Command { Id = 0, HowTo = "Kill a killer", Line = "Get a gun", Platform = "Killer's club" },
                new Command { Id = 1, HowTo = "Fry eggs", Line = "Get a frying pan", Platform = "Pan club" },
                new Command { Id = 2, HowTo = "Buy a laptop", Line = "Go to computer village", Platform = "Laptop Center" },
                new Command { Id = 3, HowTo = "Toast a babe", Line = "Chase babe", Platform = "Kennedy's layer" }
            };
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Kill a killer", Line = "Get a gun", Platform = "Killer's club" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
