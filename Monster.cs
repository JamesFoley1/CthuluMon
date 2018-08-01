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
        public Monster(string name) {
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
            double damage = (victim.Constitution *0.15 -(this.Strength*3));
            victim.HP -= (victim.Constitution * 0.15 -(Strength*3));
            System.Console.WriteLine("{0} attacks, tooth and nail! {1} takes {2} damage.", this.Name, victim.Name, damage);                        
        }

        public void KawaiiiClaw(Monster victim) {
            victim.HP -= (victim.Charisma *0.20 -(Dexterity*3));
        }

        public void GluttonousBite(Monster victim) {
            victim.HP -= (Strength * 0.30 -(Strength*2));
        }

        public void Ravage(Monster victim) {
            victim.HP -= (Strength *0.50 -(Strength*2));
        }

        public void MindRend(Monster victim) {
            victim.HP -= (Charisma *0.35 -(Wisdom*3));
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
        public static List<Monster> GenerateMonster(){
            string[] Names = {"Byakyae", "Star-spawn", "Hello Kitty", "Dracolich", "Tzzensech", "Shoggoth"};
            List<Monster> monsters = new List<Monster>();
            for(int i = 0; i < 6; i++){
                Monster monster = new Monster(Names[i]);
                monsters.Add(monster);
            }
            return monsters;
        }
    }
}