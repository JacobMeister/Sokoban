using Model;
using Sokoban_DomainLib.GeneratedCode.Model;
using System;
using View;

namespace Sokoban_DomainLib.GeneratedCode.Controller
{
    public class ViewController
	{
        public GameView GameView = new GameView();


        public MenuView MenuView = new MenuView();


        public Board Board = new Board();
        

        public string showStartUpScreen(bool _intro)
		{
            string chosenLevel = MenuView.showStartUpScreen(_intro);
            return chosenLevel;
		}

		public String showGameScreen(Board gameBoard)
		{
            String input = GameView.showBoard(gameBoard);
            return input;
		}

	}
}

