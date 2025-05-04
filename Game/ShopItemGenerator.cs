using Game.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game.Game
{
    public class ShopItemGenerator
    {
        public Player player;
        public ShopItemGenerator(Player player) 
        {
            // 1 weapon, 2 armor, 3 accessory
            this.player = player;
        }
        public void BuyItem(int random, int index)
        {
            Form1 mainForm = new Form1(player);
            ShopForm shopForm = new ShopForm(player);
            switch (random)
                {
                    case 1:
                        switch (index)
                        {
                            case 1:
                                if (player.Gold >= 100)
                                {
                                    player.weapon.AttackBonusWeapon = 2;
                                    player.weapon.NameWeapon = "Початковий рівень зброї";
                                    player.weapon.IndexWeapon = 1;
                                    player.Gold -= 100;
                                    player.purchases += 1;
                                    shopForm.Hide();
                                    mainForm.UpdateStats();
                                    mainForm.ShowDialog();
                            }
                                else
                                {
                                    MessageBox.Show("У вас недостаточно грошей");
                                }
                                break;
                            case 2:
                                if (player.Gold >= 300)
                                {
                                    player.weapon.AttackBonusWeapon = 4;
                                    player.weapon.NameWeapon = "Середній рівень зброї";
                                    player.weapon.IndexWeapon = 2;
                                    player.Gold -= 300;
                                    player.purchases += 1;
                                    shopForm.Hide();
                                    mainForm.UpdateStats();
                                    mainForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("У вас недостаточно грошей");
                                }
                                break;
                            case 3:
                                if (player.Gold >= 500)
                                {
                                    player.weapon.AttackBonusWeapon = 6;
                                    player.weapon.NameWeapon = "Високий рівень зброї";
                                    player.weapon.IndexWeapon = 3;
                                    player.Gold -= 500;
                                    player.purchases += 1;
                                    shopForm.Hide();
                                    mainForm.UpdateStats();
                                    mainForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("У вас недостаточно грошей");
                                }
                                break;
                            case 4:
                                if (player.Gold >= 800)
                                {
                                    player.weapon.AttackBonusWeapon = 10;
                                    player.weapon.NameWeapon = "Експертний рівень зброї";
                                    player.weapon.IndexWeapon = 4;
                                    player.Gold -= 800;
                                    player.purchases += 1;
                                    shopForm.Hide();
                                    mainForm.UpdateStats();
                                    mainForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("У вас недостаточно грошей");
                                }
                                break;
                            case 5:
                                if (player.Gold >= 1200)
                                {
                                    player.weapon.AttackBonusWeapon = 20;
                                    player.weapon.NameWeapon = "Легендарний рівень зброї";
                                    player.weapon.IndexWeapon = 5;
                                    player.Gold -= 1200;
                                    player.purchases += 1;
                                    shopForm.Hide();
                                    mainForm.UpdateStats();
                                    mainForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("У вас недостаточно грошей");
                                }
                                break;
                        }
                    break;
                case 2:
                    switch (index)
                    {
                        case 1:
                            if (player.Gold >= 100)
                            {
                                player.armor.DefenseBonusArmor = 100;
                                player.armor.NameArmor = "Початковий рівень броні";
                                player.armor.IndexArmor = 1;
                                player.Gold -= 100;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                        case 2:
                            if (player.Gold >= 300)
                            {
                                player.armor.DefenseBonusArmor = 200;
                                player.armor.NameArmor = "Середній рівень броні";
                                player.armor.IndexArmor = 2;
                                player.Gold -= 300;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                        case 3:
                            if (player.Gold >= 500)
                            {
                                player.armor.DefenseBonusArmor = 300;
                                player.armor.NameArmor = "Високий рівень броні";
                                player.armor.IndexArmor = 3;
                                player.Gold -= 500;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                        case 4:
                            if (player.Gold >= 800)
                            {
                                player.armor.DefenseBonusArmor = 500;
                                player.armor.NameArmor = "Експертний рівень броні";
                                player.armor.IndexArmor = 4;
                                player.Gold -= 800;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                        case 5:
                            if (player.Gold >= 1200)
                            {
                                player.armor.DefenseBonusArmor = 1000;
                                player.armor.NameArmor = "Легендарний рівень броні";
                                player.armor.IndexArmor = 5;
                                player.Gold -= 1200;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (index)
                    {
                        case 1:
                            if (player.Gold >= 100)
                            {
                                player.accessory.ManaBonusAccessory = 100;
                                player.accessory.NameAccessory = "Початковий рівень аксесуара";
                                player.accessory.IndexAccessory = 1;
                                player.Gold -= 100;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                        case 2:
                            if (player.Gold >= 300)
                            {
                                player.accessory.ManaBonusAccessory = 200;
                                player.accessory.NameAccessory = "Середній рівень аксесуара";
                                player.accessory.IndexAccessory = 2;
                                player.Gold -= 300;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                        case 3:
                            if (player.Gold >= 500)
                            {
                                player.accessory.ManaBonusAccessory = 300;
                                player.accessory.NameAccessory = "Високий рівень аксесуара";
                                player.accessory.IndexAccessory = 3;
                                player.Gold -= 500;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                        case 4:
                            if (player.Gold >= 800)
                            {
                                player.accessory.ManaBonusAccessory = 500;
                                player.accessory.NameAccessory = "Експертний рівень аксесуара";
                                player.accessory.IndexAccessory = 4;
                                player.Gold -= 800;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                        case 5:
                            if (player.Gold >= 1200)
                            {
                                player.accessory.ManaBonusAccessory = 1000;
                                player.accessory.NameAccessory = "Легендарний рівень аксесуара";
                                player.accessory.IndexAccessory = 5;
                                player.Gold -= 1200;
                                player.purchases += 1;
                                shopForm.Hide();
                                mainForm.UpdateStats();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("У вас недостаточно грошей");
                            }
                            break;
                    }
                    break;

            }
        }
        public void SellItem(int random) 
        {
            switch (random)
            {
                case 1:
                    switch (player.weapon.IndexWeapon)
                    {
                        case 0:
                            MessageBox.Show("У вас немає зброї на продаж.");
                            break;
                        case 1:
                            player.weapon.IndexWeapon = 1;
                            player.Gold += 50;
                            player.sales += 1;
                            player.weapon.AttackBonusWeapon = 0;
                            break;
                        case 2:
                            player.weapon.IndexWeapon = 2;
                            player.Gold += 100;
                            player.sales += 1;
                            player.weapon.AttackBonusWeapon = 0;
                            break;
                        case 3:
                            player.weapon.IndexWeapon = 3;
                            player.Gold += 150;
                            player.sales += 1;
                            player.weapon.AttackBonusWeapon = 0;
                            break;
                        case 4:
                            player.weapon.IndexWeapon = 4;
                            player.Gold += 200;
                            player.sales += 1;
                            player.weapon.AttackBonusWeapon = 0;
                            break;
                        case 5:
                            player.weapon.IndexWeapon = 5;
                            player.Gold += 250;
                            player.sales += 1;
                            player.weapon.AttackBonusWeapon = 0;
                            break;
                        case 6:
                            MessageBox.Show("У вас немає зброї на продаж");
                            break;
                    }
                    break;
                case 2:
                    switch (player.armor.IndexArmor)
                    {
                        case 0:
                            MessageBox.Show("У вас немає Броні на продаж.");
                            break;
                        case 1:
                            player.armor.IndexArmor = 0;
                            player.Gold += 50;
                            player.sales += 1;
                            player.armor.DefenseBonusArmor = 0;
                            break;
                        case 2:
                            player.armor.IndexArmor = 0;
                            player.Gold += 100;
                            player.sales += 1;
                            player.armor.DefenseBonusArmor = 0;
                            break;
                        case 3:
                            player.armor.IndexArmor = 0;
                            player.Gold += 150;
                            player.sales += 1;
                            player.armor.DefenseBonusArmor = 0;
                            break;
                        case 4:
                            player.armor.IndexArmor = 0;
                            player.Gold += 200;
                            player.sales += 1;
                            player.armor.DefenseBonusArmor = 0;
                            break;
                        case 5:
                            player.armor.IndexArmor = 0;
                            player.Gold += 250;
                            player.sales += 1;
                            player.armor.DefenseBonusArmor = 0;
                            break;
                        case 6:
                            MessageBox.Show("У вас немає броні на продаж");
                            break;
                    }
                    break;
                case 3:
                    switch (player.accessory.IndexAccessory)
                    {
                        case 0:
                            MessageBox.Show("У вас немає аксесуара на продаж.");
                            break;
                        case 1:
                            player.accessory.IndexAccessory = 0;
                            player.Gold += 50;
                            player.sales += 1;
                            player.accessory.ManaBonusAccessory = 0;
                            break;
                        case 2:
                            player.accessory.IndexAccessory = 0;
                            player.Gold += 100;
                            player.sales += 1;
                            player.accessory.ManaBonusAccessory = 0;
                            break;
                        case 3:
                            player.accessory.IndexAccessory = 0;
                            player.Gold += 150;
                            player.sales += 1;
                            player.accessory.ManaBonusAccessory = 0;
                            break;
                        case 4:
                            player.accessory.IndexAccessory = 0;
                            player.Gold += 200;
                            player.sales += 1;
                            player.accessory.ManaBonusAccessory = 0;
                            break;
                        case 5:
                            player.accessory.IndexAccessory = 0;
                            player.Gold += 250;
                            player.sales += 1;
                            player.accessory.ManaBonusAccessory = 0;
                            break;
                        case 6:
                            MessageBox.Show("У вас немає аксесуара на продаж");
                            break;
                    }
                    break;
            }
        }
    }
}
