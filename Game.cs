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

        // currentTeam = Monster.GenerateMonster();
        for(int i = 0; i < 4; i++){
           Monster monster =  new Monster(0,"Bob");
           currentTeam.Add(monster);
        }

        while(currentPlayer.HP > 0){
            Make_Choice();
            }   
        
        }

        public void Make_Choice(){
           
            System.Console.WriteLine("What do you want to do? move, heal, or stats");

            string choice = Console.ReadLine();

            switch (choice) {
                case "move":
                    Move();
                    break;
                case "heal":
                    // heal a pokemon
                    break;
                case "stats":
                    // get pokemon stats
                    break;
                default:
                    break;
            }

        }

        public void Move(){
             Random rand = new Random();
            if(rand.Next(1,11) < 3){
                        //check for encounter
                        System.Console.WriteLine("A pokemon appeared!");
                        Encounter thisEncounter = new Encounter(currentPlayer, currentTeam);
                        thisEncounter.StartEncounter();
                    } else {
                        Make_Choice();
                    }
        }
    }
}