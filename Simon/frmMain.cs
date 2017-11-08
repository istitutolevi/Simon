using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Simon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Random _random = new Random();

        private SimonColor[] _sequence = new SimonColor[200];
        private int _sequenceLength = 0;

        private int _playerSequencePosition = 0;

        public void AddColor()
        {
            SimonColor color = (SimonColor)_random.Next(3);
            _sequence[_sequenceLength] = color;
            _sequenceLength++;
        }

        public void PlaySequence()
        {
            for (int index = 0; index < _sequenceLength; index++)
            {
                SimonColor color = _sequence[index];
                PlayColor(color, 1000);
                Thread.Sleep(150);
            }
        }

        private void PlayColor(SimonColor color, int milliseconds)
        {
            switch (color)
            {
                case SimonColor.Blue:
                    HighlightButton(btnBlue, Color.DeepSkyBlue, milliseconds);
                    break;
                case SimonColor.Red:
                    HighlightButton(btnRed, Color.OrangeRed, milliseconds);
                    break;
                case SimonColor.Green:
                    HighlightButton(btnGreen, Color.LimeGreen, milliseconds);
                    break;
                case SimonColor.Yellow:
                    HighlightButton(btnYellow, Color.Yellow, milliseconds);
                    break;
            }
        }

        private void HighlightButton(Button button, Color color, int milliseconds)
        {
            button.BackColor = color;
            Application.DoEvents();
            Thread.Sleep(milliseconds);
            button.BackColor = SystemColors.Control;
            Application.DoEvents();
        }



        private SimonColor GetColorFromButton(Button button)
        {
            if (button == btnRed)
                return SimonColor.Red;
            else if (button == btnBlue)
                return SimonColor.Blue;
            else if (button == btnYellow)
                return SimonColor.Yellow;
            else if (button == btnGreen)
                return SimonColor.Green;
            else
                throw new Exception();
        }

        
        
        
        private void button_Click(object sender, EventArgs e)
        {
            SimonColor color = GetColorFromButton((Button) sender);

            ColorPressed(color);
        }




        private void ColorPressed(SimonColor color)
        {
            EndUserInput();

            if (color != _sequence[_playerSequencePosition])
            {
                BlinkColor(_sequence[_playerSequencePosition]);
                GameOver();
                return;
            }


            PlayColor(color, 700);
            _playerSequencePosition++;

            if (_playerSequencePosition >= _sequenceLength)
            {
                Thread.Sleep(700);
                _playerSequencePosition = 0;
                AddColor();
                PlaySequence();
                StartUserInput();
            }
        }

        private void Start()
        {
            _sequenceLength = 0;
            AddColor();
            PlaySequence();
            StartUserInput();
        }

        private void StartUserInput()
        {
            timer.Enabled = true;
        }

        private void EndUserInput()
        {
            timer.Enabled = false;
        }

        private void GameOver()
        {
            btnStart.Enabled = true;
            timer.Enabled = false;
        }

        private void BlinkColor(SimonColor color)
        {
            for (int i = 0; i < 5; i++)
            {
                PlayColor(color, 200);
                Thread.Sleep(100);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            // E' scaduto il tempo
            // Facciamo lampeggiare il tasto atteso
            BlinkColor(_sequence[_playerSequencePosition]);
            GameOver();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            Start();
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad8:
                    ColorPressed(SimonColor.Green);
                    break;
                case Keys.NumPad6:
                    ColorPressed(SimonColor.Red);
                    break;
                case Keys.NumPad4:
                    ColorPressed(SimonColor.Blue);
                    break;
                case Keys.NumPad2:
                    ColorPressed(SimonColor.Yellow);
                    break;

            }
        }



    }
}
