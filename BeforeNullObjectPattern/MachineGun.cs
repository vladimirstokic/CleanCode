using System;

namespace WindowsFormsApplication1
{
	internal class MachineGun : IWeapon
	{
		public void Attack()
		{
			Console.WriteLine("Attack with machinegun!");
		}
	}
}