using Game.Entity;
using Game.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Game
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {

            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"../../Image/MenuBackground.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            CreatePlayerForm  createPlayer = new CreatePlayerForm();
            this.Hide();
            createPlayer.ShowDialog();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            SaveLoadService saveLoadService = new SaveLoadService();
            Player player = saveLoadService.load();
            if (player != null)
            {
                Form1 form1 = new Form1(player);
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас немає збереженого гравця!");
            }
        }
    }
}
