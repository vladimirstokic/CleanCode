using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class QueryCommand : IRequestCommand
	{
		public void Execute()
		{
			Console.WriteLine("Query");
		}
	}
}
