using System;
using Model;
using Sokoban_DomainLib.GeneratedCode.Enumeration;

namespace Sokoban_DomainLib.GeneratedCode.Model
{
    public class Game
	{
		public Board Board
		{
			get;
			set;
		}

		public Player Player
		{
			get;
			set;
		}

	    public Bomb[] Bombs { get; set; }

		public bool CheckDestinations()
		{
		    var destinations = Board.GetDestinations();
		    foreach (var destination in destinations)
		    {
		        if (destination.MoveAbleObject == null) return false;
		        if (destination.MoveAbleObject is Player)
		        {
		            return false;
		        }
		    }
		    return true;
		}

		public bool CheckValidMove(Direction direction)
		{
		    switch (direction)
		    {
		        case Direction.NORTH:
		            CheckMoveUp();
		            break;
		        case Direction.SOUTH:
		            CheckMoveDown();
		            break;
		        case Direction.EAST:
		            CheckMoveRight();
		            break;
		        case Direction.WEST:
		            CheckMoveLeft();
		            break;
		    }
		}

		public void DoMove(Direction direction, bool secondaryMove)
		{
		    switch (direction)
		    {
		        case Direction.NORTH:
                    MoveUp(secondaryMove);
		            break;
		        case Direction.SOUTH:
                    MoveDown(secondaryMove);
		            break;
		        case Direction.EAST:
                    MoveRight(secondaryMove);
		            break;
		        case Direction.WEST:
                    MoveLeft(secondaryMove);
		            break;
		    }
		}

	    private bool CheckMoveUp()
	    {
	        
	    }
        private bool CheckMoveDown()
        {

        }
        private bool CheckMoveLeft()
        {

        }
        private bool CheckMoveRight()
        {

        }


	    private void MoveUp(bool secondaryMove)
	    {
	        if (secondaryMove)
	        {
	            Board.GetFloor(Player.XCoordinate, Player.YCoordinate - 2).MoveAbleObject =
	                Board.GetFloor(Player.XCoordinate, Player.YCoordinate - 1).MoveAbleObject;
	        }
	        Board.GetFloor(Player.XCoordinate, Player.YCoordinate - 1).MoveAbleObject =
	            Board.GetFloor(Player.XCoordinate, Player.YCoordinate).MoveAbleObject;
	    }
        private void MoveDown(bool secondaryMove)
        {
            if (secondaryMove)
            {
                Board.GetFloor(Player.XCoordinate, Player.YCoordinate + 2).MoveAbleObject =
                    Board.GetFloor(Player.XCoordinate, Player.YCoordinate + 1).MoveAbleObject;
            }
            Board.GetFloor(Player.XCoordinate, Player.YCoordinate + 1).MoveAbleObject =
                Board.GetFloor(Player.XCoordinate, Player.YCoordinate).MoveAbleObject;
        }
        private void MoveRight(bool secondaryMove)
        {
            if (secondaryMove)
            {
                Board.GetFloor(Player.XCoordinate + 2, Player.YCoordinate).MoveAbleObject =
                    Board.GetFloor(Player.XCoordinate + 1, Player.YCoordinate).MoveAbleObject;
            }
            Board.GetFloor(Player.XCoordinate + 1, Player.YCoordinate + 1).MoveAbleObject =
                Board.GetFloor(Player.XCoordinate, Player.YCoordinate).MoveAbleObject;
        }
        private void MoveLeft(bool secondaryMove)
        {
            if (secondaryMove)
            {
                Board.GetFloor(Player.XCoordinate - 2, Player.YCoordinate).MoveAbleObject =
                    Board.GetFloor(Player.XCoordinate - 1, Player.YCoordinate).MoveAbleObject;
            }
            Board.GetFloor(Player.XCoordinate - 1, Player.YCoordinate).MoveAbleObject =
                Board.GetFloor(Player.XCoordinate, Player.YCoordinate).MoveAbleObject;
        }

	}
}

