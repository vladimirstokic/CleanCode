using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
	class ConcreteLogger : ILogger
	{
		public void Log(string message)
		{
			Logger.Log(message);
		}
	}

	class LoggerWrapper
	{
		private static ILogger _instance = new ConcreteLogger();

		private LoggerWrapper()
		{
		}

		static LoggerWrapper()
		{
		}

		public static ILogger Instance
		{
			get
			{
				return _instance;
			}
			set
			{
				_instance = value;
			}
		}
	}

	class MockLogger : ILogger
	{
		public List<string> _log = new List<string>();

		public void Log(string message)
		{
			_log.Add($"{message}");
		}
	}
}
