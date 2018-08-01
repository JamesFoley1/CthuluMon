using System;
using System.Collections.Generic;

namespace CthuluMon {

    public class Player {
        private string Name {get; set;}
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
        
        public Player(string name){
            Name = name;
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

        public void Attack(Monster target) {
            target.HP -= (Constitution * 0.15 +(Strength*3));                        
        }

        public void MindControl(Monster target, Monster _target){
            Monster Target = target;
            Target.Attack(_target);
        }

        public void MindFlay(Monster target){
            target.HP -= (target.Fortitude * 0.5 + (5 * this.Intelligence + (this.Wisdom * 0.15)));
        }

        public void DarkBlessing(Monster target){
            target.Strength += 3;
            target.Dexterity += 3;
            target.Constitution += 3;
            target.Intelligence += 3;
            target.Wisdom += 3;
            target.Fortitude += 3;
            target.Charisma += 3;
            target.HP += 50;
        }

        public void DeathsCaress(Monster target){
            Random rand = new Random();
            if(target.HP <= 40){
                if((rand.NextDouble() * 1.0 ) > 0.93){
                    System.Console.WriteLine("Target Resisted Your grasp!");
                }
                else {
                    if (this.HP+target.HP <= 100){
                        this.HP += target.HP;
                    }
                    else if (this.HP + target.HP > 100){
                        this.HP = 100;
                    }
                    else if(this.HP == 100){
                        this.HP += (target.HP / 15);
                        System.Console.WriteLine("Your hunger has been sated and have gained bonus health! {0}", this.HP);
                    }
                    target.HP = 0;
                    System.Console.WriteLine("You feast upon {0}!", target.Name);
                }
            }
        }

    }
}