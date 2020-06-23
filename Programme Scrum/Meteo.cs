using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Programme_Scrum
{
    class Meteo
    {
       

            public static string AfficheMeteo()
        {
            string sturltest = String.Format("http://api.weatherstack.com/current?access_key=65fc835d22b1f42760e3782bd4fb8eea&query=Brussels");
            WebRequest requestObjGet = WebRequest.Create(sturltest);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            MeteoModel bsObj = JsonConvert.DeserializeObject<MeteoModel>(strresulttest);

            Console.WriteLine("La température relevée à " + bsObj.Location.Name +" est de " + bsObj.Current.Temperature +"°c");
            Console.WriteLine("La vitesse du vent est de " + bsObj.Current.WindSpeed +"Km/H");
            

            return "";
        }
    }

    class MeteoModel
    {
        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("current")]
        public Current Current { get; set; }
    }
    internal class Current
    {

        [JsonProperty("observation_time")]
        public string ObservationTime { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("weather_code")]
        public int WeatherCode { get; set; }

        [JsonProperty("weather_icons")]
        public IList<string> WeatherIcons { get; set; }

        [JsonProperty("weather_descriptions")]
        public IList<string> WeatherDescriptions { get; set; }

        [JsonProperty("wind_speed")]
        public int WindSpeed { get; set; }

        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloudcover")]
        public int Cloudcover { get; set; }

        [JsonProperty("feelslike")]
        public int Feelslike { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("is_day")]
        public string IsDay { get; set; }
    }

    internal class Location
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("timezone_id")]
        public string TimezoneId { get; set; }

        [JsonProperty("localtime")]
        public string Localtime { get; set; }

        [JsonProperty("localtime_epoch")]
        public int LocaltimeEpoch { get; set; }

        [JsonProperty("utc_offset")]
        public string UtcOffset { get; set; }
    }

    internal class Request
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

}
