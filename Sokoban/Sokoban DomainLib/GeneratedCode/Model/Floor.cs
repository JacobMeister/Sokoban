﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Floor : Destination, Wall
	{
		public virtual int xCoordinate
		{
			get;
			set;
		}

		public virtual int yCoordinate
		{
			get;
			set;
		}

		public virtual MoveAbleObject MoveAbleObject
		{
			get;
			set;
		}

	}
}
