using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        static int powerUpsPickedUp;



        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        static Enemy()
        {
            powerUpsPickedUp = 0;
        }

        static int GetNumberOfPowerUpsPickedUp() => powerUpsPickedUp;
        public string GetName() 
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield<0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health<0)
                {
                    health = 0;
                }
            }
        }

        public float GetHealth() => health;

        public float GetShield() => shield;


        public string SetName(string theName)
        {
            theName = theName.Trim();
            name = theName;
            return name;
        }

        public void PickUpPowerUp(PowerUp powerUp, float amount)
        {
            if(powerUp == PowerUp.Health)
            {
                health += amount;
                if(health >= 100)
                {
                    health = 100;
                }
            }
            else if(powerUp == PowerUp.Shield)
            {
                shield += amount;
                if(shield >= 100)
                {
                    shield = 100;
                }
            }

            powerUpsPickedUp++;
        } 
    }
}