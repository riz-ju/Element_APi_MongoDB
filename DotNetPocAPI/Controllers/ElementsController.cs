using DotNetPocData;
using DotNetPocModels.Models;
using DotNetPocServices.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetPocAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsController : ControllerBase
    {
        private readonly IElementService _elementService;
        public ElementsController(IElementService elementService)
        {
            _elementService = elementService;
        }

        [HttpGet]
        public dynamic Get()
        {
           return _elementService.GetS();
           
        }

        // GET api/<ElementsController>/5
        [HttpGet("{id}")]
        public List<Element> Get(string id)
        {
            return _elementService.GetS(id);

        }

        // POST api/<ElementsController>
        [HttpPost]
        public Element Post([FromBody] Element elems)
        {

           
            return _elementService.PostS(elems);
        }

        // PUT api/<ElementsController>/5
        [HttpPut("{id}")]
        public dynamic Put([FromBody] Element elem,string id) 
        {
           
            return _elementService.PutS(id,elem);
        }

        // DELETE api/<ElementsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
          _elementService.DeleteS( id);
          
        }
    }
}
