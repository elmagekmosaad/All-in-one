#region Settings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion
/// <summary>
/// Source / Tutorial : https://www.youtube.com/watch?v=ReA_SuPD7cU
/// </summary>
namespace GenerateSerialKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generate button
            SKGL.Generate generate = new SKGL.Generate();
            generate.secretPhase = txtPassword.Text;
            txtSerial.Text = generate.doKey(Convert.ToInt32(txtDay.Text));
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            // Valid Button
            SKGL.Validate valide = new SKGL.Validate();
            valide.secretPhase = txtPassword.Text;
            valide.Key = txtSerial.Text;
            txtStatus.Text = "Create Date:" + valide.CreationDate + "\r\n" + "ExpireDate:" + valide.ExpireDate + "\r\n" + "DayLeft:" + valide.DaysLeft;
        }
    }
}
