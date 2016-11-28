using System;

namespace pokemoncomparecsharp
{
	
	public class PokemonTables
	{
		public String[] typeChart = new String[18];
		public int[,] matchupChart = new int[18, 18];

		public PokemonTables ()
		{
			typeChart [0] = "normal";
			typeChart [1] = "fire";
			typeChart [2] = "water";
			typeChart [3] = "electric";
			typeChart [4] = "grass";
			typeChart [5] = "ice";
			typeChart [6] = "fighting";
			typeChart [7] = "poison";
			typeChart [8] = "ground";
			typeChart [9] = "flying";
			typeChart [10] = "psychic";
			typeChart [11] = "bug";
			typeChart [12] = "rock";
			typeChart [13] = "ghost";
			typeChart [14] = "dragon";
			typeChart [15] = "dark";
			typeChart [16] = "steel";
			typeChart [17] = "fairy";

			matchupChart [6, 0] = 2;
			matchupChart [13, 0] = 0;
			matchupChart [1, 1] = 3;
			matchupChart [2, 1] = 2;
			matchupChart [4, 1] = 3;
			matchupChart [5, 1] = 3;
			matchupChart [8, 1] = 2;
			matchupChart [11, 1] = 3;
			matchupChart [12, 1] = 2;
			matchupChart [16, 1] = 3;
			matchupChart [17, 1] = 3;

			matchupChart [1, 2] = 3;
			matchupChart [2, 2] = 3;
			matchupChart [3, 2] = 2;
			matchupChart [4, 2] = 2;
			matchupChart [5, 2] = 3;
			matchupChart [16, 2] = 3;

			// matchupChart[1][3]=2;
			// matchupChart[2][3]=3;
			// matchupChart[3][3]=3;
			// matchupChart[4][3]=3;
			// matchupChart[5][3]=2;
			// matchupChart[7][3]=2;
			// matchupChart[8][3]=2;
			// matchupChart[9][3]=3;
			// matchupChart[11][3]=2;

			matchupChart [3, 3] = 3;
			matchupChart [8, 3] = 2;
			matchupChart [9, 3] = 3;
			matchupChart [16, 3] = 3;

			matchupChart [1, 4] = 2;
			matchupChart [2, 4] = 3;
			matchupChart [3, 4] = 3;
			matchupChart [4, 4] = 3;
			matchupChart [5, 4] = 2;
			matchupChart [7, 4] = 2;
			matchupChart [8, 4] = 3;
			matchupChart [9, 4] = 2;
			matchupChart [11, 4] = 2;

			matchupChart [1, 5] = 2;
			matchupChart [5, 5] = 3;
			matchupChart [6, 5] = 2;
			matchupChart [12, 5] = 2;
			matchupChart [16, 5] = 2;

			matchupChart [9, 6] = 2;
			matchupChart [10, 6] = 2;
			matchupChart [11, 6] = 3;
			matchupChart [12, 6] = 3;
			matchupChart [15, 6] = 3;
			matchupChart [17, 6] = 2;

			matchupChart [3, 7] = 3;
			matchupChart [6, 7] = 3;
			matchupChart [7, 7] = 3;
			matchupChart [8, 7] = 2;
			matchupChart [10, 7] = 2;
			matchupChart [11, 7] = 3;
			matchupChart [17, 7] = 3;

			matchupChart [2, 8] = 2;
			matchupChart [3, 8] = 2;
			matchupChart [4, 8] = 0;
			matchupChart [5, 8] = 2;
			matchupChart [7, 8] = 3;
			matchupChart [12, 8] = 3;

			matchupChart [3, 9] = 3;
			matchupChart [4, 9] = 2;
			matchupChart [5, 9] = 2;
			matchupChart [6, 9] = 3;
			matchupChart [8, 9] = 0;
			matchupChart [11, 9] = 3;
			matchupChart [12, 9] = 2;

			matchupChart [6, 10] = 3;
			matchupChart [10, 10] = 3;
			matchupChart [11, 10] = 2;
			matchupChart [13, 10] = 2;
			matchupChart [15, 10] = 2;

			matchupChart [1, 11] = 2;
			matchupChart [3, 11] = 3;
			matchupChart [6, 11] = 3;
			matchupChart [8, 11] = 3;
			matchupChart [9, 11] = 2;
			matchupChart [12, 11] = 2;

			matchupChart [0, 12] = 3;
			matchupChart [1, 12] = 3;
			matchupChart [2, 12] = 2;
			matchupChart [3, 12] = 2;
			matchupChart [6, 12] = 2;
			matchupChart [7, 12] = 3;
			matchupChart [8, 12] = 2;
			matchupChart [9, 12] = 3;
			matchupChart [16, 12] = 2;

			matchupChart [0, 13] = 0;
			matchupChart [6, 13] = 0;
			matchupChart [7, 13] = 3;
			matchupChart [11, 13] = 3;
			matchupChart [13, 13] = 2;
			matchupChart [15, 13] = 2;

			matchupChart [1, 14] = 3;
			matchupChart [2, 14] = 3;
			matchupChart [3, 14] = 3;
			matchupChart [4, 14] = 3;
			matchupChart [5, 14] = 2;
			matchupChart [14, 14] = 2;
			matchupChart [17, 14] = 2;

			matchupChart [6, 15] = 2;
			matchupChart [10, 15] = 0;
			matchupChart [11, 15] = 2;
			matchupChart [13, 15] = 3;
			matchupChart [15, 15] = 3;
			matchupChart [17, 15] = 2;

			matchupChart [0, 16] = 3;
			matchupChart [1, 16] = 2;
			matchupChart [4, 16] = 3;
			matchupChart [5, 16] = 3;
			matchupChart [6, 16] = 2;
			matchupChart [7, 16] = 0;
			matchupChart [8, 16] = 2;
			matchupChart [9, 16] = 3;
			matchupChart [10, 16] = 3;
			matchupChart [11, 16] = 3;
			matchupChart [12, 16] = 3;
			matchupChart [14, 16] = 3;
			matchupChart [16, 16] = 3;
			matchupChart [17, 16] = 3;

			matchupChart [6, 17] = 3;
			matchupChart [7, 17] = 2;
			matchupChart [11, 17] = 3;
			matchupChart [14, 17] = 0;
			matchupChart [15, 17] = 3;
			matchupChart [16, 17] = 2;

		}
	}
}

