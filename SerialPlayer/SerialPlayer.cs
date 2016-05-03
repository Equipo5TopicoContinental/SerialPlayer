using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPlayer
{
    public class SerialPlayer : IPlayer
    {
        public event EventHandler<PlayerResponseEventArgs> Response;

        public void SendAlbum(byte actual, byte set)
        {
            throw new NotImplementedException();
        }

        public void SendCmd(CmdFunc func, CmdPlayTime playtime, CmdFwBwTime fwbw)
        {
            throw new NotImplementedException();
        }

        public void SendEqu(EquFreq frec, EquOption option)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(SerialPlayerMessage message) {
            throw new NotImplementedException();
        }


    }
}
