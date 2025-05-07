using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollections.Core
{
	class NetworkDynamicsService
	{
		public List<DMSSignal> AllSignalsEver { get; private set; }

		public NetworkDynamicsService(NetworkModelService nms)
		{
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			int numberOfSignals = nms.AllSwitchesEver.Count * 5;//We assume there are five signals per switch
			AllSignalsEver = new List<DMSSignal>(numberOfSignals);		
			foreach (DMSSwitch dmsSwitch in nms.AllSwitchesEver)
			{
				foreach (int signalGid in dmsSwitch.Signals)
				{
					//We assume there are five signals per switch, and every fifth is the switch status
					DMSSignal signal = new DMSSignal(signalGid, dmsSwitch.Gid, signalGid % 5, rnd.Next(10));
					AllSignalsEver.Add(signal);
				}
			}
		}
	}
}
