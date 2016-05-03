using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPlayer
{
    public enum CmdFunc
    {
        Play = 0x000,
        Pause = 0x001,
        Stop = 0x02,
        Fw = 0x03,
        Bw = 0x04,
        Skip = 0x05,
        Prev = 0x06,
        Reserved = 0x07
    }

    public enum CmdFwBwTime {
        t100ms = 0x00,
        t50ms=0x01,
        t20ms=0x02,
        t400ms=0x03
    }

    public enum CmdPlayTime {
        t500ms = 0x00,
        t200ms = 0x01,
        t10ms = 0x02,
        t1s=0x03
    }

    public enum EquFreq {
        Agudos=0x00,
        Medios=0x01,
        Bajos=0x03
    }

    public enum EquOption {
        Aumentar=0x01,
        Disminuir=0x00
    }

    public interface IPlayer
    {
        void SendCmd(CmdFunc func,CmdPlayTime playtime, CmdFwBwTime fwbw);
        void SendEqu(EquFreq frec,EquOption option);
        void SendAlbum(byte actual,byte set);

        event EventHandler<PlayerResponseEventArgs> Response;
    }
}
