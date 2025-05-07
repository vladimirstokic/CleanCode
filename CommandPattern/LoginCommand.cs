using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class LoginCommand : IRequestCommand
	{
		public void Execute()
		{
			Console.WriteLine("Login");
		}
	}
}
