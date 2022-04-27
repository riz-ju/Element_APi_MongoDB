using DotNetPocModels.Models;
using DotNetPocRepositories.Interface;
using DotNetPocServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPocServices.Service
{
    public class ElementService : IElementService
    {
        private readonly IElementRepository _elementRepository;

        public ElementService(IElementRepository elementRepository)
        {
            _elementRepository = elementRepository;
        }

        public void DeleteS(string id)
        {
            _elementRepository.DeleteR(id);
        }

        public List<Element> GetS()
        {
            return _elementRepository.GetR();
           
        }

        public List<Element> GetS(string id)
        {
          return  _elementRepository.GetR(id);
           
        }

        public Element PostS(Element elem)
        {
            return _elementRepository.PostR(elem);
            
        }

        public dynamic PutS(string id,Element elem)
        {
            return _elementRepository.PutR(id,elem);
        }
    }
}
