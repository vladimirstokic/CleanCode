using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVsComposition
{
	[TestClass]
	public class TestMonsterFactory
	{
		[TestMethod]
		public void Test_BitingMonster()
		{
			Monster crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);

			Assert.IsTrue(crocodile is BitingMonster);
		}

		[TestMethod]
		public void Test_BitingKickingMonster()
		{
			Monster luisSuarez = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.LuisSuarez);

			Assert.IsTrue(luisSuarez is BitingMonster);

			// This test will fail, because we cannot inherit from multiple base classes.
			Assert.IsTrue(luisSuarez is KickingMonster);
		}
	}
}
