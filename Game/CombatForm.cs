using Game.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game
{
    public partial class CombatForm : Form
    {
        public Player player;
        public Enemy enemy;
        public int orgStrength;
        public int minValue;
        public CombatForm(Player player, Enemy enemy)
        {

            this.player = player;
            this.enemy = enemy;
            InitializeComponent();
            UpdateStatus();
            UpdateEnemy();
            UpdateStats();
            minValue = 0;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (player.combatMana >= 10)
            {
                enemy.Health -= player.PlayerAttack();
                player.Strength = orgStrength;
                UpdateStats();
                if (enemy.Health > 0)
                {
                    DoEnemy();
                    UpdateStats();
                }
            }
            else
            {
                MessageBox.Show("У вас недостатньо мани!");
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {
            if (player.combatMana >= 20)
            {
                enemy.Health -= player.PlayerPowerAttack();
                player.Strength = orgStrength;
                UpdateStats();
                if (enemy.Health > 0)
                {
                    DoEnemy();
                    UpdateStats();
                }
            }
            else
            {
                MessageBox.Show("У вас недостатньо мани!");
            }
        }
        public void button3_Click(object sender, EventArgs e)
        {
            if (player.combatMana >= 5)
            {
                player.PlayerDefence();
                UpdateStats();
                DoEnemy();
                UpdateStats();
            }
            else
            {
                MessageBox.Show("У вас недостатньо мани!");
            }
        }
        public void button4_Click(object sender, EventArgs e)
        {
            if (player.combatMana >= 10)
            {
                player.PlayerHeal();
                UpdateStats();
                DoEnemy();
                UpdateStats();
            }
            else
            {
                MessageBox.Show("У вас недостатньо мани!");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            player.combatMana = player.MaxMana;
            UpdateStats();
            DoEnemy();
            UpdateStats();
        }
        public void UpdateStatus()
        {
            switch (player.Playerstatus)
            {
                case 1:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Image/voin.jpg");
                    break;
                case 2:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Image/knight.jpg");
                    break;
                case 3:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Image/robber.jpg");
                    break;
                case 4:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Image/bowman.png");
                    break;
                case 5:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Image/mage.jpg");
                    break;
                case 6:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Image/assassin.jpg");
                    break;

            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void UpdateEnemy()
        {
            Random random = new Random();
            switch (random.Next(1, 3))
            {
                case 1:
                    pictureBox2.Image = System.Drawing.Image.FromFile("Image/FightBackground.jpg");
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            pictureBox3.Image = System.Drawing.Image.FromFile("Image/Enemy3.jpg");
                            break;
                        case 2:
                            pictureBox3.Image = System.Drawing.Image.FromFile("Image/Enemy4.jpg");
                            break;
                    }
                    break;
                case 2:
                    pictureBox2.Image = System.Drawing.Image.FromFile("Image/FightBackground2.png");
                    switch (random.Next(1, 3))
                    {
                        case 1:
                            pictureBox3.Image = System.Drawing.Image.FromFile("Image/Enemy1.jpg");
                            break;
                        case 2:
                            pictureBox3.Image = System.Drawing.Image.FromFile("Image/Enemy2.jpg");
                            break;
                    }
                    break;
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void UpdateStats()
        {
            Form1 form1 = new Form1(player);
            if (player.combatHealth < 0)
            {
                player.combatHealth = 0;
            }
            if (player.combatMana < 0)
            {
                player.combatMana = 0;
            }
            if (enemy.Health < 0)
            {
                enemy.Health = 0;
            }
            label10.Text = player.combatHealth.ToString();
            label13.Text = player.maxcombatHealth.ToString();
            label16.Text = player.combatMana.ToString();
            label14.Text = player.maxcombatMana.ToString();
            label3.Text = enemy.Health.ToString();
            label1.Text = enemy.MaxHealth.ToString();
            progressBar1.Maximum = player.maxcombatHealth;
            progressBar2.Maximum = player.maxcombatMana;
            progressBar3.Maximum = enemy.MaxHealth;
            progressBar1.Minimum = minValue;
            progressBar2.Minimum = minValue;
            progressBar3.Minimum = minValue;
            Form1 mainForm = new Form1(player);

            if (player.Health <= 0)
            {
                MessageBox.Show("Ви програли.");
                player.losses += 1;
                player.combatHealth = 0;
                progressBar1.Value = 0;
                this.Hide();
                mainForm.UpdateStats();
                form1.UpdateEvent();
                mainForm.ShowDialog();
            }
            if (enemy.Health <= 0)
            {
                MessageBox.Show("Ви Перемогли.");
                player.wins += 1;
                progressBar3.Value = 0;
                player.Gold += enemy.RewardGold;
                player.AddExperience(enemy.RewardXP);
                this.Hide();
                mainForm.UpdateStats();
                form1.UpdateEvent();
                mainForm.ShowDialog();
            }
            if (player.combatHealth >= player.maxcombatHealth)
            {
                progressBar1.Value = player.maxcombatHealth;
            }
            else
            {
                progressBar1.Value = player.combatHealth;
            }
            if (player.combatMana >= player.maxcombatMana)
            {
                progressBar2.Value = player.maxcombatMana;
            }
            else
            {
                progressBar2.Value = player.combatMana;
            }
            if (enemy.Health > enemy.MaxHealth)
            {
                progressBar3.Value = enemy.MaxHealth;
            }
            else
            {
                progressBar3.Value = enemy.Health;
            }
        }
        public void DoEnemy()
        {
            Random random = new Random();
            if (random.Next(1, 3) == 1)
            {
                enemy.EnemyAttack(player);
            }
            else
            {
                enemy.EnemyHeal();
            }
        }
    }
}