namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bmw=new BMW();
            Console.WriteLine( bmw.Start());
            Console.WriteLine(bmw.Airconditioning());

            Merc merc=new Merc();
            Console.WriteLine(merc.Start());
            Console.WriteLine(merc.Airconditioning()); 

            Lada2107 lada2107 = new Lada2107();
            Console.WriteLine(lada2107.Start());
        }
    }
}