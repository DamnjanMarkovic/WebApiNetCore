using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiNetCore.Data;
using WebApiNetCore.Models;

namespace WebApiNetCore.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;

        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET/   api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        //GET/   api/commands/5
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandByID(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);

        }
    }
}
