using System;
using System.Collections.Generic;

namespace CthuluMon
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.startGame();
            // Player Player = GetPlayer();
            // Monster Monster1 = GenerateMonster();
            // Monster Monster2 = GenerateMonster();
            // Monster1.getInfo();
            // Monster2.getHealth();
            // Player.MindControl(Monster1, Monster2);
            // System.Console.WriteLine("Mind Controlling!");
            // Monster1.getHealth();
            // Monster2.getHealth();
            
            // System.Console.WriteLine($"A Monster {Monster1} appears! What would you like to do?");
            // StartEncounter(Player);
        }


        //         default:
        //             break;
        //     }
        //     System.Console.WriteLine(InputLine);
        // }
        // public static Player GetPlayer(){
        //     Player Player = new Player();
        //     return Player;
        // }

        public static void ShowInventory(Player player){
            foreach(KeyValuePair<string, int> item in player.Inventory){
                System.Console.WriteLine(item.Key+ ": " + item.Value);
            }
        }

        public static Monster GenerateMonster(){
            Monster FSM = new Monster("Flying Spaghetti Monster");
            getStats(FSM);
            return FSM;
        }

        public static void getStats(Monster monster){
            System.Console.WriteLine("Monster str: " + monster.Strength);
            System.Console.WriteLine("Monster dex: " + monster.Dexterity);
            System.Console.WriteLine("Monster con: " + monster.Constitution);
            System.Console.WriteLine("Monster int: " + monster.Intelligence);
            System.Console.WriteLine("Monster wis: " + monster.Wisdom);
            System.Console.WriteLine("Monster fort: " + monster.Fortitude);
            System.Console.WriteLine("Monster char: " + monster.Charisma);
            System.Console.WriteLine("Monster Health: " + monster.HP);
        }
    }
}
