using System.Xml.Serialization;

namespace WeatherAPIXml.Models.Response
{
    [XmlRoot("current")]
    public class WeatherXmlResponse
    {
        [XmlElement("city")]
        public City City { get; set; }

        [XmlElement("temperature")]
        public Temperature Temperature { get; set; }

        [XmlElement("humidity")]
        public Humidity Humidity { get; set; }

        [XmlElement("pressure")]
        public Pressure Pressure { get; set; }

        [XmlElement("wind")]
        public Wind Wind { get; set; }

        [XmlElement("clouds")]
        public Clouds Clouds { get; set; }

        [XmlElement("weather")]
        public Weather Weather { get; set; }

        [XmlElement("lastupdate")]
        public LastUpdate LastUpdate { get; set; }
    }

    public class City
    {
        [XmlAttribute]
        public string name { get; set; }
    }

    public class Temperature
    {
        [XmlAttribute]
        public double value { get; set; }

        [XmlAttribute]
        public double min { get; set; }

        [XmlAttribute]
        public double max { get; set; }

        [XmlAttribute]
        public string unit { get; set; }
    }

    public class Humidity
    {
        [XmlAttribute]
        public int value { get; set; }

        [XmlAttribute]
        public string unit { get; set; }
    }

    public class Pressure
    {
        [XmlAttribute]
        public int value { get; set; }

        [XmlAttribute]
        public string unit { get; set; }
    }

    public class Wind
    {
        [XmlElement("speed")]
        public Speed Speed { get; set; }

        [XmlElement("direction")]
        public Direction Direction { get; set; }
    }

    public class Speed
    {
        [XmlAttribute]
        public double value { get; set; }

        [XmlAttribute]
        public string name { get; set; }
    }

    public class Direction
    {
        [XmlAttribute]
        public int value { get; set; }

        [XmlAttribute]
        public string code { get; set; }

        [XmlAttribute]
        public string name { get; set; }
    }

    public class Clouds
    {
        [XmlAttribute]
        public int value { get; set; }

        [XmlAttribute]
        public string name { get; set; }
    }

    public class Weather
    {
        [XmlAttribute]
        public int number { get; set; }

        [XmlAttribute]
        public string value { get; set; }

        [XmlAttribute]
        public string icon { get; set; }
    }

    public class LastUpdate
    {
        [XmlAttribute]
        public DateTime value { get; set; }
    }
}
