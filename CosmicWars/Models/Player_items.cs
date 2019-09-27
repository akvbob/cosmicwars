/**
 * @(#) Player_items.cs
 */

namespace CosmicWars.Models
{
	public class Player_items
	{
		public int Quantity { get; set; }

        public Player Owner { get; set; }

        public Powerup Powerups { get; set; }

        public Player_items()
        {

        }
    }
	
}
