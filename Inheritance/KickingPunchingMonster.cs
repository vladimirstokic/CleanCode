﻿namespace InheritanceVsComposition
{
	public class KickingPunchingMonster : KickingMonster
	{
		public int PunchDamage { get; set; }

		public KickingPunchingMonster(int hitPoints, int kickDamage, int punchDamage)
			: base(hitPoints, kickDamage)
		{
			PunchDamage = punchDamage;
		}
	}
}