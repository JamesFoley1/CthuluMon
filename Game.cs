using System;

namespace CthuluMon{
    public class Game {
        public string Gender;
        public Player currentPlayer;
        public string[] options = {"move", "heal", "stats"};

    public void startGame()
        {
        System.Console.WriteLine("Hi, and welcome to the wonderful world of CthuluMon! I'm professor Oak! What's your name?");   
        string inputName = Console.ReadLine();

        System.Console.WriteLine($"Well it's great to meet you {inputName}! CthuluMon are mysterious and terrifying creatures. Let's catch 'em all!");

        currentPlayer = new Player(inputName);
        while(currentPlayer.HP > 0){
            Play play = new Play(currentPlayer);
            play.Make_Choice();
        }
        
        }
    }
}