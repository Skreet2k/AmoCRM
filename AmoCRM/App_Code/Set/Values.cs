using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Values
/// </summary>
public class Values
{
    public int Enum;
    public string value;
    public Values(int Enum, string value)
    {
        this.Enum = Enum;
        this.value = value;
    }
}