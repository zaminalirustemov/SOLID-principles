namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Content = "salam dunya";
            email.ToAdress = "zamin@mail.ru";
            email.SendMessage();

            SMS sms = new SMS();
            sms.PhoneNumber = "050 555 43 34";
            sms.Message = "Yeni zengimsellerimiz artiq movcuddur!";
            sms.SendMessage();
        }
    }
}