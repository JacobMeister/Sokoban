
namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public abstract class MoveAbleObject
	{
		public int XCoordinate
		{
			get;
			set;
		}

		public int YCoordinate
		{
			get;
			set;
		}

		public void Move(Direction direction)
		{
			throw new System.NotImplementedException();
		}

	}
}

