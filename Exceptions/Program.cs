using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			Funcionario f = new Funcionario();

			try
			{
				f.AumentaSalario(-10);
			}
			catch (ArgumentException a)
			{

				Console.WriteLine("Error : {0}", a.Message);
			}
		}
	}
}
