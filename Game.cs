namespace TicTacToe
{
    public class Game
    {
        IPlayer player1;
        IPlayer player2;

        int boardSize;

        public Game(IPlayer player1, IPlayer player2, int boardSize = 3)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.boardSize = boardSize;
        }

        public void Start()
        {

        }
    }
}