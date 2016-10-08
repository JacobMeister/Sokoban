using System.Collections.Generic;
using System.Linq;
using Model;
using Sokoban_DomainLib.GeneratedCode.Enumeration;

namespace Sokoban_DomainLib.GeneratedCode.Model
{
    public class Board
    {
        public Floor[][] GameBoard { get; set; }

        public Floor GetFloor(int xCoordinate, int yCoordinate)
        {
            return GameBoard[yCoordinate][xCoordinate];
        }

        public Floor[] GetDestinations()
        {
            var returnList = (from floors in GameBoard from floor in floors where floor.FloorType == FloorType.DESTINATION select floor).ToList();
            return returnList.ToArray();
        }
    }
}

