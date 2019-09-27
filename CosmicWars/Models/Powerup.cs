/**
 * @(#) Powerup.cs
 */

namespace Class.CosmicWars.Models
{
	public class Powerup
	{
		public int Price { get; set; }

        public Player_items Player_items { get; set; }

        public Player Player { get; set; }

        public Powerup()
        {

        }
    }
	
}
