using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для UML
/// </summary>
public class UTM
{
    public string utm { get; private set; }
    public UTM(string url)
    {
        for (int i = 1; i < url.Length; i++)
        {
            if (url[i] == '&')
                break;
            if (url.Substring(0, i).Contains("utm_source="))
                utm += url[i];
        }
    }
}