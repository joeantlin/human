using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Dave");
            Human human2 = new Human("Steve", 5, 6, 3, 80);
            human1.DisplayHealth();
            human2.DisplayHealth();
            human2.Attack(human1);
        }
    }
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        public Human(string name){
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int stren, int intel, int dext, int health){
            Name = name;
            Strength = stren;
            Intelligence = intel;
            Dexterity = dext;
            Health = health;
        }
        public int TotalHealth
        {
            get
            {
                return Health;
            }
            set
            {
                Health = value;
            }
        }
        public void DisplayHealth()
        {
            if (TotalHealth == 100)
            {
                 Console.WriteLine($"{Name} has {TotalHealth.ToString()} Health!");
            }
            else 
            {
                Console.WriteLine($"{Name} has {TotalHealth.ToString()} Health left!");
            }
            
        }
        public void Attack(Human target)
        {
            int damageTaken = Strength * 5;
            target.TotalHealth = target.TotalHealth - damageTaken;
            Console.WriteLine($"{Name} has attacked {target.Name} for {damageTaken} damage!");
            target.DisplayHealth();
        }
    }

}
