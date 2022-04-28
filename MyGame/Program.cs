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
        /// <summary>
        /// Creates Enemies and respective names per Enemy Number 
        /// and then shows them to the user  
        /// </summary>
        /// <param name="enemyNumber">The capacity of the enemiesArray</param>
        public static void EnemyCreator(int enemyNumber)
        {
            //Array of Enemy declaration
            Enemy[] enemiesArray = new Enemy[enemyNumber];
            //The array ID that gets changed in the for each loop
            int arrayID = 0;
            //Goes to every enemy in the enemiesArray
            foreach (Enemy enemy in enemiesArray)
            {
                //Asks for a name
                Console.WriteLine("Write Enemy Name: ");
                string enemyName = Console.ReadLine();
                //then creates the respective instance with the number gotten from the question above
                Enemy enemyInstance = new Enemy(enemyName);
                //Iguala o conteúdo do elemento respetivo do array enemiesArray com a instância criada
                enemiesArray[arrayID] = enemyInstance;

                enemyInstance.PickUpPowerUp(PowerUp.Health, 50);
                enemyInstance.PickUpPowerUp(PowerUp.Shield,20);
                
                //E por fim acrescenta 1 ao ID do array para depois o passo acima igual para o elemento do arrau enemiesArray seguinte
                arrayID++;
            }
            Console.WriteLine("You created the enemies: ");
            //Percorre o enemiesArray
            for (int j = 0; j < enemiesArray.Length; j++)
            {
                
                //Faz print do nome, vida e shield  do respetivo elemento do array
                Console.WriteLine($"{enemiesArray[j].GetName()}");
                Console.WriteLine($"Has {enemiesArray[j].GetHealth()} of Health");
                Console.WriteLine($"Has {enemiesArray[j].GetShield()} of Shield");
            }
            
            
        }
    }
}
