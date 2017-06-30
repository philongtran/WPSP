namespace Meine_Fußball_Mannschaft
{   
    /// <summary>
    /// Holds all relevant information about a player
    /// </summary>
    internal class Player
    {   
        /// <summary>
        /// name of a player as property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// surname of a player as property
        /// </summary>
        public string Vorname { get; set; }

        /// <summary>
        /// position of a player as property
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// jersey number of a player as property
        /// </summary>
        public string Rueckennummer { get; set; }

        /// <summary>
        /// year, which the player joins the club as property
        /// </summary>
        public string Seit { get; set; }

        /// <summary>
        /// birth date of the player as property
        /// </summary>
        public string GeburtsDatum { get; set; }

        /// <summary>
        /// height of the player as property
        /// </summary>
        public string GroesseInCm { get; set; }

        /// <summary>
        /// weight of the player as property
        /// </summary>
        public string GewichtInKg { get; set; }

        /// <summary>
        /// number of games played in the domestic league of the club as property
        /// </summary>
        public string SpieleInBundesliga { get; set; }

        /// <summary>
        /// number of goals scored as property
        /// </summary>
        public string ToreInBundesliga { get; set; }

        /// <summary>
        /// nation of the player as property
        /// </summary>
        public string Nation { get; set; }

        /// <summary>
        /// number of games played for his country as property
        /// </summary>
        public string Laenderspiele { get; set; }

        /// <summary>
        /// name and surname of the player as property
        /// </summary>
        public string NameGesamt { get; set; }

        /// <summary>
        /// image idendifier of the player as property
        /// </summary>
        public string Bild { get; set; }
    }
}
