using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для SetContact
/// </summary>
public class SetContact
{
    string name;
    string leadsId;
    custom_fields[] cf;

    public SetContact(string name, custom_fields[] cf, string leadsId)
    {
        this.cf = cf;
        this.name = name;
        this.leadsId = leadsId;
    }

    public string Json()
    {
        string customfields = "";
        for (int i = 0; i < cf.Length; i++)
        {
            customfields += "{\"id\":" + cf[i].id + ",\"values\":[{\"value\":\"" + cf[i].values.value + "\",\"enum\":" + cf[i].values.Enum + "}]},";

        }
        customfields = customfields.TrimEnd(',');

        return "{\"request\":{\"contacts\":{\"add\":[{\"name\":\"" + name + "\", \"custom_fields\":[" + customfields + "]}]}}}";
    }
}