using System;
using System.Collections.Generic;
using System.IO.Ports;
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

    public enum CmdFwBwTime
    {
        t100ms = 0x00,
        t50ms = 0x01,
        t20ms = 0x02,
        t400ms = 0x03
    }

    public enum CmdPlayTime
    {
        t500ms = 0x00,
        t200ms = 0x01,
        t10ms = 0x02,
        t1s = 0x03
    }

    public enum EquFreq
    {
        Agudos = 0x00,
        Medios = 0x01,
        Bajos = 0x03
    }

    public enum EquOption
    {
        Aumentar = 0x01,
        Disminuir = 0x00
    }
    public class SerialPlayer : IPlayer, IDisposable
    {
        SerialPort port;
        public static byte Cmd = 0x26;
        public static byte Equ = 0x66;
        public static byte Album = 0x44;

        public static string[] Ports
        {
            get
            {
                return SerialPort.GetPortNames();
            }
        }


        public SerialPlayer(string serialPort)
        {
            port = new SerialPort(serialPort);
            port.DataReceived += Port_DataReceived;
            port.Open();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string text = port.ReadLine();
            OnResponse(text);
        }

        public void SendAlbum(byte actual, byte set)
        {
            throw new NotImplementedException();
        }

        public void SendCmd(CmdFunc func, CmdPlayTime playtime, CmdFwBwTime fwbw)
        {
            var msg = new SerialPlayerMessage();
            msg.MessageId = Cmd;
            msg.Functionallity = 0x0;
            msg.Functionallity |= (byte)((int)playtime & 0x03);
            msg.Functionallity <<= 2;
            msg.Functionallity |= (byte)((int)fwbw & 0x03);
            msg.Functionallity <<= 2;
            msg.Functionallity |= (byte)((int)func & 0x07);
            SendMessage(msg);
        }

        public void SendEqu(EquFreq frec, EquOption option)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(SerialPlayerMessage message)
        {
            port.Write(message.Bytes, 0, message.Bytes.Length);
        }

        protected void OnResponse(string text)
        {
            PlayerResponseEventArgs e = new PlayerResponseEventArgs();
            e.Text = text;
            if (Response != null)
                Response(this, e);
        }

        public event EventHandler<PlayerResponseEventArgs> Response;


        public void Pause()
        {
            SendCmd(CmdFunc.Pause, default(CmdPlayTime), default(CmdFwBwTime));
        }

        public void Play()
        {
            SendCmd(CmdFunc.Play, default(CmdPlayTime), default(CmdFwBwTime));
        }

        public void Prev()
        {
            SendCmd(CmdFunc.Prev, default(CmdPlayTime), default(CmdFwBwTime));
        }
        public void Skip()
        {
            SendCmd(CmdFunc.Skip, default(CmdPlayTime), default(CmdFwBwTime));
        }

        public void Stop()
        {
            SendCmd(CmdFunc.Stop, default(CmdPlayTime), default(CmdFwBwTime));
        }

        public void Dispose()
        {
            port.Close();
            port.Dispose();
        }
    }
}
