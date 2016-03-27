using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string domen = "test89379873618"; // поддомен amo
        string hash = "dfc79baf3217384de55db40a5352e6e8"; // хеш для апи
        string login = "test89379873618@gmail.com"; // логин от амо
        string LeadsId; // для записи ID сделки, 

        WebForm wf = new WebForm(); // Запись в структуру значений вебформы

        if (Request.Cookies["utm"] == null) 
            Response.Cookies["utm"].Value = new UTM(Request.Url.ToString()).utm; // запись первой ссылки на которую перешел пользователь              
        wf.UTM = Server.HtmlEncode(Request.Cookies["utm"].Value);
        
        Geolocation geo = new Geolocation(); // определение геолокации на основе ip

        if (IsPostBack)
        {
            wf.Name = Request["Name"];
            wf.Email = Request["Email"];
            wf.Phone = Request["Phone"];
            wf.Comment = Request["Comment"];
            wf.City = geo.City; // Запись данных в структуру.
            custom_fields[] cf = new custom_fields[] { new custom_fields(181847, new Values(421915, wf.Phone)), new custom_fields(181849, new Values(421927, wf.Email)), new custom_fields(195236, new Values(1,wf.City)), new custom_fields(195250, new Values(1, wf.UTM)) }; // формирование массива доп полей для создания контакта

            LeadsId = API.POSTJSON("https://" + domen + ".amocrm.ru/private/api/v2/json/leads/set?USER_HASH=" + hash + "&USER_LOGIN=" + login, (new SetLeads("Новая сделка").Json()));  // создание сделки
            LeadsId = API.Serialization(LeadsId, "id");
            API.POSTJSON("https://" + domen + ".amocrm.ru/private/api/v2/json/contacts/set?USER_HASH=" + hash + "&USER_LOGIN=" + login, (new SetContact(wf.Name, cf, LeadsId).Json())); // создание контакта
            API.POSTJSON("https://" + domen + ".amocrm.ru/private/api/v2/json/tasks/set?USER_HASH=" + hash + "&USER_LOGIN=" + login, (new SetTasks("Новое задание", LeadsId, 2, 4).Json())); // создание задания с прикреплением к сделке
            API.POSTJSON("https://" + domen + ".amocrm.ru/private/api/v2/json/notes/set?USER_HASH=" + hash + "&USER_LOGIN=" + login, (new SetNote(wf.Comment, LeadsId, 2).Json())); // добавление примечания к сделке
            SendEmail.SendMail("smtp.gmail.com", "test89379873618@gmail.com", "89379873618", "test89379873618@gmail.com", "Добавление нового контакта: " + wf.Name, "Номер телефона: "+ wf.Phone + "\nАдрес почты: "+ wf.Email +  "\n"  + wf.Comment); // отправка админу оповещения с данными с формы
        }  
    }

}