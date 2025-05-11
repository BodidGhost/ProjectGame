using Game.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Game
{
    public class GameEvent
    {
        public Player player;
        public Enemy enemy;
        public GameEvent(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }
        public void DoEvent(int number1, int number2)
        {
            CombatForm combatForm = new CombatForm(player, enemy);
            ShopForm shopForm = new ShopForm(player);
            switch (number1)
            {
                case 1:
                    MessageBox.Show("Бій!");
                    combatForm.ShowDialog();
                    break;
                case 2:
                    MessageBox.Show("Нічого не сталося.");
                    break;
                case 3:
                    Event(number2);
                    break;
                case 4:
                    MessageBox.Show("Ви можете закупитися.");
                    shopForm.ShowDialog();
                    break;
            }
        }
        public void Event(int number2)
        {
            switch (number2)
            {
                case 1:
                    player.Gold += 100;
                    MessageBox.Show("Ви отримало 100 золота.");
                    break;
                case 2:
                    MessageBox.Show("Вам повезло! Ви отримало 500 золота!");
                    player.Gold += 500;
                    break;
                case 3:
                    MessageBox.Show("Ви отримало 100 досвіду.");
                    player.AddExperience(100);
                    break;
                case 4:
                    MessageBox.Show("Вам повезло! Ви отримало 500 досвіду!");
                    player.AddExperience(500);
                    break;
                case 5:
                    player.LevelCup += 1;
                    MessageBox.Show("Ви отримало + 1 LevelCup.");
                    break;
                case 6:
                    player.Health = player.MaxHealth;
                    MessageBox.Show("Ви зцілилися.");
                    break;
                case 7:
                    player.Mana = player.MaxMana;
                    MessageBox.Show("Ви поновили ману.");
                    break;
                case 8:
                    player.Health -= 5;
                    MessageBox.Show("У вас відняли 5 здоров'я.");
                    break;
                case 9:
                    if (player.Gold < 100)
                    {
                        player.Gold = 0;
                    }
                    else
                    {
                        player.Gold -= 100;
                    }
                    MessageBox.Show("У вас відняли 100 золота.");
                    break;
                case 10:
                    if (player.Gold < 300)
                    {
                        player.Gold = 0;
                    }
                    else
                    {
                        player.Gold -= 300;
                    }
                    MessageBox.Show("Вам не повезло! У вас відняли 300 досвіду.");
                    break;
            }
        }
    }
}
