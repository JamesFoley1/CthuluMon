using System;
using System.Collections.Generic;

namespace CthuluMon{
    public class Encounter {
        Player curPlayer; 
        List<Monster> playerMonsters;
        Monster curMonster;
        Monster selectedMonster;

        public Encounter(Player _curPlayer, List<Monster> _playerMonsters){
            Random rand = new Random();
            // int MonsterId = rand.Next(1,6);
            // curMonster = new Monster(MonsterId);
            curPlayer = _curPlayer;
            playerMonsters = _playerMonsters;

        }

        public void StartEncounter(){
            // System.Console.WriteLine($"A wild {curMonster.Name} appears");
            // Console.WriteLine("Choose your party: [{0}]", string.Join(", ", curPlayer.Party));
            System.Console.WriteLine("Choose a pokemon!");
            foreach(Monster monster in playerMonsters){
                System.Console.WriteLine(monster.Name);
            }
            string choosenPokemon = Console.ReadLine();
            foreach(Monster monster in playerMonsters){
                if(monster.Name == choosenPokemon){
                    selectedMonster = monster;
                }
            }

            
            System.Console.WriteLine("What do you wants to do? attack | item | run");

            string choice = Console.ReadLine();

            switch (choice){
                case "attack":
                    string[] moves = getMoves();
                    List<Action> actions = getActions();
                    System.Console.WriteLine("Choose an attack!");
                    foreach(string move in moves{
                        System.Console.WriteLine(move);
                    }
                    string selectedMove = Console.ReadLine();

                    for(int i = 0; i < moves.Length ; i++){
                        if (selectedMove == moves[i]){
                            actions[i]();
                        }
                    }
                    break;
                case "item": 
                    foreach (KeyValuePair<string,int> entry in curPlayer.Inventory){
                        if(entry.Value > 0){ System.Console.WriteLine(entry.Key);}
                    }
                    break;
                case "run":
                    Random rand = new Random();
                    if(rand.Next(0,11) < 5){
                        System.Console.WriteLine("Successfully ran away");
                    } else {
                        System.Console.WriteLine("Didn't work!");
                    }
                    break;
                default:
                    break;
            }


        }




    }
    
}