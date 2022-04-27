using DotNetPocModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPocServices.Interface
{
    public interface IElementService
    {
        public List<Element> GetS();
        public List<Element> GetS(string id);

        public Element PostS(Element elem);
        public dynamic PutS(string id,Element elem);

        public void DeleteS(string id);


    }
}
