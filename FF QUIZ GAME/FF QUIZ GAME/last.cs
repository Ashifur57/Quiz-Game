using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF_QUIZ_GAME
{
    public partial class last : Form
    {
        public last()
        {
            InitializeComponent();
        }

        private void last_Load(object sender, EventArgs e)
        {
           label2.Text= QUIZ.score;
           label1.Text = startgame.NAME; 
        }
    }
}
