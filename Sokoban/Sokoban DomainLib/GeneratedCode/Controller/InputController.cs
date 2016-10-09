using Model;
using Sokoban_DomainLib.GeneratedCode.Model;
using System;

namespace Sokoban_DomainLib.GeneratedCode.Controller
{
    public class InputController
	{
        private Board gameBoard = new Board();
        private Boolean _intro = true;
        public GameController GameController = new GameController();
        public ViewController ViewController = new ViewController();
        public BoardMaker BoardMaker = new BoardMaker();

        //the constructor of inputcontroller starts the sokoban game, this controller is the main controllere from which everything is controlled.
        public InputController()
        {
            startSokoban();
        }
        
		
        // this method will start the first screen, it will show the startupscreen with the introduction
        //after the level is selected in the console, it will load the board from the txt file, 
        // initialize the gameboard, and fill the gameboard with floor tiles, according to the txt file
        //then the game will loop, processing user input and refreshing the view

		public void startSokoban()
		{
            String levelSelected = ViewController.showStartUpScreen(_intro);
            char[,] textBoard = BoardMaker.loadBoard(levelSelected);
            int[] coords = BoardMaker.getCoordinates();
            gameBoard.initFloor(coords);
            gameBoard = BoardMaker.createBoard(textBoard);

            Boolean won = false;
            while (won == false)
            {
                
                String input = ViewController.showGameScreen(gameBoard);
                Direction direction = Direction.EAST;
                switch (input)
                {
                    case "s":

                        break;

                    case "r":

                        break;

                    case "up":
                        direction = Direction.NORTH;
                        break;
                    case "down":
                        direction = Direction.SOUTH;
                        break;
                    case "left":
                        direction = Direction.WEST;
                        break;
                    case "right":
                        direction = Direction.EAST;
                        break;
                }

                GameController.movePlayer(direction);

                won = GameController.checkDestinations();
            }
		}

	}
}

