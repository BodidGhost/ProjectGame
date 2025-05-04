using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Entity
{
    public class Player
    {
        public string Name;
        public int Playerstatus; // 1-Воїн, 2-Лицар, 3-Лучник, 4-Розбійник, 5-Маг, 6-Асасін
        public int Level;
        public int LevelCup;
        public int Experience;
        public int MaxExperience;
        public int EXtoNextLevel;
        public int Strength;
        public int Endurance;
        public int Agility;
        public int Intelligence;
        public int Health;
        public int MaxHealth;
        public int Mana;
        public int MaxMana;
        public int Gold;
        public double CriticalChance;
        public int purchases;
        public int sales;
        public int wins;
        public int losses;
        public bool defence;
        public int defenceHealth;
        public int damage;
        public int combatHealth;
        public int combatMana;
        public int maxcombatHealth;
        public int maxcombatMana;

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
            EXtoNextLevel = MaxExperience - Experience;
            CriticalChance = Agility * 0.005;
            purchases = 0;
            sales = 0;
            wins = 0;
            losses = 0;
            defence = false;
            MaxHealth = Endurance * 5;
            Health = MaxHealth;
            MaxMana = Intelligence * 5;
            Mana = MaxMana;
            combatHealth = Health + armor.DefenseBonusArmor;
            combatMana = Mana + accessory.ManaBonusAccessory;
            maxcombatHealth = combatHealth;
            maxcombatMana = combatMana;

        }

        public int PlayerAttack()
        {
            combatMana -= 10;
            Random random = new Random();
            damage = Strength;

            if (this.weapon != null)
                damage += this.weapon.AttackBonusWeapon;

            if (random.Next(100) >= CriticalChance)
            {
                damage *= 3;
            }
            return damage;
        }
        public int PlayerPowerAttack()
        {
            combatMana -= 20;
            Random random = new Random();
            damage = Strength * 2;

            if (this.weapon != null)
                damage += this.weapon.AttackBonusWeapon;
            
            if (random.Next(100) >= CriticalChance)
            {
                damage *= 3;
            }
            return damage;
        }
        public void PlayerHeal()
        {
            combatMana -= 10;
            Health += MaxHealth;
            MessageBox.Show("Гравець лікувався.");
        }
        public void PlayerDefence()
        {
            combatMana -= 5;
            defence = true;
            MessageBox.Show("Гравець обороняється.");
        }
        public void AddExperience(int amount)
        {
            Experience += amount;
            while (Experience >= EXtoNextLevel)
            {
                Experience -= EXtoNextLevel;
                LevelUp();
            }
        }
        public void LevelUp()
        {
            Level += 1;
            Strength += 2;
            Endurance += 1;
            Intelligence += 1;
            MaxHealth += 20;
            Health = MaxHealth;
            MaxMana += 20;
            Mana = MaxMana;
            MaxExperience *= 2;
            EXtoNextLevel = MaxExperience - Experience;
            MessageBox.Show("Рівень підвищено! Тепер рівень " + Level);
        }
    }
}
