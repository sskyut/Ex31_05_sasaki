using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_05_sasaki
{
    internal class Character
    {
        readonly public string name;
        public float hp;
        protected float power;
        public bool poisonResistance;//trueで毒耐性がある
        readonly public bool animal;//trueで動物
        public Character(string name, float hp, float power,bool poisonResistance=false, bool animal = true)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.poisonResistance = poisonResistance;
            this.animal = animal;
        }
        public virtual void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}に体当たり！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
