using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.mocks
{
    public class MockRequest : IRequest
    {
        private readonly ITechnic _technic = new MockTechnic();
        public IEnumerable<Request> AllRequests
        {
            get
            {
                return new List<Request>
                {
                    new Request{id_Shop=1, id_Responsible=1, date_begin=0, date_end=1, description="Расчистка", comment="", technic = new List<Technic> {_technic.AllTechnics.First()} },
                    new Request{id_Shop=2, id_Responsible=1, date_begin=0, date_end=1, description="Здравствуйте", comment="", technic = new List<Technic> {_technic.AllTechnics.First(), _technic.AllTechnics.Last(), } }
                };
            }
        }

        public Request getObjectRequest(int requestId)
        {
            throw new NotImplementedException();
        }
    }
}
