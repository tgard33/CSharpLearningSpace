namespace LearningSpace
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Inheritance example using a chef and the dishes they make
            InheritanceEX chef = new InheritanceEX();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            InheritanceEX02 ItalianChef = new InheritanceEX02();
            ItalianChef.MakeChicken();
            ItalianChef.ItalianFood();
            ItalianChef.MakeSpecialDish();


            //Static methods and classes example
            StaticMethodsAndClassesEX.SayHi("Tyler");

            Console.WriteLine(Math.Sqrt(144));

            //Static Class Attriubutes example using songs: an attribute about the class not the object
            StaticClassAttributesEX upAgain = new StaticClassAttributesEX("Up Again", "Mike.", 300);
            Console.WriteLine(StaticClassAttributesEX.songCount);
            StaticClassAttributesEX aroundYou = new StaticClassAttributesEX("Around You", "Mike.", 200);
            Console.WriteLine(StaticClassAttributesEX.songCount);

            Console.WriteLine(upAgain.getSongCount());


            //Getters and Setters Example using movies
            GetterAndSetterEX IronMan = new GetterAndSetterEX("Iron Man", "Joss Whedon", "Test");
            GetterAndSetterEX Thor = new GetterAndSetterEX("Thor", "Joss Whedon", "PG");

            Console.WriteLine(IronMan.Rating);
            Console.WriteLine(Thor.Rating);

            //object methods example using "students"
            ObjectMethodsEX student1 = new ObjectMethodsEX("Tyler", "Information Systems", 3.9);
            ObjectMethodsEX student2 = new ObjectMethodsEX("Syd", "BSN", 4.0);

            Console.WriteLine(student1.HonorRoll());
            Console.WriteLine(student2.HonorRoll());

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Console.WriteLine(book1.title);
            /*
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            */

            Book book2 = new Book("Sports Illustrated", "Tyler Gardner", 30);
            Console.WriteLine(book2.author);

            /*
            book2.title = "Sports Illustrated";
            book2.author = "Tyler Gardner";
            book2.pages = 30;

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);
            */



            Console.ReadLine();
        }
    }
}