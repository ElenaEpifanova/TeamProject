using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{
    public class RequestRepository : IRequest
    {
        private readonly AppDBContent appDBContent;
        public RequestRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Request> AllRequests => appDBContent.Request.OrderBy(r => r.begin);

        public Request getObjectRequest(int requestId) => appDBContent.Request.FirstOrDefault(p => p.Id == requestId);
    }
}
