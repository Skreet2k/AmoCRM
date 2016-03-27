using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;



/// <summary>
/// Сводное описание для POST
/// </summary>
public static class API
{
     public static string POSTJSON(string url, string data) // пост запрос с помощью апи
   {
        WebRequest req = WebRequest.Create(url);
        req.ContentType = "application/json";
        req.Method = "POST";
        req.Timeout = 100000;
        using (var streamWriter = new StreamWriter(req.GetRequestStream()))
        {
            string json = data;
            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();
        }

        WebResponse httpResponse = req.GetResponse();
        StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream());

        return streamReader.ReadToEnd();
    }

    public static string Serialization(string json, string param) // сериализация значения поля из json
    {
        var jss = new JavaScriptSerializer();
        var dict = jss.Deserialize<dynamic>(json.Replace("[", "").Replace("]",""));
        return dict["response"]["leads"]["add"]["id"] + "";
    }
}