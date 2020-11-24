using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.mocks
{
    public class MockTechnic : ITechnic
    {
        private readonly ITypeTechnic _typeTechnic = new MockTypeTechnic();
        public IEnumerable<Technic> Technics { get
            {
                return new List<Technic>
                { 
                    new Technic{quantity=1, path="", delay=0, duration=0, id_request=1, id_executor=1, id_Type=1, type=_typeTechnic.AllType.First()},
                    new Technic{quantity=1, path="", delay=0, duration=0, id_request=1, id_executor=1, id_Type=2, type=_typeTechnic.AllType.Last() }
                };
            }
         }

        public Technic getObjectTechnic(int technicId)
        {
            throw new NotImplementedException();
        }
    }
}
