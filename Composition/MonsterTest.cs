using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
	[TestClass]
	public class TestMonsterFactory
	{
		[TestMethod]
		public void Test_BitingMonster()
		{
			Monster crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);

			Assert.IsTrue(crocodile.CanBite);
			Assert.IsFalse(crocodile.CanKick);
			Assert.IsFalse(crocodile.CanPunch);
		}

		[TestMethod]
		public void Test_BitingKickingMonster()
		{
			Monster luisSuarez = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.LuisSuarez);

			Assert.IsTrue(luisSuarez.CanBite);
			Assert.IsTrue(luisSuarez.CanKick);
			Assert.IsFalse(luisSuarez.CanPunch);
		}
	}
}
