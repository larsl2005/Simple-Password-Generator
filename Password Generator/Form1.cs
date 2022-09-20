using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{  
    public partial class Form1 : Form
    {
        public Random lol = new Random();
        public int lol2;
        public string die;
        public string ll;
        public string seed;
        public int Counter = 0;
        public bool ISDEBUG = false;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(253, 274);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seed = numericUpDown1.Value.ToString();
            ll = null;
            for (int characters = 0; characters < numericUpDown1.Value; characters++)
            {

                lol2 = lol.Next(1, 87/*86*/);
                if(ISDEBUG == true)
                {
                    try
                    {
                        lol2 = lol.Next((int)numericUpDown2.Value, (int)numericUpDown3.Value + 1);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString());
                    }
                }
                convert();
                lolwut();
            }
        }
        void convert()
        {
            seed = seed + " " + lol2.ToString();
            switch (lol2)
            {
                case 1:
                    die = "a";
                    return;
                case 2:
                    die = "A";
                    return;
                case 3:
                    die = "b";
                    return;
                case 4:
                    die = "B";
                    return;
                case 5:
                    die = "c";
                    return;
                case 6:
                    die = "C";
                    return;
                case 7:
                    die = "d";
                    return;
                case 8:
                    die = "D";
                    return;
                case 9:
                    die = "e";
                    return;
                case 10:
                    die = "E";
                    return;
                case 11:
                    die = "?";
                    return;
                case 12:
                    die = "(";
                    return;
                case 13:
                    die = "&";
                    return;
                case 14:
                    die = "f";
                    return;
                case 15:
                    die = "F";
                    return;
                case 16:
                    die = "p";
                    return;
                case 17:
                    die = "P";
                    return;
                case 18:
                    die = "$";
                    return;
                case 19:
                    die = "!";
                    return;
                case 20:
                    die = "0";
                    return;
                case 21:
                    die = "1";
                    return;
                case 22:
                    die = "2";
                    return;
                case 23:
                    die = "3";
                    return;
                case 24:
                    die = "4";
                    return;
                case 25:
                    die = "5";
                    return;
                case 26:
                    die = "6";
                    return;
                case 27:
                    die = "7";
                    return;
                case 28:
                    die = "8";
                    return;
                case 29:
                    die = "9";
                    return;
                case 30:
                    die = "*";
                    return;
                case 31:
                    die = ")";
                    return;
                case 32:
                    die = "<";
                    return;
                case 33:
                    die = ">";
                    return;
                case 34:
                    die = "¬";
                    return;
                case 35:
                    die = ":";
                    return;
                case 36:
                    die = "£";
                    return;
                case 37:
                    die = "]";
                    return;
                case 38:
                    die = "}";
                    return;
                case 39:
                    die = "~";
                    return;
                case 40:
                    die = "{";
                    return;
                case 41:
                    die = "[";
                    return;
                case 42:
                    die = "'";
                    return;
                case 43:
                    die = "#";
                    return;
                case 44:
                    die = "+";
                    return;
                case 45:
                    die = "/";
                    return;
                case 46:
                    die = "g";
                    return;
                case 47:
                    die = "G";
                    return;
                case 48:
                    die = "h";
                    return;
                case 49:
                    die = "H";
                    return;
                case 50:
                    die = "i";
                    return;
                case 51:
                    die = "I";
                    return;
                case 52:
                    die = "j";
                    return;
                case 53:
                    die = "J";
                    return;
                case 54:
                    die = "k";
                    return;
                case 55:
                    die = "K";
                    return;
                case 56:
                    die = "L";
                    return;
                case 57:
                    die = "l";
                    return;
                case 58:
                    die = "n";
                    return;
                case 59:
                    die = "N";
                    return;
                case 60:
                    die = "m";
                    return;
                case 61:
                    die = "M";
                    return;
                case 62:
                    die = "o";
                    return;
                case 63:
                    die = "O";
                    return;
                case 64:
                    die = "q";
                    return;
                case 65:
                    die = "`";
                    return;
                case 66:
                    die = "Q";
                    return;
                case 67:
                    die = "r";
                    return;
                case 68:
                    die = "R";
                    return;
                case 69: //lbao
                    die = "s";
                    return;
                case 70:
                    die = "S";
                    return;
                case 71:
                    die = "t";
                    return;
                case 72:
                    die = "T";
                    return;
                case 73:
                    die = "U";
                    return;
                case 74:
                    die = "u";
                    return;
                case 75:
                    die = "v";
                    return;
                case 76:
                    die = "V";
                    return;
                case 77:
                    die = "w";
                    return;
                case 78:
                    die = "W";
                    return;
                case 79:
                    die = "x";
                    return;
                case 80:
                    die = "X";
                    return;
                case 81:
                    die = "y";
                    return;
                case 82:
                    die = "Y";
                    return;
                case 83:
                    die = "z";
                    return;
                case 84:
                    die = "Z";
                    return;
                case 85:
                    die = "ë";
                    return;
                case 86:
                    die = "Ë";
                    return;
            }
        }
     
        void lolwut()
        {
            ll = ll + die;
            textBox1.Text = ll;
           // textBox2.Text = seed;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(seed != "")
            {
                MessageBox.Show(seed);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //i hope this code is so bad i'm never allowed to work code that saves files ever again.
            button1_Click(sender, e);
            SaveFileDialog fuckingsave = new SaveFileDialog();
            fuckingsave.InitialDirectory = @"Documents";
            fuckingsave.RestoreDirectory = true; //i honestly have no fucking idea what this does
            fuckingsave.FileName = "totally not a password.txt";
            fuckingsave.DefaultExt = "txt";
            //fuckingsave.Filter = "text files (*.txt)";

            if(fuckingsave.ShowDialog() == DialogResult.OK) // i totally did not rip this from stackoverflow
            {
                Stream filestream = fuckingsave.OpenFile();
                StreamWriter sw = new StreamWriter(filestream);

                sw.Write(textBox1.Text);
                sw.Close();
                filestream.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Counter == 10)
            {
                Counter = -2147483647;
                numericUpDown1.Maximum = 2147483647;
                numericUpDown1.Size = new Size(100, 20);
                numericUpDown1.Left = +140;
                label1.Text = "Debug Mode";
                label1.Left = +10;
                ISDEBUG = true;
                MessageBox.Show("Debug mode active", "Message");
                this.Size = new Size(503, 274);
            }
            else
            {
                Counter = Counter + 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //COPY PAAAAAAAAAAASTE
            //i hope this code is so bad i'm never allowed to work code that saves files ever again.
            button1_Click(sender, e);
            SaveFileDialog fuckingsave = new SaveFileDialog();
            fuckingsave.InitialDirectory = @"Documents";
            fuckingsave.RestoreDirectory = true; //i honestly have no fucking idea what this does
            fuckingsave.FileName = "DEBUGGEN.txt";
            fuckingsave.DefaultExt = "txt";
            //fuckingsave.Filter = "text files (*.txt)";

            if (fuckingsave.ShowDialog() == DialogResult.OK) // i totally did not rip this from stackoverflow
            {
                Stream filestream = fuckingsave.OpenFile();
                StreamWriter sw = new StreamWriter(filestream);

                sw.Write(textBox1.Text+"\n"+seed);
                sw.Close();
                filestream.Close();
            }

        }
    }
}
