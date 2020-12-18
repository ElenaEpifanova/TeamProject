using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
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

        public string AddRequestId { get; set; }


        public static RequestRepository GetRequest(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content = services.GetService<AppDBContent>();
            string addrequestid = session.GetString("RequestId") ?? Guid.NewGuid().ToString();
            session.SetString("RequestId", addrequestid);
            return new RequestRepository(content) { AddRequestId = addrequestid };
        }

        public void Add_Request(int ShopId, int ResponsibleId, DateTime begin, DateTime end, string description, string comment, int PlaceId)
        {
            appDBContent.Request.Add
                (
                new Request
                {
                    ShopId = ShopId,
                    ResponsibleId = ResponsibleId,
                    begin = begin,
                    end = end,
                    description = description,
                    comment = comment,
                    PlaceId = PlaceId
                }
                );
            appDBContent.SaveChanges();
        }
    }
}
