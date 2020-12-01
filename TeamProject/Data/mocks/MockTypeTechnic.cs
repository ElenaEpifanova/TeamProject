using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.mocks
{
    public class MockTypeTechnic : ITypeTechnic
    {
        public IEnumerable<TypeTechnic> AllType
        { get
            {
                return new List<TypeTechnic>
                { new TypeTechnic{  name="Установка кислотной обработки", quantity=2 },
                  new TypeTechnic{ name="АРС Урал (Агрегат ремонто-сварочный)", quantity=2 }
                };
            }

        }
    }
}
