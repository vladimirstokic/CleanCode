using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollections.Core
{
	class DMSSignal
	{
		public int Gid { get; set; }
		public int ElectricDeviceGid { get; set; }
		public int Type { get; set; }
		public int Value { get; set; }
		public DateTime Timestamp { get; set; }
		public DMSSignal(int gid, int electricDeviceGid, int type, int value)
		{
			Gid = gid;
			ElectricDeviceGid = electricDeviceGid;
			Type = type;
			Value = value;
			Timestamp = DateTime.Now;
		}
	}
}
