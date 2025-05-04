using Game.Entity;
using Game.Game;
using Game.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game
{
    public partial class Form1 : Form
    {
        public Player player;
        public Form1(Player player)
        {
            this.player = player;
            InitializeComponent();
            pictureBox2.Image = Image.FromFile("Image/HomeBackground.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            UpdateStatus();
            UpdateStats();
        }
        public void button1_Click(object sender, EventArgs e)
        {
           
            Enemy enemy = new Enemy(player);
            GameEvent gameEvent = new GameEvent(player, enemy);
            this.Hide();
            gameEvent.DoEvent();
            UpdateStats();
        }
        public void button3_Click(object sender, EventArgs e)
        {
            SaveLoadService saveLoadService = new SaveLoadService();
            saveLoadService.save(player);
            MessageBox.Show("Кнопка недоступна. Дочекайтесь наступних обновлень");
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
                    pictureBox1.Image = Image.FromFile("Image/voin.jpg");
                    labelClass.Text = "Воїн";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("Image/knight.jpg");
                    labelClass.Text = "Лицар"; 
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("Image/robber.jpg");
                    labelClass.Text = "Розбійник";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("Image/bowman.png");
                    labelClass.Text = "Лучник";
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("Image/mage.jpg");
                    labelClass.Text = "Маг";
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("Image/assassin.jpg");
                    labelClass.Text = "Ассасін";
                    break;

            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void UpdateStats()
        {
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
            if (player.Health > player.MaxHealth)
            {
                progressBar1.Value = player.MaxHealth;
            }
            else
            {
                progressBar1.Value = player.Health;
            }
            if (player.Mana > player.MaxMana)
            {
                progressBar2.Value = player.MaxMana;
            }
            else
            {
                progressBar2.Value = player.Mana;
            }
            progressBar3.Value = player.Experience;
            switch (player.weapon.IndexWeapon)
            {
                case 1:
                    label44.Text = "Початковий вірень зброї(+ 2 урону)";
                    break;
                case 2:
                    label44.Text = "Середній вірень зброї(+ 4 урону)";
                    break;
                case 3:
                    label44.Text = "Високий вірень зброї(+ 6 урону)";
                    break;
                case 4:
                    label44.Text = "Експертний вірень зброї(+ 10 урону)";
                    break;
                case 5:
                    label44.Text = "Легендарний вірень зброї(+ 20 урону)";
                    break;
                case 6:
                    label44.Text = "Немає зброї";
                    break;
            }
            switch (player.armor.IndexArmor)
            {
                case 1:
                    label46.Text = "Початковий вірень броні(+ 100 здоров'я)";
                    break;
                case 2:
                    label46.Text = "Середній вірень броні(+ 200 здоров'я)";
                    break;
                case 3:
                    label46.Text = "Високий вірень броні(+ 300 здоров'я)";
                    break;
                case 4:
                    label46.Text = "Експертний вірень броні(+ 500 здоров'я)";
                    break;
                case 5:
                    label46.Text = "Легендарний вірень броні(+ 1000 здоров'я)";
                    break;
                case 6:
                    label46.Text = "Немає броні";
                    break;
            }
            switch (player.accessory.IndexAccessory)
            {
                case 1:
                    label47.Text = "Початковий вірень аксесуара(+ 100 мани)";
                    break;
                case 2:
                    label47.Text = "Середній вірень аксесуара(+ 200 мани)";
                    break;
                case 3:
                    label47.Text = "Високий вірень аксесуара(+ 300 мани)";
                    break;
                case 4:
                    label47.Text = "Експертний вірень аксесуара(+ 500 мани)";
                    break;
                case 5:
                    label47.Text = "Легендарний вірень аксесуара(+ 1000 мани)";
                    break;
                case 6:
                    label47.Text = "Немає аксесуара";
                    break;
            }
        }
    }
}
