/**
 * @(#) Session.cs
 */

namespace Class.CosmicWars.Models
{
	public class Session
	{
		public bool State { get; set; }

        public bool Turn { get; set; }

        public int Rounds_number { get; set; }

        public int Current_round { get; set; }

        public Player Players { get; set; }

        public Level Level { get; set; }

        public Session()
        {

        }
        public void AddPlayer()
		{
			
		}
		
		public void ExecuteTurn()
		{
			
		}
		
	}
	
}
