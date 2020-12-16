using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class AddRequest
    {
        private readonly AppDBContent appDBContent;

        public AddRequest(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string AddRequestId { get; set; }


        public static AddRequest GetRequest (IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content = services.GetService<AppDBContent>();
            string addrequestid = session.GetString("RequestId") ?? Guid.NewGuid().ToString();
            session.SetString("RequestId", addrequestid);
            return new AddRequest(content) { AddRequestId = addrequestid };
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