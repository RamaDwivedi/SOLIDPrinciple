using System;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        // Logic to send email
        Console.WriteLine("Sending email: " + message);
    }
}

public class SMSNotification : INotification
{
    public void Send(string message)
    {
        // Logic to send SMS
        Console.WriteLine("Sending SMS: " + message);
    }
}

public class PushNotification : INotification
{
    public void Send(string message)
    {
        // Logic to send push notification
        Console.WriteLine("Sending push notification: " + message);
    }
}