using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для custom_fields
/// </summary>
public class custom_fields
{
    public int id;
    public Values values;
    public custom_fields(int id, Values values)
    {
        this.id = id;
        this.values = values;
    }
}