

namespace Controller
{
    using Model;
    using Service;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BoardMaker
	{
        private int _xSize;
        private int _ySize;
        private Char[,] _field;
        private string[] _lines;
        private Board gameBoard;
		

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
                Console.WriteLine();
                for (int j = 0; j < _xSize; j++)
                {
                    char character = textBoard[i, j];
                    switch (character)
                    {
                        case '.':
                            gameBoard[i]

                        default:
                            break;
                    }
                }
            }
            return gameBoard;
        }

	}
}

