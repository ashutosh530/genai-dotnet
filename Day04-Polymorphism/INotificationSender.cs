using System;

namespace NotificationApp
{
    interface INotificationSender
    {
        void SendNotification(string message);
    }

    class EmailNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Email Notification: {message}");
        }
    }

    class SMSNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS Notification: {message}");
        }
    }

    class PushNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
        }
    }
}

