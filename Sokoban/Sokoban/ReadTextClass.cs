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


        void sukkel()
        {
           
            for (int i = 0; i < _ySize; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < _xSize; j++)
                {
                    Console.Write(_field[i, j]);
                    
                }
            }
            Console.Write(_xSize);


            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.

            // Example #1
            // Read the file as one string.
            //           string text = System.IO.File.ReadAllText(@"C:\Users\User\Source\Repos\Sokoban\Sokoban\Doolhof1.txt");

            // Display the file contents to the console. Variable text is a string.
            //            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            //         string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
   //         foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
    //            Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
     //       Console.WriteLine("Press any key to exit.");
     //       System.Console.ReadKey();
        }

        public void readTxtFile()
        {
            _lines = System.IO.File.ReadAllLines(@"C:\Users\User\Source\Repos\Sokoban\Sokoban\Doolhof4.txt");
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




           sukkel();
        }

    }
}
