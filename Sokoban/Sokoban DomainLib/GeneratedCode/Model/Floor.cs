﻿using Model;
using Sokoban_DomainLib.GeneratedCode.Enumeration;

namespace Sokoban_DomainLib.GeneratedCode.Model
{
    public class Floor
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

	    public FloorType FloorType { get; set; }

        public MoveAbleObject MoveAbleObject;

        public MoveAbleObject getMovableObject()
        {
            return MoveAbleObject;
        }
		
        public void setMovableObject(MoveAbleObject moveableObject)
        {
            this.MoveAbleObject = moveableObject;
        }

	}
}

