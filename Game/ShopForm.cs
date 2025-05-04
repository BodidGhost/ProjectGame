using Game.Entity;
using Game.Game;
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

namespace Game
{
    public partial class ShopForm : Form
    {
        public int number;
        public Player player;

        public ShopForm(Player player)
        {
            this.player = player;

            InitializeComponent();
            Random random = new Random();
            number = random.Next(1 , 4);
            UpdateItem();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(player);
            ShopItemGenerator shopItemGenerator = new ShopItemGenerator(player);
            shopItemGenerator.BuyItem(number, comboBox1.SelectedIndex + 1);
            mainForm.UpdateStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(player);
            ShopItemGenerator shopItemGenerator = new ShopItemGenerator(player);
            shopItemGenerator.SellItem(number);
            label8.Text = player.Gold.ToString();
            mainForm.UpdateStats();
        }
        public void UpdateItem()
        {
            switch (number)
            { 
                case 1:
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Початковий вірень зброї(+ 2 урону)");
                    comboBox1.Items.Add("Середній вірень зброї(+ 4 урону)");
                    comboBox1.Items.Add("Високий вірень зброї(+ 6 урону)");
                    comboBox1.Items.Add("Експертний вірень зброї(+ 10 урону)");
                    comboBox1.Items.Add("Легендарний вірень зброї(+ 20 урону)");
                    switch (player.weapon.IndexWeapon)
                    {
                        case 1:
                            label4.Text = "Початковий вірень зброї(+ 2 урону)";
                            label6.Text = "50";
                            break;
                        case 2:
                            label4.Text = "Середній вірень зброї(+ 4 урону)";
                            label6.Text = "100";
                            break;
                        case 3:
                            label4.Text = "Високий вірень зброї(+ 6 урону)";
                            label6.Text = "150";
                            break;
                        case 4:
                            label4.Text = "Експертний вірень зброї(+ 10 урону)";
                            label6.Text = "200";
                            break;
                        case 5:
                            label4.Text = "Легендарний вірень зброї(+ 20 урону)";
                            label6.Text = "250";
                            break;
                        case 6:
                            label4.Text = "Немає зброї";
                            label6.Text = "0";
                            break;
                    }
                break;
                case 2:
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Початковий вірень броні(+ 100 здоров'я)");
                    comboBox1.Items.Add("Середній вірень броні(+ 200 здоров'я)");
                    comboBox1.Items.Add("Високий вірень броні(+ 300 здоров'я)");
                    comboBox1.Items.Add("Експертний вірень броні(+ 500 здоров'я)");
                    comboBox1.Items.Add("Легендарний вірень броні(+ 1000 здоров'я)");
                    switch (player.armor.IndexArmor)
                    {
                        case 1:
                            label4.Text = "Початковий вірень броні(+ 100 здоров'я)";
                            label6.Text = "50";
                            break;
                        case 2:
                            label4.Text = "Середній вірень броні(+ 200 здоров'я)";
                            label6.Text = "100";
                            break;
                        case 3:
                            label4.Text = "Високий вірень броні(+ 300 здоров'я)";
                            label6.Text = "150";
                            break;
                        case 4:
                            label4.Text = "Експертний вірень броні(+ 500 здоров'я)";
                            label6.Text = "200";
                            break;
                        case 5:
                            label4.Text = "Легендарний вірень броні(+ 1000 здоров'я)";
                            label6.Text = "250";
                            break;
                        case 6:
                            label4.Text = "Немає броні";
                            label6.Text = "0";
                            break;
                    }
                    break;
                case 3:
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Початковий вірень аксесуара(+ 100 мани)");
                    comboBox1.Items.Add("Середній вірень аксесуара(+ 200 мани)");
                    comboBox1.Items.Add("Високий вірень аксесуара(+ 300 мани)");
                    comboBox1.Items.Add("Експертний вірень аксесуара(+ 500 мани)");
                    comboBox1.Items.Add("Легендарний вірень аксесуара(+ 1000 мани)");
                    switch (player.accessory.IndexAccessory)
                    {
                        case 1:
                            label4.Text = "Початковий вірень аксесуара(+ 100 мани)";
                            label6.Text = "50";
                            break;
                        case 2:
                            label4.Text = "Середній вірень аксесуара(+ 200 мани)";
                            label6.Text = "100";
                            break;
                        case 3:
                            label4.Text = "Високий вірень аксесуара(+ 300 мани)";
                            label6.Text = "150";
                            break;
                        case 4:
                            label4.Text = "Експертний вірень аксесуара(+ 500 мани)";
                            label6.Text = "200";
                            break;
                        case 5:
                            label4.Text = "Легендарний вірень аксесуара(+ 1000 мани)";
                            label6.Text = "250";
                            break;
                        case 6:
                            label4.Text = "Немає аксесуара";
                            label6.Text = "0";
                            break;
                    }
                    break;

            }
            label8.Text = player.Gold.ToString();
            switch (comboBox1.SelectedIndex + 1)
            {
                case 1:
                    label11.Text = "100 золота";
                    break;
                case 2:
                    label11.Text = "300 золота";
                    break;
                case 3:
                    label11.Text = "500 золота";
                    break;
                case 4:
                    label11.Text = "800 золота";
                    break;
                case 5:
                    label11.Text = "1200 золота";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(player);
            this.Hide();
            mainForm.UpdateStats();
            mainForm.UpdateEvent();
            mainForm.ShowDialog();
        }
    }
}
