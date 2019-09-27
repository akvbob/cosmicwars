/**
 * @(#) Attack.cs
 */

namespace Class.CosmicWars.Models
{
	public class Attack
	{
		public Cell_states Result { get; set; }

        public bool Ship_destroyed { get; set; }

        public Coordinate Coordinate { get; set; }


        public Attack()
        {

        }
	}
	
}
