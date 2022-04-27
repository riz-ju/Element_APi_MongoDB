using DotNetPocModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPocRepositories.Interface
{
    public interface IElementRepository
    {
        public List<Element> GetR();
        public List<Element> GetR(string id);

        public Element PostR(Element elem);
        public dynamic PutR(string id,Element elem);

        public void DeleteR(string id);
    }
}
