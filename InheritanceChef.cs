namespace csharpBeginning
{
    class InheritanceChef
    {
        public void MakeChickenFry(){
            Console.WriteLine("Making chicken Fry");
        }

        public void MakeMUttonSoup(){
            Console.WriteLine("Making Mutton soup");
        }

        public virtual void specialDish(){  // virtual mean we can modify this . this method we can override
            Console.WriteLine("My special Dish is veg curry");
        }
    }
}
