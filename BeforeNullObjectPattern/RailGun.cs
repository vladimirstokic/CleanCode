using System;

namespace WindowsFormsApplication1
{
	internal class RailGun : IWeapon
	{
		public void Attack()
		{
			Console.WriteLine("Attack with rail gun!");
		}
	}
}