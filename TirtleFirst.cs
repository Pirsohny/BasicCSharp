using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var len = 30;


            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.PenUp();
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len * 2);
            Turtle.PenDown();
            Turtle.Turn(90);
            Turtle.Move(len * 3);
            Turtle.Turn(90);
            Turtle.Move(len * 3);
            Turtle.Turn(90);
            Turtle.Move(len * 3);
            Turtle.Turn(90);
            Turtle.Move(len * 3);
            Turtle.Turn(30);
            Turtle.Move(len * 3);
            Turtle.Turn(-60);
            Turtle.Move(len * 3);

        }
    }
}
