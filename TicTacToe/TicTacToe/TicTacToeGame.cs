using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public void Board()
        {
            char[] arr = new char[10];
            foreach(var item in arr)
            {
                arr[item] = ' ';
            }
        }
    }
}
