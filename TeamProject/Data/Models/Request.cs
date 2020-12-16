using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{

	public class Request
	{
		public int Id { set; get; }

		public int ShopId { set; get; }
		public virtual Shop Shop { set; get; }

		
		public int ResponsibleId{ set; get; }
		public virtual Responsible Responsible { set; get; }


		public DateTime begin { set; get; }
		public DateTime end { set; get; }

		public string description { set; get; }
		public string comment { set; get; }

		public int PlaceId { set; get; }
		public virtual Place Place { set; get; }

		public virtual List<Technic> technic { set; get; }

	}

}
