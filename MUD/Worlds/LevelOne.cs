using MUD.Art;

namespace MUD.Worlds
{
    public class LevelOne
    {
        public string Name;
        public string age;
        public string Cclass;
        public int Health;
        public bool Dead;

        public void StartGame()
        {

            Console.Write("Enter your name:");
            Name = Console.ReadLine();
            Console.Write("Enter your age:");
            age = Console.ReadLine();
            Console.Write("Enter your character class:");
            Cclass = Console.ReadLine();
            Console.WriteLine("you are " + Name);
            Console.WriteLine("a " + age + " year old " + Cclass);

            /*Sea s = new Sea();
            s.ShowGraphic();
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine("...?");
            Console.ReadKey(true);
            Console.WriteLine("hello?");
            Console.ReadKey(true);
            Console.WriteLine("is somone there");
            Console.ReadKey(true);
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine("no response.");
            Console.ReadKey(true);
            Console.WriteLine("where am i?");
            Console.ReadKey(true);
            Console.WriteLine("who am i?");
            Console.ReadKey(true);
            Console.WriteLine("come on, remember.");
            Console.ReadKey(true);
            Console.WriteLine("who. am. i?");
            Console.ReadKey(true);
            Console.Write("Enter your name:");
            Name = Console.ReadLine();
            Console.Write("Enter your age:");
            age = Console.ReadLine();
            Console.Write("Enter your character class:");
            Cclass = Console.ReadLine();
            Console.WriteLine("you are " + Name);
            Console.WriteLine("a " + age + " year old " + Cclass);
            Console.ReadKey(true);
            Console.WriteLine("yes! that is who i am.");
            Console.ReadKey(true);
            Console.WriteLine("now. where am i?");
            Console.ReadKey(true);
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine("a beach?");
            Console.ReadKey(true);
            Console.WriteLine("why am i at a beach?");
            Console.ReadKey(true);
            Console.WriteLine("(you suddenly feel a massive pain in your stomach)");
            Console.ReadKey(true);
            Health = 72;
            Console.WriteLine("(You have " + Health + " HP)");
            Console.ReadKey(true);
            Console.WriteLine("agh! dammit! i need to eat something now.");
            Console.ReadKey(true);
            Console.WriteLine("but where can i find some food?");
            Console.ReadKey(true);
            Console.WriteLine("there is no one here and i dont se a town anywhere.");
            Console.ReadKey(true);
            Console.WriteLine("(you look at the sand and se a sandwich)");
            Console.ReadKey(true);
            Console.WriteLine("well its better then noting");
            Console.ReadKey(true);
            Console.WriteLine("(you eat the sandwich. your HP was restored!)");
            Console.ReadKey(true);

            Health = 100;
            Console.WriteLine("(You have " + Health + " HP)");
            Console.WriteLine("Welcome the magical worlds of MUDs");
            Console.WriteLine("Who are you?");
            Name = Console.ReadLine();
            Console.WriteLine("Oh, your name is " + Name);
            Console.WriteLine("Not what I would have chosen, but it will do I suppose...");
            Health = 100;
            Console.WriteLine("You have " + Health + " HP");
            Dead = false;

            if(Dead)
                Console.WriteLine("You are however, dead?");
            else
                Console.WriteLine("You are alive? Good!");*/
        }
    }
}