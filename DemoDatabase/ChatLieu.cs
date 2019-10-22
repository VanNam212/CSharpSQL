using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabase
{
    class ChatLieu
    {
        string MaChatLieu;
        string TenChatLieu;

        public ChatLieu(string maChatLieu, string tenChatLieu)
        {
            MaChatLieu1 = maChatLieu;
            TenChatLieu1 = tenChatLieu;
        }

        public string MaChatLieu1 { get => MaChatLieu; set => MaChatLieu = value; }
        public string TenChatLieu1 { get => TenChatLieu; set => TenChatLieu = value; }
    }
}
