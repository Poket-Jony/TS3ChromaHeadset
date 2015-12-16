using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cyotek.Windows.Forms;

namespace TS3ChromaHeadset
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        private TS3Handler ts3Handler = new TS3Handler();

        public FrmMain()
        {
            InitializeComponent();

            InitGui();
            InitTs3();
        }

        private void InitTs3()
        {
            if(!ts3Handler.Connect())
                MessageBox.Show(this, "Can't connect to Teamspeak 3 Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void InitGui()
        {
            togglePoke.Checked = Properties.Settings.Default.activePoke;
            toggleTextMessage.Checked = Properties.Settings.Default.activeTextMessage;

            btnPoke.BackColor = Properties.Settings.Default.colorPoke;
            btnTextMessage.BackColor = Properties.Settings.Default.colorTextMessage;
        }

        private void btnPoke_Click(object sender, EventArgs e)
        {
            ColorPickerDialog colorPicker = new ColorPickerDialog();
            colorPicker.Color = Properties.Settings.Default.colorPoke;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorPoke = colorPicker.Color;
                Properties.Settings.Default.Save();
                InitGui();
            }
        }

        private void btnTextMessage_Click(object sender, EventArgs e)
        {
            ColorPickerDialog colorPicker = new ColorPickerDialog();
            colorPicker.Color = Properties.Settings.Default.colorTextMessage;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorTextMessage = colorPicker.Color;
                Properties.Settings.Default.Save();
                InitGui();
            }
        }

        private void togglePoke_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.activePoke = togglePoke.Checked;
            Properties.Settings.Default.Save();
        }

        private void toggleTextMessage_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.activeTextMessage = toggleTextMessage.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
