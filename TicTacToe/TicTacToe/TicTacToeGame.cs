using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char[] arr = new char[10];
        public void Board()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ' ';
            }
        }
        public char Player()
        {
            char input = Convert.ToChar(Console.ReadLine());
            if (input == 'X')
            {
                return input;
            }
            if (input == 'O')
            {
                return input;
            }
            return input;

        }
        public void ShowBoard()
        {
            Console.WriteLine("{1}|{2}|{3}|", arr[1], arr[2], arr[3]);
            Console.WriteLine("-----------");
            Console.WriteLine("{4}|{5}|{6}|", arr[4], arr[5], arr[6]);
            Console.WriteLine("-----------");
            Console.WriteLine("{7}|{8}|{9}|", arr[7], arr[8], arr[9]);
            Console.WriteLine("-----------");
        }
        public void Selection()
        {
            int index = Convert.ToInt32(Console.ReadLine());
            if (arr[index] == ' ')
            {
                Console.WriteLine("Marked");
            }
            else
            {
                Console.WriteLine("Taken");
            }
        }
    }
}
