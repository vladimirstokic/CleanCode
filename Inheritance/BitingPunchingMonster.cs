using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVsComposition
{
	public class BitingPunchingMonster : BitingMonster
	{
		public int PunchDamage { get; set; }

		public BitingPunchingMonster(int hitPoints, int biteDamage, int punchDamage)
			: base(hitPoints, biteDamage)
		{
			PunchDamage = punchDamage;
		}
	}
}
