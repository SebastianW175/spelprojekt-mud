using MUD.Art;

namespace MUD.Worlds
{
    public class LevelOne
    {
        public string Name;
        public int Health;
        public bool Dead;

        public void StartGame()
        {
            Sea s = new Sea();
            s.ShowGraphic();
            Console.WriteLine("...");
            Console.WriteLine("...?");
            Console.WriteLine("hello?");
            Console.WriteLine("is somone there");
            Console.WriteLine("...");
            Console.WriteLine("no response.");
            Console.WriteLine("where am i?");
            Console.WriteLine("who am i?");
            Console.WriteLine("come on, remember.");
            Console.WriteLine("my. name. is...");
            Name = Console.ReadLine();
            Console.WriteLine("yeah. my name is " + Name + " .");
            Console.WriteLine("now. where am i?");
            Console.WriteLine("...");
            Console.WriteLine("a beach?");
            Console.WriteLine("why am i at a beach?");
            Console.WriteLine("(you suddenly feel a massive pain in your stomach)");
            Health = 72;
            Console.WriteLine("(You have " + Health + " HP)");
            Console.WriteLine("agh! dammit! i need to eat something now.");
            Console.WriteLine("but where can i find some food.");
            Console.WriteLine("");
            /*Console.WriteLine("Welcome the magical worlds of MUDs");
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