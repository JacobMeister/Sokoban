
namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Board
	{
	    public Floor[][] gameBoard { get; set; }

		public Floor getFloor( int xCoordinate,  int yCoordinate)
		{
			throw new System.NotImplementedException();
		}

		public Floor[] getDestinations()
		{
			throw new System.NotImplementedException();
		}

	}
}

