<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link rel="stylesheet" href="/StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Введите ваше имя:</label>
                <input type="text" name="Name" value="Имя" /><br />
            <label>Введите e-mail:</label>
            <input type="text" name="Email" value="e-mail" /><br />
            <label>Ваш номер телефона:</label>
                <input type="text" name="Phone" value="8-000-000-00-01" /><br /><br />
            <label>Ваш комментарий:</label><br />
                <textarea name="Comment" style="height: 83px; width: 356px"></textarea>
            <br />
            <br />
            <input type="submit" value="Отправить" id="OK" />
            <br />
        </div>
    </form>
</body>
</html>
