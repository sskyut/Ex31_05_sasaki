using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_05_sasaki
{
    class Tank : Character
    {
        public int bullet = 0;
        Random rand = new Random();
        public Tank(string name, float hp, float power, bool poisonResistance=true , bool animal = false ) : base(name, hp, power, poisonResistance,animal) 
        {

        }
        public override void Attack(Character destination)
        　{
            if (bullet > 0)
            {
                bullet--;
                Console.WriteLine($"{this.name}は{destination.name}に向け大砲を発射！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{base.name}は弾切れです！");
                int nam = rand.Next(0, 2);
                if (nam > 0)//今は使わないけど一応リロード出来るようにする
                {
                    bullet=rand.Next(1, 10+1);
                    Console.WriteLine($"{base.name}は{bullet}個、弾を補給した！");
                }
                else
                {
                    Console.WriteLine($"{base.name}は弾を補給出来なかった！");
                }
            }
        }
    }
}
