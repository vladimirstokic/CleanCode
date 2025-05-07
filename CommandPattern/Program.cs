using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			RequestHandler requestHandler = new RequestHandler();
			requestHandler.HandleRequest(3);

			RequestHandlerCorrect requestHandlerCorrect = new RequestHandlerCorrect();
			requestHandlerCorrect.HandleRequest(3);
		}
	}
}
