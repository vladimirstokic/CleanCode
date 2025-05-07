using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollections.Core
{
	class NetworkModelService
	{
		public List<DMSSwitch> AllSwitchesEver { get; set; }
		public NetworkModelService(int numberOfSwitches)
		{
			AllSwitchesEver = new List<DMSSwitch>(numberOfSwitches);
			int gidOfSwitch = 0;
			while (numberOfSwitches > 0)
			{
				//We assume there are five signals per switch
				List<int> signals = new List<int>(5);
				for (int i = gidOfSwitch; i < gidOfSwitch + 5; i++)
				{
					signals.Add(i);
				}
				DMSSwitch newSwitch = new DMSSwitch(gidOfSwitch.ToString(), gidOfSwitch, signals);
				AllSwitchesEver.Add(newSwitch);
				gidOfSwitch += 5;
				numberOfSwitches--;
			}
		}

		public List<DMSSwitch> GetSwitchesForCustomIds(List<string> customIds)
		{
			List<DMSSwitch> retVal = new List<DMSSwitch>(customIds.Count);

			HashSet<string> searchCriteria = new HashSet<string>(customIds);

			foreach(DMSSwitch dmsSwitch in AllSwitchesEver)
			{
				if (searchCriteria.Contains(dmsSwitch.CustomId))
				{
					retVal.Add(dmsSwitch);
				}
				if (retVal.Count == customIds.Count)
				{
					break;
				}
			}
			return retVal;
		}
	}
}
