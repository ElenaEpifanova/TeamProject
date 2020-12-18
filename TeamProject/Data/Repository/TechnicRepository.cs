using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{
    public class TechnicRepository : ITechnic
    {

        private readonly AppDBContent appDBContent;
        public TechnicRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Technic> AllTechnics => appDBContent.Technic;

        public Technic getObjectTechnic(int technicId) => appDBContent.Technic.FirstOrDefault(t => t.Id == technicId);

        public string AddTechnicId { get; set; }


        public static TechnicRepository GetTechnic(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content = services.GetService<AppDBContent>();
            string addtechnicid = session.GetString("TechnicId") ?? Guid.NewGuid().ToString();
            session.SetString("TechnicId", addtechnicid);
            return new TechnicRepository(content) { AddTechnicId = addtechnicid };
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
