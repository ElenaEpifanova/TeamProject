using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{

    public class TypeTechnicRepository : ITypeTechnic 
    {
        //private readonly AppDBContent appDBContent;

        public TypeTechnicRepository(/*AppDBContent appDBContent*/)
        {
            //this.appDBContent = appDBContent;
        }
        public IEnumerable<TypeTechnic> AllType => throw new NotImplementedException();
   //to do
    }
}
