using MUD.Art;

namespace MUD.Worlds
{
    public class LevelOne
    {

        public Player PlayerCar = new();
        public Enemy EnemyCar = new();
        public void StartGame()
        {
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine("...?");
            Console.ReadKey(true);
            Console.WriteLine("hello?");
            Console.ReadKey(true);
            Console.WriteLine("is somone there?");
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

            PlayerCerator you = new PlayerCerator();
            you.PlayerCerate(PlayerCar);

            Console.WriteLine("(you are " + PlayerCar.Name + ")");
            Console.WriteLine("(a " + PlayerCar.age + " year old " + PlayerCar.Cclass + ")");
            Console.WriteLine("(check status?)");

            PlayerStatus check = new PlayerStatus();
            check.StatusCheck(PlayerCar);

            Console.WriteLine("yes! that is who i am.");
            Console.ReadKey(true);
            Console.WriteLine("now. where am i?");
            Console.ReadKey(true);
            
            Sea s = new Sea();
            s.ShowGraphic();

            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine("a beach?");
            Console.ReadKey(true);
            Console.WriteLine("why am i at a beach?");
            Console.ReadKey(true);

            Console.WriteLine("(you suddenly feel a massive pain in your stomach)");
            Console.ReadKey(true);
            Console.WriteLine("(You have " + PlayerCar.Health + " HP)");
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
            PlayerCar.Health += 28;
            Console.WriteLine("(You have " + PlayerCar.Health + " HP)");

            Battle fight = new Battle();
            fight.BattleStart(PlayerCar, EnemyCar);
        }
    }
}