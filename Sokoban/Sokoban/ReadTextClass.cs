using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class ReadTextClass
    {
        private int _xSize;
        private int _ySize;
        private Char[,] _field;
        private string[] _lines;


        void testPrintWantYolo()
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

        public void readTxtFile(String level)
        {
            _lines = System.IO.File.ReadAllLines(@"C:\Users\User\Source\Repos\Sokoban\Sokoban\Doolhof" + level + ".txt");
            _xSize = _lines[0].Length;
            _ySize = _lines.Length;
            createArray();
        }

        public void createArray()
        {
            _field = new Char[_ySize,_xSize];
            fillArray();
        }

        public void fillArray()
        {
            for (int i = 0; i < _ySize; i++)
            {
                Char[] _text = _lines[i].ToCharArray();
                for (int j = 0; j < _xSize; j++)
                {
                    _field[i,j] = _text[j];
                }
            }




           testPrintWantYolo();
        }

    }
}
