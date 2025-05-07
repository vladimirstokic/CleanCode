using System;

namespace WindowsFormsApplication1
{
	internal class Character
	{
		private IWeapon weapon;

		public Character()
		{
		}

		internal void SetWeapon(IWeapon weapon)
		{
			this.weapon = weapon;
		}

		internal void Attack()
		{
			//if (weapon == null)
			//{
			//	Console.WriteLine("No weapon...");
			//}
			//else
			//{
				weapon.Attack();
			//}
		}
	}
}