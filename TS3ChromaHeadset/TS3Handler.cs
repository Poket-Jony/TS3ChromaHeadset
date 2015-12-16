using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS3ClientQueryFramework;
using TS3ClientQueryFramework.TS3Models;

namespace TS3ChromaHeadset
{
    internal class TS3Handler
    {
        private TS3Client ts3Client = new TS3Client();

        public bool Connect()
        {
            if (ts3Client.Connect())
            {
                if (ts3Client.CurrentHandlerId != 1)
                    ts3Client.Use(1);
                ts3Client.ClientNotifyRegister(ts3Client.CurrentHandlerId, Notifications.notifyclientpoke);
                ts3Client.ClientNotifyRegister(ts3Client.CurrentHandlerId, Notifications.notifytextmessage);
                ts3Client.Notifier.OnClientPoke += Notifier_OnClientPoke;
                ts3Client.Notifier.OnTextMessage += Notifier_OnTextMessage;
                return true;
            }
            return false;
        }

        public bool Disconnect()
        {
            if (ts3Client.IsConnected())
            {
                return ts3Client.Disconnect();
            }
            return false;
        }

        public void Notifier_OnClientPoke(ClientPoke clientPoke)
        {
            if (Properties.Settings.Default.activePoke)
            {
                Chroma.UpdateChromaColor(Properties.Settings.Default.colorPoke);
            }
        }

        private void Notifier_OnTextMessage(TextMessage textMessage)
        {
            if (Properties.Settings.Default.activeTextMessage)
            {
                Chroma.UpdateChromaColor(Properties.Settings.Default.colorTextMessage);
            }
        }
    }
}
