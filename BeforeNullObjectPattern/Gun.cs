using System;

namespace WindowsFormsApplication1
{
	internal class Gun : IWeapon
	{
		public void Attack()
		{
			Console.WriteLine("Attack with gun!");
		}
	}
}