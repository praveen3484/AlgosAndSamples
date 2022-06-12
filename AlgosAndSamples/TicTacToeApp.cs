using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples
{
	public class TicTacToeApp
	{
		public class TicTacToe
		{
			//for Storage:
			//	0	| 1	|	2
			//	---------
			//	3	|	4	|	5
			//	---------
			//	6	|	7	|	8
			//What user thinks:
			//	1	| 2	|	3
			//	---------
			//	4	|	5	|	6
			//	---------
			//	7	|	8	|	9

			//UI picture of Game:
			//INIT:
			//	-	| -	|	-
			//	---------
			//	-	|	-	|	-
			//	---------
			//	-	|	-	|	-
			//GamePlay:
			//	O	| -	|	-
			//	---------
			//	-	|	X	|	-
			//	---------
			//	-	|	-	|	X

			public char[] board;
			public char userMarker;
			public char aiMarker;
			public char winner;
			public char currentMarker;
			public TicTacToe(char playerMarker, char aiMarker)
			{
				userMarker = playerMarker;
				this.aiMarker = aiMarker;
				this.winner = '-';
				SetBoard();
			}

			public void Run()
			{
				//var inp = Console.ReadLine();
				bool doYouWantToPlay = true;
				while(doYouWantToPlay)
				{
					Console.WriteLine("Welcome to Tic Tac Toe! You are about to go against the master of Tic Tac Toe. " +
						"Are you ready? I hope so!\n But first, you must pick what characters you want to be and which character I will be.\n");
					Console.WriteLine("Enter a single character that will represent you on the board");
					char playerToken = Console.ReadLine()[0];
					Console.WriteLine("Enter a single character that will represent your opponent on the board");
					char opponentToken = Console.ReadLine()[0];
					TicTacToe tic = new TicTacToe(playerToken, opponentToken);
					AI ai = new AI(); 
				}
			}

			void SetBoard()
			{
				board = new char[9];
				for (int i = 0; i < board.Length; i++)
					board[i] = '-';
			}
			bool PlayTurn(int spot)
			{
				bool isValid = WithinRange(spot) && !IsSpotTaken(spot);
				if (isValid)
				{
					board[spot - 1] = currentMarker;
					currentMarker = (currentMarker == userMarker) ? aiMarker : userMarker;
				}
				return isValid;
			}

			//check if our spot is within range
			public bool WithinRange(int number)
			{
				return number > 0 && number < board.Length + 1;
			}
			//check if spot taken
			public bool IsSpotTaken(int number)
			{
				return board[number - 1] != '-';
			}

			public void PrintBoard()
			{
				// Attempting to print
				//	-	| -	|	-
				//	---------
				//	-	|	-	|	-
				//	---------
				//	-	|	-	|	-
				Console.WriteLine();
				for(int i = 0; i < board.Length; i++)
				{
					if(i % 3 == 0 && i != 0)
					{
						Console.WriteLine("\n---------");
					}
					Console.Write("\t|\t" + board[i]);
				}
			}
			public void PrintIndexBoard()
			{
				Console.WriteLine();
				for (int i = 0; i < board.Length; i++)
				{
					if (i % 3 == 0 && i != 0)
					{
						Console.WriteLine("\n---------");
					}
					Console.Write("\t|\t" + (i+1));
				}
			}

			public bool IsTheBoardFilled()
			{
				for (int i = 0; i < board.Length; i++)
				{
					if (board[i] == '-')
						return false;
				}
				return true;
			}

			public bool IsThereAWinner()
			{
				bool diagonalsAndMiddles = RightDi() || LeftDi() || MiddleRow() || SecondCol() || board[4] != '-';
				bool topAndFirst = topRow() || firstCol() && board[0] != '-';
				bool bottomAndThird = bottomRow() || thirdCol() && board[8] != '-';
				if (diagonalsAndMiddles)
				{
					this.winner = board[4];
				} else if (topAndFirst)
				{
					this.winner = board[0];
				} else if(bottomAndThird)
				{
					this.winner = board[8];
				}
				return diagonalsAndMiddles || topAndFirst || bottomAndThird;
			}

			private bool topRow()
			{
				return board[0] == board[1] && board[1] == board[2];
			}
			private bool MiddleRow()
			{
				return board[3] == board[4] && board[4] == board[5];
			}
			private bool bottomRow()
			{
				return board[6] == board[7] && board[7] == board[8];
			}

			private bool firstCol()
			{
				return board[0] == board[3] && board[3] == board[6];
			}
			private bool SecondCol()
			{
				return board[1] == board[4] && board[4] == board[7];
			}
			private bool thirdCol()
			{
				return board[2] == board[5] && board[5] == board[8];
			}

			private bool LeftDi()
			{
				return board[0] == board[4] && board[4] == board[8];
			}
			private bool RightDi()
			{
				return board[2] == board[4] && board[4] == board[6];
			}

			public string GameOver()
			{
				bool didSomeoneWin = IsThereAWinner();
				if(didSomeoneWin)
				{
					return "We have a Winner! The Winner is " + this.winner + "'s";
				} else if(IsTheBoardFilled())
				{
					return "Draw: Game Over!";
				} else
				{
					return "notOver";
				}
			}
		}
		class AI
		{
			//public int PickSpot(TicTacToe game)
			//{
			//	List<int> choice = new List<int>();
			//	for (int i = 0; i < 9; i++)
			//	{
			//		// If the slot is not taken, add it as a choice
			//		if (game.board[i])
			//}
			//}
		}
	}
}