using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Entity
{
    public class Player
    {
        public string Name;
        public int Playerstatus;
        // Все до Level
        public int Level;
        public int LevelCup;
        public int Experience;
        public int MaxExperience;
        public int amount;
        // Все до характеристик
        public int Strength;
        public int Endurance;
        public int Agility;
        public int Intelligence;
        public int Health;
        public int MaxHealth;
        public int Mana;
        public int MaxMana;
        public double CriticalChance;
        // Все д статистики
        public int Gold;
        public int purchases;
        public int sales;
        public int wins;
        public int losses;
        // Все до бою
        public bool defence;
        public int defenceHealth;
        public int damage;

        public Enemy enemy;
        public Weapon weapon;
        public Armor armor;
        public Accessory accessory;

        public Player()
        {

        }

        public Player(Weapon weapon, Armor armor, Accessory accessory)
        {
            this.armor = armor;
            this.weapon = weapon;
            this.accessory = accessory;

            Level = 1;
            LevelCup = 1;
            Experience = 0;
            MaxExperience = 500;
            CriticalChance = Agility * 0.1;

            purchases = 0;
            sales = 0;
            wins = 0;
            losses = 0;
            defence = false;

            if (this.armor == null)
            {
                MaxHealth = Endurance * 5;
            }
            else
            {
                MaxHealth = Endurance * 5 + armor.DefenseBonusArmor;
            }
            if (this.accessory == null)
            {
                MaxMana = Intelligence * 5;
            }
            else
            {
                MaxMana = Intelligence * 5 + accessory.ManaBonusAccessory;
            }
            Health = MaxHealth;
            Mana = MaxMana;

        }
        public void UpdateStats()
        {
            CriticalChance = Agility * 0.1;
            if (this.armor == null)
            {
                MaxHealth = Endurance * 5;
            }
            else
            {
                MaxHealth = Endurance * 5 + armor.DefenseBonusArmor;
            }
            if (this.accessory == null)
            {
                MaxMana = Intelligence * 5;
            }
            else
            {
                MaxMana = Intelligence * 5 + accessory.ManaBonusAccessory;
            }
        }
        public void PlayerAttack(Enemy enemy, int minusMana, int number)
        {
            Mana -= minusMana;
            Random random = new Random();
            damage = Strength;

            if (this.weapon != null)
                damage += this.weapon.AttackBonusWeapon;

            if (random.Next(100) < CriticalChance)
            {
                damage *= 3;
            }
            damage = damage * number;
            enemy.Health -= damage;
        }
        public void PlayerHeal()
        {
            Mana -= 10;
            Health = MaxHealth;
            MessageBox.Show("Гравець лікувався.");
        }
        public void PlayerDefence()
        {
            Mana -= 5;
            defence = true;
            MessageBox.Show("Гравець обороняється.");
        }
        public void PlayerMeditation()
        {
            Mana = MaxMana;
            MessageBox.Show("Гравець медитує.");
        }
        public void AddExperience(int amountEXP)
        {
            amount = amountEXP;
            while (amount >= MaxExperience - Experience)
            {
                amount -= (MaxExperience - Experience);
                LevelUp();
            }
            Experience = amount;
        }
        public void LevelUp()
        {
            Level += 1;
            Strength += 2;
            Endurance += 3;
            Intelligence += 4;
            Agility += 3;
            MaxExperience *= 2;
            UpdateStats();
            Health = MaxHealth;
            Mana = MaxMana;
            UpdateStats();
            MessageBox.Show("Рівень підвищено! Тепер рівень " + Level);
        }
    }
}
