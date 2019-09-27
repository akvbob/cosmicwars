/**
 * @(#) Board.cs
 */

namespace Class.CosmicWars.Models
{
	public class Board
	{
		public int Length { get; set; }

        public int Width { get; set; }

        public bool Ready { get; set; }

        public Coordinate Coordinates { get; set; }

        public Board()
        {

        }
    }
	
}
