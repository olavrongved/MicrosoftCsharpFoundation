public class RpgGame(int heroInitialHp = 10, int monsterInitialHp = 10)
{
    public void SimulateBattle()
    {
        var attackGenerator = new Random();
        int heroHp = heroInitialHp;
        int monsterHp = monsterInitialHp; 
        while (true)
        {
            int heroAttack = attackGenerator.Next(1, 10);
            monsterHp -= heroAttack;
            Console.WriteLine($"Hero attacks monster for {heroAttack} damage. Monster has {monsterHp} hp left.");
            if (!IsAlive(monsterHp))
            {
                Console.WriteLine("Hero wins!");
                break;
            }
            
            int monsterAttack = attackGenerator.Next(1, 10);
            heroHp -= monsterAttack;
            Console.WriteLine($"Monster attacks hero for {monsterAttack} damage. Hero has {heroHp} hp left.");
            if(!IsAlive(heroHp))
            {
                Console.WriteLine("Monster wins!");
                break;
            }
        }

    }
    private static bool IsAlive(int hp) => hp > 0;
}