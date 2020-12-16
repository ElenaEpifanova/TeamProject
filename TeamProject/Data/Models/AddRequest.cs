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