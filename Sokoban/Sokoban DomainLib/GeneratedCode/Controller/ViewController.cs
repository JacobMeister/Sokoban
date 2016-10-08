namespace Controller
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using View;

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

		public string showStartUpScreen()
		{
			throw new System.NotImplementedException();
		}

		public string ShowGameScreen(Board gameBoard)
		{
			throw new System.NotImplementedException();
		}

	}
}

