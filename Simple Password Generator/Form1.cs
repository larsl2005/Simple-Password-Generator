using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Password_Generator
{
    public partial class PasswordGen : Form
    {
        const string charsNormal = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
        const string charsSpecial = "`~-=_+!@#$€%^&*()[]{}:;\"',.<>/?\\|¬£";
        const string charsSpecial2 = "ëËăēīčŵâùẁỳ";
        public PasswordGen()
        {
            InitializeComponent();
        }

        private void Gen_Click(object sender, EventArgs e)
        {
            Generate();
        }

        void Generate()
        {
            System.Random ran = new System.Random();
            string Output = "";
            string ToPickFrom = charsNormal;
            
            if(Special1.Checked) { ToPickFrom = ToPickFrom + charsSpecial; }
            if(Special2.Checked) { ToPickFrom = ToPickFrom + charsSpecial2; }

            for (int i = 0; i < Int32.Parse(PassLength.Value.ToString()); i++)
            {
                Output = Output + ToPickFrom.Substring(ran.Next(0,ToPickFrom.Length),1);
            }
            PassResult.Text = Output;
        }

        private void Gen2File_Click(object sender, EventArgs e)
        {
            Generate();
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.InitialDirectory = @"Documents";
            SaveDialog.RestoreDirectory = true;
            SaveDialog.FileName = "Not A Password.txt";
            SaveDialog.DefaultExt = "txt";

            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                Stream filestream = SaveDialog.OpenFile();
                StreamWriter sw = new StreamWriter(filestream);

                sw.Write(PassResult.Text);
                sw.Close();
                filestream.Close();
            }
        }
    }
}
