using MUD.Art;

namespace MUD.Worlds
{
    public class LevelOne
    {

        public Player PlayerCar = new();
        public Enemy EnemyCar = new();
        public Room RoomSet = new();
        public void StartGame()
        {
            Console.WriteLine("Hello, adventurer!");
            Console.ReadKey(true);
            Console.WriteLine("your goal in this game is to get as much gold as you possibly can and defeat the dungeon boss.");
            Console.ReadKey(true);
            Console.WriteLine("but first, let me ask you something.");
            Console.ReadKey(true);
            Console.WriteLine("who are you?");
            Console.ReadKey(true);

            PlayerCerator you = new PlayerCerator();
            you.PlayerCerate(PlayerCar);

            Console.WriteLine("(you are " + PlayerCar.Name + ")");
            Console.WriteLine("(a " + PlayerCar.age + " year old " + PlayerCar.Cclass + ")");

            PlayerStatus check = new PlayerStatus();
            check.StatusCheck(PlayerCar);

            Console.WriteLine("ok. Now you are ready to explore the dungeon.");
            Console.ReadKey(true);
            Console.WriteLine("and remember, if you need help, you can always check your status.");
            Console.ReadKey(true);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("you enter the dungeon and now are in the first room.");
            Console.ReadKey(true);

            Dungeon inDungeon = new Dungeon();
            inDungeon.DungeonStart(PlayerCar, RoomSet);

            Battle fight = new Battle();
            fight.BattleStart(PlayerCar, EnemyCar);
        }
    }
}