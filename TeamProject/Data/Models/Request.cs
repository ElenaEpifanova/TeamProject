using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{

	public class Request
	{
		

		public int id { set; get; }

		public int id_shop { set; get; }
		public virtual Shop shop { set; get; }

		
		public int id_responsible{ set; get; }
		public virtual Responsible responsible { set; get; }


		public DateTime begin { set; get; }
		public DateTime end { set; get; }

		public string description { set; get; }
		public string comment { set; get; }

		public List<Technic> technic { set; get; }

	}

}
