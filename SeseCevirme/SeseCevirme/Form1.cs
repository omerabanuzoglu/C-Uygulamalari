using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace SeseCevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpVoice SesCevir = new SpVoice();
            SesCevir.Speak(textBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}
