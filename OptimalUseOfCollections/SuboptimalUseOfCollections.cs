using GuardClauses;
using OptimalUseOfCollections.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollections
{
	class SuboptimalUseOfCollections
	{
		NetworkModelService _nms;
		NetworkDynamicsService _nds;
		public SuboptimalUseOfCollections(NetworkModelService nms, NetworkDynamicsService nds)
		{
			_nms = nms;
			_nds = nds;
		}

		public List<InternalModelSwitch> PerformSearch(List<string> switchesToBeFound)
		{
			GuardClause.IsNotNull(switchesToBeFound, nameof(switchesToBeFound));

			List<InternalModelSwitch> internalModelSwitches = new List<InternalModelSwitch>(switchesToBeFound.Count);
			InitializeInternalModel(switchesToBeFound, internalModelSwitches);
			List<DMSSwitch> switchesFromNMS = FilterValidSwitches(internalModelSwitches, switchesToBeFound);
			List<DMSSignal> allSwitchStatusSignalsFromNDS = FilterSwitchStatusSignalsFromNDS();
			MapSignalsToInternalModel(internalModelSwitches, switchesFromNMS, allSwitchStatusSignalsFromNDS);
			return internalModelSwitches;
		}

		#region Private Methods

		
		private void InitializeInternalModel(List<string> switchesToBeFound, List<InternalModelSwitch> internalModelSwitches)
		{
			foreach (string switchId in switchesToBeFound)
			{
				internalModelSwitches.Add(new InternalModelSwitch(switchId, 0));
			}
		}

		private List<DMSSwitch> FilterValidSwitches(List<InternalModelSwitch> internalModelSwitches, List<string> switchesToBeFound)
		{
			List<DMSSwitch> switchesFromNMS = _nms.GetSwitchesForCustomIds(switchesToBeFound);
			foreach (InternalModelSwitch internalSwitch in internalModelSwitches)
			{
				DMSSwitch dmsSwitch = switchesFromNMS.FirstOrDefault(x => x.CustomId.Equals(internalSwitch.CustomId));
				if (dmsSwitch != null)
				{
					internalSwitch.IsValid = true;
					internalSwitch.Gid = dmsSwitch.Gid;
				}
			}
			return switchesFromNMS;
		}

		private List<DMSSignal> FilterSwitchStatusSignalsFromNDS()
		{
			List<DMSSignal> allSignalsFromNDS = _nds.AllSignalsEver;
			List<DMSSignal> allSwitchStatusSignalsFromNDS = allSignalsFromNDS.Where(x => x.Type == 0).ToList();
			return allSwitchStatusSignalsFromNDS;
		}

		private void MapSignalsToInternalModel(List<InternalModelSwitch> internalModelSwitches, List<DMSSwitch> switchesFromNMS, List<DMSSignal> allSwitchStatusSignalsFromNDS)
		{
			foreach (DMSSwitch dmsSwitch in switchesFromNMS)
			{
				foreach (int signalId in dmsSwitch.Signals)
				{
					DMSSignal signal = allSwitchStatusSignalsFromNDS.FirstOrDefault(x => x.Gid == signalId);
					if (signal == null)
					{
						continue;
					}
					InternalModelSwitch internalSwitch = internalModelSwitches.Find(x => x.CustomId == dmsSwitch.CustomId);
					internalSwitch.Status = signal.Value;
					internalSwitch.Timestamp = signal.Timestamp;
				}
			}
		}
		#endregion
	}
}
