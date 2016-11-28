using System;

namespace pokemoncomparecsharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PokemonTables pt = new PokemonTables ();

			while (true) {

				Console.ForegroundColor = ConsoleColor.Gray;
				//Take user input
				Console.WriteLine ("Type in a Type: ");
				String input = Console.In.ReadLine ();

				//convert to lowercase
				input = input.ToLower ();

				//convert user input to index
				int inputIndex = -1;

				inputIndex = Array.IndexOf (pt.typeChart, input);

				if (inputIndex == -1) {
					Console.WriteLine ("NOT VALID!");
					break;
				}


				

				Console.WriteLine ("\n2x Weak to:");

				Console.ForegroundColor = ConsoleColor.Green;
				//Returns super effective matches
				for (int i = 0; i < pt.matchupChart.GetLength (1); i++) {
					if (pt.matchupChart [i, inputIndex] == 2) {
						Console.WriteLine ("\t" + pt.typeChart [i]);
					}
				}

				Console.ForegroundColor = ConsoleColor.Gray;

				Console.WriteLine ("\n0x Effectiveness from: ");

				Console.ForegroundColor = ConsoleColor.DarkCyan;

				for (int i = 0; i < pt.matchupChart.GetLength (1); i++) {
					if (pt.matchupChart [i, inputIndex] == 0) {
						Console.WriteLine ("\t" + pt.typeChart [i]);
					}
				}
				Console.WriteLine ("\n");
			}

		}

	}
}
