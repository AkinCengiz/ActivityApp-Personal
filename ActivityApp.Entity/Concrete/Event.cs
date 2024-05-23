using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityApp.Entity.Abstract;

namespace ActivityApp.Entity.Concrete;
public class Event : BaseEntity
{
	public string Name { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime EventDate { get; set; }
	public decimal Price { get; set; }
}
