/**
 * @(#) Coordinate.cs
 */

namespace Class.CosmicWars.Models
{
	public class Coordinate
	{
		public int Row { get; set; }

        public int Column { get; set; }

        public Cell_states State { get; set; }

        public Board Board { get; set; }

        public Attack Attack { get; set; }

        public Ship Ship { get; set; }

        public Coordinate()
        {

        }
		
		public void ProcessAttack(  )
		{
			
		}
		
	}
	
}
