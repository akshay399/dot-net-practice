using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunbeamAnnotations;
namespace POCOLib
{
	[Table(Name ="employees")]
    public class Emp
    {
		private int _No;
		private string _Name;
		private string _Address;


		[Column(Name="adresss", Type="varchar(50)")]
		public string Address
		{
			get { return _Address; }
			set { _Address = value; }
		}

		[Column(Name="emp_name", Type="varchar(30)")]
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		[Column(Name="id", Type="int")]
		public int No
		{
			get { return _No; }
			set { _No = value; }
		}

	}
}
