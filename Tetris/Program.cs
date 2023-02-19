using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40,30);
            Console.SetBufferSize(40,30);

            int x1 = 3;
            int y1 = 2;
            char c1 = '*';

            Draw(x1,y1,c1);


            Console.ReadLine();
        }

        static void Draw(int x,int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
