using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{

	public class Request
	{
		

		public int id { set; get; }

		public int id_Shop { set; get; }
		public virtual Shop shop { set; get; }

		
		public int id_Responsible{ set; get; }
		//public virtual Responsible responsible { set; get; }


		public int date_begin { set; get; }  //type date
		public int date_end { set; get; } //type date

		public string description { set; get; }
		public string comment { set; get; }

		public List<Technic> technic { set; get; }

	}

}
