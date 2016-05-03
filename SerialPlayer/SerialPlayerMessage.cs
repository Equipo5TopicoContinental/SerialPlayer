using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPlayer
{
    public class SerialPlayerMessage
    {
        public byte Functionallity { get; set; }

        public byte MessageId { get; set; }

        public byte Checksum
        {
            get
            {
                return (byte)( MessageId ^ Functionallity);
            }
        }

        public byte[] Bytes {
            get { return new byte[] { MessageId, Functionallity, Checksum }; }
        }
    }
}
