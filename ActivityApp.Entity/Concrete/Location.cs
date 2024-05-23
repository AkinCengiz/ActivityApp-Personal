using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityApp.Entity.Abstract;

namespace ActivityApp.Entity.Concrete;
public class Location : BaseEntity
{
	public string Name { get; set; }
	public string Address { get; set; }
	public string Town { get; set; }
	public string City { get; set; }
	public string Country { get; set; }
}
