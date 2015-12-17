using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corale.Colore.Core;
using Corale.Colore.Razer.Headset;
using System.Windows.Forms;
using System.Timers;

namespace TS3ChromaHeadset
{
    internal static class Chroma
    {
        private static bool Debug { get; set; } = false;
        private const int colorTimerInterval = 10000;

        internal static System.Drawing.Color CurrentColor { get; set; } = System.Drawing.Color.White;
        private static bool isColorTimerElapsedInit = false;
        private static System.Timers.Timer colorTimer = new System.Timers.Timer();

        internal static void UpdateChromaColor(System.Drawing.Color color)
        {
            UpdateChromaColor(color, colorTimerInterval);
        }

        internal static void UpdateChromaColor(System.Drawing.Color color, int interval)
        {
            if (colorTimer.Enabled)
                colorTimer.Stop();
            CurrentColor = color;
            if (Debug)
                MessageBox.Show("SetBreathing()");
            else
                Headset.Instance.SetBreathing(Corale.Colore.Core.Color.FromSystemColor(CurrentColor));
            InitColorTimer(interval);
            colorTimer.Start();
        }

        private static void InitColorTimer(int interval)
        {
            colorTimer.Interval = interval;
            if (!isColorTimerElapsedInit)
            {
                colorTimer.Elapsed += ColorTimer_Elapsed;
                isColorTimerElapsedInit = true;
            }
        }

        private static void ColorTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            colorTimer.Stop();
            if (Debug)
                MessageBox.Show("Clear()");
            else
                Headset.Instance.Clear();
        }
    }
}
