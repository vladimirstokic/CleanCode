using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class RequestHandlerCorrect
	{
		Dictionary<int, IRequestCommand> _commands = new Dictionary<int, IRequestCommand>();

		public RequestHandlerCorrect()
		{
			_commands.Add(0, new LoginCommand());
			_commands.Add(1, new LogoutCommand());
			_commands.Add(2, new QueryCommand());
			_commands.Add(3, new GenerateReportCommand());
		}
		public void HandleRequest(int requestType)
		{
			IRequestCommand command = null;
			if (_commands.TryGetValue(requestType, out command))
			{
				command.Execute();
			}
		}
	}
}
