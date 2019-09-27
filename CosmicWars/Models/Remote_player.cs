/**
 * @(#) Remote_player.cs
 */

namespace CosmicWars.Models
{
	
	public class Remote_player : Player
	{
		public string Hostname { get; set; }

        public int Port { get; set; }

        public Remote_player()
        {

        }
        public void Connect(  )
		{
			
		}
		
	}
	
}
