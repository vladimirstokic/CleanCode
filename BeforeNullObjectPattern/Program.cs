using System;

namespace WindowsFormsApplication1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main(string[] args)
		{
			Character Keel = new Character();

			while (true)
			{
				IWeapon weapon = null;
				Console.WriteLine("Choose a weapon for Keel (1 = rocket launcher, 2= rail gun, 3 = machine gun)");
				String input = Console.ReadLine();
				switch (input)
				{
					case "1":
						weapon = new RocketLauncher();
						break;
					case "2":
						weapon = new RailGun();
						break;
					case "3":
						weapon = new MachineGun();
						break;
				}
				Keel.SetWeapon(weapon);
				Keel.Attack();
			}
		}
	}
}
