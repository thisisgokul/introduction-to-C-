namespace csharpBeginning
{
    internal class Program
    {
        static void Main(string[] args)
        {

         InheritanceChef chef = new InheritanceChef();
         InheritanceItalianChef italianChef = new InheritanceItalianChef();

         italianChef.specialDish();
        chef.MakeMUttonSoup();
        chef.specialDish();

          Console.ReadLine();
        }
    }
}
