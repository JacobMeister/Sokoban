using System.Collections.Generic;
using System.Linq;
using Model;
using Sokoban_DomainLib.GeneratedCode.Enumeration;

namespace Sokoban_DomainLib.GeneratedCode.Model
{
    public class Board
    {
        public Floor[,] GameBoard;
        public void initFloor(int[] coords)

        {
            int x = coords[0];
            int y = coords[1];
            GameBoard = new Floor[x,y];
        }
       

        public Floor GetFloor(int xCoordinate, int yCoordinate)
        {
            return GameBoard[yCoordinate,xCoordinate];
        }

        public void SetFloor(int xCoordinate, int yCoordinate , Floor floor)
        {
            GameBoard[xCoordinate,yCoordinate] = floor;
            
        }

        public Floor[] GetDestinations()
        {
            var returnList = (from floors in GameBoard from floor in floors where floor.FloorType == FloorType.DESTINATION select floor).ToList();
            return returnList.ToArray();
        }
    }
}

