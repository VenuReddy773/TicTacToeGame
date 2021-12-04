using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.Board();
            char player = game.Player();
            game.ShowBoard();
            game.Selection();
        }
    }
}
