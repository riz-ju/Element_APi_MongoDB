using DotNetPocRepositories.Interface;
using DotNetPocServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPocServices.Service
{
    public class ReplyService : IReplyService
    {
        private readonly IReplyRepository _replyRepository;

        public ReplyService(IReplyRepository replyRepository )
        {
            _replyRepository = replyRepository;
        }
    }
}
