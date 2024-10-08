namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Dmitriy";
            decimal MyAge = 33;
            bool HaveIApet = false;
            int MyShoesSize = 41;

            Console.WriteLine("My name is" + MyName);
            Console.WriteLine("My age is" + MyAge);
            Console.WriteLine("Do I have a pet?" + HaveIApet);
            Console.WriteLine("My shoe size is" + MyShoesSize);

            Console.ReadKey();
        }
    }
}
