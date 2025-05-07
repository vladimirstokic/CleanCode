using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalUseOfCollections.Core
{
	class InternalModelSwitch
	{
		public string CustomId { get; set; }
		public int Gid { get; set; }
		public int Status { get; set; }
		public bool IsValid { get; set; }
		public DateTime Timestamp { get; set; }
		public InternalModelSwitch(string customId, int status)
		{
			CustomId = customId;
			Status = status;
			IsValid = false;
			Gid = 0;
			Timestamp = DateTime.MinValue;
		}

		public override bool Equals(object obj)
		{
			InternalModelSwitch switchToCompare = obj as InternalModelSwitch;
			if (obj == null)
			{
				return false;
			}

			bool equal = CustomId.Equals(switchToCompare.CustomId) &&
					Gid == switchToCompare.Gid &&
					Status == switchToCompare.Status &&
					IsValid == switchToCompare.IsValid &&
					Timestamp.Equals(switchToCompare.Timestamp);

			return equal;

		}

		public override int GetHashCode()
		{
			return CustomId.GetHashCode();
		}
	}
}
