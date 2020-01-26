using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiTleRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RandomStrings_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            StringBuilder builder = new StringBuilder();
            int num = 1;
            do
            {
                int StartIndex = random.Next(0, 30);
                builder.Append("abcedfghidjkmlnop1234567890!@#$%^&*þЯäßρ®ØŦ∑¢ŦOя".Substring(StartIndex, 1));
                num += 1;
            }
            while ((num <= 10));
            this.Text = builder.ToString();
        }
        
    }
}
