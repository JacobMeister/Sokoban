﻿
    namespace View
    {
    using Sokoban_DomainLib.GeneratedCode.Controller;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Media;
    using System.Text;

    public class MenuView
	    {
            private String _answer;
        private bool _intro;

        public String showStartUpScreen(bool _intro)
            {
            this._intro = _intro;
            if (this._intro)
            {
                introScreens();
            }
            
            writeMenuText();
            Boolean answered = false;

                while (answered == false)
                {
                    if(_answer == "1" || _answer == "2" || _answer == "3" || _answer == "4")
                    {
                        Console.WriteLine("are you sure you want to play level " + _answer + "? (y/n)");
                        String yesNo = Console.ReadLine();

                        if (yesNo == "y")
                        {
                            answered = true;

                        }
                        else
                        {
                            writeMenuText();
    }
                    }
                    else
                    {
                        Console.WriteLine(_answer + " Is not a valid answer, try again");
                        System.Threading.Thread.Sleep(800);
                        writeMenuText();
                    }
                

                

                }

                return _answer;

            }

            private void introScreens()
    {
        Console.WriteLine("It was a beatiful spring morning in Japan in the shade of the cherryblossom.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Haruto was going to work, when suddenly Japans greatest enemy appeared!!!");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
    
        SoundPlayer player = new SoundPlayer();
        player.SoundLocation = @"C:\Users\User\Source\Repos\Sokoban\Sokoban\Godzilla_Roar.wav";
        player.Play();

        Console.Clear();
        BoardMaker reader = new BoardMaker();
        reader.loadBoard("godzilla");
        reader.print();

        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Oh no... It's Godzilla");
        Console.ReadKey();
        

        Console.Clear();
        Console.WriteLine("There is only one way to stop Godzilla, put bombs under his feet!");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Help Haruto defeat Godzilla!!!");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
            _intro = false;
    }

    public void writeMenuText()
    {
        Console.Clear();
        Console.WriteLine("Welkom to SOKOBAN!");
        Console.WriteLine("There are 4 available levels.");
        Console.WriteLine("Level 1 - Easy");
        Console.WriteLine("Level 2 - Normal");
        Console.WriteLine("Level 3 - Hard");
        Console.WriteLine("Level 4 - Very Hard");
        Console.WriteLine("Choose the level you want to play by typing the number.");
        _answer = Console.ReadLine();
    }




	    }
    }

