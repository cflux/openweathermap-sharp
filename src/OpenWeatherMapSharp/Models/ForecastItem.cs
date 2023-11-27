﻿using Newtonsoft.Json;
using OpenWeatherMapSharp.Utils;
using System;
using System.Collections.Generic;

namespace OpenWeatherMapSharp.Models
{
    /// <summary>
    ///     A Forcast Item
    /// </summary>
    public class ForecastItem
    {
        /// <summary>
        ///     Main weather information
        /// </summary>
        [JsonProperty("main")]
        public Main MainWeather { get; set; }

        /// <summary>
        ///     List of weather infos
        /// </summary>
        [JsonProperty("weather")]
        public List<WeatherInfo> WeatherInfos { get; set; }

        /// <summary>
        ///     Cloud information
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        /// <summary>
        ///     Wind information
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        ///     Average visibility, metres
        /// </summary>
        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        /// <summary>
        ///     Probability of precipitation
        /// </summary>
        [JsonProperty("pop")]
        public double Probability { get; set; }

        /// <summary>
        ///     Rain information
        /// </summary>
        [JsonProperty("rain")]
        public Volume Rain { get; set; }

        /// <summary>
        ///     Snow information
        /// </summary>
        [JsonProperty("snow")]
        public Volume Snow { get; set; }

        /// <summary>
        ///     City information
        /// </summary>
        [JsonProperty("city")]
        public City City { get; set; }

        /// <summary>
        ///     Date, Unix, UTC
        /// </summary>
        [JsonProperty("dt")]
        public long DateUnix { get; set; }

        /// <summary>
        ///     Date, DateTime
        /// </summary>
        [JsonIgnore]
        public DateTime Date => DateUnix.ToDateTime();
    }
}
