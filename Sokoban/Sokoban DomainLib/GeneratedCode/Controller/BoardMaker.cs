using System;
using Service;
using Sokoban_DomainLib.GeneratedCode.Model;

namespace Sokoban_DomainLib.GeneratedCode.Controller
{
    public class BoardMaker
	{
        private int _xSize;
        private int _ySize;
        private Char[,] _field;
        private string[] _lines;
        private Board gameBoard = new Board();
        private GameController gameController = new GameController();
		

        public void print()
        {
            

                for (int i = 0; i < _ySize; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < _xSize; j++)
                    {
                        Console.Write(_field[i, j]);

                    }
                }

        }

        public int[] getCoordinates()
        {
            int[] coords = { _xSize, _ySize };
            return coords;
        }
        

		public char[,] loadBoard(String mapChooser)
		{

            
        
            _lines = System.IO.File.ReadAllLines(@"C:\Users\User\Source\Repos\Sokoban\Sokoban\Doolhof" + mapChooser + ".txt");
            _xSize = _lines[0].Length;
            _ySize = _lines.Length;
            _field = new Char[_ySize, _xSize];
            for (int i = 0; i < _ySize; i++)
            {
                Char[] _text = _lines[i].ToCharArray();
                for (int j = 0; j < _xSize; j++)
                {
                    _field[i, j] = _text[j];
                }
            }
            return _field;
        }

        

        public Board createBoard(char[,] textBoard)
		{
            
            for (int i = 0; i < _ySize; i++)
            {
               
                for (int j = 0; j < _xSize; j++)
                {
                    char character = textBoard[i, j];
                    Floor floor = new Model.Floor();
                    switch (character)
                    {

                        case '.':
                            gameBoard.SetFloor(i, j, floor);
                            break;
                        case '@':
                            Player player = new Player();
                            player.XCoordinate = i;
                            player.YCoordinate = i;
                            floor.setMovableObject(player);
                            gameBoard.SetFloor(i, j, floor);


                            break;
                        case 'O':
                            Bomb bomb = new Model.Bomb();
                            bomb.XCoordinate = i;
                            bomb.YCoordinate = i;
                            floor.setMovableObject(bomb);
                            gameBoard.SetFloor(i, j, floor);
                            break;
                        case 'X':
                            Destination dest = new Destination();
                            gameBoard.SetFloor(i, j, dest);
                            break;
                        case '#':
                            Wall wall = new Model.Wall();
                            gameBoard.SetFloor(i, j, wall);
                            break;
                        case ' ':
                            InvisibleWall invWall = new InvisibleWall();
                            gameBoard.SetFloor(i, j, invWall);
                            break;

                        default:
                            break;
                    }
                }
            }
            return gameBoard;
        }

	}
}

