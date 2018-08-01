using System;

namespace CthuluMon{
    public class Encounter {
        Player curPlayer; 
        Monster curMonster;

        public Encounter(Player _curPlayer){
            Random rand = new Random();
            // int MonsterId = rand.Next(1,6);
            // curMonster = new Monster(MonsterId);
            curPlayer = _curPlayer;

        }

        public void StartEncounter(){
            // System.Console.WriteLine($"A wild {curMonster.Name} appears");
            // Console.WriteLine("Choose your party: [{0}]", string.Join(", ", curPlayer.Party));
            System.Console.WriteLine("Choose a pokemon!");
            string choosenPokemon = Console.ReadLine();


            
            System.Console.WriteLine("What do you wants to do? attack | item | run");
            string choice = Console.ReadLine();

            switch (choice){
                case "attack":

                    break;
                default:
                    break;
            }
        }




    }
    
}