using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для SetContact
/// </summary>
public class SetNote
{
    string text;
    string element_id;
    int element_type;

    public SetNote(string text, string element_id, int element_type)
    {
        this.text = text;
        this.element_id = element_id;
        this.element_type = element_type;
    }

    public string Json()
    {
        return "{ \"request\":{ \"notes\":{ \"add\":[{\"text\":\"" + text + "\",\"element_id\":"  + element_id + ",\"element_type\":" + element_type +",\"note_type\": 4}]}}}";
    }
}