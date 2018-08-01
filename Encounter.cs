using System;
using System.Collections.Generic;

namespace CthuluMon{
    public class Encounter {
        Player curPlayer; 
        List<Monster> playerMonsters;
        Monster curMonster;
        Monster selectedMonster;

        public Encounter(Player _curPlayer, List<Monster> _playerMonsters, Monster _enemyMonster){
            Random rand = new Random();
            // int MonsterId = rand.Next(1,6);
            curMonster = _enemyMonster;
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

            while(curMonster.HP > 0 && selectedMonster.HP > 0 ){
                Turn();

            }

            System.Console.WriteLine("Encounter ended");
            
        }

        public void Turn(){

            System.Console.WriteLine("What do you wants to do? attack | item | run");

            string choice = Console.ReadLine();

            switch (choice){
                case "attack":
                    string[] moves = Monster.getMoves();
                    // List<Action> actions = getActions();
                    System.Console.WriteLine("Choose an attack!");
                    foreach(string move in moves){
                        System.Console.WriteLine(move);
                    }
                    string selectedMove = Console.ReadLine();
                    if( selectedMove == "Attack" ) {
                        selectedMonster.Attack(curMonster);
                    } else if( selectedMove == "KawaiiiClaw" ) {
                        selectedMonster.KawaiiiClaw(curMonster);
                    } else if( selectedMove == "GluttonousBite" ) {
                        selectedMonster.GluttonousBite(curMonster);
                    }  else if( selectedMove == "Ravage" ) {
                        selectedMonster.Ravage(curMonster);
                    } else if( selectedMove == "HyruleSlash" ) {
                        selectedMonster.HyruleSlash(curMonster);
                    } else if( selectedMove == "MindRend" ) {
                        selectedMonster.MindRend(curMonster);
                    } 
                    else {
                        System.Console.WriteLine("Invalid Move!");
                    }
                
                    // for(int i = 0; i < moves.Length ; i++){
                    //     if (selectedMove == moves[i]){
                    //         actions[i]();
                    //     }
                    // }
                    break;
                case "item": 
                    foreach (KeyValuePair<string,int> entry in curPlayer.Inventory){
                        if(entry.Value > 0){ System.Console.WriteLine(entry.Key);}
                    }
                    string selectedItem = Console.ReadLine();
                    if( selectedItem == "Healing Potion" ) {
                        curPlayer.HealingPotion(selectedMonster);
                    } else if( selectedItem == "Poison Bomb" ) {
                        curPlayer.PoisonBomb(selectedMonster);
                    } else if( selectedItem == "Beer" ) {
                        curPlayer.Intoxicate(selectedMonster);
                    } else if( selectedItem == "Strength Potion" ) {
                        curPlayer.StrengthPotion(selectedMonster);
                    } else if( selectedItem == "Constitution Potion" ) {
                        curPlayer.ConstitutionPotion(selectedMonster);
                    } else {
                        System.Console.WriteLine("Not a valid item");
                    }

                    break;
                case "run":
                    Random rand = new Random();
                    if(rand.Next(0,11) < 5){
                        System.Console.WriteLine("Successfully ran away");
                        curMonster.HP = -1;
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