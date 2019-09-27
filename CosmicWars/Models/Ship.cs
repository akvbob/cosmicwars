/**
 * @(#) Ship.cs
 */

namespace Class.CosmicWars.Models
{
	public class Ship
	{
		public Coordinate Position { get; set; }

        public Direction Orientation { get; set; }

        public Battleship_types Type { get; set; }

        public int HitCount { get; set; }

        public Ship()
        {

        }
        public void AddHit(  )
		{
			
		}
		
		public void IsSunk(  )
		{
			
		}
		
	}
	
}
