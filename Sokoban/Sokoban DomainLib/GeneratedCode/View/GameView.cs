
namespace View
{
    using Model;
    using Sokoban_DomainLib.GeneratedCode.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GameView
	{
        public Direction showBoard(Board gameBoard)
        {
            
            Console.Clear();
            for (int i = 0; i < gameBoard.GetLength(1); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < gameBoard.GetLength(0); j++)
                {
                    var arrayItem = gameBoard.GetFloor(i, j);
                    var type = arrayItem.GetType();
                    if (type == typeof(Floor))
                    {
                        MoveAbleObject obj = arrayItem.getMovableObject();
                        if(obj.GetType() == typeof(Player))
                        {
                            Console.Write("@");
                        }
                        else if (obj.GetType() == typeof(Bomb))
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else if (type == typeof(Wall))
                    {
                        Console.Write("#");
                    }
                    else if (type == typeof(InvisibleWall))
                    {
                        Console.Write(" ");
                    }
                    else if (type == typeof(Destination))
                    {
                        Console.Write("X");
                    }
                    }
                }



                Console.ReadKey();
                
            
            Direction input = Direction.EAST;
            return input;
        }
	}
}

