using System;
using System.Collections.Generic;

namespace CthuluMon {
    public class Monster {
        public string Name {get; set;}
        public int ID {get; set;}
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

        public Monster(int ID, string name) {
            this.Name = name;
            this.ID = ID;
            Random rand = new Random();
            Strength = Math.Round((rand.NextDouble() * 20.0)+5, 2);
            Dexterity = Math.Round((rand.NextDouble() * 20.0)+5, 2);
            Constitution = Math.Round((rand.NextDouble() * 20.0)+5, 2);
            Intelligence = Math.Round((rand.NextDouble() * 20.0)+5, 2);
            Wisdom = Math.Round((rand.NextDouble() * 20.0)+5, 2);
            Fortitude = Math.Round((rand.NextDouble() * 20.0)+5, 2);
            Charisma = Math.Round((rand.NextDouble() * 20.0)+5, 2);
            HP = rand.Next(100,200);
        }

        public void Move(double yojana) { // 1 yojana = 13km or 8 miles
            Distance += yojana;
        }

        public void Attack(Monster victim) {
            victim.HP -= (Constitution * 0.15 +(Strength*3));                        
        }
        
        public void getInfo(){
            System.Console.WriteLine(Name);
            System.Console.WriteLine("Monster str: " + Strength);
            System.Console.WriteLine("Monster dex: " + Dexterity);
            System.Console.WriteLine("Monster con: " + Constitution);
            System.Console.WriteLine("Monster int: " + Intelligence);
            System.Console.WriteLine("Monster wis: " + Wisdom);
            System.Console.WriteLine("Monster fort: " + Fortitude);
            System.Console.WriteLine("Monster char: " + Charisma);
            System.Console.WriteLine("Monster Health: " + HP);
        }
        public void getHealth(){
            System.Console.WriteLine(Name + HP);
        }

    }
}