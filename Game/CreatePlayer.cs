﻿using Game.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game
{
    public partial class CreatePlayer : Form
    {
        public Player player;
        public CreatePlayer(Player player = null)
        {

            InitializeComponent();
            pictureBox2.Image = Image.FromFile("Image/HomeBackground.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            this.player = new Player(new Weapon(), new Armor(), new Accessory());

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePhoto(player);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я персонажа.");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка, виберіть клас персонажа.");
                return;
            }
            else
            {
                player.Playerstatus = comboBox1.SelectedIndex + 1;
                player.Name = textBox1.Text;
            }
            
            player.weapon.IndexWeapon = 6;
            player.weapon.AttackBonusWeapon = 0;
            player.armor.IndexArmor = 6;
            player.armor.DefenseBonusArmor = 0;
            player.accessory.IndexAccessory = 6;
            player.accessory.ManaBonusAccessory = 0;
            Form1 mainForm = new Form1(player);
            this.Hide();
            mainForm.ShowDialog();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            this.Hide();
            startMenu.ShowDialog();
        }
        public void updatePhoto(Player player)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                pictureBox1.Image = null;
                return;
            }
            switch (comboBox1.SelectedIndex + 1)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("Image/voin.jpg");
                    player.Strength = 5;
                    player.Endurance = 10;
                    player.Agility = 15;
                    player.Intelligence = 5;
                    player.MaxHealth = 10;
                    player.Health = player.MaxHealth;
                    player.MaxMana = 100;
                    player.Mana = player.MaxMana;
                    player.CriticalChance = player.Agility * 0.1;
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("Image/knight.jpg");
                    player.Strength = 12;
                    player.Endurance = 15;
                    player.Agility = 10;
                    player.Intelligence = 6;
                    player.MaxHealth = 20;
                    player.Health = player.MaxHealth;
                    player.MaxMana = 100;
                    player.Mana = player.MaxMana;
                    player.CriticalChance = player.Agility * 0.1;
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("Image/robber.jpg");
                    player.Strength = 8;
                    player.Endurance = 15;
                    player.Agility = 15;
                    player.Intelligence = 3;
                    player.MaxHealth = 70;
                    player.Health = player.MaxHealth;
                    player.MaxMana = 5;
                    player.Mana = player.MaxMana;
                    player.CriticalChance = player.Agility * 0.1;
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("Image/bowman.png");
                    player.Strength = 10;
                    player.Endurance = 20;
                    player.Agility = 15;
                    player.Intelligence = 10;
                    player.MaxHealth = 13;
                    player.Health = player.MaxHealth;
                    player.MaxMana = 120;
                    player.Mana = player.MaxMana;
                    player.CriticalChance = player.Agility * 0.1;
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("Image/mage.jpg");
                    player.Strength = 9;
                    player.Endurance = 8;
                    player.Agility = 10;
                    player.Intelligence = 20;
                    player.MaxHealth = 10;
                    player.Health = player.MaxHealth;
                    player.MaxMana = 200;
                    player.Mana = player.MaxMana;
                    player.CriticalChance = player.Agility * 0.1;
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("Image/assassin.jpg");
                    player.Strength = 8;
                    player.Endurance = 20;
                    player.Agility = 20;
                    player.Intelligence = 3;
                    player.MaxHealth = 8;
                    player.Health = player.MaxHealth;
                    player.MaxMana = 50;
                    player.Mana = player.MaxMana;
                    player.CriticalChance = player.Agility * 0.1;
                    break;

            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}