namespace Tic_Tac_Toe_App.Models
{// Models/GameBoard.cs
    public class GameBoard
    {
        public char[,] Board { get; set; } = new char[3, 3];
        public char CurrentPlayer { get; set; } = 'X';

        public bool MakeMove(int row, int col)
        {
            if (Board[row, col] == '\0')
            {
                Board[row, col] = CurrentPlayer;
                CurrentPlayer = (CurrentPlayer == 'X') ? 'O' : 'X';
                return true;
            }
            return false;
        }
    }

}
