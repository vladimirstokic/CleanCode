using System;

namespace WindowsFormsApplication1
{
	internal class RocketLauncher : IWeapon
	{

		public void Attack()
		{
			Console.WriteLine("Attack with Rocket Launcher!");
		}
	
	}
}