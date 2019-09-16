using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using CmdApi.Models;
 namespace CmdApi.Controllers
 
 {

[Route("api/[controller]")]
[ApiController]
 public class CommandsController: ControllerBase 
 {

   private readonly CommandContext _context;

   public CommandsController(CommandContext _context){

   this._context=_context;


   }

    //GET:       api/commands
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetCommands(){

       return _context.Commands;
    }
//GET:       api/commands/n
   [HttpGet("{id}")]
   public ActionResult<Command> GetCommandById(int id){

        var command = _context.Commands.Find(id);
        if(command == null) return NotFound();

        return command;
   }


//POST:    api/commands
[HttpPost]
public ActionResult<Command> PostCommand(Command command){

   _context.Commands.Add(command);
   _context.SaveChanges();

   return CreatedAtAction("GETheCommand", new Command{Id= command.Id}, command);

}

//Put:    api/commands/j
[HttpPut("{id}")]
public ActionResult<Command> PutCommand(int id,Command command){

if(id != command.Id) return BadRequest();

_context.Entry(command).State = EntityState.Modified;

_context.SaveChanges();

return NoContent();

}

//DELETE:    api/commands/k
[HttpDelete("{id}")]
public ActionResult<Command> PostCommand(int id){

    var command = _context.Commands.Find(id);

   if(command == null) return NotFound();

   _context.Commands.Remove(command);

   return command;
}
  

/* 
    [HttpGet]
    public ActionResult<IEnumerable<string>> GetString(){
      
       return new string [] {"this", "is", "MVC Arch"};

    }
*/
 }

 }