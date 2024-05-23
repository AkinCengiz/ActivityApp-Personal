using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityApp.Entity.Abstract;

namespace ActivityApp.Entity.Concrete;
public class Category : BaseEntity
{
	public string Name { get; set; } = String.Empty;
}
