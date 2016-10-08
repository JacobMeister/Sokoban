using Sokoban_DomainLib.GeneratedCode.Model;
using View;

namespace Sokoban_DomainLib.GeneratedCode.Controller
{
    public class ViewController
	{
		public GameView GameView
		{
			get;
			set;
		}

		public MenuView MenuView
		{
			get;
			set;
		}
       
        public Board Board
        {
            get;
            set;
        }

        public string showStartUpScreen(bool _intro)
		{
           return MenuView.showStartUpScreen(_intro);
		}

		public string ShowGameScreen(Board gameBoard)
		{
			throw new System.NotImplementedException();
		}

	}
}

