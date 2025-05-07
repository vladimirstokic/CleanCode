using System;

namespace WindowsFormsApplication1
{
	internal class Sword : IWeapon
	{

		public void Attack()
		{
			Console.WriteLine("Attack with sword!");
		}
	
	}
}