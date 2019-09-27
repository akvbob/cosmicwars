/**
 * @(#) Local_player.cs
 */

namespace Class.CosmicWars.Models
{
	
	public class Local_player : Player
	{
		public string Name { get; set; }

        public Board MyBoard { get; set; }

        public int Balance { get; set; }

        public Ship Battleship { get; set; }

        public Local_player()
        {

        }

    }
	
}
