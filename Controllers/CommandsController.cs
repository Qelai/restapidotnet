using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

 namespace CmdApi.Controllers
 
 {

[Route("api/hello")]
[ApiController]
 public class CommandsController: ControllerBase 
 {

    [HttpGet]
    public ActionResult<IEnumerable<string>> GetString(){
      
       return new string [] {"this", "is", "MVC Arch"};

    }

 }

 }