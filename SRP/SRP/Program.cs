namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Zaminali";
            string password = "Zaminali123";

            Cheker cheker = new Cheker();
            User user = new();

            if (cheker.CheckUsername(name))
            {
                user.Name = name;
            }
            if (cheker.CheckPassword(password))
            {
                user.Password = password;
            }
            CRUD cRUD = new CRUD();
            cRUD.Create(user);

            foreach (var item in cRUD.GetAllL())
            {
                Console.WriteLine($"{item.Name} {item.Password}");
            }
        }
    }
}