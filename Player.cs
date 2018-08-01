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
        public Dictionary<string, int> Inventory = new Dictionary<string, int>();
        public List<object> Party {get;set;}
        public Dictionary<string, Delegate> MoveList = new Dictionary<string, Delegate>();
        
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
            Inventory.Add("Healing Potion", 3);
            Inventory.Add("Beer", 3);
            Inventory.Add("Poison Bomb", 1);
            Inventory.Add("Strength Potion", 1);
            Inventory.Add("Constitution Potion", 1);
        }

        public void Attack(Monster target) {
            target.HP -= (target.Constitution * 0.15 +(Strength*3));
        }
        public void MindControl(Monster target, Monster _target){
            Monster Target = target;
            Target.Attack(_target);
        }

        public void MindFlay(Monster target){
            target.HP -= (target.Fortitude * 0.3 + (5 * this.Intelligence + (this.Wisdom * 0.15)));
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

        public void HealingPotion(Monster target){
            if(this.Inventory["Healing Potion"] > 0){
                target.HP += 50;
                System.Console.WriteLine($"{target.Name} was healed for {50}!");
                this.Inventory["Healing Potion"] -= 1;
            }
            else {
                System.Console.WriteLine("You have no healing potions left!");
            }
        }
        public void PoisonBomb(Monster target){
            if(this.Inventory["Poison Bomb"] > 0){
                target.HP -= 50;
                System.Console.WriteLine($"{target.Name} took {50} damage!");
                this.Inventory["Poison Bomb"] -= 1;
            }
            else {
                System.Console.WriteLine("You have no poision bombs left!");
            }
        }
        public void Intoxicate(Monster target){
            if (this.Inventory["Beer"] >0){
                target.HP += 10;
                target.Strength += 3;
                target.Charisma += 3;
                target.Dexterity -= 2;
                target.Intelligence -= 2;
                target.Wisdom -= 2;
                System.Console.WriteLine($"{target.Name} became intoxicated. {target.Name}: {target.HP}{target.Strength}{target.Charisma}{target.Dexterity}{target.Intelligence}{target.Wisdom}");
                this.Inventory["Beer"] -= 1;
            }
            else {
                System.Console.WriteLine($"You have {this.Inventory["beer"]} beers left!");
            }
        }
        public void StrengthPotion(Monster target){
            if (this.Inventory["Strength Potion"] > 0){
                target.Strength += 5;
                System.Console.WriteLine($"{target.Name}'s strength was increased by {5}!");
                this.Inventory["Strength Potion"] -= 1;
            }
            else {
                System.Console.WriteLine("You have no strength potions left!");
            }
        }
        public void ConstitutionPotion(Monster target){
            if (this.Inventory["Constitution Potion"] > 0){
                target.Strength += 5;
                System.Console.WriteLine($"{target.Name}'s constitution was increased by {5}!");
                this.Inventory["Constitution Potion"] -= 1;
            }
            else {
                System.Console.WriteLine("You have no constitution potions left!");
            }
        }

    }
}