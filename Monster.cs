using System;
using System.Collections.Generic;

namespace CthuluMon {
    public class Monster {
        public string Name {get; set;}
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
            double damage = ((this.Strength*3) - (victim.Constitution *0.15));
            victim.HP -= damage;
            System.Console.WriteLine("{0} attacks, tooth and nail! {1} takes {2} damage. {1} has {3} health remaining!", this.Name, victim.Name, damage, victim.HP);
        }

        public void KawaiiiClaw(Monster victim) {
            double damage = ((this.Strength*3) - (victim.Charisma *0.15));
            victim.HP -= damage;
            System.Console.WriteLine("{0} lunges at your throat, bearing claws both sinister and kawaiiiiii! {1} takes {2} damage. {1} has {3} health remaining!", this.Name, victim.Name, damage, victim.HP);
        }

        public void GluttonousBite(Monster victim) {
            double damage = ((this.Strength*2) - (victim.Strength*0.30));
            victim.HP -= damage;
            System.Console.WriteLine("{0} dislodges their lower jaw, sinking its jagged, rotten teeth into {1}'s shoulder with a wet crunch. {1} feels {2} HP rip away with a sickening groan. {1} has {3} health remaining!", this.Name, victim.Name, damage, victim.HP);
        }

        public void Ravage(Monster victim) {
            double damage = ((this.Strength*2) - (victim.Dexterity*0.50));
            victim.HP -= damage;
            System.Console.WriteLine("{0} launches itself towards {1}, lashing out with wild, savage swings. A dull crunch and wet, gutteral sob of victory break the eerie silence as {1} takes {2} damage. {1} has {3} health remaining!", this.Name, victim.Name, damage, victim.HP);
        }

        public void HyruleSlash(Monster victim) {
            double damage = ((this.Dexterity*3) - (victim.Constitution*0.35));
            victim.HP -= damage;
            System.Console.WriteLine("{0} draws a longsword bearing the emblem of a fallen warrior, the blade chipped and rusted. Falling beneath a whirlwind of blows, {1} takes {2} damage. {1} has {3} health remaining!", this.Name, victim.Name, damage, victim.HP);
        }

        public void MindRend(Monster victim) {
            double damage = ((this.Wisdom*4) - (victim.Charisma*0.35));
            victim.HP -= damage;
            System.Console.WriteLine("{0} folds their hands and hums a single, deeply resonant chant. The center of {0}'s forehead splits open, revealing an eye with a black iris and radiant violet pupil. Looking upon {1}, the eye reveals the terrible future, a dark truth of what has yet to come. Crumpling to the ground, sobbing, {1} takes {2} damage. {1} has {3} health remaining!", this.Name, victim.Name, damage, );
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
        public static string[] getMoves(){
            string[] Moves = {"Attack", "KawaiiiClaw", "GluttonousBite", "Ravage", "HyruleSlash", "MindRend"};
            return Moves;
        }

    }

}