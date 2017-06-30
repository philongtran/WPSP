using System.Collections.Generic;

namespace Meine_Fußball_Mannschaft
{   
    /// <summary>
    /// Holds the list, which contains all players as objects
    /// </summary>
    internal class Squad
    {   
        /// <summary>
        /// list of all player objects from the same club
        /// </summary>
        public List<Player> PlayerList;

        /// <summary>
        /// default constructor
        /// </summary>
        public Squad()
        {
            PlayerList = new List<Player>();
        }
    }
}