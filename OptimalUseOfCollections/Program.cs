using OptimalUseOfCollections.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollections
{
	class Program
	{
		static void Main(string[] args)
		{
			NetworkModelService nms = new NetworkModelService(10000);
			NetworkDynamicsService nds = new NetworkDynamicsService(nms);

			List<string> switchesToBeFound = new List<string>(20000);
			int switchId = 0;
			for (int i = 0; i < 20000; i++, switchId += 5)
			{
				switchesToBeFound.Add(switchId.ToString());
			}

			SuboptimalUseOfCollections subOptimal = new SuboptimalUseOfCollections(nms, nds);
			Stopwatch sw = new Stopwatch();
			sw.Start();
			List<InternalModelSwitch> internalModelSuboptimal = subOptimal.PerformSearch(switchesToBeFound);
			sw.Stop();
			Console.WriteLine($"Suboptimal processing: {sw.ElapsedMilliseconds.ToString()} ms");

			OptimalUseOfCollections optimal = new OptimalUseOfCollections(nms, nds);
			sw.Restart();
			List<InternalModelSwitch> internalModelOptimal = optimal.PerformSearch(switchesToBeFound);
			sw.Stop();
			Console.WriteLine($"Optimal processing: {sw.ElapsedMilliseconds.ToString()} ms");
			Console.WriteLine($"Collections are equal: {internalModelSuboptimal.SequenceEqual(internalModelOptimal)}");
		}
	}
}
