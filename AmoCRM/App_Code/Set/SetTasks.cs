using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class SetTasks
{
    string text;
    string element_id;
    int element_type;
    int task_type;

    public SetTasks(string text, string element_id, int element_type, int task_type)
    {
        this.text = text;
        this.element_id = element_id;
        this.element_type = element_type;
        this.task_type = task_type;
    }

    public string Json()
    {
        return "{\"request\":{\"tasks\":{\"add\":[{\"element_id\":" + element_id + ",\"element_type\":" + element_type + ",\"task_type\":" + task_type + ",\"text\":\"" + text + "\", \"complete_till\": 1619999999}]}}}";
    }
}