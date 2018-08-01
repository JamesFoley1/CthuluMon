using System;
using System.Collections.Generic;

namespace CthuluMon {

    public class Player {
        private string Name = "Cthulu";
        public string Race {get; set;}
        public double Distance {get; set;}
        public double Strength {get; set;}
        public double Dexterity {get; set;}
        public double Constitution {get; set;}
        public double Intelligence {get; set;}
        public double Wisdom {get; set;}
        public double Fortitude {get; set;}
        public double Charisma {get; set;}
        public double HP {get; set;}
        public List<object> Inventory {get;set;}
        public List<object> Party {get;set;}
        
        public Player(){
            Random rand = new Random();
            Race = "Elder One";
            Distance = 0.0;
            Strength = Math.Round((rand.NextDouble() * 15.0)+8, 2);
            Dexterity = Math.Round((rand.NextDouble() * 15.0)+8, 2);
            Constitution = Math.Round((rand.NextDouble() * 15.0)+8, 2);
            Intelligence = Math.Round((rand.NextDouble() * 15.0)+8, 2);
            Wisdom = Math.Round((rand.NextDouble() * 15.0)+8, 2);
            Fortitude = Math.Round((rand.NextDouble() * 15.0)+8, 2);
            Charisma = Math.Round((rand.NextDouble() * 15.0)+8, 2);
            HP = 100;
        }



    }
}