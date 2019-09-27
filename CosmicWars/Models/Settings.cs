/**
 * @(#) Settings.cs
 */

namespace Class.CosmicWars.Models
{
	public class Settings
	{
		public bool Sound { get; set; }

        public string Background_image { get; set; }

        public Languages Language { get; set; }

        public Player Player { get; set; }
        public Settings()
        {

        }

    }
	
}
