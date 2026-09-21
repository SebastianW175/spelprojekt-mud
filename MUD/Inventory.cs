using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Inventory
    {
        public void PlayerInventory(Player PlayerCar)
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Weapon:" + PlayerCar.Weapon);
            Console.WriteLine("Armor:" + PlayerCar.Armor);
            Console.WriteLine("Ring:" + PlayerCar.Ring);
            Console.WriteLine("------------------------------------------------------------------------");
            int i = 0;
            foreach (string item in PlayerCar.Inventory)
            {
                if (i < 3)
                {
                    Console.Write(item + "     ");
                    i++;
                }
                else
                {
                    i = 0;
                    Console.WriteLine(item);
                }
            }
            if (i == 0)
            {
                Console.WriteLine("------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------");
            }
            int ie = 0;
            while (ie < 1)
            {
                Console.Write("use item or change gear?:");
                PlayerCar.Choice = Console.ReadLine();
                if (PlayerCar.Choice == "exit" || PlayerCar.Choice == "quit" || PlayerCar.Choice == "back")
                {
                    ie = 1;
                }
                else if (PlayerCar.Choice == "item" || PlayerCar.Choice == "use")
                {
                    UseItem useItem = new UseItem();
                    useItem.UsePlayerInventoryItem(PlayerCar);
                }
                else if (PlayerCar.Choice == "equip" || PlayerCar.Choice == "equipment" || PlayerCar.Choice == "gear")
                {
                    EquipGear equipGear = new EquipGear();
                    equipGear.PlayerInventoryEquipGear(PlayerCar);
                }
                else
                {
                    Console.WriteLine("unknown command");
                }
            }
        }
    }
}
