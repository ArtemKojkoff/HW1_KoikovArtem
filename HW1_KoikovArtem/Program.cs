namespace HW1_KoikovArtem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Gender = Gend.Male;

            Console.WriteLine("Enter firstname");
            user1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            user1.LastName = Console.ReadLine();

            Console.WriteLine(user1.ToString());

            Console.ReadLine();        }
    }
}
