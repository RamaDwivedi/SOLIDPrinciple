public class NotificationService
{
    private readonly List<INotification> _notificationMethods;

    public NotificationService(List<INotification> notificationMethods)
    {
        _notificationMethods = notificationMethods;
    }

    public void Notify(string message)
    {
        foreach (var notificationMethod in _notificationMethods)
        {
            notificationMethod.Send(message);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("");
        var notifications = new List<INotification>
        {
            new EmailNotification(),
            new SMSNotification(),
            new PushNotification()
        };

        var notificationService = new NotificationService(notifications);
        notificationService.Notify("This is a test message.");
        Console.WriteLine("");
    }
}
