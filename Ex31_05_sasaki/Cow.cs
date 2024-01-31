using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_05_sasaki
{
    internal class Cow:Character
    {
        public Cow(string name, float hp, float power,bool poisonResistance= false) : base(name, hp, power,poisonResistance) { }
        public override void Attack(Character destination)
        {
                Console.WriteLine($"{this.name}は{destination.name}を角でついた！");
            Console.WriteLine($"{destination.name}に風穴をあけた！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }

    }
}
