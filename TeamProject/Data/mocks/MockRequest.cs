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
                    new Request{ShopId=1, ResponsibleId=1, begin=new DateTime(2015, 7, 20), end=new DateTime(2015, 7, 21), description="Расчистка", comment="", technic = new List<Technic> {_technic.AllTechnics.First()} },
                    new Request{ShopId=2, ResponsibleId=1, begin=new DateTime(2015, 7, 20), end=new DateTime(2015, 7, 22), description="Здравствуйте", comment="", technic = new List<Technic> {_technic.AllTechnics.First(), _technic.AllTechnics.Last(), } }
                };
            }
        }

        public Request getObjectRequest(int requestId)
        {
            throw new NotImplementedException();
        }
    }
}
