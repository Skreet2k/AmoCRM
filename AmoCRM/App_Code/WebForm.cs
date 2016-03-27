using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для WebForm
/// </summary>
public struct WebForm
{
    public string Name;
    public string Email;
    public string Phone;
    public string Comment;
    public string City;
    public string UTM;
    WebForm(string Name, string Email, string Phone, string Comment, string City, string UTM)
    {
        this.Name = Name;
        this.Email = Email;
        this.Phone = Phone;
        this.Comment = Comment;
        this.City = City;
        this.UTM = UTM;
    }
}