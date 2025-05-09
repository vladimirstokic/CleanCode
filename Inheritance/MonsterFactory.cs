﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVsComposition
{
	public class MonsterFactory
	{
		public enum MonsterType
		{
			LuisSuarez, // BitingKickingMonster
			Orc, // BitingKickingPunchingMonster
			Crocodile, // BitingMonster
			MikeTyson, // BitingPunchingMonster
			Camel, // KickingMonster
			Kangaroo, // KickingPunchingMonster
			MantisShrimp //PunchingMonster
		}

		public static Monster CreateMonster(MonsterType monsterType)
		{
			switch (monsterType)
			{
				case MonsterType.LuisSuarez:
					return new BitingKickingMonster(10, 5, 5);
				case MonsterType.Orc:
					return new BitingKickingPunchingMonster(10, 5, 5, 5);
				case MonsterType.Crocodile:
					return new BitingMonster(10, 5);
				case MonsterType.MikeTyson:
					return new BitingPunchingMonster(10, 5, 5);
				case MonsterType.Camel:
					return new KickingMonster(10, 5);
				case MonsterType.Kangaroo:
					return new KickingPunchingMonster(10, 5, 5);
				case MonsterType.MantisShrimp:
					return new PunchingMonster(10, 5);
				default:
					throw new ArgumentException();
			}
		}
	}
}
