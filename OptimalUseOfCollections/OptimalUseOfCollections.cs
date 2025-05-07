using OptimalUseOfCollections.Core;
using OptimalUseOfCollectionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollections
{
	class OptimalUseOfCollections
	{
		NetworkModelService _nms;
		NetworkDynamicsService _nds;

		public OptimalUseOfCollections(NetworkModelService nms, NetworkDynamicsService nds)
		{
			_nms = nms;
			_nds = nds;
		}

		public List<InternalModelSwitch> PerformSearch(List<string> switchesToBeFound)
		{
			InternalModel internalModel = InitializeInternalModel(switchesToBeFound);
			FilterValidSwitches(switchesToBeFound, internalModel);
			MapSignalsToInternalModel(internalModel);
			return internalModel.GetInternalModelSwitches();
		}

		private InternalModel InitializeInternalModel(List<string> switchesToBeFound)
		{
			return new InternalModel(switchesToBeFound);
		}

		private void FilterValidSwitches(List<string> switchesToBeFound, InternalModel internalModel)
		{
			List<DMSSwitch> dmsSwitches = _nms.GetSwitchesForCustomIds(switchesToBeFound);
			foreach (DMSSwitch dmsSwitch in dmsSwitches)
			{
				InternalModelSwitch internalModelSwitch;
				if (internalModel.SwitchesByCustomId.TryGetValue(dmsSwitch.CustomId, out internalModelSwitch))
				{
					internalModelSwitch.IsValid = true;
					internalModelSwitch.Gid = dmsSwitch.Gid;
					internalModel.SwitchesByGid.Add(dmsSwitch.Gid, internalModelSwitch);
				}
			}
		}

		private void MapSignalsToInternalModel(InternalModel internalModel)
		{
			foreach (DMSSignal signal in _nds.AllSignalsEver)
			{
				if (signal.Type == 0)
				{
					InternalModelSwitch internalModelSwitch;
					if (internalModel.SwitchesByGid.TryGetValue(signal.ElectricDeviceGid, out internalModelSwitch))
					{
						internalModelSwitch.Status = signal.Value;
						internalModelSwitch.Timestamp = signal.Timestamp;
					}
				}
			}
		}




	}
}
