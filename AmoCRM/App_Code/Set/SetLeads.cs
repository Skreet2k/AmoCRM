using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class SetLeads
{
    string name;

    public SetLeads(string name)
    {
        this.name = name;
    }

    public string Json()
    {
        return "{ \"request\":{ \"leads\":{ \"add\":[{\"name\":\"" + name + "\"}]}}}";
    }
}