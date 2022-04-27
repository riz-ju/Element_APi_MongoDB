using DotNetPocRepositories.Interface;
using DotNetPocServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPocServices.Service
{
    public class SlateService : ISlateService
    {
        private readonly ISlateRepository _slateRepository;

        public SlateService(ISlateRepository slateRepository)
        {
            _slateRepository = slateRepository;
        }
    }
}
