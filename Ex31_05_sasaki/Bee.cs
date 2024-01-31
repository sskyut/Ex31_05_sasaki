using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_05_sasaki
{
    internal class Bee : Character
    {
        public Bee(string name, float hp, float power, bool poisonResistance = false) : base(name, hp, power,poisonResistance) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は毒針で{destination.name}を刺した！");

            if (destination.animal)
            {
                Console.WriteLine($"{destination.name}は動物だ！");
                if (destination.poisonResistance)
                {
                    Console.WriteLine($"{destination.name}には、毒耐性があった！");
                    Console.WriteLine($"しかし、刺されて痛かった");
                    Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                    destination.hp -= this.power;
                    Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                }
                else
                {
                    Console.WriteLine($"{destination.name}は毒によって即死した！");
                    destination.hp = 0;
                    Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                   
                }
            }
            else
            {
                Console.WriteLine($"{destination.name}は動物ではない！");
                if (destination.poisonResistance)
                {
                    Console.WriteLine($"{destination.name}にはきかなかった！");
                }
                else
                {
                    Console.WriteLine($"しかし、{destination.name}は毒によって劣化してしまった！");
                    Console.WriteLine($"{destination.name}は{this.power * 2}のダメージ");
                    destination.hp -= this.power * 2;
                    Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                }
            }

        }
    }
}
