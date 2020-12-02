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
        public IEnumerable<Technic> AllTechnics { get
            {
                return new List<Technic>
                { 
                    new Technic{quantity=1, path="", delay=50, duration=120, RequestId=1, ExecutorId=1, TypeTechnicId=1, TypeTechnic=_typeTechnic.AllType.First()},
                    new Technic{quantity=1, path="", delay=50, duration=180, RequestId=1, ExecutorId=1, TypeTechnicId=2, TypeTechnic=_typeTechnic.AllType.Last() }
                };
            }
         }

        public Technic getObjectTechnic(int technicId)
        {
            throw new NotImplementedException();
        }
    }
}
