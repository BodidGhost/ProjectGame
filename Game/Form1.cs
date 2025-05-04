using Game.Entity;
using Game.Game;
using Game.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Player player;
        public Enemy enemy;
        int number1;
        int number2;
        public Form1(Player player)
        {
            this.player = player;
            InitializeComponent();
            pictureBox2.Image = Image.FromFile(@"../../Image/HomeBackground.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            UpdateStatus();
            UpdateStats();
        }
        public void button1_Click(object sender, EventArgs e)
        {
           
            Enemy enemy = new Enemy(player);
            GameEvent gameEvent = new GameEvent(player, enemy);
            this.Hide();
            UpdateEvent();
            gameEvent.DoEvent(number1, number2);
            UpdateStats();
        }
        public void button3_Click(object sender, EventArgs e)
        {
            SaveLoadService saveLoadService = new SaveLoadService();
            saveLoadService.save(player);
        }
        public void button4_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            this.Hide();
            startMenu.ShowDialog();
        }
        public void UpdateStatus()
        {
            labelName.Text = player.Name;
            switch (player.Playerstatus)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@"../../Image/voin.jpg");
                    labelClass.Text = "Воїн";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"../../Image/knight.jpg");
                    labelClass.Text = "Лицар"; 
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"../../Image/robber.jpg");
                    labelClass.Text = "Розбійник";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(@"../../Image/bowman.png");
                    labelClass.Text = "Лучник";
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(@"../../Image/mage.jpg");
                    labelClass.Text = "Маг";
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(@"../../Image/assassin.jpg");
                    labelClass.Text = "Ассасін";
                    break;

            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void UpdateStats()
        {
            if (player.Health > player.MaxHealth)
            {
                player.Health = player.MaxHealth;
                progressBar1.Value = player.MaxHealth;
            }
            else
            {
                progressBar1.Value = player.Health;
            }
            if (player.Mana > player.MaxMana)
            {
                player.Mana = player.MaxMana;
                progressBar2.Value = player.MaxMana;
            }
            else
            {
                progressBar2.Value = player.Mana;
            }
            label6.Text = player.Level.ToString();
            label7.Text = player.LevelCup.ToString();
            label10.Text = player.Health.ToString();
            label13.Text = player.MaxHealth.ToString();
            label16.Text = player.Mana.ToString();
            label14.Text = player.MaxMana.ToString();
            label20.Text = player.Experience.ToString();
            label18.Text = player.MaxExperience.ToString();
            label22.Text = player.Strength.ToString();
            label24.Text = player.Endurance.ToString();
            label26.Text = player.Agility.ToString();
            label32.Text = player.Intelligence.ToString();
            label30.Text = player.Gold.ToString();
            label28.Text = player.CriticalChance.ToString();
            label41.Text = player.purchases.ToString();
            label35.Text = player.sales.ToString();
            label37.Text = player.wins.ToString();
            label39.Text = player.losses.ToString();
            progressBar1.Maximum = player.MaxHealth;
            progressBar2.Maximum = player.MaxMana;
            progressBar3.Maximum = player.MaxExperience;
            progressBar1.Minimum = 0;
            progressBar2.Minimum = 0;
            progressBar3.Minimum = 0;
            progressBar3.Value = player.Experience;
            label55.Text = player.weapon.NameWeapon.ToString();
            label54.Text = player.weapon.AttackBonusWeapon.ToString();
            label53.Text = player.armor.NameArmor.ToString();
            label52.Text = player.armor.DefenseBonusArmor.ToString();
            label51.Text = player.accessory.NameAccessory.ToString();
            label50.Text = player.accessory.ManaBonusAccessory.ToString();

        }
        public void UpdateEvent()
        {
            int number1 = random.Next(1, 5);
            int number2 = random.Next(1, 11);
            switch (number1)
            {
                case 1:
                    listBox1.Items.Add("Бій!");
                    break;
                case 2:
                    listBox1.Items.Add("Нічого не сталося.");
                    break;
                case 3:
                    switch (number2)
                    {
                        case 1:
                            listBox1.Items.Add("Ви отримало 100 золота.");
                            break;
                        case 2:
                            listBox1.Items.Add("Вам повезло! Ви отримало 500 золота!");
                            break;
                        case 3:
                            listBox1.Items.Add("Ви отримало 100 досвіду.");
                            break;
                        case 4:
                            listBox1.Items.Add("Вам повезло! Ви отримало 500 досвіду!");
                            break;
                        case 5:
                            listBox1.Items.Add("Ви отримало + 1 LevelCup.");
                            break;
                        case 6:
                            listBox1.Items.Add("Ви зцілилися.");
                            break;
                        case 7:
                            listBox1.Items.Add("Ви поновили ману.");
                            break;
                        case 8:
                            listBox1.Items.Add("У вас відняли 5 здоров'я.");
                            break;
                        case 9:
                            listBox1.Items.Add("У вас відняли 100 золота.");
                            break;
                        case 10:
                            listBox1.Items.Add("Вам не повезло! У вас відняли 300 досвіду.");
                            break;
                        }
                    break;
                case 4:
                    listBox1.Items.Add("Магазин.");
                    break;
            }
        }
    }
}
