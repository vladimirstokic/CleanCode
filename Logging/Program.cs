using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeMethod(1);

			MockLogger mockLogger = new MockLogger();

			LoggerWrapper.Instance = mockLogger;
			SomeMethod(-1);

			if (!mockLogger._log.Contains("Parameter a must be greater or equal zero"))
			{
				throw new Exception();
			}
		}


		public static void SomeMethod(int a)
		{
			string log = "Ovo je neki moj log";
			LoggerWrapper.Instance.Log(log);

			if (a < 0)
			{
				LoggerWrapper.Instance.Log("Parameter a must be greater or equal zero");
				return;
			}

			//Some logic

		}
	}
}
