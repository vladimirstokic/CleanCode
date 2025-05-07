using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollections.Core
{
	class DMSSwitch
	{
		public string CustomId { get; set; }
		public int Gid { get; set; }
		public List<int> Signals { get; set; }
		public DMSSwitch()
		{
			CustomId = String.Empty;
			Gid = 0;
			Signals = new List<int>();
		}

		public DMSSwitch(string customId, int gid, List<int> signals)
		{
			CustomId = customId;
			Gid = gid;
			Signals = new List<int>(signals);
		}
	}
}
