using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Enemies you want: ");
            int numberOfEnemies = int.Parse(Console.ReadLine());
            EnemyCreator(numberOfEnemies);
            
        }

        public static void EnemyCreator(int enemyNumber)
        {
            Enemy[] enemiesArray = new Enemy[enemyNumber];
            int i = 0;
            foreach (Enemy enemy in enemiesArray)
            {
                Console.WriteLine("Write Enemy Name: ");
                string enemyName = Console.ReadLine();
                Enemy enemyInstance = new Enemy(enemyName);
                enemiesArray[i] = enemyInstance;
                i++;
            }
            for (int j = 0; j < enemiesArray.Length; j++)
            {
                Console.WriteLine(enemiesArray[j].GetName());
                    
            }
            
        }
    }
}
