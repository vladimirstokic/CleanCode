using OptimalUseOfCollections.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollectionsModel
{
	class InternalModel
	{
		public Dictionary<string, InternalModelSwitch> SwitchesByCustomId { get; set; }
		public Dictionary<int, InternalModelSwitch> SwitchesByGid { get; set; }

		public InternalModel(List<string> switchesToBeFound)
		{
			SwitchesByCustomId = new Dictionary<string, InternalModelSwitch>(switchesToBeFound.Count);
			SwitchesByGid = new Dictionary<int, InternalModelSwitch>(switchesToBeFound.Count);

			foreach (string switchId in switchesToBeFound)
			{
				SwitchesByCustomId.Add(switchId, new InternalModelSwitch(switchId, 0));
			}
		}

		public List<InternalModelSwitch> GetInternalModelSwitches()
		{
			return SwitchesByCustomId.Values.ToList();
		}
	}
}
