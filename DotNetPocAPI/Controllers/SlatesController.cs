using DotNetPocServices.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPocAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlatesController : ControllerBase
    {
        private readonly ISlateService _slateService;

        public SlatesController(ISlateService slateService)
        {
            _slateService = slateService;
        }
    }
}
