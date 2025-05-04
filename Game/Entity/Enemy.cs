using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Entity
{
    public class Enemy
    {
        public string Name;
        public int Level;
        public int Attack;
        public int Health;
        public int MaxHealth;
        public int RewardGold;
        public int RewardXP;
        public Player player;
        public Enemy(Player player)
        {
            this.player = player;
            Level = player.Level;
            Attack = 3 + Level * 2;
            MaxHealth = 10 * Level;
            Health = MaxHealth;
            RewardGold = Level * 250;
            RewardXP = Level * 350;
        }
        public void EnemyAttack(Player player)
        {
            if (player.defence == true)
            {
                player.combatHealth -= Attack/2;
                player.defence = false;
            }
            else 
            {
                player.combatHealth -= Attack;
            }
            MessageBox.Show("Ворог атакує.");
        }
        public void EnemyHeal()
        {
            Health += MaxHealth / 3;
            MessageBox.Show("Ворог лікувався.");
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }
    }
}
