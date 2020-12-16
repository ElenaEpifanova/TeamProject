using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class AddTechnic
    {

        private readonly AppDBContent appDBContent;

        public AddTechnic(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string AddTechnicId { get; set; }


        public static AddTechnic GetTechnic(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content = services.GetService<AppDBContent>();
            string addtechnicid = session.GetString("TechnicId") ?? Guid.NewGuid().ToString();
            session.SetString("TechnicId", addtechnicid);
            return new AddTechnic(content) { AddTechnicId = addtechnicid };
        }
        
        public void Add_Technic(int TypeTechnicId, int quantity, int delay, int duration, string path, int ExecutorId, int RequestId)
        {
            appDBContent.Technic.Add
                (
                new Technic
                {
                    TypeTechnicId = TypeTechnicId,
                    quantity = quantity,
                    delay = delay,
                    duration = duration,
                    path = path,
                    ExecutorId = ExecutorId,
                    RequestId = RequestId
                }
                );
            appDBContent.SaveChanges();
        }

    }
}
