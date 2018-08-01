using System;
using System.Collections.Generic;

namespace CthuluMon{
    public class Game {
        public string Gender;
        public Player currentPlayer;
        public List<Monster> currentTeam = new List<Monster>();
        public string[] options = {"move", "heal", "stats"};

    public void startGame()
        {
        System.Console.WriteLine("Hi, and welcome to the wonderful world of CthuluMon! I'm professor Oak! What's your name?");   
        string inputName = Console.ReadLine();

        System.Console.WriteLine($"Well it's great to meet you {inputName}! CthuluMon are mysterious and terrifying creatures. Let's catch 'em all!");

        currentPlayer = new Player(inputName);

        // // currentTeam = Monster.GenerateMonster();
        // for(int i = 0; i < 4; i++){
        //    Monster monster =  new Monster(0,"Bob");
        //    currentTeam.Add(monster);
        // }
        currentTeam = Monster.GenerateMonster();

        while(currentPlayer.HP > 0){
            Make_Choice();
            }   
        
        }

        public void Make_Choice(){
           
            System.Console.WriteLine("What do you want to do? move, heal, or stats");

            string choice = Console.ReadLine();

            switch (choice) {
                case "move":
                    Move(currentPlayer);
                    break;
                case "heal":
                    Heal();
                    // heal a pokemon
                    break;
                case "stats":
                    foreach(Monster monster in currentTeam){
                        Program.getStats(monster);
                    }
                    // get pokemon stats
                    break;
                default:
                    break;
            }

        }

        public void Move(Player player){
            Random rand = new Random();
            player.Distance += 1;
            System.Console.WriteLine($"{player.Name} has walked {player.Distance} steps down a darker path. Fhtang!");
            if(rand.Next(1,11) < 5){
                        //check for encounter
                        System.Console.WriteLine("A CthuluMon appeared!");
                        Encounter thisEncounter = new Encounter(currentPlayer, currentTeam, currentTeam[3]);
                        thisEncounter.StartEncounter();
                    } else {
                        Make_Choice();
                    }
        }
        public void Heal(){
            foreach(Monster monster in currentTeam){
                Random randHeal = new Random();
                monster.HP += randHeal.Next(40);
            }
        System.Console.WriteLine($"Invoking the dark powers which brought them to this forsaken realm, {currentPlayer.Name} call forth unholy energies to revitalize their demonic minions.");
        }
    }
}