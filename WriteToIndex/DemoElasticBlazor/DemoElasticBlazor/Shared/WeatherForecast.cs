using System;

namespace DemoElasticBlazor.Shared
{
    /// <summary>
    /// Weather Forecast
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the temperature c.
        /// </summary>
        /// <value>
        /// The temperature c.
        /// </value>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        /// <value>
        /// The summary.
        /// </value>
        public string Summary { get; set; }

        /// <summary>
        /// Gets the temperature f.
        /// </summary>
        /// <value>
        /// The temperature f.
        /// </value>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}