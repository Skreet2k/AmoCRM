using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Сводное описание для Geolocation
/// </summary>
public class Geolocation
{
    public string IP { private set; get; }
    public string City { private set; get; }
    public string Country { private set; get; }
    public string Region { private set; get; }

    public string Status { private set; get; }


    public Geolocation()
    {
        RefreshLocation();
    }
    public void RefreshLocation()
    {
        try
        {
            string locationResponse = new WebClient().DownloadString("http://ip-api.com/xml/?fields=24601");
            XElement responseXml = XDocument.Parse(locationResponse).Element("query");

            Status = responseXml.Element("status").Value;

            if (Status == "success")
            {
                IP = responseXml.Element("query").Value;
                City = responseXml.Element("city").Value;
                Country = responseXml.Element("country").Value;
                Region = responseXml.Element("regionName").Value;
            }
        }

        catch(Exception e)
        {
            Status = e.Message;
        }
    }
}