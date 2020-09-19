using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RESTapi.Models;
using RESTapi.Data;

namespace RESTapi.Controllers{

    [Route("api/command")]
    [ApiController]
    public class CommandsController : ControllerBase{
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        //Command list
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands(){
            var commandlist = _repository.GetAllCommands();
            return Ok(commandlist);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id){
            var commanditem = _repository.GetCommandById(id);
            return Ok(commanditem);
        }
    }
}