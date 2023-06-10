using System.Windows.Forms;

namespace ButtonJump
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonReLocate(int starPositionX, int startPositionY)
        {
                int newLocationX;
                int newLocationY;
                do
                {
                    newLocationX = this.rnd.Next(0, this.Size.Width - this.button1.Width - 20);
                    newLocationY = this.rnd.Next(0, this.Size.Height - this.button1.Height - 40);
                } while (starPositionX >= newLocationX - 10 &&
                         starPositionX <= newLocationX + this.button1.Width + 10 &&
                         startPositionY >= newLocationY - 10 &&
                         startPositionY <= newLocationY + this.button1.Height + 10);

                this.button1.Location = new Point(newLocationX, newLocationY);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonReLocate(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= this.button1.Location.X - 10 &&
                e.X <= this.button1.Location.X + this.button1.Width + 10 &&
                e.Y >= this.button1.Location.Y - 10 &&
                e.Y <= this.button1.Location.Y + this.button1.Height + 10)
                ButtonReLocate(e.X, e.Y);
        }
    }
}
