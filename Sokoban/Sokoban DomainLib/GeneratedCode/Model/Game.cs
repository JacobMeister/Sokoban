
namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

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

		public bool checkDestinations()
		{
			throw new System.NotImplementedException();
		}

		public bool checkValidMove(Direction direction)
		{
			throw new System.NotImplementedException();
		}

		public void DoMove(Direction direction)
		{
			throw new System.NotImplementedException();
		}

	}
}

