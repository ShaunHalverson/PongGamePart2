using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void trollFaceCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\Shaun\Videos\VideoOverlay\Memes\Troll Face.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void mogCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\Shaun\Videos\VideoOverlay\Memes\MOG.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void noCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\Shaun\Videos\VideoOverlay\Memes\No.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void foreverAloneCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\Shaun\Videos\VideoOverlay\Memes\ForeverAlone.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }
    }
}
