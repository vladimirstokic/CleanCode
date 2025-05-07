using System;

namespace WindowsFormsApplication1
{
	internal class Axe : IWeapon
	{
		public void Attack()
		{
			Console.WriteLine("Attack with axe!");
		}
	}
}