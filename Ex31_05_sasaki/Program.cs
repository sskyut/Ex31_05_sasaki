using System.Threading.Tasks;

namespace Ex31_05_sasaki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nam;
            Random rand = new Random();
            Character character1 = new Character("しむら人", 500, 2,true,true);
            Character character2 = new Character("ささっき", 1000, 25,true,false);
            Tank tank1 = new Tank("Tiger", 500000, 250,true,false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125, false, false);
            tank2.bullet = 5;
            Cow cow = new Cow("牛", 700, 50,false);  
            Cat cat = new Cat("たま", 200, 30,true);
            Bee bee1 = new Bee("蜂", 65, 80,false);
            Bee bee2 = new Bee("ハチ", 85, 60, false);
            Character[] characters = { character1, character2, tank1, tank2,cow ,cat,bee1,bee2};
            for (var i = 0; i < characters.Length; i++)
            {
                for(; ; )
                {
                    nam = rand.Next(0, characters.Length);
                    if (nam != i)
                    {
                        break;
                    }
                }
                characters[i].Attack(characters[nam]);
            }
        }
    }
}