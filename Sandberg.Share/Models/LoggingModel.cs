using System;

namespace Sandberg.Share.Models
{
    /// <summary>
    /// Information zum Wetter zu einem bestimmten Zeitpunkt
    /// </summary>
    public record LoggingModel
    {
        /// <summary>
        /// Datenbank Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Zeitpunkt der Messung
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Temperatur
        /// </summary>
        public decimal Temperature { get; set; }

        /// <summary>
        /// Luftfeuchtigkeit
        /// </summary>
        public decimal Humidity { get; set; }

        /// <summary>
        /// Bodenfeuchtigkeit
        /// </summary>
        public decimal SoilMoisture { get; set; }
    }
}