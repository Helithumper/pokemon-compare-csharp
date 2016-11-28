using System;

namespace pokemoncomparecsharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PokemonTables pt = new PokemonTables ();

			while (true) {
				//Take user input
				Console.WriteLine ("Type in a Type: ");
				String input = Console.In.ReadLine ();

				Console.WriteLine ("\n2x Weak to:");
				//convert to lowercase
				input = input.ToLower ();

				//convert user input to index
				int inputIndex = Array.IndexOf (pt.typeChart, input);

				//Returns super effective matches
				for (int i = 0; i < pt.matchupChart.GetLength (1); i++) {
					if (pt.matchupChart [i, inputIndex] == 2) {
						Console.WriteLine ("\t" + pt.typeChart [i]);
					}
				}
				Console.WriteLine ("\n");
			}

		}

	}
}
