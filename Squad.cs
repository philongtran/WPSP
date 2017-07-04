using System.Collections.Generic;

// Phi Long Tran <191624>, Viet Cuong Nguyen <191515>, Manuel Wessner <191711>
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