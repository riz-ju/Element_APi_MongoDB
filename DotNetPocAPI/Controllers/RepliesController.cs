using DotNetPocServices.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPocAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepliesController : ControllerBase
    {
        private readonly IReplyService _replyService;

        public RepliesController(IReplyService replyService)
        {
            _replyService = replyService;
        }
    }
}
