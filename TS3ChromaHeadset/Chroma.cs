using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corale.Colore.Core;
using Corale.Colore.Razer.Headset;
using System.Windows.Forms;

namespace TS3ChromaHeadset
{
    internal static class Chroma
    {
        private const int colorTimerInterval = 10000;

        internal static System.Drawing.Color CurrentColor { get; set; } = System.Drawing.Color.White;
        private static bool isColorTimerTickInit = false;
        private static Timer colorTimer = new Timer();

        internal static void UpdateChromaColor(System.Drawing.Color color)
        {
            UpdateChromaColor(color, colorTimerInterval);
        }

        internal static void UpdateChromaColor(System.Drawing.Color color, int interval)
        {
            if (colorTimer.Enabled)
                colorTimer.Stop();
            CurrentColor = color;
            Headset.Instance.SetBreathing(Corale.Colore.Core.Color.FromSystemColor(CurrentColor));
            InitColorTimer(interval);
            colorTimer.Start();
        }

        private static void InitColorTimer(int interval)
        {
            colorTimer.Interval = interval;
            if (!isColorTimerTickInit)
            {
                colorTimer.Tick += ColorTimer_Tick;
                isColorTimerTickInit = true;
            }
        }

        private static void ColorTimer_Tick(object sender, EventArgs e)
        {
            colorTimer.Stop();
            Headset.Instance.Clear();
        }
    }
}
