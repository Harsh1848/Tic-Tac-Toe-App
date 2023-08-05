namespace Tic_Tac_Toe_App.Models
{
    public class GameBoard
    {
        public char[,] Board { get; set; } = new char[3, 3]; // Represents the game board
        public char CurrentPlayer { get; set; } = 'X'; // 'X' starts the game

        public bool MakeMove(int row, int col)
        {
            if (Board[row, col] == '\0')
            {
                Board[row, col] = CurrentPlayer;
                CurrentPlayer = (CurrentPlayer == 'X') ? 'O' : 'X'; // Switch players
                return true;
            }
            return false; // Invalid move
        }
    }
}
