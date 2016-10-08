namespace Sokoban_DomainLib.GeneratedCode.Controller
{
    public class InputController
	{
        private Board gameBoard;
        private Boolean _intro = true;
		public GameController GameController
		{
			get;
			set;
		}

		public ViewController ViewController
		{
			get;
			set;
		}

		public BoardMaker BoardMaker
		{
			get;
			set;
		}

		public void startSokoban()
		{
            
            String levelSelected = ViewController.showStartUpScreen(_intro);
            char[,] textBoard = BoardMaker.loadBoard(levelSelected);
            gameBoard = BoardMaker.createBoard(textBoard);
		}

	}
}

