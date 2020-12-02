using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
	public class Shop
	{
		public int Id { set; get; }
		public string name { set; get; }
		public virtual List<Request> requests { set; get; }
	}
}
