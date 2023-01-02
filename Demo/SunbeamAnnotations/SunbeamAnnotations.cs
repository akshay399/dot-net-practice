using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunbeamAnnotations
{
    public class Table : Attribute
    {
		private string _Name;

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

	}

	public class Column : Attribute 
	{
		private string _Name;
		private string _Type;

		public string Type
		{
			get { return _Type; }
			set { _Type = value; }
		}

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

	}
}



