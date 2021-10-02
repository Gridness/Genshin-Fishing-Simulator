using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ribalka228
{
    public partial class Main : Form
    {
        int prX, prY, prH, prW;

        int _minZone, _maxZone;
        int _positionShiftInterval, _zoneShiftInterval;
        int _dotMS;

        Timer positionClock, zoneClock, dotMoveClock, posCompareClock;

        Random rnd = new Random();

        bool gameStarted = false;

        public Main()
        {
            InitializeComponent();

            dotMS.Text = "0";
            positionShiftInterval.Text = "0";
            zoneShiftInterval.Text = "0";
        }

        private void InitializeTimer()
        {
            positionClock = new Timer();
            zoneClock = new Timer();
            dotMoveClock = new Timer();
            posCompareClock = new Timer();

            positionClock.Interval = _positionShiftInterval;
            zoneClock.Interval = _zoneShiftInterval;
            dotMoveClock.Interval = 1000;
            posCompareClock.Interval = 1;

            positionClock.Tick += new EventHandler(positionClockTick);
            zoneClock.Tick += new EventHandler(zoneClockTick);
            dotMoveClock.Tick += new EventHandler(moveDotClockTick);
            posCompareClock.Tick += new EventHandler(posCompareClockTick);

            positionClock.Start();
            zoneClock.Start();
            dotMoveClock.Start();
            posCompareClock.Start();
        }

        private void posCompareClockTick(object sender, EventArgs e)
        {
            comparePositions();
        }

        private void stopTimers()
        {
            positionClock.Stop();
            zoneClock.Stop();
            dotMoveClock.Stop();
            posCompareClock.Stop();
        }

        private void moveDotClockTick(object sender, EventArgs e)
        {
            moveDot(_dotMS);
        }

        private void zoneClockTick(object sender, EventArgs e)
        {
            changeZone(_minZone, _maxZone);
        }

        private void positionClockTick(object sender, EventArgs e)
        {
            changePosition();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                prX = prjamougolnik.Location.X;
                prY = prjamougolnik.Location.Y;
                prH = prjamougolnik.Size.Height;
                prW = prjamougolnik.Size.Width;

                gameStarted = true;
                startButton.Text = "Stop";
                prjamougolnik.Visible = true;
                fishingDot.Visible = true;
                fishButton.Visible = true;
                comparisonLabel.Visible = true;

                minZone.Enabled = false;
                maxZone.Enabled = false;
                positionShiftInterval.Enabled = false;
                zoneShiftInterval.Enabled = false;
                dotMS.Enabled = false;

                InitializeTimer();
            }
            else
            {
                gameStarted = false;
                startButton.Text = "Start";
                prjamougolnik.Visible = false;
                fishingDot.Visible = false;
                fishButton.Visible = false;
                comparisonLabel.Visible = false;

                minZone.Enabled = true;
                maxZone.Enabled = true;
                positionShiftInterval.Enabled = true;
                zoneShiftInterval.Enabled = true;
                dotMS.Enabled = true;

                dropProperties(prX, prY, prH, prW);
                stopTimers();
            }
        }

        private void minZone_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(minZone.Text, out _minZone);
            checkDistance(_minZone, _maxZone);
        }

        private void maxZone_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(maxZone.Text, out _maxZone);
            checkDistance(_minZone, _maxZone);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // hueta ne nuzjnaja
        }

        private void positionShiftInterval_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(positionShiftInterval.Text, out _positionShiftInterval);
        }

        private void zoneShiftInterval_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(zoneShiftInterval.Text, out _zoneShiftInterval);
        }

        private void rndButton_Click(object sender, EventArgs e)
        {
            var fishingDotX = fishingDot.Location.X;
            var fishingDotY = fishingDot.Location.Y;

            fishingDotX += _dotMS * 2;

            fishingDot.Location = new Point(fishingDotX, fishingDotY);
        }

        private void checkDistance(int _minZone, int _maxZone)
        {
            if(_minZone >= _maxZone)
            {
                distanceError.Visible = true;
                startButton.Enabled = false;
                startButton.Text = "ТЫ ЕБЛАН, ЧЕЕЛ";
                startButton.ForeColor = Color.Red;
            } else
            {
                distanceError.Visible = false;
                startButton.Enabled = true;
                startButton.Text = "Start";
                startButton.ForeColor = Color.Black;
            }

            checkMinValue(_minZone);
        }

        private void checkMinValue(int minValue)
        {
            if(minValue < 15)
            {
                startButton.Enabled = false;
            }
        }

        private void fishingBar_Click(object sender, EventArgs e)
        {

        }

        private void dotMS_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(dotMS.Text, out _dotMS);
        }

        private void patternLabel_Click(object sender, EventArgs e)
        {

        }

        private void fishingDot_Click(object sender, EventArgs e)
        {

        }

        private void changePosition()
        {
            var prX = prjamougolnik.Location.X;
            var prY = prjamougolnik.Location.Y;

            prX = rnd.Next(fishingBar.Location.X, fishingBar.Location.X + fishingBar.Size.Width - prjamougolnik.Size.Width);
            prjamougolnik.Location = new Point(prX, prY);
        }

        private void changeZone(int _minZone, int _maxZone)
        {
            var sizePIDOORX = prjamougolnik.Size.Width;
            var sizePIDOORY = prjamougolnik.Size.Height;

            sizePIDOORX = rnd.Next(_minZone, _maxZone);
            prjamougolnik.Size = new Size(sizePIDOORX, sizePIDOORY);
        }

        private void dropProperties(int x, int y, int height, int width)
        {
            prjamougolnik.Location = new Point(x, y);
            prjamougolnik.Size = new Size(width, height);
        }

        private void moveDot(int MS)
        {
            var fishingDotX = fishingDot.Location.X;
            var fishingDotY = fishingDot.Location.Y;
            
            if(fishingDotX >= fishingBar.Location.X && fishingDotX <= fishingBar.Location.X + fishingBar.Size.Width - fishingDot.Size.Width)
                fishingDotX -= MS;

            fishingDot.Location = new Point(fishingDotX, fishingDotY);
        }

        private void comparePositions()
        {
            if(fishingDot.Location.X >= prjamougolnik.Location.X && fishingDot.Location.X <= prX + prjamougolnik.Size.Width - fishingDot.Size.Width)
            {
                comparisonLabel.Text = "Нихуя ты гений";
                comparisonLabel.ForeColor = Color.Green;
            } else
            {
                comparisonLabel.Text = "Слабоват";
                comparisonLabel.ForeColor = Color.Red;
            }
        }
    }
}
