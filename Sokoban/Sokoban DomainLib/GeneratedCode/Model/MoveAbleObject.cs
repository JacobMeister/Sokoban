using Model;

namespace Sokoban_DomainLib.GeneratedCode.Model
{
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

