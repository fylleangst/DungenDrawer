using System;

namespace DungeonDrawer
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			
			while (true)
			{
				Console.WriteLine("The Dungeon");
				Draw();
				Console.WriteLine("Press a key");
				Console.ReadKey();
				Console.Clear();
			}
		}

		private static void Draw()
		{
			var smallDungeon = "";

			for (var i = 0; i < 8; i++)
			{
				var tile = DungeonTile(12);
				smallDungeon += tile + "\n";
			}

			Console.WriteLine(smallDungeon);
		}

		private static string DungeonTile(int eyes)
		{
			var random = new Random();

			var numberOfTiles = new Random();

			var dice = random.Next(1, eyes);

			return dice switch
			{
				1 => $"Forward({numberOfTiles.Next(2,10).ToString()})",
				2 => $"Left",
				3 => $"Right",
				4 => $"Dead End",
				5 => $"T-Cross",
				6 => $"Crossroad",
				7 => $"Stairs",
				8 => $"Small Room({numberOfTiles.Next(2,4)} x {numberOfTiles.Next(2,4)})",
				9 => $"Medium Room({numberOfTiles.Next(4,8)} x {numberOfTiles.Next(4,8)})",
				10 => $"Big Room({numberOfTiles.Next(8,16)} x {numberOfTiles.Next(8,16)})",
				_ => $"Forward"
			};
		}
	}
}
