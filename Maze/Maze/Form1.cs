using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        // Plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\ColeE\Documents\Visual Studio 2012\Projects\Maze\DropTheBass.wav");

        // This SoundPlayer plays a sound when the player finishes the game.
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\ColeE\Documents\Visual Studio 2012\Projects\Maze\TheDrop.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_Click(object sender, EventArgs e)
        {

        }

        ///
        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            // Play a sound and display a message box upon reaching the finish label.
            finishSoundPlayer.Play();
            MessageBox.Show("Drop Successful!");
            Close();
        }

        /// <summary>
        /// Play a sound and move the pointer to a point 10 pixels down and to the right 
        /// of the starting point in the upper-left corner of the maze. 
        /// </summary>
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            /// When the cursor hits a wall, move it back to start.
            MoveToStart();
        }
    }
}
